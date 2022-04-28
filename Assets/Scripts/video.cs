using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
public class video : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    bool check;
    [SerializeField] VideoPlayer v;
    void Start()
    {
        if (check)
        v.loopPointReached += EndReached;
        else
            v.loopPointReached += EndReached1;
    }

    void EndReached(UnityEngine.Video.VideoPlayer vp)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(5);
    }
    void EndReached1(UnityEngine.Video.VideoPlayer vp)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }
}
