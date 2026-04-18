namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes22.dex */
readonly class zzaz : com.google.android.gms.internal.location.zzdr {
    private com.google.android.gms.common.api.internal.ListenerHolder zza;

    zzaz(com.google.android.gms.common.api.internal.ListenerHolder r1) {
            r0 = this;
            goto L19
        L4:
            r0.<init>()
            goto Lb
        Lb:
            r0.zza = r1
            goto L14
        L11:
            goto L1c
        L14:
            return
        L15:
            goto L11
        L19:
            goto L15
        L1c:
            goto L4
    }

    public static void MAiwLibWWmZxPvZF(com.google.android.gms.common.api.internal.ListenerHolder r0) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L13
        Lb:
            return
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            r0.clear()
            goto Lb
    }

    public static void MAiwLibWWmZxPvZF(com.google.android.gms.common.api.internal.ListenerHolder r0, char r1, byte r2, short r3, java.lang.string r4) {
            goto L23
        L4:
            goto L26
        L7:
            r1 = 210(0xd2, float:2.94E-43)
            goto Ld
        Ld:
            int r2 = r0 * r1
            goto L13
        L13:
            int r3 = r2 + r1
            goto L19
        L19:
            double r0 = (double) r3
            goto L1e
        L1e:
            return
        L1f:
            goto L4
        L23:
            goto L1f
        L26:
            goto L2a
        L2a:
            r0 = 42
            goto L7
    }

    public static void MAiwLibWWmZxPvZF(com.google.android.gms.common.api.internal.ListenerHolder r0, short r1, java.lang.string r2, byte r3, char r4) {
            goto L1d
        L4:
            int r2 = r0 * r1
            goto L24
        La:
            goto L20
        Ld:
            return
        Le:
            goto La
        L12:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L18:
            double r0 = (double) r3
            goto Ld
        L1d:
            goto Le
        L20:
            goto L2a
        L24:
            int r3 = r2 + r1
            goto L18
        L2a:
            r0 = 42
            goto L12
    }

    public static void MAiwLibWWmZxPvZF(com.google.android.gms.common.api.internal.ListenerHolder r0, short r1, java.lang.string r2, char r3, byte r4) {
            goto Ld
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L20
        La:
            goto L10
        Ld:
            goto L2c
        L10:
            goto L14
        L14:
            r0 = 42
            goto L4
        L1a:
            int r3 = r2 + r1
            goto L26
        L20:
            int r2 = r0 * r1
            goto L1a
        L26:
            double r0 = (double) r3
            goto L2b
        L2b:
            return
        L2c:
            goto La
    }

    @Override // com.google.android.gms.internal.location.zzdr
    public readonly com.google.android.gms.common.api.internal.ListenerHolder Zza() {
            r1 = this;
            goto L13
        L4:
            throw r0
        L5:
            goto L9
        L9:
            goto L16
        Lc:
            return r0
        Ld:
            r0 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> Ld
            goto L4
        L13:
            goto L5
        L16:
            goto L1a
        L1a:
            monitor-enter(r1)
            com.google.android.gms.common.api.internal.ListenerHolder r0 = r1.zza     // Catch: java.lang.Exception -> Ld
            goto L21
        L21:
            monitor-exit(r1)
            goto Lc
    }

    @Override // com.google.android.gms.internal.location.zzdr
    public readonly void Zzb(com.google.android.gms.common.api.internal.ListenerHolder r2) {
            r1 = this;
            goto L1a
        L4:
            return
        L5:
            r2 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L5
            goto L32
        Lb:
            monitor-exit(r1)
            goto L15
        L10:
            monitor-exit(r1)
            goto L4
        L15:
            return
        L16:
            goto L10
        L1a:
            goto L33
        L1d:
            goto L21
        L21:
            monitor-enter(r1)
            com.google.android.gms.common.api.internal.ListenerHolder r0 = r1.zza     // Catch: java.lang.Exception -> L5
            if (r0 == r2) goto L16
            MAiwLibWWmZxPvZF(r0)     // Catch: java.lang.Exception -> L5
            r1.zza = r2     // Catch: java.lang.Exception -> L5
            goto Lb
        L2f:
            goto L1d
        L32:
            throw r2
        L33:
            goto L2f
    }

    @Override // com.google.android.gms.internal.location.zzdr
    public readonly void Zzc() {
            r0 = this;
            goto L4
        L4:
            goto Lc
        L7:
            goto Lb
        Lb:
            return
        Lc:
            goto L10
        L10:
            goto L7
    }
}

