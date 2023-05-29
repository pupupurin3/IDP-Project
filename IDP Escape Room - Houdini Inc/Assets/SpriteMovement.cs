using UnityEngine;

public class SpriteMovement : MonoBehaviour
{
    public Transform spriteTransform;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            spriteTransform.position = new Vector3(mousePosition.x, mousePosition.y, 0f);
        }
    }
}

