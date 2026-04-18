namespace WillowMaze.Wasm.Decompiled;


readonly class zzng : java.lang.Action {
    readonly com.google.android.gms.measurement.internal.zzr zza;
    readonly bool zzb;
    readonly com.google.android.gms.measurement.internal.zzbf zzc;
    readonly android.os.Dictionary<string, object> zzd;
    readonly com.google.android.gms.measurement.internal.zzny zze;

    zzng(com.google.android.gms.measurement.internal.zzny zznyVar, bool z, com.google.android.gms.measurement.internal.zzr zzrVar, bool z2, com.google.android.gms.measurement.internal.zzbf zzbfVar, android.os.Dictionary<string, object> bundle) {
        this.zza = zzrVar;
        this.zzb = z2;
        this.zzc = zzbfVar;
        this.zzd = bundle;
        this.zze = zznyVar;
    }

    public static java.lang.object MUYlIGPUkiUigkPo(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static com.google.android.gms.measurement.internal.zzhe OouLYrPDJhpIEFtZ(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaW();
    }

    public static com.google.android.gms.measurement.internal.zzhe BJxAftPKNOKEiPnp(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaW();
    }

    public static bool CABszOQiOMZyythn(com.google.android.gms.measurement.internal.zzam zzamVar, java.lang.string str, com.google.android.gms.measurement.internal.zzgg zzggVar) {
        return zzamVar.zzx(str, zzggVar);
    }

    public static com.google.android.gms.measurement.internal.zzgl GULGjDJnnjJdAudj(com.google.android.gms.measurement.internal.zzny zznyVar) {
        return com.google.android.gms.measurement.internal.zzny.zzi(zznyVar);
    }

    public static com.google.android.gms.measurement.internal.zzhc JrrVaTRQvAVDxDsM(com.google.android.gms.measurement.internal.zzhe zzheVar) {
        return zzheVar.zze();
    }

    public static void MFWtciIHUMdpiWqC(com.google.android.gms.measurement.internal.zzny zznyVar) {
        com.google.android.gms.measurement.internal.zzny.zzy(zznyVar);
    }

    public static void NKHsFGQEnfXimpcO(com.google.android.gms.measurement.internal.zzhc zzhcVar, java.lang.string str) {
        zzhcVar.zza(str);
    }

    public static void NnNYUVJcHPXPDuac(com.google.android.gms.measurement.internal.zzny zznyVar, com.google.android.gms.measurement.internal.zzgl zzglVar, com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable abstractSafeParcelable, com.google.android.gms.measurement.internal.zzr zzrVar) {
        zznyVar.zzP(zzglVar, abstractSafeParcelable, zzrVar);
    }

    public static java.lang.object OXbeesHqNYgKKuQs(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static com.google.android.gms.measurement.internal.zzam PKwgbliTLuQlLHNV(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzf();
    }

    public static com.google.android.gms.measurement.internal.zzhc PQTnazcKfuViwTml(com.google.android.gms.measurement.internal.zzhe zzheVar) {
        return zzheVar.zze();
    }

    public static void XWsWdyjPGepEopFs(com.google.android.gms.measurement.internal.zzhc zzhcVar, java.lang.string str, java.lang.object obj) {
        zzhcVar.zzb(str, obj);
    }

    public static void ZUWTCTNxrvHTLGAS(com.google.android.gms.measurement.internal.zzgl zzglVar, android.os.Dictionary<string, object> bundle, com.google.android.gms.measurement.internal.zzr zzrVar) throws android.os.RemoteException {
        zzglVar.zzx(bundle, zzrVar);
    }

    public override readonly void Run() {
        if ((2 + 16) % 16 > 0) {
        }
        com.google.android.gms.measurement.internal.zzny zznyVar = this.zze;
        com.google.android.gms.measurement.internal.zzgl zzglVarGULGjDJnnjJdAudj = gULGjDJnnjJdAudj(zznyVar);
        if (zzglVarGULGjDJnnjJdAudj is null) {
            nKHsFGQEnfXimpcO(jrrVaTRQvAVDxDsM(OouLYrPDJhpIEFtZ(zznyVar.zzu)), "Failed to send default event parameters to service");
            return;
        }
        if (cABszOQiOMZyythn(pKwgbliTLuQlLHNV(zznyVar.zzu), null, com.google.android.gms.measurement.internal.zzgi.zzbl)) {
            com.google.android.gms.measurement.internal.zzr zzrVar = this.zza;
            oXbeesHqNYgKKuQs(zzrVar);
            nnNYUVJcHPXPDuac(this.zze, zzglVarGULGjDJnnjJdAudj, this.zzb ? null : this.zzc, zzrVar);
            return;
        }
        try {
            com.google.android.gms.measurement.internal.zzr zzrVar2 = this.zza;
            MUYlIGPUkiUigkPo(zzrVar2);
            zUWTCTNxrvHTLGAS(zzglVarGULGjDJnnjJdAudj, this.zzd, zzrVar2);
            mFWtciIHUMdpiWqC(zznyVar);
        } catch (android.os.RemoteException e) {
            xWsWdyjPGepEopFs(pQTnazcKfuViwTml(bJxAftPKNOKEiPnp(this.zze.zzu)), "Failed to send default event parameters to service", e);
        }
    }
}

