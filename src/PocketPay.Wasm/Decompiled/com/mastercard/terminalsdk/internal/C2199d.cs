namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: com.mastercard.terminalsdk.internal.d */
/* JADX INFO: loaded from: classes2.dex */
public class C2199d : java.io.FilterStream {

    /* JADX INFO: renamed from: a */
    private long[] f432a;

    /* JADX INFO: renamed from: b */
    private long[] f433b;

    /* JADX INFO: renamed from: c */
    private byte[] f434c;

    /* JADX INFO: renamed from: d */
    private short f435d;

    /* JADX INFO: renamed from: e */
    private readonly int f436e;

    /* JADX INFO: renamed from: h */
    private int f437h;

    /* JADX INFO: renamed from: i */
    private int f438i;

    /* JADX INFO: renamed from: j */
    private int f439j;

    public C2199d(java.io.Stream r2, int r3, int r4, short r5, int r6, int r7) throws java.io.IOException {
            r1 = this;
            goto L6c
        L4:
            return
        L5:
            goto L3a
        L9:
            r1.f436e = r5
            goto L51
        Lf:
            r3 = r6 ^ r7
            goto L80
        L15:
            r1.f438i = r5
            goto L2d
        L1b:
            r1.f439j = r2
            goto L5f
        L21:
            r0 = 8
            goto L64
        L27:
            r1.f432a = r0
            goto L94
        L2d:
            r1.f437h = r5
            goto L7a
        L33:
            r1.<init>(r2)
            goto L73
        L3a:
            goto L6f
        L3d:
            int r5 = yqRYCoOeIGfdgFci(r5, r2)
            goto L21
        L45:
            r1.f433b = r2
            goto L4
        L4b:
            r2 = r4 ^ r7
            goto Lf
        L51:
            byte[] r0 = new byte[r5]
            goto La6
        L57:
            long[] r2 = HXGmffjSayTMNayJ(r2, r3)
            goto L88
        L5f:
            r2 = 4
            goto L3d
        L64:
            int r5 = dKjcpIfKLvwjLusQ(r5, r0)
            goto L9
        L6c:
            goto L5
        L6f:
            goto L33
        L73:
            r2 = 2147483647(0x7fffffff, float:NaN)
            goto L1b
        L7a:
            r2 = r3 ^ r7
            goto La0
        L80:
            long[] r2 = gpQwRYzBLeZThogr(r2, r3)
            goto L45
        L88:
            r1.f432a = r2
            goto L4b
        L8e:
            r1.f433b = r2
            goto L15
        L94:
            long[] r2 = new long[r2]
            goto L8e
        L9a:
            long[] r0 = new long[r2]
            goto L27
        La0:
            r3 = r5 ^ r7
            goto L57
        La6:
            r1.f434c = r0
            goto L9a
    }

