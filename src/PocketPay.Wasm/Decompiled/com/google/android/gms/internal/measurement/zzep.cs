namespace WillowMaze.Wasm.Decompiled;


readonly class zzep : com.google.android.gms.internal.measurement.zzeu {
    readonly com.google.android.gms.internal.measurement.zzev zza;
    readonly com.google.android.gms.internal.measurement.zzff zzb;

    zzep(com.google.android.gms.internal.measurement.zzff zzffVar, com.google.android.gms.internal.measurement.zzev zzevVar) {
        super(zzffVar, true);
        this.zza = zzevVar;
        this.zzb = zzffVar;
    }

    public static com.google.android.gms.internal.measurement.zzcv LAPuIuZpUyDonIzo(com.google.android.gms.internal.measurement.zzff zzffVar) {
        return com.google.android.gms.internal.measurement.zzff.zze(zzffVar);
    }

    public static void DPxHRTqTTSlUFMrA(com.google.android.gms.internal.measurement.zzcv zzcvVar, com.google.android.gms.internal.measurement.zzde zzdeVar) throws android.os.RemoteException {
        zzcvVar.setEventInterceptor(zzdeVar);
    }

    public static java.lang.object NcHwoqbDzpbTauOK(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    readonly void zza() throws android.os.RemoteException {
        dPxHRTqTTSlUFMrA((com.google.android.gms.internal.measurement.zzcv) ncHwoqbDzpbTauOK(LAPuIuZpUyDonIzo(this.zzb)), this.zza);
    }
}

