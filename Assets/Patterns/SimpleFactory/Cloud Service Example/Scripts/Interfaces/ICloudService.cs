using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.SimpleFactory.CloudExample.Interfaces
{
    public interface ICloudService
    {
        public void Login(string accessToken, string password);
        public void Logout();
        public void UploadFile(string localFilePath, string cloudFolder);
        public void DownloadFile(string cloudFilePath, string localFolder);
    }
}