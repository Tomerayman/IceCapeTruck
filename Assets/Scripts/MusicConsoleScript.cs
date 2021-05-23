using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicConsoleScript : MonoBehaviour
{
    private List<string> rightCombo = new List<string>(new string[]
        {"2", "1", "2", "1", "2", "3", "4",
            "4", "2", "1", "2"});

    private List<string> currList;
    public Material successMtl;
    public Material badMtl;
    public Material regularMtl;
    public MeshRenderer bulbRenderer;
    public Image CheckMark;
    private bool isDone = false;
        
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
        if (isDone) return;
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
            StartCoroutine(tempColor());
            Debug.Log("start over");
        }
    }

    IEnumerator tempColor()
    {
        bulbRenderer.material = badMtl;
        yield return new WaitForSeconds(1f);
        bulbRenderer.material = regularMtl;
    }

    private void ComboSuccess()
    {
        Debug.Log("success");
        bulbRenderer.material = successMtl;
        isDone = true;
        CheckMark.enabled = true;
    }
}
