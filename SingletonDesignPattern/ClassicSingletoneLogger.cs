namespace SingletonDesignPattern
{
    /// <summary>
    /// lazy loading singletone
    /// </summary>
    public class ClassicSingletoneLogger : Singletone
    {
        private static ClassicSingletoneLogger instance;
        private ClassicSingletoneLogger()
        {
            
        }

        public static ClassicSingletoneLogger GetInstance() { 
            if(instance== null)
            {
                instance = new ClassicSingletoneLogger();
            }
            return instance; 
        }
    }
}
