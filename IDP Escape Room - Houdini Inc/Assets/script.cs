using UnityEngine;

public class DragToFade : MonoBehaviour
{
    public GameObject targetObject;
    public float fadeSpeed = 0.5f;
    public float minOpacity = 0.2f;
    public float maxOpacity = 1f;

    private SpriteRenderer spriteRenderer;
    private bool isDragging = false;

    private void Start()
    {
        // Get the SpriteRenderer component of the target object
        spriteRenderer = targetObject.GetComponent<SpriteRenderer>();
    }

    private void OnMouseDown()
    {
        isDragging = true;
    }

    private void OnMouseUp()
    {
        isDragging = false;
    }

    private void Update()
    {
        if (isDragging)
        {
            // Gradually increase the transparency of the target object
            Color currentColor = spriteRenderer.color;
            float newOpacity = Mathf.Clamp(currentColor.a + fadeSpeed * Time.deltaTime, minOpacity, maxOpacity);
            spriteRenderer.color = new Color(currentColor.r, currentColor.g, currentColor.b, newOpacity);
        }
    }
}
