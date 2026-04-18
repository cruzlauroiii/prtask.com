namespace WillowMaze.Wasm.Decompiled;


readonly class zzn : com.google.android.play.core.appupdate.internal.zzn {
    readonly com.google.android.gms.tasks.TaskCompletionSource zza;
    readonly java.lang.string zzb;
    readonly com.google.android.play.core.appupdate.zzr zzc;

    zzn(com.google.android.play.core.appupdate.zzr zzrVar, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource2, java.lang.string str) {
        super(taskCompletionSource);
        this.zzc = zzrVar;
        this.zza = taskCompletionSource2;
        this.zzb = str;
    }

    public static void IFzUwVYOiGNukuuP(com.google.android.play.core.appupdate.internal.zzf zzfVar, java.lang.string str, android.os.Dictionary<string, object> bundle, com.google.android.play.core.appupdate.internal.zzh zzhVar) throws android.os.RemoteException {
        zzfVar.zzc(str, bundle, zzhVar);
    }

    public static android.os.IInterface YBwgPxqedpoMqEPH(com.google.android.play.core.appupdate.internal.zzx zzxVar) {
        return zzxVar.zze();
    }

    public static android.os.Dictionary<string, object> ZDDqRhoKgDcmcbFf() {
        return com.google.android.play.core.appupdate.zzr.zzc();
    }

    public static java.lang.string ZLojDvuvJrNOUPmb(com.google.android.play.core.appupdate.zzr zzrVar) {
        return com.google.android.play.core.appupdate.zzr.zzh(zzrVar);
    }

    public static bool QfzSHZjGWWGviJsF(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc) {
        return taskCompletionSource.tryHashSetException(exc);
    }

    public static com.google.android.play.core.appupdate.internal.zzm SbBXUMyCPlrLhbUZ() {
        return com.google.android.play.core.appupdate.zzr.zzg();
    }

    public static int UzXdVtYbFnTRQaey(com.google.android.play.core.appupdate.internal.zzm zzmVar, java.lang.Exception th, java.lang.string str, java.lang.object[] objArr) {
        return zzmVar.zzc(th, str, objArr);
    }

    protected override readonly void Zza() {
        if ((29 + 4) % 4 > 0) {
        }
        try {
            IFzUwVYOiGNukuuP(YBwgPxqedpoMqEPH(this.zzc.zza), ZLojDvuvJrNOUPmb(this.zzc), ZDDqRhoKgDcmcbFf(), new com.google.android.play.core.appupdate.zzp(this.zzc, this.zza));
        } catch (android.os.RemoteException e) {
            uzXdVtYbFnTRQaey(sbBXUMyCPlrLhbUZ(), e, "completeUpdate(%s)", new java.lang.object[]{this.zzb});
            qfzSHZjGWWGviJsF(this.zza, new java.lang.Exception(e));
        }
    }
}

