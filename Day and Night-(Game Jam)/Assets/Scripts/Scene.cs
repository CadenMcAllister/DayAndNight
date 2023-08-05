using UnityEngine;
using UnityEngine.SceneManagement;
public class Scene : MonoBehaviour
{
    public GameObject LevelLoader;
    public bool Starter = false;
    public LevelLoader levelLoader;
    void Awake(){
        levelLoader = GameObject.Find("LevelLoader").GetComponent<LevelLoader>();
    }
    private void OnCollisionEnter2D (Collision2D collision){
        if (collision.gameObject.tag == "Player"){
        Starter = true;
        }
    }
}
