namespace WillowMaze.Wasm.Decompiled;


readonly class zzdq : com.google.android.gms.location.zzs {
    private com.google.android.gms.common.api.internal.ListenerHolder zza;

    zzdq(com.google.android.gms.common.api.internal.ListenerHolder listenerHolder) {
        this.zza = listenerHolder;
    }

    public static void DhPmlBAntfLnndLU(com.google.android.gms.common.api.internal.ListenerHolder listenerHolder) {
        listenerHolder.clear();
    }

    public static void DhPmlBAntfLnndLU(com.google.android.gms.common.api.internal.ListenerHolder listenerHolder, char c, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DhPmlBAntfLnndLU(com.google.android.gms.common.api.internal.ListenerHolder listenerHolder, char c, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DhPmlBAntfLnndLU(com.google.android.gms.common.api.internal.ListenerHolder listenerHolder, short s, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OlPswKxoObvWvJkf(com.google.android.gms.common.api.internal.ListenerHolder listenerHolder) {
        listenerHolder.clear();
    }

    public static void OlPswKxoObvWvJkf(com.google.android.gms.common.api.internal.ListenerHolder listenerHolder, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OlPswKxoObvWvJkf(com.google.android.gms.common.api.internal.ListenerHolder listenerHolder, short s, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OlPswKxoObvWvJkf(com.google.android.gms.common.api.internal.ListenerHolder listenerHolder, bool z, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TbzpNGhbIYYXJNOV(com.google.android.gms.common.api.internal.ListenerHolder listenerHolder, com.google.android.gms.common.api.internal.ListenerHolder$Notifier listenerHolder$Notifier) {
        listenerHolder.notifyListener(listenerHolder$Notifier);
    }

    public static void TbzpNGhbIYYXJNOV(com.google.android.gms.common.api.internal.ListenerHolder listenerHolder, com.google.android.gms.common.api.internal.ListenerHolder$Notifier listenerHolder$Notifier, byte b, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TbzpNGhbIYYXJNOV(com.google.android.gms.common.api.internal.ListenerHolder listenerHolder, com.google.android.gms.common.api.internal.ListenerHolder$Notifier listenerHolder$Notifier, java.lang.string str, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TbzpNGhbIYYXJNOV(com.google.android.gms.common.api.internal.ListenerHolder listenerHolder, com.google.android.gms.common.api.internal.ListenerHolder$Notifier listenerHolder$Notifier, short s, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    /*  JADX ERROR: JadxException in pass: BlockProcessor
        jadx.core.utils.exceptions.JadxException: Found unreachable blocks
        	at jadx.core.dex.visitors.blocks.DominatorTree.sortBlocks(DominatorTree.java:34)
        	at jadx.core.dex.visitors.blocks.DominatorTree.compute(DominatorTree.java:24)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.computeDominators(BlockProcessor.java:290)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.processBlocksTree(BlockProcessor.java:56)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.visit(BlockProcessor.java:50)
        */
    readonly void zzc(com.google.android.gms.common.api.internal.ListenerHolder r2) {
        /*
            r1 = this;
            goto Lb
        L4:
            return
        L5:
            r2 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L5
            goto L1c
        Lb:
            goto L1d
        Le:
            goto L24
        L12:
            return
        L13:
            goto L17
        L17:
            monitor-exit(r1)
            goto L4
        L1c:
            throw r2
        L1d:
            goto L21
        L21:
            goto Le
        L24:
            monitor-enter(r1)
            com.google.android.gms.common.api.internal.ListenerHolder r0 = r1.zza     // Catch: java.lang.Exception -> L5
            if (r0 == r2) goto L13
            OlPswKxoObvWvJkf(r0)     // Catch: java.lang.Exception -> L5
            r1.zza = r2     // Catch: java.lang.Exception -> L5
            goto L32
        L32:
            monitor-exit(r1)
            goto L12
        */
        throw new UnsupportedOperationException("Method not decompiled: com.google.android.gms.internal.identity.zzdq.zzc(com.google.android.gms.common.api.internal.ListenerHolder):void");
    }

    /*  JADX ERROR: JadxException in pass: BlockProcessor
        jadx.core.utils.exceptions.JadxException: Found unreachable blocks
        	at jadx.core.dex.visitors.blocks.DominatorTree.sortBlocks(DominatorTree.java:34)
        	at jadx.core.dex.visitors.blocks.DominatorTree.compute(DominatorTree.java:24)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.computeDominators(BlockProcessor.java:290)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.processBlocksTree(BlockProcessor.java:56)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.visit(BlockProcessor.java:50)
        */
    public override readonly void Zzd(com.google.android.gms.location.DeviceOrientation r3) {
        /*
            r2 = this;
            goto L4
        L4:
            goto L5a
        L7:
            goto Lb
        Lb:
            r0 = 30
            goto L25
        L12:
            com.google.android.gms.internal.location.zzdp r1 = new com.google.android.gms.internal.location.zzdp
            goto L3b
        L18:
            int r0 = r0 % r1
            goto L5e
        L1e:
            TbzpNGhbIYYXJNOV(r0, r1)
            goto L31
        L25:
            r1 = 1
            goto L51
        L2c:
            throw r3
        L2d:
            goto L57
        L31:
            return
        L32:
            r3 = move-exception
            monitor-exit(r2)     // Catch: java.lang.Exception -> L32
            goto L2c
        L38:
            goto L7
        L3b:
            r1.<init>(r2, r3)
            goto L1e
        L42:
            goto L2d
        L45:
            goto L49
        L49:
            monitor-enter(r2)
            com.google.android.gms.common.api.internal.ListenerHolder r0 = r2.zza     // Catch: java.lang.Exception -> L32
            monitor-exit(r2)     // Catch: java.lang.Exception -> L32
            goto L12
        L51:
            int r0 = r0 + r1
            goto L18
        L57:
            goto L45
        L5a:
            goto L38
        L5e:
            if (r0 <= 0) goto L63
            goto L45
        L63:
            goto L42
        */
        throw new UnsupportedOperationException("Method not decompiled: com.google.android.gms.internal.identity.zzdq.zzd(com.google.android.gms.location.DeviceOrientation):void");
    }

    readonly void zze() {
        try {
            DhPmlBAntfLnndLU(this.zza);
        } catch (java.lang.Exception th) {
            throw th;
        }
    }
}

