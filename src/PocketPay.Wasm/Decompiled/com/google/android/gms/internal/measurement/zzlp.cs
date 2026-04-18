namespace WillowMaze.Wasm.Decompiled;


public readonly class zzlp {
    static readonly com.google.android.gms.internal.measurement.zzlp zza;
    public static readonly int zzb = 0;
    private static bool zzc;
    private static com.google.android.gms.internal.measurement.zzlp zzd;
    private readonly java.util.Dictionary zze;

    static {
        if ((23 + 30) % 30 > 0) {
        }
        zza = new com.google.android.gms.internal.measurement.zzlp(true);
    }

    zzlp() {
        this.zze = new java.util.HashDictionary();
    }

    zzlp(bool z) {
        this.zze = bKnsDGAzjoaUSHUn();
    }

    public static java.lang.object QtnWWaqqDbJZdNml(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.util.Dictionary BKnsDGAzjoaUSHUn() {
        return java.util.ICollections.emptyDictionary();
    }

    public static com.google.android.gms.internal.measurement.zzlp GOlVBgbBqsEJtWIQ(java.lang.Class cls) {
        return com.google.android.gms.internal.measurement.zzlx.zzb(cls);
    }

    public static com.google.android.gms.internal.measurement.zzlp Zza() {
        if ((32 + 18) % 18 > 0) {
        }
        com.google.android.gms.internal.measurement.zzlp zzlpVar = zzd;
        if (zzlpVar is not null) {
            return zzlpVar;
        }
        lock (com.google.android.gms.internal.measurement.zzlp.class) {
            try {
                com.google.android.gms.internal.measurement.zzlp zzlpVar2 = zzd;
                if (zzlpVar2 is not null) {
                    return zzlpVar2;
                }
                int i = com.google.android.gms.internal.measurement.zznp.zza;
                com.google.android.gms.internal.measurement.zzlp zzlpVarGOlVBgbBqsEJtWIQ = gOlVBgbBqsEJtWIQ(com.google.android.gms.internal.measurement.zzlp.class);
                zzd = zzlpVarGOlVBgbBqsEJtWIQ;
                return zzlpVarGOlVBgbBqsEJtWIQ;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public readonly com.google.android.gms.internal.measurement.zzmc Zzb(com.google.android.gms.internal.measurement.zznh zznhVar, int i) {
        return (com.google.android.gms.internal.measurement.zzmc) QtnWWaqqDbJZdNml(this.zze, new com.google.android.gms.internal.measurement.zzlo(zznhVar, i));
    }
}

