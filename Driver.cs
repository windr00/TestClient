using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using Myproto;
using UnityEngine;
using System.Reflection;
using ProtoBuf;
using PredefinedProto;

public class Driver : MonoBehaviour {

	private bool ifTested = false;

    void Awake()
    {
        DataOperator.GetInstance().AddCommandListener(ReceiveCommand);
		Loom.Init ();
    }

	void Start() {
	}


	void Test() {
		var e = new UserEvent ();
		var ga = new GA ();
		ga.AssetName = "cube";
		ga.GOID = "cube1";
		e.rawContent = ga as object;
		e.sponsorId = "0";
		e.targetIdList = World.GetInstance ().GetAllGOIds ();
		e.type = UserEvent.EventType.GA;
		EventCollection.OnEventTrigger (e);
	}

    private void ReceiveCommand(List<MsgResponse> command)
    {
		Loom.QueueOnMainThread (() => {
			EventDispatch.DispatchEvent(command);
		});
        
    }

	void FixedUpdate () 
	{
		DataOperator.GetInstance ().SendMessage ();
		
		if (!ifTested) {
			Test ();
			ifTested = true;
		}
	}
}
