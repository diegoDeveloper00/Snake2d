using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
        if (SceneManager.GetActiveScene().buildIndex.Equals(1))
        {
            anim.SetBool("AnimateIn", true);
        }
    }

    public void playGame()
    {
        StartCoroutine(loadLevel());

    }

    IEnumerator loadLevel()
    {
        anim.SetBool("animateOut", true);

        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
