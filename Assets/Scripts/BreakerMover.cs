using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakerMover : MonoBehaviour
{
    public Camera mainCamera;
    float LeftBoarder,RightBoarder;
    public GameStatus gamestatus;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera  = FindObjectOfType<Camera>();
        LeftBoarder=mainCamera.ScreenToWorldPoint(new Vector3()).x;
        RightBoarder=mainCamera.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x;
    }

    // Update is called once per frame
    void Update()
    {
        if(gamestatus.LevelFailed){
            return;
        }
        this.transform.position=new Vector3(mainCamera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,0,0)).x,mainCamera.ScreenToWorldPoint(new Vector3()).y,0);
        if(transform.position.x<LeftBoarder){
            transform.position=new Vector3(LeftBoarder,transform.position.y,0);
        }
        if(transform.position.x>RightBoarder){
            transform.position=new Vector3(RightBoarder,transform.position.y,0);
        }
    }
}
