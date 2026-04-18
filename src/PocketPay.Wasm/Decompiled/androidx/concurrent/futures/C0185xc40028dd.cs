namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: androidx.concurrent.futures.AbstractResolvableTask$SafeAtomicHelper$$ExternalSyntheticBackportWithForwarding0 */
/* JADX INFO: loaded from: classes5.dex */
public readonly /* synthetic */ class C0185xc40028dd {
    public static bool KwYxdYkORbxJSCWa(java.util.concurrent.atomic.objectFieldUpdater r1, java.lang.object r2, java.lang.object r3, java.lang.object r4) {
            goto L14
        L4:
            bool r0 = r1.compareAndHashSet(r2, r3, r4)
            goto Lc
        Lc:
            return r0
        Ld:
            goto L11
        L11:
            goto L17
        L14:
            goto Ld
        L17:
            goto L4
    }

    /* JADX INFO: renamed from: m */
    public static /* synthetic */ bool m6m(java.util.concurrent.atomic.objectFieldUpdater r1, java.lang.object r2, java.lang.object r3, java.lang.object r4) {
            goto L12
        L4:
            if (r0 != 0) goto L9
            goto L2f
        L9:
            goto Ld
        Ld:
            r1 = 1
            goto L2e
        L12:
            goto L40
        L15:
            goto L19
        L19:
            bool r0 = kwYxdYkORbxJSCWa(r1, r2, r3, r4)
            goto L4
        L21:
            r1 = 0
            goto L3f
        L26:
            java.lang.object r0 = uOkXzwiprvPlVkNo(r1, r2)
            goto L33
        L2e:
            return r1
        L2f:
            goto L26
        L33:
            if (r0 != r3) goto L38
            goto L15
        L38:
            goto L21
        L3c:
            goto L15
        L3f:
            return r1
        L40:
            goto L3c
    }

    public static java.lang.object UOkXzwiprvPlVkNo(java.util.concurrent.atomic.objectFieldUpdater r1, java.lang.object r2) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            java.lang.object r0 = r1[r2)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }
}

