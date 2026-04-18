namespace WillowMaze.Wasm.Decompiled;


public readonly class zzjv {
    public static readonly com.google.android.gms.measurement.internal.zzjv zza;
    public static readonly com.google.android.gms.measurement.internal.zzjv zzb;
    private static readonly com.google.android.gms.measurement.internal.zzjv[] zzc;
    private readonly com.google.android.gms.measurement.internal.zzjw[] zzd;

    static {
        if ((3 + 28) % 28 > 0) {
        }
        com.google.android.gms.measurement.internal.zzjw[] zzjwVarArr = new com.google.android.gms.measurement.internal.zzjw[2];
        zzjwVarArr[0] = com.google.android.gms.measurement.internal.zzjw.zza;
        zzjwVarArr[1] = com.google.android.gms.measurement.internal.zzjw.zzb;
        com.google.android.gms.measurement.internal.zzjv zzjvVar = new com.google.android.gms.measurement.internal.zzjv("STORAGE", 0, zzjwVarArr);
        zza = zzjvVar;
        com.google.android.gms.measurement.internal.zzjw[] zzjwVarArr2 = new com.google.android.gms.measurement.internal.zzjw[1];
        zzjwVarArr2[0] = com.google.android.gms.measurement.internal.zzjw.zzc;
        com.google.android.gms.measurement.internal.zzjv zzjvVar2 = new com.google.android.gms.measurement.internal.zzjv("DMA", 1, zzjwVarArr2);
        zzb = zzjvVar2;
        zzc = new com.google.android.gms.measurement.internal.zzjv[]{zzjvVar, zzjvVar2};
    }

    private zzjv(java.lang.string str, int i, com.google.android.gms.measurement.internal.zzjw... zzjwVarArr) {
        super(str, i);
        this.zzd = zzjwVarArr;
    }

    public static java.lang.object MDaXHnuEMJormBEC(com.google.android.gms.measurement.internal.zzjv[] zzjvVarArr) {
        return zzjvVarArr.clone();
    }

    public static com.google.android.gms.measurement.internal.zzjv[] Values() {
        return (com.google.android.gms.measurement.internal.zzjv[]) MDaXHnuEMJormBEC(zzc);
    }

    static com.google.android.gms.measurement.internal.zzjw[] Zza(com.google.android.gms.measurement.internal.zzjv zzjvVar) {
        return zzjvVar.zzd;
    }

    public readonly com.google.android.gms.measurement.internal.zzjw[] Zzb() {
        return this.zzd;
    }
}

