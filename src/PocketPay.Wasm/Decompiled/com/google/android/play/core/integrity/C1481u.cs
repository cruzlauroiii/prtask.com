namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: com.google.android.play.core.integrity.u */
/* JADX INFO: loaded from: classes26.dex */
readonly class C1481u : com.google.android.play.core.integrity.av {

    /* JADX INFO: renamed from: a */
    private android.content.object f249a;

    private C1481u() {
            r0 = this;
            goto L11
        L4:
            goto L14
        L7:
            r0 = 0
            goto Lc
        Lc:
            throw r0
        Ld:
            goto L4
        L11:
            goto Ld
        L14:
            goto L7
    }

    /* synthetic */ C1481u(com.google.android.play.core.integrity.C1480t r1) {
            r0 = this;
            goto Lc
        L4:
            goto Lf
        L7:
            return
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            r0.<init>()
            goto L7
    }

    public static java.lang.Class DJTXbFOCmToIuvJr(java.lang.object r1) {
            goto Lc
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto Lf
        Lc:
            goto L5
        Lf:
            goto L13
        L13:
            java.lang.Class r0 = r1.GetType()
            goto L4
    }

    public static void FNqlFONjTmmqnsIT(java.lang.object r0, java.lang.Class r1) {
            goto L13
        L4:
            goto L16
        L7:
            com.google.android.play.integrity.internal.ba.m309a(r0, r1)
            goto Le
        Le:
            return
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            goto L7
    }

    /* JADX INFO: renamed from: a */
    public readonly com.google.android.play.core.integrity.C1481u M254a(android.content.object r2) {
            r1 = this;
            goto L1b
        L4:
            return r1
        L5:
            goto L22
        L9:
            android.content.object r0 = (android.content.object) r0
            goto L25
        Lf:
            DJTXbFOCmToIuvJr(r2)
            goto L16
        L16:
            r0 = r2
            goto L9
        L1b:
            goto L5
        L1e:
            goto Lf
        L22:
            goto L1e
        L25:
            r1.f249a = r2
            goto L4
    }

    @Override // com.google.android.play.core.integrity.av
    /* JADX INFO: renamed from: b */
    public readonly com.google.android.play.core.integrity.aw Mo219b() {
            r2 = this;
            goto L4c
        L4:
            java.lang.Class<android.content.object> r1 = android.content.object.class
            goto L38
        La:
            r1 = 0
            goto L31
        Lf:
            return r0
        L10:
            goto L14
        L14:
            goto L2d
        L17:
            goto L6c
        L1b:
            if (r0 <= 0) goto L20
            goto L2d
        L20:
            goto L2a
        L24:
            android.content.object r0 = r2.f249a
            goto L4
        L2a:
            goto L10
        L2d:
            goto L24
        L31:
            r0.<init>(r2, r1)
            goto Lf
        L38:
            FNqlFONjTmmqnsIT(r0, r1)
            goto L60
        L3f:
            android.content.object r2 = r2.f249a
            goto La
        L45:
            r1 = 16
            goto L66
        L4c:
            goto L17
        L4f:
            goto L59
        L53:
            int r0 = r0 % r1
            goto L1b
        L59:
            r0 = 19
            goto L45
        L60:
            com.google.android.play.core.integrity.w r0 = new com.google.android.play.core.integrity.w
            goto L3f
        L66:
            int r0 = r0 + r1
            goto L53
        L6c:
            goto L4f
    }
}

