using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyLevelManagementScript : MonoBehaviour
{
	// Start is called before the first frame update


	public bool putHammerIn = false;
	public bool putHacksawIn = false;
	public bool putSawIn = false;
	public bool putGunIn = false;

	public GameObject finishTextHolder;
	public GameObject startTextHolder;


	public void checkForVictory()
	{
		if (putHammerIn && putHacksawIn && putSawIn && putSawIn && putGunIn)
		{
			finishTextHolder.transform.GetChild(0).gameObject.SetActive(true);
			startTextHolder.transform.GetChild(0).gameObject.SetActive(false);

			Debug.Log("I did the thing");
		}

	}

	public void putTheHammerIn()
	{
		this.putHammerIn = true;
		checkForVictory();
	}

	public void putTheHacksawIn()
	{
		this.putHacksawIn = true;
		checkForVictory();
	}

	public void putTheSawIn()
	{
		this.putSawIn = true;
		checkForVictory();
	}

	public void putTheGunIn()
	{
		this.putGunIn = true;
		checkForVictory();
	}




	private void Update()
	{
		checkForVictory();
	}


}
