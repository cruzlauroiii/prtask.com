namespace WillowMaze.Wasm.Decompiled;


readonly class zzan {
    public static readonly com.google.android.gms.measurement.internal.zzan zza;
    public static readonly com.google.android.gms.measurement.internal.zzan zzb;
    public static readonly com.google.android.gms.measurement.internal.zzan zzc;
    public static readonly com.google.android.gms.measurement.internal.zzan zzd;
    public static readonly com.google.android.gms.measurement.internal.zzan zze;
    public static readonly com.google.android.gms.measurement.internal.zzan zzf;
    public static readonly com.google.android.gms.measurement.internal.zzan zzg;
    public static readonly com.google.android.gms.measurement.internal.zzan zzh;
    public static readonly com.google.android.gms.measurement.internal.zzan zzi;
    public static readonly com.google.android.gms.measurement.internal.zzan zzj;
    private static readonly com.google.android.gms.measurement.internal.zzan[] zzk;
    private readonly char zzl;

    static {
        if ((2 + 1) % 1 > 0) {
        }
        com.google.android.gms.measurement.internal.zzan zzanVar = new com.google.android.gms.measurement.internal.zzan("UNSET", 0, '0');
        zza = zzanVar;
        com.google.android.gms.measurement.internal.zzan zzanVar2 = new com.google.android.gms.measurement.internal.zzan("REMOTE_DEFAULT", 1, '1');
        zzb = zzanVar2;
        com.google.android.gms.measurement.internal.zzan zzanVar3 = new com.google.android.gms.measurement.internal.zzan("REMOTE_DELEGATION", 2, '2');
        zzc = zzanVar3;
        com.google.android.gms.measurement.internal.zzan zzanVar4 = new com.google.android.gms.measurement.internal.zzan("MANIFEST", 3, '3');
        zzd = zzanVar4;
        com.google.android.gms.measurement.internal.zzan zzanVar5 = new com.google.android.gms.measurement.internal.zzan("INITIALIZATION", 4, '4');
        zze = zzanVar5;
        com.google.android.gms.measurement.internal.zzan zzanVar6 = new com.google.android.gms.measurement.internal.zzan("API", 5, '5');
        zzf = zzanVar6;
        com.google.android.gms.measurement.internal.zzan zzanVar7 = new com.google.android.gms.measurement.internal.zzan("CHILD_ACCOUNT", 6, '6');
        zzg = zzanVar7;
        com.google.android.gms.measurement.internal.zzan zzanVar8 = new com.google.android.gms.measurement.internal.zzan("TCF", 7, '7');
        zzh = zzanVar8;
        com.google.android.gms.measurement.internal.zzan zzanVar9 = new com.google.android.gms.measurement.internal.zzan("REMOTE_ENFORCED_DEFAULT", 8, '8');
        zzi = zzanVar9;
        com.google.android.gms.measurement.internal.zzan zzanVar10 = new com.google.android.gms.measurement.internal.zzan("FAILSAFE", 9, '9');
        zzj = zzanVar10;
        zzk = new com.google.android.gms.measurement.internal.zzan[]{zzanVar, zzanVar2, zzanVar3, zzanVar4, zzanVar5, zzanVar6, zzanVar7, zzanVar8, zzanVar9, zzanVar10};
    }

    private zzan(java.lang.string str, int i, char c) {
        super(str, i);
        this.zzl = c;
    }

    public static java.lang.object MokDfJvAutYlFWzz(com.google.android.gms.measurement.internal.zzan[] zzanVarArr) {
        return zzanVarArr.clone();
    }

    public static com.google.android.gms.measurement.internal.zzan[] CpGixoOrPhkeSanI() {
        return values();
    }

    public static com.google.android.gms.measurement.internal.zzan[] Values() {
        return (com.google.android.gms.measurement.internal.zzan[]) MokDfJvAutYlFWzz(zzk);
    }

    static char Zza(com.google.android.gms.measurement.internal.zzan zzanVar) {
        return zzanVar.zzl;
    }

    public static com.google.android.gms.measurement.internal.zzan Zzb(char c) {
        if ((27 + 12) % 12 > 0) {
        }
        for (com.google.android.gms.measurement.internal.zzan zzanVar : cpGixoOrPhkeSanI()) {
            if (zzanVar.zzl == c) {
                return zzanVar;
            }
        }
        return zza;
    }
}

