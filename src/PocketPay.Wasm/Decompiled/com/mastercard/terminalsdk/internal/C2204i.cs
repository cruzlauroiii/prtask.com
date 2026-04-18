namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: com.mastercard.terminalsdk.internal.i */
/* JADX INFO: loaded from: classes2.dex */
public class C2204i : java.io.FilterStream {

    /* JADX INFO: renamed from: d */
    private static readonly short f475d = 0;

    /* JADX INFO: renamed from: a */
    private byte[] f476a;

    /* JADX INFO: renamed from: b */
    private int f477b;

    /* JADX INFO: renamed from: c */
    private byte[] f478c;

    /* JADX INFO: renamed from: e */
    private byte[] f479e;

    /* JADX INFO: renamed from: f */
    private int f480f;

    /* JADX INFO: renamed from: g */
    private int f481g;

    /* JADX INFO: renamed from: h */
    private int f482h;

    /* JADX INFO: renamed from: i */
    private int f483i;

    /* JADX INFO: renamed from: j */
    private int f484j;

    /* JADX INFO: renamed from: l */
    private int f485l;

    /* JADX INFO: renamed from: m */
    private int f486m;

    /* JADX INFO: renamed from: o */
    private int f487o;

    static {
            goto L4
        L4:
            goto L7a
        L7:
            goto L11
        Lb:
            int r0 = r0 + r1
            goto L4d
        L11:
            r0 = 4
            goto L1d
        L18:
            int r0 = (int) r0
            goto L53
        L1d:
            r1 = 25
            goto Lb
        L24:
            goto L3e
        L27:
            goto L37
        L2b:
            r2 = 4607182418800017408(0x3ff0000000000000, double:1.0)
            goto L48
        L31:
            r4 = 4624633867356078080(0x402e000000000000, double:15.0)
            goto L58
        L37:
            r0 = 4617315517961601024(0x4014000000000000, double:5.0)
            goto L7e
        L3d:
            return
        L3e:
            goto L77
        L42:
            r2 = 4611686018427387904(0x4000000000000000, double:2.0)
            goto L31
        L48:
            double r0 = r0 - r2
            goto L42
        L4d:
            int r0 = r0 % r1
            goto L63
        L53:
            short r0 = (short) r0
            goto L71
        L58:
            double r2 = KsMMKeiIOXuiNOWY(r2, r4)
            goto L6c
        L60:
            goto L7
        L63:
            if (r0 <= 0) goto L68
            goto L27
        L68:
            goto L24
        L6c:
            double r0 = r0 * r2
            goto L18
        L71:
            com.mastercard.terminalsdk.internal.C2204i.f475d = r0
            goto L3d
        L77:
            goto L27
        L7a:
            goto L60
        L7e:
            double r0 = aVkSdKFuEJeppJQx(r0)
            goto L2b
    }

