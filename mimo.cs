using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mimo : MonoBehaviour
{
    static int score = 0;

    void OnMouseDown(){
        Destroy(gameObject);
        score = score - 10;
        print("мимо");
    }
}
