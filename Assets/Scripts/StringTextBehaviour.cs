using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class StringTextBehaviour : MonoBehaviour
{
    private Text textObj;
    public StringData value;

    private void Start()
    {
        textObj = GetComponent<Text>();
    }

    private void Update()
    {
        textObj.text = value.value;
    }
}