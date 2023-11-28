using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class hlutursnu : MonoBehaviour
{
    private TextMeshProUGUI texti;

    private void Start()
    {
        texti = GameObject.Find("Text (TMP)2").GetComponent<TextMeshProUGUI>();
    }
    void Update()
    {
        transform.Rotate(new Vector3(0,80,0) * Time.deltaTime);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {

            
            //collision.collider.gameObject.SetActive(false);
            
            
            gameObject.SetActive(false);
            rememberMe.StigGull = rememberMe.StigGull + 1;
            rememberMe.SpawnHraði = rememberMe.SpawnHraði + 1;
            StartCoroutine("BallBall");
            rememberMe.Life = rememberMe.Life + 5;
           // Debug.Log("health er núna" + (rememberMe.Life).ToString());
            texti.text = "Líf " + rememberMe.Life;
            if (rememberMe.SpawnHraði == 30)
            {
                SceneManager.LoadScene(2);
            }
        }
    }
}
