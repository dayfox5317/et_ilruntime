using ETModel;

using System;
using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UILogin)]
    public class UILoginEvent: AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UILogin);
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            //await ResourcesComponent.Instance.LoadBundleAsync(UIType.UILogin.StringToAB());
            //GameObject bundleGameObject = (GameObject) ResourcesComponent.Instance.GetAsset(UIType.UILogin.StringToAB(), UIType.UILogin);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = EntityFactory.CreateWithParent<UI, string, GameObject>(uiComponent, UIType.UILogin, gameObject);
            ui.AddComponent<UILoginComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UILobby);
           
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}