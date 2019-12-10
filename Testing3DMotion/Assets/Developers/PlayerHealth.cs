using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{
    public int startingHealth = 100;                            // The amount of health the player starts the game with.
    public int currentHealth;                                   // The current health the player has.
    public Slider healthSlider;                                 // Reference to the UI's health bar.
    public Image damageImage;                                   // Reference to an image to flash on the screen on being hurt.
    public AudioClip deathClip;                                   // Reference to an image to flash on the screen on being hurt.
    public AudioClip healthClip;                               // The audio clip to play when the player dies.
    public AudioClip damageClip;                               // The audio clip to play when the player dies.
    public float flashSpeed = 5f;                               // The speed the damageImage will fade at.
    public Color flashColour = new Color(1f, 0f, 0f, 0.1f);     // The colour the damageImage is set to, to flash.


    Animator anim;                                              // Reference to the Animator component.
    AudioSource playerAudio;                                    // Reference to the AudioSource component.
    //PlayerMovement playerMovement;                              // Reference to the player's movement.
    //PlayerShooting playerShooting;                              // Reference to the PlayerShooting script.
    bool isDead;                                                // Whether the player is dead.
    bool damaged;
    bool health;  // True when the player gets damaged.

    public float timer;

    void Awake()
    {
        // Setting up the references.
        //anim = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();
        //playerMovement = GetComponent<PlayerMovement>();
        //playerShooting = GetComponentInChildren<PlayerShooting>();

        // Set the initial health of the player.
        currentHealth = startingHealth;
    }


    void Update()
    {
        // If the player has just been damaged...
        //if (damaged)
        //{
            // ... set the colour of the damageImage to the flash colour.
        //    damageImage.color = flashColour;
        //}
        // Otherwise...
        //else
       // {
            // ... transition the colour back to clear.
        //    damageImage.color = Color.Lerp(damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
        //}

        // Reset the damaged flag.
        //damaged = false;

        if (health)
        {
            StartCoroutine(FlickeringLightHealth());
        }
        health = false;

        if (damaged)
        {
            StartCoroutine(FlickeringLightDamage());
        }
        damaged = false;
    }

    IEnumerator FlickeringLightHealth()
    {

        Color newColor = RenderSettings.ambientLight;

        Color newColor1 = new Color(0.1347684f, 0.2655172f, 0.07223631f);
        RenderSettings.ambientLight = newColor1;
        yield return new WaitForSeconds(0.1f);
        RenderSettings.ambientLight = newColor;
        yield return new WaitForSeconds(0.1f);
        RenderSettings.ambientLight = newColor1;
        yield return new WaitForSeconds(0.1f);
        RenderSettings.ambientLight = newColor;
    }

    IEnumerator FlickeringLightDamage()
    {
        Color newColor = RenderSettings.ambientLight;
        //Color newColor = new Color(0.27241379f, 0.03241379f, 0.03241379f);

        Color newColor1 = new Color(0.5347684f, 0.1655172f, 0.17223631f);
        RenderSettings.ambientLight = newColor1;
        yield return new WaitForSeconds(0.1f);
        RenderSettings.ambientLight = newColor;
        yield return new WaitForSeconds(0.1f);
        RenderSettings.ambientLight = newColor1;
        yield return new WaitForSeconds(0.1f);
        RenderSettings.ambientLight = newColor;
    }

    public void TakeDamage(int amount)
    {
        // Set the damaged flag so the screen will flash.
        damaged = true;

        // Reduce the current health by the damage amount.
        currentHealth -= amount;

        // Set the health bar's value to the current health.
        healthSlider.value = currentHealth;

        // Play the hurt sound effect.
        playerAudio.clip = damageClip;
        playerAudio.Play();

        // If the player has lost all it's health and the death flag hasn't been set yet...
        if (currentHealth <= 0 && !isDead)
        {
            // ... it should die.
            Death();
        }
    }

    public void TakeHealth(int amount)
    {
        // Set the damaged flag so the screen will flash.
        health = true;

        // Reduce the current health by the damage amount.
        currentHealth += amount;

        // Set the health bar's value to the current health.
        healthSlider.value = currentHealth;

        // Play the hurt sound effect.
        playerAudio.clip = healthClip;
        playerAudio.Play();

        // If the player has lost all it's health and the death flag hasn't been set yet...
        if (currentHealth <= 0 && !isDead)
        {
            // ... it should die.
            Death();
        }
    }


    void Death()
    {
        // Set the death flag so this function won't be called again.
        isDead = true;

        // Turn off any remaining shooting effects.
        //playerShooting.DisableEffects();

        // Tell the animator that the player is dead.
        //anim.SetTrigger("Die");

        // Set the audiosource to play the death clip and play it (this will stop the hurt sound from playing).
        //playerAudio.clip = deathClip;
        //playerAudio.Play();

        // Turn off the movement and shooting scripts.
        //playerMovement.enabled = false;
        //playerShooting.enabled = false;
    }
}