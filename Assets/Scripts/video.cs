using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
public class video : MonoBehaviour
{
    // Start is called before the first frame update


    [SerializeField] VideoPlayer v;
    void Start()
    {

        v.loopPointReached += EndReached;

    }

    void EndReached(UnityEngine.Video.VideoPlayer vp)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }
}
