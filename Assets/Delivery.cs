using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{

    [SerializeField] Color32 hasPackageColor =  new Color32(0,1,0,1);
    [SerializeField] Color32 noPackageColor =  new Color32(1,1,1,1);

    SpriteRenderer spriteRenderer;

    private bool packagePickedUp = false;
    [SerializeField] public Vector3[] customerPosition = new Vector3[] {new Vector3(-34.47f,-33.86f), new Vector3(-29.48f, 8.36f),
    new Vector3(2.99f, -31.4f), new Vector3(32.47f, 8.75f), new Vector3(28.63f, 16.81f), new Vector3(8.29f, 32.78f),
    new Vector3(-8.6f, 32.63f)};
    [SerializeField] public Vector3[] packagePosition = new Vector3[] {new Vector3(-17f, -6.82f), new Vector3(-3.8f, 3.9f), new Vector3(6.4f, 10.4f), 
    new Vector3(0.1f, -22.8f), new Vector3(19f, -10.7f), new Vector3(-25.3f, 21.2f), new Vector3(-9.3f, -30.2f)};

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("hit");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Package" && !packagePickedUp)
        {
            Debug.Log("Package picked up!");
            packagePickedUp = true;
            other.transform.position = packagePosition[(int) Random.Range(0, packagePosition.Length - 1)];
            spriteRenderer.color = hasPackageColor;
        }

        if(other.tag == "Customer" && packagePickedUp)
        {
            Debug.Log("Package delivered!");
            packagePickedUp = false;
            spriteRenderer.color = noPackageColor;
            other.transform.position = customerPosition[(int) Random.Range(0, customerPosition.Length - 1)];
        }
    }

}
