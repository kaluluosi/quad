using UnityEngine;
using System.Collections;

public class VersionControl : GameMaster
{
	public string version = "0.1.0a";
	// Use this for initialization
	void Awake () 
	{
		if(!PlayerPrefs.HasKey("ver") || PlayerPrefs.GetString("ver") != version)
		{
			PlayerPrefs.DeleteAll();
			PlayerPrefs.SetString("ver", version);
		}
	}

}
