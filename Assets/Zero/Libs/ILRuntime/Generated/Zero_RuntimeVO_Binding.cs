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
    unsafe class Zero_RuntimeVO_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Zero.RuntimeVO);

            field = type.GetField("hotResMode", flag);
            app.RegisterCLRFieldGetter(field, get_hotResMode_0);
            app.RegisterCLRFieldSetter(field, set_hotResMode_0);


        }



        static object get_hotResMode_0(ref object o)
        {
            return ((Zero.RuntimeVO)o).hotResMode;
        }
        static void set_hotResMode_0(ref object o, object v)
        {
            ((Zero.RuntimeVO)o).hotResMode = (Zero.EHotResMode)v;
        }


    }
}
