using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{


    public GameObject screen1, screen2, panelSettings;
    public Image loadImage;
    public Text loadingText;

    public void ButtonSettings()
    {
        panelSettings.SetActive(!panelSettings.activeSelf);
    }

    public void ButtonQuit()
    {
        Application.Quit();
    }

    public void ButtonStartLoad()
    {

        screen1.SetActive(false);
        screen2.SetActive(true);
        StartCoroutine(ShowAnimations());
    }

    private IEnumerator ShowAnimations()
    {
        loadingText.gameObject.PunchScale(new Vector3(0.3f, 0.3f, 0.0f), 1.0f, 0.0f);
        iTween.RotateBy(loadImage.gameObject, iTween.Hash("z", -360, "looptype", iTween.LoopType.loop, "speed", 50));
        yield return new WaitForSeconds(1.0f);
        StartCoroutine(ShowAnimations());
    }
}