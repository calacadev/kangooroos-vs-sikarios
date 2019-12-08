using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour
{
    public Image logoIn;
        
        // Start is called before the first frame update
        void Start()
        {
        //logoIn.canvasRenderer.SetAlpha(0.0f);
        //fadeIn();
        // StartCoroutine(FadeImage(true));
        //StartCoroutine(FadeImage(false));
        FadeInandOut(logoIn);
        StartCoroutine(Wait(5.0f));
    }

    void fadeIn()
        {
            logoIn.CrossFadeAlpha(1, 2, false);
        }
        void fadeOut()
        {
            logoIn.CrossFadeAlpha(0, 2, false);
        }
    void FadeInandOut(Image image)
    {
        image.CrossFadeAlpha(1, 2, true);
        StartCoroutine(Wait(5.0f));
        image.CrossFadeAlpha(0, 2, false);
    }
    IEnumerator FadeImage(bool fadeAway)
        {
            // fade from opaque to transparent
            if (fadeAway)
            {
                // loop over 1 second backwards
                for (float i = 1; i >= 0; i -= Time.deltaTime)
                {
                    // set color with i as alpha
                    logoIn.color = new Color(1, 1, 1, i);
                    yield return null;
                }
            }
            // fade from transparent to opaque
            else
            {
                // loop over 1 second
                for (float i = 0; i <= 1; i += Time.deltaTime)
                {
                    // set color with i as alpha
                    logoIn.color = new Color(1, 1, 1, i);
                    yield return null;
                }
            }
        }

    IEnumerator Wait(float time)
    {
        yield return new WaitForSecondsRealtime(time);
    }
    private void Update()
        {
        // fadeOut();
        StartCoroutine(Wait(5.0f));
        StartCoroutine(FadeImage(false));

    }


}
