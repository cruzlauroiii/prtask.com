namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: com.mastercard.terminalsdk.internal.a */
/* JADX INFO: loaded from: classes2.dex */
public class C2196a : java.io.FilterStream {

    /* JADX INFO: renamed from: a */
    private byte[] f422a;

    /* JADX INFO: renamed from: b */
    private readonly int f423b;

    /* JADX INFO: renamed from: c */
    private byte[] f424c;

    /* JADX INFO: renamed from: d */
    private com.mastercard.terminalsdk.internal.C2200e f425d;

    /* JADX INFO: renamed from: e */
    private byte[] f426e;

    /* JADX INFO: renamed from: f */
    private int f427f;

    /* JADX INFO: renamed from: g */
    private int f428g;

    /* JADX INFO: renamed from: h */
    private int f429h;

    /* JADX INFO: renamed from: i */
    private int[] f430i;

    /* JADX INFO: renamed from: j */
    private int f431j;

    public C2196a(java.io.Stream r4, int[] r5, byte[] r6, int r7, bool r8, int r9) throws java.io.IOException {
            r3 = this;
            goto L96
        L4:
            r0 = 14
            goto L11
        Lb:
            r3.f423b = r4
            goto L90
        L11:
            r1 = 32
            goto Ldc
        L18:
            jJbbFlUnuZJvPRyp(r6, r9, r0, r9, r7)
        L1b:
            goto L58
        L1f:
            byte[] r1 = new byte[r7]
            goto L6a
        L25:
            r6.<init>(r5, r4, r7, r8)
            goto L64
        L2c:
            r7 = 16
            goto L44
        L32:
            byte[] r0 = new byte[r7]
            goto L38
        L38:
            r3.f422a = r0
            goto L1f
        L3e:
            r3.f430i = r2
            goto L4c
        L44:
            int r4 = TrmDCrrtOmlOblav(r4, r7)
            goto Lb
        L4c:
            r3.f431j = r7
            goto L70
        L52:
            r3.f424c = r0
            goto L32
        L58:
            com.mastercard.terminalsdk.internal.e r6 = new com.mastercard.terminalsdk.internal.e
            goto La3
        L5e:
            r3.f427f = r9
            goto La8
        L64:
            r3.f425d = r6
            goto Ld7
        L6a:
            r3.f426e = r1
            goto Lee
        L70:
            r3.f429h = r7
            goto L5e
        L76:
            goto Lbb
        L79:
            goto Le2
        L7d:
            r9 = 0
            goto L18
        L82:
            byte[] r0 = new byte[r7]
            goto L52
        L88:
            int r4 = xPePMttEOZwkgkpu(r7, r4)
            goto L2c
        L90:
            r7 = 8
            goto L82
        L96:
            goto L79
        L99:
            goto L4
        L9d:
            int r0 = r0 % r1
            goto Le5
        La3:
            r7 = 1
            goto L25
        La8:
            if (r9 == r1) goto Lad
            goto L1b
        Lad:
            goto L7d
        Lb1:
            r4 = 2147483647(0x7fffffff, float:NaN)
            goto Ld1
        Lb8:
            goto Ld8
        Lbb:
            goto Lc5
        Lbf:
            int[] r2 = new int[r1]
            goto L3e
        Lc5:
            r3.<init>(r4)
            goto Lb1
        Lcc:
            r4 = 3
            goto L88
        Ld1:
            r3.f428g = r4
            goto Lcc
        Ld7:
            return
        Ld8:
            goto L76
        Ldc:
            int r0 = r0 + r1
            goto L9d
        Le2:
            goto L99
        Le5:
            if (r0 <= 0) goto Lea
            goto Lbb
        Lea:
            goto Lb8
        Lee:
            r1 = 2
            goto Lbf
    }

