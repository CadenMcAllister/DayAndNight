using UnityEngine;
using UnityEngine.SceneManagement;
public class Scene : MonoBehaviour
{
    public bool Next = false;
    private void OnCollisionEnter2D (Collision2D collision){
        Next = true;
    }
}
