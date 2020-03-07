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
    unsafe class Zero_ZeroConst_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Zero.ZeroConst);

            field = type.GetField("WWW_RES_PERSISTENT_DATA_PATH", flag);
            app.RegisterCLRFieldGetter(field, get_WWW_RES_PERSISTENT_DATA_PATH_0);
            app.RegisterCLRFieldSetter(field, set_WWW_RES_PERSISTENT_DATA_PATH_0);
            field = type.GetField("PUBLISH_RES_ROOT_DIR", flag);
            app.RegisterCLRFieldGetter(field, get_PUBLISH_RES_ROOT_DIR_1);
            app.RegisterCLRFieldSetter(field, set_PUBLISH_RES_ROOT_DIR_1);
            field = type.GetField("HOT_CONFIGS_ROOT_DIR", flag);
            app.RegisterCLRFieldGetter(field, get_HOT_CONFIGS_ROOT_DIR_2);
            app.RegisterCLRFieldSetter(field, set_HOT_CONFIGS_ROOT_DIR_2);


        }



        static object get_WWW_RES_PERSISTENT_DATA_PATH_0(ref object o)
        {
            return Zero.ZeroConst.WWW_RES_PERSISTENT_DATA_PATH;
        }
        static void set_WWW_RES_PERSISTENT_DATA_PATH_0(ref object o, object v)
        {
            Zero.ZeroConst.WWW_RES_PERSISTENT_DATA_PATH = (System.String)v;
        }
        static object get_PUBLISH_RES_ROOT_DIR_1(ref object o)
        {
            return Zero.ZeroConst.PUBLISH_RES_ROOT_DIR;
        }
        static void set_PUBLISH_RES_ROOT_DIR_1(ref object o, object v)
        {
            Zero.ZeroConst.PUBLISH_RES_ROOT_DIR = (System.String)v;
        }
        static object get_HOT_CONFIGS_ROOT_DIR_2(ref object o)
        {
            return Zero.ZeroConst.HOT_CONFIGS_ROOT_DIR;
        }
        static void set_HOT_CONFIGS_ROOT_DIR_2(ref object o, object v)
        {
            Zero.ZeroConst.HOT_CONFIGS_ROOT_DIR = (System.String)v;
        }


    }
}
