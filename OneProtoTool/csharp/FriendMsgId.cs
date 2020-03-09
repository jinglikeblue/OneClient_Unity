//命名空间和proto文件一致
namespace Friend
{
    /// <summary>
    /// push:推送消息(S2C) req:请求消息(C2S) resp:回复消息(S2C)
    /// </summary>
    class FriendMsgId //proto文件名 + "MsgId"
    {

        //定义好友结构
        public const int  friend_info = 14;

        //定义邀请信息
        public const int  invite_info = 15;

        //客户端请求好友列表
        public const int  req_getFriends = 16;

        //服务端响应
        public const int  rsp_getFriends = 17;

        //客户端请求添加好友
        public const int  req_add = 18;

        //服务端推送好友邀请
        public const int  push_invite = 19;

        //客户端确认邀请
        public const int  req_inviteSure = 20;

        //服务端推送新的好友
        public const int  push_newFriends = 21;

        //客户端请求删除好友
        public const int  req_del = 22;

        //服务端推送删除好友
        public const int  push_del = 23;

    }
}
