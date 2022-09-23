using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        //moves up right every tick
        Vector3 movement = new Vector3(horizontal, vertical, 1);

        //
        transform.Translate(movement * Time.deltaTime);
    }
}
