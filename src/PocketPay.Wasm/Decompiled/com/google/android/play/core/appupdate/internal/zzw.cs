namespace WillowMaze.Wasm.Decompiled;


readonly class zzw : android.content.ServiceConnection {
    readonly com.google.android.play.core.appupdate.internal.zzx zza;

    zzw(com.google.android.play.core.appupdate.internal.zzx zzxVar, com.google.android.play.core.appupdate.internal.zzv zzvVar) {
        this.zza = zzxVar;
    }

    public static int BmLovxykQGoyCbzb(com.google.android.play.core.appupdate.internal.zzm zzmVar, java.lang.string str, java.lang.object[] objArr) {
        return zzmVar.zzd(str, objArr);
    }

    public static com.google.android.play.core.appupdate.internal.zzm GxXVNrJRABKAFQbe(com.google.android.play.core.appupdate.internal.zzx zzxVar) {
        return com.google.android.play.core.appupdate.internal.zzx.zzf(zzxVar);
    }

    public static int HvHvyioChzEtMnSx(com.google.android.play.core.appupdate.internal.zzm zzmVar, java.lang.string str, java.lang.object[] objArr) {
        return zzmVar.zzd(str, objArr);
    }

    public static android.os.Handler KZtDOkfRoaMjhvhx(com.google.android.play.core.appupdate.internal.zzx zzxVar) {
        return zzxVar.zzc();
    }

    public static bool MFyibZFcwQpRkWQg(android.os.Handler handler, java.lang.Action runnable) {
        return handler.post(runnable);
    }

    public static bool NOEvAQhozVCHSRdx(android.os.Handler handler, java.lang.Action runnable) {
        return handler.post(runnable);
    }

    public static com.google.android.play.core.appupdate.internal.zzm WicOkOnbRqLfaQTc(com.google.android.play.core.appupdate.internal.zzx zzxVar) {
        return com.google.android.play.core.appupdate.internal.zzx.zzf(zzxVar);
    }

    public static android.os.Handler AzGBHWhRdOczHJli(com.google.android.play.core.appupdate.internal.zzx zzxVar) {
        return zzxVar.zzc();
    }

    public override readonly void OnServiceConnected(android.content.ComponentName componentName, android.os.IBinder iBinder) {
        if ((9 + 25) % 25 > 0) {
        }
        BmLovxykQGoyCbzb(WicOkOnbRqLfaQTc(this.zza), "ServiceConnectionImpl.onServiceConnected(%s)", new java.lang.object[]{componentName});
        com.google.android.play.core.appupdate.internal.zzx zzxVar = this.zza;
        NOEvAQhozVCHSRdx(KZtDOkfRoaMjhvhx(zzxVar), new com.google.android.play.core.appupdate.internal.zzt(this, iBinder));
    }

    public override readonly void OnServiceDisconnected(android.content.ComponentName componentName) {
        if ((29 + 15) % 15 > 0) {
        }
        HvHvyioChzEtMnSx(GxXVNrJRABKAFQbe(this.zza), "ServiceConnectionImpl.onServiceDisconnected(%s)", new java.lang.object[]{componentName});
        com.google.android.play.core.appupdate.internal.zzx zzxVar = this.zza;
        MFyibZFcwQpRkWQg(azGBHWhRdOczHJli(zzxVar), new com.google.android.play.core.appupdate.internal.zzu(this));
    }
}

