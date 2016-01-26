using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EventReporter {

    public static List<UserEvent> ReportEvent()
    {
		var ret = new List<UserEvent> ();
		ret.AddRange(EventBag.GetInstance().GetAll());
		EventBag.GetInstance ().RemoveAll ();
		Debug.Log ("report event count: " + ret.Count);
		EventBag.nextTurnWait.Set ();
		return ret;
    }
}
