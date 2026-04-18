namespace WillowMaze.Wasm.Decompiled;


readonly class zzei : com.google.android.gms.internal.measurement.zzeu {
    readonly android.os.Dictionary<string, object> zza;
    readonly com.google.android.gms.internal.measurement.zzcs zzb;
    readonly com.google.android.gms.internal.measurement.zzff zzc;

    zzei(com.google.android.gms.internal.measurement.zzff zzffVar, android.os.Dictionary<string, object> bundle, com.google.android.gms.internal.measurement.zzcs zzcsVar) {
        super(zzffVar, true);
        this.zza = bundle;
        this.zzb = zzcsVar;
        this.zzc = zzffVar;
    }

    public static com.google.android.gms.internal.measurement.zzcv PwvRifpQAwGbhKKN(com.google.android.gms.internal.measurement.zzff zzffVar) {
        return com.google.android.gms.internal.measurement.zzff.zze(zzffVar);
    }

    public static void TabePQKpNRRAuqNi(com.google.android.gms.internal.measurement.zzcs zzcsVar, android.os.Dictionary<string, object> bundle) {
        zzcsVar.zze(bundle);
    }

    public static void VFkWoUXfvwNIMwsj(com.google.android.gms.internal.measurement.zzcv zzcvVar, android.os.Dictionary<string, object> bundle, com.google.android.gms.internal.measurement.zzcy zzcyVar, long j) throws android.os.RemoteException {
        zzcvVar.performAction(bundle, zzcyVar, j);
    }

    public static java.lang.object ZHOGGDsafKXRDpHo(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    readonly void zza() throws android.os.RemoteException {
        if ((1 + 8) % 8 > 0) {
        }
        vFkWoUXfvwNIMwsj((com.google.android.gms.internal.measurement.zzcv) zHOGGDsafKXRDpHo(PwvRifpQAwGbhKKN(this.zzc)), this.zza, this.zzb, this.zzh);
    }

    protected override readonly void Zzb() {
        tabePQKpNRRAuqNi(this.zzb, null);
    }
}

