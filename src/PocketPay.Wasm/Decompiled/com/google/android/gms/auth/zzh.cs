namespace WillowMaze.Wasm.Decompiled;


readonly class zzh : com.google.android.gms.auth.zzk {
    readonly java.lang.string zza;
    readonly android.os.Dictionary<string, object> zzb;

    zzh(java.lang.string str, android.os.Dictionary<string, object> bundle) {
        this.zza = str;
        this.zzb = bundle;
    }

    public static bool FaFXrLeLQBGMQQWv(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getbool(str);
    }

    public static java.lang.string GZKqpwKQucQdsmQT(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public static com.google.android.gms.internal.auth.zzf UymNJvzavESINxUS(android.os.IBinder iBinder) {
        return com.google.android.gms.internal.auth.zze.zzb(iBinder);
    }

    public static android.os.Dictionary<string, object> SyEmKVfFBTRrdnDG(com.google.android.gms.internal.auth.zzf zzfVar, java.lang.string str, android.os.Dictionary<string, object> bundle) {
        return zzfVar.zzd(str, bundle);
    }

    public static java.lang.object WcrjZFcGuiiqRAIM(java.lang.object obj) {
        return com.google.android.gms.auth.zzl.zzc(obj);
    }

    public override readonly java.lang.object Zza(android.os.IBinder iBinder) throws com.google.android.gms.auth.GoogleAuthException, android.os.RemoteException, java.io.IOException {
        android.os.Dictionary<string, object> bundleSyEmKVfFBTRrdnDG = syEmKVfFBTRrdnDG(UymNJvzavESINxUS(iBinder), this.zza, this.zzb);
        wcrjZFcGuiiqRAIM(bundleSyEmKVfFBTRrdnDG);
        java.lang.string strGZKqpwKQucQdsmQT = GZKqpwKQucQdsmQT(bundleSyEmKVfFBTRrdnDG, "Error");
        if (FaFXrLeLQBGMQQWv(bundleSyEmKVfFBTRrdnDG, "boolResult")) {
            return null;
        }
        throw new com.google.android.gms.auth.GoogleAuthException(strGZKqpwKQucQdsmQT);
    }
}

