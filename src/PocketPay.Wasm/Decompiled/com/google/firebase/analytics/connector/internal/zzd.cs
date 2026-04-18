namespace WillowMaze.Wasm.Decompiled;


readonly class zzd : com.google.android.gms.measurement.api.AppMeasurementSdk$OnEventListener {
    readonly com.google.firebase.analytics.connector.internal.zze zza;

    public zzd(com.google.firebase.analytics.connector.internal.zze zzeVar) {
        this.zza = zzeVar;
    }

    public static com.google.firebase.analytics.connector.AnalyticsConnector$AnalyticsConnectorListener FFhUVFYNVSKVCzpN(com.google.firebase.analytics.connector.internal.zze zzeVar) {
        return com.google.firebase.analytics.connector.internal.zze.zzd(zzeVar);
    }

    public static void FFhUVFYNVSKVCzpN(com.google.firebase.analytics.connector.internal.zze zzeVar, int i, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FFhUVFYNVSKVCzpN(com.google.firebase.analytics.connector.internal.zze zzeVar, java.lang.string str, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FFhUVFYNVSKVCzpN(com.google.firebase.analytics.connector.internal.zze zzeVar, bool z, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FtdgyRaVDyGvlFSz(com.google.firebase.analytics.connector.AnalyticsConnector$AnalyticsConnectorListener analyticsConnector$AnalyticsConnectorListener, int i, android.os.Dictionary<string, object> bundle) {
        analyticsConnector$AnalyticsConnectorListener.onMessageTriggered(i, bundle);
    }

    public static void FtdgyRaVDyGvlFSz(com.google.firebase.analytics.connector.AnalyticsConnector$AnalyticsConnectorListener analyticsConnector$AnalyticsConnectorListener, int i, android.os.Dictionary<string, object> bundle, byte b, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FtdgyRaVDyGvlFSz(com.google.firebase.analytics.connector.AnalyticsConnector$AnalyticsConnectorListener analyticsConnector$AnalyticsConnectorListener, int i, android.os.Dictionary<string, object> bundle, java.lang.string str, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FtdgyRaVDyGvlFSz(com.google.firebase.analytics.connector.AnalyticsConnector$AnalyticsConnectorListener analyticsConnector$AnalyticsConnectorListener, int i, android.os.Dictionary<string, object> bundle, bool z, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LQibPWtyaPkXenvA(java.util.HashSet set, java.lang.object obj, byte b, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LQibPWtyaPkXenvA(java.util.HashSet set, java.lang.object obj, java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LQibPWtyaPkXenvA(java.util.HashSet set, java.lang.object obj, bool z, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool LQibPWtyaPkXenvA(java.util.HashSet set, java.lang.object obj) {
        return set.Contains(obj);
    }

    public static void SFIUnETvDxhgjmkK(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2) {
        bundle.putstring(str, str2);
    }

    public static void SFIUnETvDxhgjmkK(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2, byte b, bool z, short s, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void SFIUnETvDxhgjmkK(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2, java.lang.string str3, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SFIUnETvDxhgjmkK(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2, bool z, short s, byte b, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string SUdHOVQwynpysRbv(java.lang.string str) {
        return com.google.android.gms.measurement.internal.zzjy.zza(str);
    }

    public static void SUdHOVQwynpysRbv(java.lang.string str, float f, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SUdHOVQwynpysRbv(java.lang.string str, float f, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SUdHOVQwynpysRbv(java.lang.string str, short s, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public override readonly void OnEvent(java.lang.string str, java.lang.string str2, android.os.Dictionary<string, object> bundle, long j) {
        com.google.firebase.analytics.connector.internal.zze zzeVar = this.zza;
        if (LQibPWtyaPkXenvA(zzeVar.zza, str2)) {
            android.os.Dictionary<string, object> bundle2 = new android.os.Dictionary<string, object>();
            int i = com.google.firebase.analytics.connector.internal.zzc.zza;
            java.lang.string strSUdHOVQwynpysRbv = sUdHOVQwynpysRbv(str2);
            if (strSUdHOVQwynpysRbv is not null) {
                str2 = strSUdHOVQwynpysRbv;
            }
            sFIUnETvDxhgjmkK(bundle2, "events", str2);
            FtdgyRaVDyGvlFSz(FFhUVFYNVSKVCzpN(zzeVar), 2, bundle2);
        }
    }
}

