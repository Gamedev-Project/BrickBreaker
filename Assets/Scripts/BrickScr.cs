using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickScr : MonoBehaviour
{
	public int BrickLives;

	public void BrickLivesDecrease(){
		BrickLives--;
		GetComponent<Renderer>().material.color =Color.green;
	}
}
