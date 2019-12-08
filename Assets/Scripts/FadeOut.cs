using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FadeOut : MonoBehaviour
{
    public Image logoOut;

    // Start is called before the first frame update
    void Start()
    {
        logoOut.canvasRenderer.SetAlpha(1.0f);
        fadeOut();
    }

    void fadeOut()
    {
        logoOut.CrossFadeAlpha(0, 2, false);
    }

  

}
