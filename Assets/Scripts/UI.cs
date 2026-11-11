using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class UI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI hbText = default;
    [SerializeField] private TextMeshProUGUI staminaVal = default;
    [SerializeField] private Image staminaRed;
    [SerializeField] private Image staminaGreen;
    [SerializeField] private TextMeshProUGUI playerText = default;

    public Headbob headbob;
    public PlayerController playerController;


    void Update()
    {

        hbText.text = "hb - " + headbob.currentStateStr;

        playerText.text = "player - " + playerController.currentStateStr;

        staminaVal.text = playerController.stamina.ToString("0.00");


        staminaGreen.transform.localScale = new Vector3(playerController.stamina, 1f, 1f);

    }
}
