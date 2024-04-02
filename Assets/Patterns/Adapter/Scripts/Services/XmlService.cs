using Patterns.Adapter.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Adapter.Services
{
    public class XmlService : IService
    {
        public string GetServiceData(string url)
        {
            Debug.Log("Get XML data");
            return "XML data";
        }
    }
}