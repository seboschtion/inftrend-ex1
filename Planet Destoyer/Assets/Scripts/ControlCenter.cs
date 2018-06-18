using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlCenter : MonoBehaviour
{
    public GameObject laserBeam;
    public GameObject planet;
    public GameObject explosion;
    public Button fireButton;
    private int counter;

    void Start()
    {
        var button = fireButton.GetComponent<Button>();
        button.onClick.AddListener(ToggleLaserBeam);
	}

	void ToggleLaserBeam()
    {
      counter++;
      laserBeam.SetActive(!laserBeam.activeSelf);
      if (counter == 5)
      {
        Explode();
        }
	}

  void Explode() {
		explosion.SetActive(true);
		Object.Destroy(planet);
	}
}
