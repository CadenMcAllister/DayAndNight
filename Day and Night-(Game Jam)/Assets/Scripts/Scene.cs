using UnityEngine;
using UnityEngine.SceneManagement;
public class Scene : MonoBehaviour
{
    public string scene;
    void Start(){
    scene = SceneManager.GetActiveScene().ToString();
    Debug.Log(scene);
    }
}
