using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicConsoleScript : MonoBehaviour
{
    private List<string> rightCombo = new List<string>(new string[]
        {"2", "1", "2", "1", "2", "3", "4",
            "4", "2", "1", "2"});

    private List<string> currList;
        
    // Start is called before the first frame update
    void Start()
    {
        currList = new List<string>(rightCombo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void JustPlayed(string code)
    {
        if (currList[0] == code)
        {
            currList.RemoveAt(0);
            if (currList.Count == 0)
            {
                ComboSuccess();
            }
        }
        else
        {
            currList = new List<string>(rightCombo);
        }
    }

    private void ComboSuccess()
    {
        
    }
}
