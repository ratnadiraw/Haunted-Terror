using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnemyHealth_Skeleton : MonoBehaviour {
    public Slider healthSlider;                                 // Reference to the UI's health bar.
    public bool damage;
    public GameObject musuh;
    public int currentHealth = 100;                                   // The current health the player has.
    public SkinnedMeshRenderer[] skinMeshRenderers;
    public Text winningText;
    public Text pointText;
    public Button nextGame;
    bool win;

    // Use this for initialization
    void Start () {
        skinMeshRenderers = GetComponentsInChildren<SkinnedMeshRenderer>();
        win = false;
    }

    IEnumerator FlickeringLightMusuh()
    {

        foreach (SkinnedMeshRenderer oneMesh in skinMeshRenderers)
            oneMesh.enabled = false;
        yield return new WaitForSeconds(0.1f);
        foreach (SkinnedMeshRenderer oneMesh in skinMeshRenderers)
            oneMesh.enabled = true;
        yield return new WaitForSeconds(0.1f);
        foreach (SkinnedMeshRenderer oneMesh in skinMeshRenderers)
            oneMesh.enabled = false;
        yield return new WaitForSeconds(0.1f);
        foreach (SkinnedMeshRenderer oneMesh in skinMeshRenderers)
            oneMesh.enabled = true;
    }
    // Update is called once per frame
    void Update () {
        if (damage)
        {
            StartCoroutine(FlickeringLightMusuh());
        }
        damage = false;
        if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger) == true)
        {
            if (win)
            {
                SceneManager.LoadScene("Level1");
            }
        }
    }

    void Death()
    {

        winningText.text = "CONGRATULATION";
        winningText.gameObject.SetActive(true);
        nextGame.gameObject.SetActive(true);
        musuh.transform.position = new Vector3(-100, -100, -100);
        Destroy(healthSlider);
        win = true;
    }

    public void TakeDamage(int amount)
    {
        // Set the damaged flag so the screen will flash.
        damage = true;

        // Reduce the current health by the damage amount.
        currentHealth -= amount;

        // Set the health bar's value to the current health.
        healthSlider.value = currentHealth;

        // Play the hurt sound effect.
        
        // If the player has lost all it's health and the death flag hasn't been set yet...
        if (currentHealth <= 0)
        {
            // ... it should die.
            Death();
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.LogWarning("MASUK COLLISON");
        if (collision.gameObject.tag == "Cube")
        {

            Debug.LogWarning("MASUK COLLISON CUBE");
            Destroy(collision.gameObject);
            TakeDamage(20);
        }

        if (collision.gameObject.tag == "DownCube")
        {
            Debug.LogWarning("MASUK COLLISON DOWN CUBE");
            Destroy(collision.gameObject);
            TakeDamage(40);
        }
    }
}
