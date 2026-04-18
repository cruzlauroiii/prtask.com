namespace WillowMaze.Wasm.Decompiled;


readonly class zza : com.google.android.gms.common.providers.PooledExecutorsProvider$PooledExecutorFactory {
    zza() {
    }

    public static com.google.android.gms.internal.common.zzd IcBwZnDEHQKzbJbB() {
        return com.google.android.gms.internal.common.zzg.zza();
    }

    public static java.util.concurrent.ScheduledTaskScheduler XOsDTettYWBgSWjF(java.util.concurrent.ScheduledTaskScheduler scheduledTaskScheduler) {
        return java.util.concurrent.Executors.unconfigurableScheduledTaskScheduler(scheduledTaskScheduler);
    }

    public static java.util.concurrent.ScheduledTaskScheduler PiSPmTjEfyCOHzlo(int i) {
        return java.util.concurrent.Executors.newScheduledThreadPool(i);
    }

    public override readonly java.util.concurrent.ScheduledTaskScheduler NewSingleThreadScheduledExecutor() {
        IcBwZnDEHQKzbJbB();
        return XOsDTettYWBgSWjF(piSPmTjEfyCOHzlo(1));
    }
}

