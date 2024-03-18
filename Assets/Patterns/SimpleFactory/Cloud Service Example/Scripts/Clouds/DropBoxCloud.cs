using Patterns.SimpleFactory.CloudExample.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.SimpleFactory.CloudExample.Clouds
{
    public class DropBoxCloud : ICloudService
    {
        public void Login(string accessToken, string password)
        {
            Debug.Log("Logged in to DropBox");
        }

        public void Logout()
        {
            Debug.Log("Logout from DropBox");
        }

        public void UploadFile(string localFilePath, string cloudFolder)
        {
            Debug.Log("File uploded to DropBox");
        }

        public void DownloadFile(string cloudFilePath, string localFolder)
        {
            Debug.Log("File downloaded from DropBox");
        }
    }
}