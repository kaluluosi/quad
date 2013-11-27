/// <summary>
/// 路牌的触发机制
/// 制作人：小白
/// </summary>
using UnityEngine;
using System.Collections;

public class Trigger_Sign : StoryBoard 
{
	void OnTriggerStay(Collider other)
	{
		if(other.tag == "Player" && !_GamePause.paused)
		{
			if(Input.GetButtonDown("Exam"))
			{
				Mission ("Sign001");
			}
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Player" && !_GamePause.paused)
		{
			_PlayerHint.ShowUpHint();
		}
	}

	void OnTriggerExit(Collider other)
	{
		if(other.tag == "Player" && !_GamePause.paused)
		{
			_PlayerHint.HideUpHint();
		}
	}
}
