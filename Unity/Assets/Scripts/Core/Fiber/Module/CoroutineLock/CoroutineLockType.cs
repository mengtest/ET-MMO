namespace ET
{
    public static class CoroutineLockType
    {
        public const int None = 0;
        public const int Location = 1;                  // location进程上使用
        public const int MessageLocationSender = 2;       // MessageLocationSender中队列消息 
        public const int Mailbox = 3;                   // Mailbox中队列
        public const int UnitId = 4;                    // Map服务器上线下线时使用
        public const int DB = 5;
        public const int Resources = 6;
        public const int ResourcesLoader = 7;

        public const int GetRoles = 8;
        public const int CreateRole = 9; //创建角色
        public const int DeleteRole = 10;
        public const int LoginReam = 11;
        public const int LoginGameGate = 12;
        public const int EnterGameMap = 13;

        
        public const int LoadUIBaseWindows = 20;


        public const int Max = 100; // 这个必须最大
    }
}