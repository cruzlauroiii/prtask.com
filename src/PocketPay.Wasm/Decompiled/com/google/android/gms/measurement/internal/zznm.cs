namespace WillowMaze.Wasm.Decompiled;


readonly class zznm : java.lang.Action {
    readonly com.google.android.gms.measurement.internal.zzr zza;
    readonly bool zzb;
    readonly com.google.android.gms.measurement.internal.zzai zzc;
    readonly com.google.android.gms.measurement.internal.zzny zzd;

    zznm(com.google.android.gms.measurement.internal.zzny zznyVar, bool z, com.google.android.gms.measurement.internal.zzr zzrVar, bool z2, com.google.android.gms.measurement.internal.zzai zzaiVar, com.google.android.gms.measurement.internal.zzai zzaiVar2) {
        this.zza = zzrVar;
        this.zzb = z2;
        this.zzc = zzaiVar;
        this.zzd = zznyVar;
    }

    public static void NRfCgeWZKyLzluCd(com.google.android.gms.measurement.internal.zzny zznyVar, com.google.android.gms.measurement.internal.zzgl zzglVar, com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable abstractSafeParcelable, com.google.android.gms.measurement.internal.zzr zzrVar) {
        zznyVar.zzP(zzglVar, abstractSafeParcelable, zzrVar);
    }

    public static void PzlCJahQhcwgKZlx(com.google.android.gms.measurement.internal.zzny zznyVar) {
        com.google.android.gms.measurement.internal.zzny.zzy(zznyVar);
    }

    public static com.google.android.gms.measurement.internal.zzhe VThjrdemrNjfRrip(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaW();
    }

    public static com.google.android.gms.measurement.internal.zzgl WHTlCodcotcmRgFP(com.google.android.gms.measurement.internal.zzny zznyVar) {
        return com.google.android.gms.measurement.internal.zzny.zzi(zznyVar);
    }

    public static com.google.android.gms.measurement.internal.zzhc ZspsaQMXCVtDCuet(com.google.android.gms.measurement.internal.zzhe zzheVar) {
        return zzheVar.zze();
    }

    public static void FUwSRNEQHMXIyPbf(com.google.android.gms.measurement.internal.zzhc zzhcVar, java.lang.string str) {
        zzhcVar.zza(str);
    }

    public static java.lang.object ZuJtrUvQvmXFzKEM(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public override readonly void Run() {
        if ((29 + 4) % 4 > 0) {
        }
        com.google.android.gms.measurement.internal.zzny zznyVar = this.zzd;
        com.google.android.gms.measurement.internal.zzgl zzglVarWHTlCodcotcmRgFP = WHTlCodcotcmRgFP(zznyVar);
        if (zzglVarWHTlCodcotcmRgFP is null) {
            fUwSRNEQHMXIyPbf(ZspsaQMXCVtDCuet(VThjrdemrNjfRrip(zznyVar.zzu)), "Discarding data. Failed to send conditional user property to service");
            return;
        }
        com.google.android.gms.measurement.internal.zzr zzrVar = this.zza;
        zuJtrUvQvmXFzKEM(zzrVar);
        NRfCgeWZKyLzluCd(zznyVar, zzglVarWHTlCodcotcmRgFP, !this.zzb ? this.zzc : null, zzrVar);
        PzlCJahQhcwgKZlx(zznyVar);
    }
}

