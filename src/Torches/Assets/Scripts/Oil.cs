using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oil : MonoBehaviour
{
    public int oilPowerUp;
    public Vector3 lightScaleTransformOil;

    public LightController PlayerLightController;

    void Start()
    {
        lightScaleTransformOil = new Vector3(2, 2, 1);
        oilPowerUp = 30;
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            ScoreManager.oilTimeLeft = +oilPowerUp;
            ScoreManager.oilTimerOn = true;
            PlayerLightController.changeLightLayerScale(lightScaleTransformOil);
            gameObject.SetActive(false);
        }
    }
}
