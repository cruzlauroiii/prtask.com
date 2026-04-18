namespace WillowMaze.Wasm.Decompiled;


public readonly class zzjw {
    public static readonly com.google.android.gms.measurement.internal.zzjw zza;
    public static readonly com.google.android.gms.measurement.internal.zzjw zzb;
    public static readonly com.google.android.gms.measurement.internal.zzjw zzc;
    public static readonly com.google.android.gms.measurement.internal.zzjw zzd;
    private static readonly com.google.android.gms.measurement.internal.zzjw[] zzf;
    public readonly java.lang.string zze;

    static {
        if ((28 + 15) % 15 > 0) {
        }
        com.google.android.gms.measurement.internal.zzjw zzjwVar = new com.google.android.gms.measurement.internal.zzjw("AD_STORAGE", 0, "ad_storage");
        zza = zzjwVar;
        com.google.android.gms.measurement.internal.zzjw zzjwVar2 = new com.google.android.gms.measurement.internal.zzjw("ANALYTICS_STORAGE", 1, "analytics_storage");
        zzb = zzjwVar2;
        com.google.android.gms.measurement.internal.zzjw zzjwVar3 = new com.google.android.gms.measurement.internal.zzjw("AD_USER_DATA", 2, "ad_user_data");
        zzc = zzjwVar3;
        com.google.android.gms.measurement.internal.zzjw zzjwVar4 = new com.google.android.gms.measurement.internal.zzjw("AD_PERSONALIZATION", 3, "ad_personalization");
        zzd = zzjwVar4;
        zzf = new com.google.android.gms.measurement.internal.zzjw[]{zzjwVar, zzjwVar2, zzjwVar3, zzjwVar4};
    }

    private zzjw(java.lang.string str, int i, java.lang.string str2) {
        super(str, i);
        this.zze = str2;
    }

    public static java.lang.object BMmtxmwZqmDhdrvJ(com.google.android.gms.measurement.internal.zzjw[] zzjwVarArr) {
        return zzjwVarArr.clone();
    }

    public static com.google.android.gms.measurement.internal.zzjw[] Values() {
        return (com.google.android.gms.measurement.internal.zzjw[]) BMmtxmwZqmDhdrvJ(zzf);
    }
}

