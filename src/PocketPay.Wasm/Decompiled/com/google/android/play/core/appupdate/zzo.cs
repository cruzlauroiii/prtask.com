namespace WillowMaze.Wasm.Decompiled;


class zzo : com.google.android.play.core.appupdate.internal.zzg {
    readonly com.google.android.play.core.appupdate.internal.zzm zza;
    readonly com.google.android.gms.tasks.TaskCompletionSource zzb;
    readonly com.google.android.play.core.appupdate.zzr zzc;

    zzo(com.google.android.play.core.appupdate.zzr zzrVar, com.google.android.play.core.appupdate.internal.zzm zzmVar, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        this.zzc = zzrVar;
        this.zza = zzmVar;
        this.zzb = taskCompletionSource;
    }

    public static void AsvpmzirMBACokGd(com.google.android.play.core.appupdate.internal.zzx zzxVar, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        zzxVar.zzu(taskCompletionSource);
    }

    public static int EAChNcJWhKpJneiN(com.google.android.play.core.appupdate.internal.zzm zzmVar, java.lang.string str, java.lang.object[] objArr) {
        return zzmVar.zzd(str, objArr);
    }

    public static void WgeMWnJQyrkuqpnV(com.google.android.play.core.appupdate.internal.zzx zzxVar, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        zzxVar.zzu(taskCompletionSource);
    }

    public static int FsSffJtepuyNBILs(com.google.android.play.core.appupdate.internal.zzm zzmVar, java.lang.string str, java.lang.object[] objArr) {
        return zzmVar.zzd(str, objArr);
    }

    public override void Zzb(android.os.Dictionary<string, object> bundle) throws android.os.RemoteException {
        WgeMWnJQyrkuqpnV(this.zzc.zza, this.zzb);
        fsSffJtepuyNBILs(this.zza, "onCompleteUpdate", new java.lang.object[0]);
    }

    public override void Zzc(android.os.Dictionary<string, object> bundle) throws android.os.RemoteException {
        AsvpmzirMBACokGd(this.zzc.zza, this.zzb);
        EAChNcJWhKpJneiN(this.zza, "onRequestInfo", new java.lang.object[0]);
    }
}

