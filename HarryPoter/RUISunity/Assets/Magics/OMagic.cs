//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using UnityEngine;
using System.Diagnostics;
using Debug = UnityEngine.Debug;

namespace HarryPotter.Magics
{
	public class OMagic : DeffensiveMagic
	{
		GameObject sphere;
		public OMagic (string magicName, int cooldown) : base(magicName)
		{
			sphere = GameObject.FindGameObjectWithTag ("sfera");
			this.cooldown = cooldown;
		}
		
		public override void Effect()
		{
			Debug.Log ("OOO SHAPRE");
			GameObject sph = GameObject.Instantiate (sphere);
			sph.transform.position = GameObject.FindGameObjectWithTag ("Player").transform.position;
			sph.tag = "Shiled";
			GameObject.Destroy (sph, 10f);
		}
	}
}
