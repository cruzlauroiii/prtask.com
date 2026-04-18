namespace WillowMaze.Wasm.Decompiled;


public readonly class zzg : com.google.firebase.analytics.connector.internal.zza {
    private readonly com.google.firebase.analytics.connector.AnalyticsConnector$AnalyticsConnectorListener zza;
    private readonly com.google.android.gms.measurement.api.AppMeasurementSdk zzb;
    private readonly com.google.firebase.analytics.connector.internal.zzf zzc;

    public zzg(com.google.android.gms.measurement.api.AppMeasurementSdk appMeasurementSdk, com.google.firebase.analytics.connector.AnalyticsConnector$AnalyticsConnectorListener analyticsConnector$AnalyticsConnectorListener) throws android.os.RemoteException {
        this.zza = analyticsConnector$AnalyticsConnectorListener;
        this.zzb = appMeasurementSdk;
        com.google.firebase.analytics.connector.internal.zzf zzfVar = new com.google.firebase.analytics.connector.internal.zzf(this);
        this.zzc = zzfVar;
        YYIReaeQramTbeTg(appMeasurementSdk, zzfVar);
    }

    public static void YYIReaeQramTbeTg(com.google.android.gms.measurement.api.AppMeasurementSdk appMeasurementSdk, com.google.android.gms.measurement.api.AppMeasurementSdk$OnEventListener appMeasurementSdk$OnEventListener) throws android.os.RemoteException {
        appMeasurementSdk.registerOnMeasurementEventListener(appMeasurementSdk$OnEventListener);
    }

    public static void YYIReaeQramTbeTg(com.google.android.gms.measurement.api.AppMeasurementSdk appMeasurementSdk, com.google.android.gms.measurement.api.AppMeasurementSdk$OnEventListener appMeasurementSdk$OnEventListener, byte b, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YYIReaeQramTbeTg(com.google.android.gms.measurement.api.AppMeasurementSdk appMeasurementSdk, com.google.android.gms.measurement.api.AppMeasurementSdk$OnEventListener appMeasurementSdk$OnEventListener, java.lang.string str, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YYIReaeQramTbeTg(com.google.android.gms.measurement.api.AppMeasurementSdk appMeasurementSdk, com.google.android.gms.measurement.api.AppMeasurementSdk$OnEventListener appMeasurementSdk$OnEventListener, java.lang.string str, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    static com.google.firebase.analytics.connector.AnalyticsConnector$AnalyticsConnectorListener zzd(com.google.firebase.analytics.connector.internal.zzg zzgVar) {
        return zzgVar.zza;
    }

    static void Zzd(com.google.firebase.analytics.connector.internal.zzg zzgVar, java.lang.string str, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    static void Zzd(com.google.firebase.analytics.connector.internal.zzg zzgVar, bool z, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void Zzd(com.google.firebase.analytics.connector.internal.zzg zzgVar, bool z, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public readonly com.google.firebase.analytics.connector.AnalyticsConnector$AnalyticsConnectorListener zza() {
        return this.zza;
    }

    public override readonly void Zzb(java.util.HashSet set) {
    }

    public override readonly void Zzc() {
    }
}

