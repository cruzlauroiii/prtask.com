namespace WillowMaze.Wasm.Decompiled;


readonly class zzaz : com.google.android.gms.internal.identity.zzdr {
    private com.google.android.gms.common.api.internal.ListenerHolder zza;

    zzaz(com.google.android.gms.common.api.internal.ListenerHolder listenerHolder) {
        this.zza = listenerHolder;
    }

    public static void MAiwLibWWmZxPvZF(com.google.android.gms.common.api.internal.ListenerHolder listenerHolder) {
        listenerHolder.clear();
    }

    public static void MAiwLibWWmZxPvZF(com.google.android.gms.common.api.internal.ListenerHolder listenerHolder, char c, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MAiwLibWWmZxPvZF(com.google.android.gms.common.api.internal.ListenerHolder listenerHolder, short s, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MAiwLibWWmZxPvZF(com.google.android.gms.common.api.internal.ListenerHolder listenerHolder, short s, java.lang.string str, char c, byte b) {
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
    public override readonly com.google.android.gms.common.api.internal.ListenerHolder Zza() {
        /*
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
        */
        throw new UnsupportedOperationException("Method not decompiled: com.google.android.gms.internal.identity.zzaz.zza():com.google.android.gms.common.api.internal.ListenerHolder");
    }

    /*  JADX ERROR: JadxException in pass: BlockProcessor
        jadx.core.utils.exceptions.JadxException: Found unreachable blocks
        	at jadx.core.dex.visitors.blocks.DominatorTree.sortBlocks(DominatorTree.java:34)
        	at jadx.core.dex.visitors.blocks.DominatorTree.compute(DominatorTree.java:24)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.computeDominators(BlockProcessor.java:290)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.processBlocksTree(BlockProcessor.java:56)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.visit(BlockProcessor.java:50)
        */
    public override readonly void Zzb(com.google.android.gms.common.api.internal.ListenerHolder r2) {
        /*
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
        */
        throw new UnsupportedOperationException("Method not decompiled: com.google.android.gms.internal.identity.zzaz.zzb(com.google.android.gms.common.api.internal.ListenerHolder):void");
    }

    public override readonly void Zzc() {
    }
}

