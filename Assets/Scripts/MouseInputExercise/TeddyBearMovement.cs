using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeddyBearMovement : MonoBehaviour
{
    private float screenLeft;
    private float screenRight;
    private float screenTop;
    private float screenBottom;
    private float colliderHalfWidth;
    private float colliderHalfHeight;

    [SerializeField]
    GameObject prefabExplosion;

    [SerializeField]
    float moveUnitsPerSecond;

    // Start is called before the first frame update
    void Start()
    {
        // Save screen Edge in world cordinates
        float screenZ = -Camera.main.transform.position.z;
        Vector3 lowerLeftCornerScreen = new Vector3(0, 0, screenZ);
        Vector3 upperRightCornerScreen = new Vector3(Screen.width, Screen.height, screenZ);
        Vector3 lowerLeftCornerWorld = Camera.main.ScreenToWorldPoint(lowerLeftCornerScreen);
        Vector3 upperRightCornerWorld = Camera.main.ScreenToWorldPoint(upperRightCornerScreen);
        screenLeft = lowerLeftCornerWorld.x;
        screenRight = upperRightCornerWorld.x;
        screenTop = upperRightCornerWorld.y;
        screenBottom = lowerLeftCornerWorld.y;

        // Save collider dimension values
        BoxCollider2D collider = GetComponent<BoxCollider2D>();
        Vector3 diff = collider.bounds.max - collider.bounds.min;
        colliderHalfWidth = diff.x / 2;
        colliderHalfHeight = diff.y / 2;

    }

    // Update is called once per frame
    void Update()
    {
        #region Teddy bear follow mouse
        //// Calculate mouse world position
        //Vector3 mousePosition = Input.mousePosition;
        //mousePosition.z = -Camera.main.transform.position.z;
        //Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        //// Move teddy bear to mouse position
        //transform.position = worldPosition;
        #endregion

        #region Keyboard movement
        Vector3 position = transform.position;

        // Get new horizontal position
        float horizontalInput = Input.GetAxis("Horizontal");
        if (horizontalInput != 0)
        {
            position.x += horizontalInput * moveUnitsPerSecond * Time.deltaTime;
        }

        // Get new vertical position
        float verticalInput = Input.GetAxis("Vertical");
        if (verticalInput != 0)
        {
            position.y += verticalInput * moveUnitsPerSecond * Time.deltaTime;
        }

        // Move the character
        transform.position = position;
        #endregion


        ClampInScreen();

        // on left click, create explosion at teeddy bear and destroy teddy bear
        if (Input.GetAxis("BlowUpTeddy") > 0)
        {
            Instantiate(prefabExplosion,transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

    void ClampInScreen()
    {
        // Check boundaries and shift as nexeessary
        Vector3 position = transform.position;
        // Check left border
        if (position.x - colliderHalfWidth < screenLeft)
        {
            position.x = screenLeft + colliderHalfWidth;
        }
        // Check right border
        if (position.x + colliderHalfWidth > screenRight)
        {
            position.x = screenRight - colliderHalfWidth;
        }
        // Check top border
        if (position.y + colliderHalfHeight > screenTop)
        {
            position.y = screenTop - colliderHalfHeight;
        }
        // Check bottom border
        if (position.y - colliderHalfHeight < screenBottom)
        {
            position.y = screenBottom + colliderHalfHeight;
        }
        // Update position
        transform.position = position;
    }
}
