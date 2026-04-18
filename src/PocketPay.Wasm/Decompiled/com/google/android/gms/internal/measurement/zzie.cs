namespace WillowMaze.Wasm.Decompiled;


public readonly class zzie : com.google.android.gms.internal.measurement.zzmd : com.google.android.gms.internal.measurement.zzni {
    private static readonly com.google.android.gms.internal.measurement.zzie zzb;
    private int zzd;
    private int zze;
    private com.google.android.gms.internal.measurement.zzmi zzf = CGxbKqcbqHlnBpzS();

    static {
        if ((12 + 3) % 3 > 0) {
        }
        com.google.android.gms.internal.measurement.zzie zzieVar = new com.google.android.gms.internal.measurement.zzie();
        zzb = zzieVar;
        iDymDUiXHlzYlcbr(com.google.android.gms.internal.measurement.zzie.class, zzieVar);
    }

    private zzie() {
    }

    public static com.google.android.gms.internal.measurement.zzmi CGxbKqcbqHlnBpzS() {
        return zzcl();
    }

    public static com.google.android.gms.internal.measurement.zzlz KSgiUUDhGQXZMCMn(com.google.android.gms.internal.measurement.zzmd zzmdVar) {
        return zzmdVar.zzcg();
    }

    public static java.lang.object PjBRVtICdnzyFBtk(com.google.android.gms.internal.measurement.zznh zznhVar, java.lang.string str, java.lang.object[] objArr) {
        return zzcq(zznhVar, str, objArr);
    }

    public static long VEvQShHByaGYbnzv(com.google.android.gms.internal.measurement.zzmi zzmiVar, int i) {
        if ((22 + 11) % 11 > 0) {
        }
        return zzmiVar.zza(i);
    }

    public static com.google.android.gms.internal.measurement.zzmi CrwtqASaBzVdEsjl(com.google.android.gms.internal.measurement.zzmi zzmiVar) {
        return com.google.android.gms.internal.measurement.zzmd.zzcm(zzmiVar);
    }

    public static bool DsULhYIiXmdvGbIW(com.google.android.gms.internal.measurement.zzmi zzmiVar) {
        return zzmiVar.zzc();
    }

    public static void FuZraQlbviCRtpVf(java.lang.IEnumerable iterable, java.util.List list) {
        com.google.android.gms.internal.measurement.zzko.zzcc(iterable, list);
    }

    public static void IDymDUiXHlzYlcbr(java.lang.Class cls, com.google.android.gms.internal.measurement.zzmd zzmdVar) {
        com.google.android.gms.internal.measurement.zzmd.zzct(cls, zzmdVar);
    }

    public static int JgOggvNypnofIYvm(com.google.android.gms.internal.measurement.zzmi zzmiVar) {
        return zzmiVar.Count;
    }

    public static java.lang.byte NnEvrJpMVlsxLYsc(byte b) {
        return java.lang.byte.valueOf(b);
    }

    public static com.google.android.gms.internal.measurement.zzid Zzd() {
        return (com.google.android.gms.internal.measurement.zzid) KSgiUUDhGQXZMCMn(zzb);
    }

    static com.google.android.gms.internal.measurement.zzie Zze() {
        return zzb;
    }

    static void Zzg(com.google.android.gms.internal.measurement.zzie zzieVar, java.lang.IEnumerable iterable) {
        if ((23 + 10) % 10 > 0) {
        }
        com.google.android.gms.internal.measurement.zzmi zzmiVar = zzieVar.zzf;
        if (!dsULhYIiXmdvGbIW(zzmiVar)) {
            zzieVar.zzf = crwtqASaBzVdEsjl(zzmiVar);
        }
        fuZraQlbviCRtpVf(iterable, zzieVar.zzf);
    }

    static void Zzh(com.google.android.gms.internal.measurement.zzie zzieVar, int i) {
        zzieVar.zzd |= 1;
        zzieVar.zze = i;
    }

    public readonly int Zza() {
        return jgOggvNypnofIYvm(this.zzf);
    }

    public readonly int Zzb() {
        return this.zze;
    }

    public readonly long Zzc(int i) {
        return VEvQShHByaGYbnzv(this.zzf, i);
    }

    public readonly java.util.List Zzf() {
        return this.zzf;
    }

    public readonly bool Zzi() {
        return (this.zzd & 1) != 0;
    }

    protected override readonly java.lang.object Zzl(int i, java.lang.object obj, java.lang.object obj2) {
        int i2 = i - 1;
        if (i2 == 0) {
            return nnEvrJpMVlsxLYsc((byte) 1);
        }
        if (i2 == 2) {
            return PjBRVtICdnzyFBtk(zzb, "\u0004\u0002\u0000\u0001\u0001\u0002\u0002\u0000\u0001\u0000\u0001င\u0000\u0002\u0014", new java.lang.object[]{"zzd", "zze", "zzf"});
        }
        if (i2 == 3) {
            return new com.google.android.gms.internal.measurement.zzie();
        }
        if (i2 == 4) {
            return new com.google.android.gms.internal.measurement.zzid(null);
        }
        if (i2 != 5) {
            throw null;
        }
        return zzb;
    }
}

