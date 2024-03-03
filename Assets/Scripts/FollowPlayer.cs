using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Camera mainCamera;
    public Camera sideCamera;
    public GameObject player;
    private Vector3 mainOffset = new Vector3 (0, 5, -7);
    private Vector3 sideOffset = new Vector3 (0, 2, 1.5f);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.V))
        {
            if(mainCamera.gameObject.activeSelf)
            {
                mainCamera.gameObject.SetActive(false);
                sideCamera.gameObject.SetActive(true);
            }
            else
            {
                mainCamera.gameObject.SetActive(true);
                sideCamera.gameObject.SetActive(false);
            }
        }
    }
    // Update is called once per frame
    void LateUpdate()
    {
        //Offset the camera behind the player by adding to the player's position
        mainCamera.transform.position = player.transform.position + mainOffset;
        sideCamera.transform.position = player.transform.position + sideOffset;
    }
}
