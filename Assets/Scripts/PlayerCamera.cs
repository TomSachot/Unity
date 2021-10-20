using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    private Transform playerTransform { get; set; } = null;

    public Transform _eyeTransform = null;

    private Transform eyeTransform { get { return _eyeTransform; } set { _eyeTransform = value; } }

    //variable
    public bool _invertCamera = false;

    //propriété
    private bool invertCamera { get { return _invertCamera; } set { _invertCamera = value; } }

    public int valeur { get; private set; }

    // Start is called before the first frame update
    private void Start()
    {
        playerTransform = transform;
    }

    // Update is called once per frame
    private void Update()
    {
        playerTransform.Rotate(Vector3.up, Input.GetAxis("Mouse X"));
        float invertValue = invertCamera == true ? 1 : -1;
        eyeTransform.Rotate(Vector3.right, Input.GetAxis("Mouse Y")* invertValue);
    }
}
