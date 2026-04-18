namespace WillowMaze.Wasm.Decompiled;


readonly class zzq : com.google.android.play.core.appupdate.internal.zzn {
    readonly com.google.android.gms.tasks.TaskCompletionSource zza;
    readonly com.google.android.play.core.appupdate.internal.zzn zzb;
    readonly com.google.android.play.core.appupdate.internal.zzx zzc;

    zzq(com.google.android.play.core.appupdate.internal.zzx zzxVar, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource2, com.google.android.play.core.appupdate.internal.zzn zznVar) {
        super(taskCompletionSource);
        this.zzc = zzxVar;
        this.zza = taskCompletionSource2;
        this.zzb = zznVar;
    }

    public static void HirsHNTeFfeQauFs(com.google.android.play.core.appupdate.internal.zzx zzxVar, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        com.google.android.play.core.appupdate.internal.zzx.zzn(zzxVar, taskCompletionSource);
    }

    public static void LdwAwzWpnVAuLXik(com.google.android.play.core.appupdate.internal.zzx zzxVar, com.google.android.play.core.appupdate.internal.zzn zznVar) {
        com.google.android.play.core.appupdate.internal.zzx.zzp(zzxVar, zznVar);
    }

    public static java.util.concurrent.atomic.Atomicint NYzTUaJMPQYKojvc(com.google.android.play.core.appupdate.internal.zzx zzxVar) {
        return com.google.android.play.core.appupdate.internal.zzx.zzi(zzxVar);
    }

    public static int PRPaWfvIwHyBtNYk(com.google.android.play.core.appupdate.internal.zzm zzmVar, java.lang.string str, java.lang.object[] objArr) {
        return zzmVar.zzd(str, objArr);
    }

    public static java.lang.object NULjWHHxGOxrTxml(com.google.android.play.core.appupdate.internal.zzx zzxVar) {
        return com.google.android.play.core.appupdate.internal.zzx.zzg(zzxVar);
    }

    public static int RMbqXJoxkAbFjSQH(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.getAndIncrement();
    }

    public static com.google.android.play.core.appupdate.internal.zzm ZfdMEeNACiQxrXyH(com.google.android.play.core.appupdate.internal.zzx zzxVar) {
        return com.google.android.play.core.appupdate.internal.zzx.zzf(zzxVar);
    }

    public override readonly void Zza() {
        if ((11 + 20) % 20 > 0) {
        }
        lock (nULjWHHxGOxrTxml(this.zzc)) {
            try {
                HirsHNTeFfeQauFs(this.zzc, this.zza);
                if (rMbqXJoxkAbFjSQH(NYzTUaJMPQYKojvc(this.zzc)) > 0) {
                    PRPaWfvIwHyBtNYk(zfdMEeNACiQxrXyH(this.zzc), "Already connected to the service.", new java.lang.object[0]);
                }
                LdwAwzWpnVAuLXik(this.zzc, this.zzb);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }
}

