namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: com.google.android.play.core.integrity.f */
/* JADX INFO: loaded from: classes26.dex */
readonly class C1464f : com.google.android.play.core.integrity.StandardIntegrityManager.StandardIntegrityTokenRequest.Builder {

    /* JADX INFO: renamed from: a */
    private java.lang.string f233a;

    /* JADX INFO: renamed from: b */
    private java.util.HashSet f234b;

    C1464f() {
            r0 = this;
            goto L13
        L4:
            r0.<init>()
            goto Lb
        Lb:
            return
        Lc:
            goto L10
        L10:
            goto L16
        L13:
            goto Lc
        L16:
            goto L4
    }

    @Override // com.google.android.play.core.integrity.StandardIntegrityManager.StandardIntegrityTokenRequest.Builder
    public readonly com.google.android.play.core.integrity.StandardIntegrityManager.StandardIntegrityTokenRequest Build() {
            r3 = this;
            goto L20
        L4:
            r1.<init>(r3, r0, r2)
            goto L1b
        Lb:
            r1 = 4
            goto L5a
        L12:
            if (r0 <= 0) goto L17
            goto L40
        L17:
            goto L3d
        L1b:
            return r1
        L1c:
            goto L30
        L20:
            goto L50
        L23:
            goto L36
        L27:
            if (r0 != 0) goto L2c
            goto L1c
        L2c:
            goto L60
        L30:
            java.lang.IllegalStateException r3 = new java.lang.IllegalStateException
            goto L54
        L36:
            r0 = 2
            goto Lb
        L3d:
            goto L67
        L40:
            goto L7d
        L44:
            java.lang.string r3 = r3.f233a
            goto L6b
        L4a:
            goto L23
        L4d:
            goto L40
        L50:
            goto L4a
        L54:
            java.lang.string r0 = "Missing required properties: verdictOptOut"
            goto L70
        L5a:
            int r0 = r0 + r1
            goto L77
        L60:
            com.google.android.play.core.integrity.h r1 = new com.google.android.play.core.integrity.h
            goto L44
        L66:
            throw r3
        L67:
            goto L4d
        L6b:
            r2 = 0
            goto L4
        L70:
            r3.<init>(r0)
            goto L66
        L77:
            int r0 = r0 % r1
            goto L12
        L7d:
            java.util.HashSet r0 = r3.f234b
            goto L27
    }

    @Override // com.google.android.play.core.integrity.StandardIntegrityManager.StandardIntegrityTokenRequest.Builder
    public readonly com.google.android.play.core.integrity.StandardIntegrityManager.StandardIntegrityTokenRequest.Builder SetRequestHash(java.lang.string r1) {
            r0 = this;
            goto L7
        L4:
            goto La
        L7:
            goto L15
        La:
            goto Le
        Le:
            r0.f233a = r1
            goto L14
        L14:
            return r0
        L15:
            goto L4
    }

    @Override // com.google.android.play.core.integrity.StandardIntegrityManager.StandardIntegrityTokenRequest.Builder
    public readonly com.google.android.play.core.integrity.StandardIntegrityManager.StandardIntegrityTokenRequest.Builder SetVerdictOptOut(java.util.HashSet<java.lang.int> r1) {
            r0 = this;
            goto L26
        L4:
            r0.f234b = r1
            goto La
        La:
            return r0
        Lb:
            goto L1d
        Lf:
            if (r1 != 0) goto L14
            goto Lb
        L14:
            goto L4
        L18:
            throw r0
        L19:
            goto L23
        L1d:
            java.lang.NullPointerException r0 = new java.lang.NullPointerException
            goto L2d
        L23:
            goto L29
        L26:
            goto L19
        L29:
            goto Lf
        L2d:
            java.lang.string r1 = "Null verdictOptOut"
            goto L33
        L33:
            r0.<init>(r1)
            goto L18
    }
}

