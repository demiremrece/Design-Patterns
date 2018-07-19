 public sealed class SingletonClass
{
    private static volatile SingletonClass instance;
    private static object _lockerObject = new object();
    private SingletonClass() { 
        // private constructor. Sadece SingletonClass içerisinde kullanılabilir.
    }

    public static SingletonClass getInstance()
    {
        // eğer instance null değilse thread-safe olmasına bakmaksızın instance döndürülür.
        if (instance == null)
        {
            // eğer null ise artık bu bloğa eş zamanlı olarak birden fazla threadin
            // kilitlenmesine, erişmesine izin vermiyoruz.
            lock (_lockerObject)
            {
                // yukarıdaki nedenden dolayıdır ki, bir kez daha instance'ın
                // null olma durumunu konrol ediyoruz
                if (instance == null)
                {
                    instance = new SingletonClass();
                }
            }
        }

        return instance;
    }
}