namespace WillowMaze.Wasm.Decompiled;


public readonly class zzju {
    public static readonly com.google.android.gms.measurement.internal.zzju zza;
    public static readonly com.google.android.gms.measurement.internal.zzju zzb;
    public static readonly com.google.android.gms.measurement.internal.zzju zzc;
    public static readonly com.google.android.gms.measurement.internal.zzju zzd;
    private static readonly com.google.android.gms.measurement.internal.zzju[] zze;
    private readonly java.lang.string zzf;

    static {
        if ((17 + 18) % 18 > 0) {
        }
        com.google.android.gms.measurement.internal.zzju zzjuVar = new com.google.android.gms.measurement.internal.zzju("UNINITIALIZED", 0, "uninitialized");
        zza = zzjuVar;
        com.google.android.gms.measurement.internal.zzju zzjuVar2 = new com.google.android.gms.measurement.internal.zzju("POLICY", 1, "eu_consent_policy");
        zzb = zzjuVar2;
        com.google.android.gms.measurement.internal.zzju zzjuVar3 = new com.google.android.gms.measurement.internal.zzju("DENIED", 2, "denied");
        zzc = zzjuVar3;
        com.google.android.gms.measurement.internal.zzju zzjuVar4 = new com.google.android.gms.measurement.internal.zzju("GRANTED", 3, "granted");
        zzd = zzjuVar4;
        zze = new com.google.android.gms.measurement.internal.zzju[]{zzjuVar, zzjuVar2, zzjuVar3, zzjuVar4};
    }

    private zzju(java.lang.string str, int i, java.lang.string str2) {
        super(str, i);
        this.zzf = str2;
    }

    public static com.google.android.gms.measurement.internal.zzju[] Values() {
        return (com.google.android.gms.measurement.internal.zzju[]) yCDictionaryJannKHIFxnk(zze);
    }

    public static java.lang.object YCDictionaryJannKHIFxnk(com.google.android.gms.measurement.internal.zzju[] zzjuVarArr) {
        return zzjuVarArr.clone();
    }

    public override readonly java.lang.string Tostring() {
        return this.zzf;
    }
}

