using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetManager : MonoBehaviour {

	public GameObject planet1;
	public GameObject planet2;
	public GameObject planet3;
	public GameObject planet4;

	private void HideAll() {
		planet1.SetActive(false);
		planet2.SetActive(false);
		planet3.SetActive(false);
		planet4.SetActive(false);
	}

	public void ShowPlanet1(){
		HideAll();
		planet1.SetActive(true);
	}

	public void ShowPlanet2(){
		HideAll();
		planet2.SetActive(true);
	}

	public void ShowPlanet3(){
		HideAll();
		planet3.SetActive(true);
	}

	public void ShowPlanet4(){
		HideAll();
		planet4.SetActive(true);
	}
}
