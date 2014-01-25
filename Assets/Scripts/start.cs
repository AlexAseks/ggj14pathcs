using UnityEngine;
using System.Collections;

public class start : MonoBehaviour {

	public GameObject Camara;
	public GameObject mirror;
	public GUISkin LifesGuiSkin;
	public Texture lIconFull;
	public Texture lIcon2Left;
	public Texture lIcon1Left;

	// Use this for initialization
	void Start () {

	}
	void OnGUI() {
		//GUI.Box (new Rect (-3,-3,100,30), lifes.ToString());
		GUI.BeginGroup (new Rect (-3, -3, 150, 50));
		GUI.Box (new Rect (0,0,50,50), lIconFull);
		GUI.EndGroup ();

	}
	// Update is called once per frame
	void Update () {
		Debug.Log (Camara.transform.position);
	}
}
