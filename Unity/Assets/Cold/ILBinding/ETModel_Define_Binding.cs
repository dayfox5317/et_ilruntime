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
    unsafe class ETModel_Define_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(ETModel.Define);

            field = type.GetField("IsILRuntime", flag);
            app.RegisterCLRFieldGetter(field, get_IsILRuntime_0);
            app.RegisterCLRFieldSetter(field, set_IsILRuntime_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_IsILRuntime_0, AssignFromStack_IsILRuntime_0);
            field = type.GetField("Force_Mono", flag);
            app.RegisterCLRFieldGetter(field, get_Force_Mono_1);
            app.RegisterCLRFieldSetter(field, set_Force_Mono_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_Force_Mono_1, AssignFromStack_Force_Mono_1);


        }



        static object get_IsILRuntime_0(ref object o)
        {
            return ETModel.Define.IsILRuntime;
        }

        static StackObject* CopyToStack_IsILRuntime_0(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ETModel.Define.IsILRuntime;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_IsILRuntime_0(ref object o, object v)
        {
            ETModel.Define.IsILRuntime = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_IsILRuntime_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @IsILRuntime = ptr_of_this_method->Value == 1;
            ETModel.Define.IsILRuntime = @IsILRuntime;
            return ptr_of_this_method;
        }

        static object get_Force_Mono_1(ref object o)
        {
            return ETModel.Define.Force_Mono;
        }

        static StackObject* CopyToStack_Force_Mono_1(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ETModel.Define.Force_Mono;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_Force_Mono_1(ref object o, object v)
        {
            ETModel.Define.Force_Mono = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_Force_Mono_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @Force_Mono = ptr_of_this_method->Value == 1;
            ETModel.Define.Force_Mono = @Force_Mono;
            return ptr_of_this_method;
        }



    }
}
