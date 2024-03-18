using Patterns.SimpleFactory.CloudExample.Enums;
using Patterns.SimpleFactory.CloudExample.Factories;
using Patterns.SimpleFactory.CloudExample.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.SimpleFactory.CloudExample.Managers
{
    public class CloudServiceManager : MonoBehaviour
    {
        private ICloudService _cloudService;

        public void InitializeCloudService(int cloudServiceId)
        {
            _cloudService = CloudServicesFactory.GetCloudService((CloudService)cloudServiceId);
        }

        public void Login()
        {
            _cloudService.Login("Token", "Password");
        }

        public void Logout()
        {
            _cloudService.Logout();
        }

        public void UploadFile()
        {
            _cloudService.UploadFile("LocalFilePath", "CloudFolder");
        }

        public void DownloadFile()
        {
            _cloudService.DownloadFile("CloudFilePath", "LocalFolder");
        }
    }
}