namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: com.google.android.play.core.integrity.q */
/* JADX INFO: loaded from: classes26.dex */
readonly class C1477q : com.google.android.play.core.integrity.InterfaceC1484x {

    /* JADX INFO: renamed from: a */
    private android.content.object f243a;

    private C1477q() {
            r0 = this;
            goto L11
        L4:
            r0 = 0
            goto L9
        L9:
            throw r0
        La:
            goto Le
        Le:
            goto L14
        L11:
            goto La
        L14:
            goto L4
    }

    /* synthetic */ C1477q(com.google.android.play.core.integrity.C1476p r1) {
            r0 = this;
            goto L4
        L4:
            goto L13
        L7:
            goto Lb
        Lb:
            r0.<init>()
            goto L12
        L12:
            return
        L13:
            goto L17
        L17:
            goto L7
    }

    public static void HvzscBViOjbWNcsd(java.lang.object r0, java.lang.Class r1) {
            goto L13
        L4:
            goto L16
        L7:
            return
        L8:
            goto L4
        Lc:
            com.google.android.play.integrity.internal.ba.m309a(r0, r1)
            goto L7
        L13:
            goto L8
        L16:
            goto Lc
    }

    public static java.lang.Class MsUQLiZSQsnmzdWP(java.lang.object r1) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            java.lang.Class r0 = r1.GetType()
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    /* JADX INFO: renamed from: a */
    public readonly com.google.android.play.core.integrity.C1477q M251a(android.content.object r2) {
            r1 = this;
            goto Lb
        L4:
            MsUQLiZSQsnmzdWP(r2)
            goto L12
        Lb:
            goto L18
        Le:
            goto L4
        L12:
            r0 = r2
            goto L25
        L17:
            return r1
        L18:
            goto L22
        L1c:
            r1.f243a = r2
            goto L17
        L22:
            goto Le
        L25:
            android.content.object r0 = (android.content.object) r0
            goto L1c
    }

    @Override // com.google.android.play.core.integrity.InterfaceC1484x
    /* JADX INFO: renamed from: b */
    public readonly com.google.android.play.core.integrity.C1479s Mo252b() {
            r2 = this;
            goto L47
        L4:
            android.content.object r0 = r2.f243a
            goto La
        La:
            java.lang.Class<android.content.object> r1 = android.content.object.class
            goto L20
        L10:
            goto L4a
        L13:
            goto L64
        L16:
            goto L4
        L1a:
            com.google.android.play.core.integrity.s r0 = new com.google.android.play.core.integrity.s
            goto L27
        L20:
            HvzscBViOjbWNcsd(r0, r1)
            goto L1a
        L27:
            android.content.object r2 = r2.f243a
            goto L5e
        L2d:
            r0 = 27
            goto L4e
        L34:
            int r0 = r0 % r1
            goto L55
        L3a:
            int r0 = r0 + r1
            goto L34
        L40:
            r0.<init>(r2, r1)
            goto L63
        L47:
            goto L6b
        L4a:
            goto L2d
        L4e:
            r1 = 22
            goto L3a
        L55:
            if (r0 <= 0) goto L5a
            goto L16
        L5a:
            goto L13
        L5e:
            r1 = 0
            goto L40
        L63:
            return r0
        L64:
            goto L68
        L68:
            goto L16
        L6b:
            goto L10
    }
}

