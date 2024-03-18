using Patterns.SimpleFactory.CloudExample.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.SimpleFactory.CloudExample.Clouds
{
    public class MegaCloud : ICloudService
    {
        public void Login(string accessToken, string password)
        {
            Debug.Log("Logged in to Mega");
        }

        public void Logout()
        {
            Debug.Log("Logout from Mega");
        }

        public void UploadFile(string localFilePath, string cloudFolder)
        {
            Debug.Log("File uploded to Mega");
        }

        public void DownloadFile(string cloudFilePath, string localFolder)
        {
            Debug.Log("File downloaded from Mega");
        }
    }
}