    public static int ArinhLKQfMeYKlHA(java.io.Stream r1) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            int r0 = r1.read()
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static void GEbaTmAiRLHsbQSd(com.mastercard.terminalsdk.internal.C2196a r0) {
            goto L13
        L4:
            goto L16
        L7:
            r0.m432b()
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

    public static int GdnAvNdmKlWDuYBA(java.io.Stream r1, byte[] r2, int r3, int r4) {
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
            int r0 = r1.read(r2, r3, r4)
            goto Lb
        L18:
            goto L7
    }

    public static void StFDiSRHNhNlymWA(java.lang.object r0, int r1, java.lang.object r2, int r3, int r4) {
            goto L13
        L4:
            java.lang.System.arraycopy(r0, r1, r2, r3, r4)
            goto Le
        Lb:
            goto L16
        Le:
            return
        Lf:
            goto Lb
        L13:
            goto Lf
        L16:
            goto L4
    }

    public static int TrmDCrrtOmlOblav(int r1, int r2) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            int r0 = java.lang.Math.min(r1, r2)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static void XalhEpGQPUtqLtQx(int r0, int r1, bool r2, int r3, int[] r4, int[][] r5, int[] r6) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L13
        Lb:
            return
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            com.mastercard.terminalsdk.internal.C2197b.m434b(r0, r1, r2, r3, r4, r5, r6)
            goto Lb
    }

    /* JADX INFO: renamed from: a */
    private int M431a() throws java.io.IOException {
            r7 = this;
            goto L157
        L4:
            int r0 = ArinhLKQfMeYKlHA(r0)
            goto L134
        Lc:
            int r0 = r7.f428g
            goto L12
        L12:
            r1 = 2147483647(0x7fffffff, float:NaN)
            goto L128
        L19:
            java.io.Stream r3 = r7.in
            goto Le3
        L1f:
            byte[] r0 = r7.f424c
            goto L48
        L25:
            if (r0 < 0) goto L2a
            goto L5d
        L2a:
            goto L1f
        L2e:
            throw r7
        L2f:
            goto L56
        L33:
            int r3 = GdnAvNdmKlWDuYBA(r3, r5, r2, r6)
            goto L9b
        L3b:
            r0 = r0 & 255(0xff, float:3.57E-43)
            goto L5c
        L41:
            wsMYuIcGxHytFsjp(r7)
            goto L89
        L48:
            r2 = 7
            goto L95
        L4d:
            if (r2 >= r1) goto L52
            goto L113
        L52:
            goto L41
        L56:
            int r7 = r7.f429h
            goto L11d
        L5c:
            int r1 = r1 - r0
        L5d:
            goto Le9
        L61:
            java.lang.IllegalStateException r7 = new java.lang.IllegalStateException
            goto La4
        L67:
            if (r2 >= r1) goto L6c
            goto L15f
        L6c:
            goto L4d
        L70:
            int r6 = 8 - r2
            goto L33
        L76:
            int r2 = r2 + r3
            goto L67
        L7b:
            int r0 = rbmPRrXnIaeNdSaZ(r0)
            goto L83
        L83:
            r7.f428g = r0
        L85:
            goto Lf4
        L89:
            java.io.Stream r0 = r7.in
            goto L4
        L8f:
            java.lang.IllegalStateException r7 = new java.lang.IllegalStateException
            goto Lb4
        L95:
            r0 = r0[r2]
            goto L3b
        L9b:
            if (r3 > 0) goto La0
            goto L6c
        La0:
            goto L76
        La4:
            r7.<init>(r0)
            goto L2e
        Lab:
            if (r0 <= 0) goto Lb0
            goto Ld9
        Lb0:
            goto Ld6
        Lb4:
            r7.<init>(r0)
            goto Lbb
        Lbb:
            throw r7
        Lbc:
            goto L61
        Lc0:
            if (r2 >= 0) goto Lc5
            goto Lbc
        Lc5:
            goto L15e
        Lc9:
            r1 = 8
            goto L147
        Lcf:
            r1 = 2
            goto L117
        Ld6:
            goto L11e
        Ld9:
            goto Lc
        Ldd:
            int r0 = r0 % r1
            goto Lab
        Le3:
            byte[] r5 = r7.f424c
            goto L70
        Le9:
            r7.f429h = r1
            goto L111
        Lef:
            byte r3 = (byte) r2
            goto L100
        Lf4:
            int r0 = r7.f431j
            goto Lc9
        Lfa:
            java.io.Stream r0 = r7.in
            goto L7b
        L100:
            r4 = 0
            goto L141
        L105:
            r7.f431j = r4
            goto L25
        L10b:
            java.lang.string r0 = "unexpected block size"
            goto Lc0
        L111:
            goto L2f
        L113:
            goto L8f
        L117:
            int r0 = r0 + r1
            goto Ldd
        L11d:
            return r7
        L11e:
            goto L150
        L122:
            byte[] r0 = r7.f424c
            goto L163
        L128:
            if (r0 == r1) goto L12d
            goto L85
        L12d:
            goto Lfa
        L131:
            goto L15a
        L134:
            r7.f428g = r0
            goto L105
        L13a:
            r0 = 8
            goto Lcf
        L141:
            r0[r4] = r3
            goto L10b
        L147:
            if (r0 == r1) goto L14c
            goto L2f
        L14c:
            goto L122
        L150:
            goto Ld9
        L153:
            goto L131
        L157:
            goto L153
        L15a:
            goto L13a
        L15e:
            r2 = 1
        L15f:
            goto L19
        L163:
            int r2 = r7.f428g
            goto Lef
    }

