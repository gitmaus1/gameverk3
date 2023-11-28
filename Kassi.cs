using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Kassi : MonoBehaviour
{

    //public static int count=0;
    public GameObject sprenging;
    private TextMeshProUGUI countText;
    void Start()
    {

        countText = GameObject.Find("Text (TMP)").GetComponent<TextMeshProUGUI>();
        
        

        // tekur líf úr minni
        //count = rememberMe.stig;
        SetCountText();
    }
    private void Update()
    {
        // eiðir hluti
        if (transform.position.y < -10)
        {
            Destroy(gameObject);
            gameObject.SetActive(false);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "kula")
        {
            Destroy(gameObject);
            gameObject.SetActive(false);
            Debug.Log("varð fyrir kúlu");
            //count = count + 1;//færð stig
            rememberMe.stig = rememberMe.stig + 1; // savear
            SetCountText();//kallar í aðferðina
            Sprengin();
        }
    }
    void SetCountText()//hér er aðferðin
    {
        countText.text = "Stig: " + rememberMe.stig.ToString();
    }
    void Sprengin()
    {
        Instantiate(sprenging, transform.position, transform.rotation);
    }
}
