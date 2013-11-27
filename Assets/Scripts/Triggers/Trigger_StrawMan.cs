/// <summary>
/// 路牌的触发机制
/// 制作人：小白
/// </summary>
using UnityEngine;
using System.Collections;

public class Trigger_StrawMan : StoryBoard 
{
	void Update()
	{
		if(Input.GetButtonDown("Exam"))
		{
			Debug.Log("发送");
		}
	}
	void OnTriggerStay(Collider other)
	{
		if(Input.GetButtonDown("Exam"))
		{
			if(other.tag == "Player" && !_GamePause.paused)
			{
				Debug.Log("接收");
				Mission ("StrawMan001");
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
