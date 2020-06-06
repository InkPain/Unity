using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    public Rigidbody rb;
    public Joystick joystick;
    public GameObject myCamera;
    GameObject mooveTutor;

    JumpButton jumpButton;
    Health healthSystem;

    public float force;
    public float jumpForce;
    public float jumpForceFromButton;


    bool tgm = false;

    public bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        jumpButton = GameObject.FindGameObjectWithTag("JumpButton").GetComponent<JumpButton>();
        healthSystem = GameObject.FindGameObjectWithTag("Player").GetComponent<Health>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.W) || joystick.Vertical > 0.1f && joystick.Vertical != 0)
        {
            rb.AddForce(myCamera.transform.forward * force * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S) || joystick.Vertical < 0.1f && joystick.Vertical !=0)
        {
            rb.AddForce(myCamera.transform.forward * -force * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D) || joystick.Horizontal > 0.1f && joystick.Horizontal != 0)
        {
            rb.AddForce(myCamera.transform.right * force * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A) || joystick.Horizontal < 0.1f && joystick.Horizontal != 0)
        {
            rb.AddForce(myCamera.transform.right * -force * Time.deltaTime);
        }

        Jump();

        
    }

    

    public void Jump()
    {
        Ray ray = new Ray(gameObject.transform.position, Vector3.down);
        RaycastHit rh;
        if (Physics.Raycast(ray, out rh, 0.8f))
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
            
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {
            rb.AddForce(Vector3.up * jumpForce);
        }
        if (jumpButton.jump && isGrounded == true)
        {
            rb.AddForce(Vector3.up * jumpForceFromButton);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "tgm")
        {
            tgm = true;
        }

        if (other.tag == "Checkpoint")
        {
            PlayerPrefs.SetFloat("xPos", transform.position.x);
            PlayerPrefs.SetFloat("yPos", transform.position.y);
            PlayerPrefs.SetFloat("zPos", transform.position.z);
            Destroy(other.gameObject);

        }


        if (other.tag == "Respawn" && tgm == false && healthSystem.health >= 1)
        {
            transform.position = new Vector3(PlayerPrefs.GetFloat("xPos"), PlayerPrefs.GetFloat("yPos"), PlayerPrefs.GetFloat("zPos"));
            healthSystem.health = healthSystem.health - 1;
            rb.velocity = new Vector3(0, 0, 0);
        }

        if (other.tag == "Respawn" && tgm == false && healthSystem.health < 1)
        {
            SceneManager.LoadScene(0);
        }

        if (other.tag == "Finish")
        {
            SceneManager.LoadScene("Level_2");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "tgm")
        {
            tgm = false;
        }
    }
}
