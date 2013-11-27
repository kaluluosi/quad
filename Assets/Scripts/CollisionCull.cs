using UnityEngine;
using System.Collections;

public class CollisionCull : MonoBehaviour 
{
	public MeshCollider[] children;

	void Awake()
	{
		children = transform.GetComponentsInChildren<MeshCollider>();
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Player")
		{
			foreach(MeshCollider en in children)
			{
				en.enabled = false;
			}
		}
	}
	void OnTriggerExit(Collider other)
	{
		if(other.tag == "Player")
		{
			foreach(MeshCollider en in children)
			{
				en.enabled = true;
			}
		}
	}
}
