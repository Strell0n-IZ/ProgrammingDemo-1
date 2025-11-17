using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerHealth : MonoBehaviour
{

    public int health;
    public int maxHealth = 6;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    public void TakeDamage(int amount)
    {
        health -= amount;
        if (health <= 0)
        {
            ResetScene();
        }
    }
    private void ResetScene()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name, LoadSceneMode.Single);
    }
}
