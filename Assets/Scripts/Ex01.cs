using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex01 : MonoBehaviour
{
    public GameObject cube; //The cube
    public int numberCubes = 3; //Number of cubes to instantiate
    private float maxScale = 2.5f;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numberCubes; i++) {
            SpawnCube();
        }
    }

    //Function that gives a random position
    private Vector3 RandomPos() {
        float randX = Random.Range(-8,9);
        float randY = Random.Range(-3, 4);
        float randZ = Random.Range(0, 6);

        return new Vector3(randX, randY, randZ);
    }

    //FUnction that gives a random Scale
    private Vector3 RandomScale()
    {
        float randX = Random.Range(0.5f, maxScale);
        float randY = Random.Range(0.5f, maxScale);
        float randZ = Random.Range(0.5f, maxScale);

        return new Vector3(randX, randY, randZ);
    }

    //Function that instantiate a new gameObject Cube
    private void SpawnCube() {
        GameObject newGameObject = Instantiate(cube, RandomPos(), Quaternion.identity);
        newGameObject.transform.localScale = RandomScale() ;
    }
}
