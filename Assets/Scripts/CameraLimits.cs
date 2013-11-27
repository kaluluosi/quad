/// <summary>
/// 摄影机的移动与约束
/// 制作人：小白
/// </summary>
using UnityEngine;
using System.Collections;

public class CameraLimits : GameMaster 
{
	public bool limitXPos;
	public Vector2 xLimit;
	public bool limitYPos;
	public Vector2 yLimit;

	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		if(limitXPos && !limitYPos)
		{
			transform.position = new Vector3(Mathf.Clamp(transform.position.x, xLimit.x, xLimit.y), transform.position.y, transform.position.z);
		}
		else if(!limitXPos && limitYPos)
		{
			transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, yLimit.x, yLimit.y), transform.position.z);
		}
		else if(limitXPos && limitYPos)
		{
			transform.position = new Vector3(Mathf.Clamp(transform.position.x, xLimit.x, xLimit.y), Mathf.Clamp(transform.position.y, yLimit.x, yLimit.y), transform.position.z);
		}
	}
}
