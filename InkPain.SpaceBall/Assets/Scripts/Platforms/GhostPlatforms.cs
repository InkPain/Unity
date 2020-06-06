using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostPlatforms : MonoBehaviour
{
    public Transform pos1,pos2,startPos;
    public float speed;

    private Vector3 nextPos;

    ButtonPlatform ghostPlatformButton;

    // Start is called before the first frame update
    void Start()
    {
        ghostPlatformButton = GameObject.FindGameObjectWithTag("GhostPlatformButton").GetComponent<ButtonPlatform>();
        nextPos = startPos.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (ghostPlatformButton.buttonPressed)
        {
            nextPos = pos2.position;
        }

        transform.position = Vector3.MoveTowards(transform.position, nextPos, speed * Time.deltaTime);
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(pos1.position, pos2.position);
    }
}
