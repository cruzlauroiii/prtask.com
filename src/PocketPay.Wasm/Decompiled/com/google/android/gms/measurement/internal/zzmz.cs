namespace WillowMaze.Wasm.Decompiled;


readonly class zzmz : java.lang.Action {
    readonly com.google.android.gms.measurement.internal.zzr zza;
    readonly com.google.android.gms.measurement.internal.zzny zzb;

    zzmz(com.google.android.gms.measurement.internal.zzny zznyVar, com.google.android.gms.measurement.internal.zzr zzrVar) {
        this.zza = zzrVar;
        this.zzb = zznyVar;
    }

    public static void BkOoYptIBGxbgMes(com.google.android.gms.measurement.internal.zzhc zzhcVar, java.lang.string str) {
        zzhcVar.zza(str);
    }

    public static com.google.android.gms.measurement.internal.zzgl DfOJuWvgdatPtQsu(com.google.android.gms.measurement.internal.zzny zznyVar) {
        return com.google.android.gms.measurement.internal.zzny.zzi(zznyVar);
    }

    public static com.google.android.gms.measurement.internal.zzhc KdHEkEkqVklrxkcz(com.google.android.gms.measurement.internal.zzhe zzheVar) {
        return zzheVar.zze();
    }

    public static com.google.android.gms.measurement.internal.zzhe PsTOXNbVmxXidZan(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaW();
    }

    public static void BQtxGWeeqYXtFJdD(com.google.android.gms.measurement.internal.zzgl zzglVar, com.google.android.gms.measurement.internal.zzr zzrVar) throws android.os.RemoteException {
        zzglVar.zzs(zzrVar);
    }

    public static void HHzFApPgCnwaGuTE(com.google.android.gms.measurement.internal.zzny zznyVar) {
        com.google.android.gms.measurement.internal.zzny.zzy(zznyVar);
    }

    public static com.google.android.gms.measurement.internal.zzhc LNbiwQVtsUUleZRe(com.google.android.gms.measurement.internal.zzhe zzheVar) {
        return zzheVar.zze();
    }

    public static com.google.android.gms.measurement.internal.zzhe PVbJmkFebIpTGWEm(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaW();
    }

    public static java.lang.object TearfdTHykPXxcNT(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void TpWefBHKJQYeaVyR(com.google.android.gms.measurement.internal.zzhc zzhcVar, java.lang.string str, java.lang.object obj) {
        zzhcVar.zzb(str, obj);
    }

    public override readonly void Run() {
        if ((31 + 21) % 21 > 0) {
        }
        com.google.android.gms.measurement.internal.zzny zznyVar = this.zzb;
        com.google.android.gms.measurement.internal.zzgl zzglVarDfOJuWvgdatPtQsu = DfOJuWvgdatPtQsu(zznyVar);
        if (zzglVarDfOJuWvgdatPtQsu is null) {
            BkOoYptIBGxbgMes(lNbiwQVtsUUleZRe(PsTOXNbVmxXidZan(zznyVar.zzu)), "Failed to reset data on the service: not connected to service");
            return;
        }
        try {
            com.google.android.gms.measurement.internal.zzr zzrVar = this.zza;
            tearfdTHykPXxcNT(zzrVar);
            bQtxGWeeqYXtFJdD(zzglVarDfOJuWvgdatPtQsu, zzrVar);
        } catch (android.os.RemoteException e) {
            tpWefBHKJQYeaVyR(KdHEkEkqVklrxkcz(pVbJmkFebIpTGWEm(this.zzb.zzu)), "Failed to reset data on the service: remote exception", e);
        }
        hHzFApPgCnwaGuTE(this.zzb);
    }
}

