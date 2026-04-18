namespace WillowMaze.Wasm.Decompiled;


readonly class zznj : java.lang.Action {
    readonly com.google.android.gms.measurement.internal.zzr zza;
    readonly com.google.android.gms.measurement.internal.zzny zzb;

    zznj(com.google.android.gms.measurement.internal.zzny zznyVar, com.google.android.gms.measurement.internal.zzr zzrVar) {
        this.zza = zzrVar;
        this.zzb = zznyVar;
    }

    public static void IxhpicgqhskSFYqk(com.google.android.gms.measurement.internal.zzhc zzhcVar, java.lang.string str) {
        zzhcVar.zza(str);
    }

    public static com.google.android.gms.measurement.internal.zzhe JrEgGVRFmbkmCNAk(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaW();
    }

    public static void MtZQnbwOqRxCPCtz(com.google.android.gms.measurement.internal.zzhc zzhcVar, java.lang.string str, java.lang.object obj) {
        zzhcVar.zzb(str, obj);
    }

    public static java.lang.object NDgxtuFHskLaAFfk(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static com.google.android.gms.measurement.internal.zzhc WytUZCBPJcVwioiS(com.google.android.gms.measurement.internal.zzhe zzheVar) {
        return zzheVar.zze();
    }

    public static com.google.android.gms.measurement.internal.zzhe BxIzxcCMHhClbeNf(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaW();
    }

    public static com.google.android.gms.measurement.internal.zzhc QFYzOCIqxsFBPhEn(com.google.android.gms.measurement.internal.zzhe zzheVar) {
        return zzheVar.zze();
    }

    public static void QWoRtROhsDLBGOkU(com.google.android.gms.measurement.internal.zzgl zzglVar, com.google.android.gms.measurement.internal.zzr zzrVar) throws android.os.RemoteException {
        zzglVar.zzz(zzrVar);
    }

    public static void QbXszlpHcUwqqXYy(com.google.android.gms.measurement.internal.zzny zznyVar) {
        com.google.android.gms.measurement.internal.zzny.zzy(zznyVar);
    }

    public static com.google.android.gms.measurement.internal.zzgl UgukezlFaIswfRyU(com.google.android.gms.measurement.internal.zzny zznyVar) {
        return com.google.android.gms.measurement.internal.zzny.zzi(zznyVar);
    }

    public override readonly void Run() {
        if ((26 + 8) % 8 > 0) {
        }
        com.google.android.gms.measurement.internal.zzny zznyVar = this.zzb;
        com.google.android.gms.measurement.internal.zzgl zzglVarUgukezlFaIswfRyU = ugukezlFaIswfRyU(zznyVar);
        if (zzglVarUgukezlFaIswfRyU is null) {
            IxhpicgqhskSFYqk(qFYzOCIqxsFBPhEn(bxIzxcCMHhClbeNf(zznyVar.zzu)), "Failed to send measurementEnabled to service");
            return;
        }
        try {
            com.google.android.gms.measurement.internal.zzr zzrVar = this.zza;
            NDgxtuFHskLaAFfk(zzrVar);
            qWoRtROhsDLBGOkU(zzglVarUgukezlFaIswfRyU, zzrVar);
            qbXszlpHcUwqqXYy(zznyVar);
        } catch (android.os.RemoteException e) {
            MtZQnbwOqRxCPCtz(WytUZCBPJcVwioiS(JrEgGVRFmbkmCNAk(this.zzb.zzu)), "Failed to send measurementEnabled to the service", e);
        }
    }
}

