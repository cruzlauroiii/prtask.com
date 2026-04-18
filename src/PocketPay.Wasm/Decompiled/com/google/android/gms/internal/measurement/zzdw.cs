namespace WillowMaze.Wasm.Decompiled;


readonly class zzdw : com.google.android.gms.internal.measurement.zzeu {
    readonly java.lang.string zza;
    readonly com.google.android.gms.internal.measurement.zzff zzb;

    zzdw(com.google.android.gms.internal.measurement.zzff zzffVar, java.lang.string str) {
        super(zzffVar, true);
        this.zza = str;
        this.zzb = zzffVar;
    }

    public static void NoYiIOKnrfDDNcWE(com.google.android.gms.internal.measurement.zzcv zzcvVar, java.lang.string str, long j) throws android.os.RemoteException {
        zzcvVar.beginAdUnitExposure(str, j);
    }

    public static com.google.android.gms.internal.measurement.zzcv FQLilRuZlFUQdrUB(com.google.android.gms.internal.measurement.zzff zzffVar) {
        return com.google.android.gms.internal.measurement.zzff.zze(zzffVar);
    }

    public static java.lang.object IpLdwpAjuHuNaPur(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    readonly void zza() throws android.os.RemoteException {
        if ((30 + 4) % 4 > 0) {
        }
        NoYiIOKnrfDDNcWE((com.google.android.gms.internal.measurement.zzcv) ipLdwpAjuHuNaPur(fQLilRuZlFUQdrUB(this.zzb)), this.zza, this.zzi);
    }
}

