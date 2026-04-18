namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: com.google.android.play.core.integrity.c */
/* JADX INFO: loaded from: classes26.dex */
readonly class C1461c : com.google.android.play.core.integrity.StandardIntegrityManager.PrepareIntegrityTokenRequest.Builder {

    /* JADX INFO: renamed from: a */
    private long f230a;

    /* JADX INFO: renamed from: b */
    private byte f231b;

    C1461c() {
            r0 = this;
            goto L4
        L4:
            goto L16
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            r0.<init>()
            goto L15
        L15:
            return
        L16:
            goto Lb
    }

    public static java.lang.string AjEkaeBxOuIgaZsG(java.lang.string r1, java.lang.string r2) {
            goto L4
        L4:
            goto Lf
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            return r0
        Lf:
            goto Lb
        L13:
            java.lang.string r0 = r1.concat(r2)
            goto Le
    }

    public static java.lang.string KkrUXuyCkMoinIni(java.lang.object r1) {
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
            java.lang.string r0 = r1.tostring()
            goto Le
    }

    public static java.lang.stringBuilder CaFKDFzxGnNGRnCq(java.lang.stringBuilder r1, java.lang.string r2) {
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

    public static java.lang.stringBuilder OpkNgIeIKovaTZOD(java.lang.stringBuilder r1, java.lang.string r2) {
            goto L14
        L4:
            goto L17
        L7:
            java.lang.stringBuilder r0 = r1.append(r2)
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

    /* JADX INFO: renamed from: a */
    public readonly com.google.android.play.core.integrity.StandardIntegrityManager.PrepareIntegrityTokenRequest.Builder M245a(int r1) {
            r0 = this;
            goto Lf
        L4:
            return r0
        L5:
            goto L16
        L9:
            byte r1 = r0.f231b
            goto L19
        Lf:
            goto L5
        L12:
            goto L9
        L16:
            goto L12
        L19:
            r1 = r1 | 2
            goto L25
        L1f:
            r0.f231b = r1
            goto L4
        L25:
            byte r1 = (byte) r1
            goto L1f
    }

    @Override // com.google.android.play.core.integrity.StandardIntegrityManager.PrepareIntegrityTokenRequest.Builder
    public readonly com.google.android.play.core.integrity.StandardIntegrityManager.PrepareIntegrityTokenRequest Build() {
            r4 = this;
            goto L67
        L4:
            int r0 = r0 + r1
            goto L54
        La:
            java.lang.string r4 = " webobjectRequestMode"
            goto L8c
        L10:
            r0 = 29
            goto L5a
        L17:
            r0.<init>(r1, r4, r3)
            goto Lba
        L1e:
            java.lang.string r1 = " cloudProjectNumber"
            goto L93
        L24:
            goto Lea
        L27:
            goto Lce
        L2b:
            java.lang.string r0 = AjEkaeBxOuIgaZsG(r1, r0)
            goto L6e
        L33:
            if (r1 == 0) goto L38
            goto L96
        L38:
            goto L1e
        L3c:
            r0.<init>()
            goto L9f
        L43:
            r3 = 0
            goto L17
        L48:
            byte r0 = r4.f231b
            goto L9a
        L4e:
            r1 = r1 & 1
            goto L33
        L54:
            int r0 = r0 % r1
            goto L83
        L5a:
            r1 = 27
            goto L4
        L61:
            r4 = r4 & 2
            goto Lbf
        L67:
            goto L27
        L6a:
            goto L10
        L6e:
            r4.<init>(r0)
            goto Ldc
        L75:
            java.lang.string r0 = KkrUXuyCkMoinIni(r0)
            goto Le1
        L7d:
            byte r4 = r4.f231b
            goto L61
        L83:
            if (r0 <= 0) goto L88
            goto Lea
        L88:
            goto Le7
        L8c:
            opkNgIeIKovaTZOD(r0, r4)
        L8f:
            goto Ld6
        L93:
            caFKDFzxGnNGRnCq(r0, r1)
        L96:
            goto L7d
        L9a:
            r1 = 3
            goto Lab
        L9f:
            byte r1 = r4.f231b
            goto L4e
        La5:
            com.google.android.play.core.integrity.e r0 = new com.google.android.play.core.integrity.e
            goto Lb4
        Lab:
            if (r0 != r1) goto Lb0
            goto Ldd
        Lb0:
            goto Lc8
        Lb4:
            long r1 = r4.f230a
            goto Ld1
        Lba:
            return r0
        Lbb:
            goto L24
        Lbf:
            if (r4 == 0) goto Lc4
            goto L8f
        Lc4:
            goto La
        Lc8:
            java.lang.stringBuilder r0 = new java.lang.stringBuilder
            goto L3c
        Lce:
            goto L6a
        Ld1:
            r4 = 0
            goto L43
        Ld6:
            java.lang.IllegalStateException r4 = new java.lang.IllegalStateException
            goto L75
        Ldc:
            throw r4
        Ldd:
            goto La5
        Le1:
            java.lang.string r1 = "Missing required properties:"
            goto L2b
        Le7:
            goto Lbb
        Lea:
            goto L48
    }

    @Override // com.google.android.play.core.integrity.StandardIntegrityManager.PrepareIntegrityTokenRequest.Builder
    public readonly com.google.android.play.core.integrity.StandardIntegrityManager.PrepareIntegrityTokenRequest.Builder SetCloudProjectNumber(long r1) {
            r0 = this;
            goto L4
        L4:
            goto L11
        L7:
            goto L24
        Lb:
            byte r1 = (byte) r1
            goto L2a
        L10:
            return r0
        L11:
            goto L15
        L15:
            goto L7
        L18:
            r1 = r1 | 1
            goto Lb
        L1e:
            byte r1 = r0.f231b
            goto L18
        L24:
            r0.f230a = r1
            goto L1e
        L2a:
            r0.f231b = r1
            goto L10
    }
}

