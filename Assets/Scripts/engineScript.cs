using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class engineScript : MonoBehaviour
{
    // Start is called before the first frame update
    List<GameObject> gameobjectList;
    public GameObject chosen,chosen1,chosen2;
    [SerializeField]
    Text text;
    [SerializeField]
    Text text2;
    [SerializeField]
    Text text3;
    public int Health = 3;
    [SerializeField]
     GameObject heart;
    [SerializeField]
    GameObject heart2;
    [SerializeField]
    GameObject heart3;

    void Awake()
    {
        gameobjectList = new List<GameObject>(GameObject.FindGameObjectsWithTag("food"));

        gameobjectList = shuffle(gameobjectList);

        chosen = gameobjectList[0];
        chosen1 = gameobjectList[1];
        chosen2 = gameobjectList[2];
        text.text = chosen.name;
        text2.text = chosen1.name;
        text3.text = chosen2.name;
    }

    
    List<GameObject> shuffle(List<GameObject> a)
    {


        for (int i = 0; i < a.Count; i++)
        {
            GameObject temp = a[i];
            int randomIndex = Random.Range(i, a.Count);
            a[i] = a[randomIndex];
            a[randomIndex] = temp;
        }
        return a;


    }
    void Update()
    {
        gameobjectList = gameobjectList.Where(item => item != null).ToList();
        if(chosen == null  && chosen1 == null && chosen2 == null)
        {
            SceneManager.LoadScene(2);
        }
        if (chosen == null) {
            text.text = "";
        }
        if (chosen1 == null)
        {
            text2.text = "";
        }
        if (chosen2 == null)
        {
            text3.text = "";
        }


        if (Health > 3)
        {
            Health = 3;
        }
        if(Health < 0)
        {
            Health = 0;
           
        }
        switch (Health)
        {
            case 3:
                heart.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(true);
                break;
            case 2:
                heart.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(false);
                break;
            case 1:
                heart.gameObject.SetActive(true);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                break;
            case 0:
                heart.gameObject.SetActive(false);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                SceneManager.LoadScene(4);
                StartCoroutine(  Wait(2));

                break;


        }

        IEnumerator Wait(int i)
        {
            yield return new WaitForSeconds(i);
            SceneManager.LoadScene(1);
        }
    }
}
