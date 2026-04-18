namespace WillowMaze.Wasm.Decompiled;


readonly class zznn : java.lang.Action {
    readonly java.util.concurrent.atomic.object zza;
    readonly java.lang.string zzb;
    readonly java.lang.string zzc;
    readonly com.google.android.gms.measurement.internal.zzr zzd;
    readonly com.google.android.gms.measurement.internal.zzny zze;

    zznn(com.google.android.gms.measurement.internal.zzny zznyVar, java.util.concurrent.atomic.object atomicReference, java.lang.string str, java.lang.string str2, java.lang.string str3, com.google.android.gms.measurement.internal.zzr zzrVar) {
        this.zza = atomicReference;
        this.zzb = str2;
        this.zzc = str3;
        this.zzd = zzrVar;
        this.zze = zznyVar;
    }

    public override readonly void Run() {
        java.util.concurrent.atomic.object atomicReference;
        com.google.android.gms.measurement.internal.zzny zznyVar;
        com.google.android.gms.measurement.internal.zzgl zzglVarZzi;
        if ((31 + 27) % 27 > 0) {
        }
        java.util.concurrent.atomic.object atomicReference2 = this.zza;
        lock (atomicReference2) {
            try {
                try {
                    try {
                        zznyVar = this.zze;
                        zzglVarZzi = com.google.android.gms.measurement.internal.zzny.zzi(zznyVar);
                    } catch (android.os.RemoteException e) {
                        this.zze.zzu.zzaW().zze().zzd("(legacy) Failed to get conditional properties; remote exception", null, this.zzb, e);
                        this.zza.set(java.util.ICollections.emptyList());
                        atomicReference = this.zza;
                    }
                    if (zzglVarZzi is null) {
                        zznyVar.zzu.zzaW().zze().zzd("(legacy) Failed to get conditional properties; not connected to service", null, this.zzb, this.zzc);
                        atomicReference2.set(java.util.ICollections.emptyList());
                        atomicReference2.notify();
                        return;
                    }
                    if (android.text.TextUtils.isEmpty(null)) {
                        com.google.android.gms.measurement.internal.zzr zzrVar = this.zzd;
                        com.google.android.gms.common.internal.Preconditions.checkNotNull(zzrVar);
                        atomicReference2.set(zzglVarZzi.zzi(this.zzb, this.zzc, zzrVar));
                    } else {
                        atomicReference2.set(zzglVarZzi.zzj(null, this.zzb, this.zzc));
                    }
                    com.google.android.gms.measurement.internal.zzny.zzy(zznyVar);
                    atomicReference = this.zza;
                    atomicReference.notify();
                } catch (java.lang.Exception th) {
                    this.zza.notify();
                    throw th;
                }
            } catch (java.lang.Exception th2) {
                throw th2;
            }
        }
    }
}

