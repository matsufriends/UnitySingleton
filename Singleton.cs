public abstract class Singleton<T> where T : new() {
    private static T sInstance;

    public static T Instance {
        get {
            if (sInstance != null) return sInstance;
            sInstance = new T();
            return sInstance;
        }
    }
}
