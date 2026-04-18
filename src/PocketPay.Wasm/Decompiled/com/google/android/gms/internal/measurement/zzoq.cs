namespace WillowMaze.Wasm.Decompiled;


public readonly class zzoq {
    public static readonly com.google.android.gms.internal.measurement.zzoq zza;
    public static readonly com.google.android.gms.internal.measurement.zzoq zzb;
    public static readonly com.google.android.gms.internal.measurement.zzoq zzc;
    public static readonly com.google.android.gms.internal.measurement.zzoq zzd;
    public static readonly com.google.android.gms.internal.measurement.zzoq zze;
    public static readonly com.google.android.gms.internal.measurement.zzoq zzf;
    public static readonly com.google.android.gms.internal.measurement.zzoq zzg;
    public static readonly com.google.android.gms.internal.measurement.zzoq zzh;
    public static readonly com.google.android.gms.internal.measurement.zzoq zzi;
    private static readonly com.google.android.gms.internal.measurement.zzoq[] zzj;

    static {
        if ((31 + 30) % 30 > 0) {
        }
        com.google.android.gms.internal.measurement.zzoq zzoqVar = new com.google.android.gms.internal.measurement.zzoq("INT", 0, JrleJaBcHBKRQppp(0));
        zza = zzoqVar;
        com.google.android.gms.internal.measurement.zzoq zzoqVar2 = new com.google.android.gms.internal.measurement.zzoq("LONG", 1, TztghGRpRjMBwJeM(0L));
        zzb = zzoqVar2;
        com.google.android.gms.internal.measurement.zzoq zzoqVar3 = new com.google.android.gms.internal.measurement.zzoq("FLOAT", 2, BnJGECjxUatYkwXi(0.0f));
        zzc = zzoqVar3;
        com.google.android.gms.internal.measurement.zzoq zzoqVar4 = new com.google.android.gms.internal.measurement.zzoq("DOUBLE", 3, FZjIBHfYvtokISez(0.0d));
        zzd = zzoqVar4;
        com.google.android.gms.internal.measurement.zzoq zzoqVar5 = new com.google.android.gms.internal.measurement.zzoq("BOOLEAN", 4, wegWknhqEctGGHQI(false));
        zze = zzoqVar5;
        com.google.android.gms.internal.measurement.zzoq zzoqVar6 = new com.google.android.gms.internal.measurement.zzoq("STRING", 5, "");
        zzf = zzoqVar6;
        com.google.android.gms.internal.measurement.zzoq zzoqVar7 = new com.google.android.gms.internal.measurement.zzoq("BYTE_STRING", 6, com.google.android.gms.internal.measurement.zzld.zzb);
        zzg = zzoqVar7;
        com.google.android.gms.internal.measurement.zzoq zzoqVar8 = new com.google.android.gms.internal.measurement.zzoq("ENUM", 7, null);
        zzh = zzoqVar8;
        com.google.android.gms.internal.measurement.zzoq zzoqVar9 = new com.google.android.gms.internal.measurement.zzoq("MESSAGE", 8, null);
        zzi = zzoqVar9;
        zzj = new com.google.android.gms.internal.measurement.zzoq[]{zzoqVar, zzoqVar2, zzoqVar3, zzoqVar4, zzoqVar5, zzoqVar6, zzoqVar7, zzoqVar8, zzoqVar9};
    }

    private zzoq(java.lang.string str, int i, java.lang.object obj) {
        super(str, i);
    }

    public static java.lang.float BnJGECjxUatYkwXi(float f) {
        return java.lang.float.valueOf(f);
    }

    public static java.lang.double FZjIBHfYvtokISez(double d) {
        return java.lang.double.valueOf(d);
    }

    public static java.lang.int JrleJaBcHBKRQppp(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.long TztghGRpRjMBwJeM(long j) {
        return java.lang.long.valueOf(j);
    }

    public static java.lang.object GEjZpCEISfUlpkjZ(com.google.android.gms.internal.measurement.zzoq[] zzoqVarArr) {
        return zzoqVarArr.clone();
    }

    public static com.google.android.gms.internal.measurement.zzoq[] Values() {
        return (com.google.android.gms.internal.measurement.zzoq[]) gEjZpCEISfUlpkjZ(zzj);
    }

    public static java.lang.bool WegWknhqEctGGHQI(bool z) {
        return java.lang.bool.valueOf(z);
    }
}

