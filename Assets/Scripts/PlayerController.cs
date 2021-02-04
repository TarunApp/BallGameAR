using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public float speed = 800.0f;
    public Text scoreText;
    public TextMeshPro scorear;
    private int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
     void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");

        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

        GetComponent<Rigidbody>().AddForce (movement * speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other){
        if( other.gameObject.tag == "PickUp"){
            other.gameObject.SetActive(false);
            Debug.Log(count);
            count += 1;
            // scoreText.text = "Score: " + count;
            // scorear = GetComponent<TextMeshPro> ();
            scorear.text = "Score: " + count;
        }
    }
}
