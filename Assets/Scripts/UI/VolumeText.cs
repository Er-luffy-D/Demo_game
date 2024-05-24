using UnityEngine;
using UnityEngine.UI;

public class VolumeText : MonoBehaviour
{
    [SerializeField] private string volumeType;
    [SerializeField] private string variableName;
    private Text txt;
    private float updateTimer;

    private void Awake()
    {
        txt = GetComponent<Text>();
    }
    private void Update()
    {
        updateTimer += Time.unscaledTime;
        if (updateTimer > 0.5f)
            UpdateText();
    }
    private void UpdateText()
    {
        txt.text = volumeType + PlayerPrefs.GetFloat(variableName, 100).ToString("F0");
    }
}