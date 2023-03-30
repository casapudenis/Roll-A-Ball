using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerLVL2 : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    private int count;
    public Text countText;
    void Start()
    {
        rb= GetComponent<Rigidbody>();
        count = 8;
        SetCountText();
    }
    void FixedUpdate()
    {
        float moveHorizontal=Input.GetAxis("Horizontal");
        float moveVertical=Input.GetAxis("Vertical");
        Vector3 movement = new Vector3 (moveHorizontal,0.0f,moveVertical);
        rb.AddForce(movement*speed);
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count+1;
            SetCountText();
        }
    }
    void SetCountText()
    {
        countText.text = "Cuburi prinse: "+ count.ToString();
        if(count>=16)
        {
            SceneManager.LoadScene("WinScene");
        }
    }
}