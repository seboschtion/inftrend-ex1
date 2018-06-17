using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetManager : MonoBehaviour
{
	public GameObject planet1;
	public GameObject planet2;
	public GameObject planet3;
	public GameObject planet4;
    public GameObject planetDescription1;
    public GameObject planetDescription2;
    public GameObject planetDescription3;
    public GameObject planetDescription4;

    private void HideAll()
    {
		planet1.SetActive(false);
		planet2.SetActive(false);
		planet3.SetActive(false);
		planet4.SetActive(false);
        planetDescription1.SetActive(false);
        planetDescription2.SetActive(false);
        planetDescription3.SetActive(false);
        planetDescription4.SetActive(false);
    }

	public void ShowPlanet1()
    {
		HideAll();
		planet1.SetActive(true);
        planetDescription1.SetActive(true);
    }

	public void ShowPlanet2()
    {
		HideAll();
		planet2.SetActive(true);
        planetDescription2.SetActive(true);
    }

	public void ShowPlanet3()
    {
		HideAll();
		planet3.SetActive(true);
        planetDescription3.SetActive(true);
    }

	public void ShowPlanet4()
    {
		HideAll();
		planet4.SetActive(true);
        planetDescription4.SetActive(true);
    }
}
