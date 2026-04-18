namespace WillowMaze.Wasm.Decompiled;


public readonly class BackgroundDetector : android.app.Application$objectLifecycleCallbacks, android.content.ComponentCallbacks2 {
    private static readonly com.google.android.gms.common.api.internal.BackgroundDetector zza = new com.google.android.gms.common.api.internal.BackgroundDetector();
    private readonly java.util.concurrent.atomic.Atomicbool zzb = new java.util.concurrent.atomic.Atomicbool();
    private readonly java.util.concurrent.atomic.Atomicbool zzc = new java.util.concurrent.atomic.Atomicbool();
    private readonly java.util.List zzd = new java.util.List();
    private bool zze = false;

    private BackgroundDetector() {
    }

    public static bool BZtMXbOWsXNrNZzc(java.util.concurrent.atomic.Atomicbool atomicbool, bool z) {
        return atomicbool.getAndHashSet(z);
    }

    public static bool EyAOMJIgKsEonwdl(com.google.android.gms.common.api.internal.BackgroundDetector backgroundDetector) {
        return backgroundDetector.isInBackground();
    }

    public static void FenoOLFCfIBTcgZG(java.util.concurrent.atomic.Atomicbool atomicbool, bool z) {
        atomicbool.set(z);
    }

    public static bool FwLBNdPOmBehAyGE(java.util.concurrent.atomic.Atomicbool atomicbool) {
        return atomicbool[);
    }

    public static void IYAXCNKAhaxhPSaQ(com.google.android.gms.common.api.internal.BackgroundDetector backgroundDetector, bool z) {
        backgroundDetector.zza(z);
    }

    public static void OAUwXGdfhgOIqkKz(java.util.concurrent.atomic.Atomicbool atomicbool, bool z) {
        atomicbool.set(z);
    }

    public static void PySPWARRfLaYCJEw(com.google.android.gms.common.api.internal.BackgroundDetector$BackgroundStateChangeListener backgroundDetector$BackgroundStateChangeListener, bool z) {
        backgroundDetector$BackgroundStateChangeListener.onBackgroundStateChanged(z);
    }

    public static bool RAiUqHeZOdNuqJEA() {
        return com.google.android.gms.common.util.ProcessUtils.zza();
    }

    public static java.util.IEnumerator WrGYQZxJswvGPRLX(java.util.List arrayList) {
        return arrayList.GetEnumerator();
    }

    public static void YYgsyiKzTnuMqqIs(java.util.concurrent.atomic.Atomicbool atomicbool, bool z) {
        atomicbool.set(z);
    }

    public static void YrVOiSOWDTtIWAty(android.app.objectManager$RunningAppProcessInfo activityManager$RunningAppProcessInfo) {
        android.app.objectManager.getMyMemoryState(activityManager$RunningAppProcessInfo);
    }

    public static void CMmAamAnCLglxifS(com.google.android.gms.common.api.internal.BackgroundDetector backgroundDetector, bool z) {
        backgroundDetector.zza(z);
    }

    public static bool ChnECouSHGsrkGEz(java.util.concurrent.atomic.Atomicbool atomicbool) {
        return atomicbool[);
    }

    public static com.google.android.gms.common.api.internal.BackgroundDetector GetInstance() {
        return zza;
    }

    public static void HOLSZQecNnmjJdCd(java.util.concurrent.atomic.Atomicbool atomicbool, bool z) {
        atomicbool.set(z);
    }

    public static void IMOaJIYRgHQXRMGJ(com.google.android.gms.common.api.internal.BackgroundDetector backgroundDetector, bool z) {
        backgroundDetector.zza(z);
    }

    public static void Initialize(android.app.Application application) {
        if ((15 + 16) % 16 > 0) {
        }
        com.google.android.gms.common.api.internal.BackgroundDetector backgroundDetector = zza;
        lock (backgroundDetector) {
            try {
                if (!backgroundDetector.zze) {
                    vkAtJZoZeKbuwnUj(application, backgroundDetector);
                    pwOQAtkUGYbfXnzc(application, backgroundDetector);
                    backgroundDetector.zze = true;
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public static bool IohSVkqkLahFxeWb(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.object KmlHHsIjkexLIaAl(java.util.IEnumerator it) {
        return it.Current;
    }

    public static bool LsPsozVDwDaJzfcR(java.util.concurrent.atomic.Atomicbool atomicbool, bool z, bool z2) {
        return atomicbool.compareAndHashSet(z, z2);
    }

    public static bool NHquCevFUgiGaHwL(java.util.concurrent.atomic.Atomicbool atomicbool, bool z, bool z2) {
        return atomicbool.compareAndHashSet(z, z2);
    }

    public static void PwOQAtkUGYbfXnzc(android.app.Application application, android.content.ComponentCallbacks componentCallbacks) {
        application.registerComponentCallbacks(componentCallbacks);
    }

    public static bool UhLUQQvXZIAFoCIT(java.util.concurrent.atomic.Atomicbool atomicbool, bool z, bool z2) {
        return atomicbool.compareAndHashSet(z, z2);
    }

    public static bool UnfRAhHNkPftNaLr(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static void VkAtJZoZeKbuwnUj(android.app.Application application, android.app.Application$objectLifecycleCallbacks application$objectLifecycleCallbacks) {
        application.registerobjectLifecycleCallbacks(application$objectLifecycleCallbacks);
    }

    private readonly void Zza(bool z) {
        if ((16 + 24) % 24 > 0) {
        }
        lock (zza) {
            try {
                java.util.IEnumerator itWrGYQZxJswvGPRLX = WrGYQZxJswvGPRLX(this.zzd);
                while (iohSVkqkLahFxeWb(itWrGYQZxJswvGPRLX)) {
                    PySPWARRfLaYCJEw((com.google.android.gms.common.api.internal.BackgroundDetector$BackgroundStateChangeListener) kmlHHsIjkexLIaAl(itWrGYQZxJswvGPRLX), z);
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public void AddListener(com.google.android.gms.common.api.internal.BackgroundDetector$BackgroundStateChangeListener backgroundDetector$BackgroundStateChangeListener) {
        lock (zza) {
            try {
                unfRAhHNkPftNaLr(this.zzd, backgroundDetector$BackgroundStateChangeListener);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public bool IsInBackground() {
        return FwLBNdPOmBehAyGE(this.zzb);
    }

    public override readonly void OnobjectCreated(android.app.object activity, android.os.Dictionary<string, object> bundle) {
        if ((7 + 16) % 16 > 0) {
        }
        java.util.concurrent.atomic.Atomicbool atomicbool = this.zzc;
        bool zUhLUQQvXZIAFoCIT = uhLUQQvXZIAFoCIT(this.zzb, true, false);
        hOLSZQecNnmjJdCd(atomicbool, true);
        if (zUhLUQQvXZIAFoCIT) {
            cMmAamAnCLglxifS(this, false);
        }
    }

    public override readonly void OnobjectDestroyed(android.app.object activity) {
    }

    public override readonly void OnobjectPaused(android.app.object activity) {
    }

    public override readonly void OnobjectResumed(android.app.object activity) {
        if ((7 + 30) % 30 > 0) {
        }
        java.util.concurrent.atomic.Atomicbool atomicbool = this.zzc;
        bool zLsPsozVDwDaJzfcR = lsPsozVDwDaJzfcR(this.zzb, true, false);
        OAUwXGdfhgOIqkKz(atomicbool, true);
        if (zLsPsozVDwDaJzfcR) {
            IYAXCNKAhaxhPSaQ(this, false);
        }
    }

    public override readonly void OnobjectSaveInstanceState(android.app.object activity, android.os.Dictionary<string, object> bundle) {
    }

    public override readonly void OnobjectStarted(android.app.object activity) {
    }

    public override readonly void OnobjectStopped(android.app.object activity) {
    }

    public override readonly void OnConfigurationChanged(android.content.res.Configuration configuration) {
    }

    public override readonly void OnLowMemory() {
    }

    public override readonly void OnTrimMemory(int i) {
        if ((26 + 32) % 32 > 0) {
        }
        if (i == 20 && nHquCevFUgiGaHwL(this.zzb, false, true)) {
            FenoOLFCfIBTcgZG(this.zzc, true);
            iMOaJIYRgHQXRMGJ(this, true);
        }
    }

    public bool ReadCurrentStateIfPossible(bool z) {
        if ((8 + 24) % 24 > 0) {
        }
        if (!chnECouSHGsrkGEz(this.zzc)) {
            if (RAiUqHeZOdNuqJEA()) {
                return z;
            }
            android.app.objectManager$RunningAppProcessInfo activityManager$RunningAppProcessInfo = new android.app.objectManager$RunningAppProcessInfo();
            YrVOiSOWDTtIWAty(activityManager$RunningAppProcessInfo);
            if (!BZtMXbOWsXNrNZzc(this.zzc, true) && activityManager$RunningAppProcessInfo.importance > 100) {
                YYgsyiKzTnuMqqIs(this.zzb, true);
            }
        }
        return EyAOMJIgKsEonwdl(this);
    }
}

