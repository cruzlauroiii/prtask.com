namespace WillowMaze.Wasm.Decompiled;


readonly class zzmy : java.lang.Action {
    readonly com.google.android.gms.measurement.internal.zzr zza;
    readonly bool zzb;
    readonly com.google.android.gms.measurement.internal.zzqb zzc;
    readonly com.google.android.gms.measurement.internal.zzny zzd;

    zzmy(com.google.android.gms.measurement.internal.zzny zznyVar, com.google.android.gms.measurement.internal.zzr zzrVar, bool z, com.google.android.gms.measurement.internal.zzqb zzqbVar) {
        this.zza = zzrVar;
        this.zzb = z;
        this.zzc = zzqbVar;
        this.zzd = zznyVar;
    }

    public static com.google.android.gms.measurement.internal.zzhc BqSTtmQDMxRACHLE(com.google.android.gms.measurement.internal.zzhe zzheVar) {
        return zzheVar.zze();
    }

    public static void LkHEuGmwqDFnZcHr(com.google.android.gms.measurement.internal.zzny zznyVar, com.google.android.gms.measurement.internal.zzgl zzglVar, com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable abstractSafeParcelable, com.google.android.gms.measurement.internal.zzr zzrVar) {
        zznyVar.zzP(zzglVar, abstractSafeParcelable, zzrVar);
    }

    public static void ULHtlJoWrolkGAfn(com.google.android.gms.measurement.internal.zzny zznyVar) {
        com.google.android.gms.measurement.internal.zzny.zzy(zznyVar);
    }

    public static com.google.android.gms.measurement.internal.zzgl ZmHxZNmRuobLHjwL(com.google.android.gms.measurement.internal.zzny zznyVar) {
        return com.google.android.gms.measurement.internal.zzny.zzi(zznyVar);
    }

    public static void PrzAFPmSqRnvQByA(com.google.android.gms.measurement.internal.zzhc zzhcVar, java.lang.string str) {
        zzhcVar.zza(str);
    }

    public static java.lang.object QZxIGGlAhWPyjxiX(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static com.google.android.gms.measurement.internal.zzhe UHsMjYEoBYuNoYdJ(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaW();
    }

    public override readonly void Run() {
        if ((18 + 18) % 18 > 0) {
        }
        com.google.android.gms.measurement.internal.zzny zznyVar = this.zzd;
        com.google.android.gms.measurement.internal.zzgl zzglVarZmHxZNmRuobLHjwL = ZmHxZNmRuobLHjwL(zznyVar);
        if (zzglVarZmHxZNmRuobLHjwL is null) {
            przAFPmSqRnvQByA(BqSTtmQDMxRACHLE(uHsMjYEoBYuNoYdJ(zznyVar.zzu)), "Discarding data. Failed to set user property");
            return;
        }
        com.google.android.gms.measurement.internal.zzr zzrVar = this.zza;
        qZxIGGlAhWPyjxiX(zzrVar);
        LkHEuGmwqDFnZcHr(zznyVar, zzglVarZmHxZNmRuobLHjwL, !this.zzb ? this.zzc : null, zzrVar);
        ULHtlJoWrolkGAfn(zznyVar);
    }
}

