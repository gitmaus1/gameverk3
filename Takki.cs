using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


using TMPro;

public class Takki : MonoBehaviour
{
    public TextMeshProUGUI textin;
    
    public void Start()
    {

       

        // ef lokasena texti
        if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            textin.text = "Lokastig " + rememberMe.stig + " peningum náð " + rememberMe.StigGull;
            if (!(rememberMe.StigGull == 30)) {

                
                if (rememberMe.Life == 0)
                {
                    textin.text = textin.text + " óvinir drápu þig ";
                }
                else
                {
                    textin.text = textin.text + " druknaði ";
                }
            }
            else {
                textin.text = textin.text + " þú wanst til hamingju";
            }




        }

    }
    private void Update()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    public void Byrja()
    {
        rememberMe.stig = 0;//núll stilli stigin 
        rememberMe.StigGull = 0;
        rememberMe.SpawnHraði = 0;
        rememberMe.Life = 30;
        SceneManager.LoadScene(1);
    }
    public void Endir()
    {
        SceneManager.LoadScene(0);
       
    }
    
}
