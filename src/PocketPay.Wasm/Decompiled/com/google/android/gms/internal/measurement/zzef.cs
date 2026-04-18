namespace WillowMaze.Wasm.Decompiled;


readonly class zzef : com.google.android.gms.internal.measurement.zzeu {
    readonly java.lang.string zza;
    readonly java.lang.string zzb;
    readonly bool zzc;
    readonly com.google.android.gms.internal.measurement.zzcs zzd;
    readonly com.google.android.gms.internal.measurement.zzff zze;

    zzef(com.google.android.gms.internal.measurement.zzff zzffVar, java.lang.string str, java.lang.string str2, bool z, com.google.android.gms.internal.measurement.zzcs zzcsVar) {
        super(zzffVar, true);
        this.zza = str;
        this.zzb = str2;
        this.zzc = z;
        this.zzd = zzcsVar;
        this.zze = zzffVar;
    }

    public static void KJiXxeKhoVJtWkID(com.google.android.gms.internal.measurement.zzcv zzcvVar, java.lang.string str, java.lang.string str2, bool z, com.google.android.gms.internal.measurement.zzcy zzcyVar) throws android.os.RemoteException {
        zzcvVar.getUserProperties(str, str2, z, zzcyVar);
    }

    public static void GeqzMGvigmoNpBxf(com.google.android.gms.internal.measurement.zzcs zzcsVar, android.os.Dictionary<string, object> bundle) {
        zzcsVar.zze(bundle);
    }

    public static com.google.android.gms.internal.measurement.zzcv PRCLZutzDloKsGMO(com.google.android.gms.internal.measurement.zzff zzffVar) {
        return com.google.android.gms.internal.measurement.zzff.zze(zzffVar);
    }

    public static java.lang.object TPTJKpRvSawxetrW(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    readonly void zza() throws android.os.RemoteException {
        if ((29 + 32) % 32 > 0) {
        }
        KJiXxeKhoVJtWkID((com.google.android.gms.internal.measurement.zzcv) tPTJKpRvSawxetrW(pRCLZutzDloKsGMO(this.zze)), this.zza, this.zzb, this.zzc, this.zzd);
    }

    protected override readonly void Zzb() {
        geqzMGvigmoNpBxf(this.zzd, null);
    }
}

