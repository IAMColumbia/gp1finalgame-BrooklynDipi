using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    public GameObject lightLayer;

    public Vector3 standardScaleTransform;

    void Start()
    {
        standardScaleTransform = new Vector3(1.5f, 1.5f, 1f);
    }

    void Update()
    {
        if (ScoreManager.oilTimerOn == false)
        {
            changeLightLayerScale(standardScaleTransform);
        }
    }

    public void changeLightLayerScale(Vector3 newScale)
    {
        lightLayer.transform.localScale = newScale;
    }

    //array of items allowing it to be lit

}
