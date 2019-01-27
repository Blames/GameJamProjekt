using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gauge : MonoBehaviour {

	[SerializeField]
	private int hp;
	[SerializeField]
	private int hpmax;
	[SerializeField]
	private Image bar;

	[SerializeField]
	private float fillAmount; 

	public float MaxValue { get; set;}
	public float value { get; set;}
	public float Value
	{
		set
		{
			fillAmount = gaugeValue(value,0,MaxValue,0,1);
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		updateBar();
	}

	public void updateBar()
	{
		if(fillAmount != bar.fillAmount)
		{
			bar.fillAmount = fillAmount;
		}	
	}

	private float gaugeValue(float value, float inMin, float inMax, float outMin, float outMax)
	{
		//Get a value between 0 and 1 
		return(value - inMin) * (outMax - outMin) / (inMax - inMin) + outMin;
	}

	// Inflige des dégâts
	public void TakeDamage(int damages)
	{
		hp -= damages;
		UpdateHealth();
	}
	// Soigne le joueur
	public void Heal(int heal)
	{
		hp += heal;
		UpdateHealth();
	}

	// Actualise les points de vie pour rester entre 0 et hpmax
	private void UpdateHealth()
	{
		hp = Mathf.Clamp(hp, 0, hpmax);
		float amount = (float)hp / hpmax;
		bar.fillAmount = amount;
	}
}
