using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundSetting : MonoBehaviour
{
    SpriteRenderer bgSpr;

    // Start is called before the first frame update
    void Start()
    {
        bgSpr = GetComponent<SpriteRenderer>();

        //      Get Camera Size
        float cameraHeight = 2f * Camera.main.orthographicSize;
        float cameraWidth = cameraHeight * Camera.main.aspect;

        float bgHeight = bgSpr.sprite.bounds.size.y;
        float bgWidth = bgSpr.sprite.bounds.size.x;

        float scaleX = cameraWidth / bgWidth;
        float scaleY = cameraHeight / bgHeight;

        transform.localScale = new Vector3(scaleX, scaleY, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
