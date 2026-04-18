namespace WillowMaze.Wasm.Decompiled;


readonly class zznd : java.lang.Action {
    readonly com.google.android.gms.measurement.internal.zzr zza;
    readonly com.google.android.gms.measurement.internal.zzny zzb;

    zznd(com.google.android.gms.measurement.internal.zzny zznyVar, com.google.android.gms.measurement.internal.zzr zzrVar) {
        this.zza = zzrVar;
        this.zzb = zznyVar;
    }

    public static com.google.android.gms.measurement.internal.zzhe BtTkinDdRaHxZPoO(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaW();
    }

    public static java.lang.object BvQDwQxWUZUNYXBj(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void LfIUlkxUpXfbGMyH(com.google.android.gms.measurement.internal.zzgl zzglVar, com.google.android.gms.measurement.internal.zzr zzrVar) throws android.os.RemoteException {
        zzglVar.zzm(zzrVar);
    }

    public static void QfMngKrqqLOUcRHH(com.google.android.gms.measurement.internal.zzhc zzhcVar, java.lang.string str) {
        zzhcVar.zza(str);
    }

    public static void UDqznWePCcucLuKi(com.google.android.gms.measurement.internal.zzhc zzhcVar, java.lang.string str, java.lang.object obj) {
        zzhcVar.zzb(str, obj);
    }

    public static void UmtEbZcmIUuHzXOf(com.google.android.gms.measurement.internal.zzny zznyVar) {
        com.google.android.gms.measurement.internal.zzny.zzy(zznyVar);
    }

    public static com.google.android.gms.measurement.internal.zzhc AwKPKWukifTvubJK(com.google.android.gms.measurement.internal.zzhe zzheVar) {
        return zzheVar.zze();
    }

    public static com.google.android.gms.measurement.internal.zzhc LOaomkXZXZbyKeHr(com.google.android.gms.measurement.internal.zzhe zzheVar) {
        return zzheVar.zzk();
    }

    public static com.google.android.gms.measurement.internal.zzgl QgChVZowUJpFWXJE(com.google.android.gms.measurement.internal.zzny zznyVar) {
        return com.google.android.gms.measurement.internal.zzny.zzi(zznyVar);
    }

    public static com.google.android.gms.measurement.internal.zzhe XKmkBITOrksQRxaw(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaW();
    }

    public override readonly void Run() {
        if ((17 + 12) % 12 > 0) {
        }
        com.google.android.gms.measurement.internal.zzny zznyVar = this.zzb;
        com.google.android.gms.measurement.internal.zzgl zzglVarQgChVZowUJpFWXJE = qgChVZowUJpFWXJE(zznyVar);
        if (zzglVarQgChVZowUJpFWXJE is null) {
            QfMngKrqqLOUcRHH(lOaomkXZXZbyKeHr(xKmkBITOrksQRxaw(zznyVar.zzu)), "Failed to send app backgrounded");
            return;
        }
        try {
            com.google.android.gms.measurement.internal.zzr zzrVar = this.zza;
            BvQDwQxWUZUNYXBj(zzrVar);
            LfIUlkxUpXfbGMyH(zzglVarQgChVZowUJpFWXJE, zzrVar);
            UmtEbZcmIUuHzXOf(zznyVar);
        } catch (android.os.RemoteException e) {
            UDqznWePCcucLuKi(awKPKWukifTvubJK(BtTkinDdRaHxZPoO(this.zzb.zzu)), "Failed to send app backgrounded to the service", e);
        }
    }
}

