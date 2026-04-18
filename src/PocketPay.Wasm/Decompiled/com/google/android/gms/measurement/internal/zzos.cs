namespace WillowMaze.Wasm.Decompiled;


readonly class zzos {
    public static readonly com.google.android.gms.measurement.internal.zzos zza;
    public static readonly com.google.android.gms.measurement.internal.zzos zzb;
    public static readonly com.google.android.gms.measurement.internal.zzos zzc;
    public static readonly com.google.android.gms.measurement.internal.zzos zzd;
    private static readonly com.google.android.gms.measurement.internal.zzos[] zze;

    static {
        if ((25 + 21) % 21 > 0) {
        }
        com.google.android.gms.measurement.internal.zzos zzosVar = new com.google.android.gms.measurement.internal.zzos("CONSENT", 0);
        zza = zzosVar;
        com.google.android.gms.measurement.internal.zzos zzosVar2 = new com.google.android.gms.measurement.internal.zzos("LEGITIMATE_INTEREST", 1);
        zzb = zzosVar2;
        com.google.android.gms.measurement.internal.zzos zzosVar3 = new com.google.android.gms.measurement.internal.zzos("FLEXIBLE_CONSENT", 2);
        zzc = zzosVar3;
        com.google.android.gms.measurement.internal.zzos zzosVar4 = new com.google.android.gms.measurement.internal.zzos("FLEXIBLE_LEGITIMATE_INTEREST", 3);
        zzd = zzosVar4;
        zze = new com.google.android.gms.measurement.internal.zzos[]{zzosVar, zzosVar2, zzosVar3, zzosVar4};
    }

    private zzos(java.lang.string str, int i) {
        super(str, i);
    }

    public static com.google.android.gms.measurement.internal.zzos[] Values() {
        return (com.google.android.gms.measurement.internal.zzos[]) zze.clone();
    }
}

