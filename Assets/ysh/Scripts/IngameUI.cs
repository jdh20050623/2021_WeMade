using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IngameUI : MonoBehaviour
{
    Slider quarantine_Slider;
    Slider society_Slider;
    Text budget_Text;
    Text support_Text;

    // Start is called before the first frame update
    void Start()
    {
        quarantine_Slider = GameObject.Find("Quarantine_Slider").GetComponent<Slider>();
        society_Slider = GameObject.Find("Society_Slider").GetComponent<Slider>();

        budget_Text = GameObject.Find("Budget_Text").GetComponent<Text>();
        support_Text = GameObject.Find("Support_Text").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        quarantine_Slider.value = GameManager.Instance.quarantine;
        society_Slider.value = GameManager.Instance.society;

        budget_Text.text = "예산 : " + GameManager.Instance.budget;
        support_Text.text = "지지율 : " + GameManager.Instance.support;

        Debug.Log("quarantine : " + GameManager.Instance.quarantine);
        Debug.Log("society : " + GameManager.Instance.society);
    }
}
