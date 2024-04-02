using Patterns.Adapter.Adapters;
using Patterns.Adapter.Interfaces;
using Patterns.Adapter.Services;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Adapter.Managers
{
    public class ServicesManager : MonoBehaviour
    {
        public void ShowServicesData()
        {
            JsonService jsonService = new JsonService();
            XmlService xmlService = new XmlService();
            
            ShowJsonData(jsonService);
            ShowJsonData(xmlService);

            Debug.Log("Use xml service in adapter");

            XmlToJsonAdapter xmlToJsonAdapter = new XmlToJsonAdapter(xmlService);
            ShowJsonData(xmlToJsonAdapter);
        }

        public void ShowJsonData(IService service)
        {
            Debug.Log($"Is operation successful {service.GetServiceData("url_path") == "Json data"}");
        }
    }
}