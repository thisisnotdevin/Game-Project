using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallonGrowth : MonoBehaviour
{
    public float timer = 0f;
    public float growTime = 6f;
    public float maxSize = 2f;

    public bool isMaxSize = false;

    void Start()
    {
       if(isMaxSize == false){
           StartCoroutine(Grow());
       } 
    }

    private IEnumerator Grow()
    {
        Vector2 startScale = transform.localScale;
        Vector2 maxScale = new Vector2(maxSize, maxSize);

        do
        {
            //Grow, increment timer
            transform.localScale = Vector3.Lerp(startScale, maxScale, timer / growTime);
            timer += Time.deltaTime;
            yield return null;

        } while (timer < growTime);

        isMaxSize = true;
    }

   

}
