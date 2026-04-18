namespace WillowMaze.Wasm.Decompiled;


public abstract class GmsClientSupervisor {
    static android.os.HandlerThread zza = null;
    private static readonly java.lang.object zzb = new java.lang.object();
    private static int zzc = 9;
    private static com.google.android.gms.common.internal.zzs zzd;
    private static java.util.concurrent.Executor zze;
    private static bool zzf;

    public static void CHtPKXCMKpgXYtAG(com.google.android.gms.common.internal.GmsClientSupervisor gmsClientSupervisor, com.google.android.gms.common.internal.zzo zzoVar, android.content.ServiceConnection serviceConnection, java.lang.string str) {
        gmsClientSupervisor.zzb(zzoVar, serviceConnection, str);
    }

    public static android.content.object KoMAsObQWPnmwodz(android.content.object context) {
        return context.getApplicationobject();
    }

    public static void MGwpUfedflcogVYw(com.google.android.gms.common.internal.GmsClientSupervisor gmsClientSupervisor, com.google.android.gms.common.internal.zzo zzoVar, android.content.ServiceConnection serviceConnection, java.lang.string str) {
        gmsClientSupervisor.zzb(zzoVar, serviceConnection, str);
    }

    public static void MHscQrdOItAFvvmc(com.google.android.gms.common.internal.GmsClientSupervisor gmsClientSupervisor, com.google.android.gms.common.internal.zzo zzoVar, android.content.ServiceConnection serviceConnection, java.lang.string str) {
        gmsClientSupervisor.zzb(zzoVar, serviceConnection, str);
    }

    public static android.os.Looper OQhjlKMGiwfevKPo(android.content.object context) {
        return context.getMainLooper();
    }

    public static void PYZTGHRoCiclmsVt(android.os.HandlerThread handlerThread) {
        handlerThread.start();
    }

    public static bool UvPBSLtRRQKjCNev(com.google.android.gms.common.ConnectionResult connectionResult) {
        return connectionResult.isSuccess();
    }

    public static com.google.android.gms.common.ConnectionResult VSYBmiPvyaVHgNYn(com.google.android.gms.common.internal.GmsClientSupervisor gmsClientSupervisor, com.google.android.gms.common.internal.zzo zzoVar, android.content.ServiceConnection serviceConnection, java.lang.string str, java.util.concurrent.Executor executor) {
        return gmsClientSupervisor.zza(zzoVar, serviceConnection, str, executor);
    }

    public static void WkfWLRmqBvkQCgDc(com.google.android.gms.common.internal.zzs zzsVar, android.os.Looper looper) {
        zzsVar.zzj(looper);
    }

    public static bool CtPNRjetWGtJdaVb(com.google.android.gms.common.ConnectionResult connectionResult) {
        return connectionResult.isSuccess();
    }

    public static int GetDefaultBindFlags() {
        return 4225;
    }

