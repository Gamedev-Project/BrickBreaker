using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScr : MonoBehaviour
{
    public Rigidbody2D BallRigidBody;
    public bool Strike_out;
    public Transform paddle;
    public float Force=150f;
    public Transform Boom;
    float delayDeleteTempBoom=4f;
    public GameStatus gamestatus;
    // Start is called before the first frame update
    void Start()
    {
        BallRigidBody=GetComponent<Rigidbody2D>();
        BallRigidBody.AddForce(Vector3.up*Force);
    }

    // Update is called once per frame
    void Update()
    {
        if(gamestatus.LevelFailed){
            return;
        }
        if(!Strike_out){
            transform.position=paddle.position;
        }
        if(Input.GetMouseButton(0)&&!Strike_out){
            Strike_out=true;
            BallRigidBody.AddForce(Vector3.up*Force);
        }
    }
    void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("BottomBoarder")){
        //BallRigidBody.velocity=Vector3.zero; //////////DELETEEEE////////
        Strike_out=false;
        gamestatus.LivesDecrese();
        }
    }
    void OnCollisionEnter2D(Collision2D other){
        if(other.transform.CompareTag("BrickTag")){
            BrickScr BrScr=other.gameObject.GetComponent<BrickScr>();
            if(BrScr.BrickLives>1){
                BrScr.BrickLivesDecrease();
            }
            else{

                Transform TempBoom=Instantiate(Boom,other.transform.position,other.transform.rotation);
                Destroy(TempBoom.gameObject,delayDeleteTempBoom);
                Destroy(other.gameObject);
                gamestatus.ScoreIncrese();
                gamestatus.BrickSumDecrease();
            }
        }
    }
}
