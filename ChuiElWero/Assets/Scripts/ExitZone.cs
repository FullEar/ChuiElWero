using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitZone : MonoBehaviour
{
    public void OnTriggerEnter(Collider collision)

    {
        Debug.Log(collision.gameObject.tag);

        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("MainMenu");
        }

    }
}
