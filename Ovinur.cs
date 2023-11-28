using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEngine.UI;
using TMPro;

public class Ovinur : MonoBehaviour
{
   
    private Transform player;
    private TextMeshProUGUI texti;
    private Rigidbody rb;
    private Vector3 movement;
    private float hradi = 5f;
    // Start is called before the first frame update
    void Start()
    {
        texti = GameObject.Find("Text (TMP)2").GetComponent<TextMeshProUGUI>();
        player = GameObject.Find("First Person Controller").GetComponent<Transform>();
        hradi = Random.Range(5, 20);
        rb = this.GetComponent<Rigidbody>();
        texti.text = "Líf " + rememberMe.Life.ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 stefna = player.position - transform.position;
        stefna.Normalize();
        movement = stefna;
    }
    private void FixedUpdate()
    {
        Hreyfing(movement);
    }
    void Hreyfing(Vector3 stefna)
    {
        rb.MovePosition(transform.position + (stefna * hradi * Time.deltaTime));
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            Debug.Log("Leikmaður fær í sig óvin");
            TakeDamage(10);
            gameObject.SetActive(false);
        }
    }
    public void TakeDamage(int damage)
    {

        rememberMe.Life -= damage;
        texti.text = "Líf " + rememberMe.Life.ToString();
        if (rememberMe.Life <= 0)
        {
            SceneManager.LoadScene(2);
            
            
            //Bullet.count = 0;//núll stilli stigin 
            //rememberMe.stig = 0;

            texti.text = "Líf " + rememberMe.Life.ToString();
        }
      
    }

  
}
