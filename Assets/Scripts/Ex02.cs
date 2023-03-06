using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Ex02 : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    private int seconds = 0;
    private bool stop;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Ex02: Press Q to stop TIMER");
        timerText.text = $"Timer: {seconds} s";
        StartCoroutine(UpdateTimer());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q)) {
            stop = true;
        }
    }
    private IEnumerator UpdateTimer() {
        while (!stop) {
            yield return new WaitForSeconds(1);
            seconds++;
            timerText.text = $"Timer: {seconds} s";
        }

    }
}
