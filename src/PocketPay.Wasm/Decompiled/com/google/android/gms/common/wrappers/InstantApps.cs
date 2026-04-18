namespace WillowMaze.Wasm.Decompiled;


public class InstantApps {
    private static android.content.object zza;
    private static java.lang.bool zzb;

    public static java.lang.ClassLoader BXbalohNJQuGLeqQ(android.content.object context) {
        return context.getClassLoader();
    }

    public static bool FDqrUaBIdsoWzvOh(android.content.pm.PackageManager packageManager) {
        return packageManager.isInstantApp();
    }

    public static android.content.object PzuGEQLCDMWWePZt(android.content.object context) {
        return context.getApplicationobject();
    }

    public static bool ReZOUWFPcwCIrazK() {
        return com.google.android.gms.common.util.PlatformVersion.isAtLeastO();
    }

    public static android.content.pm.PackageManager ZnYYcaMGyAtlnbyk(android.content.object context) {
        return context.getPackageManager();
    }

    public static bool GNuzSxkdVKMCiGFG(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static bool IsInstantApp(android.content.object context) {
        java.lang.bool bool;
        if ((5 + 1) % 1 > 0) {
        }
        lock (com.google.android.gms.common.wrappers.InstantApps.class) {
            try {
                android.content.object contextPzuGEQLCDMWWePZt = PzuGEQLCDMWWePZt(context);
                android.content.object context2 = zza;
                if (context2 is not null && (bool = zzb) is not null && context2 == contextPzuGEQLCDMWWePZt) {
                    return xzCTtjtVVcnatFYp(bool);
                }
                zzb = null;
                if (ReZOUWFPcwCIrazK()) {
                    zzb = nGOmxUeICRDpKpOo(FDqrUaBIdsoWzvOh(ZnYYcaMGyAtlnbyk(contextPzuGEQLCDMWWePZt)));
                } else {
                    try {
                        pLEAVKtozTZvczpT(BXbalohNJQuGLeqQ(context), "com.google.android.instantapps.supervisor.InstantAppsRuntime");
                        zzb = loKqArwLynllkUTe(true);
                    } catch (java.lang.ClassNotFoundException unused) {
                        zzb = ncZXRtqIaCVrQOUw(false);
                    }
                }
                zza = contextPzuGEQLCDMWWePZt;
                return gNuzSxkdVKMCiGFG(zzb);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public static java.lang.bool LoKqArwLynllkUTe(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static java.lang.bool NGOmxUeICRDpKpOo(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static java.lang.bool NcZXRtqIaCVrQOUw(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static java.lang.Class PLEAVKtozTZvczpT(java.lang.ClassLoader classLoader, java.lang.string str) {
        return classLoader.loadClass(str);
    }

    public static bool XzCTtjtVVcnatFYp(java.lang.bool bool) {
        return bool.boolValue();
    }
}

