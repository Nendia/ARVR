using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEditor;
using System.IO;


[System.Serializable]
public class MyRatEvent : UnityEvent<string>
{
}

[Serializable]
public struct Gesture
{
    public string name;
    public List<Vector3> fingerDatas;
    public MyRatEvent onRecognized;
    public List<Quaternion> fingerAngles;
}

public class GestureDetector : MonoBehaviour
{
    public float threshold = 0.1f;
    public OVRSkeleton skeleton;
    public List<Gesture> gestures;
    public bool debugMode = true;
    public MyRatEvent toRecognize;
    public bool saveNow;
    public string json;
    public string participantID;
    public bool readNow;

    private List<OVRBone> fingerBones;
   // private Gesture previousGesture;
    private bool hasStarted = false;

    // Start is called before the first frame update
    void Start()
    {
        //previousGesture = new Gesture();

        // When the Oculus hand had his time to initialize hand, with a simple coroutine i start a delay of
        // a function to initialize the script
        StartCoroutine(DelayRoutine(2.5f, Initialize));
    }

    // Coroutine used for delay some function
    public IEnumerator DelayRoutine(float delay, Action actionToDo)
    {
        yield return new WaitForSeconds(delay);
        actionToDo.Invoke();
    }

    public void Initialize()
    {
        // Check the function for know what it does
        SetSkeleton();

        // After initialize the skeleton set a boolean to true to confirm the initialization
        hasStarted = true;
    }

    public void SetSkeleton()
    {
        // Populate the private list of fingerbones from the current hand we put in the skeleton
        fingerBones = new List<OVRBone>(skeleton.Bones);
    }

    // Update is called once per frame
    void Update()
    {
        if(readNow == true){
            readNow = false;
            ReadString();
        }
        if (saveNow == true)
        {
            saveNow = false;
            SaveToFile();   
        }

        if(debugMode && Input.GetKeyDown(KeyCode.Space))
        {
            Save("new Gesture");
        }
        if (fingerBones == null)
        { 
            return; 
        }
        Gesture currentGesture = Recognize();
        bool hasRecognized = !currentGesture.Equals(new Gesture()); // ist false, wenn es ein neue Geste ist
        // Check if new gesture 
        if (hasRecognized) // && !currentGesture.Equals(previousGesture))
        {
            //New Gesture!!
            //Debug.Log("New Gesture Found : " + currentGesture.name);
            //previousGesture = currentGesture;
            currentGesture.onRecognized.Invoke(currentGesture.name);
        }
        else
        {
            //Debug.Log("New Gesture Found : " + "nix");
            toRecognize.Invoke("wartend");
        }
    }

    /*void Save()
    {
        Gesture g = new Gesture();
        g.name = "New Gesture";
        List<Vector3> data = new List<Vector3>();
        int i = 0;
        foreach (OVRBone bone in fingerBones)
        {
            i++;
            //finger position relative to root
            Debug.Log(bone.Id);
            data.Add(skeleton.transform.InverseTransformPoint(bone.Transform.position));
        }
        Debug.Log(i);
        g.fingerDatas = data;
        gestures.Add(g);
    }*/

    public Gesture? Save(String bewegungsname)
    {
        if (fingerBones.Count >= 24)
        {
            Gesture g = new Gesture();
            g.name = bewegungsname;
            List<Vector3> data = new List<Vector3>();
            List<Quaternion> dataR = new List<Quaternion>();
            List<OVRBone> dataB = new List<OVRBone>();
            int i = 0;
            foreach (OVRBone bone in fingerBones)
            {
                i++;
                //finger position relative to root
                data.Add(skeleton.transform.InverseTransformPoint(bone.Transform.position));
                dataR.Add(bone.Transform.rotation);
                dataB.Add(bone);
            }
            g.fingerDatas = data;
            g.fingerAngles = dataR;
            g.onRecognized = toRecognize;
            gestures.Add(g);
            return g;
        }
        Initialize();
        return null;
        }


        Gesture Recognize()
    {
            Gesture currentgesture = new Gesture();
            float currentMin = Mathf.Infinity;
            foreach (var gesture in gestures)
            {
                float sumDistance = 0;
                bool isDiscarded = false;
                for (int i = 0; i < fingerBones.Count; i++)
                {
                    Vector3 currentData = skeleton.transform.InverseTransformPoint(fingerBones[i].Transform.position);
                    float distance = Vector3.Distance(currentData, gesture.fingerDatas[i]);
                    if (distance > threshold)
                    {
                        isDiscarded = true;
                        break;
                    }
                    sumDistance += distance;
                }
                if (!isDiscarded && sumDistance < currentMin)
                {
                    currentMin = sumDistance;
                    currentgesture = gesture;
                }
            }
            return currentgesture;
    }

    public void SaveToFile()
    {
        json = Newtonsoft.Json.JsonConvert.SerializeObject(gestures, Newtonsoft.Json.Formatting.Indented, new Newtonsoft.Json.JsonSerializerSettings
        {
            ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
        });
        Debug.Log(json);
        WriteString();


    }

//    [MenuItem("Tools/Write file")]
    void WriteString()

    {
        string path = "Assets/Resources/"+participantID+".txt";

        //Write some text to the test.txt file

        StreamWriter writer = new StreamWriter(path, true);

        writer.WriteLine(json);

        writer.Close();

        //Re-import the file to update the reference in the editor

        //AssetDatabase.ImportAsset(path);

        //TextAsset asset = (TextAsset)Resources.Load(json);

        //Print the text from the file

        //Debug.Log(asset.text);

    }

//    [MenuItem("Tools/Read file")]

    void ReadString()

    {

        string path = "Assets/Resources/" + participantID + ".txt";

        //Read the text from directly from the test.txt file

        StreamReader reader = new StreamReader(path);

        Debug.Log(reader.ReadToEnd());

        reader.Close();

    }

}
