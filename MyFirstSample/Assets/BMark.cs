#pragma warning disable 162,108,618
using Casanova.Prelude;
using System.Linq;
using System;
using System.Collections.Generic;
using UnityEngine;
namespace Testing {public class BMark : MonoBehaviour{
public static int frame;
void Update () { Update(Time.deltaTime, this); 
 frame++; }
public bool JustEntered = true;


public void Start()
	{
		Abc = 2;
		
}
		public System.Int32 Abc;

System.DateTime init_time = System.DateTime.Now;
	public void Update(float dt, BMark world) {
var t = System.DateTime.Now;

		this.Rule0(dt, world);

	}





	int s0=-1;
	public void Rule0(float dt, BMark world){ 
	switch (s0)
	{

	case -1:
	Abc = Abc;
	s0 = -1;
return;	
	default: return;}}
	






}
public class AllTests{
public int frame;
public bool JustEntered = true;
	public int ID;
public AllTests()
	{JustEntered = false;
 frame = BMark.frame;
		Step = 0;
		Rf = 1f;
		
}
		public System.Single Rf;
	public System.Int32 Step;
	public System.Single ___d00;
	public UnityEngine.Vector3 ___v10;
	public UnityEngine.Vector3 ___v210;
	public System.Single ___dot10;
	public UnityEngine.Vector3 ___v221;
	public UnityEngine.Vector3 ___v31;
	public UnityEngine.Vector3 ___v232;
	public UnityEngine.Vector3 ___sub30;
	public UnityEngine.Vector3 ___v42;
	public UnityEngine.Vector3 ___v243;
	public UnityEngine.Vector3 ___trans40;
	public UnityEngine.Vector3 ___v53;
	public UnityEngine.Vector3 ___v254;
	public UnityEngine.Vector3 ___mult50;
	public UnityEngine.Vector3 ___v64;
	public UnityEngine.Vector3 ___scale60;
	public UnityEngine.Vector2 ___v75;
	public UnityEngine.Vector2 ___v275;
	public System.Single ___dot71;
	public UnityEngine.Vector2 ___v286;
	public UnityEngine.Vector2 ___v96;
	public UnityEngine.Vector2 ___v297;
	public UnityEngine.Vector2 ___sub91;
	public UnityEngine.Vector2 ___v107;
	public UnityEngine.Vector2 ___v2108;
	public UnityEngine.Vector2 ___trans101;
	public UnityEngine.Vector2 ___v118;
	public UnityEngine.Vector2 ___v2119;
	public UnityEngine.Vector2 ___mult111;
	public UnityEngine.Vector2 ___v129;
	public UnityEngine.Vector2 ___scale121;
	public void Update(float dt, BMark world) {
frame = BMark.frame;

		this.Rule0(dt, world);
		this.Rule1(dt, world);
		this.Rule2(dt, world);
		this.Rule3(dt, world);
		this.Rule4(dt, world);
		this.Rule5(dt, world);
		this.Rule6(dt, world);
		this.Rule7(dt, world);
		this.Rule8(dt, world);
		this.Rule9(dt, world);
		this.Rule10(dt, world);
		this.Rule11(dt, world);
		this.Rule12(dt, world);
	}





	int s0=-1;
	public void Rule0(float dt, BMark world){ 
	switch (s0)
	{

	case -1:
	___d00 = ((1.1f) * (((dt) % (256))));
	Rf = ((((((((((((((((((((((((((((((((((((((___d00) * (___d00))) * (___d00))) * (___d00))) * (___d00))) * (___d00))) * (___d00))) * (___d00))) * (___d00))) * (___d00))) * (___d00))) * (___d00))) * (___d00))) * (___d00))) * (___d00))) * (___d00))) * (___d00))) * (___d00))) * (___d00))) * (___d00));
	s0 = -1;
return;	
	default: return;}}
	

	int s1=-1;
	public void Rule1(float dt, BMark world){ 
	switch (s1)
	{

	case -1:
	___v10 = Vector3.one;
	___v210 = new UnityEngine.Vector3(dt,dt,dt);
	___dot10 = UnityEngine.Vector3.Dot(___v10,___v210);
	Rf = ___dot10;
	s1 = -1;
return;	
	default: return;}}
	

