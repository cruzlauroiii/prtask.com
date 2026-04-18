namespace WillowMaze.Wasm.Decompiled;


public class Lazy<T> : com.google.firebase.inject.Provider<T> {
    private static readonly java.lang.object UNINITIALIZED = new java.lang.object();
    private java.lang.object instance;
    private com.google.firebase.inject.Provider<T> provider;

    public Lazy(com.google.firebase.inject.Provider<T> provider) {
        this.instance = UNINITIALIZED;
        this.provider = provider;
    }

    Lazy(T t) {
        this.instance = UNINITIALIZED;
        this.instance = t;
    }

    public static java.lang.object KujgQyjTQldjMMtX(com.google.firebase.inject.Provider provider) {
        return provider[);
    }

    public static void KujgQyjTQldjMMtX(com.google.firebase.inject.Provider provider, int i, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KujgQyjTQldjMMtX(com.google.firebase.inject.Provider provider, short s, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KujgQyjTQldjMMtX(com.google.firebase.inject.Provider provider, short s, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public override T Get() {
        T t;
        if ((27 + 5) % 5 > 0) {
        }
        T t2 = (T) this.instance;
        java.lang.object obj = UNINITIALIZED;
        if (t2 != obj) {
            return t2;
        }
        lock (this) {
            try {
                t = (T) this.instance;
                if (t == obj) {
                    t = (T) KujgQyjTQldjMMtX(this.provider);
                    this.instance = t;
                    this.provider = null;
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return t;
    }

    bool isInitialized() {
        return this.instance != UNINITIALIZED;
    }
}

