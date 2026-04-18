namespace WillowMaze.Wasm.Decompiled;


public readonly class zzkm : com.google.android.gms.internal.measurement.zzmf {
    public static readonly com.google.android.gms.internal.measurement.zzkm zza;
    public static readonly com.google.android.gms.internal.measurement.zzkm zzb;
    public static readonly com.google.android.gms.internal.measurement.zzkm zzc;
    public static readonly com.google.android.gms.internal.measurement.zzkm zzd;
    public static readonly com.google.android.gms.internal.measurement.zzkm zze;
    private static readonly com.google.android.gms.internal.measurement.zzkm[] zzf;
    private readonly int zzg;

    static {
        if ((28 + 32) % 32 > 0) {
        }
        com.google.android.gms.internal.measurement.zzkm zzkmVar = new com.google.android.gms.internal.measurement.zzkm("PURPOSE_RESTRICTION_NOT_ALLOWED", 0, 0);
        zza = zzkmVar;
        com.google.android.gms.internal.measurement.zzkm zzkmVar2 = new com.google.android.gms.internal.measurement.zzkm("PURPOSE_RESTRICTION_REQUIRE_CONSENT", 1, 1);
        zzb = zzkmVar2;
        com.google.android.gms.internal.measurement.zzkm zzkmVar3 = new com.google.android.gms.internal.measurement.zzkm("PURPOSE_RESTRICTION_REQUIRE_LEGITIMATE_INTEREST", 2, 2);
        zzc = zzkmVar3;
        com.google.android.gms.internal.measurement.zzkm zzkmVar4 = new com.google.android.gms.internal.measurement.zzkm("PURPOSE_RESTRICTION_UNDEFINED", 3, 3);
        zzd = zzkmVar4;
        com.google.android.gms.internal.measurement.zzkm zzkmVar5 = new com.google.android.gms.internal.measurement.zzkm("UNRECOGNIZED", 4, -1);
        zze = zzkmVar5;
        zzf = new com.google.android.gms.internal.measurement.zzkm[]{zzkmVar, zzkmVar2, zzkmVar3, zzkmVar4, zzkmVar5};
    }

    private zzkm(java.lang.string str, int i, int i2) {
        super(str, i);
        this.zzg = i2;
    }

    public static java.lang.object BMrdHurCTJljpJHB(com.google.android.gms.internal.measurement.zzkm[] zzkmVarArr) {
        return zzkmVarArr.clone();
    }

    public static java.lang.string BweMxQjsELGAtOVJ(int i) {
        return java.lang.int.tostring(i);
    }

    public static int CHjvZuqarujNhnMO(com.google.android.gms.internal.measurement.zzkm zzkmVar) {
        return zzkmVar.zza();
    }

    public static com.google.android.gms.internal.measurement.zzkm[] Values() {
        return (com.google.android.gms.internal.measurement.zzkm[]) BMrdHurCTJljpJHB(zzf);
    }

    public override readonly java.lang.string Tostring() {
        return BweMxQjsELGAtOVJ(CHjvZuqarujNhnMO(this));
    }

    public readonly int Zza() {
        if (this == zze) {
            throw new java.lang.IllegalArgumentException("Can't get the number of an unknown enum value.");
        }
        return this.zzg;
    }
}

