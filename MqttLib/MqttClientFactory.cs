using System;
using System.Text;
using MqttLib.Core;
using MqttLib;
using UnityEngine;

namespace MqttLib
{
    public class MqttClientFactory
    {
        public static IMqtt CreateClient(string connString, string clientId, string username = null, string password = null, IPersistence persistence = null, MonoBehaviour coroutineOwner = null)
        {
            return new Mqtt(connString, clientId, username, password, persistence, coroutineOwner);
        }

        public static IMqttShared CreateSharedClient(string connString, string clientId, string username = null, string password = null, MonoBehaviour coroutineOwner = null)
        {
            return new Mqtt(connString, clientId, username, password, null, coroutineOwner);
        }

        public static IMqtt CreateBufferedClient(string connString, string clientId)
        {
            throw new NotImplementedException();
        }
    }
}
