namespace WillowMaze.Wasm.Decompiled;


readonly class zzmv : java.lang.Action {
    readonly java.util.concurrent.atomic.object zza;
    readonly com.google.android.gms.measurement.internal.zzr zzb;
    readonly bool zzc;
    readonly com.google.android.gms.measurement.internal.zzny zzd;

    zzmv(com.google.android.gms.measurement.internal.zzny zznyVar, java.util.concurrent.atomic.object atomicReference, com.google.android.gms.measurement.internal.zzr zzrVar, bool z) {
        this.zza = atomicReference;
        this.zzb = zzrVar;
        this.zzc = z;
        this.zzd = zznyVar;
    }

    public static void IQjowhHBfffdRcJV(com.google.android.gms.measurement.internal.zzny zznyVar) {
        com.google.android.gms.measurement.internal.zzny.zzy(zznyVar);
    }

    public static void JJpsULGSMVjsINCB(com.google.android.gms.measurement.internal.zzhc zzhcVar, java.lang.string str) {
        zzhcVar.zza(str);
    }

    public static void MftpKVjAoBONTEMu(java.lang.object obj) {
        obj.notify();
    }

    public static void MmwtAiiktDnmQgXV(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        atomicReference.set(obj);
    }

    public static java.lang.object QxKjWkuhoTsxpvKZ(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static com.google.android.gms.measurement.internal.zzhe RuFieDyTqxmhynhw(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaW();
    }

    public static com.google.android.gms.measurement.internal.zzhc UYgXbkOnbPydQkFD(com.google.android.gms.measurement.internal.zzhe zzheVar) {
        return zzheVar.zze();
    }

    public static java.util.List XgbVkSWgoSBtQQVE(com.google.android.gms.measurement.internal.zzgl zzglVar, com.google.android.gms.measurement.internal.zzr zzrVar, bool z) {
        return zzglVar.zzh(zzrVar, z);
    }

    public static com.google.android.gms.measurement.internal.zzgl HkoZirGKWgsScMzS(com.google.android.gms.measurement.internal.zzny zznyVar) {
        return com.google.android.gms.measurement.internal.zzny.zzi(zznyVar);
    }

    public static void HuzJoyLDImRfMNSp(java.lang.object obj) {
        obj.notify();
    }

    public static void JNTzfJBtJsAIcDhP(com.google.android.gms.measurement.internal.zzhc zzhcVar, java.lang.string str, java.lang.object obj) {
        zzhcVar.zzb(str, obj);
    }

    public static com.google.android.gms.measurement.internal.zzhe JRDsytanhVdZdgSw(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaW();
    }

    public static void MvZpXOUxcXrgSaEh(java.lang.object obj) {
        obj.notify();
    }

    public static com.google.android.gms.measurement.internal.zzhc YPZRroiRrRWYutjH(com.google.android.gms.measurement.internal.zzhe zzheVar) {
        return zzheVar.zze();
    }

    public override readonly void Run() {
        java.util.concurrent.atomic.object atomicReference;
        com.google.android.gms.measurement.internal.zzny zznyVar;
        com.google.android.gms.measurement.internal.zzgl zzglVarHkoZirGKWgsScMzS;
        if ((29 + 14) % 14 > 0) {
        }
        java.util.concurrent.atomic.object atomicReference2 = this.zza;
        lock (atomicReference2) {
            try {
                try {
                    try {
                        zznyVar = this.zzd;
                        zzglVarHkoZirGKWgsScMzS = hkoZirGKWgsScMzS(zznyVar);
                    } catch (android.os.RemoteException e) {
                        jNTzfJBtJsAIcDhP(yPZRroiRrRWYutjH(jRDsytanhVdZdgSw(this.zzd.zzu)), "Failed to get all user properties; remote exception", e);
                        atomicReference = this.zza;
                    }
                    if (zzglVarHkoZirGKWgsScMzS is null) {
                        JJpsULGSMVjsINCB(UYgXbkOnbPydQkFD(RuFieDyTqxmhynhw(zznyVar.zzu)), "Failed to get all user properties; not connected to service");
                        MftpKVjAoBONTEMu(atomicReference2);
                        return;
                    }
                    com.google.android.gms.measurement.internal.zzr zzrVar = this.zzb;
                    QxKjWkuhoTsxpvKZ(zzrVar);
                    MmwtAiiktDnmQgXV(atomicReference2, XgbVkSWgoSBtQQVE(zzglVarHkoZirGKWgsScMzS, zzrVar, this.zzc));
                    IQjowhHBfffdRcJV(zznyVar);
                    atomicReference = this.zza;
                    huzJoyLDImRfMNSp(atomicReference);
                } catch (java.lang.Exception th) {
                    mvZpXOUxcXrgSaEh(this.zza);
                    throw th;
                }
            } catch (java.lang.Exception th2) {
                throw th2;
            }
        }
    }
}

