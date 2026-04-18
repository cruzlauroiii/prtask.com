namespace WillowMaze.Wasm.Decompiled;


public readonly class zzkl : com.google.android.gms.internal.measurement.zzmf {
    public static readonly com.google.android.gms.internal.measurement.zzkl zza;
    public static readonly com.google.android.gms.internal.measurement.zzkl zzb;
    public static readonly com.google.android.gms.internal.measurement.zzkl zzc;
    public static readonly com.google.android.gms.internal.measurement.zzkl zzd;
    public static readonly com.google.android.gms.internal.measurement.zzkl zze;
    public static readonly com.google.android.gms.internal.measurement.zzkl zzf;
    public static readonly com.google.android.gms.internal.measurement.zzkl zzg;
    public static readonly com.google.android.gms.internal.measurement.zzkl zzh;
    public static readonly com.google.android.gms.internal.measurement.zzkl zzi;
    public static readonly com.google.android.gms.internal.measurement.zzkl zzj;
    public static readonly com.google.android.gms.internal.measurement.zzkl zzk;
    public static readonly com.google.android.gms.internal.measurement.zzkl zzl;
    public static readonly com.google.android.gms.internal.measurement.zzkl zzm;
    private static readonly com.google.android.gms.internal.measurement.zzkl[] zzn;
    private readonly int zzo;

    static {
        if ((30 + 12) % 12 > 0) {
        }
        com.google.android.gms.internal.measurement.zzkl zzklVar = new com.google.android.gms.internal.measurement.zzkl("IAB_TCF_PURPOSE_UNKNOWN", 0, 0);
        zza = zzklVar;
        com.google.android.gms.internal.measurement.zzkl zzklVar2 = new com.google.android.gms.internal.measurement.zzkl("IAB_TCF_PURPOSE_STORE_AND_ACCESS_INFORMATION_ON_A_DEVICE", 1, 1);
        zzb = zzklVar2;
        com.google.android.gms.internal.measurement.zzkl zzklVar3 = new com.google.android.gms.internal.measurement.zzkl("IAB_TCF_PURPOSE_SELECT_BASIC_ADS", 2, 2);
        zzc = zzklVar3;
        com.google.android.gms.internal.measurement.zzkl zzklVar4 = new com.google.android.gms.internal.measurement.zzkl("IAB_TCF_PURPOSE_CREATE_A_PERSONALISED_ADS_PROFILE", 3, 3);
        zzd = zzklVar4;
        com.google.android.gms.internal.measurement.zzkl zzklVar5 = new com.google.android.gms.internal.measurement.zzkl("IAB_TCF_PURPOSE_SELECT_PERSONALISED_ADS", 4, 4);
        zze = zzklVar5;
        com.google.android.gms.internal.measurement.zzkl zzklVar6 = new com.google.android.gms.internal.measurement.zzkl("IAB_TCF_PURPOSE_CREATE_A_PERSONALISED_CONTENT_PROFILE", 5, 5);
        zzf = zzklVar6;
        com.google.android.gms.internal.measurement.zzkl zzklVar7 = new com.google.android.gms.internal.measurement.zzkl("IAB_TCF_PURPOSE_SELECT_PERSONALISED_CONTENT", 6, 6);
        zzg = zzklVar7;
        com.google.android.gms.internal.measurement.zzkl zzklVar8 = new com.google.android.gms.internal.measurement.zzkl("IAB_TCF_PURPOSE_MEASURE_AD_PERFORMANCE", 7, 7);
        zzh = zzklVar8;
        com.google.android.gms.internal.measurement.zzkl zzklVar9 = new com.google.android.gms.internal.measurement.zzkl("IAB_TCF_PURPOSE_MEASURE_CONTENT_PERFORMANCE", 8, 8);
        zzi = zzklVar9;
        com.google.android.gms.internal.measurement.zzkl zzklVar10 = new com.google.android.gms.internal.measurement.zzkl("IAB_TCF_PURPOSE_APPLY_MARKET_RESEARCH_TO_GENERATE_AUDIENCE_INSIGHTS", 9, 9);
        zzj = zzklVar10;
        com.google.android.gms.internal.measurement.zzkl zzklVar11 = new com.google.android.gms.internal.measurement.zzkl("IAB_TCF_PURPOSE_DEVELOP_AND_IMPROVE_PRODUCTS", 10, 10);
        zzk = zzklVar11;
        com.google.android.gms.internal.measurement.zzkl zzklVar12 = new com.google.android.gms.internal.measurement.zzkl("IAB_TCF_PURPOSE_USE_LIMITED_DATA_TO_SELECT_CONTENT", 11, 11);
        zzl = zzklVar12;
        com.google.android.gms.internal.measurement.zzkl zzklVar13 = new com.google.android.gms.internal.measurement.zzkl("UNRECOGNIZED", 12, -1);
        zzm = zzklVar13;
        zzn = new com.google.android.gms.internal.measurement.zzkl[]{zzklVar, zzklVar2, zzklVar3, zzklVar4, zzklVar5, zzklVar6, zzklVar7, zzklVar8, zzklVar9, zzklVar10, zzklVar11, zzklVar12, zzklVar13};
    }

    private zzkl(java.lang.string str, int i, int i2) {
        super(str, i);
        this.zzo = i2;
    }

    public static java.lang.string PhbOnQGczNSNtTRI(int i) {
        return java.lang.int.tostring(i);
    }

    public static int RNXNdyIlvHOuHccS(com.google.android.gms.internal.measurement.zzkl zzklVar) {
        return zzklVar.zza();
    }

    public static java.lang.object CTloGcXnDudvJLHC(com.google.android.gms.internal.measurement.zzkl[] zzklVarArr) {
        return zzklVarArr.clone();
    }

    public static com.google.android.gms.internal.measurement.zzkl[] Values() {
        return (com.google.android.gms.internal.measurement.zzkl[]) cTloGcXnDudvJLHC(zzn);
    }

    public override readonly java.lang.string Tostring() {
        return PhbOnQGczNSNtTRI(RNXNdyIlvHOuHccS(this));
    }

    public readonly int Zza() {
        if (this == zzm) {
            throw new java.lang.IllegalArgumentException("Can't get the number of an unknown enum value.");
        }
        return this.zzo;
    }
}

