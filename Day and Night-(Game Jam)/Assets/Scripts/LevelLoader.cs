using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator transition;
    public Scene scene;
    public float transitionDuration = 1f;

    // Start is called before the first frame update
    void Start()
    {
        scene = GameObject.Find("Flag").GetComponent<Scene>();
    }

    // Update is called once per frame
    void Update()
    {
        if (scene.Next){
            LoadNextLevel();
        }
    }

    public void LoadNextLevel(){
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadLevel(int levelIndex){
        //Play Animation
        transition.SetTrigger("Start");
        //Wait
        yield return new WaitForSeconds(transitionDuration);
        //Load Scene
        SceneManager.LoadScene(levelIndex);
    }
}
