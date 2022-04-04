using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Points : MonoBehaviour
{
    public Player target;
    public TMP_Text pointsText;

    void Update()
    {
        pointsText.text = "Points: " + target.points;
    }


}
