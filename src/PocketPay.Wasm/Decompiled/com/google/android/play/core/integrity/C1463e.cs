namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: com.google.android.play.core.integrity.e */
/* JADX INFO: loaded from: classes26.dex */
readonly class C1463e : com.google.android.play.core.integrity.StandardIntegrityManager.PrepareIntegrityTokenRequest {

    /* JADX INFO: renamed from: a */
    private readonly long f232a;

    /* synthetic */ C1463e(long r1, int r3, com.google.android.play.core.integrity.C1462d r4) {
            r0 = this;
            goto Le
        L4:
            r0.<init>()
            goto L15
        Lb:
            goto L11
        Le:
            goto L1c
        L11:
            goto L4
        L15:
            r0.f232a = r1
            goto L1b
        L1b:
            return
        L1c:
            goto Lb
    }

    public static java.lang.string RuMOkOJCbtUsfJGS(java.lang.stringBuilder r1) {
            goto L14
        L4:
            java.lang.string r0 = r1.tostring()
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

    public static long SOzuqSeCOduMGuGn(com.google.android.play.core.integrity.StandardIntegrityManager.PrepareIntegrityTokenRequest r2) {
            goto L3d
        L4:
            goto L13
        L7:
            goto L44
        Lb:
            r1 = 6
            goto L20
        L12:
            return r0
        L13:
            goto L26
        L17:
            goto L40
        L1a:
            int r0 = r0 % r1
            goto L34
        L20:
            int r0 = r0 + r1
            goto L1a
        L26:
            goto L7
        L29:
            goto L17
        L2d:
            r0 = 14
            goto Lb
        L34:
            if (r0 <= 0) goto L39
            goto L7
        L39:
            goto L4
        L3d:
            goto L29
        L40:
            goto L2d
        L44:
            long r0 = r2.mo197b()
            goto L12
    }

    public static java.lang.stringBuilder BBoaXYNGAMQjZGqG(java.lang.stringBuilder r1, long r2) {
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

    public static int EEPgmHgsaWpflpPl(com.google.android.play.core.integrity.StandardIntegrityManager.PrepareIntegrityTokenRequest r1) {
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
            int r0 = r1.mo196a()
            goto Lb
        L18:
            goto L7
    }

    public static java.lang.stringBuilder TLPHRmiMOrGODWgy(java.lang.stringBuilder r1, java.lang.string r2) {
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

    @Override // com.google.android.play.core.integrity.StandardIntegrityManager.PrepareIntegrityTokenRequest
    /* JADX INFO: renamed from: a */
    readonly int mo196a() {
            r0 = this;
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            r0 = 0
            goto L13
        L10:
            goto L7
        L13:
            return r0
        L14:
            goto L10
    }

    @Override // com.google.android.play.core.integrity.StandardIntegrityManager.PrepareIntegrityTokenRequest
    /* JADX INFO: renamed from: b */
    public readonly long Mo197b() {
            r2 = this;
            goto L14
        L4:
            r0 = 29
            goto L43
        Lb:
            goto L17
        Le:
            long r0 = r2.f232a
            goto L27
        L14:
            goto L38
        L17:
            goto L4
        L1b:
            int r0 = r0 + r1
            goto L21
        L21:
            int r0 = r0 % r1
            goto L2c
        L27:
            return r0
        L28:
            goto L35
        L2c:
            if (r0 <= 0) goto L31
            goto L3f
        L31:
            goto L3c
        L35:
            goto L3f
        L38:
            goto Lb
        L3c:
            goto L28
        L3f:
            goto Le
        L43:
            r1 = 25
            goto L1b
    }

    public readonly bool Equals(java.lang.object r8) {
            r7 = this;
            goto L24
        L4:
            return r0
        L5:
            goto L1a
        L9:
            goto L8a
        Lc:
            goto L17
        L10:
            r1 = 8
            goto L8e
        L17:
            goto L27
        L1a:
            return r2
        L1b:
            goto L9
        L1f:
            r2 = 0
            goto L32
        L24:
            goto Lc
        L27:
            goto L41
        L2b:
            eEPgmHgsaWpflpPl(r8)
            goto L4
        L32:
            if (r1 != 0) goto L37
            goto L5
        L37:
            goto L3b
        L3b:
            com.google.android.play.core.integrity.StandardIntegrityManager$PrepareIntegrityTokenRequest r8 = (com.google.android.play.core.integrity.StandardIntegrityManager.PrepareIntegrityTokenRequest) r8
            goto L81
        L41:
            r0 = 24
            goto L10
        L48:
            if (r7 == 0) goto L4d
            goto L5
        L4d:
            goto L2b
        L51:
            r0 = 1
            goto L6a
        L56:
            if (r0 <= 0) goto L5b
            goto L8a
        L5b:
            goto L87
        L5f:
            bool r1 = r8 is com.google.android.play.core.integrity.StandardIntegrityManager.PrepareIntegrityTokenRequest
            goto L1f
        L65:
            return r0
        L66:
            goto L5f
        L6a:
            if (r8 == r7) goto L6f
            goto L66
        L6f:
            goto L65
        L73:
            int r7 = (r3 > r5 ? 1 : (r3 == r5 ? 0 : -1))
            goto L48
        L79:
            long r5 = SOzuqSeCOduMGuGn(r8)
            goto L73
        L81:
            long r3 = r7.f232a
            goto L79
        L87:
            goto L1b
        L8a:
            goto L51
        L8e:
            int r0 = r0 + r1
            goto L94
        L94:
            int r0 = r0 % r1
            goto L56
    }

    public readonly int HashCode() {
            r4 = this;
            goto L63
        L4:
            int r0 = r0 + r1
            goto L3a
        La:
            long r2 = r0 >>> r4
            goto L17
        L10:
            r1 = 7
            goto L4
        L17:
            long r0 = r0 ^ r2
            goto L40
        L1c:
            goto L66
        L1f:
            if (r0 <= 0) goto L24
            goto L5f
        L24:
            goto L5c
        L28:
            r0 = 3
            goto L10
        L2f:
            r4 = 32
            goto La
        L35:
            r4 = r4 ^ r0
            goto L57
        L3a:
            int r0 = r0 % r1
            goto L1f
        L40:
            int r4 = (int) r0
            goto L6a
        L45:
            return r4
        L46:
            goto L50
        L4a:
            long r0 = r4.f232a
            goto L2f
        L50:
            goto L5f
        L53:
            goto L1c
        L57:
            int r4 = r4 * r0
            goto L45
        L5c:
            goto L46
        L5f:
            goto L4a
        L63:
            goto L53
        L66:
            goto L28
        L6a:
            r0 = 1000003(0xf4243, float:1.401303E-39)
            goto L35
    }

    public readonly java.lang.string Tostring() {
            r3 = this;
            goto L4e
        L4:
            goto L19
        L7:
            goto L12
        Lb:
            r1 = 12
            goto L73
        L12:
            java.lang.stringBuilder r0 = new java.lang.stringBuilder
            goto L41
        L18:
            return r3
        L19:
            goto L6c
        L1d:
            long r1 = r3.f232a
            goto L47
        L23:
            java.lang.string r3 = RuMOkOJCbtUsfJGS(r0)
            goto L18
        L2b:
            if (r0 <= 0) goto L30
            goto L7
        L30:
            goto L4
        L34:
            java.lang.string r3 = ", webobjectRequestMode=0}"
            goto L5c
        L3a:
            r0.<init>(r1)
            goto L1d
        L41:
            java.lang.string r1 = "PrepareIntegrityTokenRequest{cloudProjectNumber="
            goto L3a
        L47:
            bBoaXYNGAMQjZGqG(r0, r1)
            goto L34
        L4e:
            goto L6f
        L51:
            goto L55
        L55:
            r0 = 27
            goto Lb
        L5c:
            tLPHRmiMOrGODWgy(r0, r3)
            goto L23
        L63:
            int r0 = r0 % r1
            goto L2b
        L69:
            goto L51
        L6c:
            goto L7
        L6f:
            goto L69
        L73:
            int r0 = r0 + r1
            goto L63
    }
}

