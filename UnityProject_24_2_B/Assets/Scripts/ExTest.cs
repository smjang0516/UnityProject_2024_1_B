using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExTest : MonoBehaviour
{
    public int Hp = 100;

    // Start is called before the first frame update
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Hp -= 10;
            Debug.Log("Ã¼·Â : " + Hp);
            if(Hp < 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
