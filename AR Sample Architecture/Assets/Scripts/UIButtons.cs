using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIButtons : MonoBehaviour
{
    public GameObject MainMenuPanel;
    public GameObject PlacePanel;
    public GameObject AboutPanel;
    public GameObject[] StageElements;

    [SerializeField]
    public GameObject[] ObjTypes = new GameObject[20];

    private GameObject[] BTNs;
    private GameObject[] sortedBTNs;
    private string[] NamesBTN = { "BigBen", "BuckinghamPalace", "BurjKhalifa", "CantonTower", "CNTower", "Colosseum", "EiffelTower", "EmpireStateBuilding", "GoldenGateBridge", "GreatSphinx", "HimejiCastle", "LondonEye", "NotreDame", "OperaHouse", "PisaTower", "SpaceNeedle", "StatueOfLiberty", "Stonehenge", "TajMahal", "TokyoTower"};
    private int BorderPosition=0;
    public GameObject BorderOBJ;

    // Start is called before the first frame update
    void Start()
    {
        BTNManager();
        PlacePanel.SetActive(false);
        AboutPanel.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
    public void PlaceObj()
    {
        MainMenuPanel.SetActive(false);
        PlacePanel.SetActive(true);
        BorderOBJ.SetActive(false);

    }
    public void ResetStage()
    {
        StageElements = GameObject.FindGameObjectsWithTag("StructA");
        foreach (GameObject Str in StageElements)
        {
            Destroy(Str);
        }

    }
    public void About()
    {
        MainMenuPanel.SetActive(false);
        AboutPanel.SetActive(true);

    }
    public void Exit()
    {
        Application.Quit();
    }
    public void GoBack()
    {
        PlacePanel.SetActive(false);
        MainMenuPanel.SetActive(true);

    }
    public void GoBackAbout()
    {
        AboutPanel.SetActive(false);
        MainMenuPanel.SetActive(true);

    }

    private void BTNManager()
    {
        BTNs = GameObject.FindGameObjectsWithTag("BTN");
        sortedBTNs = BTNs;
        for (int i = 0; i < BTNs.Length; i++) 
        {
            for (int j = 0; i < NamesBTN.Length; j++)
            {
                if (BTNs[i].name == NamesBTN[j])
                {
                    sortedBTNs[j] = BTNs[i];
                    break;

                }
            }
            
        }
    }


    //Object Selection Button Script
    public void ObjTypeManager(int N)
    {
        ARTap2PlaceObj.ObjSelected = ObjTypes[N];
    }
    
    private void UpdateBorder(int NewPos)
    {
        if (BorderPosition == NewPos)
        {
            //check State
            if (!(BorderOBJ.activeInHierarchy))
            {
                BorderOBJ.SetActive(true);
            }
            else
            {
                BorderOBJ.SetActive(false);
            }
        }
        else
        {
            BorderPosition = NewPos;
            BorderOBJ.transform.SetParent(sortedBTNs[BorderPosition].transform, false);
            BorderOBJ.SetActive(true);

        }
    }

    public void SelectBigBen()
    {
        UpdateBorder(0);
        ObjTypeManager(0);
    }
    public void SelectBuckinghamPalace()
    {
        UpdateBorder(1);
        ObjTypeManager(1);
    }
    public void SelectBurjKhalifa()
    {
        UpdateBorder(2);
        ObjTypeManager(2);
    }
    public void SelectCantonTower()
    {
        UpdateBorder(3);
        ObjTypeManager(3);
    }
    public void SelectCNTower()
    {
        UpdateBorder(4);
        ObjTypeManager(4);
    }
    public void SelectColosseum()
    {
        UpdateBorder(5);
        ObjTypeManager(5);
    }
    public void SelectEiffelTower()
    {
        UpdateBorder(6);
        ObjTypeManager(6);
    }
    public void SelectEmpireStateBuilding()
    {
        UpdateBorder(7);
        ObjTypeManager(7);
    }
    public void SelectGoldenGateBridge()
    {
        UpdateBorder(8);
        ObjTypeManager(8);
    }
    public void SelectGreatSphinx()
    {
        UpdateBorder(9);
        ObjTypeManager(9);
    }
    public void SelectHimejiCastle()
    {
        UpdateBorder(10);
        ObjTypeManager(10);
    }
    public void SelectLondonEye()
    {
        UpdateBorder(11);
        ObjTypeManager(11);
    }
    public void SelectNotreDame()
    {
        UpdateBorder(12);
        ObjTypeManager(12);
    }
    public void SelectOperaHouse()
    {
        UpdateBorder(13);
        ObjTypeManager(13);
    }
    public void SelectPisaTower()
    {
        UpdateBorder(14);
        ObjTypeManager(14);
    }
    public void SelectSpaceNeedle()
    {
        UpdateBorder(15);
        ObjTypeManager(15);
    }
    public void SelectStatueOfLiberty()
    {
        UpdateBorder(16);
        ObjTypeManager(16);
    }
    public void SelectStonehenge()
    {
        UpdateBorder(17);
        ObjTypeManager(17);
    }
    public void SelectTajMahal()
    {
        UpdateBorder(18);
        ObjTypeManager(18);
    }
    public void SelectTokyoTower()
    {
        UpdateBorder(19);
        ObjTypeManager(19);
    }


}
