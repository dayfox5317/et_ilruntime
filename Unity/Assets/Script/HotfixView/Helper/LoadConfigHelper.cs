using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace ET
{
    public static class LoadConfigHelper
    {
        public static void LoadAllConfigBytes(Dictionary<string, byte[]> output)
        {
            var types = Game.EventSystem.GetTypes(typeof(ConfigAttribute));
          
           // Dictionary<string, UnityEngine.Object> keys = ResourcesComponent.Instance.GetBundleAll("config.unity3d");

            foreach (var type in types)
            {
                var path = ETModel.ABPathHelper.GetConfigPath(type.Name);
                var asset = ResourcesComponent.Instance.LoadAsset<TextAsset>(path);
                
                output[type.Name] = asset.bytes;
            }
        }
    }
}