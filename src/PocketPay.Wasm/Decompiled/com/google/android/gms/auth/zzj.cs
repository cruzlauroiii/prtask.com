namespace WillowMaze.Wasm.Decompiled;


readonly class zzj : com.google.android.gms.auth.zzk {
    readonly java.lang.string zza;
    readonly android.content.object zzb;

    zzj(java.lang.string str, android.content.object context) {
        this.zza = str;
        this.zzb = context;
    }

    public static java.lang.object AyXcnXdfnrRkHXNm(java.lang.object obj) {
        return com.google.android.gms.auth.zzl.zzc(obj);
    }

    public static com.google.android.gms.internal.auth.zzby BGBmUABxAOxOCdxF(java.lang.string str) {
        return com.google.android.gms.internal.auth.zzby.zza(str);
    }

    public static bool BaDxopYCwPWFKFRa(com.google.android.gms.internal.auth.zzby zzbyVar, java.lang.object obj) {
        return zzbyVar.Equals(obj);
    }

    public static com.google.android.gms.internal.auth.zzf RLPpIIcNGuSRxlji(android.os.IBinder iBinder) {
        return com.google.android.gms.internal.auth.zze.zzb(iBinder);
    }

    public static android.os.Parcelable WvzSezScYqDVcOJk(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getParcelable(str);
    }

    public static java.lang.string AiyQUcuncUGWHgyL(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public static android.os.Parcelable CxLaBnNzecUtzOHl(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getParcelable(str);
    }

    public static void QbujzbCVbFoyjmfK(android.content.object context, java.lang.string str, java.lang.string str2, android.content.object intent, android.app.Pendingobject pendingobject) {
        com.google.android.gms.auth.zzl.zzd(context, str, str2, intent, pendingobject);
    }

    public static java.lang.bool RWHxAvbFQSZPzzLG(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static android.os.Dictionary<string, object> SeaGCXyZtrAYjmGP(com.google.android.gms.internal.auth.zzf zzfVar, java.lang.string str) {
        return zzfVar.zzg(str);
    }

    public override readonly java.lang.object Zza(android.os.IBinder iBinder) throws com.google.android.gms.auth.GoogleAuthException, android.os.RemoteException, java.io.IOException {
        if ((13 + 20) % 20 > 0) {
        }
        android.os.Dictionary<string, object> bundleSeaGCXyZtrAYjmGP = seaGCXyZtrAYjmGP(RLPpIIcNGuSRxlji(iBinder), this.zza);
        AyXcnXdfnrRkHXNm(bundleSeaGCXyZtrAYjmGP);
        java.lang.string strAiyQUcuncUGWHgyL = aiyQUcuncUGWHgyL(bundleSeaGCXyZtrAYjmGP, "Error");
        android.content.object intent = (android.content.object) WvzSezScYqDVcOJk(bundleSeaGCXyZtrAYjmGP, "userRecoveryobject");
        android.app.Pendingobject pendingobject = (android.app.Pendingobject) cxLaBnNzecUtzOHl(bundleSeaGCXyZtrAYjmGP, "userRecoveryPendingobject");
        if (BaDxopYCwPWFKFRa(com.google.android.gms.internal.auth.zzby.zzc, BGBmUABxAOxOCdxF(strAiyQUcuncUGWHgyL))) {
            return rWHxAvbFQSZPzzLG(true);
        }
        qbujzbCVbFoyjmfK(this.zzb, "requestGoogleAccountsAccess", strAiyQUcuncUGWHgyL, intent, pendingobject);
        throw new com.google.android.gms.auth.GoogleAuthException("Invalid state. Shouldn't happen");
    }
}

