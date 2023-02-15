using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Transform content;
    [SerializeField] private GameObject buttonPrefab;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            int index = new();
            index = i;
            GameObject newButton = Instantiate(buttonPrefab, content);
            newButton.transform.GetChild(0).GetComponent<TMP_Text>().text = (i + 1).ToString();
            int star = Random.Range(0, 3);
            for (int j = 0; j < star; j++)
            {
                newButton.transform.GetChild(1).GetChild(j).GetComponent<Image>().color = Color.white;
            }
            newButton.GetComponent<Button>().onClick.AddListener(delegate { PrintIndex(index + 1); });
        }
    }

    void PrintIndex(int index)
    {
        Debug.Log(index);
    }

}
