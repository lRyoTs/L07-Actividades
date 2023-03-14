using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ex05 : MonoBehaviour
{
    //Variables
    private Renderer _renderer;
    public Material defaultColor;
    public Material hittedColor;

    private bool isHit = false; //Check if the sphere is hitted
    private bool isGameOver = false;

    private int lifes = 3;
    private int score = 0;

    public TextMeshProUGUI pointsText;
    public TextMeshProUGUI lifesText;

    private AudioSource _audioSource;
    public AudioClip soundDefeat;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
        _renderer = GetComponent<Renderer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        pointsText.text = $"Score:\n{score}";
        lifesText.text = $"LIVES:\n{lifes}";
        StartCoroutine(ChangePos());
    }

    //function that check if the gameobject collider is pressed
    private void OnMouseDown()
    {
        if (!isHit && !isGameOver) {
            ManageClick();
        }
       
    }

    //Coroutine that changes gameobject position while is not game Over
    private IEnumerator ChangePos() {
        while (!isGameOver)
        {
            yield return new WaitForSeconds(2);

            transform.position = RandomPosition();//move gameobject to another position
            //Check if gameobject clicked
            if (!isHit)
            {
                _audioSource.PlayOneShot(soundDefeat,1);
                lifes--; //Decrease life
                lifesText.text = $"LIVES:\n{lifes}";//Update life
                if (lifes <= 0) {
                    isGameOver = true;
                    _audioSource.Stop();
                    lifesText.text = $"GAME OVER";
                }
            }
            isHit = false;//restart isHit
            _renderer.material = defaultColor;//set default material
        }
    }

    //Function that gives a new random position
    private Vector3 RandomPosition() {
        int randomX = Random.Range(-10,10);
        int randomY = Random.Range(-3, 3);
        return new Vector3(randomX, randomY, 0);
    }

    //FUnction that manages when the gameobject is clicked
    private void ManageClick() {
        isHit = true;
        _renderer.material = hittedColor;
        score++; //increase score
        pointsText.text = $"Score:\n{score}"; //Update score
    }
}
