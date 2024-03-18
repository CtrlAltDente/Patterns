using Patterns.SimpleFactory.CloudExample.Clouds;
using Patterns.SimpleFactory.CloudExample.Enums;
using Patterns.SimpleFactory.CloudExample.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.SimpleFactory.CloudExample.Factories
{
    public static class CloudServicesFactory
    {
        public static ICloudService GetCloudService(CloudService cloudService)
        {
            switch(cloudService)
            {
                case CloudService.GoogleDrive: { return new GoogleDriveCloud(); }
                case CloudService.DropBox: {  return new DropBoxCloud(); }
                case CloudService.Mega: {  return new MegaCloud(); }
                default: throw new Exception($"Cloud service {cloudService} not implemented in program");
            }
        }
    }
}