    /* JADX INFO: renamed from: b */
    private void M432b() {
            r4 = this;
            goto L16
        L4:
            return
        L5:
            goto L4e
        L9:
            goto Lf
        La:
            goto L4
        Le:
            r0 = 0
        Lf:
            goto L76
        L13:
            goto L19
        L16:
            goto L51
        L19:
            goto L55
        L1d:
            r1[r0] = r2
            goto L48
        L23:
            r2 = r1[r0]
            goto L42
        L29:
            r2 = r2 ^ r3
            goto L37
        L2e:
            if (r0 <= 0) goto L33
            goto L5f
        L33:
            goto L5c
        L37:
            byte r2 = (byte) r2
            goto L1d
        L3c:
            int r0 = r0 + r1
            goto L63
        L42:
            byte[] r3 = r4.f422a
            goto L69
        L48:
            int r0 = r0 + 1
            goto L9
        L4e:
            goto L5f
        L51:
            goto L13
        L55:
            r0 = 3
            goto L6f
        L5c:
            goto L5
        L5f:
            goto Le
        L63:
            int r0 = r0 % r1
            goto L2e
        L69:
            r3 = r3[r0]
            goto L29
        L6f:
            r1 = 15
            goto L3c
        L76:
            r1 = 8
            goto L82
        L7c:
            byte[] r1 = r4.f424c
            goto L23
        L82:
            if (r0 < r1) goto L87
            goto La
        L87:
            goto L7c
    }

