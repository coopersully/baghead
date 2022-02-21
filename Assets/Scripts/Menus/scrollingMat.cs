using UnityEngine;

public class scrollingMat : MonoBehaviour
{
    [SerializeField] private float scrollSpeed;
    [SerializeField] private Renderer targetRenderer;
    
    // Update is called once per frame
    void Update()
    {
        targetRenderer.material.mainTextureOffset += new Vector2(scrollSpeed * Time.deltaTime, 0f);
    }
}
