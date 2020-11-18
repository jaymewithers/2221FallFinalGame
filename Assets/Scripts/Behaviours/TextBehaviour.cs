using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TextBehaviour : MonoBehaviour
{
    private Text textObj;
    public IntData mainIntDataObj, altIntDataObj, currentDataObj;

    private void Start()
    {
        textObj = GetComponent<Text>();
    }

    private void Update()
    {
        textObj.text = currentDataObj.value.ToString();
    }

    public void MainIntDataToAlt()
    {
        currentDataObj = altIntDataObj;
    }

    public void AltToMainIntData()
    {
        currentDataObj = mainIntDataObj;
    }
}