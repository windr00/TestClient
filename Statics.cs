﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Statics
{

    public static Communication.NetworkType netType = Communication.NetworkType.TCP;

    public static string ServerIpAddress = "192.168.1.105";

    public static int ServerPort = 8088;

    public static string SendObjectType = "Myproto.MsgRequest";

    public static string RecvObjectType = "Myproto.MsgResponse";

    public static string SerializeMethodName = "Serailizer";

    public static string DeserializeMethodName = "Deserailizer";

    public static Serialize.Method SerializeMethod = Serialize.Method.PROTO;

    public static Serialize.Method DeserializeMethod = Serialize.Method.PROTO;

    public static string AssetBundleStoragePath = "";

}
