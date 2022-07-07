using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnduranceUI : MonoBehaviour
{
    public Text endText;
    public CharacterData playerData;
    public Image theBar;
    // Start is called before the first frame update
    void Start()
    {
        theBar = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        theBar.fillAmount = playerData.currentEndurance / playerData.maxEndurance;
        endText.text = ((int)playerData.currentEndurance).ToString() + "/" + ((int)playerData.maxEndurance).ToString();
    }
}
