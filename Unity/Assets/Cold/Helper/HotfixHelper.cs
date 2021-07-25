using System;
using System.Collections;
using System.Collections.Generic;

namespace ETModel
{
    public static class HotfixHelper
    {
        public static void StartHotfix()
        {
            if (Define.IsILRuntime && !Define.Force_Mono
                 )
            {
                ILRuntimeHelper.Start();
            }
            else
            {
                MonoHelper.StartHotfix();
            }
        }

        public static List<Type> GetTypes()
        {
            return Define.IsILRuntime && !Define.Force_Mono ? ILRuntimeHelper.Types : MonoHelper.Types;
        }

    }
}
