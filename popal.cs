using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popal : MonoBehaviour
{
    static int score = 0;  
   
    void OnMouseDown(){
        Destroy(gameObject);
        score = score + 100;
        print("Ты заработал" + score); 

    }
}
