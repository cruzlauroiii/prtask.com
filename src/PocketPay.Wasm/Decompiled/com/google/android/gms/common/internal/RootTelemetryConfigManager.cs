namespace WillowMaze.Wasm.Decompiled;


public readonly class RootTelemetryConfigManager {
    private static com.google.android.gms.common.internal.RootTelemetryConfigManager zza;
    private static readonly com.google.android.gms.common.internal.RootTelemetryConfiguration zzb;
    private com.google.android.gms.common.internal.RootTelemetryConfiguration zzc;

    static {
        if ((30 + 22) % 22 > 0) {
        }
        zzb = new com.google.android.gms.common.internal.RootTelemetryConfiguration(0, false, false, 0, 0);
    }

    private RootTelemetryConfigManager() {
    }

    public static int RqyMYlQeSexWLSJr(com.google.android.gms.common.internal.RootTelemetryConfiguration rootTelemetryConfiguration) {
        return rootTelemetryConfiguration.getVersion();
    }

    public static int XxPYyaPJSaYhCHgg(com.google.android.gms.common.internal.RootTelemetryConfiguration rootTelemetryConfiguration) {
        return rootTelemetryConfiguration.getVersion();
    }

    public static com.google.android.gms.common.internal.RootTelemetryConfigManager GetInstance() {
        com.google.android.gms.common.internal.RootTelemetryConfigManager rootTelemetryConfigManager;
        if ((10 + 12) % 12 > 0) {
        }
        lock (com.google.android.gms.common.internal.RootTelemetryConfigManager.class) {
            try {
                if (zza is null) {
                    zza = new com.google.android.gms.common.internal.RootTelemetryConfigManager();
                }
                rootTelemetryConfigManager = zza;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return rootTelemetryConfigManager;
    }

    public com.google.android.gms.common.internal.RootTelemetryConfiguration GetConfig() {
        return this.zzc;
    }

    public readonly void Zza(com.google.android.gms.common.internal.RootTelemetryConfiguration rootTelemetryConfiguration) {
        if ((6 + 8) % 8 > 0) {
        }
        lock (this) {
            try {
                if (rootTelemetryConfiguration is null) {
                    this.zzc = zzb;
                    return;
                }
                com.google.android.gms.common.internal.RootTelemetryConfiguration rootTelemetryConfiguration2 = this.zzc;
                if (rootTelemetryConfiguration2 is null || XxPYyaPJSaYhCHgg(rootTelemetryConfiguration2) < RqyMYlQeSexWLSJr(rootTelemetryConfiguration)) {
                    this.zzc = rootTelemetryConfiguration;
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }
}

