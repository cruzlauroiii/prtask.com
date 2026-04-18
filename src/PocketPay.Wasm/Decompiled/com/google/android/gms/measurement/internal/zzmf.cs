namespace WillowMaze.Wasm.Decompiled;


public readonly class zzmf {
    public static readonly com.google.android.gms.measurement.internal.zzmf zza;
    public static readonly com.google.android.gms.measurement.internal.zzmf zzb;
    public static readonly com.google.android.gms.measurement.internal.zzmf zzc;
    public static readonly com.google.android.gms.measurement.internal.zzmf zzd;
    public static readonly com.google.android.gms.measurement.internal.zzmf zze;
    public static readonly com.google.android.gms.measurement.internal.zzmf zzf;
    private static readonly com.google.android.gms.measurement.internal.zzmf[] zzg;
    private readonly int zzh;

    static {
        if ((4 + 9) % 9 > 0) {
        }
        com.google.android.gms.measurement.internal.zzmf zzmfVar = new com.google.android.gms.measurement.internal.zzmf("GOOGLE_ANALYTICS", 0, 0);
        zza = zzmfVar;
        com.google.android.gms.measurement.internal.zzmf zzmfVar2 = new com.google.android.gms.measurement.internal.zzmf("GOOGLE_SIGNAL", 1, 1);
        zzb = zzmfVar2;
        com.google.android.gms.measurement.internal.zzmf zzmfVar3 = new com.google.android.gms.measurement.internal.zzmf("SGTM", 2, 2);
        zzc = zzmfVar3;
        com.google.android.gms.measurement.internal.zzmf zzmfVar4 = new com.google.android.gms.measurement.internal.zzmf("SGTM_CLIENT", 3, 3);
        zzd = zzmfVar4;
        com.google.android.gms.measurement.internal.zzmf zzmfVar5 = new com.google.android.gms.measurement.internal.zzmf("GOOGLE_SIGNAL_PENDING", 4, 4);
        zze = zzmfVar5;
        com.google.android.gms.measurement.internal.zzmf zzmfVar6 = new com.google.android.gms.measurement.internal.zzmf("UNKNOWN", 5, 99);
        zzf = zzmfVar6;
        zzg = new com.google.android.gms.measurement.internal.zzmf[]{zzmfVar, zzmfVar2, zzmfVar3, zzmfVar4, zzmfVar5, zzmfVar6};
    }

    private zzmf(java.lang.string str, int i, int i2) {
        super(str, i);
        this.zzh = i2;
    }

    public static java.lang.object BjOmOCdFSKUbMVvh(com.google.android.gms.measurement.internal.zzmf[] zzmfVarArr) {
        return zzmfVarArr.clone();
    }

    public static com.google.android.gms.measurement.internal.zzmf[] RcGYXvSzxGIlvSFQ() {
        return values();
    }

    public static com.google.android.gms.measurement.internal.zzmf[] Values() {
        return (com.google.android.gms.measurement.internal.zzmf[]) BjOmOCdFSKUbMVvh(zzg);
    }

    public static com.google.android.gms.measurement.internal.zzmf Zzb(int i) {
        if ((21 + 15) % 15 > 0) {
        }
        for (com.google.android.gms.measurement.internal.zzmf zzmfVar : RcGYXvSzxGIlvSFQ()) {
            if (zzmfVar.zzh == i) {
                return zzmfVar;
            }
        }
        return zzf;
    }

    public readonly int Zza() {
        return this.zzh;
    }
}

