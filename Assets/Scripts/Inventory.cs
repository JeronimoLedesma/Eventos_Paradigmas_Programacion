using UnityEngine;

public class Inventory : MonoBehaviour
{
    public string itemList;

    void ItemShow(string item)
    {
        itemList += item + ". ";
        Debug.Log(itemList);
    }

    private void OnEnable()
    {
        Item.OnCollected += ItemShow;
    }

    private void OnDisable()
    {
        Item.OnCollected -= ItemShow;
    }
}
