using UnityEngine;
using System.Collections;

[System.Serializable]
public class IRDSUpdateData : ScriptableObject{
	public bool dontShowOnLoad = false;
	public Texture2D iRDSLogo;
	public TextAsset changeLog;
	static string version = "3.2.6.1.d";
	
	public static string Version {
		get {
			return version;
		}
	}
}
