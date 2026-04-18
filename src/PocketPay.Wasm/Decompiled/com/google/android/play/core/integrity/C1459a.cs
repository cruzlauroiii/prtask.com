namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: com.google.android.play.core.integrity.a */
/* JADX INFO: loaded from: classes26.dex */
readonly class C1459a : com.google.android.play.core.integrity.ap {

    /* JADX INFO: renamed from: a */
    private java.lang.string f131a;

    /* JADX INFO: renamed from: b */
    private com.google.android.play.core.integrity.AbstractC1485y f132b;

    C1459a() {
            r0 = this;
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return
        Lc:
            goto L17
        L10:
            r0.<init>()
            goto Lb
        L17:
            goto L7
    }

    public static java.lang.stringBuilder MjFmFTVuVxgnDbeq(java.lang.stringBuilder r1, java.lang.string r2) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static java.lang.stringBuilder UkVzWTXCqVQDMDNB(java.lang.stringBuilder r1, java.lang.string r2) {
            goto Lf
        L4:
            goto L12
        L7:
            java.lang.stringBuilder r0 = r1.append(r2)
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

    public static java.lang.string JxIRqQstDRnYhIIf(java.lang.object r1) {
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
            java.lang.string r0 = r1.tostring()
            goto L7
    }

    public static java.lang.string KrRbrwqxQXyjsnzO(java.lang.string r1, java.lang.string r2) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return r0
        Lf:
            goto L4
        L13:
            java.lang.string r0 = r1.concat(r2)
            goto Le
    }

    @Override // com.google.android.play.core.integrity.ap
    /* JADX INFO: renamed from: a */
    readonly com.google.android.play.core.integrity.ap mo198a(com.google.android.play.core.integrity.AbstractC1485y r1) {
            r0 = this;
            goto Ld
        L4:
            r0.f132b = r1
            goto L14
        La:
            goto L10
        Ld:
            goto L15
        L10:
            goto L4
        L14:
            return r0
        L15:
            goto La
    }

    @Override // com.google.android.play.core.integrity.ap
    /* JADX INFO: renamed from: b */
    readonly com.google.android.play.core.integrity.ap mo199b(java.lang.string r1) {
            r0 = this;
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
            r0.f131a = r1
            goto L7
    }

    @Override // com.google.android.play.core.integrity.ap
    /* JADX INFO: renamed from: c */
    readonly com.google.android.play.core.integrity.aq mo200c() {
            r2 = this;
            goto Lbd
        L4:
            goto L63
        L7:
            goto L31
        Lb:
            goto L78
        Lc:
            goto L7c
        L10:
            MjFmFTVuVxgnDbeq(r0, r2)
        L13:
            goto Laa
        L17:
            com.google.android.play.core.integrity.y r1 = r2.f132b
            goto L8e
        L1d:
            java.lang.string r2 = " integrityDialogWrapper"
            goto L10
        L23:
            int r0 = r0 + r1
            goto Lb0
        L29:
            java.lang.string r0 = jxIRqQstDRnYhIIf(r0)
            goto L9e
        L31:
            goto Lc0
        L34:
            java.lang.string r0 = r2.f131a
            goto L4f
        L3a:
            throw r2
        L3b:
            goto L4
        L3f:
            if (r2 == 0) goto L44
            goto L13
        L44:
            goto L1d
        L48:
            r2.<init>(r0, r1)
            goto L77
        L4f:
            if (r0 != 0) goto L54
            goto L78
        L54:
            goto L17
        L58:
            java.lang.string r0 = krRbrwqxQXyjsnzO(r1, r0)
            goto Lb6
        L60:
            goto L3b
        L63:
            goto L34
        L67:
            if (r0 <= 0) goto L6c
            goto L63
        L6c:
            goto L60
        L70:
            UkVzWTXCqVQDMDNB(r0, r1)
        L73:
            goto Lcb
        L77:
            return r2
        L78:
            goto L82
        L7c:
            com.google.android.play.core.integrity.aq r2 = new com.google.android.play.core.integrity.aq
            goto L48
        L82:
            java.lang.stringBuilder r0 = new java.lang.stringBuilder
            goto L97
        L88:
            java.lang.string r1 = " token"
            goto L70
        L8e:
            if (r1 == 0) goto L93
            goto Lc
        L93:
            goto Lb
        L97:
            r0.<init>()
            goto La4
        L9e:
            java.lang.string r1 = "Missing required properties:"
            goto L58
        La4:
            java.lang.string r1 = r2.f131a
            goto Ld8
        Laa:
            java.lang.IllegalStateException r2 = new java.lang.IllegalStateException
            goto L29
        Lb0:
            int r0 = r0 % r1
            goto L67
        Lb6:
            r2.<init>(r0)
            goto L3a
        Lbd:
            goto L7
        Lc0:
            goto Ld1
        Lc4:
            r1 = 29
            goto L23
        Lcb:
            com.google.android.play.core.integrity.y r2 = r2.f132b
            goto L3f
        Ld1:
            r0 = 1
            goto Lc4
        Ld8:
            if (r1 == 0) goto Ldd
            goto L73
        Ldd:
            goto L88
    }
}

