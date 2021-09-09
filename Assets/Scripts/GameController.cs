using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{

    public CameraShake cameraShake;
    public TextMeshProUGUI countText;

    private int clicks = 0;

    void SetCountText()
    {
        countText.text = "Score: " + clicks.ToString();
    }

    private void Start()
    {
        SetCountText();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(cameraShake.Shake(.1f, .1f));
            clicks++;
            SetCountText();
        }
    }
}
