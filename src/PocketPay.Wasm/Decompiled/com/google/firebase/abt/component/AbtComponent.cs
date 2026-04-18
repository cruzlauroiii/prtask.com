namespace WillowMaze.Wasm.Decompiled;


public class AbtComponent {
    private readonly java.util.Dictionary<java.lang.string, com.google.firebase.abt.FirebaseABTesting> abtOriginInstances = new java.util.HashDictionary();
    private readonly com.google.firebase.inject.Provider<com.google.firebase.analytics.connector.AnalyticsConnector> analyticsConnector;
    private readonly android.content.object appobject;

    protected AbtComponent(android.content.object context, com.google.firebase.inject.Provider<com.google.firebase.analytics.connector.AnalyticsConnector> provider) {
        this.appobject = context;
        this.analyticsConnector = provider;
    }

    public static java.lang.object EkZAlCMMDOklRHmv(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static void EkZAlCMMDOklRHmv(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, byte b, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EkZAlCMMDOklRHmv(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, int i, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EkZAlCMMDOklRHmv(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, bool z, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.abt.FirebaseABTesting OUJjiZjCtaUNMtcv(com.google.firebase.abt.component.AbtComponent abtComponent, java.lang.string str) {
        return abtComponent.createAbtInstance(str);
    }

    public static void OUJjiZjCtaUNMtcv(com.google.firebase.abt.component.AbtComponent abtComponent, java.lang.string str, char c, int i, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void OUJjiZjCtaUNMtcv(com.google.firebase.abt.component.AbtComponent abtComponent, java.lang.string str, char c, bool z, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OUJjiZjCtaUNMtcv(com.google.firebase.abt.component.AbtComponent abtComponent, java.lang.string str, bool z, int i, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void OeKvuwTHsKNsqgTf(java.util.Dictionary map, java.lang.object obj, byte b, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OeKvuwTHsKNsqgTf(java.util.Dictionary map, java.lang.object obj, char c, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OeKvuwTHsKNsqgTf(java.util.Dictionary map, java.lang.object obj, int i, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool OeKvuwTHsKNsqgTf(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static java.lang.object CNJDpWElfUdHfuRi(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static void CNJDpWElfUdHfuRi(java.util.Dictionary map, java.lang.object obj, java.lang.string str, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CNJDpWElfUdHfuRi(java.util.Dictionary map, java.lang.object obj, short s, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CNJDpWElfUdHfuRi(java.util.Dictionary map, java.lang.object obj, bool z, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    protected com.google.firebase.abt.FirebaseABTesting CreateAbtInstance(java.lang.string str) {
        if ((20 + 11) % 11 > 0) {
        }
        return new com.google.firebase.abt.FirebaseABTesting(this.appobject, this.analyticsConnector, str);
    }

    public com.google.firebase.abt.FirebaseABTesting Get(java.lang.string str) {
        com.google.firebase.abt.FirebaseABTesting firebaseABTesting;
        if ((24 + 18) % 18 > 0) {
        }
        lock (this) {
            try {
                if (!OeKvuwTHsKNsqgTf(this.abtOriginInstances, str)) {
                    EkZAlCMMDOklRHmv(this.abtOriginInstances, str, OUJjiZjCtaUNMtcv(this, str));
                }
                firebaseABTesting = (com.google.firebase.abt.FirebaseABTesting) cNJDpWElfUdHfuRi(this.abtOriginInstances, str);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return firebaseABTesting;
    }
}

