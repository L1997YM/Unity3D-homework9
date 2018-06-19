//using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Vuforia;

public class VirtualButtontest : MonoBehaviour, IVirtualButtonEventHandler{

	public GameObject vb;
	private int pressNum = 0;

	// Use this for initialization
	void Start () {
		VirtualButtonBehaviour vbb = vb.GetComponent<VirtualButtonBehaviour> ();
		if (vbb) {
			vbb.RegisterEventHandler (this);
		}
	}

	// Update is called once per frame
	void Update () {
		switch (pressNum) 
		{
		case 0:
			vb.transform.localScale *= 1f;
			break;
		case 1:
			vb.transform.localScale *= 0.8f;
			break;
		case 2:
			vb.transform.localScale *= 0.5f;
			break;
		}
	}

	public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
	{
		pressNum++;
		pressNum %= 3;
		ani.SetTrigger ("Take Off");
		Debug.Log ("按钮按下！");
	}

	public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
	{
		ani.SetTrigger ("Land");
		Debug.Log ("按钮释放");
	}


}

