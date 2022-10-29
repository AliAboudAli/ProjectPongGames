using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartcountdownController : MonoBehaviour
{
    public int countdownTIme;
    public Text countdownDisplay;
    private int countdownTime;

    private void start()
    {
        StartCoroutine(CountdownToStart());
    }

    IEnumerator CountdownToStart()
    {
        while (countdownTime > 0)
        {
            countdownDisplay.text = countdownTIme.ToString();

            yield return new WaitForSeconds(1f);

            countdownTIme--;
        }
        {
            countdownDisplay.text = "Go";

            yield return new WaitForSeconds(1f);

            countdownDisplay.gameObject.SetActive(false);
        }
    }
}