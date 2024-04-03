using Patterns.Adapter.Adapters;
using Patterns.Adapter.Services;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Facade.Data
{
    public class UrlDataSaver : MonoBehaviour
    {
        XmlService xmlService = new XmlService();
        
        XmlToJsonAdapter xmlToJsonAdapter;

        public void SaveJsonDataFromUrl(string url)
        {
            xmlToJsonAdapter = new XmlToJsonAdapter(xmlService);
            string jsonData = xmlToJsonAdapter.GetServiceData(url);
            Debug.Log("Data getted and converted to Json");
            SaveDataToCache(jsonData);
        }

        private void SaveDataToCache(string data)
        {
            Debug.Log("Data saved to cache");
        }
    }
}