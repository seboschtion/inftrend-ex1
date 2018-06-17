using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlCenter : MonoBehaviour
{
    public GameObject laserBeam;
    public Button fireButton;

    void Start()
    {
        var button = fireButton.GetComponent<Button>();
        button.onClick.AddListener(ToggleLaserBeam);
	}
	
	void ToggleLaserBeam()
    {
        laserBeam.SetActive(!laserBeam.activeSelf);
	}
}
