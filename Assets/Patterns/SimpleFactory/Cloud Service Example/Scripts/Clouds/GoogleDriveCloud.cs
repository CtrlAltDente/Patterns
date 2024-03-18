using Patterns.SimpleFactory.CloudExample.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.SimpleFactory.CloudExample.Clouds
{
    public class GoogleDriveCloud : ICloudService
    {
        public void Login(string accessToken, string password)
        {
            Debug.Log("Logged in to Google Drive");
        }

        public void Logout()
        {
            Debug.Log("Logout from Google Drive");
        }

        public void UploadFile(string localFilePath, string cloudFolder)
        {
            Debug.Log("File uploded to Google Drive");
        }

        public void DownloadFile(string cloudFilePath, string localFolder)
        {
            Debug.Log("File downloaded from Google Drive");
        }
    }
}