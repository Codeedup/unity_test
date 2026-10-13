using UnityEngine;

public class myFirstScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Renderer myRenderer = GetComponent<Renderer>();

        
        myRenderer.material.color = Color.aliceBlue;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
