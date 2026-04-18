namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes20.dex */
readonly class zaa : com.google.android.gms.common.api.internal.LifecycleCallback {
    private java.util.List zaa;

    private zaa(com.google.android.gms.common.api.internal.Lifecycleobject r2) {
            r1 = this;
            goto L1a
        L4:
            r1.<init>(r2)
            goto L14
        Lb:
            r1.zaa = r2
            goto L2d
        L11:
            goto L1d
        L14:
            java.util.List r2 = new java.util.List
            goto L21
        L1a:
            goto L29
        L1d:
            goto L4
        L21:
            r2.<init>()
            goto Lb
        L28:
            return
        L29:
            goto L11
        L2d:
            com.google.android.gms.common.api.internal.Lifecycleobject r2 = r1.mLifecycleobject
            goto L3a
        L33:
            gkrEAjkFzASdUEpG(r2, r0, r1)
            goto L28
        L3a:
            java.lang.string r0 = "LifecycleObserverOnStop"
            goto L33
    }

    public static java.util.IEnumerator AWamDIkojneaqSqX(java.util.List r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            java.util.IEnumerator r0 = r1.GetEnumerator()
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static bool JCMHCoDDgfTpXaxc(java.util.List r1, java.lang.object r2) {
            goto L11
        L4:
            bool r0 = r1.Add(r2)
            goto Lc
        Lc:
            return r0
        Ld:
            goto L18
        L11:
            goto Ld
        L14:
            goto L4
        L18:
            goto L14
    }

    public static com.google.android.gms.common.api.internal.Lifecycleobject QaNgtcidbcberorb(android.app.object r1) {
            goto L14
        L4:
            goto L17
        L7:
            com.google.android.gms.common.api.internal.Lifecycleobject r0 = getobject(r1)
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

    public static bool YcSENptHNfLWJUwr(java.util.IEnumerator r1) {
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
            bool r0 = r1.MoveNext()
            goto L7
    }

    public static void EmKHNwSlXelBVoxK(com.google.android.gms.common.api.internal.zaa r0, java.lang.Action r1) {
            goto Lb
        L4:
            r0.zac(r1)
            goto L15
        Lb:
            goto L16
        Le:
            goto L4
        L12:
            goto Le
        L15:
            return
        L16:
            goto L12
    }

    public static void GkrEAjkFzASdUEpG(com.google.android.gms.common.api.internal.Lifecycleobject r0, java.lang.string r1, com.google.android.gms.common.api.internal.LifecycleCallback r2) {
            goto L4
        L4:
            goto L16
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            r0.addCallback(r1, r2)
            goto L15
        L15:
            return
        L16:
            goto Lb
    }

    public static void HeluBHkgGtfudkQe(java.lang.Action r0) {
            goto Lc
        L4:
            return
        L5:
            goto L9
        L9:
            goto Lf
        Lc:
            goto L5
        Lf:
            goto L13
        L13:
            r0.run()
            goto L4
    }

    public static java.lang.object IsOujDxvwtwJFDFV(java.util.IEnumerator r1) {
            goto Lc
        L4:
            java.lang.object r0 = r1.Current
            goto L16
        Lc:
            goto L17
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            return r0
        L17:
            goto L13
    }

    public static com.google.android.gms.common.api.internal.LifecycleCallback JuXeOtgbiznKRFzv(com.google.android.gms.common.api.internal.Lifecycleobject r1, java.lang.string r2, java.lang.Class r3) {
            goto Lf
        L4:
            goto L12
        L7:
            com.google.android.gms.common.api.internal.LifecycleCallback r0 = r1.getCallbackOrNull(r2, r3)
            goto L16
        Lf:
            goto L17
        L12:
            goto L7
        L16:
            return r0
        L17:
            goto L4
    }

    static /* bridge */ /* synthetic */ com.google.android.gms.common.api.internal.zaa zaa(android.app.object r3) {
            goto L31
        L4:
            goto L5e
        L7:
            goto L38
        Lb:
            r0 = 19
            goto L56
        L12:
            if (r0 <= 0) goto L17
            goto L7
        L17:
            goto L4
        L1b:
            int r0 = r0 % r1
            goto L12
        L21:
            goto L34
        L24:
            int r0 = r0 + r1
            goto L1b
        L2a:
            goto L7
        L2d:
            goto L21
        L31:
            goto L2d
        L34:
            goto Lb
        L38:
            monitor-enter(r3)
            com.google.android.gms.common.api.internal.Lifecycleobject r0 = QaNgtcidbcberorb(r3)     // Catch: java.lang.Exception -> L50
            java.lang.string r1 = "LifecycleObserverOnStop"
            java.lang.Class<com.google.android.gms.common.api.internal.zaa> r2 = com.google.android.gms.common.api.internal.zaa.class
            com.google.android.gms.common.api.internal.LifecycleCallback r1 = juXeOtgbiznKRFzv(r0, r1, r2)     // Catch: java.lang.Exception -> L50
            com.google.android.gms.common.api.internal.zaa r1 = (com.google.android.gms.common.api.internal.zaa) r1     // Catch: java.lang.Exception -> L50
            if (r1 != 0) goto L4e
            com.google.android.gms.common.api.internal.zaa r1 = new com.google.android.gms.common.api.internal.zaa     // Catch: java.lang.Exception -> L50
            r1.<init>(r0)     // Catch: java.lang.Exception -> L50
        L4e:
            monitor-exit(r3)     // Catch: java.lang.Exception -> L50
            return r1
        L50:
            r0 = move-exception
            monitor-exit(r3)     // Catch: java.lang.Exception -> L50
            goto L5d
        L56:
            r1 = 30
            goto L24
        L5d:
            throw r0
        L5e:
            goto L2a
    }

    static /* bridge */ /* synthetic */ void zab(com.google.android.gms.common.api.internal.zaa r0, java.lang.Action r1) {
            goto L13
        L4:
            return
        L5:
            goto L9
        L9:
            goto L16
        Lc:
            emKHNwSlXelBVoxK(r0, r1)
            goto L4
        L13:
            goto L5
        L16:
            goto Lc
    }

    private readonly void Zac(java.lang.Action r2) {
            r1 = this;
            goto L15
        L4:
            monitor-enter(r1)
            java.util.List r0 = r1.zaa     // Catch: java.lang.Exception -> Lf
            JCMHCoDDgfTpXaxc(r0, r2)     // Catch: java.lang.Exception -> Lf
            goto L1c
        Le:
            return
        Lf:
            r2 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> Lf
            goto L24
        L15:
            goto L25
        L18:
            goto L4
        L1c:
            monitor-exit(r1)
            goto Le
        L21:
            goto L18
        L24:
            throw r2
        L25:
            goto L21
    }

    @Override // com.google.android.gms.common.api.internal.LifecycleCallback
    public readonly void OnStop() {
            r2 = this;
            goto L11
        L4:
            java.lang.Action r0 = (java.lang.Action) r0
            goto La
        La:
            heluBHkgGtfudkQe(r0)
            goto L2f
        L11:
            goto L24
        L14:
            goto L64
        L18:
            if (r0 <= 0) goto L1d
            goto L84
        L1d:
            goto L81
        L21:
            goto L84
        L24:
            goto L34
        L28:
            return
        L29:
            r0 = move-exception
            monitor-exit(r2)     // Catch: java.lang.Exception -> L29
            goto L88
        L2f:
            goto L41
        L30:
            goto L28
        L34:
            goto L14
        L37:
            int r0 = r0 % r1
            goto L18
        L3d:
            java.util.IEnumerator r2 = AWamDIkojneaqSqX(r0)
        L41:
            goto L45
        L45:
            bool r0 = YcSENptHNfLWJUwr(r2)
            goto L53
        L4d:
            int r0 = r0 + r1
            goto L37
        L53:
            if (r0 != 0) goto L58
            goto L30
        L58:
            goto L5c
        L5c:
            java.lang.object r0 = isOujDxvwtwJFDFV(r2)
            goto L4
        L64:
            r0 = 32
            goto L6b
        L6b:
            r1 = 17
            goto L4d
        L72:
            monitor-enter(r2)
            java.util.List r0 = r2.zaa     // Catch: java.lang.Exception -> L29
            java.util.List r1 = new java.util.List     // Catch: java.lang.Exception -> L29
            r1.<init>()     // Catch: java.lang.Exception -> L29
            r2.zaa = r1     // Catch: java.lang.Exception -> L29
            monitor-exit(r2)     // Catch: java.lang.Exception -> L29
            goto L3d
        L81:
            goto L89
        L84:
            goto L72
        L88:
            throw r0
        L89:
            goto L21
    }
}