    public static int CEYtXkMFhhGBGOLW(com.mastercard.terminalsdk.internal.C2196a r1) {
            goto Lf
        L4:
            goto L12
        L7:
            int r0 = r1.m431a()
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

    /* JADX INFO: renamed from: d */
    private void M433d() {
            r18 = this;
            goto L13b
        L4:
            int r5 = r5 + r8
            goto L130
        L9:
            byte[] r4 = r0.f426e
            goto L78
        Lf:
            int r1 = r0.f427f
            goto Laf
        L15:
            int r4 = r1 >> 8
            goto L19c
        L1b:
            if (r1 == r3) goto L20
            goto Lef
        L20:
            goto L65
        L24:
            r7 = r1[r3]
            goto L1ba
        L2a:
            r10 = r1[r7]
            goto L72
        L30:
            byte r4 = (byte) r4
            goto L1c6
        L35:
            r4 = r1[r2]
            goto L208
        L3b:
            int r12 = r12 << 8
            goto L94
        L41:
            int[] r15 = r1.f452b
            goto L1b4
        L47:
            r5 = -16777216(0xffffffffff000000, float:-1.7014118E38)
            goto L1a8
        L4d:
            com.mastercard.terminalsdk.internal.e r1 = r0.f425d
            goto L41
        L53:
            int[] r5 = r0.f430i
            goto L180
        L59:
            int r10 = r10 << 24
            goto L213
        L5f:
            byte[] r0 = r0.f422a
            goto Lbe
        L65:
            byte[] r1 = r0.f424c
            goto L9
        L6b:
            tqFaCtqeQQJwdTWF(r1, r2, r0, r2, r3)
        L6e:
            goto L158
        L72:
            r10 = r10 & 255(0xff, float:3.57E-43)
            goto L241
        L78:
            int r5 = r1.length
            goto Lec
        L7d:
            int r7 = r7 << 16
            goto Lc8
        L83:
            int r0 = r0 % r1
            goto L1ff
        L89:
            r6 = 1
            goto Lf3
        L8e:
            int[][] r1 = r1.f453e
            goto L53
        L94:
            r9 = r9 & r12
            goto L147
        L99:
            int r12 = r5 >> 24
            goto Lc3
        L9f:
            int r5 = r1 >> 24
            goto L1f4
        La5:
            byte r12 = (byte) r12
            goto Ld4
        Laa:
            byte r6 = (byte) r6
            goto L196
        Laf:
            if (r1 == r3) goto Lb4
            goto L6e
        Lb4:
            goto L247
        Lb8:
            int r14 = r0.f423b
            goto L4d
        Lbe:
            int r3 = r1.length
            goto L6b
        Lc3:
            byte r12 = (byte) r12
            goto L15d
        Lc8:
            r8 = 16711680(0xff0000, float:2.3418052E-38)
            goto L218
        Lce:
            r11[r8] = r4
            goto L233
        Ld4:
            r11[r6] = r12
            goto L105
        Lda:
            r2 = 0
            goto L1cc
        Ldf:
            XalhEpGQPUtqLtQx(r11, r12, r13, r14, r15, r16, r17)
            goto L1f9
        Le6:
            byte[] r1 = r0.f426e
            goto L5f
        Lec:
            StFDiSRHNhNlymWA(r1, r2, r4, r2, r5)
        Lef:
            goto L124
        Lf3:
            r7 = r1[r6]
            goto L7d
        Lf9:
            byte[] r11 = r0.f424c
            goto L99
        Lff:
            r5 = r1[r2]
            goto L16a
        L105:
            int r6 = r5 >> 8
            goto Laa
        L10b:
            goto L159
        L10e:
            goto L135
        L112:
            r1 = r1[r9]
            goto L22d
        L118:
            r11[r7] = r5
            goto L9f
        L11e:
            int r12 = r12 << 16
            goto L176
        L124:
            byte[] r1 = r0.f424c
            goto L35
        L12a:
            int r4 = r1 >> 16
            goto L30
        L130:
            r8 = 6
            goto L185
        L135:
            r0 = r18
            goto L1c0
        L13b:
            goto L1a4
        L13e:
            goto L163
        L142:
            byte r5 = (byte) r5
            goto L118
        L147:
            int r5 = r5 + r9
            goto L17b
        L14c:
            int r4 = r4 + r7
            goto L20e
        L151:
            r9 = 65280(0xff00, float:9.1477E-41)
            goto L191
        L158:
            return
        L159:
            goto L1a1
        L15d:
            r11[r2] = r12
            goto L227
        L163:
            r0 = 3
            goto L1ad
        L16a:
            r1 = r1[r6]
            goto Lf9
        L170:
            r11[r9] = r1
            goto Lf
        L176:
            r8 = r8 & r12
            goto L4
        L17b:
            r9 = 7
            goto L112
        L180:
            r13 = 0
            goto L1d7
        L185:
            r12 = r1[r8]
            goto L3b
        L18b:
            r12 = r1[r10]
            goto L11e
        L191:
            r7 = r7 & r9
            goto L14c
        L196:
            r11[r3] = r6
            goto L142
        L19c:
            byte r4 = (byte) r4
            goto Lce
        L1a1:
            goto L10e
        L1a4:
            goto L238
        L1a8:
            r4 = r4 & r5
            goto L89
        L1ad:
            r1 = 8
            goto L1dd
        L1b4:
            com.mastercard.terminalsdk.internal.e r1 = r0.f425d
            goto L8e
        L1ba:
            int r7 = r7 << 8
            goto L151
        L1c0:
            int r1 = r0.f427f
            goto Lda
        L1c6:
            r11[r10] = r4
            goto L15
        L1cc:
            r3 = 2
            goto L1b
        L1d1:
            r10 = r1[r4]
            goto L59
        L1d7:
            r16 = r1
            goto L1e9
        L1dd:
            int r0 = r0 + r1
            goto L83
        L1e3:
            r11[r4] = r5
            goto L12a
        L1e9:
            r17 = r5
            goto Ldf
        L1ef:
            int r4 = r4 + r7
            goto L24
        L1f4:
            byte r5 = (byte) r5
            goto L1e3
        L1f9:
            int[] r1 = r0.f430i
            goto Lff
        L1ff:
            if (r0 <= 0) goto L204
            goto L10e
        L204:
            goto L10b
        L208:
            int r4 = r4 << 24
            goto L47
        L20e:
            r7 = 3
            goto L2a
        L213:
            r5 = r5 & r10
            goto L222
        L218:
            r7 = r7 & r8
            goto L1ef
        L21d:
            r4 = 4
            goto L1d1
        L222:
            r10 = 5
            goto L18b
        L227:
            int r12 = r5 >> 16
            goto La5
        L22d:
            r1 = r1 & 255(0xff, float:3.57E-43)
            goto L23b
        L233:
            byte r1 = (byte) r1
            goto L170
        L238:
            goto L13e
        L23b:
            int r12 = r5 + r1
            goto Lb8
        L241:
            int r11 = r4 + r10
            goto L21d
        L247:
            GEbaTmAiRLHsbQSd(r0)
            goto Le6
    }

    public static int FeSkjRyPFejsVOoT(com.mastercard.terminalsdk.internal.C2196a r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            int r0 = r1.m431a()
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static void JJbbFlUnuZJvPRyp(java.lang.object r0, int r1, java.lang.object r2, int r3, int r4) {
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
            java.lang.System.arraycopy(r0, r1, r2, r3, r4)
            goto L7
    }

    public static int MCEFeaFxDCPLcPzE(java.io.Stream r1) {
            goto L14
        L4:
            goto L17
        L7:
            int r0 = r1.read()
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

    public static int RbmPRrXnIaeNdSaZ(java.io.Stream r1) {
            goto Lc
        L4:
            int r0 = r1.read()
            goto L13
        Lc:
            goto L14
        Lf:
            goto L4
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto Lf
    }

    public static void TqFaCtqeQQJwdTWF(java.lang.object r0, int r1, java.lang.object r2, int r3, int r4) {
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
            java.lang.System.arraycopy(r0, r1, r2, r3, r4)
            goto Lb
        L17:
            goto L7
    }

    public static int VxWKHgtoAjoMAfZM(com.mastercard.terminalsdk.internal.C2196a r1) {
            goto Lf
        L4:
            goto L12
        L7:
            int r0 = r1.m431a()
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

    public static void WsMYuIcGxHytFsjp(com.mastercard.terminalsdk.internal.C2196a r0) {
            goto L4
        L4:
            goto L16
        L7:
            goto Lb
        Lb:
            r0.m433d()
            goto L15
        L12:
            goto L7
        L15:
            return
        L16:
            goto L12
    }

    public static int XPePMttEOZwkgkpu(int r1, int r2) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            int r0 = java.lang.Math.max(r1, r2)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    @Override // java.io.FilterStream, java.io.Stream
    public int Available() throws java.io.IOException {
            r1 = this;
            goto L1e
        L4:
            goto L21
        L7:
            int r0 = r0 - r1
            goto L19
        Lc:
            vxWKHgtoAjoMAfZM(r1)
            goto L13
        L13:
            int r0 = r1.f429h
            goto L25
        L19:
            return r0
        L1a:
            goto L4
        L1e:
            goto L1a
        L21:
            goto Lc
        L25:
            int r1 = r1.f431j
            goto L7
    }

    @Override // java.io.FilterStream, java.io.Stream
    public bool MarkSupported() {
            r0 = this;
            goto L9
        L4:
            return r0
        L5:
            goto L15
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            r0 = 0
            goto L4
        L15:
            goto Lc
    }

    @Override // java.io.FilterStream, java.io.Stream
    public int Read() throws java.io.IOException {
            r3 = this;
            goto L52
        L4:
            r3.f431j = r2
            goto L25
        La:
            goto L77
        Ld:
            goto L60
        L11:
            goto L55
        L14:
            r3 = -1
            goto L40
        L19:
            r3 = r3 & 255(0xff, float:3.57E-43)
            goto L76
        L1f:
            int r1 = r3.f429h
            goto L67
        L25:
            r3 = r1[r0]
            goto L19
        L2b:
            if (r0 <= 0) goto L30
            goto Ld
        L30:
            goto La
        L34:
            byte[] r1 = r3.f424c
            goto L70
        L3a:
            int r0 = r3.f431j
            goto L1f
        L40:
            return r3
        L41:
            goto L34
        L45:
            r1 = 6
            goto L82
        L4c:
            int r0 = r0 % r1
            goto L2b
        L52:
            goto L7e
        L55:
            goto L59
        L59:
            r0 = 15
            goto L45
        L60:
            feSkjRyPFejsVOoT(r3)
            goto L3a
        L67:
            if (r0 >= r1) goto L6c
            goto L41
        L6c:
            goto L14
        L70:
            int r2 = r0 + 1
            goto L4
        L76:
            return r3
        L77:
            goto L7b
        L7b:
            goto Ld
        L7e:
            goto L11
        L82:
            int r0 = r0 + r1
            goto L4c
    }

    @Override // java.io.FilterStream, java.io.Stream
    public int Read(byte[] r7, int r8, int r9) throws java.io.IOException {
            r6 = this;
            goto L2c
        L4:
            int r0 = r8 + r9
            goto La
        La:
            r1 = r8
        Lb:
            goto Lf
        Lf:
            if (r1 < r0) goto L14
            goto L72
        L14:
            goto Lb2
        L18:
            goto L4f
        L1b:
            goto L4
        L1f:
            goto L1b
        L22:
            goto L68
        L26:
            int r3 = r1 + 1
            goto Lbe
        L2c:
            goto L22
        L2f:
            goto L91
        L33:
            r1 = 5
            goto L98
        L3a:
            int r3 = r6.f429h
            goto L5f
        L40:
            r1 = r3
            goto L71
        L45:
            if (r1 == r8) goto L4a
            goto L7c
        L4a:
            goto L9e
        L4e:
            return r9
        L4f:
            goto L1f
        L53:
            r6.f431j = r5
            goto L6b
        L59:
            int r0 = r0 % r1
            goto La3
        L5f:
            if (r2 >= r3) goto L64
            goto Lba
        L64:
            goto L45
        L68:
            goto L2f
        L6b:
            r2 = r4[r2]
            goto Lac
        L71:
            goto Lb
        L72:
            goto L4e
        L76:
            int r9 = r9 - r0
            goto Lb9
        L7b:
            return r6
        L7c:
            goto L8c
        L80:
            int r2 = r6.f431j
            goto L3a
        L86:
            int r5 = r2 + 1
            goto L53
        L8c:
            int r0 = r0 - r1
            goto L76
        L91:
            r0 = 28
            goto L33
        L98:
            int r0 = r0 + r1
            goto L59
        L9e:
            r6 = -1
            goto L7b
        La3:
            if (r0 <= 0) goto La8
            goto L1b
        La8:
            goto L18
        Lac:
            r7[r1] = r2
            goto L40
        Lb2:
            cEYtXkMFhhGBGOLW(r6)
            goto L80
        Lb9:
            return r9
        Lba:
            goto L26
        Lbe:
            byte[] r4 = r6.f424c
            goto L86
    }

    @Override // java.io.FilterStream, java.io.Stream
    public long Skip(long r5) throws java.io.IOException {
            r4 = this;
            goto L60
        L4:
            int r0 = r0 % r1
            goto L36
        La:
            return r0
        Lb:
            goto L44
        Lf:
            goto L32
        L10:
            goto La
        L14:
            r1 = 23
            goto L4b
        L1b:
            goto L63
        L1e:
            r0 = 27
            goto L14
        L25:
            r2 = 1
            goto L3f
        L2b:
            r3 = -1
            goto L57
        L30:
            r0 = 0
        L32:
            goto L51
        L36:
            if (r0 <= 0) goto L3b
            goto L7b
        L3b:
            goto L78
        L3f:
            long r0 = r0 + r2
            goto Lf
        L44:
            goto L7b
        L47:
            goto L1b
        L4b:
            int r0 = r0 + r1
            goto L4
        L51:
            int r2 = (r0 > r5 ? 1 : (r0 == r5 ? 0 : -1))
            goto L67
        L57:
            if (r2 != r3) goto L5c
            goto L10
        L5c:
            goto L25
        L60:
            goto L47
        L63:
            goto L1e
        L67:
            if (r2 < 0) goto L6c
            goto L10
        L6c:
            goto L70
        L70:
            int r2 = mCEFeaFxDCPLcPzE(r4)
            goto L2b
        L78:
            goto Lb
        L7b:
            goto L30
    }
}

