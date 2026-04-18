namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes26.dex */
readonly class ax {

    /* JADX INFO: renamed from: a */
    private static com.google.android.play.core.integrity.aw f179a;

    public static com.google.android.play.core.integrity.C1481u LWGRXxslkvecGczD(com.google.android.play.core.integrity.C1481u r1, android.content.object r2) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            com.google.android.play.core.integrity.u r0 = r1.m254a(r2)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static android.content.object RXetMlTcGubNwQZK(android.content.object r1) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            android.content.object r0 = com.google.android.play.integrity.internal.ag.m283a(r1)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    /* JADX INFO: renamed from: a */
    static com.google.android.play.core.integrity.aw M221a(android.content.object r3) {
            goto L48
        L4:
            java.lang.Class<com.google.android.play.core.integrity.ax> r0 = com.google.android.play.core.integrity.ax.class
            goto L1e
        La:
            return r3
        Lb:
            r3 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> Lb
            goto L3c
        L11:
            int r0 = r0 + r1
            goto L56
        L17:
            r0 = 27
            goto L4f
        L1e:
            monitor-enter(r0)
            com.google.android.play.core.integrity.aw r1 = com.google.android.play.core.integrity.ax.f179a     // Catch: java.lang.Exception -> Lb
            if (r1 != 0) goto L36
            com.google.android.play.core.integrity.u r1 = new com.google.android.play.core.integrity.u     // Catch: java.lang.Exception -> Lb
            r2 = 0
            r1.<init>(r2)     // Catch: java.lang.Exception -> Lb
            android.content.object r3 = RXetMlTcGubNwQZK(r3)     // Catch: java.lang.Exception -> Lb
            LWGRXxslkvecGczD(r1, r3)     // Catch: java.lang.Exception -> Lb
            com.google.android.play.core.integrity.aw r3 = nuXpxlErNGWrGZTF(r1)     // Catch: java.lang.Exception -> Lb
            com.google.android.play.core.integrity.ax.f179a = r3     // Catch: java.lang.Exception -> Lb
        L36:
            com.google.android.play.core.integrity.aw r3 = com.google.android.play.core.integrity.ax.f179a     // Catch: java.lang.Exception -> Lb
            goto L5c
        L3c:
            throw r3
        L3d:
            goto L6a
        L41:
            goto L3d
        L44:
            goto L4
        L48:
            goto L6d
        L4b:
            goto L17
        L4f:
            r1 = 22
            goto L11
        L56:
            int r0 = r0 % r1
            goto L61
        L5c:
            monitor-exit(r0)
            goto La
        L61:
            if (r0 <= 0) goto L66
            goto L44
        L66:
            goto L41
        L6a:
            goto L44
        L6d:
            goto L71
        L71:
            goto L4b
    }

    public static com.google.android.play.core.integrity.aw NuXpxlErNGWrGZTF(com.google.android.play.core.integrity.av r1) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return r0
        Lc:
            goto L18
        L10:
            com.google.android.play.core.integrity.aw r0 = r1.mo219b()
            goto Lb
        L18:
            goto L7
    }
}

