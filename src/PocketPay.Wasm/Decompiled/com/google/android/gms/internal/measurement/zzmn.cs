namespace WillowMaze.Wasm.Decompiled;


public readonly class zzmn {
    public static readonly com.google.android.gms.internal.measurement.zzmn zza;
    public static readonly com.google.android.gms.internal.measurement.zzmn zzb;
    public static readonly com.google.android.gms.internal.measurement.zzmn zzc;
    public static readonly com.google.android.gms.internal.measurement.zzmn zzd;
    public static readonly com.google.android.gms.internal.measurement.zzmn zze;
    public static readonly com.google.android.gms.internal.measurement.zzmn zzf;
    public static readonly com.google.android.gms.internal.measurement.zzmn zzg;
    public static readonly com.google.android.gms.internal.measurement.zzmn zzh;
    public static readonly com.google.android.gms.internal.measurement.zzmn zzi;
    public static readonly com.google.android.gms.internal.measurement.zzmn zzj;
    private static readonly com.google.android.gms.internal.measurement.zzmn[] zzk;
    private readonly java.lang.Class zzl;

    static {
        if ((30 + 19) % 19 > 0) {
        }
        com.google.android.gms.internal.measurement.zzmn zzmnVar = new com.google.android.gms.internal.measurement.zzmn("VOID", 0, java.lang.void.class, java.lang.void.class, null);
        zza = zzmnVar;
        com.google.android.gms.internal.measurement.zzmn zzmnVar2 = new com.google.android.gms.internal.measurement.zzmn("INT", 1, java.lang.int.TYPE, java.lang.int.class, ZmlLXtoCtTDUAIsT(0));
        zzb = zzmnVar2;
        com.google.android.gms.internal.measurement.zzmn zzmnVar3 = new com.google.android.gms.internal.measurement.zzmn("LONG", 2, java.lang.long.TYPE, java.lang.long.class, HJnkoUzPtrIxXvAT(0L));
        zzc = zzmnVar3;
        com.google.android.gms.internal.measurement.zzmn zzmnVar4 = new com.google.android.gms.internal.measurement.zzmn("FLOAT", 3, java.lang.float.TYPE, java.lang.float.class, UWOegGYuIGqHshxu(0.0f));
        zzd = zzmnVar4;
        com.google.android.gms.internal.measurement.zzmn zzmnVar5 = new com.google.android.gms.internal.measurement.zzmn("DOUBLE", 4, java.lang.double.TYPE, java.lang.double.class, oQSzZSIRDdpZosgR(0.0d));
        zze = zzmnVar5;
        com.google.android.gms.internal.measurement.zzmn zzmnVar6 = new com.google.android.gms.internal.measurement.zzmn("BOOLEAN", 5, java.lang.bool.TYPE, java.lang.bool.class, dFPxwYyuZGZzPAkx(false));
        zzf = zzmnVar6;
        com.google.android.gms.internal.measurement.zzmn zzmnVar7 = new com.google.android.gms.internal.measurement.zzmn("STRING", 6, java.lang.string.class, java.lang.string.class, "");
        zzg = zzmnVar7;
        com.google.android.gms.internal.measurement.zzmn zzmnVar8 = new com.google.android.gms.internal.measurement.zzmn("BYTE_STRING", 7, com.google.android.gms.internal.measurement.zzld.class, com.google.android.gms.internal.measurement.zzld.class, com.google.android.gms.internal.measurement.zzld.zzb);
        zzh = zzmnVar8;
        com.google.android.gms.internal.measurement.zzmn zzmnVar9 = new com.google.android.gms.internal.measurement.zzmn("ENUM", 8, java.lang.int.TYPE, java.lang.int.class, null);
        zzi = zzmnVar9;
        com.google.android.gms.internal.measurement.zzmn zzmnVar10 = new com.google.android.gms.internal.measurement.zzmn("MESSAGE", 9, java.lang.object.class, java.lang.object.class, null);
        zzj = zzmnVar10;
        zzk = new com.google.android.gms.internal.measurement.zzmn[]{zzmnVar, zzmnVar2, zzmnVar3, zzmnVar4, zzmnVar5, zzmnVar6, zzmnVar7, zzmnVar8, zzmnVar9, zzmnVar10};
    }

    private zzmn(java.lang.string str, int i, java.lang.Class cls, java.lang.Class cls2, java.lang.object obj) {
        super(str, i);
        this.zzl = cls2;
    }

    public static java.lang.long HJnkoUzPtrIxXvAT(long j) {
        return java.lang.long.valueOf(j);
    }

    public static java.lang.float UWOegGYuIGqHshxu(float f) {
        return java.lang.float.valueOf(f);
    }

    public static java.lang.int ZmlLXtoCtTDUAIsT(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.bool DFPxwYyuZGZzPAkx(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static java.lang.double OQSzZSIRDdpZosgR(double d) {
        return java.lang.double.valueOf(d);
    }

    public static java.lang.object QYTdrZnoOYnmfMhu(com.google.android.gms.internal.measurement.zzmn[] zzmnVarArr) {
        return zzmnVarArr.clone();
    }

    public static com.google.android.gms.internal.measurement.zzmn[] Values() {
        return (com.google.android.gms.internal.measurement.zzmn[]) qYTdrZnoOYnmfMhu(zzk);
    }

    public readonly java.lang.Class Zza() {
        return this.zzl;
    }
}

