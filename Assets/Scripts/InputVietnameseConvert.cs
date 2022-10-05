using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/ViToEn", order = 2)]
public class InputVietnameseConvert : ScriptableObject
{
    public List<string> engKey;
    public List<string> vietKey;
    public Attitude attitude;
    public bool IsVietnamese(string inputStr) {

        foreach (var item in vietKey)
        {
            if (inputStr.Contains(item)) {
                return true;
            }
        }
        return false;
    }
    public string GetEnglishKey() {
        Debug.Log("Return English Key:" + engKey);
        string eng = engKey[Random.Range(0, engKey.Count)];
        return eng;
    }
    public enum Attitude { Normal,Happy,Sad,Angry,Confuse}
}
