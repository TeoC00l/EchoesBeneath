using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMethods : MonoBehaviour
{
    public void deactivatePlayer()
    {
        PlayerInput.instance.NullifyInput = true;
        GameManager.instance.player.GetComponent<InteractionComponent>().enabled = false;

        Camera.main.gameObject.SetActive(false);

    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("2DIntro");
    }
}
