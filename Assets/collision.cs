using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    void  OnCollisionEnter2D(Collision2D col) {
    	print("FUNGUJE COOOO!");
    }
    void OnCollionStay2D(Collision2D col)  {
    	print("funguje V2");
    }
}
