using UnityEngine;
using UnityEngine.SceneManagement;
public class Scene : MonoBehaviour
{
    public string scene;
    void Start(){
    scene = SceneManager.GetActiveScene().ToString();
    }

    private void OnCollisionEnter2D(Collision2D collision){
        if (scene == "Main"){
            Debug.Log("Main");
        }
    }
}
