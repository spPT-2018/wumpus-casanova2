#pragma warning disable 162,108,618
using Casanova.Prelude;
using System.Linq;
using System;
using System.Collections.Generic;
using UnityEngine;
namespace GameTwo {public class Wumpus : MonoBehaviour{
public static int frame;
void Update () { Update(Time.deltaTime, this); 
 frame++; }
public bool JustEntered = true;


public void Start()
	{
		Agenty = new CnvAgent();
		Abc = 2;
		
}
		public System.Int32 Abc;
	public CnvAgent Agenty;

System.DateTime init_time = System.DateTime.Now;
	public void Update(float dt, Wumpus world) {
var t = System.DateTime.Now;

		Agenty.Update(dt, world);
		this.Rule0(dt, world);

	}





	int s0=-1;
	public void Rule0(float dt, Wumpus world){ 
	switch (s0)
	{

	case -1:
	Abc = Abc;
	s0 = -1;
return;	
	default: return;}}
	






}
public class CnvAgent{
public int frame;
public bool JustEntered = true;
	public int ID;
public CnvAgent()
	{JustEntered = false;
 frame = Wumpus.frame;
		UnityAgent = UnityAgent.Instantiate();
		Target = Vector2.zero;
		Spent = 2f;
		Dur = 1f;
		
}
		public System.Single Dur;
	public UnityEngine.Vector3 Position{  get { return UnityAgent.Position; }
  set{UnityAgent.Position = value; }
 }
	public System.Single Spent;
	public UnityEngine.Vector2 Target;
	public UnityAgent UnityAgent;
	public System.Boolean enabled{  get { return UnityAgent.enabled; }
  set{UnityAgent.enabled = value; }
 }
	public UnityEngine.GameObject gameObject{  get { return UnityAgent.gameObject; }
 }
	public UnityEngine.HideFlags hideFlags{  get { return UnityAgent.hideFlags; }
  set{UnityAgent.hideFlags = value; }
 }
	public System.Boolean isActiveAndEnabled{  get { return UnityAgent.isActiveAndEnabled; }
 }
	public System.String name{  get { return UnityAgent.name; }
  set{UnityAgent.name = value; }
 }
	public System.String tag{  get { return UnityAgent.tag; }
  set{UnityAgent.tag = value; }
 }
	public UnityEngine.Transform transform{  get { return UnityAgent.transform; }
 }
	public System.Boolean useGUILayout{  get { return UnityAgent.useGUILayout; }
  set{UnityAgent.useGUILayout = value; }
 }
	public void Update(float dt, Wumpus world) {
frame = Wumpus.frame;

		this.Rule0(dt, world);

	}





	int s0=-1;
	public void Rule0(float dt, Wumpus world){ 
	switch (s0)
	{

	case -1:
	Position = Position;
	s0 = -1;
return;	
	default: return;}}
	






}
}      