using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField] float anglePerSecond;
    public static Cube Instance;
    void Awake()
    {
        Instance = this;
    }

    void Update()
    {
        transform.Rotate(Vector3.right*anglePerSecond*Time.deltaTime);
    }
}
