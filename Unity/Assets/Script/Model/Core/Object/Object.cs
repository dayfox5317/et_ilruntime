using System;
using System.ComponentModel;
using MongoDB.Bson.IO;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;
#if !NOT_UNITY
using UnityEngine;

#endif

namespace ET
{

#if !NOT_UNITY
    //ILRT 里不能用适配器IDisposable，会导致PB解析错误
    public interface IDisposable
    {
        void Dispose();
    }
#endif
    public interface ISupportInitialize
    {
        void BeginInit();
        void EndInit();
    }

    public abstract class Object: ISupportInitialize, IDisposable
    {
#if UNITY_EDITOR && VIEWGO
        public static GameObject Global => GameObject.Find("/Global");

        [BsonIgnore]
        public GameObject ViewGO
        {
            get;
        }
#endif

        public Object()
        {
#if UNITY_EDITOR && VIEWGO
            if (!this.GetType().IsDefined(typeof (HideInHierarchy), true) && Log.NeedLog)
            {
                this.ViewGO = new GameObject();
                this.ViewGO.name = this.GetType().Name;
                this.ViewGO.layer = LayerMask.NameToLayer("Hidden");
                this.ViewGO.transform.SetParent(Global.transform, false);
                this.ViewGO.AddComponent<ComponentView>().Component = this;
            }
#endif
        }

        public virtual void BeginInit()
        {
        }
        
        public virtual void EndInit()
        {
        }

        public virtual void Dispose()
        {
#if UNITY_EDITOR && VIEWGO
            if (this.ViewGO != null)
            {
                UnityEngine.Object.Destroy(this.ViewGO);
            }
#endif
        }
        
        public override string ToString()
        {
            return JsonHelper.ToJson(this);
        }
    }
}