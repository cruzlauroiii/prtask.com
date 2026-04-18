namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: com.mastercard.terminalsdk.internal.c */
/* JADX INFO: loaded from: classes2.dex */
public class C2198c {
    /* JADX INFO: renamed from: a */
    private static long M437a(long r2, long r4, int r6, int r7) {
            goto L18
        L4:
            long r0 = r2 >> r6
            goto L24
        La:
            long r4 = r4 + r2
            goto L1f
        Lf:
            if (r0 <= 0) goto L14
            goto L5a
        L14:
            goto L57
        L18:
            goto L43
        L1b:
            goto L34
        L1f:
            return r4
        L20:
            goto L40
        L24:
            long r2 = r2 ^ r0
            goto L29
        L29:
            long r4 = r4 * r2
            goto L3b
        L2e:
            int r0 = r0 % r1
            goto Lf
        L34:
            r0 = 24
            goto L50
        L3b:
            long r2 = (long) r7
            goto La
        L40:
            goto L5a
        L43:
            goto L4d
        L47:
            int r0 = r0 + r1
            goto L2e
        L4d:
            goto L1b
        L50:
            r1 = 25
            goto L47
        L57:
            goto L20
        L5a:
            goto L4
    }

    /* JADX INFO: renamed from: a */
    static long[] M438a(int r6, int r7) {
            goto Lb3
        L4:
            int r0 = r0 % r1
            goto L9d
        La:
            long r6 = r6 & r4
            goto L77
        Lf:
            return r1
        L10:
            goto L7c
        L14:
            goto L10
        L17:
            goto L72
        L1b:
            r2 = 0
            goto L32
        L20:
            r4 = 4294967295(0xffffffff, double:2.1219957905E-314)
            goto L92
        L29:
            goto Lb6
        L2c:
            int r7 = r6 + (-1)
            goto L97
        L32:
            r1[r2] = r6
            goto L8d
        L38:
            int r0 = r0 + r1
            goto L4
        L3e:
            r6 = 32
            goto La6
        L44:
            r1 = 22
            goto L38
        L4b:
            r1[r6] = r2
            goto L67
        L51:
            if (r6 < r0) goto L56
            goto L84
        L56:
            goto L2c
        L5a:
            long[] r1 = new long[r0]
            goto L88
        L60:
            r0 = 7
            goto L44
        L67:
            int r6 = r6 + 1
            goto L83
        L6d:
            long r6 = (long) r7
            goto La
        L72:
            r0 = 4
            goto L5a
        L77:
            long r6 = r6 | r2
            goto L1b
        L7c:
            goto L17
        L7f:
            goto L29
        L83:
            goto L8e
        L84:
            goto Lf
        L88:
            long r2 = (long) r6
            goto L20
        L8d:
            r6 = 1
        L8e:
            goto L51
        L92:
            long r2 = r2 & r4
            goto L3e
        L97:
            r2 = r1[r7]
            goto Lab
        L9d:
            if (r0 <= 0) goto La2
            goto L17
        La2:
            goto L14
        La6:
            long r2 = r2 << r6
            goto L6d
        Lab:
            long r2 = jTOBEiDQDeDnBrbb(r2, r6)
            goto L4b
        Lb3:
            goto L7f
        Lb6:
            goto L60
    }

    public static long BAFnTilCkjQKCvMc(long r2, long r4, int r6, int r7) {
            goto L13
        L4:
            if (r0 <= 0) goto L9
            goto L2f
        L9:
            goto L2c
        Ld:
            int r0 = r0 % r1
            goto L4
        L13:
            goto L48
        L16:
            goto L1f
        L1a:
            return r0
        L1b:
            goto L45
        L1f:
            r0 = 11
            goto L3b
        L26:
            int r0 = r0 + r1
            goto Ld
        L2c:
            goto L1b
        L2f:
            goto L33
        L33:
            long r0 = m437a(r2, r4, r6, r7)
            goto L1a
        L3b:
            r1 = 28
            goto L26
        L42:
            goto L16
        L45:
            goto L2f
        L48:
            goto L42
    }

