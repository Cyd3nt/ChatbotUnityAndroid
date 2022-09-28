using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/ViToEn", order = 2)]
public class InputVietnameseConvert : ScriptableObject
{
    public string engKey;
    public List<string> vietKey;

    public bool IsVietnamese(string inputStr) {

        foreach (var item in vietKey)
        {
            if (inputStr == item) return true;
        }
        return false;
    }
    public string GetEnglishKey() {
        Debug.Log("Return English Key:" + engKey);
        return engKey;
    }
}
