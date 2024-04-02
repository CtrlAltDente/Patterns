using Patterns.Adapter.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Adapter.Services
{
    public class JsonService : IService
    {
        public string GetServiceData(string url)
        {
            Debug.Log("Get json data");
            return "Json data";
        }
    }
}