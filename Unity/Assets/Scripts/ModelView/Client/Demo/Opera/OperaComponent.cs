﻿using UnityEngine;

namespace ET.Client
{
	[ComponentOf(typeof(Scene))]
	public class OperaComponent: Entity, IAwake, IUpdate
    {
        public Vector3 ClickPoint;
        
	    public int mapMask;

	    public GameObject myGo;
    }
}
