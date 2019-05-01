﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class RecycleObject : MonoBehaviour 
{

		private Vector3 newLocation;
		public List<Recycler> recyclableList;
		private int i = 0;

		void Start()
		{
			recyclableList = new List<Recycler>();
			Recycler.RecycleAction += RecycleActionHandler;
		}
		private void RecycleActionHandler(Recycler obj)
		{
			recyclableList.Add(obj);
		}

		void OnTriggerEnter()
		{

			i = UnityEngine.Random.Range(0, recyclableList.Count - 1);
			newLocation.y = StaticVars.nextSectionPosition;
			recyclableList[i].cube.position = newLocation;
			StaticVars.nextSectionPosition += StaticVars.distance;
			if (recyclableList.Count > 0)
			{ 
				recyclableList.RemoveAt(i);
			}
		}
}
