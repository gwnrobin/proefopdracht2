using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UI : MonoBehaviour
{
    [SerializeField]
    private GameObject input1;
    [SerializeField]
    private GameObject input2;
    [SerializeField]
    private GameObject input3;
    [SerializeField]
    private GameObject hexGrid;
    private Button button;



    void Start()
    {
        button = GetComponent<Button>();

        button.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        HexaGrid hexaGrid = hexGrid.GetComponent<HexaGrid>();
        hexaGrid.SetGap(float.Parse(input1.GetComponent<InputField>().text));
        hexaGrid.SetGridWidth(float.Parse(input2.GetComponent<InputField>().text));
        hexaGrid.SetGridHeight(float.Parse(input3.GetComponent<InputField>().text));
        hexaGrid.MakeGrid();
    }
}