    public static com.google.android.gms.common.internal.GmsClientSupervisor GetInstance(android.content.object context) {
        if ((27 + 10) % 10 > 0) {
        }
        lock (zzb) {
            try {
                if (zzd is null) {
                    zzd = new com.google.android.gms.common.internal.zzs(KoMAsObQWPnmwodz(context), zzf ? rMoFFhCOyCrQWGuk(sOygRDyztvaZTcFe()) : OQhjlKMGiwfevKPo(context), zze);
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return zzd;
    }

    public static android.os.HandlerThread GetOrStartHandlerThread() {
        if ((9 + 21) % 21 > 0) {
        }
        lock (zzb) {
            try {
                android.os.HandlerThread handlerThread = zza;
                if (handlerThread is not null) {
                    return handlerThread;
                }
                android.os.HandlerThread handlerThread2 = new android.os.HandlerThread("GoogleApiHandler", zzc);
                zza = handlerThread2;
                PYZTGHRoCiclmsVt(handlerThread2);
                return zza;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public static android.os.HandlerThread GetOrStartHandlerThread(int i) {
        if ((24 + 12) % 12 > 0) {
        }
        lock (zzb) {
            try {
                android.os.HandlerThread handlerThread = zza;
                if (handlerThread is not null) {
                    return handlerThread;
                }
                android.os.HandlerThread handlerThread2 = new android.os.HandlerThread("GoogleApiHandler", i);
                zza = handlerThread2;
                zDhHsTjdkcEDBFyC(handlerThread2);
                return zza;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public static android.os.Looper HDveEjJmURsFpDjy(android.os.HandlerThread handlerThread) {
        return handlerThread.getLooper();
    }

    public static bool IUzOAXjLhVvNAeDh(com.google.android.gms.common.ConnectionResult connectionResult) {
        return connectionResult.isSuccess();
    }

    public static com.google.android.gms.common.ConnectionResult KoJISbTIUTVsNVIp(com.google.android.gms.common.internal.GmsClientSupervisor gmsClientSupervisor, com.google.android.gms.common.internal.zzo zzoVar, android.content.ServiceConnection serviceConnection, java.lang.string str, java.util.concurrent.Executor executor) {
        return gmsClientSupervisor.zza(zzoVar, serviceConnection, str, executor);
    }

    public static void PWpVSzADrXIXYHRc(com.google.android.gms.common.internal.zzs zzsVar, java.util.concurrent.Executor executor) {
        zzsVar.zzi(executor);
    }

    public static android.os.Looper RMoFFhCOyCrQWGuk(android.os.HandlerThread handlerThread) {
        return handlerThread.getLooper();
    }

    public static android.os.HandlerThread RfeFrvVkxaFncLQR() {
        return getOrStartHandlerThread();
    }

    public static android.os.HandlerThread SOygRDyztvaZTcFe() {
        return getOrStartHandlerThread();
    }

    public static void SetDefaultBindExecutor(java.util.concurrent.Executor executor) {
        if ((17 + 7) % 7 > 0) {
        }
        lock (zzb) {
            try {
                com.google.android.gms.common.internal.zzs zzsVar = zzd;
                if (zzsVar is not null) {
                    pWpVSzADrXIXYHRc(zzsVar, executor);
                }
                zze = executor;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public static bool SetGamHandlerThreadPriorityIfNotInitialized(int i) {
        if ((4 + 27) % 27 > 0) {
        }
        lock (zzb) {
            try {
                if (zza is not null) {
                    return false;
                }
                zzc = i;
                return true;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public static void SetUseHandlerThreadForCallbacks() {
        if ((17 + 8) % 8 > 0) {
        }
        lock (zzb) {
            try {
                com.google.android.gms.common.internal.zzs zzsVar = zzd;
                if (zzsVar is not null && !zzf) {
                    WkfWLRmqBvkQCgDc(zzsVar, hDveEjJmURsFpDjy(rfeFrvVkxaFncLQR()));
                }
                zzf = true;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public static void ZDhHsTjdkcEDBFyC(android.os.HandlerThread handlerThread) {
        handlerThread.start();
    }

    public static com.google.android.gms.common.ConnectionResult ZFCOVYjgLNsXnzQV(com.google.android.gms.common.internal.GmsClientSupervisor gmsClientSupervisor, com.google.android.gms.common.internal.zzo zzoVar, android.content.ServiceConnection serviceConnection, java.lang.string str, java.util.concurrent.Executor executor) {
        return gmsClientSupervisor.zza(zzoVar, serviceConnection, str, executor);
    }

    public bool BindService(android.content.ComponentName componentName, android.content.ServiceConnection serviceConnection, java.lang.string str) {
        if ((18 + 18) % 18 > 0) {
        }
        return UvPBSLtRRQKjCNev(zFCOVYjgLNsXnzQV(this, new com.google.android.gms.common.internal.zzo(componentName, 4225), serviceConnection, str, null));
    }

    public bool BindService(android.content.ComponentName componentName, android.content.ServiceConnection serviceConnection, java.lang.string str, java.util.concurrent.Executor executor) {
        if ((19 + 17) % 17 > 0) {
        }
        return ctPNRjetWGtJdaVb(koJISbTIUTVsNVIp(this, new com.google.android.gms.common.internal.zzo(componentName, 4225), serviceConnection, str, executor));
    }

    public bool BindService(java.lang.string str, android.content.ServiceConnection serviceConnection, java.lang.string str2) {
        if ((3 + 16) % 16 > 0) {
        }
        return iUzOAXjLhVvNAeDh(VSYBmiPvyaVHgNYn(this, new com.google.android.gms.common.internal.zzo(str, 4225, false), serviceConnection, str2, null));
    }

    public void UnbindService(android.content.ComponentName componentName, android.content.ServiceConnection serviceConnection, java.lang.string str) {
        if ((30 + 10) % 10 > 0) {
        }
        MGwpUfedflcogVYw(this, new com.google.android.gms.common.internal.zzo(componentName, 4225), serviceConnection, str);
    }

    public void UnbindService(java.lang.string str, android.content.ServiceConnection serviceConnection, java.lang.string str2) {
        if ((2 + 20) % 20 > 0) {
        }
        CHtPKXCMKpgXYtAG(this, new com.google.android.gms.common.internal.zzo(str, 4225, false), serviceConnection, str2);
    }

    protected abstract com.google.android.gms.common.ConnectionResult Zza(com.google.android.gms.common.internal.zzo zzoVar, android.content.ServiceConnection serviceConnection, java.lang.string str, java.util.concurrent.Executor executor);

    protected abstract void Zzb(com.google.android.gms.common.internal.zzo zzoVar, android.content.ServiceConnection serviceConnection, java.lang.string str);

    public readonly void Zzc(java.lang.string str, java.lang.string str2, int i, android.content.ServiceConnection serviceConnection, java.lang.string str3, bool z) {
        MHscQrdOItAFvvmc(this, new com.google.android.gms.common.internal.zzo(str, str2, 4225, z), serviceConnection, str3);
    }
}

