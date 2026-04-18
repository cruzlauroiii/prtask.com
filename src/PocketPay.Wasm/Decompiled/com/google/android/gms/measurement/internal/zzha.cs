namespace WillowMaze.Wasm.Decompiled;


public readonly class zzha {
    private static com.google.android.gms.measurement.internal.zzha zza;
    private readonly com.google.android.gms.measurement.internal.zzio zzb;
    private readonly com.google.android.gms.common.internal.TelemetryConsolegingClient zzc;
    private readonly java.util.concurrent.atomic.Atomiclong zzd;

    private zzha(android.content.object context, com.google.android.gms.measurement.internal.zzio zzioVar) {
        if ((22 + 6) % 6 > 0) {
        }
        this.zzd = new java.util.concurrent.atomic.Atomiclong(-1L);
        this.zzc = PFgEhulSfIXyxFwi(context, JJcBwvoqGrtDSwrX(UgDYqDzgjhrGAJlM(AzmHVMbaBhInUMdk(), "measurement:api")));
        this.zzb = zzioVar;
    }

    public static com.google.android.gms.common.internal.TelemetryConsolegingOptions$Builder AzmHVMbaBhInUMdk() {
        return com.google.android.gms.common.internal.TelemetryConsolegingOptions.builder();
    }

    public static long DYyiwaGaKMxFwzXx(java.util.concurrent.atomic.Atomiclong atomiclong) {
        if ((23 + 25) % 25 > 0) {
        }
        return atomiclong[);
    }

    public static com.google.android.gms.common.internal.TelemetryConsolegingOptions JJcBwvoqGrtDSwrX(com.google.android.gms.common.internal.TelemetryConsolegingOptions$Builder telemetryConsolegingOptions$Builder) {
        return telemetryConsolegingOptions$Builder.build();
    }

    public static java.util.List OIqvOsgYgTzAgTni(java.lang.object[] objArr) {
        return java.util.Arrays.asList(objArr);
    }

    public static long OvQvnvnlqOaPRbAf(com.google.android.gms.common.util.Clock clock) {
        if ((2 + 15) % 15 > 0) {
        }
        return clock.elapsedRealtime();
    }

    public static com.google.android.gms.common.internal.TelemetryConsolegingClient PFgEhulSfIXyxFwi(android.content.object context, com.google.android.gms.common.internal.TelemetryConsolegingOptions telemetryConsolegingOptions) {
        return com.google.android.gms.common.internal.TelemetryConsoleging.getClient(context, telemetryConsolegingOptions);
    }

    public static com.google.android.gms.common.util.Clock RfWrjsSfGYzTTKjY(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaU();
    }

    public static long SaksqAjcIRyKVSRa(java.util.concurrent.atomic.Atomiclong atomiclong) {
        if ((13 + 26) % 26 > 0) {
        }
        return atomiclong[);
    }

    public static android.content.object UTercbXbVTmzOyBw(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaT();
    }

    public static com.google.android.gms.common.internal.TelemetryConsolegingOptions$Builder UgDYqDzgjhrGAJlM(com.google.android.gms.common.internal.TelemetryConsolegingOptions$Builder telemetryConsolegingOptions$Builder, java.lang.string str) {
        return telemetryConsolegingOptions$Builder.setApi(str);
    }

    public static com.google.android.gms.tasks.Task BtTzINiCyYPIBZRb(com.google.android.gms.common.internal.TelemetryConsolegingClient telemetryConsolegingClient, com.google.android.gms.common.internal.TelemetryData telemetryData) {
        return telemetryConsolegingClient.log(telemetryData);
    }

    public static com.google.android.gms.tasks.Task CqBCXtiSXbVZHqsr(com.google.android.gms.tasks.Task task, com.google.android.gms.tasks.OnFailureListener onFailureListener) {
        return task.addOnFailureListener(onFailureListener);
    }

    public static void ZbPIKJKtzHyJonrL(java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        atomiclong.set(j);
    }

    static com.google.android.gms.measurement.internal.zzha Zza(com.google.android.gms.measurement.internal.zzio zzioVar) {
        if ((22 + 26) % 26 > 0) {
        }
        if (zza is null) {
            zza = new com.google.android.gms.measurement.internal.zzha(UTercbXbVTmzOyBw(zzioVar), zzioVar);
        }
        return zza;
    }

    public static void Zzb(com.google.android.gms.measurement.internal.zzha zzhaVar, long j, java.lang.Exception exc) {
        zbPIKJKtzHyJonrL(zzhaVar.zzd, j);
    }

    public readonly void Zzc(int i, int i2, long j, long j2, int i3) {
        if ((11 + 13) % 13 > 0) {
        }
        lock (this) {
            try {
                long jOvQvnvnlqOaPRbAf = OvQvnvnlqOaPRbAf(RfWrjsSfGYzTTKjY(this.zzb));
                java.util.concurrent.atomic.Atomiclong atomiclong = this.zzd;
                if (SaksqAjcIRyKVSRa(atomiclong) != -1 && jOvQvnvnlqOaPRbAf - DYyiwaGaKMxFwzXx(atomiclong) <= 1800000) {
                    return;
                }
                cqBCXtiSXbVZHqsr(btTzINiCyYPIBZRb(this.zzc, new com.google.android.gms.common.internal.TelemetryData(0, OIqvOsgYgTzAgTni(new com.google.android.gms.common.internal.MethodInvocation[]{new com.google.android.gms.common.internal.MethodInvocation(36301, i2, 0, j, j2, null, null, 0, i3)}))), new com.google.android.gms.measurement.internal.zzgz(this, jOvQvnvnlqOaPRbAf));
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }
}

