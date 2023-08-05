using UnityEngine;

public class GunController : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform bulletSpawnPoint;
    public float projectileForce = 10f;
    private GameObject currentGun;
    public GameObject Player;
    public Rigidbody2D rbPlayer;

    void Start()
    {
        GameObject Player = GameObject.Find("Player");
        currentGun = gameObject;
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Fire();
        }
    }

void Fire()
{
    GameObject newProjectile = Instantiate(currentGun.GetComponent<GunController>().projectilePrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
    Rigidbody2D rb = newProjectile.GetComponent<Rigidbody2D>();
    
    rb.AddForce(transform.right * currentGun.GetComponent<GunController>().projectileForce, ForceMode2D.Impulse);
    rbPlayer.velocity = new Vector2(-5, 5);
    Destroy(newProjectile, 5f);

}
}
