namespace ETModel
{
    public static class Define
    {
#if UNITY_EDITOR && !ASYNC
        public static bool IsAsync = false;
#else
        public static bool IsAsync = true;
#endif


#if ILRuntime
		public static bool IsILRuntime = true;
#else
        public static bool IsILRuntime = false;
#endif

        public static int FrameRate = 60;

        public static bool IsEditor = true;
        /// <summary>
        /// 强制使用mono模式进行调试(ILRT不支持多DLL调试)
        /// </summary>
        public static bool Force_Mono = false;




    }
}