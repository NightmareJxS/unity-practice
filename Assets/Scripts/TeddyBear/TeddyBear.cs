using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeddyBear : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    int size;
    //int loop = 0;
    //bool check = false;

    [SerializeField]
    Sprite sp;

    SpriteRenderer spRenderer;

    void Start()
    {
        // Apply impusle force  to get teddy bear moving
        const float MinImpulseForce = 3f;
        const float MaxImpluseForce = 5f;

        float angle = Random.Range(0, 2*Mathf.PI);

        Vector2 direction = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));

        float magnitute = Random.Range(MinImpulseForce, MaxImpluseForce);

        GetComponent<Rigidbody2D>().AddForce( direction * magnitute, ForceMode2D.Impulse);

        #region Change size on Start
        //// Thay đổi kích thước con gấu với localScale
        //Vector3 scale = transform.localScale; // Lấy kích thước hiện tại

        //scale.x = size;
        //scale.y = size;

        //transform.localScale = scale; // Thay đổi kích thước

        //// Thay đổi hình (Sprite) của con gấu trên cửa sổ Ínpector
        //spRenderer = GetComponent<SpriteRenderer>(); // Lấy component SpriteRenderer của Game Object
        //spRenderer.sprite = sp; // Gắn ảnh vào component
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        #region Auto upscale and downscale
        // Auto upscale and downscale
        //Vector3 scale = transform.localScale;

        //if (size < 5 && loop == 0)
        //{
        //    check = true;
        //    loop = 4;
        //}

        //if (size >= 5 && loop == 0)
        //{
        //    check = false;
        //    loop = 4;
        //}

        //if (check)
        //{
        //    size++;
        //    scale.x = size;
        //    scale.y = size;
        //    loop--;
        //}
        //else
        //{
        //    size--;
        //    scale.x = size;
        //    scale.y = size;
        //    loop--;
        //}

        //transform.localScale = scale;
        #endregion

    }
}
