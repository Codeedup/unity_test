using UnityEngine;

public class AutoBehavior : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        Transform transform = GetComponent<Transform>();
        transform.Translate(Vector3.right * Time.deltaTime);
        transform.Rotate(0, 0, 50 * Time.deltaTime);
        transform.localScale -= Vector3.one * Time.deltaTime;
    }
}
