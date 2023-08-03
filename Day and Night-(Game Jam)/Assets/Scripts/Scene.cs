using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scene : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;

    private void OnCollisionEnter2D (Collision2D collision){
        LoadNextLevel();
    }

    public void LoadNextLevel(){
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator  LoadLevel(int levelIndex){
        //Play Animation
        transition.SetTrigger("Start");
        //Wait
        yield return new WaitForSeconds(transitionTime);
        //Load Scene
        SceneManager.LoadScene(levelIndex);
    }
}