    /* JADX INFO: renamed from: c */
    private static long M439c(long r6, int r8) {
            goto L25
        L4:
            goto L14
        L7:
            goto L52
        Lb:
            int r0 = r0 + r1
            goto L4c
        L11:
            goto L48
        L14:
            goto L31
        L18:
            r0 = 7
            goto L40
        L1f:
            r4 = 30
            goto L55
        L25:
            goto L7
        L28:
            goto L18
        L2c:
            r5 = r8
            goto L38
        L31:
            r2 = 1812433253(0x6c078965, double:8.954610057E-315)
            goto L1f
        L38:
            long r6 = bAFnTilCkjQKCvMc(r0, r2, r4, r5)
            goto L47
        L40:
            r1 = 14
            goto Lb
        L47:
            return r6
        L48:
            goto L4
        L4c:
            int r0 = r0 % r1
            goto L5a
        L52:
            goto L28
        L55:
            r0 = r6
            goto L2c
        L5a:
            if (r0 <= 0) goto L5f
            goto L14
        L5f:
            goto L11
    }

    /* JADX INFO: renamed from: e */
    static void M440e(long[] r10, long[] r11, int r12) {
            goto L12
        L4:
            r0 = r10[r0]
            goto L94
        La:
            long r0 = r0 % r6
            goto L35
        Lf:
            goto L15
        L12:
            goto L6b
        L15:
            goto L5a
        L19:
            r4 = r11[r4]
            goto L25
        L1f:
            int r0 = r0 + r1
            goto La1
        L25:
            long r0 = r0 + r4
            goto L47
        L2a:
            int r4 = r4 % 4
            goto L19
        L30:
            return
        L31:
            goto L68
        L35:
            int r12 = r12 + 3
            goto L9b
        L3b:
            long r8 = r8 * r2
            goto La7
        L40:
            r1 = 19
            goto L1f
        L47:
            r6 = 2147483647(0x7fffffff, double:1.060997895E-314)
            goto La
        L4e:
            r11[r12] = r8
            goto L6f
        L54:
            int r0 = r12 % 4
            goto L4
        L5a:
            r0 = 1
            goto L40
        L61:
            goto L31
        L64:
            goto L54
        L68:
            goto L64
        L6b:
            goto Lf
        L6f:
            r10[r12] = r0
            goto L30
        L75:
            int r4 = r12 + 2
            goto L2a
        L7b:
            if (r0 <= 0) goto L80
            goto L64
        L80:
            goto L61
        L84:
            r8 = r10[r12]
            goto L3b
        L8a:
            long r8 = r8 / r6
            goto L4e
        L8f:
            long r0 = r0 * r2
            goto L75
        L94:
            r2 = 2147483085(0x7ffffdcd, double:1.0609976173E-314)
            goto L8f
        L9b:
            int r12 = r12 % 4
            goto L84
        La1:
            int r0 = r0 % r1
            goto L7b
        La7:
            long r8 = r8 + r4
            goto L8a
    }

    public static long JTOBEiDQDeDnBrbb(long r2, int r4) {
            goto L45
        L4:
            int r0 = r0 + r1
            goto L19
        La:
            long r0 = m439c(r2, r4)
            goto L1f
        L12:
            goto L41
        L15:
            goto L32
        L19:
            int r0 = r0 % r1
            goto L35
        L1f:
            return r0
        L20:
            goto L12
        L24:
            r0 = 21
            goto L2b
        L2b:
            r1 = 13
            goto L4
        L32:
            goto L48
        L35:
            if (r0 <= 0) goto L3a
            goto L41
        L3a:
            goto L3e
        L3e:
            goto L20
        L41:
            goto La
        L45:
            goto L15
        L48:
            goto L24
    }
}

