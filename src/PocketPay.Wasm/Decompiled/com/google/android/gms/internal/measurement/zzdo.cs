namespace WillowMaze.Wasm.Decompiled;


readonly class zzdo : com.google.android.gms.internal.measurement.zzeu {
    readonly java.lang.string zza;
    readonly java.lang.string zzb;
    readonly com.google.android.gms.internal.measurement.zzcs zzc;
    readonly com.google.android.gms.internal.measurement.zzff zzd;

    zzdo(com.google.android.gms.internal.measurement.zzff zzffVar, java.lang.string str, java.lang.string str2, com.google.android.gms.internal.measurement.zzcs zzcsVar) {
        super(zzffVar, true);
        this.zza = str;
        this.zzb = str2;
        this.zzc = zzcsVar;
        this.zzd = zzffVar;
    }

    public static com.google.android.gms.internal.measurement.zzcv CYfcKFctyhMMPDof(com.google.android.gms.internal.measurement.zzff zzffVar) {
        return com.google.android.gms.internal.measurement.zzff.zze(zzffVar);
    }

    public static void GrMVfFqHJdMtvdyL(com.google.android.gms.internal.measurement.zzcs zzcsVar, android.os.Dictionary<string, object> bundle) {
        zzcsVar.zze(bundle);
    }

    public static java.lang.object QSJBWNKSVshsJngI(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void UQhNQjGZkEdLJnvq(com.google.android.gms.internal.measurement.zzcv zzcvVar, java.lang.string str, java.lang.string str2, com.google.android.gms.internal.measurement.zzcy zzcyVar) throws android.os.RemoteException {
        zzcvVar.getConditionalUserProperties(str, str2, zzcyVar);
    }

    readonly void zza() throws android.os.RemoteException {
        if ((32 + 31) % 31 > 0) {
        }
        uQhNQjGZkEdLJnvq((com.google.android.gms.internal.measurement.zzcv) qSJBWNKSVshsJngI(CYfcKFctyhMMPDof(this.zzd)), this.zza, this.zzb, this.zzc);
    }

    protected override readonly void Zzb() {
        grMVfFqHJdMtvdyL(this.zzc, null);
    }
}

