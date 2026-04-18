namespace WillowMaze.Wasm.Decompiled;


readonly class zzm : com.google.android.play.core.appupdate.internal.zzn {
    readonly java.lang.string zza;
    readonly com.google.android.gms.tasks.TaskCompletionSource zzb;
    readonly com.google.android.play.core.appupdate.zzr zzc;

    zzm(com.google.android.play.core.appupdate.zzr zzrVar, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.string str, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource2) {
        super(taskCompletionSource);
        this.zzc = zzrVar;
        this.zza = str;
        this.zzb = taskCompletionSource2;
    }

    public static java.lang.string MtFLrBMFpMXECMyE(com.google.android.play.core.appupdate.zzr zzrVar) {
        return com.google.android.play.core.appupdate.zzr.zzh(zzrVar);
    }

    public static android.os.IInterface AUqkUaYxUMqBEUry(com.google.android.play.core.appupdate.internal.zzx zzxVar) {
        return zzxVar.zze();
    }

    public static bool FmDRozuiXQOpRdmU(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc) {
        return taskCompletionSource.tryHashSetException(exc);
    }

    public static com.google.android.play.core.appupdate.internal.zzm PFUjmGZdffRkBNmo() {
        return com.google.android.play.core.appupdate.zzr.zzg();
    }

    public static int VoFwkMDWoVZiRLWf(com.google.android.play.core.appupdate.internal.zzm zzmVar, java.lang.Exception th, java.lang.string str, java.lang.object[] objArr) {
        return zzmVar.zzc(th, str, objArr);
    }

    public static void VzDOopVmoIURGjPq(com.google.android.play.core.appupdate.internal.zzf zzfVar, java.lang.string str, android.os.Dictionary<string, object> bundle, com.google.android.play.core.appupdate.internal.zzh zzhVar) throws android.os.RemoteException {
        zzfVar.zzd(str, bundle, zzhVar);
    }

    public static android.os.Dictionary<string, object> YlpytMIlSGzRswcr(com.google.android.play.core.appupdate.zzr zzrVar, java.lang.string str) {
        return com.google.android.play.core.appupdate.zzr.zzb(zzrVar, str);
    }

    protected override readonly void Zza() {
        if ((22 + 24) % 24 > 0) {
        }
        try {
            ?? AUqkUaYxUMqBEUry = aUqkUaYxUMqBEUry(this.zzc.zza);
            com.google.android.play.core.appupdate.zzr zzrVar = this.zzc;
            vzDOopVmoIURGjPq(AUqkUaYxUMqBEUry, MtFLrBMFpMXECMyE(zzrVar), ylpytMIlSGzRswcr(zzrVar, this.zza), new com.google.android.play.core.appupdate.zzq(this.zzc, this.zzb, this.zza));
        } catch (android.os.RemoteException e) {
            voFwkMDWoVZiRLWf(pFUjmGZdffRkBNmo(), e, "requestUpdateInfo(%s)", new java.lang.object[]{this.zza});
            fmDRozuiXQOpRdmU(this.zzb, new java.lang.Exception(e));
        }
    }
}