    public static long[] HXGmffjSayTMNayJ(int r1, int r2) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L13
        Lb:
            return r0
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            long[] r0 = com.mastercard.terminalsdk.internal.C2198c.m438a(r1, r2)
            goto Lb
    }

    public static int OllnWvBwOytkJSNF(java.io.Stream r1) {
            goto L14
        L4:
            int r0 = r1.read()
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

    public static void QhqGNbUbpeSNoHDw(long[] r0, long[] r1, int r2) {
            goto Lb
        L4:
            com.mastercard.terminalsdk.internal.C2198c.m440e(r0, r1, r2)
            goto L15
        Lb:
            goto L16
        Le:
            goto L4
        L12:
            goto Le
        L15:
            return
        L16:
            goto L12
    }

    public static int UedmInkjTkTFwVvR(java.io.Stream r1, byte[] r2, int r3, int r4) {
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
            int r0 = r1.read(r2, r3, r4)
            goto L4
    }

    public static int ZnvAezSWoNkaayPZ(java.io.Stream r1) {
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

    public static int AVpinnmcLmssqJHy(java.io.Stream r1) {
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
            int r0 = r1.read()
            goto L4
        L18:
            goto Lc
    }

    /* JADX INFO: renamed from: b */
    private void M441b() {
            r8 = this;
            goto Le1
        L4:
            r6 = 255(0xff, double:1.26E-321)
            goto L74
        La:
            goto Lcb
        Ld:
            goto L5c
        L11:
            int r0 = r0 % 4
            goto L8f
        L17:
            r1[r0] = r2
            goto L23
        L1d:
            int r1 = r8.f436e
            goto L5f
        L23:
            int r0 = r0 + 1
            goto L2f
        L29:
            long[] r4 = r8.f432a
            goto L68
        L2f:
            goto Lbd
        L31:
            goto L94
        L35:
            int r0 = r0 + r1
            goto L89
        L3b:
            int r0 = r0 + 1
            goto L11
        L41:
            if (r0 <= 0) goto L46
            goto Lcb
        L46:
            goto Lc8
        L4a:
            int r6 = r0 << 3
            goto L79
        L50:
            long[] r0 = r8.f432a
            goto L83
        L56:
            byte[] r1 = r8.f434c
            goto Ldb
        L5c:
            goto Le4
        L5f:
            if (r0 < r1) goto L64
            goto L31
        L64:
            goto L56
        L68:
            short r5 = r8.f435d
            goto La9
        L6e:
            r8.f435d = r0
            goto La4
        L74:
            long r4 = r4 & r6
            goto L9f
        L79:
            long r4 = r4 >> r6
            goto L4
        L7e:
            byte r2 = (byte) r2
            goto L17
        L83:
            long[] r1 = r8.f433b
            goto Lb6
        L89:
            int r0 = r0 % r1
            goto L41
        L8f:
            short r0 = (short) r0
            goto L6e
        L94:
            short r0 = r8.f435d
            goto L3b
        L9a:
            long r2 = (long) r2
            goto L29
        L9f:
            long r2 = r2 ^ r4
            goto Ld6
        La4:
            return
        La5:
            goto La
        La9:
            r4 = r4[r5]
            goto L4a
        Laf:
            r0 = 13
            goto Lcf
        Lb6:
            short r2 = r8.f435d
            goto Lc1
        Lbc:
            r0 = 0
        Lbd:
            goto L1d
        Lc1:
            QhqGNbUbpeSNoHDw(r0, r1, r2)
            goto Lbc
        Lc8:
            goto La5
        Lcb:
            goto L50
        Lcf:
            r1 = 10
            goto L35
        Ld6:
            int r2 = (int) r2
            goto L7e
        Ldb:
            r2 = r1[r0]
            goto L9a
        Le1:
            goto Ld
        Le4:
            goto Laf
    }

    public static int DKjcpIfKLvwjLusQ(int r1, int r2) {
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
            int r0 = java.lang.Math.min(r1, r2)
            goto Le
    }

    /* JADX INFO: renamed from: e */
    private int M442e() throws java.io.IOException {
            r6 = this;
            goto L135
        L4:
            r6.<init>(r0)
            goto L63
        Lb:
            if (r2 > 0) goto L10
            goto Le5
        L10:
            goto L5e
        L14:
            if (r0 <= 0) goto L19
            goto L108
        L19:
            goto L105
        L1d:
            java.io.Stream r0 = r6.in
            goto L8c
        L23:
            throw r6
        L24:
            goto L16d
        L28:
            r6.f439j = r0
        L2a:
            goto Ld5
        L2e:
            if (r1 >= 0) goto L33
            goto L24
        L33:
            goto L49
        L37:
            int r0 = r6.f436e
        L39:
            goto L112
        L3d:
            r6.f439j = r0
            goto L179
        L43:
            java.lang.IllegalStateException r6 = new java.lang.IllegalStateException
            goto Lf8
        L49:
            r1 = 1
        L4a:
            goto La9
        L4e:
            int r1 = r6.f436e
            goto L7d
        L54:
            goto L138
        L57:
            nIGQPMUAfdmpruRa(r6)
            goto L1d
        L5e:
            int r1 = r1 + r2
            goto L71
        L63:
            throw r6
        L64:
            goto L86
        L68:
            if (r1 >= r2) goto L6d
            goto Ldc
        L6d:
            goto L57
        L71:
            int r2 = r6.f436e
            goto Le0
        L77:
            int r2 = r0 + (-1)
            goto Lff
        L7d:
            if (r0 == r1) goto L82
            goto L64
        L82:
            goto L129
        L86:
            int r6 = r6.f437h
            goto L13c
        L8c:
            int r0 = OllnWvBwOytkJSNF(r0)
            goto L3d
        L94:
            r1 = 2147483647(0x7fffffff, float:NaN)
            goto La0
        L9b:
            r3 = 0
            goto L10c
        La0:
            if (r0 == r1) goto La5
            goto L2a
        La5:
            goto L148
        La9:
            java.io.Stream r2 = r6.in
            goto L167
        Laf:
            int r5 = r6.f436e
            goto Ld0
        Lb5:
            r1 = 5
            goto Lc2
        Lbc:
            java.lang.string r0 = "unexpected block size"
            goto L2e
        Lc2:
            int r0 = r0 + r1
            goto Le9
        Lc8:
            int r2 = UedmInkjTkTFwVvR(r2, r4, r1, r5)
            goto Lb
        Ld0:
            int r5 = r5 - r1
            goto Lc8
        Ld5:
            int r0 = r6.f438i
            goto L4e
        Ldb:
            goto L64
        Ldc:
            goto L43
        Le0:
            if (r1 >= r2) goto Le5
            goto L4a
        Le5:
            goto L173
        Le9:
            int r0 = r0 % r1
            goto L14
        Lef:
            if (r0 < 0) goto Lf4
            goto L163
        Lf4:
            goto L123
        Lf8:
            r6.<init>(r0)
            goto L23
        Lff:
            r1 = r1[r2]
            goto L12f
        L105:
            goto L13d
        L108:
            goto L15b
        L10c:
            r0[r3] = r2
            goto Lbc
        L112:
            r6.f437h = r0
            goto Ldb
        L118:
            int r0 = r0 - r1
            goto L161
        L11d:
            int r1 = r6.f439j
            goto L17f
        L123:
            int r0 = r6.f436e
            goto L155
        L129:
            byte[] r0 = r6.f434c
            goto L11d
        L12f:
            r1 = r1 & 255(0xff, float:3.57E-43)
            goto L118
        L135:
            goto L144
        L138:
            goto L14e
        L13c:
            return r6
        L13d:
            goto L141
        L141:
            goto L108
        L144:
            goto L54
        L148:
            java.io.Stream r0 = r6.in
            goto L184
        L14e:
            r0 = 24
            goto Lb5
        L155:
            byte[] r1 = r6.f434c
            goto L77
        L15b:
            int r0 = r6.f439j
            goto L94
        L161:
            goto L39
        L163:
            goto L37
        L167:
            byte[] r4 = r6.f434c
            goto Laf
        L16d:
            java.lang.IllegalStateException r6 = new java.lang.IllegalStateException
            goto L4
        L173:
            int r2 = r6.f436e
            goto L68
        L179:
            r6.f438i = r3
            goto Lef
        L17f:
            byte r2 = (byte) r1
            goto L9b
        L184:
            int r0 = aVpinnmcLmssqJHy(r0)
            goto L28
    }

    public static long[] GpQwRYzBLeZThogr(int r1, int r2) {
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
            long[] r0 = com.mastercard.terminalsdk.internal.C2198c.m438a(r1, r2)
            goto L4
    }

    public static int KztFSeBFRVdJtmIT(com.mastercard.terminalsdk.internal.C2199d r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            int r0 = r1.m442e()
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static void NIGQPMUAfdmpruRa(com.mastercard.terminalsdk.internal.C2199d r0) {
            goto L13
        L4:
            return
        L5:
            goto L9
        L9:
            goto L16
        Lc:
            r0.m441b()
            goto L4
        L13:
            goto L5
        L16:
            goto Lc
    }

    public static int VoNMMuHfevEfQMzU(com.mastercard.terminalsdk.internal.C2199d r1) {
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
            int r0 = r1.m442e()
            goto Le
    }

    public static int WsjYCSgUjkoZrTIQ(com.mastercard.terminalsdk.internal.C2199d r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            int r0 = r1.m442e()
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static int YqRYCoOeIGfdgFci(int r1, int r2) {
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
            int r0 = java.lang.Math.max(r1, r2)
            goto Lb
        L18:
            goto L7
    }

    @Override // java.io.FilterStream, java.io.Stream
    public int Available() throws java.io.IOException {
            r1 = this;
            goto Le
        L4:
            kztFSeBFRVdJtmIT(r1)
            goto L25
        Lb:
            goto L11
        Le:
            goto L16
        L11:
            goto L4
        L15:
            return r0
        L16:
            goto Lb
        L1a:
            int r0 = r0 - r1
            goto L15
        L1f:
            int r1 = r1.f438i
            goto L1a
        L25:
            int r0 = r1.f437h
            goto L1f
    }

    @Override // java.io.FilterStream, java.io.Stream
    public bool MarkSupported() {
            r0 = this;
            goto Le
        L4:
            return r0
        L5:
            goto L15
        L9:
            r0 = 0
            goto L4
        Le:
            goto L5
        L11:
            goto L9
        L15:
            goto L11
    }

    @Override // java.io.FilterStream, java.io.Stream
    public int Read() throws java.io.IOException {
            r3 = this;
            goto L50
        L4:
            goto L2e
        L7:
            goto L17
        Lb:
            r3 = r3 & 255(0xff, float:3.57E-43)
            goto L2d
        L11:
            r3 = r1[r0]
            goto Lb
        L17:
            wsjYCSgUjkoZrTIQ(r3)
            goto L4a
        L1e:
            int r1 = r3.f437h
            goto L24
        L24:
            if (r0 >= r1) goto L29
            goto L78
        L29:
            goto L35
        L2d:
            return r3
        L2e:
            goto L70
        L32:
            goto L53
        L35:
            r3 = -1
            goto L77
        L3a:
            if (r0 <= 0) goto L3f
            goto L7
        L3f:
            goto L4
        L43:
            r0 = 24
            goto L63
        L4a:
            int r0 = r3.f438i
            goto L1e
        L50:
            goto L73
        L53:
            goto L43
        L57:
            r3.f438i = r2
            goto L11
        L5d:
            int r0 = r0 % r1
            goto L3a
        L63:
            r1 = 17
            goto L82
        L6a:
            int r2 = r0 + 1
            goto L57
        L70:
            goto L7
        L73:
            goto L32
        L77:
            return r3
        L78:
            goto L7c
        L7c:
            byte[] r1 = r3.f434c
            goto L6a
        L82:
            int r0 = r0 + r1
            goto L5d
    }

    @Override // java.io.FilterStream, java.io.Stream
    public int Read(byte[] r7, int r8, int r9) throws java.io.IOException {
            r6 = this;
            goto Laa
        L4:
            r1 = r3
            goto L3d
        L9:
            int r0 = r8 + r9
            goto L24
        Lf:
            int r5 = r2 + 1
            goto L8f
        L15:
            goto Lad
        L18:
            int r3 = r1 + 1
            goto L71
        L1e:
            int r0 = r0 % r1
            goto Lbb
        L24:
            r1 = r8
        L25:
            goto L9a
        L29:
            voNMMuHfevEfQMzU(r6)
            goto L77
        L30:
            r7[r1] = r2
            goto L4
        L36:
            r0 = 28
            goto La3
        L3d:
            goto L25
        L3e:
            goto L42
        L42:
            return r9
        L43:
            goto L55
        L47:
            int r9 = r9 - r0
            goto L8a
        L4c:
            if (r2 >= r3) goto L51
            goto L8b
        L51:
            goto L5c
        L55:
            goto L86
        L58:
            goto L15
        L5c:
            if (r1 == r8) goto L61
            goto Lb7
        L61:
            goto Lb1
        L65:
            int r3 = r6.f437h
            goto L4c
        L6b:
            int r0 = r0 + r1
            goto L1e
        L71:
            byte[] r4 = r6.f434c
            goto Lf
        L77:
            int r2 = r6.f438i
            goto L65
        L7d:
            r2 = r4[r2]
            goto L30
        L83:
            goto L43
        L86:
            goto L9
        L8a:
            return r9
        L8b:
            goto L18
        L8f:
            r6.f438i = r5
            goto L7d
        L95:
            int r0 = r0 - r1
            goto L47
        L9a:
            if (r1 < r0) goto L9f
            goto L3e
        L9f:
            goto L29
        La3:
            r1 = 13
            goto L6b
        Laa:
            goto L58
        Lad:
            goto L36
        Lb1:
            r6 = -1
            goto Lb6
        Lb6:
            return r6
        Lb7:
            goto L95
        Lbb:
            if (r0 <= 0) goto Lc0
            goto L86
        Lc0:
            goto L83
    }

    @Override // java.io.FilterStream, java.io.Stream
    public long Skip(long r5) throws java.io.IOException {
            r4 = this;
            goto L37
        L4:
            if (r0 <= 0) goto L9
            goto L1f
        L9:
            goto L1c
        Ld:
            r0 = 14
            goto L78
        L14:
            int r2 = ZnvAezSWoNkaayPZ(r4)
            goto L50
        L1c:
            goto L5f
        L1f:
            goto L4a
        L23:
            int r0 = r0 % r1
            goto L4
        L29:
            int r2 = (r0 > r5 ? 1 : (r0 == r5 ? 0 : -1))
            goto L55
        L2f:
            goto L4c
        L30:
            goto L5e
        L34:
            goto L3a
        L37:
            goto L74
        L3a:
            goto Ld
        L3e:
            r2 = 1
            goto L63
        L44:
            int r0 = r0 + r1
            goto L23
        L4a:
            r0 = 0
        L4c:
            goto L29
        L50:
            r3 = -1
            goto L68
        L55:
            if (r2 < 0) goto L5a
            goto L30
        L5a:
            goto L14
        L5e:
            return r0
        L5f:
            goto L71
        L63:
            long r0 = r0 + r2
            goto L2f
        L68:
            if (r2 != r3) goto L6d
            goto L30
        L6d:
            goto L3e
        L71:
            goto L1f
        L74:
            goto L34
        L78:
            r1 = 9
            goto L44
    }
}

