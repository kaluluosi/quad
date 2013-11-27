/// <summary>
/// GUI的音效
/// 制作人：小白
/// </summary>
using UnityEngine;
using System.Collections;

public class GUISFX : GameMaster 
{
	public AudioClip pickSound;
	public AudioClip selectSound;
	public AudioClip questionSound;
	public AudioClip enterMenuSound;
	public AudioClip quitMenuSound;

	public bool sfxActive;
	public void GetSFX()
	{
		if(_GameData.SFXActive == 0)
			sfxActive = false;
		else
			sfxActive = true;
	}

	void Start()
	{
		GetSFX();
	}

	public void PlayPickSound()
	{
		if(sfxActive)
		{
			audio.clip = pickSound;
			audio.Play();
		}
	}

	public void PlaySelectSound()
	{
		if(sfxActive)
		{
			audio.clip = selectSound;
			audio.Play();
		}
	}

	public void PlayQuestionSound()
	{
		if(sfxActive)
		{
			audio.clip = questionSound;
			audio.Play();
		}
	}

	public void PlayEnterMenuSound()
	{
		if(sfxActive)
		{
			audio.clip = enterMenuSound;
			audio.Play();
		}
	}

	public void PlayQuitMenuSound()
	{
		if(sfxActive)
		{
			audio.clip = quitMenuSound;
			audio.Play();
		}
	}
}
