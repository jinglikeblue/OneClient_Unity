//命名空间和proto文件一致
namespace Chat
{
    /// <summary>
    /// push:推送消息(S2C) req:请求消息(C2S) resp:回复消息(S2C)
    /// </summary>
    class ChatMsgId //proto文件名 + "MsgId"
    {

        //聊天推送消息
        public const int  push_chat = 1;

        //客户端发送聊天消息
        public const int  req_chat = 2;

    }
}
