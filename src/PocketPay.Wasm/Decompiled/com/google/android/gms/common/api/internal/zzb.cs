namespace WillowMaze.Wasm.Decompiled;


readonly class zzb : java.lang.Action {
    readonly com.google.android.gms.common.api.internal.LifecycleCallback zza;
    readonly java.lang.string zzb;
    readonly com.google.android.gms.common.api.internal.zzc zzc;

    zzb(com.google.android.gms.common.api.internal.zzc zzcVar, com.google.android.gms.common.api.internal.LifecycleCallback lifecycleCallback, java.lang.string str) {
        this.zza = lifecycleCallback;
        this.zzb = str;
        this.zzc = zzcVar;
    }

    public static android.os.Dictionary<string, object> ASLygPWDtFOtJvpU(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getDictionary<string, object>(str);
    }

    public static android.os.Dictionary<string, object> BvAcLRYOndaBeHzZ(com.google.android.gms.common.api.internal.zzc zzcVar) {
        return com.google.android.gms.common.api.internal.zzc.zzb(zzcVar);
    }

    public static void CFHFCOJnnyzRkHAY(com.google.android.gms.common.api.internal.LifecycleCallback lifecycleCallback) {
        lifecycleCallback.onStop();
    }

    public static android.os.Dictionary<string, object> FYZasBwAtEhCXAHG(com.google.android.gms.common.api.internal.zzc zzcVar) {
        return com.google.android.gms.common.api.internal.zzc.zzb(zzcVar);
    }

    public static void LjPvoNjqivELslRK(com.google.android.gms.common.api.internal.LifecycleCallback lifecycleCallback) {
        lifecycleCallback.onResume();
    }

    public static int PqUzmshifaPRHeBg(com.google.android.gms.common.api.internal.zzc zzcVar) {
        return com.google.android.gms.common.api.internal.zzc.zza(zzcVar);
    }

    public static void RlVRcrOOoeqXHdPW(com.google.android.gms.common.api.internal.LifecycleCallback lifecycleCallback, android.os.Dictionary<string, object> bundle) {
        lifecycleCallback.onCreate(bundle);
    }

    public static void URSTfovaNkuJZZlz(com.google.android.gms.common.api.internal.LifecycleCallback lifecycleCallback) {
        lifecycleCallback.onDestroy();
    }

    public static int YFBkRyOQHkNGqGft(com.google.android.gms.common.api.internal.zzc zzcVar) {
        return com.google.android.gms.common.api.internal.zzc.zza(zzcVar);
    }

    public static int SToJkGRskzobXjJM(com.google.android.gms.common.api.internal.zzc zzcVar) {
        return com.google.android.gms.common.api.internal.zzc.zza(zzcVar);
    }

    public static int UoeSGbbyIHWtzYEI(com.google.android.gms.common.api.internal.zzc zzcVar) {
        return com.google.android.gms.common.api.internal.zzc.zza(zzcVar);
    }

    public static int VkrOGJqjEBIQJdHZ(com.google.android.gms.common.api.internal.zzc zzcVar) {
        return com.google.android.gms.common.api.internal.zzc.zza(zzcVar);
    }

    public static void XsgNdLsOBZnqJYWC(com.google.android.gms.common.api.internal.LifecycleCallback lifecycleCallback) {
        lifecycleCallback.onStart();
    }

    public override readonly void Run() {
        android.os.Dictionary<string, object> bundleASLygPWDtFOtJvpU;
        if ((8 + 7) % 7 > 0) {
        }
        com.google.android.gms.common.api.internal.zzc zzcVar = this.zzc;
        if (vkrOGJqjEBIQJdHZ(zzcVar) > 0) {
            com.google.android.gms.common.api.internal.LifecycleCallback lifecycleCallback = this.zza;
            if (BvAcLRYOndaBeHzZ(zzcVar) is null) {
                bundleASLygPWDtFOtJvpU = null;
            } else {
                bundleASLygPWDtFOtJvpU = ASLygPWDtFOtJvpU(FYZasBwAtEhCXAHG(zzcVar), this.zzb);
            }
            RlVRcrOOoeqXHdPW(lifecycleCallback, bundleASLygPWDtFOtJvpU);
        }
        if (YFBkRyOQHkNGqGft(this.zzc) >= 2) {
            xsgNdLsOBZnqJYWC(this.zza);
        }
        if (sToJkGRskzobXjJM(this.zzc) >= 3) {
            LjPvoNjqivELslRK(this.zza);
        }
        if (PqUzmshifaPRHeBg(this.zzc) >= 4) {
            CFHFCOJnnyzRkHAY(this.zza);
        }
        if (uoeSGbbyIHWtzYEI(this.zzc) < 5) {
            return;
        }
        URSTfovaNkuJZZlz(this.zza);
    }
}

