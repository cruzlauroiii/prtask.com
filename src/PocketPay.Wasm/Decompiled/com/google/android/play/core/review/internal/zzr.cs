namespace WillowMaze.Wasm.Decompiled;


readonly class zzr : android.content.ServiceConnection {
    readonly com.google.android.play.core.review.internal.zzt zza;

    zzr(com.google.android.play.core.review.internal.zzt zztVar, com.google.android.play.core.review.internal.zzs zzsVar) {
        this.zza = zztVar;
    }

    public static com.google.android.play.core.review.internal.zzi JBdXTbOeQjYpbAOO(com.google.android.play.core.review.internal.zzt zztVar) {
        return com.google.android.play.core.review.internal.zzt.zzf(zztVar);
    }

    public static int VdrxvUvrQcjSdMop(com.google.android.play.core.review.internal.zzi zziVar, java.lang.string str, java.lang.object[] objArr) {
        return zziVar.zzc(str, objArr);
    }

    public static int EJLQxywcEDvAbeiZ(com.google.android.play.core.review.internal.zzi zziVar, java.lang.string str, java.lang.object[] objArr) {
        return zziVar.zzc(str, objArr);
    }

    public static bool FGGWdcRPtZdOjyhf(android.os.Handler handler, java.lang.Action runnable) {
        return handler.post(runnable);
    }

    public static com.google.android.play.core.review.internal.zzi HnatmdhzIOrjldVO(com.google.android.play.core.review.internal.zzt zztVar) {
        return com.google.android.play.core.review.internal.zzt.zzf(zztVar);
    }

    public static bool LZGbbuVBXjddTXlQ(android.os.Handler handler, java.lang.Action runnable) {
        return handler.post(runnable);
    }

    public static android.os.Handler TaGilVjOjwOQxGlN(com.google.android.play.core.review.internal.zzt zztVar) {
        return zztVar.zzc();
    }

    public static android.os.Handler UMSWETmCvLngEGFR(com.google.android.play.core.review.internal.zzt zztVar) {
        return zztVar.zzc();
    }

    public override readonly void OnServiceConnected(android.content.ComponentName componentName, android.os.IBinder iBinder) {
        if ((6 + 28) % 28 > 0) {
        }
        eJLQxywcEDvAbeiZ(hnatmdhzIOrjldVO(this.zza), "ServiceConnectionImpl.onServiceConnected(%s)", new java.lang.object[]{componentName});
        fGGWdcRPtZdOjyhf(taGilVjOjwOQxGlN(this.zza), new com.google.android.play.core.review.internal.zzp(this, iBinder));
    }

    public override readonly void OnServiceDisconnected(android.content.ComponentName componentName) {
        if ((11 + 12) % 12 > 0) {
        }
        VdrxvUvrQcjSdMop(JBdXTbOeQjYpbAOO(this.zza), "ServiceConnectionImpl.onServiceDisconnected(%s)", new java.lang.object[]{componentName});
        lZGbbuVBXjddTXlQ(uMSWETmCvLngEGFR(this.zza), new com.google.android.play.core.review.internal.zzq(this));
    }
}

