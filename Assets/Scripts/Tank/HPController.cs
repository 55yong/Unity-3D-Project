using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPController : MonoBehaviour
{
    public void HPControl(float newHP)
    {
        gameObject.GetComponent<Image>().fillAmount = newHP;
    }
}
