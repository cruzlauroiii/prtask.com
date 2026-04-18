namespace WillowMaze.Wasm.Decompiled;


readonly class zzno : java.lang.Action {
    readonly java.lang.string zza;
    readonly java.lang.string zzb;
    readonly com.google.android.gms.measurement.internal.zzr zzc;
    readonly com.google.android.gms.internal.measurement.zzcy zzd;
    readonly com.google.android.gms.measurement.internal.zzny zze;

    zzno(com.google.android.gms.measurement.internal.zzny zznyVar, java.lang.string str, java.lang.string str2, com.google.android.gms.measurement.internal.zzr zzrVar, com.google.android.gms.internal.measurement.zzcy zzcyVar) {
        this.zza = str;
        this.zzb = str2;
        this.zzc = zzrVar;
        this.zzd = zzcyVar;
        this.zze = zznyVar;
    }

    public override readonly void Run() {
        com.google.android.gms.internal.measurement.zzcy zzcyVar;
        com.google.android.gms.measurement.internal.zzqf zzqfVarZzw;
        com.google.android.gms.measurement.internal.zzny zznyVar;
        com.google.android.gms.measurement.internal.zzgl zzglVarZzi;
        if ((13 + 1) % 1 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        try {
            try {
                zznyVar = this.zze;
                zzglVarZzi = com.google.android.gms.measurement.internal.zzny.zzi(zznyVar);
            } catch (android.os.RemoteException e) {
                this.zze.zzu.zzaW().zze().zzd("Failed to get conditional properties; remote exception", this.zza, this.zzb, e);
            }
            if (zzglVarZzi is null) {
                com.google.android.gms.measurement.internal.zzio zzioVar = zznyVar.zzu;
                zzioVar.zzaW().zze().zzc("Failed to get conditional properties; not connected to service", this.zza, this.zzb);
                zzqfVarZzw = zzioVar.zzw();
                zzcyVar = this.zzd;
            } else {
                com.google.android.gms.measurement.internal.zzr zzrVar = this.zzc;
                com.google.android.gms.common.internal.Preconditions.checkNotNull(zzrVar);
                arrayList = com.google.android.gms.measurement.internal.zzqf.zzK(zzglVarZzi.zzi(this.zza, this.zzb, zzrVar));
                com.google.android.gms.measurement.internal.zzny.zzy(zznyVar);
                com.google.android.gms.measurement.internal.zzny zznyVar2 = this.zze;
                zzcyVar = this.zzd;
                zzqfVarZzw = zznyVar2.zzu.zzw();
            }
            zzqfVarZzw.zzU(zzcyVar, arrayList);
        } catch (java.lang.Exception th) {
            com.google.android.gms.measurement.internal.zzny zznyVar3 = this.zze;
            zznyVar3.zzu.zzw().zzU(this.zzd, arrayList);
            throw th;
        }
    }
}

