using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnAtStart : MonoBehaviour
{

    [SerializeField] GameObject package;
    [SerializeField] GameObject customer;
    public Vector3[] customerPosition = new Vector3[] {new Vector3(-34.47f,-33.86f), new Vector3(-29.48f, 8.36f),
    new Vector3(2.99f, -31.4f), new Vector3(32.47f, 8.75f), new Vector3(28.63f, 16.81f), new Vector3(8.29f, 32.78f),
    new Vector3(-8.6f, 32.63f)};
    public Vector3[] packagePosition = new Vector3[] {new Vector3(-17f, -6.82f), new Vector3(-3.8f, 3.9f), new Vector3(6.4f, 10.4f), 
    new Vector3(0.1f, -22.8f), new Vector3(19f, -10.7f), new Vector3(-25.3f, 21.2f), new Vector3(-9.3f, -30.2f)};

    // Start is called before the first frame update
    void Start()
    {
        package.transform.position = packagePosition[(int) Random.Range(0, packagePosition.Length)];
        customer.transform.position = customerPosition[(int) Random.Range(0, packagePosition.Length)];
    }

}
