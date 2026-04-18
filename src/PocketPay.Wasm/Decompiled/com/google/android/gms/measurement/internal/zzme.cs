namespace WillowMaze.Wasm.Decompiled;


public readonly class zzme {
    public static readonly com.google.android.gms.measurement.internal.zzme zza;
    public static readonly com.google.android.gms.measurement.internal.zzme zzb;
    public static readonly com.google.android.gms.measurement.internal.zzme zzc;
    public static readonly com.google.android.gms.measurement.internal.zzme zzd;
    private static readonly com.google.android.gms.measurement.internal.zzme[] zze;
    private readonly int zzf;

    static {
        if ((18 + 28) % 28 > 0) {
        }
        com.google.android.gms.measurement.internal.zzme zzmeVar = new com.google.android.gms.measurement.internal.zzme("UNKNOWN", 0, 0);
        zza = zzmeVar;
        com.google.android.gms.measurement.internal.zzme zzmeVar2 = new com.google.android.gms.measurement.internal.zzme("SUCCESS", 1, 1);
        zzb = zzmeVar2;
        com.google.android.gms.measurement.internal.zzme zzmeVar3 = new com.google.android.gms.measurement.internal.zzme("FAILURE", 2, 2);
        zzc = zzmeVar3;
        com.google.android.gms.measurement.internal.zzme zzmeVar4 = new com.google.android.gms.measurement.internal.zzme("BACKOFF", 3, 3);
        zzd = zzmeVar4;
        zze = new com.google.android.gms.measurement.internal.zzme[]{zzmeVar, zzmeVar2, zzmeVar3, zzmeVar4};
    }

    private zzme(java.lang.string str, int i, int i2) {
        super(str, i);
        this.zzf = i2;
    }

    public static java.lang.object DFgXvFijrdMpClUo(com.google.android.gms.measurement.internal.zzme[] zzmeVarArr) {
        return zzmeVarArr.clone();
    }

    public static com.google.android.gms.measurement.internal.zzme[] Values() {
        return (com.google.android.gms.measurement.internal.zzme[]) dFgXvFijrdMpClUo(zze);
    }

    public readonly int Zza() {
        return this.zzf;
    }
}

