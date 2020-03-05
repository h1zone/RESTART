using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class GettextFileldValue : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // повторно не раотает
        this.GetComponent<Text>().text = "Идти в " + GlobalMap.selectedMapObj.name + "?";
    }



    // Update is called once per frame
    void Update()
    {
        Debug.Log(GlobalMap.selectedMapObj.name);
    }
}
