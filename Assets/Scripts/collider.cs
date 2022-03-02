using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class collider : MonoBehaviour
{
    int count = 0;
    [SerializeField]
    GameObject[] arr;
    // Start is called before the first frame update
    [SerializeField]
    GameObject cam;
    [SerializeField]
    GameObject list;
    [SerializeField]
    GameObject icon;
    [SerializeField]
    bool left;
   
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("food"))
        {
            if (GameObject.Find("Engine").GetComponent<engineScript>().chosen != null)
            {
                if (!String.Equals(other.gameObject.name, GameObject.Find("Engine").GetComponent<engineScript>().chosen.gameObject.name)
                    && !String.Equals(other.gameObject.name, GameObject.Find("Engine").GetComponent<engineScript>().chosen1.gameObject.name)
                    && !String.Equals(other.gameObject.name, GameObject.Find("Engine").GetComponent<engineScript>().chosen2.gameObject.name ))
                {
                    GameObject.Find("Engine").GetComponent<engineScript>().Health -= 1;

                }
            }
            Destroy(other.gameObject);      
        }

        if (other.gameObject.CompareTag("next"))
        {
            cam.GetComponent<CameraController>().loop();
        }

     
        /*
        if (other.gameObject.CompareTag("food"))
        {
            Destroy(other.gameObject);
            Debug.Log(GameObject.Find("Engine").GetComponent<Engine>().oneN );
            Debug.Log(GameObject.Find("Engine").GetComponent<Engine>().twoN);
            Debug.Log(GameObject.Find("Engine").GetComponent<Engine>().threeN);
            Debug.Log(other.gameObject.name);
            if (!(other.gameObject.name.Equals( GameObject.Find("Engine").GetComponent<Engine>().oneN)||
               other.gameObject.name.Equals( GameObject.Find("Engine").GetComponent<Engine>().twoN)||
               other.gameObject.name.Equals( GameObject.Find("Engine").GetComponent<Engine>().threeN)))
            {
                arr[count].SetActive(true);
                count = count + 1;
            }
        }*/
    }

    private void OnCollisionStay(Collision other)
    {
        if (other.gameObject.CompareTag("test") && left)
        {
            list.SetActive(true);
            icon.SetActive(false);
        }

    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("test") && left)
        {
            list.SetActive(false);
            icon.SetActive(true);
        }
    }



}
