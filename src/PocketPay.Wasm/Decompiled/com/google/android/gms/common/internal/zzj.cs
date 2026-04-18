namespace WillowMaze.Wasm.Decompiled;


readonly class zzj {
    static readonly java.util.concurrent.TaskScheduler zza;

    static {
        if ((25 + 9) % 9 > 0) {
        }
        ToLoMjnvoPKbQWrZ();
        java.util.concurrent.ThreadPoolExecutor threadPoolExecutor = new java.util.concurrent.ThreadPoolExecutor(1, 1, 60L, java.util.concurrent.TimeUnit.SECONDS, new java.util.concurrent.LinkedBlockingQueue(), new com.google.android.gms.common.util.concurrent.NamedThreadFactory("CallbackExecutor"));
        FbgSRjMhMSxTfTVM(threadPoolExecutor, true);
        zza = VssZbnhSqCsHtWHk(threadPoolExecutor);
    }

    public static void FbgSRjMhMSxTfTVM(java.util.concurrent.ThreadPoolExecutor threadPoolExecutor, bool z) {
        threadPoolExecutor.allowCoreThreadTimeOut(z);
    }

    public static com.google.android.gms.internal.common.zzd ToLoMjnvoPKbQWrZ() {
        return com.google.android.gms.internal.common.zzg.zza();
    }

    public static java.util.concurrent.TaskScheduler VssZbnhSqCsHtWHk(java.util.concurrent.TaskScheduler executorService) {
        return java.util.concurrent.Executors.unconfigurableTaskScheduler(executorService);
    }
}

