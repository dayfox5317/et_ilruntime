using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

using ILRuntime.CLR.TypeSystem;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Runtime.Stack;
using ILRuntime.Reflection;
using ILRuntime.CLR.Utils;

namespace ILRuntime.Runtime.Generated
{
    unsafe class ETModel_ETTask_1_ETModel_IDisposableClassInheritanceAdaptor_Binding_IDisposableAdaptor_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(ETModel.ETTask<ETModel.IDisposableClassInheritanceAdaptor.IDisposableAdaptor>);
            args = new Type[]{typeof(ETModel.IDisposableClassInheritanceAdaptor.IDisposableAdaptor)};
            method = type.GetMethod("SetResult", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetResult_0);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("Create", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Create_1);
            args = new Type[]{};
            method = type.GetMethod("GetAwaiter", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetAwaiter_2);
            args = new Type[]{};
            method = type.GetMethod("get_IsCompleted", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_IsCompleted_3);
            args = new Type[]{};
            method = type.GetMethod("GetResult", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetResult_4);


        }


        static StackObject* SetResult_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ETModel.IDisposableClassInheritanceAdaptor.IDisposableAdaptor @result = (ETModel.IDisposableClassInheritanceAdaptor.IDisposableAdaptor)typeof(ETModel.IDisposableClassInheritanceAdaptor.IDisposableAdaptor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ETModel.ETTask<ETModel.IDisposableClassInheritanceAdaptor.IDisposableAdaptor> instance_of_this_method = (ETModel.ETTask<ETModel.IDisposableClassInheritanceAdaptor.IDisposableAdaptor>)typeof(ETModel.ETTask<ETModel.IDisposableClassInheritanceAdaptor.IDisposableAdaptor>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetResult(@result);

            return __ret;
        }

        static StackObject* Create_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @fromPool = ptr_of_this_method->Value == 1;


            var result_of_this_method = ETModel.ETTask<ETModel.IDisposableClassInheritanceAdaptor.IDisposableAdaptor>.Create(@fromPool);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetAwaiter_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ETModel.ETTask<ETModel.IDisposableClassInheritanceAdaptor.IDisposableAdaptor> instance_of_this_method = (ETModel.ETTask<ETModel.IDisposableClassInheritanceAdaptor.IDisposableAdaptor>)typeof(ETModel.ETTask<ETModel.IDisposableClassInheritanceAdaptor.IDisposableAdaptor>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetAwaiter();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_IsCompleted_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ETModel.ETTask<ETModel.IDisposableClassInheritanceAdaptor.IDisposableAdaptor> instance_of_this_method = (ETModel.ETTask<ETModel.IDisposableClassInheritanceAdaptor.IDisposableAdaptor>)typeof(ETModel.ETTask<ETModel.IDisposableClassInheritanceAdaptor.IDisposableAdaptor>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsCompleted;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* GetResult_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ETModel.ETTask<ETModel.IDisposableClassInheritanceAdaptor.IDisposableAdaptor> instance_of_this_method = (ETModel.ETTask<ETModel.IDisposableClassInheritanceAdaptor.IDisposableAdaptor>)typeof(ETModel.ETTask<ETModel.IDisposableClassInheritanceAdaptor.IDisposableAdaptor>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetResult();

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }



    }
}