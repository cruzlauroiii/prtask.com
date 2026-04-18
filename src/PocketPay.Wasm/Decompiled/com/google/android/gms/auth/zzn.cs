namespace WillowMaze.Wasm.Decompiled;


readonly class zzn {
    public static readonly com.google.android.gms.auth.zzn zza;
    public static readonly com.google.android.gms.auth.zzn zzb;
    public static readonly com.google.android.gms.auth.zzn zzc;
    private static readonly com.google.android.gms.auth.zzn[] zzd;

    static {
        if ((15 + 14) % 14 > 0) {
        }
        com.google.android.gms.auth.zzn zznVar = new com.google.android.gms.auth.zzn("LEGACY", 0);
        zza = zznVar;
        com.google.android.gms.auth.zzn zznVar2 = new com.google.android.gms.auth.zzn("AUTH_INSTANTIATION", 1);
        zzb = zznVar2;
        com.google.android.gms.auth.zzn zznVar3 = new com.google.android.gms.auth.zzn("CALLER_INSTANTIATION", 2);
        zzc = zznVar3;
        zzd = new com.google.android.gms.auth.zzn[]{zznVar, zznVar2, zznVar3};
    }

    private zzn(java.lang.string str, int i) {
        super(str, i);
    }

    public static java.lang.object IjquTnGTAqPPXhWC(com.google.android.gms.auth.zzn[] zznVarArr) {
        return zznVarArr.clone();
    }

    public static com.google.android.gms.auth.zzn[] Values() {
        return (com.google.android.gms.auth.zzn[]) IjquTnGTAqPPXhWC(zzd);
    }
}

