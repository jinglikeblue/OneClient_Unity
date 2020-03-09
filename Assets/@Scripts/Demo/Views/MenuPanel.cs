using Google.Protobuf;
using One;
using System;
using UnityEngine;
using UnityEngine.UI;
using Zero;
using ZeroHot;

namespace ILDemo
{
    public class MenuPanel : AView
    {
        GameObject buttonPrefab;
        Transform content;

        protected override void OnInit(object data)
        {
            base.OnInit(data);
            buttonPrefab.SetActive(false);

            //AddBtn("Roushan", RoushanTest);
            AddBtn("Connect Server", ConnectServer);
            AddBtn("Test Protobuf", TestProtobuf);
        }

        private void ConnectServer()
        {
            
        }

        void RoushanTest()
        {
            UIPanelMgr.Ins.Switch<StartupPanel>();
        }

        void AddBtn(string label, Action action)
        {
            var go = GameObject.Instantiate(buttonPrefab, content);
            go.name = label;
            go.SetActive(true);
            go.GetComponentInChildren<Text>().text = label;            
            go.GetComponent<Button>().onClick.AddListener(() => { action.Invoke(); });           
        }

        void TestProtobuf()
        {
            var login = new ReqLogin();
            login.Nickname = "Jing";

            var msg = new ProtoPackage();
            msg.MsgId = 1;
            msg.MsgBody = login.ToByteString();


            Dumper.Dump(msg);

            byte[] bytes = msg.ToByteArray();
            var obj = ProtoPackage.Parser.ParseFrom(bytes);
            var obj1 = ReqLogin.Parser.ParseFrom(msg.MsgBody);            
            Debug.Log(Log.C(Log.COLOR_PURPLE, obj1.Nickname));            
        }
    }
}
