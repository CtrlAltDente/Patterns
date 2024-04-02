using Patterns.Adapter.Interfaces;
using Patterns.Adapter.Services;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Adapter.Adapters
{
    public class XmlToJsonAdapter : IService
    {
        private XmlService _xmlService;

        public XmlToJsonAdapter(XmlService xmlService)
        {
            _xmlService = xmlService;
        }

        public string GetServiceData(string url)
        {
            return TransformXmlToJson(url);
        }

        private string TransformXmlToJson(string url)
        {
            string serviceData = _xmlService.GetServiceData(url);
            Debug.Log("Transform XML to JSON");
            serviceData = "Json data";
            return serviceData;
        }
    }
}