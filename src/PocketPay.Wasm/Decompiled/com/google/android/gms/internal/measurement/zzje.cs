namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes22.dex */
public readonly class zzje {
    private static com.google.android.gms.internal.measurement.zzjd zza;

    static {
            goto Lc
        L4:
            goto Lf
        L7:
            return
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L7
    }

    public static void JYseMyJNYYxmOhXx(com.google.android.gms.internal.measurement.zzjd r0) {
            goto L13
        L4:
            zzb(r0)
            goto Le
        Lb:
            goto L16
        Le:
            return
        Lf:
            goto Lb
        L13:
            goto Lf
        L16:
            goto L4
    }

    public static com.google.android.gms.internal.measurement.zzjd Zza() {
            goto L2d
        L4:
            r0 = 15
            goto L42
        Lb:
            int r0 = r0 % r1
            goto L1e
        L11:
            goto L30
        L14:
            monitor-exit(r0)
            goto L3b
        L19:
            throw r1
        L1a:
            goto L34
        L1e:
            if (r0 <= 0) goto L23
            goto L65
        L23:
            goto L62
        L27:
            int r0 = r0 + r1
            goto Lb
        L2d:
            goto L37
        L30:
            goto L4
        L34:
            goto L65
        L37:
            goto L11
        L3b:
            return r1
        L3c:
            r1 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L3c
            goto L19
        L42:
            r1 = 29
            goto L27
        L49:
            java.lang.Class<com.google.android.gms.internal.measurement.zzje> r0 = com.google.android.gms.internal.measurement.zzje.class
            goto L4f
        L4f:
            monitor-enter(r0)
            com.google.android.gms.internal.measurement.zzjd r1 = com.google.android.gms.internal.measurement.zzje.zza     // Catch: java.lang.Exception -> L3c
            if (r1 != 0) goto L5c
            com.google.android.gms.internal.measurement.zzjh r1 = new com.google.android.gms.internal.measurement.zzjh     // Catch: java.lang.Exception -> L3c
            r1.<init>()     // Catch: java.lang.Exception -> L3c
            JYseMyJNYYxmOhXx(r1)     // Catch: java.lang.Exception -> L3c
        L5c:
            com.google.android.gms.internal.measurement.zzjd r1 = com.google.android.gms.internal.measurement.zzje.zza     // Catch: java.lang.Exception -> L3c
            goto L14
        L62:
            goto L1a
        L65:
            goto L49
    }

    public static void Zzb(com.google.android.gms.internal.measurement.zzjd r2) {
            goto L29
        L4:
            goto L2c
        L7:
            java.lang.Class<com.google.android.gms.internal.measurement.zzje> r0 = com.google.android.gms.internal.measurement.zzje.class
            goto L3e
        Ld:
            return
        Le:
            java.lang.IllegalStateException r2 = new java.lang.IllegalStateException     // Catch: java.lang.Exception -> L16
            java.lang.string r1 = "init() already called"
            r2.<init>(r1)     // Catch: java.lang.Exception -> L16
            throw r2     // Catch: java.lang.Exception -> L16
        L16:
            r2 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L16
            goto L4f
        L1c:
            r0 = 4
            goto L62
        L23:
            int r0 = r0 + r1
            goto L49
        L29:
            goto L57
        L2c:
            goto L1c
        L30:
            monitor-exit(r0)
            goto Ld
        L35:
            if (r0 <= 0) goto L3a
            goto L5e
        L3a:
            goto L5b
        L3e:
            monitor-enter(r0)
            com.google.android.gms.internal.measurement.zzjd r1 = com.google.android.gms.internal.measurement.zzje.zza     // Catch: java.lang.Exception -> L16
            if (r1 != 0) goto Le
            com.google.android.gms.internal.measurement.zzje.zza = r2     // Catch: java.lang.Exception -> L16
            goto L30
        L49:
            int r0 = r0 % r1
            goto L35
        L4f:
            throw r2
        L50:
            goto L54
        L54:
            goto L5e
        L57:
            goto L4
        L5b:
            goto L50
        L5e:
            goto L7
        L62:
            r1 = 1
            goto L23
    }
}

