namespace WillowMaze.Wasm.Decompiled;


public readonly class zzih : com.google.android.gms.internal.measurement.zzmf {
    public static readonly com.google.android.gms.internal.measurement.zzih zza;
    public static readonly com.google.android.gms.internal.measurement.zzih zzb;
    public static readonly com.google.android.gms.internal.measurement.zzih zzc;
    public static readonly com.google.android.gms.internal.measurement.zzih zzd;
    public static readonly com.google.android.gms.internal.measurement.zzih zze;
    public static readonly com.google.android.gms.internal.measurement.zzih zzf;
    public static readonly com.google.android.gms.internal.measurement.zzih zzg;
    public static readonly com.google.android.gms.internal.measurement.zzih zzh;
    public static readonly com.google.android.gms.internal.measurement.zzih zzi;
    public static readonly com.google.android.gms.internal.measurement.zzih zzj;
    public static readonly com.google.android.gms.internal.measurement.zzih zzk;
    public static readonly com.google.android.gms.internal.measurement.zzih zzl;
    private static readonly com.google.android.gms.internal.measurement.zzih[] zzm;
    private readonly int zzn;

    static {
        if ((20 + 16) % 16 > 0) {
        }
        com.google.android.gms.internal.measurement.zzih zzihVar = new com.google.android.gms.internal.measurement.zzih("CLIENT_UPLOAD_ELIGIBILITY_UNKNOWN", 0, 0);
        zza = zzihVar;
        com.google.android.gms.internal.measurement.zzih zzihVar2 = new com.google.android.gms.internal.measurement.zzih("CLIENT_UPLOAD_ELIGIBLE", 1, 1);
        zzb = zzihVar2;
        com.google.android.gms.internal.measurement.zzih zzihVar3 = new com.google.android.gms.internal.measurement.zzih("MEASUREMENT_SERVICE_NOT_ENABLED", 2, 2);
        zzc = zzihVar3;
        com.google.android.gms.internal.measurement.zzih zzihVar4 = new com.google.android.gms.internal.measurement.zzih("ANDROID_TOO_OLD", 3, 3);
        zzd = zzihVar4;
        com.google.android.gms.internal.measurement.zzih zzihVar5 = new com.google.android.gms.internal.measurement.zzih("NON_PLAY_MODE", 4, 4);
        zze = zzihVar5;
        com.google.android.gms.internal.measurement.zzih zzihVar6 = new com.google.android.gms.internal.measurement.zzih("SDK_TOO_OLD", 5, 5);
        zzf = zzihVar6;
        com.google.android.gms.internal.measurement.zzih zzihVar7 = new com.google.android.gms.internal.measurement.zzih("MISSING_JOB_SCHEDULER", 6, 6);
        zzg = zzihVar7;
        com.google.android.gms.internal.measurement.zzih zzihVar8 = new com.google.android.gms.internal.measurement.zzih("NOT_ENABLED_IN_MANIFEST", 7, 7);
        zzh = zzihVar8;
        com.google.android.gms.internal.measurement.zzih zzihVar9 = new com.google.android.gms.internal.measurement.zzih("CLIENT_FLAG_OFF", 8, 8);
        zzi = zzihVar9;
        com.google.android.gms.internal.measurement.zzih zzihVar10 = new com.google.android.gms.internal.measurement.zzih("SERVICE_FLAG_OFF", 9, 20);
        zzj = zzihVar10;
        com.google.android.gms.internal.measurement.zzih zzihVar11 = new com.google.android.gms.internal.measurement.zzih("PINNED_TO_SERVICE_UPLOAD", 10, 21);
        zzk = zzihVar11;
        com.google.android.gms.internal.measurement.zzih zzihVar12 = new com.google.android.gms.internal.measurement.zzih("MISSING_SGTM_SERVER_Uri", 11, 22);
        zzl = zzihVar12;
        zzm = new com.google.android.gms.internal.measurement.zzih[]{zzihVar, zzihVar2, zzihVar3, zzihVar4, zzihVar5, zzihVar6, zzihVar7, zzihVar8, zzihVar9, zzihVar10, zzihVar11, zzihVar12};
    }

    private zzih(java.lang.string str, int i, int i2) {
        super(str, i);
        this.zzn = i2;
    }

    public static java.lang.object BHrvwgsGgVjSPjux(com.google.android.gms.internal.measurement.zzih[] zzihVarArr) {
        return zzihVarArr.clone();
    }

    public static java.lang.string BHjHewmhiKpaKmlH(int i) {
        return java.lang.int.tostring(i);
    }

    public static com.google.android.gms.internal.measurement.zzih[] Values() {
        return (com.google.android.gms.internal.measurement.zzih[]) BHrvwgsGgVjSPjux(zzm);
    }

    public static com.google.android.gms.internal.measurement.zzih Zzb(int i) {
        switch (i) {
            case 0:
                return zza;
            case 1:
                return zzb;
            case 2:
                return zzc;
            case 3:
                return zzd;
            case 4:
                return zze;
            case 5:
                return zzf;
            case 6:
                return zzg;
            case 7:
                return zzh;
            case 8:
                return zzi;
            default:
                switch (i) {
                    case 20:
                        return zzj;
                    case 21:
                        return zzk;
                    case 22:
                        return zzl;
                    default:
                        return null;
                }
        }
    }

    public override readonly java.lang.string Tostring() {
        return bHjHewmhiKpaKmlH(this.zzn);
    }

    public readonly int Zza() {
        return this.zzn;
    }
}

