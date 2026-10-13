
using UnityEngine;
using UnityEngine.Animations;

public class TransformObject : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Transform transform = GetComponent<Transform> ();
        transform.position = new Vector3(0, 1, 0);
        transform.rotation = Quaternion.Euler(0, 0, 120);
        transform.localScale = new Vector3(4, 1, 1);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}