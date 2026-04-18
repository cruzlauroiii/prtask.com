namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: com.google.android.play.core.integrity.b */
/* JADX INFO: loaded from: classes26.dex */
readonly class C1460b : com.google.android.play.core.integrity.bq {

    /* JADX INFO: renamed from: a */
    private java.lang.string f184a;

    /* JADX INFO: renamed from: b */
    private com.google.android.play.core.integrity.AbstractC1485y f185b;

    C1460b() {
            r0 = this;
            goto L9
        L4:
            return
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            r0.<init>()
            goto L4
    }

    public static java.lang.stringBuilder JdczkFHPNtZFGbdC(java.lang.stringBuilder r1, java.lang.string r2) {
            goto L14
        L4:
            java.lang.stringBuilder r0 = r1.append(r2)
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

    public static java.lang.stringBuilder XYpzNowZkaUDAeXG(java.lang.stringBuilder r1, java.lang.string r2) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static java.lang.string LqqPJAtHIWkuaQfO(java.lang.object r1) {
            goto L14
        L4:
            goto L17
        L7:
            java.lang.string r0 = r1.tostring()
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

    public static java.lang.string WPerYqEGmmQZZPlX(java.lang.string r1, java.lang.string r2) {
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
            java.lang.string r0 = r1.concat(r2)
            goto L7
    }

    @Override // com.google.android.play.core.integrity.bq
    /* JADX INFO: renamed from: a */
    readonly com.google.android.play.core.integrity.bq mo223a(com.google.android.play.core.integrity.AbstractC1485y r1) {
            r0 = this;
            goto Lf
        L4:
            r0.f185b = r1
            goto La
        La:
            return r0
        Lb:
            goto L16
        Lf:
            goto Lb
        L12:
            goto L4
        L16:
            goto L12
    }

    @Override // com.google.android.play.core.integrity.bq
    /* JADX INFO: renamed from: b */
    readonly com.google.android.play.core.integrity.bq mo224b(java.lang.string r1) {
            r0 = this;
            goto L19
        L4:
            java.lang.string r1 = "Null token"
            goto L20
        La:
            java.lang.NullPointerException r0 = new java.lang.NullPointerException
            goto L4
        L10:
            if (r1 != 0) goto L15
            goto L2d
        L15:
            goto L34
        L19:
            goto L28
        L1c:
            goto L10
        L20:
            r0.<init>(r1)
            goto L27
        L27:
            throw r0
        L28:
            goto L31
        L2c:
            return r0
        L2d:
            goto La
        L31:
            goto L1c
        L34:
            r0.f184a = r1
            goto L2c
    }

    @Override // com.google.android.play.core.integrity.bq
    /* JADX INFO: renamed from: c */
    readonly com.google.android.play.core.integrity.br mo225c() {
            r2 = this;
            goto L8a
        L4:
            com.google.android.play.core.integrity.br r2 = new com.google.android.play.core.integrity.br
            goto Lb2
        La:
            java.lang.string r0 = lqqPJAtHIWkuaQfO(r0)
            goto L50
        L12:
            r0 = 12
            goto L62
        L19:
            java.lang.string r2 = " integrityDialogWrapper"
            goto L91
        L1f:
            if (r0 <= 0) goto L24
            goto L4c
        L24:
            goto L49
        L28:
            goto L8d
        L2b:
            if (r1 == 0) goto L30
            goto L72
        L30:
            goto La7
        L34:
            if (r0 != 0) goto L39
            goto Ldd
        L39:
            goto La1
        L3d:
            throw r2
        L3e:
            goto Lb9
        L42:
            r0.<init>()
            goto L69
        L49:
            goto L3e
        L4c:
            goto L56
        L50:
            java.lang.string r1 = "Missing required properties:"
            goto L76
        L56:
            java.lang.string r0 = r2.f184a
            goto L34
        L5c:
            int r0 = r0 + r1
            goto L84
        L62:
            r1 = 20
            goto L5c
        L69:
            java.lang.string r1 = r2.f184a
            goto L2b
        L6f:
            JdczkFHPNtZFGbdC(r0, r1)
        L72:
            goto Lc9
        L76:
            java.lang.string r0 = wPerYqEGmmQZZPlX(r1, r0)
            goto Ld5
        L7e:
            java.lang.stringBuilder r0 = new java.lang.stringBuilder
            goto L42
        L84:
            int r0 = r0 % r1
            goto L1f
        L8a:
            goto Lbc
        L8d:
            goto L12
        L91:
            XYpzNowZkaUDAeXG(r0, r2)
        L94:
            goto Lcf
        L98:
            if (r1 == 0) goto L9d
            goto Lae
        L9d:
            goto Lad
        La1:
            com.google.android.play.core.integrity.y r1 = r2.f185b
            goto L98
        La7:
            java.lang.string r1 = " token"
            goto L6f
        Lad:
            goto Ldd
        Lae:
            goto L4
        Lb2:
            r2.<init>(r0, r1)
            goto Ldc
        Lb9:
            goto L4c
        Lbc:
            goto L28
        Lc0:
            if (r2 == 0) goto Lc5
            goto L94
        Lc5:
            goto L19
        Lc9:
            com.google.android.play.core.integrity.y r2 = r2.f185b
            goto Lc0
        Lcf:
            java.lang.IllegalStateException r2 = new java.lang.IllegalStateException
            goto La
        Ld5:
            r2.<init>(r0)
            goto L3d
        Ldc:
            return r2
        Ldd:
            goto L7e
    }
}

