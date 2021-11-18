using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrowButtons : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject t1, t2, t3, t4, games;

    void Start()
    {
        //setando o alpha para aplicar nos botões
        var tempColor = games.transform.GetChild(1).GetComponentInChildren<Image>().color;
        tempColor.a = 0.156f;

        games.transform.GetChild(1).GetChild(0).GetComponent<Image>().color = tempColor;
        games.transform.GetChild(1).GetChild(1).GetComponent<Image>().color = tempColor;
        games.transform.GetChild(1).GetChild(6).GetComponent<Image>().color = tempColor;
        games.transform.GetChild(1).GetChild(7).GetComponent<Image>().color = tempColor;
        //desativando valor dos jogos
        games.transform.GetChild(1).GetChild(0).GetChild(0).gameObject.SetActive(false);
        games.transform.GetChild(1).GetChild(1).GetChild(0).gameObject.SetActive(false);
        games.transform.GetChild(1).GetChild(6).GetChild(0).gameObject.SetActive(false);

        games.transform.GetChild(2).GetChild(0).GetComponent<Image>().color = tempColor;
        games.transform.GetChild(2).GetChild(5).GetComponent<Image>().color = tempColor;
        games.transform.GetChild(2).GetChild(6).GetComponent<Image>().color = tempColor;
        //desativando valor dos jogos
        games.transform.GetChild(2).GetChild(0).GetChild(0).gameObject.SetActive(false);

        games.transform.GetChild(3).GetChild(0).GetComponent<Image>().color = tempColor;
        games.transform.GetChild(3).GetChild(1).GetComponent<Image>().color = tempColor;
        games.transform.GetChild(3).GetChild(6).GetComponent<Image>().color = tempColor;
        games.transform.GetChild(3).GetChild(7).GetComponent<Image>().color = tempColor;

    }

    // Update is called once per frame
  
    public void LeftArrow()
    {
        if (t1.GetComponent<Toggle>().isOn)
        {
            t4.GetComponent<Toggle>().isOn = true;
            games.transform.localPosition = new Vector3(-1530, 11, 0);

            var tempColor = games.transform.GetChild(0).GetComponentInChildren<Image>().color;
            //mudança de tonalidade dos botões
            games.transform.GetChild(3).GetChild(0).GetComponent<Image>().color = tempColor;
            games.transform.GetChild(3).GetChild(1).GetComponent<Image>().color = tempColor;
            games.transform.GetChild(3).GetChild(6).GetComponent<Image>().color = tempColor;
            games.transform.GetChild(3).GetChild(7).GetComponent<Image>().color = tempColor;
  
            tempColor.a = 0.156f;
            //mudança de tonalidade dos botões
            games.transform.GetChild(0).GetChild(5).GetComponent<Image>().color = tempColor;
            games.transform.GetChild(0).GetChild(6).GetComponent<Image>().color = tempColor;
            //desativando valor dos jogos
            games.transform.GetChild(0).GetChild(5).GetChild(0).gameObject.SetActive(false);

        }

        else if (t2.GetComponent<Toggle>().isOn)
        {
            t1.GetComponent<Toggle>().isOn = true;
            games.transform.localPosition = new Vector3(0, 11, 0);

            var tempColor = games.transform.GetChild(1).GetComponentInChildren<Image>().color;

            games.transform.GetChild(0).GetChild(5).GetComponent<Image>().color = tempColor;
            games.transform.GetChild(0).GetChild(6).GetComponent<Image>().color = tempColor;

            games.transform.GetChild(0).GetChild(5).GetChild(0).gameObject.SetActive(true);

            tempColor.a = 0.156f;

            games.transform.GetChild(1).GetChild(0).GetComponent<Image>().color = tempColor;
            games.transform.GetChild(1).GetChild(1).GetComponent<Image>().color = tempColor;
            games.transform.GetChild(1).GetChild(6).GetComponent<Image>().color = tempColor;
            games.transform.GetChild(1).GetChild(7).GetComponent<Image>().color = tempColor;

            games.transform.GetChild(1).GetChild(0).GetChild(0).gameObject.SetActive(false);
            games.transform.GetChild(1).GetChild(1).GetChild(0).gameObject.SetActive(false);
            games.transform.GetChild(1).GetChild(6).GetChild(0).gameObject.SetActive(false);
        }

        else if (t3.GetComponent<Toggle>().isOn)
        {
            t2.GetComponent<Toggle>().isOn = true;
            games.transform.localPosition = new Vector3(-510, 11, 0);

            var tempColor = games.transform.GetChild(2).GetComponentInChildren<Image>().color;

            games.transform.GetChild(1).GetChild(0).GetComponent<Image>().color = tempColor;
            games.transform.GetChild(1).GetChild(1).GetComponent<Image>().color = tempColor;
            games.transform.GetChild(1).GetChild(6).GetComponent<Image>().color = tempColor;
            games.transform.GetChild(1).GetChild(7).GetComponent<Image>().color = tempColor;

            games.transform.GetChild(1).GetChild(0).GetChild(0).gameObject.SetActive(true);
            games.transform.GetChild(1).GetChild(1).GetChild(0).gameObject.SetActive(true);
            games.transform.GetChild(1).GetChild(6).GetChild(0).gameObject.SetActive(true);

            tempColor.a = 0.156f;

            games.transform.GetChild(2).GetChild(0).GetComponent<Image>().color = tempColor;
            games.transform.GetChild(2).GetChild(5).GetComponent<Image>().color = tempColor;
            games.transform.GetChild(2).GetChild(6).GetComponent<Image>().color = tempColor;

            games.transform.GetChild(2).GetChild(0).GetChild(0).gameObject.SetActive(false);
        }

        else if (t4.GetComponent<Toggle>().isOn)
        {
            t3.GetComponent<Toggle>().isOn = true;
            games.transform.localPosition = new Vector3(-1020, 11, 0);

            var tempColor = games.transform.GetChild(3).GetComponentInChildren<Image>().color;

            games.transform.GetChild(2).GetChild(0).GetComponent<Image>().color = tempColor;
            games.transform.GetChild(2).GetChild(5).GetComponent<Image>().color = tempColor;
            games.transform.GetChild(2).GetChild(6).GetComponent<Image>().color = tempColor;

            games.transform.GetChild(2).GetChild(0).GetChild(0).gameObject.SetActive(true);

            tempColor.a = 0.156f;

            games.transform.GetChild(3).GetChild(0).GetComponent<Image>().color = tempColor;
            games.transform.GetChild(3).GetChild(1).GetComponent<Image>().color = tempColor;
            games.transform.GetChild(3).GetChild(6).GetComponent<Image>().color = tempColor;
            games.transform.GetChild(3).GetChild(7).GetComponent<Image>().color = tempColor;

        }
    }
    public void RightArrow()
    {
        if (t1.GetComponent<Toggle>().isOn)
        {
            t2.GetComponent<Toggle>().isOn = true;
            games.transform.localPosition = new Vector3(-510, 11, 0);

            var tempColor = games.transform.GetChild(0).GetComponentInChildren<Image>().color;

            games.transform.GetChild(1).GetChild(0).GetComponent<Image>().color = tempColor;
            games.transform.GetChild(1).GetChild(1).GetComponent<Image>().color = tempColor;
            games.transform.GetChild(1).GetChild(6).GetComponent<Image>().color = tempColor;
            games.transform.GetChild(1).GetChild(7).GetComponent<Image>().color = tempColor;

            games.transform.GetChild(1).GetChild(0).GetChild(0).gameObject.SetActive(true);
            games.transform.GetChild(1).GetChild(1).GetChild(0).gameObject.SetActive(true);
            games.transform.GetChild(1).GetChild(6).GetChild(0).gameObject.SetActive(true);

            tempColor.a = 0.156f;

            games.transform.GetChild(0).GetChild(5).GetComponent<Image>().color = tempColor;
            games.transform.GetChild(0).GetChild(6).GetComponent<Image>().color = tempColor;

            games.transform.GetChild(0).GetChild(5).GetChild(0).gameObject.SetActive(false);

        }

        else if (t2.GetComponent<Toggle>().isOn)
        {
            t3.GetComponent<Toggle>().isOn = true;
            games.transform.localPosition = new Vector3(-1020, 11, 0);

            var tempColor = games.transform.GetChild(1).GetComponentInChildren<Image>().color;

            games.transform.GetChild(2).GetChild(0).GetComponent<Image>().color = tempColor;
            games.transform.GetChild(2).GetChild(5).GetComponent<Image>().color = tempColor;
            games.transform.GetChild(2).GetChild(6).GetComponent<Image>().color = tempColor;

            games.transform.GetChild(2).GetChild(0).GetChild(0).gameObject.SetActive(true);

            tempColor.a = 0.156f;

            games.transform.GetChild(1).GetChild(0).GetComponent<Image>().color = tempColor;
            games.transform.GetChild(1).GetChild(1).GetComponent<Image>().color = tempColor;
            games.transform.GetChild(1).GetChild(6).GetComponent<Image>().color = tempColor;
            games.transform.GetChild(1).GetChild(7).GetComponent<Image>().color = tempColor;

            games.transform.GetChild(1).GetChild(0).GetChild(0).gameObject.SetActive(false);
            games.transform.GetChild(1).GetChild(1).GetChild(0).gameObject.SetActive(false);
            games.transform.GetChild(1).GetChild(6).GetChild(0).gameObject.SetActive(false);

        }

        else if (t3.GetComponent<Toggle>().isOn)
        {
            t4.GetComponent<Toggle>().isOn = true;
            games.transform.localPosition = new Vector3(-1530, 11, 0);

            var tempColor = games.transform.GetChild(2).GetComponentInChildren<Image>().color;

            games.transform.GetChild(3).GetChild(0).GetComponent<Image>().color = tempColor;
            games.transform.GetChild(3).GetChild(1).GetComponent<Image>().color = tempColor;
            games.transform.GetChild(3).GetChild(6).GetComponent<Image>().color = tempColor;
            games.transform.GetChild(3).GetChild(7).GetComponent<Image>().color = tempColor;

            tempColor.a = 0.156f;

            games.transform.GetChild(2).GetChild(0).GetComponent<Image>().color = tempColor;
            games.transform.GetChild(2).GetChild(5).GetComponent<Image>().color = tempColor;
            games.transform.GetChild(2).GetChild(6).GetComponent<Image>().color = tempColor;

            games.transform.GetChild(2).GetChild(0).GetChild(0).gameObject.SetActive(false);

        }

        else if (t4.GetComponent<Toggle>().isOn)
        {
            t1.GetComponent<Toggle>().isOn = true;
            games.transform.localPosition = new Vector3(0, 11, 0);

            var tempColor = games.transform.GetChild(3).GetComponentInChildren<Image>().color;

            games.transform.GetChild(0).GetChild(5).GetComponent<Image>().color = tempColor;
            games.transform.GetChild(0).GetChild(6).GetComponent<Image>().color = tempColor;

            games.transform.GetChild(0).GetChild(5).GetChild(0).gameObject.SetActive(true);

            tempColor.a = 0.156f;

            games.transform.GetChild(3).GetChild(0).GetComponent<Image>().color = tempColor;
            games.transform.GetChild(3).GetChild(1).GetComponent<Image>().color = tempColor;
            games.transform.GetChild(3).GetChild(6).GetComponent<Image>().color = tempColor;
            games.transform.GetChild(3).GetChild(7).GetComponent<Image>().color = tempColor;
        }
    }
}
