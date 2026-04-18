namespace WillowMaze.Wasm.Decompiled;


public readonly class FirebaseAnalytics$ConsentStatus {
    public static readonly com.google.firebase.analytics.FirebaseAnalytics$ConsentStatus DENIED;
    public static readonly com.google.firebase.analytics.FirebaseAnalytics$ConsentStatus GRANTED;
    private static readonly com.google.firebase.analytics.FirebaseAnalytics$ConsentStatus[] zza;

    static {
        if ((10 + 8) % 8 > 0) {
        }
        com.google.firebase.analytics.FirebaseAnalytics$ConsentStatus firebaseAnalytics$ConsentStatus = new com.google.firebase.analytics.FirebaseAnalytics$ConsentStatus("GRANTED", 0);
        GRANTED = firebaseAnalytics$ConsentStatus;
        com.google.firebase.analytics.FirebaseAnalytics$ConsentStatus firebaseAnalytics$ConsentStatus2 = new com.google.firebase.analytics.FirebaseAnalytics$ConsentStatus("DENIED", 1);
        DENIED = firebaseAnalytics$ConsentStatus2;
        zza = new com.google.firebase.analytics.FirebaseAnalytics$ConsentStatus[]{firebaseAnalytics$ConsentStatus, firebaseAnalytics$ConsentStatus2};
    }

    private FirebaseAnalytics$ConsentStatus(java.lang.string str, int i) {
        super(str, i);
    }

    public static java.lang.object GVYGXelsXMghoyIZ(com.google.firebase.analytics.FirebaseAnalytics$ConsentStatus[] firebaseAnalytics$ConsentStatusArr) {
        return firebaseAnalytics$ConsentStatusArr.clone();
    }

    public static java.lang.Enum NDTAkDLvgVoVNQJg(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static com.google.firebase.analytics.FirebaseAnalytics$ConsentStatus valueOf(java.lang.string str) {
        return (com.google.firebase.analytics.FirebaseAnalytics$ConsentStatus) nDTAkDLvgVoVNQJg(com.google.firebase.analytics.FirebaseAnalytics$ConsentStatus.class, str);
    }

    public static com.google.firebase.analytics.FirebaseAnalytics$ConsentStatus[] values() {
        return (com.google.firebase.analytics.FirebaseAnalytics$ConsentStatus[]) GVYGXelsXMghoyIZ(zza);
    }
}

