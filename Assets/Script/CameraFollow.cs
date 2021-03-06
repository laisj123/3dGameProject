﻿using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public float CameraHeight;	//攝影機固定在人物上方10m
	public float CameraDistance;	//攝影機固定在離人物背後水平10m遠
	public float CameraHorizontalOffset; //攝影機距離肩膀水平距離
	private Transform ToolMan;
	private Transform MainCamera;
	// Use this for initialization
	void Start () {
		ToolMan = GameObject.Find ("ToolMan").transform;
		MainCamera = Camera.main.transform;
		MainCamera.position = new Vector3 (ToolMan.position.x+CameraHorizontalOffset,	//固定camera跟人之間的相對位置
			ToolMan.position.y+CameraHeight, ToolMan.position.z-CameraDistance);
	}
	
	// Update is called once per frame
	void Update () {

	}
}