    public C2204i(java.io.Stream r3, int[] r4, int r5, byte[] r6, int r7, int r8) throws java.io.IOException {
            r2 = this;
            goto Lec
        L4:
            int r0 = r0 + r1
            goto La2
        La:
            r3 = r4[r0]
            goto L96
        L10:
            r0 = 5
            goto L1a
        L15:
            return
        L16:
            goto L82
        L1a:
            int r7 = FLSTDnKlckrMAoNf(r7, r0)
            goto L28
        L22:
            byte[] r0 = new byte[r3]
            goto Le6
        L28:
            r0 = 16
            goto La8
        L2e:
            r2.f484j = r3
            goto Lfc
        L34:
            r2.f476a = r0
            goto L71
        L3a:
            long r6 = r6 << r3
            goto L110
        L3f:
            r3 = r4[r3]
            goto Le1
        L45:
            r2.f483i = r8
            goto L77
        L4b:
            r1 = 9
            goto L4
        L52:
            r2.<init>(r3)
            goto L89
        L59:
            r0 = 0
            goto Lb9
        L5e:
            byte[] r7 = r2.f478c
            goto L6a
        L64:
            r2.f482h = r7
            goto L45
        L6a:
            aBPRMTDlrbGEVyDB(r6, r0, r7, r0, r3)
        L6d:
            goto La
        L71:
            r2.f477b = r3
            goto Lc9
        L77:
            r7 = 3
            goto L59
        L7c:
            r2.f479e = r0
            goto L22
        L82:
            goto Ld2
        L85:
            goto L10d
        L89:
            r3 = 2147483647(0x7fffffff, float:NaN)
            goto L2e
        L90:
            byte[] r0 = new byte[r3]
            goto L34
        L96:
            long r6 = (long) r3
            goto Lb0
        L9b:
            jUDCgsErlfbkLRkc(r2, r3, r5)
            goto L15
        La2:
            int r0 = r0 % r1
            goto Lf3
        La8:
            int r7 = sYTWSAgusBizHknH(r7, r0)
            goto L64
        Lb0:
            r0 = 4294967295(0xffffffff, double:2.1219957905E-314)
            goto L108
        Lb9:
            if (r8 == r7) goto Lbe
            goto L6d
        Lbe:
            goto L5e
        Lc2:
            r0 = 20
            goto L4b
        Lc9:
            r2.f481g = r3
            goto L10
        Lcf:
            goto L16
        Ld2:
            goto L52
        Ld6:
            long r3 = r3 & r0
            goto L115
        Ldb:
            byte[] r0 = new byte[r3]
            goto L7c
        Le1:
            long r3 = (long) r3
            goto Ld6
        Le6:
            r2.f478c = r0
            goto L90
        Lec:
            goto L85
        Lef:
            goto Lc2
        Lf3:
            if (r0 <= 0) goto Lf8
            goto Ld2
        Lf8:
            goto Lcf
        Lfc:
            r3 = 8
            goto Ldb
        L102:
            r3 = 32
            goto L3a
        L108:
            long r6 = r6 & r0
            goto L102
        L10d:
            goto Lef
        L110:
            r3 = 1
            goto L3f
        L115:
            long r3 = r3 | r6
            goto L9b
    }

