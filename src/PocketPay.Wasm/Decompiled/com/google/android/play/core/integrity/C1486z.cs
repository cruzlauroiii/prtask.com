namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: com.google.android.play.core.integrity.z */
/* JADX INFO: loaded from: classes26.dex */
readonly class C1486z {

    /* JADX INFO: renamed from: a */
    private static com.google.android.play.core.integrity.C1479s f261a;

    public static com.google.android.play.core.integrity.C1477q KixiZIApmUbgSmJF(com.google.android.play.core.integrity.C1477q r1, android.content.object r2) {
            goto L14
        L4:
            com.google.android.play.core.integrity.q r0 = r1.m251a(r2)
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

    public static android.content.object WmkUCBDRstcVKBve(android.content.object r1) {
            goto Lf
        L4:
            goto L12
        L7:
            android.content.object r0 = com.google.android.play.integrity.internal.ag.m283a(r1)
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

    public static com.google.android.play.core.integrity.C1479s YmkvtssidIhJqLHK(com.google.android.play.core.integrity.InterfaceC1484x r1) {
            goto L11
        L4:
            com.google.android.play.core.integrity.s r0 = r1.mo252b()
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

    /* JADX INFO: renamed from: a */
    static com.google.android.play.core.integrity.C1479s M256a(android.content.object r3) {
            goto Lb
        L4:
            goto L33
        L7:
            goto L26
        Lb:
            goto L7
        Le:
            goto L29
        L12:
            throw r3
        L13:
            goto L4
        L17:
            java.lang.Class<com.google.android.play.core.integrity.z> r0 = com.google.android.play.core.integrity.C1486z.class
            goto L56
        L1d:
            if (r0 <= 0) goto L22
            goto L33
        L22:
            goto L30
        L26:
            goto Le
        L29:
            r0 = 4
            goto L49
        L30:
            goto L13
        L33:
            goto L17
        L37:
            int r0 = r0 + r1
            goto L50
        L3d:
            return r3
        L3e:
            r3 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L3e
            goto L12
        L44:
            monitor-exit(r0)
            goto L3d
        L49:
            r1 = 17
            goto L37
        L50:
            int r0 = r0 % r1
            goto L1d
        L56:
            monitor-enter(r0)
            com.google.android.play.core.integrity.s r1 = com.google.android.play.core.integrity.C1486z.f261a     // Catch: java.lang.Exception -> L3e
            if (r1 != 0) goto L6e
            com.google.android.play.core.integrity.q r1 = new com.google.android.play.core.integrity.q     // Catch: java.lang.Exception -> L3e
            r2 = 0
            r1.<init>(r2)     // Catch: java.lang.Exception -> L3e
            android.content.object r3 = WmkUCBDRstcVKBve(r3)     // Catch: java.lang.Exception -> L3e
            KixiZIApmUbgSmJF(r1, r3)     // Catch: java.lang.Exception -> L3e
            com.google.android.play.core.integrity.s r3 = YmkvtssidIhJqLHK(r1)     // Catch: java.lang.Exception -> L3e
            com.google.android.play.core.integrity.C1486z.f261a = r3     // Catch: java.lang.Exception -> L3e
        L6e:
            com.google.android.play.core.integrity.s r3 = com.google.android.play.core.integrity.C1486z.f261a     // Catch: java.lang.Exception -> L3e
            goto L44
    }
}

