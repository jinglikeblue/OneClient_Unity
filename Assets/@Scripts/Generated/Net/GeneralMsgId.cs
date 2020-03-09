//命名空间和proto文件一致
namespace General
{
    /// <summary>
    /// push:推送消息(S2C) req:请求消息(C2S) resp:回复消息(S2C)
    /// </summary>
    class GeneralMsgId //proto文件名 + "MsgId"
    {

        //定义武将信息结构
        public const int  general_info = 24;

        //获取所有武将信息
        public const int  req_getAll = 25;

        
        public const int  rsp_getAll = 26;

        //武将布阵
        public const int  req_embattle = 27;

        
        public const int  rsp_embattle = 28;

    }
}
