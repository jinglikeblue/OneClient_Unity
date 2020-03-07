using Chat;
using Google.Protobuf;
using System;
using UnityEngine;
using UnityEngine.UI;
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
            req_chat msg = new req_chat()
            {
                Content = "hello",
                Channel = chat_channel.ChatTypeRoom,
                Target = 1
            };

            Dumper.Dump(msg);

            byte[] bytes = msg.ToByteArray();
            var obj = req_chat.Parser.ParseFrom(bytes);
            Dumper.Dump(obj);
        }
    }
}
