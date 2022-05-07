using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio : MonoBehaviour
{
    private static audio _instance;

    public static audio instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType<audio>();

                DontDestroyOnLoad(_instance.gameObject);
            }

            return _instance;
        }
    }
    // Start is called before the first frame update
    void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            if (this != _instance)
                Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