	int s2=-1;
	public void Rule2(float dt, BMark world){ 
	switch (s2)
	{

	case -1:
	___v221 = new UnityEngine.Vector3(dt,dt,dt);
	Rf = ___v221.magnitude;
	s2 = -1;
return;	
	default: return;}}
	

	int s3=-1;
	public void Rule3(float dt, BMark world){ 
	switch (s3)
	{

	case -1:
	___v31 = Vector3.one;
	___v232 = new UnityEngine.Vector3(dt,dt,dt);
	___sub30 = ((___v232) - (___v31));
	Rf = ___sub30.x;
	s3 = -1;
return;	
	default: return;}}
	

	int s4=-1;
	public void Rule4(float dt, BMark world){ 
	switch (s4)
	{

	case -1:
	___v42 = Vector3.one;
	___v243 = new UnityEngine.Vector3(dt,dt,dt);
	___trans40 = ((___v42) + (___v243));
	Rf = ___trans40.x;
	s4 = -1;
return;	
	default: return;}}
	

	int s5=-1;
	public void Rule5(float dt, BMark world){ 
	switch (s5)
	{

	case -1:
	___v53 = Vector3.one;
	___v254 = new UnityEngine.Vector3(dt,dt,dt);
	___mult50 = new UnityEngine.Vector3((___v53.x) * (___v254.x),(___v53.y) * (___v254.y),(___v53.z) * (___v254.z));
	Rf = ___mult50.x;
	s5 = -1;
return;	
	default: return;}}
	

	int s6=-1;
	public void Rule6(float dt, BMark world){ 
	switch (s6)
	{

	case -1:
	___v64 = Vector3.one;
	___scale60 = UnityEngine.Vector3.Scale(___v64,new UnityEngine.Vector3(dt,dt,dt));
	Rf = ___scale60.x;
	s6 = -1;
return;	
	default: return;}}
	

	int s7=-1;
	public void Rule7(float dt, BMark world){ 
	switch (s7)
	{

	case -1:
	___v75 = Vector2.one;
	___v275 = new UnityEngine.Vector2(dt,dt);
	___dot71 = UnityEngine.Vector2.Dot(___v75,___v275);
	Rf = ___dot71;
	s7 = -1;
return;	
	default: return;}}
	

	int s8=-1;
	public void Rule8(float dt, BMark world){ 
	switch (s8)
	{

	case -1:
	___v286 = new UnityEngine.Vector2(dt,dt);
	Rf = ___v286.magnitude;
	s8 = -1;
return;	
	default: return;}}
	

	int s9=-1;
	public void Rule9(float dt, BMark world){ 
	switch (s9)
	{

	case -1:
	___v96 = Vector2.one;
	___v297 = new UnityEngine.Vector2(dt,dt);
	___sub91 = ((___v297) - (___v96));
	Rf = ___sub91.x;
	s9 = -1;
return;	
	default: return;}}
	

	int s10=-1;
	public void Rule10(float dt, BMark world){ 
	switch (s10)
	{

	case -1:
	___v107 = Vector2.one;
	___v2108 = new UnityEngine.Vector2(dt,dt);
	___trans101 = ((___v107) + (___v2108));
	Rf = ___trans101.x;
	s10 = -1;
return;	
	default: return;}}
	

	int s11=-1;
	public void Rule11(float dt, BMark world){ 
	switch (s11)
	{

	case -1:
	___v118 = Vector2.one;
	___v2119 = new UnityEngine.Vector2(dt,dt);
	___mult111 = new UnityEngine.Vector2((___v118.x) * (___v2119.x),(___v118.y) * (___v2119.y));
	Rf = ___mult111.x;
	s11 = -1;
return;	
	default: return;}}
	

	int s12=-1;
	public void Rule12(float dt, BMark world){ 
	switch (s12)
	{

	case -1:
	___v129 = Vector2.one;
	___scale121 = UnityEngine.Vector2.Scale(___v129,new UnityEngine.Vector2(dt,dt));
	Rf = ___scale121.x;
	s12 = -1;
return;	
	default: return;}}
	





}
}      