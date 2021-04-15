using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestScript : MonoBehaviour
{
    public GameObject outOfBox;
    public GameObject outOfPortal;
    public Text outOfBoxText;
    public GameObject wonScreen;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "PortalTrigger")
        {
            wonScreen.SetActive(true);
        }

        if (other.gameObject.name == "Out of Box")
        {
            outOfBoxText.color = UnityEngine.Color.green;
        }
    }
}
