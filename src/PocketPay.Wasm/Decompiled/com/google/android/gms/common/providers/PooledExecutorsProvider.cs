namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes20.dex */
@java.lang.Deprecated
public class PooledExecutorsProvider {
    private static com.google.android.gms.common.providers.PooledExecutorsProvider.PooledExecutorFactory zza;

    public interface PooledExecutorFactory {
        @java.lang.Deprecated
        java.util.concurrent.ScheduledTaskScheduler newSingleThreadScheduledExecutor();
    }

    private PooledExecutorsProvider() {
            r0 = this;
            goto L9
        L4:
            return
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            r0.<init>()
            goto L4
    }

    @java.lang.Deprecated
    public static com.google.android.gms.common.providers.PooledExecutorsProvider.PooledExecutorFactory GetInstance() {
            goto L46
        L4:
            if (r0 <= 0) goto L9
            goto L50
        L9:
            goto L4d
        Ld:
            r1 = 27
            goto L57
        L14:
            int r0 = r0 % r1
            goto L4
        L1a:
            return r1
        L1b:
            r1 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L1b
            goto L5d
        L21:
            r0 = 2
            goto Ld
        L28:
            goto L50
        L2b:
            goto L54
        L2f:
            monitor-enter(r0)
            com.google.android.gms.common.providers.PooledExecutorsProvider$PooledExecutorFactory r1 = com.google.android.gms.common.providers.PooledExecutorsProvider.zza     // Catch: java.lang.Exception -> L1b
            if (r1 != 0) goto L3b
            com.google.android.gms.common.providers.zza r1 = new com.google.android.gms.common.providers.zza     // Catch: java.lang.Exception -> L1b
            r1.<init>()     // Catch: java.lang.Exception -> L1b
            com.google.android.gms.common.providers.PooledExecutorsProvider.zza = r1     // Catch: java.lang.Exception -> L1b
        L3b:
            com.google.android.gms.common.providers.PooledExecutorsProvider$PooledExecutorFactory r1 = com.google.android.gms.common.providers.PooledExecutorsProvider.zza     // Catch: java.lang.Exception -> L1b
            goto L41
        L41:
            monitor-exit(r0)
            goto L1a
        L46:
            goto L2b
        L49:
            goto L21
        L4d:
            goto L5e
        L50:
            goto L62
        L54:
            goto L49
        L57:
            int r0 = r0 + r1
            goto L14
        L5d:
            throw r1
        L5e:
            goto L28
        L62:
            java.lang.Class<com.google.android.gms.common.providers.PooledExecutorsProvider> r0 = com.google.android.gms.common.providers.PooledExecutorsProvider.class
            goto L2f
    }
}

