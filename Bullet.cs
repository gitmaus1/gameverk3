using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bullet : MonoBehaviour
{
    

    public float speed=20f;
    public Rigidbody rb;
    public int damage = 10;
    public GameObject sprengjan;
    public static int count;//klasabreyta
    public Text countText;
    void Start()
    {
        rb.velocity = transform.forward  * speed;
    }
    private void OnCollisionEnter(Collision collision)
    {
        countText.text = "Stig: " + count.ToString();
        Debug.Log(collision.collider.name);
        Debug.Log("konni hér");
       // Ovinur ovinur = collision.collider.GetComponent<Ovinur>();
        if (collision.collider.tag=="ovinur")
        {
            count += 10;
            Destroy(collision.gameObject);
            gameObject.SetActive(false);
            Debug.Log("hitti óvin");
            // ovinur.TakeDamage(damage);//ná í aðferðina í klasanum Ovinur
            Destroy(gameObject);//eyða kúlunni
                                // Debug.Log("kúlu eytt");
                                // collision.collider.gameObject.SetActive(false);
            Sprengja();//framkvæmir sprengju
        }
        /*
        if (ovinur != null)
        {
            Debug.Log("hitti óvin");
           // ovinur.TakeDamage(damage);//ná í aðferðina í klasanum Ovinur
            Destroy(gameObject);//eyða kúlunni
            Debug.Log("kúlu eytt");
        }*/
        else if (collision.collider.name != "Player")
        {
          //  Destroy(gameObject);//eyða kúlunni
           // Debug.Log("kúlu líka eytt eytt");
        }
    }
    /*
    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log(collision.name);
        Debug.Log("konni hér");
        Ovinur ovinur = collision.GetComponent<Ovinur>();
        if (ovinur!= null)
        {
            Debug.Log("hitti óvin");
            ovinur.TakeDamage(damage);//ná í aðferðina í klasanum Ovinur
            Destroy(gameObject);//eyða kúlunni
            Debug.Log("kúlu eytt");
        }
        if (collision.name!="Player")
        {
            Destroy(gameObject);//eyða kúlunni
            Debug.Log("kúlu líka eytt eytt");
        }
       
   
    } */
    void Sprengja()
    {
        Instantiate(sprengjan, transform.position, transform.rotation);
    }
}
