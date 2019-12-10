using UnityEngine;
using System.Collections;

namespace CompleteProject
{
    public class EnemyAttackSpider : MonoBehaviour
    {
        public float timeBetweenAttacks = 0.5f;     // The time in seconds between each attack.
        public int attackDamage;               // The amount of health taken away per attack.

        Animation anim;
        //Animator anim;                              // Reference to the animator component.
        GameObject player;                          // Reference to the player GameObject.
        HealthPlayer playerHealth;                  // Reference to the player's health.
        EnemyHealth enemyHealth;                    // Reference to this enemy's health.
        bool playerInRange;                         // Whether player is within the trigger collider and can be attacked.
        float timer;    // Timer for counting up to the next attack.
        bool run;

        void Awake ()
        {
            // Setting up the references.
            player = GameObject.FindGameObjectWithTag ("Player");
            playerHealth = player.GetComponent <HealthPlayer> ();
            enemyHealth = GetComponent<EnemyHealth>();
            anim = GetComponent <Animation> ();
            run = false;
        }


        void OnTriggerEnter (Collider other)
        {

            Debug.LogError("MASUK KEAPAAAA"+other.gameObject.name);
            // If the entering collider is the player...
            if (other.gameObject == player)
            {
                Debug.LogError("MASUK KE PLAYER");
                // ... the player is in range.
                playerInRange = true;
                anim.Play("Attack");
            }
        }


        void OnTriggerExit (Collider other)
        {
            // If the exiting collider is the player...
            if(other.gameObject == player)
            {
                // ... the player is no longer in range.
                playerInRange = false;

                anim.Play("Run");
            }
        }


        void Update ()
        {
            // Add the time since Update was last called to the timer.
            timer += Time.deltaTime;

            // If the timer exceeds the time between attacks, the player is in range and this enemy is alive...
            if(timer >= timeBetweenAttacks && playerInRange && enemyHealth.currentHealth > 0)
            {
                Debug.LogError("HALO");
                // ... attack.
                Attack ();
            } 

            

            // If the player has zero or less health...
            if(playerHealth.currentHealth <= 0)
            {
                // ... tell the animator the player is dead.
                anim.Play("Death");
            }
        }


        void Attack ()
        {
            // Reset the timer.
            timer = 0f;

            // If the player has health to lose...
            if(playerHealth.currentHealth > 0)
            {
                // ... damage the player.
                playerHealth.TakeDamage (attackDamage);
            }
            
        }
    }
}