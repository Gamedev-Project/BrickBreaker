using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [Tooltip("start the movment")]
    [SerializeField]
    float Speed, Range;
    public Transform OriginalPos;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = OriginalPos.position;
    }

    // Update is called once per frame
    void Update(){
        float x = Mathf.Sin(Time.time*Speed);
        float y= OriginalPos.position.y;
        float z= OriginalPos.position.z;
        transform.position = new Vector3(OriginalPos.position.x+x*Range,y,z);
    }
}
