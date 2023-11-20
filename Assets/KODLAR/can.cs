using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class can : MonoBehaviour
{
    public int maxCan = 3;
    private int currentCan;
    private SpriteRenderer spriteRenderer;
    private Color originalColor;
    public Color damagedColor;

    private void Start()
    {
        currentCan = maxCan;
        spriteRenderer = GetComponent<SpriteRenderer>();
        originalColor = spriteRenderer.color;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Dusman") || collision.gameObject.CompareTag("Engel"))
        {
            LoseCan();
        }
    }

    private void LoseCan()
    {
        currentCan--;

        if (currentCan <= 0)
        {
            RestartGame();
        }
        else
        {
            StartCoroutine(FlashCharacter());
        }
    }

    private IEnumerator FlashCharacter()
    {
        spriteRenderer.color = damagedColor;
        yield return new WaitForSeconds(0.2f);
        spriteRenderer.color = originalColor;
    }

    private void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public int GetCurrentCan()
    {
        return currentCan;
    }
}
