using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private int numBottles = 50; //number 
    // Start is called before the first frame update
    void Start()
    {

        while (numBottles-- >= 0) {

            if (numBottles > 0)
            {
                Debug.Log($"{numBottles} bottle of beer on the wall, {numBottles} bottles of beer.");
            }
            else if (numBottles == 0) {
                Debug.Log($"No more bottle of beer on the wall, no more bottles of beer.");
            }

            if (numBottles-1 > 0)
            {
                Debug.Log($"Take one down and pass it around, {numBottles-1} bottles of beer on the wall.");
            }
            else if (numBottles-1 == 0)
            {
                Debug.Log($"Take one down and pass it around, no more bottles of beer on the wall.");
            }
            else if(numBottles-1 == -1)
            {
                Debug.Log($"Go to the store and buy some more, 99 bottles of beer on the wall.");
            }

        }
    }
}
