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
    unsafe class Zero_ZeroView_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Zero.ZeroView);

            field = type.GetField("aViewClass", flag);
            app.RegisterCLRFieldGetter(field, get_aViewClass_0);
            app.RegisterCLRFieldSetter(field, set_aViewClass_0);
            field = type.GetField("aViewObject", flag);
            app.RegisterCLRFieldGetter(field, get_aViewObject_1);
            app.RegisterCLRFieldSetter(field, set_aViewObject_1);


        }



        static object get_aViewClass_0(ref object o)
        {
            return ((Zero.ZeroView)o).aViewClass;
        }
        static void set_aViewClass_0(ref object o, object v)
        {
            ((Zero.ZeroView)o).aViewClass = (System.String)v;
        }
        static object get_aViewObject_1(ref object o)
        {
            return ((Zero.ZeroView)o).aViewObject;
        }
        static void set_aViewObject_1(ref object o, object v)
        {
            ((Zero.ZeroView)o).aViewObject = (System.Object)v;
        }


    }
}
