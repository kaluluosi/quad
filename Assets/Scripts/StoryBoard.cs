/// <summary>
/// 故事版
/// 制作人：小白
/// </summary>
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class StoryBoard : StoryBoardEngine
{
	void Awake()
	{
		if(PlayerPrefs.HasKey("Flag_Nail"))
		   PlayerPrefs.SetInt("Flag_Nail",0);
	}
	#region Flags
//	public Dictionary<string, bool> Flags;
	#endregion 

	#region 剧情
	private IEnumerator Sign001()
	{
		string[] say = {GameText.Text("Sign001"),GameText.Text("Sign002"),GameText.Text("Sign003")};
		Dialog(say,"Idle");
		yield return null;
	}
	private IEnumerator StrawMan001()
	{
		if(PlayerPrefs.GetInt("Flag_Nail") == 1)
			Dialog("一只稻草人。","Idle");
		else
			Dialog("一只稻草人，身上似乎插着一只铁钉。","StrawMan002");
		yield return null;
	}
	private IEnumerator StrawMan002()
	{
		Ask("将铁钉拿下来吗？","是\n否","Yes","Idle");
		yield return null;
	}
	private IEnumerator Yes()
	{
		Dialog("获得了[生锈的铁钉]。","Idle");
		PlayerPrefs.SetInt("Flag_Nail",1);
		yield return null;
	}
	#endregion

}