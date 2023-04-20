using UnityEngine;
using System.IO.Ports;
using UnityEngine.SceneManagement;

public class InputData : MonoBehaviour
{
    SerialPort myConnection = new SerialPort("COM8", 115200);
    public string incomingData;
    public string[] values;
    public float btn;
    public float dis;

    void Start()
    {
        myConnection.Open();   
    }

    void Update()
    {
        incomingData = myConnection.ReadLine();
        values = incomingData.Split(',');

        if(values.Length == 2)
        {
            foreach(string value in values)
            {
                //Convert the string to float
                Debug.Log(float.Parse(value));
            }

            Debug.Log("--------------------------");

            btn = float.Parse(values[0]);
            dis = float.Parse(values[1]);
        }

        if (btn == 1){
            SceneManager.LoadScene(0);
        }
    }
}
