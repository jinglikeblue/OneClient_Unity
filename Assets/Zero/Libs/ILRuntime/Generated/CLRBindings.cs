using System;
using System.Collections.Generic;
using System.Reflection;

namespace ILRuntime.Runtime.Generated
{
    class CLRBindings
    {


        /// <summary>
        /// Initialize the CLR binding, please invoke this AFTER CLR Redirection registration
        /// </summary>
        public static void Initialize(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            Google_Protobuf_ProtoPreconditions_Binding.Register(app);
            Google_Protobuf_CodedOutputStream_Binding.Register(app);
            System_String_Binding.Register(app);
            Google_Protobuf_CodedInputStream_Binding.Register(app);
            Google_Protobuf_MessageParser_1_Adapt_IMessage_Binding_Adaptor_Binding.Register(app);
            UnityEngine_Application_Binding.Register(app);
            Zero_AudioDevice_Binding.Register(app);
            Zero_ResMgr_Binding.Register(app);
            UnityEngine_Object_Binding.Register(app);
            Zero_GUIDeviceInfo_Binding.Register(app);
            UnityEngine_Debug_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_String_Double_Binding.Register(app);
            System_Int32_Binding.Register(app);
            System_Exception_Binding.Register(app);
            UnityEngine_GameObject_Binding.Register(app);
            UnityEngine_UI_Text_Binding.Register(app);
            UnityEngine_UI_Button_Binding.Register(app);
            UnityEngine_Events_UnityEvent_Binding.Register(app);
            System_Action_Binding.Register(app);
            System_Action_1_ILTypeInstance_Binding.Register(app);
            UnityEngine_Transform_Binding.Register(app);
            UnityEngine_Component_Binding.Register(app);
            Zero_ComponentUtil_Binding.Register(app);
            System_Collections_Generic_HashSet_1_ILTypeInstance_Binding.Register(app);
            System_Collections_Generic_List_1_ILTypeInstance_Binding.Register(app);
            System_Collections_Generic_List_1_ILTypeInstance_Binding_Enumerator_Binding.Register(app);
            System_IDisposable_Binding.Register(app);
            AEventListener_1_Physics2DEventListener_Binding.Register(app);
            Zero_Physics2DEventListener_Binding.Register(app);
            UnityEngine_Vector3_Binding.Register(app);
            UnityEngine_Vector2_Binding.Register(app);
            UnityEngine_Rigidbody2D_Binding.Register(app);
            Zero_ASingletonMonoBehaviour_1_ILBridge_Binding.Register(app);
            Zero_ILBridge_Binding.Register(app);
            AEventListener_1_UIEventListener_Binding.Register(app);
            Zero_UIEventListener_Binding.Register(app);
            Zero_ObjectBindingData_Binding.Register(app);
            System_Object_Binding.Register(app);
            Zero_StringBindingData_Binding.Register(app);
            UnityEngine_UI_RawImage_Binding.Register(app);
            Google_Protobuf_MessageExtensions_Binding.Register(app);
            System_Type_Binding.Register(app);
            System_Reflection_MemberInfo_Binding.Register(app);
            Zero_Log_Binding.Register(app);
            Jing_FileSystem_Binding.Register(app);
            System_IO_File_Binding.Register(app);
            System_Text_Encoding_Binding.Register(app);
            Zero_Runtime_Binding.Register(app);
            Zero_RuntimeVO_Binding.Register(app);
            Zero_ZeroConst_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_String_ILTypeInstance_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_String_ILTypeInstance_Binding_KeyCollection_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_String_ILTypeInstance_Binding_Enumerator_Binding.Register(app);
            System_Collections_Generic_KeyValuePair_2_String_ILTypeInstance_Binding.Register(app);
            System_Threading_Monitor_Binding.Register(app);
            System_Collections_Generic_List_1_Action_Binding.Register(app);
            System_Threading_Interlocked_Binding.Register(app);
            Zero_ZeroView_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_String_FieldInfo_Binding.Register(app);
            System_Reflection_FieldInfo_Binding.Register(app);
            System_Activator_Binding.Register(app);
            UnityEngine_MonoBehaviour_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_String_Dictionary_2_String_ILTypeInstance_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Type_ILTypeInstance_Binding.Register(app);
            System_Action_1_Object_Binding.Register(app);
            UnityEngine_RectTransform_Binding.Register(app);
            Zero_RectUtility_Binding.Register(app);
            System_Action_2_ILTypeInstance_Object_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_String_Object_Binding.Register(app);

            ILRuntime.CLR.TypeSystem.CLRType __clrType = null;
        }

        /// <summary>
        /// Release the CLR binding, please invoke this BEFORE ILRuntime Appdomain destroy
        /// </summary>
        public static void Shutdown(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
        }
    }
}
