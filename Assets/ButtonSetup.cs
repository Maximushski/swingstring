﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ButtonSetup : MonoBehaviour
{
		
		public bool isLight;
		private Color tint;
		private Quaternion angle;
		
		
				
		// Use this for initialization
		void OnEnable ()
		{
				Image picture = GetComponent<Image> ();
				RectTransform thisRect = GetComponent<RectTransform> ();
		
				tint = GlobalStuff.LastColour;
				
				
						
				
				if (isLight) {
				
						picture.color = Color.Lerp (tint, Color.white, 0.5f);
						picture.color = new Color (picture.color.r, picture.color.g, picture.color.b, 1f);
				
				} else {
				
						picture.color = Color.Lerp (tint, Color.black, 0.5f);
						picture.color = new Color (picture.color.r, picture.color.g, picture.color.b, 1f);
				}
				
				
	
		}
	
		
}
