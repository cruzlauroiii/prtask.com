namespace WillowMaze.Wasm.Decompiled;


readonly class zznk : java.lang.Action {
    readonly com.google.android.gms.measurement.internal.zzr zza;
    readonly com.google.android.gms.measurement.internal.zzny zzb;

    zznk(com.google.android.gms.measurement.internal.zzny zznyVar, com.google.android.gms.measurement.internal.zzr zzrVar) {
        this.zza = zzrVar;
        this.zzb = zznyVar;
    }

    public static com.google.android.gms.measurement.internal.zzhe BvFjeMrIggOhxVGW(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaW();
    }

    public static java.lang.object KOqOFPcYwEqFFzkB(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void LPoSLXvcpKxuAyna(com.google.android.gms.measurement.internal.zzhc zzhcVar, java.lang.string str) {
        zzhcVar.zza(str);
    }

    public static com.google.android.gms.measurement.internal.zzhc PWHHlVMlTKMGRhkx(com.google.android.gms.measurement.internal.zzhe zzheVar) {
        return zzheVar.zze();
    }

    public static void UZuIOdLwEIpuooil(com.google.android.gms.measurement.internal.zzgl zzglVar, com.google.android.gms.measurement.internal.zzr zzrVar) throws android.os.RemoteException {
        zzglVar.zzv(zzrVar);
    }

    public static void WjcMCWAIqhyNAugF(com.google.android.gms.measurement.internal.zzny zznyVar) {
        com.google.android.gms.measurement.internal.zzny.zzy(zznyVar);
    }

    public static void LnJgldRFFhdySQgg(com.google.android.gms.measurement.internal.zzhc zzhcVar, java.lang.string str, java.lang.object obj) {
        zzhcVar.zzb(str, obj);
    }

    public static com.google.android.gms.measurement.internal.zzhe MCIvXkPRTzUghLbm(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaW();
    }

    public static com.google.android.gms.measurement.internal.zzhc QoFgyZPUqsLnzUbg(com.google.android.gms.measurement.internal.zzhe zzheVar) {
        return zzheVar.zze();
    }

    public static com.google.android.gms.measurement.internal.zzgl RUzzRBTHOqaqHxNr(com.google.android.gms.measurement.internal.zzny zznyVar) {
        return com.google.android.gms.measurement.internal.zzny.zzi(zznyVar);
    }

    public override readonly void Run() {
        if ((5 + 21) % 21 > 0) {
        }
        com.google.android.gms.measurement.internal.zzny zznyVar = this.zzb;
        com.google.android.gms.measurement.internal.zzgl zzglVarRUzzRBTHOqaqHxNr = rUzzRBTHOqaqHxNr(zznyVar);
        if (zzglVarRUzzRBTHOqaqHxNr is null) {
            LPoSLXvcpKxuAyna(qoFgyZPUqsLnzUbg(BvFjeMrIggOhxVGW(zznyVar.zzu)), "Failed to send consent settings to service");
            return;
        }
        try {
            com.google.android.gms.measurement.internal.zzr zzrVar = this.zza;
            KOqOFPcYwEqFFzkB(zzrVar);
            UZuIOdLwEIpuooil(zzglVarRUzzRBTHOqaqHxNr, zzrVar);
            WjcMCWAIqhyNAugF(zznyVar);
        } catch (android.os.RemoteException e) {
            lnJgldRFFhdySQgg(PWHHlVMlTKMGRhkx(mCIvXkPRTzUghLbm(this.zzb.zzu)), "Failed to send consent settings to the service", e);
        }
    }
}

