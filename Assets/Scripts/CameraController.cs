using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    Transform[] views;
    [SerializeField]
    float transitionSpeed;

    public CameraShake cameraShake;

    Transform currentView;
    bool check = true;
    bool yes = false;
    int counter = 0;
    void Start()
    {
        
    }
    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Q) && check)
        {

            StartCoroutine(Shake(0.2f));
            StartCoroutine(changeAfterTime(0.5f, views[0]));

            StartCoroutine(ExecuteAfterTime(2f, views[1]));

        }
        if (Input.GetKeyDown(KeyCode.W) && check)
        {

            StartCoroutine(Shake(0.2f));
            StartCoroutine(changeAfterTime(0.5f, views[2]));

            StartCoroutine(ExecuteAfterTime(2f, views[3]));
        }
       /* if (Input.GetKeyDown(KeyCode.E) && check)
        {
            StartCoroutine(Shake(0.5f));
            StartCoroutine(changeAfterTime(0.5f, views[4]));
            
            StartCoroutine(ExecuteAfterTime(2f, views[5])); 
        }*/
        if (Input.GetKeyDown(KeyCode.E) && check)
        {
            StartCoroutine(Shake(0.2f));
            StartCoroutine(changeAfterTime(0.5f, views[6]));

            StartCoroutine(ExecuteAfterTime(2f, views[7]));
        }
        if (Input.GetKeyDown(KeyCode.X) && check)
        {
          
        }


    }

   
    
   /* public void loop()
    {
        if (check && counter == 0)
        {

            currentView = views[0];
            StartCoroutine(ExecuteAfterTime(1, views[1]));
            counter++;
        }
        if (check && counter == 1)
        {
            currentView = views[2];
            StartCoroutine(ExecuteAfterTime(1, views[3]));
            counter++;
        }
        if (check && counter == 2)
        {
            currentView = views[4];
            StartCoroutine(ExecuteAfterTime(1, views[5]));
            counter++;
        }
        if (check && counter == 3)
        {
            currentView = views[6];
            StartCoroutine(ExecuteAfterTime(1, views[7]));

            counter = 0;
        }
    } */
        IEnumerator ExecuteAfterTime(float time,Transform vector)
        {

          
         

            yield return new WaitForSeconds(time);
            currentView = vector;
            StartCoroutine(lerpTransition());
            check = true;
           
           

        }
        IEnumerator changeAfterTime(float time, Transform vector)
        {


            //yield return new WaitForSeconds(time);

            //yield return new WaitForSeconds(time);
            currentView = vector;
                //transition();

            Vector3 originalPos = transform.position;

            float elapsed = 0.0f;
            
            while (elapsed < 1f)
            {

               
                

                transform.position =  Vector3.Lerp(originalPos,currentView.position, (elapsed/ 0.5f) );

                elapsed += Time.deltaTime;

                yield return null;
            }
                

            transform.position = currentView.position;

      

    }
        IEnumerator Shake(float duration)
        {
            check = false;

            Vector3 originalPos = transform.eulerAngles;

            float elapsed = 0.0f;

            while (elapsed < duration)
            {
                    
                float z = Random.Range(originalPos.z - 5   , originalPos.z + 5) ;
                //float y = Random.Range(-1f, 1f) * magnitude;
            
                transform.eulerAngles = new Vector3(originalPos.x , originalPos.y , z);

                elapsed += Time.deltaTime;

                yield return null;
            }

            
             transform.eulerAngles = originalPos;

        }
        void transition()
        {
        transform.position = currentView.position;
        transform.eulerAngles = currentView.transform.eulerAngles;
        }
        IEnumerator lerpTransition()
        {
        float elapsedTime = 0;
        float waitTime = 1f;
            while (elapsedTime < waitTime)
            {
             
                transform.position = Vector3.Lerp(transform.position, currentView.position, (elapsedTime/waitTime));
                Vector3 currentAngle = new Vector3(
                  Mathf.LerpAngle(transform.rotation.eulerAngles.x, currentView.transform.rotation.eulerAngles.x, (elapsedTime / waitTime) ),
                  Mathf.LerpAngle(transform.rotation.eulerAngles.y, currentView.transform.rotation.eulerAngles.y, (elapsedTime / waitTime) ),
                  Mathf.LerpAngle(transform.rotation.eulerAngles.z, currentView.transform.rotation.eulerAngles.z, (elapsedTime / waitTime) ) );
                
                
                transform.eulerAngles = currentAngle;
            elapsedTime += Time.deltaTime;
                
                yield return null;
            }
        transform.position = currentView.position;
        transform.eulerAngles = currentView.eulerAngles;
        }

}
