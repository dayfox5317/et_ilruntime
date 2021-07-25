using System;
using System.Collections;
using System.Collections.Generic;

namespace ETModel
{
    public static class HotfixHelper
    {
        public static void StartHotfix()
        {
            var list = new List<Type>() {
        typeof(MongoDB.Bson.Serialization.Attributes.BsonIdAttribute),
        typeof(MongoDB.Bson.Serialization.Attributes.BsonIgnoreAttribute),
        typeof(MongoDB.Bson.Serialization.Attributes.BsonIgnoreExtraElementsAttribute),
        typeof(MongoDB.Bson.Serialization.Attributes.BsonIgnoreIfDefaultAttribute),
        typeof(MongoDB.Bson.Serialization.Attributes.BsonIgnoreIfNullAttribute),
        typeof(MongoDB.Bson.Serialization.Attributes.BsonDefaultValueAttribute),
        typeof(MongoDB.Bson.Serialization.Attributes.BsonRequiredAttribute),
        typeof(MongoDB.Bson.Serialization.Attributes.BsonElementAttribute),
        typeof(MongoDB.Bson.Serialization.Attributes.BsonDictionaryOptionsAttribute),
        typeof(MongoDB.Bson.Serialization.BsonSerializer),
        typeof(System.Runtime.Serialization.IgnoreDataMemberAttribute),


        };



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
