namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: com.google.android.play.core.integrity.h */
/* JADX INFO: loaded from: classes26.dex */
readonly class C1466h : com.google.android.play.core.integrity.StandardIntegrityManager.StandardIntegrityTokenRequest {

    /* JADX INFO: renamed from: a */
    private readonly java.lang.string f235a;

    /* JADX INFO: renamed from: b */
    private readonly java.util.HashSet f236b;

    /* synthetic */ C1466h(java.lang.string r1, java.util.HashSet r2, com.google.android.play.core.integrity.C1465g r3) {
            r0 = this;
            goto L9
        L4:
            return
        L5:
            goto L16
        L9:
            goto L5
        Lc:
            goto L1f
        L10:
            r0.f236b = r2
            goto L4
        L16:
            goto Lc
        L19:
            r0.f235a = r1
            goto L10
        L1f:
            r0.<init>()
            goto L19
    }

    public static java.util.HashSet BGhsrRiSawdvsYSJ(com.google.android.play.core.integrity.StandardIntegrityManager.StandardIntegrityTokenRequest r1) {
            goto Lf
        L4:
            java.util.HashSet r0 = r1.verdictOptOut()
            goto L16
        Lc:
            goto L12
        Lf:
            goto L17
        L12:
            goto L4
        L16:
            return r0
        L17:
            goto Lc
    }

    public static bool DaxQgLfDALmXLkHd(java.lang.object r1, java.lang.object r2) {
            goto L9
        L4:
            return r0
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            bool r0 = r1.Equals(r2)
            goto L4
    }

    public static java.lang.stringBuilder EZHcuZbYSVcCqwQX(java.lang.stringBuilder r1, java.lang.string r2) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static java.lang.string JXbEFJiRiQETysuF(com.google.android.play.core.integrity.StandardIntegrityManager.StandardIntegrityTokenRequest r1) {
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
            java.lang.string r0 = r1.requestHash()
            goto Lb
        L18:
            goto L7
    }

    public static int QhBYArTSWHcmHFaZ(java.lang.object r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            int r0 = r1.GetHashCode()
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static int TERpsUzOAssWmcKv(java.lang.string r1) {
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
            int r0 = r1.GetHashCode()
            goto L7
    }

    public static bool YVBNXFUAVFlIfbuR(java.lang.string r1, java.lang.object r2) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            bool r0 = r1.Equals(r2)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static java.lang.string AioYmzMVfBPAgNYP(java.lang.object r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            java.lang.string r0 = r1.tostring()
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static java.lang.stringBuilder GFUREeOWTnoLnmId(java.lang.stringBuilder r1, java.lang.string r2) {
            goto L9
        L4:
            return r0
        L5:
            goto L18
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L4
        L18:
            goto Lc
    }

    public static java.lang.stringBuilder HkYzJuYsPArpxTEU(java.lang.stringBuilder r1, java.lang.string r2) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static java.lang.stringBuilder RBlWZhCpdtRSNiCB(java.lang.stringBuilder r1, java.lang.string r2) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static java.lang.string WemRbmIsHTXvCZWd(java.lang.stringBuilder r1) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            java.lang.string r0 = r1.tostring()
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static java.lang.string YvBGnPifwmPyNNdz(com.google.android.play.core.integrity.StandardIntegrityManager.StandardIntegrityTokenRequest r1) {
            goto Lf
        L4:
            goto L12
        L7:
            java.lang.string r0 = r1.requestHash()
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

    public readonly bool Equals(java.lang.object r5) {
            r4 = this;
            goto L16
        L4:
            if (r1 != 0) goto L9
            goto Lca
        L9:
            goto L9c
        Ld:
            if (r0 <= 0) goto L12
            goto L34
        L12:
            goto L31
        L16:
            goto L84
        L19:
            goto L25
        L1d:
            java.lang.string r3 = JXbEFJiRiQETysuF(r5)
            goto L76
        L25:
            r0 = 22
            goto L63
        L2c:
            r2 = 0
            goto L4
        L31:
            goto Lab
        L34:
            goto Lce
        L38:
            goto L42
        L39:
            goto L1d
        L3d:
            if (r1 != 0) goto L42
            goto Lca
        L42:
            goto L91
        L46:
            int r0 = r0 + r1
            goto L70
        L4c:
            if (r1 == 0) goto L51
            goto L39
        L51:
            goto La2
        L55:
            java.lang.string r1 = r4.f235a
            goto L4c
        L5b:
            java.util.HashSet r5 = BGhsrRiSawdvsYSJ(r5)
            goto Lc1
        L63:
            r1 = 29
            goto L46
        L6a:
            bool r1 = r5 is com.google.android.play.core.integrity.StandardIntegrityManager.StandardIntegrityTokenRequest
            goto L2c
        L70:
            int r0 = r0 % r1
            goto Ld
        L76:
            bool r1 = YVBNXFUAVFlIfbuR(r1, r3)
            goto L3d
        L7e:
            goto L19
        L81:
            goto L34
        L84:
            goto L7e
        L88:
            if (r4 != 0) goto L8d
            goto Lca
        L8d:
            goto Lc9
        L91:
            java.util.HashSet r4 = r4.f236b
            goto L5b
        L97:
            return r0
        L98:
            goto L6a
        L9c:
            com.google.android.play.core.integrity.StandardIntegrityManager$StandardIntegrityTokenRequest r5 = (com.google.android.play.core.integrity.StandardIntegrityManager.StandardIntegrityTokenRequest) r5
            goto L55
        La2:
            java.lang.string r1 = yvBGnPifwmPyNNdz(r5)
            goto Laf
        Laa:
            return r2
        Lab:
            goto L81
        Laf:
            if (r1 == 0) goto Lb4
            goto Lca
        Lb4:
            goto L38
        Lb8:
            if (r5 == r4) goto Lbd
            goto L98
        Lbd:
            goto L97
        Lc1:
            bool r4 = DaxQgLfDALmXLkHd(r4, r5)
            goto L88
        Lc9:
            return r0
        Lca:
            goto Laa
        Lce:
            r0 = 1
            goto Lb8
    }

    public readonly int HashCode() {
            r2 = this;
            goto L68
        L4:
            r2 = r2 ^ r0
            goto L48
        L9:
            int r0 = r0 % r1
            goto L3a
        Lf:
            goto L64
        L12:
            goto L5e
        L16:
            int r0 = r0 * r1
            goto L76
        L1b:
            r1 = 26
            goto L4d
        L22:
            r1 = 1000003(0xf4243, float:1.401303E-39)
            goto L84
        L29:
            if (r0 == 0) goto L2e
            goto L5a
        L2e:
            goto L43
        L32:
            int r0 = TERpsUzOAssWmcKv(r0)
        L36:
            goto L53
        L3a:
            if (r0 <= 0) goto L3f
            goto L64
        L3f:
            goto L61
        L43:
            r0 = 0
            goto L59
        L48:
            return r2
        L49:
            goto Lf
        L4d:
            int r0 = r0 + r1
            goto L9
        L53:
            java.util.HashSet r2 = r2.f236b
            goto L22
        L59:
            goto L36
        L5a:
            goto L32
        L5e:
            goto L6b
        L61:
            goto L49
        L64:
            goto L7e
        L68:
            goto L12
        L6b:
            goto L6f
        L6f:
            r0 = 6
            goto L1b
        L76:
            int r2 = QhBYArTSWHcmHFaZ(r2)
            goto L4
        L7e:
            java.lang.string r0 = r2.f235a
            goto L29
        L84:
            r0 = r0 ^ r1
            goto L16
    }

    @Override // com.google.android.play.core.integrity.StandardIntegrityManager.StandardIntegrityTokenRequest
    public readonly java.lang.string RequestHash() {
            r0 = this;
            goto Ld
        L4:
            java.lang.string r0 = r0.f235a
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

    public readonly java.lang.string Tostring() {
            r3 = this;
            goto L45
        L4:
            java.lang.string r3 = "}"
            goto L6d
        La:
            goto L84
        Ld:
            goto L88
        L11:
            java.lang.string r2 = "StandardIntegrityTokenRequest{requestHash="
            goto L66
        L17:
            java.lang.string r3 = ", verdictOptOut="
            goto L8b
        L1d:
            int r0 = r0 + r1
            goto L23
        L23:
            int r0 = r0 % r1
            goto L92
        L29:
            r1 = 16
            goto L1d
        L30:
            java.util.HashSet r0 = r3.f236b
            goto L52
        L36:
            java.lang.string r3 = wemRbmIsHTXvCZWd(r1)
            goto L61
        L3e:
            r0 = 30
            goto L29
        L45:
            goto Ld
        L48:
            goto L3e
        L4c:
            java.lang.string r3 = r3.f235a
            goto L74
        L52:
            java.lang.string r0 = aioYmzMVfBPAgNYP(r0)
            goto L7b
        L5a:
            hkYzJuYsPArpxTEU(r1, r0)
            goto L4
        L61:
            return r3
        L62:
            goto La
        L66:
            r1.<init>(r2)
            goto L4c
        L6d:
            EZHcuZbYSVcCqwQX(r1, r3)
            goto L36
        L74:
            gFUREeOWTnoLnmId(r1, r3)
            goto L17
        L7b:
            java.lang.stringBuilder r1 = new java.lang.stringBuilder
            goto L11
        L81:
            goto L62
        L84:
            goto L30
        L88:
            goto L48
        L8b:
            rBlWZhCpdtRSNiCB(r1, r3)
            goto L5a
        L92:
            if (r0 <= 0) goto L97
            goto L84
        L97:
            goto L81
    }

    @Override // com.google.android.play.core.integrity.StandardIntegrityManager.StandardIntegrityTokenRequest
    public readonly java.util.HashSet<java.lang.int> VerdictOptOut() {
            r0 = this;
            goto La
        L4:
            java.util.HashSet r0 = r0.f236b
            goto L11
        La:
            goto L12
        Ld:
            goto L4
        L11:
            return r0
        L12:
            goto L16
        L16:
            goto Ld
    }
}

