using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoardData : MonoBehaviour
{
    //private Text textObj;

    //public StringData stringObj;
    //public IntData intObj;

    //public int score1, score2, score3, score4, score5;
    //public int newScore1, newScore2, newScore3, newScore4, newScore5;
    //public List<IntData> scoreList;
    //public IntData score1, score2, score3, score4, score5;

    // private void Start()
    // {
    //     textObj = GetComponent<Text>();
    // }

    public void ListToText(List<int> list)
    {
        var result = "";
        foreach (var listValue in list)
        {
            result += listValue.ToString() + "\n";
        }
    }

    public void SortList(List<int> intList)
    {
        intList.Sort();
    }

    // public void AddToScores(IntData value)
    // {
    //     scoreList.Add(value);
    //     if (scoreList.Capacity > 1)
    //     { 
    //         scoreList.Sort();
    //     }
    //     //scoreList.Capacity = 5;
    // }

    // public void UpdateScores()
    // {
    //     score1 = scoreList[1];
    //     if (scoreList.Capacity == 2)
    //     {
    //         score2 = scoreList[2];
    //     }
    //     if (scoreList.Capacity == 3)
    //     {
    //         score2 = scoreList[3];
    //     }
    //     if (scoreList.Capacity == 4)
    //     {
    //         score2 = scoreList[4];
    //     }
    //     if (scoreList.Capacity == 5)
    //     {
    //         score2 = scoreList[5];
    //     }
    // }

    // public void HandleScore()
    // {
    //     textObj.text = stringObj.value + intObj;
    // }

    // public void SortScores()
    // {
    //     scoreList.Sort();
    // }
}