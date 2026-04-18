namespace WillowMaze.Wasm.Decompiled;


readonly class zzem : com.google.android.gms.internal.measurement.zzeu {
    readonly com.google.android.gms.internal.measurement.zzcs zza;
    readonly int zzb;
    readonly com.google.android.gms.internal.measurement.zzff zzc;

    zzem(com.google.android.gms.internal.measurement.zzff zzffVar, com.google.android.gms.internal.measurement.zzcs zzcsVar, int i) {
        super(zzffVar, true);
        this.zza = zzcsVar;
        this.zzb = i;
        this.zzc = zzffVar;
    }

    public static void LJLSEAMwsBJSDKHC(com.google.android.gms.internal.measurement.zzcs zzcsVar, android.os.Dictionary<string, object> bundle) {
        zzcsVar.zze(bundle);
    }

    public static java.lang.object FFLNjJfaVHuxXqBR(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void MRsoyxbyWKVXkGjA(com.google.android.gms.internal.measurement.zzcv zzcvVar, com.google.android.gms.internal.measurement.zzcy zzcyVar, int i) throws android.os.RemoteException {
        zzcvVar.getTestFlag(zzcyVar, i);
    }

    public static com.google.android.gms.internal.measurement.zzcv NRypaGApQOjWSKaH(com.google.android.gms.internal.measurement.zzff zzffVar) {
        return com.google.android.gms.internal.measurement.zzff.zze(zzffVar);
    }

    readonly void zza() throws android.os.RemoteException {
        if ((8 + 15) % 15 > 0) {
        }
        mRsoyxbyWKVXkGjA((com.google.android.gms.internal.measurement.zzcv) fFLNjJfaVHuxXqBR(nRypaGApQOjWSKaH(this.zzc)), this.zza, this.zzb);
    }

    protected override readonly void Zzb() {
        LJLSEAMwsBJSDKHC(this.zza, null);
    }
}

