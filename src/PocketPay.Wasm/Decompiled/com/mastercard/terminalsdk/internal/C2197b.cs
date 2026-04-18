namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: com.mastercard.terminalsdk.internal.b */
/* JADX INFO: loaded from: classes2.dex */
public class C2197b {
    public static void NpxZHzknPvlQcZsE(int[] r0) {
            goto L13
        L4:
            return
        L5:
            goto L9
        L9:
            goto L16
        Lc:
            m435b(r0)
            goto L4
        L13:
            goto L5
        L16:
            goto Lc
    }

    public static int UTfvkLOJxCTNOyrO(int r1, int[][] r2) {
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
            int r0 = m436d(r1, r2)
            goto L4
    }

    public static void ZNqCTVfAtkTGESKt(int[] r0) {
            goto L13
        L4:
            goto L16
        L7:
            m435b(r0)
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

    /* JADX INFO: renamed from: b */
    public static void M434b(int r4, int r5, bool r6, int r7, int[] r8, int[][] r9, int[] r10) {
            goto L50
        L4:
            r7 = r8[r7]
            goto Ldc
        La:
            goto Lbb
        Lc:
            goto Lca
        L10:
            int r7 = r7 - r9
            goto L4
        L15:
            r4 = r4 ^ r7
            goto L88
        L1a:
            goto L45
        L1d:
            goto L3b
        L21:
            r9 = 1
            goto L10
        L26:
            goto L53
        L29:
            if (r6 == 0) goto L2e
            goto L4c
        L2e:
            goto L49
        L32:
            if (r1 < r7) goto L37
            goto Lc
        L37:
            goto Lb4
        L3b:
            if (r6 == 0) goto L40
            goto L9d
        L40:
            goto L9a
        L44:
            return
        L45:
            goto La7
        L49:
            NpxZHzknPvlQcZsE(r8)
        L4c:
            goto L6e
        L50:
            goto Laa
        L53:
            goto L93
        L57:
            r1 = 25
            goto Lc4
        L5e:
            r5 = r5 ^ r2
            goto L63
        L63:
            int r1 = r1 + 1
            goto Ld7
        L69:
            r0 = 0
            goto Lba
        L6e:
            r10[r0] = r5
            goto L79
        L74:
            r5 = r4
            goto Lbf
        L79:
            r10[r9] = r4
            goto L44
        L7f:
            if (r0 <= 0) goto L84
            goto L1d
        L84:
            goto L1a
        L88:
            int r7 = r8.length
            goto L21
        L8d:
            int r0 = r0 % r1
            goto L7f
        L93:
            r0 = 14
            goto L57
        L9a:
            ZNqCTVfAtkTGESKt(r8)
        L9d:
            goto L69
        La1:
            int r7 = r7 + (-2)
            goto Lae
        La7:
            goto L1d
        Laa:
            goto L26
        Lae:
            r7 = r8[r7]
            goto L15
        Lb4:
            r2 = r8[r1]
            goto Le1
        Lba:
            r1 = r0
        Lbb:
            goto L32
        Lbf:
            r4 = r3
            goto La
        Lc4:
            int r0 = r0 + r1
            goto L8d
        Lca:
            int r7 = r8.length
            goto La1
        Lcf:
            int r2 = UTfvkLOJxCTNOyrO(r4, r9)
            goto L5e
        Ld7:
            r3 = r5
            goto L74
        Ldc:
            r5 = r5 ^ r7
            goto L29
        Le1:
            r4 = r4 ^ r2
            goto Lcf
    }

    /* JADX INFO: renamed from: b */
    private static void M435b(int[] r3) {
            goto L6f
        L4:
            r3[r0] = r2
            goto L3b
        La:
            r1 = r3[r0]
            goto L48
        L10:
            r1 = 17
            goto L35
        L17:
            if (r0 <= 0) goto L1c
            goto L7f
        L1c:
            goto L7c
        L20:
            if (r0 < r1) goto L25
            goto L60
        L25:
            goto La
        L29:
            int r1 = r3.length
            goto L94
        L2e:
            r0 = 27
            goto L10
        L35:
            int r0 = r0 + r1
            goto L9a
        L3b:
            int r2 = r3.length
            goto L6a
        L40:
            goto L72
        L43:
            return
        L44:
            goto L4d
        L48:
            int r2 = r3.length
            goto L54
        L4d:
            goto L7f
        L50:
            goto L40
        L54:
            int r2 = r2 - r0
            goto L64
        L59:
            int r0 = r0 + 1
            goto L5f
        L5f:
            goto L8a
        L60:
            goto L43
        L64:
            int r2 = r2 + (-1)
            goto L76
        L6a:
            int r2 = r2 - r0
            goto L83
        L6f:
            goto L50
        L72:
            goto L2e
        L76:
            r2 = r3[r2]
            goto L4
        L7c:
            goto L44
        L7f:
            goto L89
        L83:
            int r2 = r2 + (-1)
            goto L8e
        L89:
            r0 = 0
        L8a:
            goto L29
        L8e:
            r3[r2] = r1
            goto L59
        L94:
            int r1 = r1 / 2
            goto L20
        L9a:
            int r0 = r0 % r1
            goto L17
    }

    /* JADX INFO: renamed from: d */
    private static int M436d(int r4, int[][] r5) {
            goto L85
        L4:
            r1 = 2
            goto Lf
        L9:
            r5 = r5[r1]
            goto L7f
        Lf:
            r1 = r5[r1]
            goto L30
        L15:
            goto L2c
        L18:
            goto L99
        L1c:
            r2 = r2 & 255(0xff, float:3.57E-43)
            goto La4
        L22:
            int r0 = r0 + r1
            goto Laf
        L28:
            goto L88
        L2b:
            return r0
        L2c:
            goto L57
        L30:
            r1 = r1[r2]
            goto L42
        L36:
            r1 = r1 & 255(0xff, float:3.57E-43)
            goto L93
        L3c:
            r3 = r5[r3]
            goto L73
        L42:
            r0 = r0 ^ r1
            goto L64
        L47:
            r0 = 4
            goto L8c
        L4e:
            if (r0 <= 0) goto L53
            goto L18
        L53:
            goto L15
        L57:
            goto L18
        L5a:
            goto L28
        L5e:
            r0 = r3[r0]
            goto L9f
        L64:
            r1 = 3
            goto L9
        L69:
            int r0 = r0 + r1
            goto L4
        L6e:
            int r0 = r0 + r4
            goto L2b
        L73:
            r1 = r3[r1]
            goto L69
        L79:
            int r1 = r4 >>> 16
            goto L36
        L7f:
            r4 = r5[r4]
            goto L6e
        L85:
            goto L5a
        L88:
            goto L47
        L8c:
            r1 = 10
            goto L22
        L93:
            int r2 = r4 >>> 8
            goto L1c
        L99:
            int r0 = r4 >>> 24
            goto L79
        L9f:
            r3 = 1
            goto L3c
        La4:
            r4 = r4 & 255(0xff, float:3.57E-43)
            goto Laa
        Laa:
            r3 = 0
            goto Lb5
        Laf:
            int r0 = r0 % r1
            goto L4e
        Lb5:
            r3 = r5[r3]
            goto L5e
    }
}

