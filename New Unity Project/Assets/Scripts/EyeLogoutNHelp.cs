using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EyeLogoutNHelp : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject help, valor, exit, eye, noteye, valorOculto, profile;
    public void Eye()
    {
        noteye.gameObject.SetActive(true);
        eye.gameObject.SetActive(false);
        valorOculto.gameObject.SetActive(true);
        valor.gameObject.SetActive(false);
    }

    public void NotEye()
    {
        eye.gameObject.SetActive(true);
        noteye.gameObject.SetActive(false);
        valorOculto.gameObject.SetActive(false);
        valor.gameObject.SetActive(true);
    }

    public void Logout()
    {
        exit.gameObject.SetActive(true);
    }

    public void RealLogout()
    {
        Application.Quit();
    }

    public void CloseLogout()
    {
        exit.gameObject.SetActive(false);
    }

    public void Help()
    {
        help.gameObject.SetActive(true);
    }

    public void CloseHelp()
    {
        help.gameObject.SetActive(false);
    }

    public void Profile()
    {
        if(profile.gameObject.activeSelf)
        {
            profile.gameObject.SetActive(false);
        }
        else if(!profile.gameObject.activeSelf)
        {
            profile.gameObject.SetActive(true);
        }

    }
  
}
