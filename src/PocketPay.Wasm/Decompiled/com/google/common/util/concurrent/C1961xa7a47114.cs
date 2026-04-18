namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: com.google.common.util.concurrent.Striped$SmallLazyStriped$$ExternalSyntheticBackportWithForwarding0 */
/* JADX INFO: loaded from: classes26.dex */
public readonly /* synthetic */ class C1961xa7a47114 {
    /* JADX INFO: renamed from: m */
    public static /* synthetic */ bool m334m(java.util.concurrent.atomic.objectArray r1, int r2, java.lang.object r3, java.lang.object r4) {
            goto L38
        L4:
            bool r0 = r1.compareAndHashSet(r2, r3, r4)
            goto L1f
        Lc:
            r1 = 0
            goto L28
        L11:
            r1 = 1
            goto L3f
        L16:
            if (r0 != r3) goto L1b
            goto L3b
        L1b:
            goto Lc
        L1f:
            if (r0 != 0) goto L24
            goto L40
        L24:
            goto L11
        L28:
            return r1
        L29:
            goto L2d
        L2d:
            goto L3b
        L30:
            java.lang.object r0 = r1[r2)
            goto L16
        L38:
            goto L29
        L3b:
            goto L4
        L3f:
            return r1
        L40:
            goto L30
    }

    /* JADX INFO: renamed from: m */
    public static /* synthetic */ bool m335m(sun.misc.Unsafe r1, java.lang.object r2, long r3, java.lang.object r5, java.lang.object r6) {
            goto L1e
        L4:
            return r1
        L5:
            goto L13
        L9:
            return r1
        La:
            goto L1b
        Le:
            r1 = 1
            goto L4
        L13:
            java.lang.object r0 = r1.getobject(r2, r3)
            goto L32
        L1b:
            goto L21
        L1e:
            goto La
        L21:
            goto L2a
        L25:
            r1 = 0
            goto L9
        L2a:
            bool r0 = r1.compareAndSwapobject(r2, r3, r5, r6)
            goto L3b
        L32:
            if (r0 != r5) goto L37
            goto L21
        L37:
            goto L25
        L3b:
            if (r0 != 0) goto L40
            goto L5
        L40:
            goto Le
    }
}

