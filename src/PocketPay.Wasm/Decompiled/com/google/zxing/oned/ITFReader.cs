namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes2.dex */
public readonly class ITFReader : com.google.zxing.oned.OneDReader {
    private static readonly int[] DEFAULT_ALLOWED_LENGTHS = null;
    private static readonly int[][] END_PATTERN_REVERSED = null;
    private static readonly float MAX_AVG_VARIANCE = 0.38f;
    private static readonly float MAX_INDIVIDUAL_VARIANCE = 0.5f;

    /* JADX INFO: renamed from: N */
    private static readonly int f351N = 1;
    private static readonly int[][] PATTERNS = null;
    private static readonly int[] START_PATTERN = null;

    /* JADX INFO: renamed from: W */
    private static readonly int f352W = 3;

    /* JADX INFO: renamed from: w */
    private static readonly int f353w = 2;
    private int narrowLineWidth;

    static {
            goto L127
        L4:
            int[] r12 = new int[]{r1, r0, r0, r1, r0}
            goto Lf3
        Lc:
            int[][] r2 = new int[][]{r2, r4}
            goto Lbc
        L14:
            int[] r4 = new int[]{r0, r0, r1, r1, r0}
            goto Ld6
        L1c:
            int[] r6 = new int[]{r0, r1, r0, r0, r1}
            goto L53
        L24:
            int[] r9 = new int[]{r1, r0, r1, r0, r0}
            goto L2c
        L2c:
            int[] r10 = new int[]{r0, r1, r1, r0, r0}
            goto L101
        L34:
            com.google.zxing.oned.ITFReader.PATTERNS = r0
            goto L13b
        L3a:
            int[] r20 = new int[]{r0, r3, r3, r0, r0}
            goto La8
        L42:
            int[] r8 = new int[]{r0, r0, r1, r0, r1}
            goto L24
        L4a:
            if (r0 <= 0) goto L4f
            goto Lc5
        L4f:
            goto Lc2
        L53:
            int[] r7 = new int[]{r1, r1, r0, r0, r0}
            goto L42
        L5b:
            goto L12a
        L5e:
            r1 = 7
            goto L9c
        L65:
            int[] r14 = new int[]{r0, r0, r3, r3, r0}
            goto Le5
        L6d:
            r2 = 6
            goto Lfb
        L72:
            int[] r18 = new int[]{r0, r0, r3, r0, r3}
            goto L119
        L7a:
            com.google.zxing.oned.ITFReader.START_PATTERN = r1
            goto Lb0
        L80:
            int[][] r0 = new int[][]{r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14, r15, r16, r17, r18, r19, r20, r21, r22, r23}
            goto L34
        L88:
            com.google.zxing.oned.ITFReader.DEFAULT_ALLOWED_LENGTHS = r0
            goto Lc9
        L8e:
            r1 = 14
            goto L6d
        L94:
            int[] r4 = new int[]{r0, r0, r3}
            goto Lc
        L9c:
            int r0 = r0 + r1
            goto Led
        La2:
            r4 = 10
            goto L111
        La8:
            int[] r21 = new int[]{r0, r0, r0, r3, r3}
            goto L12e
        Lb0:
            r1 = 2
            goto L140
        Lb5:
            goto Lc5
        Lb8:
            goto L5b
        Lbc:
            com.google.zxing.oned.ITFReader.END_PATTERN_REVERSED = r2
            goto L14
        Lc2:
            goto L13c
        Lc5:
            goto L121
        Lc9:
            r0 = 1
            goto Lce
        Lce:
            int[] r1 = new int[]{r0, r0, r0, r0}
            goto L7a
        Ld6:
            int[] r5 = new int[]{r1, r0, r0, r0, r1}
            goto L1c
        Lde:
            r0 = 21
            goto L5e
        Le5:
            int[] r15 = new int[]{r3, r0, r0, r0, r3}
            goto L109
        Led:
            int r0 = r0 % r1
            goto L4a
        Lf3:
            int[] r13 = new int[]{r0, r1, r0, r1, r0}
            goto L65
        Lfb:
            r3 = 8
            goto La2
        L101:
            int[] r11 = new int[]{r0, r0, r0, r1, r1}
            goto L4
        L109:
            int[] r16 = new int[]{r0, r3, r0, r0, r3}
            goto L148
        L111:
            int[] r0 = new int[]{r2, r3, r4, r0, r1}
            goto L88
        L119:
            int[] r19 = new int[]{r3, r0, r3, r0, r0}
            goto L3a
        L121:
            r0 = 12
            goto L8e
        L127:
            goto Lb8
        L12a:
            goto Lde
        L12e:
            int[] r22 = new int[]{r3, r0, r0, r3, r0}
            goto L150
        L136:
            r3 = 3
            goto L94
        L13b:
            return
        L13c:
            goto Lb5
        L140:
            int[] r2 = new int[]{r0, r0, r1}
            goto L136
        L148:
            int[] r17 = new int[]{r3, r3, r0, r0, r0}
            goto L72
        L150:
            int[] r23 = new int[]{r0, r3, r0, r3, r0}
            goto L80
    }

    public ITFReader() {
            r1 = this;
            goto Lb
        L4:
            r1.<init>()
            goto L20
        Lb:
            goto L1c
        Le:
            goto L4
        L12:
            goto Le
        L15:
            r1.narrowLineWidth = r0
            goto L1b
        L1b:
            return
        L1c:
            goto L12
        L20:
            r0 = -1
            goto L15
    }

    public static int CREswjLozgaVZvEs(com.google.zxing.common.BitArray r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            int r0 = skipWhiteSpace(r1)
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static void EBzKRHcZSdkOOALe(com.google.zxing.common.BitArray r0, int r1, int r2, java.lang.stringBuilder r3) {
            goto L4
        L4:
            goto L16
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            decodeMiddle(r0, r1, r2, r3)
            goto L15
        L15:
            return
        L16:
            goto Lb
    }

    public static void EVKxusTzVusRTrjc(com.google.zxing.common.BitArray r0) {
            goto L9
        L4:
            return
        L5:
            goto L17
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            r0.reverse()
            goto L4
        L17:
            goto Lc
    }

    public static bool EXdtgtjwdAwldGyP(com.google.zxing.common.BitArray r1, int r2) {
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
            bool r0 = r1[r2)
            goto Lb
    }

    public static void FHBLiVSXgtcNhwyK(com.google.zxing.oned.ITFReader r0, com.google.zxing.common.BitArray r1, int r2) {
            goto L13
        L4:
            r0.validateQuietZone(r1, r2)
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

    public static int[] HCPZVUEoQMSVypuO(com.google.zxing.common.BitArray r1, int r2, int[] r3) {
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
            int[] r0 = findGuardRegex(r1, r2, r3)
            goto Le
    }

    public static int HWbbyajuBjgqKLbO(int r1, int r2) {
            goto Lf
        L4:
            int r0 = java.lang.Math.min(r1, r2)
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

    public static int[] KgapgqxeFaOpZoHh(com.google.zxing.oned.ITFReader r1, com.google.zxing.common.BitArray r2) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            int[] r0 = r1.decodeStart(r2)
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static com.google.zxing.NotFoundException LWacuNOfIyUexVfP() {
            goto Lf
        L4:
            com.google.zxing.NotFoundException r0 = com.google.zxing.NotFoundException.getNotFoundInstance()
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

    public static void MZAppyuoCqxEhsML(com.google.zxing.common.BitArray r0) {
            goto Le
        L4:
            r0.reverse()
            goto L15
        Lb:
            goto L11
        Le:
            goto L16
        L11:
            goto L4
        L15:
            return
        L16:
            goto Lb
    }

    public static int NPfQnlXEBRjNSDkl(com.google.zxing.common.BitArray r1) {
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
            int r0 = r1.getSize()
            goto Lb
        L18:
            goto L7
    }

    public static com.google.zxing.FormatException PiIUAjeRfZYUCvsz() {
            goto L14
        L4:
            goto L17
        L7:
            com.google.zxing.FormatException r0 = com.google.zxing.FormatException.getFormatInstance()
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

    public static int[] QsFHJrDAXBWqmINs(com.google.zxing.common.BitArray r1, int r2, int[] r3) {
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
            int[] r0 = findGuardRegex(r1, r2, r3)
            goto L4
    }

    public static int SwxUwUUZkkcsvhAd(com.google.zxing.common.BitArray r1) {
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
            int r0 = r1.getSize()
            goto Lb
    }

    public static void TyFFOhTagrMWYEhZ(java.lang.object r0, int r1, java.lang.object r2, int r3, int r4) {
            goto L4
        L4:
            goto L13
        L7:
            goto Lb
        Lb:
            java.lang.System.arraycopy(r0, r1, r2, r3, r4)
            goto L12
        L12:
            return
        L13:
            goto L17
        L17:
            goto L7
    }

    public static void UdWFsqFAddNiboNM(com.google.zxing.common.BitArray r0, int r1, int[] r2) {
            goto L13
        L4:
            return
        L5:
            goto L9
        L9:
            goto L16
        Lc:
            recordRegex(r0, r1, r2)
            goto L4
        L13:
            goto L5
        L16:
            goto Lc
    }

    public static com.google.zxing.NotFoundException WlolGxMVstWitxWS() {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            com.google.zxing.NotFoundException r0 = com.google.zxing.NotFoundException.getNotFoundInstance()
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static int[] WneFaznohngrswkt(com.google.zxing.common.BitArray r1, int r2, int[] r3) {
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
            int[] r0 = findGuardRegex(r1, r2, r3)
            goto Lb
    }

    public static java.lang.stringBuilder XADSjfNilgmbsrUy(java.lang.stringBuilder r1, char r2) {
            goto Lc
        L4:
            java.lang.stringBuilder r0 = r1.append(r2)
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

    public static bool DDVbjPiUjXjcKfmF(com.google.zxing.common.BitArray r1, int r2) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            bool r0 = r1[r2)
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static com.google.zxing.NotFoundException DdbnFiuIgjuqLyOQ() {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            com.google.zxing.NotFoundException r0 = com.google.zxing.NotFoundException.getNotFoundInstance()
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    private static int DecodeDigit(int[] r7) throws com.google.zxing.NotFoundException {
            goto L99
        L4:
            r0 = 11
            goto L45
        Lb:
            goto L4f
        Le:
            goto Ld4
        L12:
            if (r4 >= 0) goto L17
            goto L1c
        L17:
            goto L64
        L1b:
            return r4
        L1c:
            goto L37
        L20:
            float r5 = xgcUxqUHpXMbIyGx(r7, r5, r6)
            goto L7e
        L28:
            int r3 = r3 + 1
            goto L84
        L2e:
            if (r3 < r0) goto L33
            goto L85
        L33:
            goto L93
        L37:
            com.google.zxing.NotFoundException r7 = ddbnFiuIgjuqLyOQ()
            goto Lae
        L3f:
            int r0 = r0 + r1
            goto Lce
        L45:
            r1 = 5
            goto L3f
        L4c:
            goto Laf
        L4f:
            goto L58
        L53:
            r4 = r2
        L54:
            goto L2e
        L58:
            int[][] r0 = com.google.zxing.oned.ITFReader.PATTERNS
            goto L89
        L5e:
            r5 = r5[r3]
            goto Lb8
        L64:
            int r4 = r4 % 10
            goto L1b
        L6a:
            int r5 = (r5 > r1 ? 1 : (r5 == r1 ? 0 : -1))
            goto L75
        L70:
            r1 = r5
            goto L8e
        L75:
            if (r5 == 0) goto L7a
            goto Lb4
        L7a:
            goto Lb3
        L7e:
            int r6 = (r5 > r1 ? 1 : (r5 == r1 ? 0 : -1))
            goto Lc5
        L84:
            goto L54
        L85:
            goto L12
        L89:
            int r0 = r0.length
            goto Lbe
        L8e:
            goto Lb4
        L8f:
            goto L6a
        L93:
            int[][] r5 = com.google.zxing.oned.ITFReader.PATTERNS
            goto L5e
        L99:
            goto Le
        L9c:
            goto L4
        La0:
            r2 = -1
            goto Ldc
        La5:
            if (r0 <= 0) goto Laa
            goto L4f
        Laa:
            goto L4c
        Lae:
            throw r7
        Laf:
            goto Lb
        Lb3:
            r4 = r2
        Lb4:
            goto L28
        Lb8:
            r6 = 1056964608(0x3f000000, float:0.5)
            goto L20
        Lbe:
            r1 = 1052938076(0x3ec28f5c, float:0.38)
            goto La0
        Lc5:
            if (r6 < 0) goto Lca
            goto L8f
        Lca:
            goto Ld7
        Lce:
            int r0 = r0 % r1
            goto La5
        Ld4:
            goto L9c
        Ld7:
            r4 = r3
            goto L70
        Ldc:
            r3 = 0
            goto L53
    }

    private int[] DecodeEnd(com.google.zxing.common.BitArray r6) throws com.google.zxing.NotFoundException {
            r5 = this;
            goto L86
        L4:
            r0 = 7
            goto L2a
        Lb:
            if (r0 <= 0) goto L10
            goto L90
        L10:
            goto L8d
        L14:
            return r0
        L15:
            r5 = move-exception
            goto L6c
        L1a:
            int r0 = r0 % r1
            goto Lb
        L20:
            goto L90
        L23:
            goto L27
        L27:
            goto L89
        L2a:
            r1 = 30
            goto L80
        L31:
            dnWNCYsaNVGkPcKR(r6)
            goto L14
        L38:
            r1 = 1
            goto L73
        L3d:
            goto L46
        L3e:
            int[][] r3 = com.google.zxing.oned.ITFReader.END_PATTERN_REVERSED     // Catch: java.lang.Exception -> L15
            r3 = r3[r1]     // Catch: java.lang.Exception -> L15
            int[] r0 = QsFHJrDAXBWqmINs(r6, r0, r3)     // Catch: java.lang.Exception -> L15
        L46:
            r3 = r0[r2]     // Catch: java.lang.Exception -> L15
            FHBLiVSXgtcNhwyK(r5, r6, r3)     // Catch: java.lang.Exception -> L15
            r5 = r0[r2]     // Catch: java.lang.Exception -> L15
            int r3 = SwxUwUUZkkcsvhAd(r6)     // Catch: java.lang.Exception -> L15
            r4 = r0[r1]     // Catch: java.lang.Exception -> L15
            int r3 = r3 - r4
            r0[r2] = r3     // Catch: java.lang.Exception -> L15
            int r2 = iUdgedUqCBZwmnZB(r6)     // Catch: java.lang.Exception -> L15
            int r2 = r2 - r5
            r0[r1] = r2     // Catch: java.lang.Exception -> L15
            goto L31
        L61:
            MZAppyuoCqxEhsML(r6)
            int r0 = nXMdrQsgJKNNlzqH(r6)     // Catch: java.lang.Exception -> L15
            goto L38
        L6c:
            EVKxusTzVusRTrjc(r6)
            goto L94
        L73:
            r2 = 0
            int[][] r3 = com.google.zxing.oned.ITFReader.END_PATTERN_REVERSED     // Catch: java.lang.Exception -> L15 com.google.zxing.NotFoundException -> L3e
            r3 = r3[r2]     // Catch: java.lang.Exception -> L15 com.google.zxing.NotFoundException -> L3e
            int[] r0 = HCPZVUEoQMSVypuO(r6, r0, r3)     // Catch: java.lang.Exception -> L15 com.google.zxing.NotFoundException -> L3e
            goto L3d
        L80:
            int r0 = r0 + r1
            goto L1a
        L86:
            goto L23
        L89:
            goto L4
        L8d:
            goto L95
        L90:
            goto L61
        L94:
            throw r5
        L95:
            goto L20
    }

    private static void DecodeMiddle(com.google.zxing.common.BitArray r9, int r10, int r11, java.lang.stringBuilder r12) throws com.google.zxing.NotFoundException {
            goto Le6
        L4:
            int[] r1 = new int[r0]
            goto L2a
        La:
            int r0 = r0 + r1
            goto L7e
        L10:
            int r7 = r7 + 1
            goto L8f
        L16:
            int r6 = tNwutTncQcwgjZEf(r3)
            goto L89
        L1e:
            r4[r6] = r7
            goto Lc4
        L24:
            goto Lb0
        L26:
            goto L16
        L2a:
            r2 = 5
            goto L69
        L2f:
            return
        L30:
            goto Lf9
        L34:
            r6 = r1[r5]
            goto Ld8
        L3a:
            int r6 = jRpyDVxgCJgJsTFn(r4)
            goto L6f
        L42:
            char r6 = (char) r6
            goto La8
        L47:
            goto Lab
        L48:
            goto L2f
        L4c:
            if (r0 <= 0) goto L51
            goto Lc0
        L51:
            goto Lbd
        L55:
            int r7 = r6 * 2
            goto Ld2
        L5b:
            UdWFsqFAddNiboNM(r9, r10, r1)
            goto L84
        L62:
            r0 = 20
            goto La1
        L69:
            int[] r3 = new int[r2]
            goto Lf3
        L6f:
            int r6 = r6 + 48
            goto L42
        L75:
            if (r6 < r2) goto L7a
            goto L26
        L7a:
            goto L55
        L7e:
            int r0 = r0 % r1
            goto L4c
        L84:
            r5 = 0
            goto Laf
        L89:
            int r6 = r6 + 48
            goto Lca
        L8f:
            r7 = r1[r7]
            goto L1e
        L95:
            r3[r6] = r8
            goto L10
        L9b:
            r0 = 10
            goto L4
        La1:
            r1 = 23
            goto La
        La8:
            XADSjfNilgmbsrUy(r12, r6)
        Lab:
            goto Ldd
        Laf:
            r6 = r5
        Lb0:
            goto L75
        Lb4:
            if (r10 < r11) goto Lb9
            goto L48
        Lb9:
            goto L5b
        Lbd:
            goto L30
        Lc0:
            goto L9b
        Lc4:
            int r6 = r6 + 1
            goto L24
        Lca:
            char r6 = (char) r6
            goto L100
        Lcf:
            goto Le9
        Ld2:
            r8 = r1[r7]
            goto L95
        Ld8:
            int r10 = r10 + r6
            goto Led
        Ldd:
            if (r5 < r0) goto Le2
            goto Lf5
        Le2:
            goto L34
        Le6:
            goto Lfc
        Le9:
            goto L62
        Led:
            int r5 = r5 + 1
            goto L47
        Lf3:
            int[] r4 = new int[r2]
        Lf5:
            goto Lb4
        Lf9:
            goto Lc0
        Lfc:
            goto Lcf
        L100:
            oxDhQGDqQqcaKycH(r12, r6)
            goto L3a
    }

    private int[] DecodeStart(com.google.zxing.common.BitArray r4) throws com.google.zxing.NotFoundException {
            r3 = this;
            goto L7b
        L4:
            r1 = 1
            goto L37
        L9:
            goto L46
        Lc:
            goto L56
        L10:
            r2 = r0[r2]
            goto L66
        L16:
            r2 = 0
            goto L10
        L1b:
            int r0 = CREswjLozgaVZvEs(r4)
            goto L2b
        L23:
            int[] r0 = WneFaznohngrswkt(r4, r0, r1)
            goto L4
        L2b:
            int[] r1 = com.google.zxing.oned.ITFReader.START_PATTERN
            goto L23
        L31:
            int r0 = r0 % r1
            goto L6b
        L37:
            r1 = r0[r1]
            goto L16
        L3d:
            int r0 = r0 + r1
            goto L31
        L43:
            goto L52
        L46:
            goto L1b
        L4a:
            r0 = 2
            goto L74
        L51:
            return r0
        L52:
            goto L9
        L56:
            goto L7e
        L59:
            int r1 = r1 / 4
            goto L82
        L5f:
            dwZTmwnjkObqxmOT(r3, r4, r2)
            goto L51
        L66:
            int r1 = r1 - r2
            goto L59
        L6b:
            if (r0 <= 0) goto L70
            goto L46
        L70:
            goto L43
        L74:
            r1 = 27
            goto L3d
        L7b:
            goto Lc
        L7e:
            goto L4a
        L82:
            r3.narrowLineWidth = r1
            goto L5f
    }

    public static void DnWNCYsaNVGkPcKR(com.google.zxing.common.BitArray r0) {
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
            r0.reverse()
            goto Lb
        L17:
            goto L7
    }

    public static void DwZTmwnjkObqxmOT(com.google.zxing.oned.ITFReader r0, com.google.zxing.common.BitArray r1, int r2) {
            goto L9
        L4:
            return
        L5:
            goto L17
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            r0.validateQuietZone(r1, r2)
            goto L4
        L17:
            goto Lc
    }

    public static int DzmAFWugyJQppvOC(com.google.zxing.common.BitArray r1, int r2) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            int r0 = r1.getNextHashSet(r2)
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    private static int[] FindGuardRegex(com.google.zxing.common.BitArray r10, int r11, int[] r12) throws com.google.zxing.NotFoundException {
            goto L11d
        L4:
            r1[r6] = r8
            goto Lda
        La:
            goto L9b
        Ld:
            goto L13a
        L11:
            r6 = r5
        L12:
            goto Ld1
        L16:
            int r11 = r11 + 1
            goto L32
        L1c:
            bool r7 = EXdtgtjwdAwldGyP(r10, r11)
            goto L2d
        L24:
            if (r7 < 0) goto L29
            goto L100
        L29:
            goto L3d
        L2d:
            r8 = 1
            goto L8b
        L32:
            goto L12
        L33:
            goto Le7
        L37:
            int r7 = r6 + (-1)
            goto L51
        L3d:
            int[] r10 = new int[]{r4, r11}
            goto Lff
        L45:
            int r7 = r0 + (-1)
            goto La4
        L4b:
            r1[r7] = r3
            goto L68
        L51:
            r9 = 2
            goto L56
        L56:
            TyFFOhTagrMWYEhZ(r1, r9, r1, r3, r7)
            goto L4b
        L5d:
            r7 = r1[r3]
            goto L79
        L63:
            r3 = 0
            goto Lfa
        L68:
            r1[r6] = r3
            goto L7f
        L6e:
            int r7 = (r7 > r9 ? 1 : (r7 == r9 ? 0 : -1))
            goto L24
        L74:
            int r7 = r7 + r9
            goto L9f
        L79:
            r9 = r1[r8]
            goto L74
        L7f:
            int r6 = r6 + (-1)
            goto L94
        L85:
            int r0 = r0 + r1
            goto Lc6
        L8b:
            if (r7 != r5) goto L90
            goto L12d
        L90:
            goto Lb9
        L94:
            goto L141
        L96:
            goto L13f
        L9a:
            throw r10
        L9b:
            goto Lbf
        L9f:
            int r4 = r4 + r7
            goto L37
        La4:
            if (r6 == r7) goto La9
            goto L96
        La9:
            goto L104
        Lad:
            r1[r6] = r7
            goto L12c
        Lb3:
            int[] r1 = new int[r0]
            goto L124
        Lb9:
            r7 = r1[r6]
            goto L118
        Lbf:
            goto Ld
        Lc2:
            goto Lef
        Lc6:
            int r0 = r0 % r1
            goto L131
        Lcc:
            r5 = r3
            goto L11
        Ld1:
            if (r11 < r2) goto Ld6
            goto L33
        Ld6:
            goto L1c
        Lda:
            r5 = r5 ^ 1
        Ldc:
            goto L16
        Le0:
            r1 = 21
            goto L85
        Le7:
            com.google.zxing.NotFoundException r10 = gCvSsESGLDfrAeJU()
            goto L9a
        Lef:
            goto L120
        Lf2:
            float r7 = yuPhbucteRsDHZNs(r1, r12, r7)
            goto L10a
        Lfa:
            r4 = r11
            goto Lcc
        Lff:
            return r10
        L100:
            goto L5d
        L104:
            r7 = 1056964608(0x3f000000, float:0.5)
            goto Lf2
        L10a:
            r9 = 1052938076(0x3ec28f5c, float:0.38)
            goto L6e
        L111:
            r0 = 15
            goto Le0
        L118:
            int r7 = r7 + r8
            goto Lad
        L11d:
            goto Lc2
        L120:
            goto L111
        L124:
            int r2 = hrzCsHSFmwNKMjNU(r10)
            goto L63
        L12c:
            goto Ldc
        L12d:
            goto L45
        L131:
            if (r0 <= 0) goto L136
            goto Ld
        L136:
            goto La
        L13a:
            int r0 = r12.length
            goto Lb3
        L13f:
            int r6 = r6 + 1
        L141:
            goto L4
    }

    public static com.google.zxing.NotFoundException GCvSsESGLDfrAeJU() {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            com.google.zxing.NotFoundException r0 = com.google.zxing.NotFoundException.getNotFoundInstance()
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static java.lang.object GiJqeLNUEJgTCdbC(java.util.Dictionary r1, java.lang.object r2) {
            goto Lc
        L4:
            java.lang.object r0 = r1[r2)
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

    public static int[] HeLvVFjqIFFMVpbI(com.google.zxing.oned.ITFReader r1, com.google.zxing.common.BitArray r2) {
            goto Lf
        L4:
            int[] r0 = r1.decodeEnd(r2)
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

    public static int HrzCsHSFmwNKMjNU(com.google.zxing.common.BitArray r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            int r0 = r1.getSize()
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static int IUdgedUqCBZwmnZB(com.google.zxing.common.BitArray r1) {
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
            int r0 = r1.getSize()
            goto L4
    }

    public static int JRpyDVxgCJgJsTFn(int[] r1) {
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
            int r0 = decodeDigit(r1)
            goto L4
    }

    public static int NXMdrQsgJKNNlzqH(com.google.zxing.common.BitArray r1) {
            goto L14
        L4:
            goto L17
        L7:
            int r0 = skipWhiteSpace(r1)
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

    public static java.lang.stringBuilder OxDhQGDqQqcaKycH(java.lang.stringBuilder r1, char r2) {
            goto Lf
        L4:
            java.lang.stringBuilder r0 = r1.append(r2)
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

    public static int PnPDhGsBkJgCdQtb(java.lang.string r1) {
            goto L11
        L4:
            int r0 = r1.Length
            goto Lc
        Lc:
            return r0
        Ld:
            goto L18
        L11:
            goto Ld
        L14:
            goto L4
        L18:
            goto L14
    }

    public static void RfqgxAcjggWOjEnX(com.google.zxing.Result r0, com.google.zxing.ResultMetadataType r1, java.lang.object r2) {
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
            r0.putMetadata(r1, r2)
            goto Lb
        L17:
            goto L7
    }

    private static int SkipWhiteSpace(com.google.zxing.common.BitArray r2) throws com.google.zxing.NotFoundException {
            goto L4
        L4:
            goto L29
        L7:
            goto L3e
        Lb:
            int r2 = dzmAFWugyJQppvOC(r2, r1)
            goto L13
        L13:
            if (r2 != r0) goto L18
            goto L66
        L18:
            goto L65
        L1c:
            goto L7
        L1f:
            goto L52
        L22:
            goto L5d
        L26:
            goto L22
        L29:
            goto L1c
        L2d:
            com.google.zxing.NotFoundException r2 = WlolGxMVstWitxWS()
            goto L51
        L35:
            if (r0 <= 0) goto L3a
            goto L22
        L3a:
            goto L1f
        L3e:
            r0 = 5
            goto L56
        L45:
            int r0 = r0 + r1
            goto L4b
        L4b:
            int r0 = r0 % r1
            goto L35
        L51:
            throw r2
        L52:
            goto L26
        L56:
            r1 = 14
            goto L45
        L5d:
            int r0 = NPfQnlXEBRjNSDkl(r2)
            goto L6a
        L65:
            return r2
        L66:
            goto L2d
        L6a:
            r1 = 0
            goto Lb
    }

    public static int TNwutTncQcwgjZEf(int[] r1) {
            goto Lf
        L4:
            int r0 = decodeDigit(r1)
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

    public static java.lang.string UfNKSRaydDvsyUMb(java.lang.stringBuilder r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            java.lang.string r0 = r1.tostring()
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    private void ValidateQuietZone(com.google.zxing.common.BitArray r2, int r3) throws com.google.zxing.NotFoundException {
            r1 = this;
            goto L4c
        L4:
            int r1 = r1 + (-1)
            goto L13
        La:
            if (r0 != 0) goto Lf
            goto L3a
        Lf:
            goto L39
        L13:
            int r3 = r3 + (-1)
            goto L1e
        L19:
            return
        L1a:
            goto L31
        L1e:
            goto L6f
        L1f:
            goto L61
        L23:
            throw r1
        L24:
            goto L6a
        L28:
            if (r3 >= 0) goto L2d
            goto L1f
        L2d:
            goto L3e
        L31:
            com.google.zxing.NotFoundException r1 = LWacuNOfIyUexVfP()
            goto L23
        L39:
            goto L1f
        L3a:
            goto L4
        L3e:
            bool r0 = dDVbjPiUjXjcKfmF(r2, r3)
            goto La
        L46:
            int r1 = r1 * 10
            goto L53
        L4c:
            goto L24
        L4f:
            goto L5b
        L53:
            int r1 = HWbbyajuBjgqKLbO(r1, r3)
            goto L6d
        L5b:
            int r1 = r1.narrowLineWidth
            goto L46
        L61:
            if (r1 == 0) goto L66
            goto L1a
        L66:
            goto L19
        L6a:
            goto L4f
        L6d:
            int r3 = r3 + (-1)
        L6f:
            goto L73
        L73:
            if (r1 > 0) goto L78
            goto L1f
        L78:
            goto L28
    }

    public static float XgcUxqUHpXMbIyGx(int[] r1, int[] r2, float r3) {
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
            float r0 = patternMatchVariance(r1, r2, r3)
            goto L4
    }

    public static float YuPhbucteRsDHZNs(int[] r1, int[] r2, float r3) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            float r0 = patternMatchVariance(r1, r2, r3)
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    @Override // com.google.zxing.oned.OneDReader
    public com.google.zxing.Result DecodeRow(int r10, com.google.zxing.common.BitArray r11, java.util.Dictionary<com.google.zxing.DecodeHintType, ?> r12) throws com.google.zxing.FormatException, com.google.zxing.NotFoundException {
            r9 = this;
            goto L145
        L4:
            r0.<init>(r9, r10)
            goto L1ab
        Lb:
            int r3 = pnPDhGsBkJgCdQtb(r11)
            goto L113
        L13:
            r9 = r9[r4]
            goto L89
        L19:
            goto L156
        L1b:
            goto L155
        L1f:
            r12 = r2
            goto L29
        L24:
            r6 = r4
            goto L138
        L29:
            goto Lca
        L2b:
            goto Ld4
        L2f:
            r3 = r0[r2]
            goto L167
        L35:
            if (r3 > r7) goto L3a
            goto L18b
        L3a:
            goto L18a
        L3e:
            com.google.zxing.FormatException r9 = PiIUAjeRfZYUCvsz()
            goto L10e
        L46:
            com.google.zxing.ResultPoint r0 = new com.google.zxing.ResultPoint
            goto L13
        L4c:
            int[] r0 = KgapgqxeFaOpZoHh(r9, r11)
            goto L12b
        L54:
            com.google.zxing.ResultPoint r5 = new com.google.zxing.ResultPoint
            goto Lb4
        L5a:
            int[] r12 = com.google.zxing.oned.ITFReader.DEFAULT_ALLOWED_LENGTHS
        L5c:
            goto Lb
        L60:
            r3[r4] = r5
            goto L46
        L66:
            if (r12 == 0) goto L6b
            goto L5c
        L6b:
            goto L5a
        L6f:
            goto L10f
        L72:
            goto L4c
        L76:
            int[] r12 = (int[]) r12
            goto L19
        L7c:
            java.lang.string r11 = ufNKSRaydDvsyUMb(r1)
            goto Laf
        L84:
            r2 = 1
            goto L2f
        L89:
            float r9 = (float) r9
            goto L4
        L8e:
            r0 = 3
            goto L19d
        L95:
            r3 = 2
            goto Lff
        L9a:
            if (r12 != 0) goto L9f
            goto L1b2
        L9f:
            goto L17e
        La3:
            int[] r12 = (int[]) r12
            goto L76
        La9:
            r8 = r12[r6]
            goto L175
        Laf:
            r1 = 0
            goto L16c
        Lb4:
            r0 = r0[r2]
            goto Ldd
        Lba:
            int r6 = r6 + 1
            goto L133
        Lc0:
            goto L148
        Lc3:
            com.google.zxing.ResultMetadataType r9 = com.google.zxing.ResultMetadataType.SYMBOLOGY_IDENTIFIER
            goto Led
        Lc9:
            r12 = r4
        Lca:
            goto L1b6
        Lce:
            java.lang.stringBuilder r1 = new java.lang.stringBuilder
            goto L11f
        Ld4:
            if (r8 > r7) goto Ld9
            goto Le3
        Ld9:
            goto Le2
        Ldd:
            float r0 = (float) r0
            goto Lfa
        Le2:
            r7 = r8
        Le3:
            goto Lba
        Le7:
            int r0 = r0 + r1
            goto L1bf
        Led:
            java.lang.string r10 = "]I0"
            goto L160
        Lf3:
            EBzKRHcZSdkOOALe(r11, r3, r5, r1)
            goto L7c
        Lfa:
            float r10 = (float) r10
            goto L1a4
        Lff:
            com.google.zxing.ResultPoint[] r3 = new com.google.zxing.ResultPoint[r3]
            goto L54
        L105:
            if (r0 <= 0) goto L10a
            goto L72
        L10a:
            goto L6f
        L10e:
            throw r9
        L10f:
            goto L18f
        L113:
            int r5 = r12.length
            goto L24
        L118:
            r12.<init>(r11, r1, r3, r9)
            goto Lc3
        L11f:
            r2 = 20
            goto L196
        L125:
            r5 = r9[r4]
            goto Lf3
        L12b:
            int[] r9 = heLvVFjqIFFMVpbI(r9, r11)
            goto Lce
        L133:
            goto L139
        L134:
            goto Lc9
        L138:
            r7 = r6
        L139:
            goto L14c
        L13d:
            java.lang.object r12 = giJqeLNUEJgTCdbC(r12, r3)
            goto La3
        L145:
            goto L192
        L148:
            goto L8e
        L14c:
            if (r6 < r5) goto L151
            goto L134
        L151:
            goto La9
        L155:
            r12 = r1
        L156:
            goto L66
        L15a:
            com.google.zxing.BarcodeFormat r9 = com.google.zxing.BarcodeFormat.ITF
            goto L118
        L160:
            rfqgxAcjggWOjEnX(r12, r9, r10)
            goto L1b1
        L167:
            r4 = 0
            goto L125
        L16c:
            if (r12 != 0) goto L171
            goto L1b
        L171:
            goto L184
        L175:
            if (r3 == r8) goto L17a
            goto L2b
        L17a:
            goto L1f
        L17e:
            com.google.zxing.Result r12 = new com.google.zxing.Result
            goto L95
        L184:
            com.google.zxing.DecodeHintType r3 = com.google.zxing.DecodeHintType.ALLOWED_LENGTHS
            goto L13d
        L18a:
            r12 = r2
        L18b:
            goto L9a
        L18f:
            goto L72
        L192:
            goto Lc0
        L196:
            r1.<init>(r2)
            goto L84
        L19d:
            r1 = 14
            goto Le7
        L1a4:
            r5.<init>(r0, r10)
            goto L60
        L1ab:
            r3[r2] = r0
            goto L15a
        L1b1:
            return r12
        L1b2:
            goto L3e
        L1b6:
            if (r12 == 0) goto L1bb
            goto L18b
        L1bb:
            goto L35
        L1bf:
            int r0 = r0 % r1
            goto L105
    }
}

