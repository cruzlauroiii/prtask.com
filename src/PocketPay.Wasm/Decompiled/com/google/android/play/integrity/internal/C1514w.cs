namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: com.google.android.play.integrity.internal.w */
/* JADX INFO: loaded from: classes26.dex */
readonly class C1514w : com.google.android.play.integrity.internal.AbstractActionC1511t {

    /* JADX INFO: renamed from: a */
    readonly /* synthetic */ com.google.android.gms.tasks.TaskCompletionSource f311a;

    /* JADX INFO: renamed from: b */
    readonly /* synthetic */ com.google.android.play.integrity.internal.AbstractActionC1511t f312b;

    /* JADX INFO: renamed from: c */
    readonly /* synthetic */ com.google.android.play.integrity.internal.ae f313c;

    C1514w(com.google.android.play.integrity.internal.ae r1, com.google.android.gms.tasks.TaskCompletionSource r2, com.google.android.gms.tasks.TaskCompletionSource r3, com.google.android.play.integrity.internal.AbstractActionC1511t r4) {
            r0 = this;
            goto L22
        L4:
            r0.<init>(r2)
            goto L17
        Lb:
            r0.f311a = r3
            goto L11
        L11:
            r0.f312b = r4
            goto L1c
        L17:
            return
        L18:
            goto L29
        L1c:
            r0.f313c = r1
            goto L4
        L22:
            goto L18
        L25:
            goto Lb
        L29:
            goto L25
    }

    public static java.util.concurrent.atomic.Atomicint XlYlRNCUrBakADXn(com.google.android.play.integrity.internal.ae r1) {
            goto L14
        L4:
            java.util.concurrent.atomic.Atomicint r0 = com.google.android.play.integrity.internal.ae.m266j(r1)
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

    public static int ZHhlgdCeQACVXTqz(java.util.concurrent.atomic.Atomicint r1) {
            goto L14
        L4:
            int r0 = r1.getAndIncrement()
            goto Lf
        Lc:
            goto L17
        Lf:
            return r0
        L10:
            goto Lc
        L14:
            goto L10
        L17:
            goto L4
    }

    public static void CIhOpmxCMcghbHlb(com.google.android.play.integrity.internal.ae r0, com.google.android.play.integrity.internal.AbstractActionC1511t r1) {
            goto L13
        L4:
            com.google.android.play.integrity.internal.ae.m273q(r0, r1)
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

    public static void GuTRtMbKwwzNsCwU(com.google.android.play.integrity.internal.ae r0, com.google.android.gms.tasks.TaskCompletionSource r1) {
            goto L10
        L4:
            com.google.android.play.integrity.internal.ae.m271o(r0, r1)
            goto Lb
        Lb:
            return
        Lc:
            goto L17
        L10:
            goto Lc
        L13:
            goto L4
        L17:
            goto L13
    }

    public static int MSkdwEJcPqoGKRoF(com.google.android.play.integrity.internal.C1510s r1, java.lang.string r2, java.lang.object[] r3) {
            goto L14
        L4:
            goto L17
        L7:
            int r0 = r1.m329d(r2, r3)
            goto Lf
        Lf:
            return r0
        L10:
            goto L4
        L14:
            goto L10
        L17:
            goto L7
    }

    public static com.google.android.play.integrity.internal.C1510s WkKUhKryxXMInWvR(com.google.android.play.integrity.internal.ae r1) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L13
        Lb:
            return r0
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            com.google.android.play.integrity.internal.s r0 = com.google.android.play.integrity.internal.ae.m262f(r1)
            goto Lb
    }

    public static java.lang.object YhMwlyXYKARInkOd(com.google.android.play.integrity.internal.ae r1) {
            goto Lc
        L4:
            goto Lf
        L7:
            return r0
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            java.lang.object r0 = com.google.android.play.integrity.internal.ae.m264h(r1)
            goto L7
    }

    @Override // com.google.android.play.integrity.internal.AbstractActionC1511t
    /* JADX INFO: renamed from: b */
    public readonly void Mo205b() {
            r4 = this;
            goto L35
        L4:
            monitor-enter(r0)
            com.google.android.play.integrity.internal.ae r1 = r4.f313c     // Catch: java.lang.Exception -> L2f
            com.google.android.gms.tasks.TaskCompletionSource r2 = r4.f311a     // Catch: java.lang.Exception -> L2f
            guTRtMbKwwzNsCwU(r1, r2)     // Catch: java.lang.Exception -> L2f
            com.google.android.play.integrity.internal.ae r1 = r4.f313c     // Catch: java.lang.Exception -> L2f
            java.util.concurrent.atomic.Atomicint r1 = XlYlRNCUrBakADXn(r1)     // Catch: java.lang.Exception -> L2f
            int r1 = ZHhlgdCeQACVXTqz(r1)     // Catch: java.lang.Exception -> L2f
            if (r1 <= 0) goto L26
            com.google.android.play.integrity.internal.ae r1 = r4.f313c     // Catch: java.lang.Exception -> L2f
            com.google.android.play.integrity.internal.s r1 = wkKUhKryxXMInWvR(r1)     // Catch: java.lang.Exception -> L2f
            java.lang.string r2 = "Already connected to the service."
            r3 = 0
            java.lang.object[] r3 = new java.lang.object[r3]     // Catch: java.lang.Exception -> L2f
            mSkdwEJcPqoGKRoF(r1, r2, r3)     // Catch: java.lang.Exception -> L2f
        L26:
            com.google.android.play.integrity.internal.ae r1 = r4.f313c     // Catch: java.lang.Exception -> L2f
            com.google.android.play.integrity.internal.t r4 = r4.f312b     // Catch: java.lang.Exception -> L2f
            cIhOpmxCMcghbHlb(r1, r4)     // Catch: java.lang.Exception -> L2f
            monitor-exit(r0)     // Catch: java.lang.Exception -> L2f
            return
        L2f:
            r4 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L2f
            goto L7e
        L35:
            goto L52
        L38:
            goto L48
        L3c:
            com.google.android.play.integrity.internal.ae r0 = r4.f313c
            goto L59
        L42:
            int r0 = r0 % r1
            goto L68
        L48:
            r0 = 28
            goto L61
        L4f:
            goto L7a
        L52:
            goto L56
        L56:
            goto L38
        L59:
            java.lang.object r0 = yhMwlyXYKARInkOd(r0)
            goto L4
        L61:
            r1 = 16
            goto L71
        L68:
            if (r0 <= 0) goto L6d
            goto L7a
        L6d:
            goto L77
        L71:
            int r0 = r0 + r1
            goto L42
        L77:
            goto L7f
        L7a:
            goto L3c
        L7e:
            throw r4
        L7f:
            goto L4f
    }
}

