using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class UI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI debugText = default;
    [SerializeField] private TextMeshProUGUI staminaVal = default;
    [SerializeField] private Image staminaRed;
    [SerializeField] private Image staminaGreen;

    public Headbob headbob;
    public PlayerController playerController;

    private bool shrunk = false;


    void Start()
    {

        if (shrunk == false)
        {

            staminaGreen.transform.localScale -= new Vector3(playerController.stamina, 0f, 0f);

            shrunk = true;

        }

    }


    void Update()
    {

        debugText.text = headbob.currentState;

        staminaVal.text = playerController.stamina.ToString("0.00");
    }


}
