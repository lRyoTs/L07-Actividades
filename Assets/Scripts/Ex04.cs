using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex04 : MonoBehaviour
{
    public int numRepeat = 10;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ChangePos());
    }

    //Coroutine that change GameObject a give number of times every 2 seconds
    private IEnumerator ChangePos(){
        for (;numRepeat > 0 ;numRepeat--) {
            yield return new WaitForSeconds(2);
            transform.position = RandomPosition();
        }
        
    }

    //Function that gives a random position
    private Vector3 RandomPosition() {
        float posX = Random.Range(-3f, 4f);
        float posZ = Random.Range(-3f, 4f);
        float posY = Random.Range(-3f, 4f);

        return new Vector3(posX, posY, posZ);
    }
}
