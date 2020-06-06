using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseControl : MonoBehaviour
{
    public Joystick joystick;

    Quaternion rotation;
    float angleX;
    float currentAngleX;
    float velocityCurrntAngeX;
    float angleY;
    float currentAngleY;
    float velocityCurrntAngeY;
    public float speedMouse = 1f;
    public float delyMouseRotation = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        rotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {

            if (Input.GetKey(KeyCode.Mouse1))
        {

            angleX += Input.GetAxis("Mouse X") * speedMouse;
            currentAngleX = Mathf.SmoothDamp(currentAngleX, angleX, ref velocityCurrntAngeX, delyMouseRotation);
            Quaternion rotationX = Quaternion.AngleAxis(currentAngleX, Vector3.up);

            angleY += Input.GetAxis("Mouse Y") * speedMouse;
            angleY = Mathf.Clamp(angleY, -30, 30);
            currentAngleY = Mathf.SmoothDamp(currentAngleY, angleY, ref velocityCurrntAngeY, delyMouseRotation);
            Quaternion rotationY = Quaternion.AngleAxis(-currentAngleY, Vector3.right);


            transform.rotation = rotation * rotationX * rotationY;

        }

        if (joystick.Vertical > 0.1f && joystick.Vertical != 0 || joystick.Vertical < 0.1f && joystick.Vertical != 0 || joystick.Horizontal > 0.1f && joystick.Horizontal != 0 || joystick.Horizontal < 0.1f && joystick.Horizontal != 0)
        {

            angleX += Input.GetAxis("Mouse X") * speedMouse;
            currentAngleX = Mathf.SmoothDamp(currentAngleX, angleX, ref velocityCurrntAngeX, delyMouseRotation);
            Quaternion rotationX = Quaternion.AngleAxis(currentAngleX, Vector3.up);

            angleY += Input.GetAxis("Mouse Y") * speedMouse;
            angleY = Mathf.Clamp(angleY, -30, 30);
            currentAngleY = Mathf.SmoothDamp(currentAngleY, angleY, ref velocityCurrntAngeY, delyMouseRotation);
            Quaternion rotationY = Quaternion.AngleAxis(-currentAngleY, Vector3.right);


            transform.rotation = rotation * rotationX * rotationY;

        }
    }
}
