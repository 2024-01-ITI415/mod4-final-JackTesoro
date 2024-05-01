using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    private TextMeshProUGUI diamondText;

    //public GameObject GameOverScreen;

    //private void Awake()
    //{
        //GameOverScreen.SetActive(false);
    //}

    // Start is called before the first frame update
    void Start()
    {
        diamondText = GetComponent<TextMeshProUGUI>();
        //diamondText = 0;
    }

    public void UpdateDiamondText(PlayerInventory playerInventory)
    {
        diamondText.text = playerInventory.NumberOfDiamonds.ToString();
        //if (diamondText >= 73)
        //{
            //diamondText.SetActive(true);
        //}
    }
}
