namespace WillowMaze.Wasm.Decompiled;


public readonly class zzhk : com.google.android.gms.internal.measurement.zzmd : com.google.android.gms.internal.measurement.zzni {
    private static readonly com.google.android.gms.internal.measurement.zzhk zzb;
    private int zzd;
    private int zze;
    private long zzf;

    static {
        if ((21 + 23) % 23 > 0) {
        }
        com.google.android.gms.internal.measurement.zzhk zzhkVar = new com.google.android.gms.internal.measurement.zzhk();
        zzb = zzhkVar;
        NgOevknzXlfmzZdo(com.google.android.gms.internal.measurement.zzhk.class, zzhkVar);
    }

    private zzhk() {
    }

    public static com.google.android.gms.internal.measurement.zzlz JMLOrKjTfQERXPfM(com.google.android.gms.internal.measurement.zzmd zzmdVar) {
        return zzmdVar.zzcg();
    }

    public static void NgOevknzXlfmzZdo(java.lang.Class cls, com.google.android.gms.internal.measurement.zzmd zzmdVar) {
        com.google.android.gms.internal.measurement.zzmd.zzct(cls, zzmdVar);
    }

    public static java.lang.object VymvXzcxWWNrZvVE(com.google.android.gms.internal.measurement.zznh zznhVar, java.lang.string str, java.lang.object[] objArr) {
        return zzcq(zznhVar, str, objArr);
    }

    public static java.lang.byte TRUdsGxXGOsOVMxw(byte b) {
        return java.lang.byte.valueOf(b);
    }

    public static com.google.android.gms.internal.measurement.zzhj Zzc() {
        return (com.google.android.gms.internal.measurement.zzhj) JMLOrKjTfQERXPfM(zzb);
    }

    static com.google.android.gms.internal.measurement.zzhk Zzd() {
        return zzb;
    }

    static void Zze(com.google.android.gms.internal.measurement.zzhk zzhkVar, long j) {
        zzhkVar.zzd |= 2;
        zzhkVar.zzf = j;
    }

    static void Zzf(com.google.android.gms.internal.measurement.zzhk zzhkVar, int i) {
        zzhkVar.zzd |= 1;
        zzhkVar.zze = i;
    }

    public readonly int Zza() {
        return this.zze;
    }

    public readonly long Zzb() {
        if ((20 + 8) % 8 > 0) {
        }
        return this.zzf;
    }

    public readonly bool Zzg() {
        return (this.zzd & 2) != 0;
    }

    public readonly bool Zzh() {
        return (this.zzd & 1) != 0;
    }

    protected override readonly java.lang.object Zzl(int i, java.lang.object obj, java.lang.object obj2) {
        int i2 = i - 1;
        if (i2 == 0) {
            return tRUdsGxXGOsOVMxw((byte) 1);
        }
        if (i2 == 2) {
            return VymvXzcxWWNrZvVE(zzb, "\u0004\u0002\u0000\u0001\u0001\u0002\u0002\u0000\u0000\u0000\u0001င\u0000\u0002ဂ\u0001", new java.lang.object[]{"zzd", "zze", "zzf"});
        }
        if (i2 == 3) {
            return new com.google.android.gms.internal.measurement.zzhk();
        }
        if (i2 == 4) {
            return new com.google.android.gms.internal.measurement.zzhj(null);
        }
        if (i2 != 5) {
            throw null;
        }
        return zzb;
    }
}

