using UnityEngine;
using UnityEngine.SceneManagement;
public class Scene : MonoBehaviour
{
    public string scene;
    void Update(){
    scene = SceneManager.GetActiveScene().name;
    }

    private void OnCollisionEnter2D (Collision2D collision){
        if (scene == "Main"){
        }
    }
}
