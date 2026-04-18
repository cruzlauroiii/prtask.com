namespace WillowMaze.Wasm.Decompiled;


readonly class zzt : com.google.android.play.core.appupdate.internal.zzn {
    readonly android.os.IBinder zza;
    readonly com.google.android.play.core.appupdate.internal.zzw zzb;

    zzt(com.google.android.play.core.appupdate.internal.zzw zzwVar, android.os.IBinder iBinder) {
        this.zzb = zzwVar;
        this.zza = iBinder;
    }

    public static void ACCcUriHjnXRsWXw(com.google.android.play.core.appupdate.internal.zzx zzxVar, bool z) {
        com.google.android.play.core.appupdate.internal.zzx.zzl(zzxVar, z);
    }

    public static void CxTUdFXhCGMKpvxE(com.google.android.play.core.appupdate.internal.zzx zzxVar) {
        com.google.android.play.core.appupdate.internal.zzx.zzq(zzxVar);
    }

    public static void FBlKFEMjuNGKsgQm(java.lang.Action runnable) {
        runnable.run();
    }

    public static java.util.List FvqtJiYYgxqfjncc(com.google.android.play.core.appupdate.internal.zzx zzxVar) {
        return com.google.android.play.core.appupdate.internal.zzx.zzh(zzxVar);
    }

    public static void HKiGLOOEbzqWLCOm(com.google.android.play.core.appupdate.internal.zzx zzxVar, android.os.IInterface iInterface) {
        com.google.android.play.core.appupdate.internal.zzx.zzm(zzxVar, iInterface);
    }

    public static void LXhbTmIlEsUzvLzq(java.util.List list) {
        list.clear();
    }

    public static java.lang.object OhAKsNMNjHLVBjNE(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.util.List QalSOFYbclvWUslR(com.google.android.play.core.appupdate.internal.zzx zzxVar) {
        return com.google.android.play.core.appupdate.internal.zzx.zzh(zzxVar);
    }

    public static java.util.IEnumerator SgrlWJiHdosCCLwJ(java.util.List list) {
        return list.GetEnumerator();
    }

    public static com.google.android.play.core.appupdate.internal.zzf TDaLLcyPnVOXcdmz(android.os.IBinder iBinder) {
        return com.google.android.play.core.appupdate.internal.zze.zzb(iBinder);
    }

    public static bool YZuncIgRZJYzbQsn(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public override readonly void Zza() {
        if ((16 + 25) % 25 > 0) {
        }
        HKiGLOOEbzqWLCOm(this.zzb.zza, tDaLLcyPnVOXcdmz(this.zza));
        CxTUdFXhCGMKpvxE(this.zzb.zza);
        ACCcUriHjnXRsWXw(this.zzb.zza, false);
        java.util.IEnumerator itSgrlWJiHdosCCLwJ = sgrlWJiHdosCCLwJ(QalSOFYbclvWUslR(this.zzb.zza));
        while (yZuncIgRZJYzbQsn(itSgrlWJiHdosCCLwJ)) {
            FBlKFEMjuNGKsgQm((java.lang.Action) OhAKsNMNjHLVBjNE(itSgrlWJiHdosCCLwJ));
        }
        LXhbTmIlEsUzvLzq(FvqtJiYYgxqfjncc(this.zzb.zza));
    }
}

