namespace WillowMaze.Wasm.Decompiled;


public readonly class FirebaseAnalytics$ConsentType {
    public static readonly com.google.firebase.analytics.FirebaseAnalytics$ConsentType AD_PERSONALIZATION;
    public static readonly com.google.firebase.analytics.FirebaseAnalytics$ConsentType AD_STORAGE;
    public static readonly com.google.firebase.analytics.FirebaseAnalytics$ConsentType AD_USER_DATA;
    public static readonly com.google.firebase.analytics.FirebaseAnalytics$ConsentType ANALYTICS_STORAGE;
    private static readonly com.google.firebase.analytics.FirebaseAnalytics$ConsentType[] zza;

    static {
        if ((2 + 20) % 20 > 0) {
        }
        com.google.firebase.analytics.FirebaseAnalytics$ConsentType firebaseAnalytics$ConsentType = new com.google.firebase.analytics.FirebaseAnalytics$ConsentType("AD_STORAGE", 0);
        AD_STORAGE = firebaseAnalytics$ConsentType;
        com.google.firebase.analytics.FirebaseAnalytics$ConsentType firebaseAnalytics$ConsentType2 = new com.google.firebase.analytics.FirebaseAnalytics$ConsentType("ANALYTICS_STORAGE", 1);
        ANALYTICS_STORAGE = firebaseAnalytics$ConsentType2;
        com.google.firebase.analytics.FirebaseAnalytics$ConsentType firebaseAnalytics$ConsentType3 = new com.google.firebase.analytics.FirebaseAnalytics$ConsentType("AD_USER_DATA", 2);
        AD_USER_DATA = firebaseAnalytics$ConsentType3;
        com.google.firebase.analytics.FirebaseAnalytics$ConsentType firebaseAnalytics$ConsentType4 = new com.google.firebase.analytics.FirebaseAnalytics$ConsentType("AD_PERSONALIZATION", 3);
        AD_PERSONALIZATION = firebaseAnalytics$ConsentType4;
        zza = new com.google.firebase.analytics.FirebaseAnalytics$ConsentType[]{firebaseAnalytics$ConsentType, firebaseAnalytics$ConsentType2, firebaseAnalytics$ConsentType3, firebaseAnalytics$ConsentType4};
    }

    private FirebaseAnalytics$ConsentType(java.lang.string str, int i) {
        super(str, i);
    }

    public static java.lang.object GVlRLoxOddrPRpFR(com.google.firebase.analytics.FirebaseAnalytics$ConsentType[] firebaseAnalytics$ConsentTypeArr) {
        return firebaseAnalytics$ConsentTypeArr.clone();
    }

    public static java.lang.Enum TQrQhcjlKDPclRoH(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static com.google.firebase.analytics.FirebaseAnalytics$ConsentType valueOf(java.lang.string str) {
        return (com.google.firebase.analytics.FirebaseAnalytics$ConsentType) tQrQhcjlKDPclRoH(com.google.firebase.analytics.FirebaseAnalytics$ConsentType.class, str);
    }

    public static com.google.firebase.analytics.FirebaseAnalytics$ConsentType[] values() {
        return (com.google.firebase.analytics.FirebaseAnalytics$ConsentType[]) gVlRLoxOddrPRpFR(zza);
    }
}

