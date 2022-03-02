using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ActivationMessage : MonoBehaviour
{

    [SerializeField] Text text;
    // Start is called before the first frame update
    bool q = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (q)
        {
            //Debug.Log(new Vector3(0, Camera.main.transform.eulerAngles.x + 90, 0));
            Camera.main.transform.eulerAngles = Vector3.Lerp(Camera.main.transform.eulerAngles, new Vector3(0, Camera.main.transform.eulerAngles.y + 90, 0), Time.deltaTime * 1);
        }
    }

    public void GunMessageOn()
    {
        text.text = "GUN";

        Debug.Log("gun");
    }
    public void GunMessageOff()
    {

        text.text = "  ";
        Debug.Log("dec");

    }
    public void ThumbsUpMessageOn()
    {
        text.text = "ThumbsUp";

        Debug.Log("thumb");
    }
    public void ThumbsUpMessageOff()
    {

        text.text = "  ";

    }

    public void ChopMessageOn()
    {
        text.text = "Chop";

        Debug.Log("Chop");
    }
    public void ChopMessageOff()
    {

        text.text = "  ";

    }
    public void ClapMessageOn()
    {
        text.text = "Clap";

        Debug.Log("Clap");
    }
    public void ClapMessageOff()
    {

        text.text = "  ";

    }
    public void PeaceMessageOn()
    {
        text.text = "Peace";

        Debug.Log("peace");
    }
    public void PeaceMessageOff()
    {

        text.text = "  ";

    }
    public void turnRight()
    {
        q = true;
    }
    public void turnRightOff()
    {
        q = false;
    }
}