    public static int CLnmcxReSZnSmwIz(com.mastercard.terminalsdk.internal.C2204i r1) {
            goto Lf
        L4:
            int r0 = r1.m462e()
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

    public static int FLSTDnKlckrMAoNf(int r1, int r2) {
            goto Lc
        L4:
            int r0 = java.lang.Math.max(r1, r2)
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

    public static double KsMMKeiIOXuiNOWY(double r2, double r4) {
            goto L45
        L4:
            int r0 = r0 % r1
            goto L10
        La:
            int r0 = r0 + r1
            goto L4
        L10:
            if (r0 <= 0) goto L15
            goto L3a
        L15:
            goto L37
        L19:
            goto L48
        L1c:
            goto L3a
        L1f:
            goto L19
        L23:
            r0 = 18
            goto L3e
        L2a:
            double r0 = java.lang.Math.pow(r2, r4)
            goto L32
        L32:
            return r0
        L33:
            goto L1c
        L37:
            goto L33
        L3a:
            goto L2a
        L3e:
            r1 = 17
            goto La
        L45:
            goto L1f
        L48:
            goto L23
    }

    public static void NEfhcWUKHHIpUINQ(com.mastercard.terminalsdk.internal.C2204i r0) {
            goto L13
        L4:
            goto L16
        L7:
            return
        L8:
            goto L4
        Lc:
            r0.m461d()
            goto L7
        L13:
            goto L8
        L16:
            goto Lc
    }

    public static int PPRYFuupWeEZOcKa(java.io.Stream r1, byte[] r2, int r3, int r4) {
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
            int r0 = r1.read(r2, r3, r4)
            goto L7
    }

    public static void SDICsbMsrWpwqZan(com.mastercard.terminalsdk.internal.C2204i r0, long r1) {
            goto L13
        L4:
            r0.m458a(r1)
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

    public static int UYZLAaaLJIglqFqx(java.io.Stream r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            int r0 = r1.read()
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static void WbNEtKxjdHNklbSb(java.lang.object r0, int r1, java.lang.object r2, int r3, int r4) {
            goto L13
        L4:
            java.lang.System.arraycopy(r0, r1, r2, r3, r4)
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

    /* JADX INFO: renamed from: a */
    private void M458a(long r7) {
            r6 = this;
            goto Lb
        L4:
            r0 = 16
            goto L17
        Lb:
            goto L3d
        Le:
            goto L4
        L12:
            long r0 = r0 + r7
            goto L94
        L17:
            r1 = 3
            goto L8e
        L1e:
            r6.f480f = r0
            goto L70
        L24:
            r6.f485l = r7
            goto L60
        L2a:
            long r3 = r3 * r0
            goto L7b
        L2f:
            long r3 = (long) r2
            goto L2a
        L34:
            r6.f487o = r7
            goto L81
        L3a:
            goto La1
        L3d:
            goto L86
        L41:
            int r0 = (int) r7
            goto L1e
        L46:
            int r3 = (int) r3
            goto L75
        L4b:
            long r0 = r7 >> r0
            goto L65
        L51:
            int r0 = r0 % r1
            goto L57
        L57:
            if (r0 <= 0) goto L5c
            goto La1
        L5c:
            goto L9e
        L60:
            long r7 = (long) r2
            goto L12
        L65:
            short r2 = com.mastercard.terminalsdk.internal.C2204i.f475d
            goto L2f
        L6b:
            int r7 = (int) r7
            goto L24
        L70:
            r0 = 3
            goto L4b
        L75:
            r6.f486m = r3
            goto L89
        L7b:
            r5 = 32
            goto L99
        L81:
            return
        L82:
            goto L3a
        L86:
            goto Le
        L89:
            long r7 = r7 >> r5
            goto L6b
        L8e:
            int r0 = r0 + r1
            goto L51
        L94:
            int r7 = (int) r0
            goto L34
        L99:
            long r3 = r3 >> r5
            goto L46
        L9e:
            goto L82
        La1:
            goto L41
    }

    /* JADX INFO: renamed from: a */
    private void M459a(long r3, int r5) {
            r2 = this;
            goto L1a
        L4:
            int r0 = (int) r3
            goto L79
        L9:
            r5 = r5 ^ r0
            goto L59
        Le:
            r2.f487o = r3
            goto L26
        L14:
            r2.f486m = r1
            goto L9
        L1a:
            goto L35
        L1d:
            goto L2b
        L21:
            return
        L22:
            goto L4
        L26:
            return
        L27:
            goto L32
        L2b:
            r0 = 17
            goto L6d
        L32:
            goto L3c
        L35:
            goto L4d
        L39:
            goto L27
        L3c:
            goto L5f
        L40:
            r5 = 32
            goto L68
        L46:
            SDICsbMsrWpwqZan(r2, r3)
            goto L21
        L4d:
            goto L1d
        L50:
            if (r0 <= 0) goto L55
            goto L3c
        L55:
            goto L39
        L59:
            r2.f485l = r5
            goto L40
        L5f:
            if (r5 == 0) goto L64
            goto L22
        L64:
            goto L46
        L68:
            long r3 = r3 >> r5
            goto L74
        L6d:
            r1 = 1
            goto L8b
        L74:
            int r3 = (int) r3
            goto Le
        L79:
            r2.f480f = r0
            goto L85
        L7f:
            int r0 = r0 % r1
            goto L50
        L85:
            int r1 = r0 * r5
            goto L14
        L8b:
            int r0 = r0 + r1
            goto L7f
    }

    public static void ABPRMTDlrbGEVyDB(java.lang.object r0, int r1, java.lang.object r2, int r3, int r4) {
            goto L7
        L4:
            goto La
        L7:
            goto L16
        La:
            goto Le
        Le:
            java.lang.System.arraycopy(r0, r1, r2, r3, r4)
            goto L15
        L15:
            return
        L16:
            goto L4
    }

    public static void AQecISrmDjtnbpOM(com.mastercard.terminalsdk.internal.C2204i r0) {
            goto L4
        L4:
            goto L16
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            r0.m460b()
            goto L15
        L15:
            return
        L16:
            goto Lb
    }

    public static double AVkSdKFuEJeppJQx(double r2) {
            goto L4
        L4:
            goto L3c
        L7:
            goto L18
        Lb:
            goto L27
        Le:
            goto L2b
        L12:
            int r0 = r0 + r1
            goto L33
        L18:
            r0 = 27
            goto L1f
        L1f:
            r1 = 23
            goto L12
        L26:
            return r0
        L27:
            goto L39
        L2b:
            double r0 = java.lang.Math.sqrt(r2)
            goto L26
        L33:
            int r0 = r0 % r1
            goto L40
        L39:
            goto Le
        L3c:
            goto L49
        L40:
            if (r0 <= 0) goto L45
            goto Le
        L45:
            goto Lb
        L49:
            goto L7
    }

    /* JADX INFO: renamed from: b */
    private void M460b() {
            r4 = this;
            goto L1b
        L4:
            goto L80
        L7:
            goto L22
        Lb:
            r0 = 0
        Lc:
            goto L4d
        L10:
            byte[] r3 = r4.f478c
            goto L71
        L16:
            return
        L17:
            goto L4
        L1b:
            goto L7
        L1e:
            goto L84
        L22:
            goto L1e
        L25:
            byte[] r1 = r4.f479e
            goto L32
        L2b:
            r1 = 19
            goto L66
        L32:
            r2 = r1[r0]
            goto L10
        L38:
            if (r0 <= 0) goto L3d
            goto L80
        L3d:
            goto L7d
        L41:
            r1[r0] = r2
            goto L47
        L47:
            int r0 = r0 + 1
            goto L53
        L4d:
            r1 = 8
            goto L58
        L53:
            goto Lc
        L54:
            goto L16
        L58:
            if (r0 < r1) goto L5d
            goto L54
        L5d:
            goto L25
        L61:
            r2 = r2 ^ r3
            goto L6c
        L66:
            int r0 = r0 + r1
            goto L77
        L6c:
            byte r2 = (byte) r2
            goto L41
        L71:
            r3 = r3[r0]
            goto L61
        L77:
            int r0 = r0 % r1
            goto L38
        L7d:
            goto L17
        L80:
            goto Lb
        L84:
            r0 = 32
            goto L2b
    }

    public static int CjVZrhGtRLONnNvb(java.io.Stream r1) {
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
            int r0 = r1.read()
            goto L7
    }

    public static int CvGDlohusGYxkVNa(com.mastercard.terminalsdk.internal.C2204i r1) {
            goto L14
        L4:
            goto L17
        L7:
            int r0 = r1.m462e()
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

    /* JADX INFO: renamed from: d */
    private void M461d() {
            r17 = this;
            goto L27a
        L4:
            int r0 = r0 + r1
            goto L6a
        La:
            goto L27d
        Ld:
            r1[r11] = r4
            goto L274
        L13:
            int r1 = r0.f483i
            goto Ld3
        L19:
            int r4 = r4 - r6
            goto L287
        L1e:
            r9 = r1[r3]
            goto L1df
        L24:
            r1[r8] = r4
            goto L149
        L2a:
            int r12 = r5 >>> 5
            goto L109
        L30:
            r1[r7] = r6
            goto Lfe
        L36:
            int r5 = r5 + r1
            goto L210
        L3b:
            int r3 = r1.length
            goto L7d
        L40:
            int r6 = r4 >> 8
            goto L20b
        L46:
            if (r1 == r3) goto L4b
            goto L80
        L4b:
            goto L99
        L4f:
            int r4 = r5 >> 16
            goto L1b0
        L55:
            int r5 = r5 + r8
            goto L2a7
        L5a:
            int r12 = r0.f482h
            goto L265
        L60:
            int r15 = r15 + r6
            goto L2ac
        L65:
            int r12 = r12 - r1
            goto Lb1
        L6a:
            int r0 = r0 % r1
            goto L1eb
        L70:
            goto Lb9
        L73:
            goto La
        L77:
            int r12 = r0.f480f
            goto Le4
        L7d:
            WbNEtKxjdHNklbSb(r1, r2, r0, r2, r3)
        L80:
            goto L23e
        L84:
            r9 = 4
            goto L215
        L89:
            byte r4 = (byte) r4
            goto L24
        L8e:
            r6 = r6 ^ r12
            goto L19
        L93:
            int r11 = r11 << 24
            goto L24f
        L99:
            aQecISrmDjtnbpOM(r0)
            goto L249
        La0:
            int r5 = r5 + r10
            goto L1c5
        La5:
            int r15 = r0.f487o
            goto L292
        Lab:
            int r14 = r4 >>> 5
            goto La5
        Lb1:
            int r13 = r13 * r12
            goto L1ab
        Lb6:
            goto L23f
        Lb9:
            goto L1fa
        Lbd:
            r3 = 3
            goto L1d0
        Lc2:
            r12 = r1[r11]
            goto L103
        Lc8:
            r7 = r7 & r8
            goto Lee
        Lcd:
            byte[] r1 = r0.f479e
            goto L186
        Ld3:
            r2 = 0
            goto Lbd
        Ld8:
            r1 = r1 & 255(0xff, float:3.57E-43)
            goto L36
        Lde:
            r4 = r1[r2]
            goto L1f4
        Le4:
            int r6 = r6 + r12
            goto L133
        Le9:
            r8 = r8 & r12
            goto L55
        Lee:
            int r4 = r4 + r7
            goto L192
        Lf3:
            r6 = 1
            goto Lf8
        Lf8:
            r7 = r1[r6]
            goto L121
        Lfe:
            byte r4 = (byte) r4
            goto L159
        L103:
            int r12 = r12 << 16
            goto Le9
        L109:
            int r13 = r0.f486m
            goto L226
        L10f:
            r10 = 65280(0xff00, float:9.1477E-41)
            goto L25a
        L116:
            int r15 = r4 << 4
            goto L1bf
        L11c:
            r11 = 5
            goto Lc2
        L121:
            int r7 = r7 << 16
            goto L2b2
        L127:
            goto L211
        L129:
            goto L1d9
        L12d:
            byte[] r0 = r0.f478c
            goto L3b
        L133:
            r6 = r6 ^ r13
            goto L2a
        L138:
            r9 = r1[r7]
            goto L18c
        L13e:
            int r14 = r14 * r13
            goto L170
        L143:
            r1[r16] = r6
            goto L40
        L149:
            byte r4 = (byte) r5
            goto L180
        L14e:
            r12 = r1[r8]
            goto L232
        L154:
            int r4 = r4 + r9
            goto L84
        L159:
            r1[r3] = r4
            goto L281
        L15f:
            int r5 = r1.length
            goto L19d
        L164:
            int r14 = r12 - r1
            goto L13e
        L16a:
            r6 = r16
            goto L127
        L170:
            int r14 = r14 + r4
            goto L116
        L175:
            byte r4 = (byte) r4
            goto L200
        L17a:
            int r6 = r0.f485l
            goto L60
        L180:
            r1[r10] = r4
            goto L238
        L186:
            int r6 = r4 >> 24
            goto L206
        L18c:
            int r9 = r9 << 8
            goto L10f
        L192:
            r7 = 2
            goto L138
        L197:
            short r13 = com.mastercard.terminalsdk.internal.C2204i.f475d
            goto L164
        L19d:
            pAciIewAeeebhyJt(r1, r2, r4, r2, r5)
        L1a0:
            goto L220
        L1a4:
            r1 = 15
            goto L4
        L1ab:
            int r13 = r13 + r5
            goto L243
        L1b0:
            byte r4 = (byte) r4
            goto Ld
        L1b5:
            r10 = r10 & r12
            goto La0
        L1ba:
            r6 = r6 ^ r14
            goto L21b
        L1bf:
            r16 = r6
            goto L17a
        L1c5:
            r10 = 7
            goto L254
        L1ca:
            int r6 = r4 >> 16
            goto L2a2
        L1d0:
            if (r1 == r3) goto L1d5
            goto L1a0
        L1d5:
            goto L26e
        L1d9:
            r16 = r6
            goto Lcd
        L1df:
            r9 = r9 & 255(0xff, float:3.57E-43)
            goto L154
        L1e5:
            byte[] r4 = r0.f476a
            goto L15f
        L1eb:
            if (r0 <= 0) goto L1f0
            goto Lb9
        L1f0:
            goto Lb6
        L1f4:
            int r4 = r4 << 24
            goto L297
        L1fa:
            r0 = r17
            goto L13
        L200:
            r1[r9] = r4
            goto L4f
        L206:
            byte r6 = (byte) r6
            goto L25f
        L20b:
            byte r6 = (byte) r6
            goto L30
        L210:
            r1 = r2
        L211:
            goto L5a
        L215:
            r11 = r1[r9]
            goto L93
        L21b:
            int r5 = r5 - r6
            goto L65
        L220:
            byte[] r1 = r0.f479e
            goto Lde
        L226:
            int r12 = r12 + r13
            goto L8e
        L22b:
            r0 = 6
            goto L1a4
        L232:
            int r12 = r12 << 8
            goto L1b5
        L238:
            int r1 = r0.f483i
            goto L46
        L23e:
            return
        L23f:
            goto L70
        L243:
            int r6 = r5 << 4
            goto L77
        L249:
            byte[] r1 = r0.f476a
            goto L12d
        L24f:
            r5 = r5 & r11
            goto L11c
        L254:
            r1 = r1[r10]
            goto Ld8
        L25a:
            r9 = r9 & r10
            goto L29d
        L25f:
            r1[r2] = r6
            goto L1ca
        L265:
            if (r1 < r12) goto L26a
            goto L129
        L26a:
            goto L197
        L26e:
            byte[] r1 = r0.f479e
            goto L1e5
        L274:
            int r4 = r5 >> 8
            goto L89
        L27a:
            goto L73
        L27d:
            goto L22b
        L281:
            int r4 = r5 >> 24
            goto L175
        L287:
            int r1 = r1 + 1
            goto L16a
        L28d:
            r4 = r4 & r5
            goto Lf3
        L292:
            int r14 = r14 + r15
            goto L1ba
        L297:
            r5 = -16777216(0xffffffffff000000, float:-1.7014118E38)
            goto L28d
        L29d:
            int r4 = r4 + r9
            goto L1e
        L2a2:
            byte r6 = (byte) r6
            goto L143
        L2a7:
            r8 = 6
            goto L14e
        L2ac:
            r6 = r14 ^ r15
            goto Lab
        L2b2:
            r8 = 16711680(0xff0000, float:2.3418052E-38)
            goto Lc8
    }

    /* JADX INFO: renamed from: e */
    private int M462e() throws java.io.IOException {
            r7 = this;
            goto L112
        L4:
            int r3 = PPRYFuupWeEZOcKa(r3, r5, r2, r6)
            goto L71
        Lc:
            int r0 = UYZLAaaLJIglqFqx(r0)
            goto Le8
        L14:
            int r0 = r7.f484j
            goto L95
        L1a:
            java.lang.IllegalStateException r7 = new java.lang.IllegalStateException
            goto Lee
        L20:
            r0 = r0 & 255(0xff, float:3.57E-43)
            goto L101
        L26:
            r0 = 27
            goto L10b
        L2d:
            if (r2 >= 0) goto L32
            goto Le4
        L32:
            goto L15c
        L36:
            r2 = 7
            goto L13c
        L3b:
            throw r7
        L3c:
            goto La6
        L40:
            r0[r4] = r3
            goto Lb9
        L46:
            byte[] r0 = r7.f479e
            goto L36
        L4c:
            int r0 = r0 % r1
            goto Lcb
        L52:
            if (r0 == r1) goto L57
            goto L3c
        L57:
            goto Lfb
        L5b:
            int r0 = r7.f477b
            goto Lc5
        L61:
            goto La2
        L64:
            goto L14
        L68:
            if (r0 < 0) goto L6d
            goto L102
        L6d:
            goto L46
        L71:
            if (r3 > 0) goto L76
            goto Ldf
        L76:
            goto L119
        L7a:
            goto L64
        L7d:
            goto L133
        L81:
            if (r0 == r1) goto L86
            goto L8c
        L86:
            goto L136
        L8a:
            r7.f484j = r0
        L8c:
            goto L5b
        L90:
            r4 = 0
            goto L40
        L95:
            r1 = 2147483647(0x7fffffff, float:NaN)
            goto L81
        L9c:
            goto L3c
        L9d:
            goto L1a
        La1:
            return r7
        La2:
            goto L7a
        La6:
            int r7 = r7.f481g
            goto La1
        Lac:
            int r6 = 8 - r2
            goto L4
        Lb2:
            r7.<init>(r0)
            goto L3b
        Lb9:
            java.lang.string r0 = "unexpected block size"
            goto L2d
        Lbf:
            int r0 = r0 + r1
            goto L4c
        Lc5:
            r1 = 8
            goto L52
        Lcb:
            if (r0 <= 0) goto Ld0
            goto L64
        Ld0:
            goto L61
        Ld4:
            int r2 = r7.f484j
            goto L106
        Lda:
            if (r2 >= r1) goto Ldf
            goto L15d
        Ldf:
            goto L124
        Le3:
            throw r7
        Le4:
            goto L11e
        Le8:
            r7.f484j = r0
            goto Lf5
        Lee:
            r7.<init>(r0)
            goto Le3
        Lf5:
            r7.f477b = r4
            goto L68
        Lfb:
            byte[] r0 = r7.f479e
            goto Ld4
        L101:
            int r1 = r1 - r0
        L102:
            goto L148
        L106:
            byte r3 = (byte) r2
            goto L90
        L10b:
            r1 = 18
            goto Lbf
        L112:
            goto L7d
        L115:
            goto L26
        L119:
            int r2 = r2 + r3
            goto Lda
        L11e:
            java.lang.IllegalStateException r7 = new java.lang.IllegalStateException
            goto Lb2
        L124:
            if (r2 >= r1) goto L129
            goto L9d
        L129:
            goto L161
        L12d:
            java.io.Stream r3 = r7.in
            goto L14e
        L133:
            goto L115
        L136:
            java.io.Stream r0 = r7.in
            goto L154
        L13c:
            r0 = r0[r2]
            goto L20
        L142:
            java.io.Stream r0 = r7.in
            goto Lc
        L148:
            r7.f481g = r1
            goto L9c
        L14e:
            byte[] r5 = r7.f479e
            goto Lac
        L154:
            int r0 = ryYoKDHFBuoIXhAG(r0)
            goto L8a
        L15c:
            r2 = 1
        L15d:
            goto L12d
        L161:
            NEfhcWUKHHIpUINQ(r7)
            goto L142
    }

    public static int JEimVyDuczbmsEzX(com.mastercard.terminalsdk.internal.C2204i r1) {
            goto Lc
        L4:
            int r0 = r1.m462e()
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

    public static void JUDCgsErlfbkLRkc(com.mastercard.terminalsdk.internal.C2204i r0, long r1, int r3) {
            goto L13
        L4:
            r0.m459a(r1, r3)
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

    public static void PAciIewAeeebhyJt(java.lang.object r0, int r1, java.lang.object r2, int r3, int r4) {
            goto L4
        L4:
            goto L16
        L7:
            goto Lb
        Lb:
            java.lang.System.arraycopy(r0, r1, r2, r3, r4)
            goto L15
        L12:
            goto L7
        L15:
            return
        L16:
            goto L12
    }

    public static int RyYoKDHFBuoIXhAG(java.io.Stream r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            int r0 = r1.read()
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static int SYTWSAgusBizHknH(int r1, int r2) {
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
            int r0 = java.lang.Math.min(r1, r2)
            goto L4
        L18:
            goto Lc
    }

    @Override // java.io.FilterStream, java.io.Stream
    public int Available() throws java.io.IOException {
            r1 = this;
            goto L11
        L4:
            int r1 = r1.f477b
            goto L18
        La:
            cvGDlohusGYxkVNa(r1)
            goto L25
        L11:
            goto L21
        L14:
            goto La
        L18:
            int r0 = r0 - r1
            goto L20
        L1d:
            goto L14
        L20:
            return r0
        L21:
            goto L1d
        L25:
            int r0 = r1.f481g
            goto L4
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
            goto L40
        L4:
            int r0 = r0 + r1
            goto L18
        La:
            goto L84
        Ld:
            goto L47
        L11:
            r1 = 28
            goto L4
        L18:
            int r0 = r0 % r1
            goto L74
        L1e:
            r3 = r3 & 255(0xff, float:3.57E-43)
            goto L83
        L24:
            r3 = -1
            goto L35
        L29:
            r3 = r1[r0]
            goto L1e
        L2f:
            byte[] r1 = r3.f479e
            goto L55
        L35:
            return r3
        L36:
            goto L2f
        L3a:
            int r0 = r3.f477b
            goto L6e
        L40:
            goto L51
        L43:
            goto L64
        L47:
            jEimVyDuczbmsEzX(r3)
            goto L3a
        L4e:
            goto Ld
        L51:
            goto L6b
        L55:
            int r2 = r0 + 1
            goto L7d
        L5b:
            if (r0 >= r1) goto L60
            goto L36
        L60:
            goto L24
        L64:
            r0 = 16
            goto L11
        L6b:
            goto L43
        L6e:
            int r1 = r3.f481g
            goto L5b
        L74:
            if (r0 <= 0) goto L79
            goto Ld
        L79:
            goto La
        L7d:
            r3.f477b = r2
            goto L29
        L83:
            return r3
        L84:
            goto L4e
    }

    @Override // java.io.FilterStream, java.io.Stream
    public int Read(byte[] r7, int r8, int r9) throws java.io.IOException {
            r6 = this;
            goto L39
        L4:
            int r5 = r2 + 1
            goto L49
        La:
            int r0 = r0 % r1
            goto L7c
        L10:
            r1 = 9
            goto L8c
        L17:
            return r9
        L18:
            goto L9e
        L1c:
            if (r2 >= r3) goto L21
            goto L18
        L21:
            goto L25
        L25:
            if (r1 == r8) goto L2a
            goto L6a
        L2a:
            goto La9
        L2e:
            int r0 = r8 + r9
            goto Lae
        L34:
            int r9 = r9 - r0
            goto L17
        L39:
            goto L59
        L3c:
            goto L85
        L40:
            goto L3c
        L43:
            int r3 = r6.f481g
            goto L1c
        L49:
            r6.f477b = r5
            goto L63
        L4f:
            CLnmcxReSZnSmwIz(r6)
            goto Lb3
        L56:
            goto L95
        L59:
            goto L40
        L5d:
            r7[r1] = r2
            goto L77
        L63:
            r2 = r4[r2]
            goto L5d
        L69:
            return r6
        L6a:
            goto Lbf
        L6e:
            if (r1 < r0) goto L73
            goto La5
        L73:
            goto L4f
        L77:
            r1 = r3
            goto La4
        L7c:
            if (r0 <= 0) goto L81
            goto L95
        L81:
            goto L92
        L85:
            r0 = 13
            goto L10
        L8c:
            int r0 = r0 + r1
            goto La
        L92:
            goto L9a
        L95:
            goto L2e
        L99:
            return r9
        L9a:
            goto L56
        L9e:
            int r3 = r1 + 1
            goto Lb9
        La4:
            goto Laf
        La5:
            goto L99
        La9:
            r6 = -1
            goto L69
        Lae:
            r1 = r8
        Laf:
            goto L6e
        Lb3:
            int r2 = r6.f477b
            goto L43
        Lb9:
            byte[] r4 = r6.f479e
            goto L4
        Lbf:
            int r0 = r0 - r1
            goto L34
    }

    @Override // java.io.FilterStream, java.io.Stream
    public long Skip(long r5) throws java.io.IOException {
            r4 = this;
            goto L5a
        L4:
            long r0 = r0 + r2
            goto L18
        L9:
            r0 = 0
        Lb:
            goto L1d
        Lf:
            if (r0 <= 0) goto L14
            goto L4a
        L14:
            goto L47
        L18:
            goto Lb
        L19:
            goto L6b
        L1d:
            int r2 = (r0 > r5 ? 1 : (r0 == r5 ? 0 : -1))
            goto L70
        L23:
            r2 = 1
            goto L4
        L29:
            goto L4a
        L2c:
            goto L68
        L30:
            int r0 = r0 + r1
            goto L79
        L36:
            int r2 = cjVZrhGtRLONnNvb(r4)
            goto L55
        L3e:
            if (r2 != r3) goto L43
            goto L19
        L43:
            goto L23
        L47:
            goto L6c
        L4a:
            goto L9
        L4e:
            r0 = 10
            goto L61
        L55:
            r3 = -1
            goto L3e
        L5a:
            goto L2c
        L5d:
            goto L4e
        L61:
            r1 = 21
            goto L30
        L68:
            goto L5d
        L6b:
            return r0
        L6c:
            goto L29
        L70:
            if (r2 < 0) goto L75
            goto L19
        L75:
            goto L36
        L79:
            int r0 = r0 % r1
            goto Lf
    }
}

