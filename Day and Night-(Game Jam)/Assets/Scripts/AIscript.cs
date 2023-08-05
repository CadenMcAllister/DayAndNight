using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIscript : MonoBehaviour
{
    public GameObject target;
    public bool Dead;
    public GameObject projectilePrefab;
    public Transform bulletSpawnPoint;
    public float projectileForce = 500f;

    private Rigidbody2D rb;
    private bool canShoot = true;
    private float collisionCounter = 0f;

    void Start()
    {
        target = GameObject.Find("Player");
        rb = GetComponent<Rigidbody2D>();
    }
    void Dead1(){
        Dead = true;
        canShoot = false;
        Destroy(gameObject);
    }
    void Update()
    {
        if (collisionCounter > 5f){
            Dead = true;
            Invoke("Dead1", 1);
        }
        // Check if the player is in range
        float distance = Vector2.Distance(transform.position, target.transform.position);
        if (distance < 10f)
        {
            // Fire the projectile
            Fire();
        }     
    }

    private void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.tag == "PlayerProjectile"){
        collisionCounter += 1;
        }
    }

    void Fire()
    {
        if (canShoot)
        {
            // Create a new instance of the projectile prefab at the bulletSpawnPoint position
            GameObject newProjectile = Instantiate(projectilePrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            Rigidbody2D rb = newProjectile.GetComponent<Rigidbody2D>();

            // Calculate the direction to the player
            Vector2 directionToTarget = (target.transform.position - bulletSpawnPoint.position).normalized;

            // Add a force to the projectile that points towards the player
            
            rb.AddForce(directionToTarget * projectileForce, ForceMode2D.Impulse);

            // Set canShoot to false and start the cooldown timer
            canShoot = false;
            Invoke(nameof(ResetCooldown), 2f);
        }
    }

    void ResetCooldown()
    {
        canShoot = true;
    }
}
