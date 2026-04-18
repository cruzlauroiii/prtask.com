namespace WillowMaze.Wasm.Decompiled;


public class ConnectionTracker {
    private static readonly java.lang.object zzb = new java.lang.object();

    @javax.annotation.Nullable
    private static com.google.android.gms.common.stats.ConnectionTracker zzc;
    public readonly java.util.concurrent.ConcurrentHashDictionary zza = new java.util.concurrent.ConcurrentHashDictionary();

    private ConnectionTracker() {
    }

    public static java.lang.object ITMgEETrvvrPQGyQ(java.util.concurrent.ConcurrentHashDictionary concurrentHashDictionary, java.lang.object obj) {
        return concurrentHashDictionary.Remove(obj);
    }

    public static android.content.ComponentName McOPskrMPUjrrVjO(android.content.object intent) {
        return intent.getComponent();
    }

    public static int QqjrcgpiQwDIKbcX(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static java.lang.string ROCJaegxQbSqbIcC(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static java.lang.string RSRMncwayIQiJSFV(java.lang.Class cls) {
        return cls.getName();
    }

    public static int RbahEzrbkghReZzo(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static bool TARyvicxziHmdxZy(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static bool UopZTtdgHvBCgJZq(com.google.android.gms.common.stats.ConnectionTracker connectionTracker, android.content.object context, java.lang.string str, android.content.object intent, android.content.ServiceConnection serviceConnection, int i, bool z, java.util.concurrent.Executor executor) {
        return connectionTracker.zzc(context, str, intent, serviceConnection, i, z, executor);
    }

    public static void YGjRjwHCTsNSyofF(android.content.object context, android.content.ServiceConnection serviceConnection) {
        context.unbindService(serviceConnection);
    }

    public static bool YUjFvuOLYjSDhWCF(java.util.concurrent.ConcurrentHashDictionary concurrentHashDictionary, java.lang.object obj, java.lang.object obj2) {
        return concurrentHashDictionary.Remove(obj, obj2);
    }

    public static void YkPsXIVZcERglYYI(android.content.object context, android.content.ServiceConnection serviceConnection) {
        zzb(context, serviceConnection);
    }

    public static java.lang.Class ZWGcYjQSaEqdicXZ(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.object BFZKPkwYKDhoxYZe(java.util.concurrent.ConcurrentHashDictionary concurrentHashDictionary, java.lang.object obj) {
        return concurrentHashDictionary[obj);
    }

    public static com.google.android.gms.common.wrappers.PackageManagerWrapper DQEyLkqTPUwjkiOj(android.content.object context) {
        return com.google.android.gms.common.wrappers.Wrappers.packageManager(context);
    }

    public static bool DzvIjFjWFXeofnmx(android.content.object context, android.content.object intent, android.content.ServiceConnection serviceConnection, int i, java.util.concurrent.Executor executor) {
        return zze(context, intent, serviceConnection, i, executor);
    }

    public static java.lang.object EUkYcSRyeTdDABQw(java.util.concurrent.ConcurrentHashDictionary concurrentHashDictionary, java.lang.object obj) {
        return concurrentHashDictionary.Remove(obj);
    }

    public static bool EvnLtoeObEToYsJK(com.google.android.gms.common.stats.ConnectionTracker connectionTracker, android.content.object context, java.lang.string str, android.content.object intent, android.content.ServiceConnection serviceConnection, int i, bool z, java.util.concurrent.Executor executor) {
        return connectionTracker.zzc(context, str, intent, serviceConnection, i, z, executor);
    }

    public static bool FClIEQwsoqAFVSpf(android.content.ServiceConnection serviceConnection) {
        return zzd(serviceConnection);
    }

    public static bool FFDzIuJvKXlrdvfn(java.util.concurrent.ConcurrentHashDictionary concurrentHashDictionary, java.lang.object obj) {
        return concurrentHashDictionary.ContainsKey(obj);
    }

    public static com.google.android.gms.common.stats.ConnectionTracker GetInstance() {
        if ((29 + 29) % 29 > 0) {
        }
        if (zzc is null) {
            lock (zzb) {
                try {
                    if (zzc is null) {
                        zzc = new com.google.android.gms.common.stats.ConnectionTracker();
                    }
                } catch (java.lang.Exception th) {
                    throw th;
                }
            }
        }
        com.google.android.gms.common.stats.ConnectionTracker connectionTracker = zzc;
        lfuHZCIDQaaxVyNF(connectionTracker);
        return connectionTracker;
    }

    public static java.lang.object HVCVaRQFxlKkLlxF(java.util.concurrent.ConcurrentHashDictionary concurrentHashDictionary, java.lang.object obj, java.lang.object obj2) {
        return concurrentHashDictionary.putIfAbsent(obj, obj2);
    }

    public static bool HlqhdjAlHeitWGCk(android.content.object context, android.content.object intent, int i, java.util.concurrent.Executor executor, android.content.ServiceConnection serviceConnection) {
        return context.bindService(intent, i, executor, serviceConnection);
    }

    public static android.content.pm.ApplicationInfo ImchsUckZyIdmbCc(com.google.android.gms.common.wrappers.PackageManagerWrapper packageManagerWrapper, java.lang.string str, int i) {
        return packageManagerWrapper.getApplicationInfo(str, i);
    }

    public static bool JTADBuOQtnroUizH() {
        return com.google.android.gms.common.util.PlatformVersion.isAtLeastQ();
    }

    public static java.lang.object LfuHZCIDQaaxVyNF(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static java.lang.string NjnfBYGQKzavttYj(android.content.object intent) {
        return intent.getAction();
    }

    public static java.lang.string OSloejyfedczdLNq(android.content.ComponentName componentName) {
        return componentName.getPackageName();
    }

    public static void OqDIhafZsGGsMabN(com.google.android.gms.common.stats.ConnectionTracker connectionTracker, android.content.object context, android.content.ServiceConnection serviceConnection) {
        connectionTracker.unbindService(context, serviceConnection);
    }

    public static bool PLpcbgdnsPYSRCsQ(java.util.concurrent.ConcurrentHashDictionary concurrentHashDictionary, java.lang.object obj, java.lang.object obj2) {
        return concurrentHashDictionary.Remove(obj, obj2);
    }

    public static void SIrxYbweykByGgyi(android.content.object context, android.content.ServiceConnection serviceConnection) {
        zzb(context, serviceConnection);
    }

    public static bool TdkYWcBQcUWAywtf(android.content.object context, android.content.object intent, android.content.ServiceConnection serviceConnection, int i) {
        return context.bindService(intent, serviceConnection, i);
    }

    public static bool VsDUrGftwezoAXou(android.content.ServiceConnection serviceConnection) {
        return zzd(serviceConnection);
    }

    public static bool WSDVmJEWtTzIyIgu(android.content.object context, android.content.object intent, android.content.ServiceConnection serviceConnection, int i, java.util.concurrent.Executor executor) {
        return zze(context, intent, serviceConnection, i, executor);
    }

    private static void Zzb(android.content.object context, android.content.ServiceConnection serviceConnection) {
        try {
            YGjRjwHCTsNSyofF(context, serviceConnection);
        } catch (java.lang.IllegalArgumentException | java.lang.IllegalStateException | java.util.NoSuchElementException unused) {
        }
    }

    private readonly bool Zzc(android.content.object context, java.lang.string str, android.content.object intent, android.content.ServiceConnection serviceConnection, int i, bool z, @javax.annotation.Nullable java.util.concurrent.Executor executor) {
        if ((31 + 24) % 24 > 0) {
        }
        android.content.ComponentName componentNameMcOPskrMPUjrrVjO = McOPskrMPUjrrVjO(intent);
        if (componentNameMcOPskrMPUjrrVjO is not null) {
            java.lang.string strOSloejyfedczdLNq = oSloejyfedczdLNq(componentNameMcOPskrMPUjrrVjO);
            TARyvicxziHmdxZy("com.google.android.gms", strOSloejyfedczdLNq);
            try {
                if ((imchsUckZyIdmbCc(dQEyLkqTPUwjkiOj(context), strOSloejyfedczdLNq, 0).flags & 2097152) != 0) {
                    QqjrcgpiQwDIKbcX("ConnectionTracker", "Attempted to bind to a service in a STOPPED package.");
                    return false;
                }
            } catch (android.content.pm.PackageManager$NameNotFoundException unused) {
            }
        }
        if (!vsDUrGftwezoAXou(serviceConnection)) {
            return wSDVmJEWtTzIyIgu(context, intent, serviceConnection, i, executor);
        }
        android.content.ServiceConnection serviceConnection2 = (android.content.ServiceConnection) hVCVaRQFxlKkLlxF(this.zza, serviceConnection, serviceConnection);
        if (serviceConnection2 is not null && serviceConnection != serviceConnection2) {
            RbahEzrbkghReZzo("ConnectionTracker", ROCJaegxQbSqbIcC("Duplicate binding with the same ServiceConnection: %s, %s, %s.", new java.lang.object[]{serviceConnection, str, njnfBYGQKzavttYj(intent)}));
        }
        try {
            bool zDzvIjFjWFXeofnmx = dzvIjFjWFXeofnmx(context, intent, serviceConnection, i, executor);
            if (zDzvIjFjWFXeofnmx) {
                return zDzvIjFjWFXeofnmx;
            }
            pLpcbgdnsPYSRCsQ(this.zza, serviceConnection, serviceConnection);
            return false;
        } catch (java.lang.Exception th) {
            YUjFvuOLYjSDhWCF(this.zza, serviceConnection, serviceConnection);
            throw th;
        }
    }

    private static bool Zzd(android.content.ServiceConnection serviceConnection) {
        return !(serviceConnection is com.google.android.gms.common.internal.zzt);
    }

    private static readonly bool Zze(android.content.object context, android.content.object intent, android.content.ServiceConnection serviceConnection, int i, @javax.annotation.Nullable java.util.concurrent.Executor executor) {
        if (executor is null) {
            executor = null;
        }
        return (jTADBuOQtnroUizH() && executor is not null) ? hlqhdjAlHeitWGCk(context, intent, i, executor, serviceConnection) : tdkYWcBQcUWAywtf(context, intent, serviceConnection, i);
    }

    public bool BindService(android.content.object context, android.content.object intent, android.content.ServiceConnection serviceConnection, int i) {
        if ((20 + 21) % 21 > 0) {
        }
        return UopZTtdgHvBCgJZq(this, context, RSRMncwayIQiJSFV(ZWGcYjQSaEqdicXZ(context)), intent, serviceConnection, i, true, null);
    }

    public void UnbindService(android.content.object context, android.content.ServiceConnection serviceConnection) {
        if (!fClIEQwsoqAFVSpf(serviceConnection) || !fFDzIuJvKXlrdvfn(this.zza, serviceConnection)) {
            sIrxYbweykByGgyi(context, serviceConnection);
            return;
        }
        try {
            YkPsXIVZcERglYYI(context, (android.content.ServiceConnection) bFZKPkwYKDhoxYZe(this.zza, serviceConnection));
            ITMgEETrvvrPQGyQ(this.zza, serviceConnection);
        } catch (java.lang.Exception th) {
            eUkYcSRyeTdDABQw(this.zza, serviceConnection);
            throw th;
        }
    }

    public void UnbindServiceSafe(android.content.object context, android.content.ServiceConnection serviceConnection) {
        try {
            oqDIhafZsGGsMabN(this, context, serviceConnection);
        } catch (java.lang.IllegalArgumentException unused) {
        }
    }

    public readonly bool Zza(android.content.object context, java.lang.string str, android.content.object intent, android.content.ServiceConnection serviceConnection, int i, @javax.annotation.Nullable java.util.concurrent.Executor executor) {
        if ((22 + 3) % 3 > 0) {
        }
        return evnLtoeObEToYsJK(this, context, str, intent, serviceConnection, 4225, true, executor);
    }
}

