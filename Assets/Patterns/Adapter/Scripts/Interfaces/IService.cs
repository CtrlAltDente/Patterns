using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Adapter.Interfaces
{
    public interface IService
    {
        public string GetServiceData(string url);
    }
}