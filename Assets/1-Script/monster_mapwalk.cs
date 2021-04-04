using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monster_mapwalk : MonoBehaviour
{
    Transform Player; 
    public float minPosX; //左邊界
    public float maxPosX; //右邊界
    public int A;
    public float posx;
    public int monster;
    // Start is called before the first frame update
    void Start()
    {
        Player = gameObject.transform;
        // var pos = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        // Vector3 Pos = gameObject.transform.position;
        // Vector3 pos = gameObject.transform.localPosition;
        
        // A++;
        // transform.Translate(new Vector2(3, 0) * Time.deltaTime);
        
// if(posx == -336){
//                 A++;
//                 }

// if (pos.x > -336 && A % 2 == 1){
            
//             // transform.Translate(new Vector2(3, 0) * Time.deltaTime);
//             // A = A - 2 * monster + 7;
            

//             transform.position = new Vector3 (Mathf.Clamp(transform.position.x + 1f * Time .deltaTime, minPosX, maxPosX), transform.position.y, transform.position.z);
            
//         }
//         else{
//             transform.position = new Vector3 (Mathf.Clamp(transform.position.x - 1f * Time .deltaTime, minPosX, maxPosX), transform.position.y, transform.position.z);
//         }

var pos = gameObject.transform.position;
posx = pos.x;
if(posx == -3){
                A++;
                }else if(posx == 3){
                    A++;
                }


        if (pos.x <= 327 && A % 2 == 1){
            
            // transform.Translate(new Vector2(3, 0) * Time.deltaTime);
            // A = A - 2 * monster + 7;
            
            transform.position = new Vector3 (Mathf.Clamp(transform.position.x - 1 * Time .deltaTime, minPosX, maxPosX), transform.position.y, transform.position.z);
            
        }
        else{
            transform.position = new Vector3 (Mathf.Clamp(transform.position.x + 1 * Time .deltaTime, minPosX, maxPosX), transform.position.y, transform.position.z);
        }

































// var pos = transform.position;
// posx = pos.x;
// if(posx == -3){
//                 A++;
//                 }else if(posx == 3){
//                     A++;
//                 }


//         if (pos.x <= 3 && A % 2 == 1){
            
//             // transform.Translate(new Vector2(3, 0) * Time.deltaTime);
//             // A = A - 2 * monster + 7;
            
//             transform.position = new Vector3 (Mathf.Clamp(transform.position.x - 2f * Time .deltaTime, minPosX, maxPosX), transform.position.y, transform.position.z);
            
//         }
//         else{
//             transform.position = new Vector3 (Mathf.Clamp(transform.position.x + 2f * Time .deltaTime, minPosX, maxPosX), transform.position.y, transform.position.z);
//         }
        










        // if (A < 150){
        //     A = A - 2 * monster + 7;
        //     transform.position = new Vector3 (Mathf.Clamp(transform.position.x + 5f * Time .deltaTime, minPosX, maxPosX), transform.position.y, transform.position.z);
        // }
        // else if (A < 300){
        //     // transform.Translate(new Vector2(3, 0) * Time.deltaTime);
        //     transform.position = new Vector3 (Mathf.Clamp(transform.position.x - 5f * Time .deltaTime, minPosX, maxPosX), transform.position.y, transform.position.z);
        // }
        // else{
        //     A = monster;
        // }
        
//         A++;
//         if (A<200)
// {
//     transform.Translate(new Vector2(1, 0) * Time.deltaTime);
//        //当达到最右边时的最远距离
// //             transform.position = new Vector3 (transform.position.x + 3f * Time .deltaTime, transform.position.y, 0);
//         }

//         // 当达到最右边时的最远距离并且回到原点时
//         if (A>200&&A<400)
//         {
//            transform.position = new Vector3 (transform.position.x - 3f * Time .deltaTime, transform.position.y, 0);
//         }
//         if (A>400)
//         {
//          //原点继续出去
//             A = 0;
//         }
        
    }
}
