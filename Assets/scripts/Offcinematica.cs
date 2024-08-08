using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Offcinematica : MonoBehaviour
{
    [SerializeField] GameObject[] gameObjects;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TurnOff());
    }

    IEnumerator TurnOff()
    {
        yield return new WaitForSeconds(10.5f);
        foreach (GameObject obj in gameObjects)
        {
            obj.SetActive(false);
        }
    }
}
