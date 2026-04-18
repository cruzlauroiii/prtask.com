namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: com.mastercard.terminalsdk.internal.j */
/* JADX INFO: loaded from: classes2.dex */
public class C2205j {
    public static void BOmhQvPMXMkkXPsm(int[] r0) {
            goto L7
        L4:
            goto La
        L7:
            goto L16
        La:
            goto Le
        Le:
            m463b(r0)
            goto L15
        L15:
            return
        L16:
            goto L4
    }

    public static void DMuGNnpNZDLPUnWT(int[] r0) {
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
            m463b(r0)
            goto Lb
        L17:
            goto L7
    }

    public static int WCZigPugcGrjPwXb(int r1) {
            goto L11
        L4:
            int r0 = m464c(r1)
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

    /* JADX INFO: renamed from: b */
    public static void M463b(int[] r3) {
            goto L2f
        L4:
            r3[r2] = r1
            goto L1c
        La:
            int r2 = r2 + (-1)
            goto L29
        L10:
            goto L51
        L13:
            goto L67
        L17:
            int r2 = r3.length
            goto L5b
        L1c:
            int r0 = r0 + 1
            goto L9b
        L22:
            r1 = 8
            goto L3f
        L29:
            r2 = r3[r2]
            goto L39
        L2f:
            goto L8e
        L32:
            goto L60
        L36:
            goto L32
        L39:
            r3[r0] = r2
            goto L80
        L3f:
            int r0 = r0 + r1
            goto L6c
        L45:
            int r2 = r2 - r0
            goto L85
        L4a:
            r1 = r3[r0]
            goto L17
        L50:
            return
        L51:
            goto L8b
        L55:
            int r1 = r1 / 2
            goto L72
        L5b:
            int r2 = r2 - r0
            goto La
        L60:
            r0 = 25
            goto L22
        L67:
            r0 = 0
        L68:
            goto L7b
        L6c:
            int r0 = r0 % r1
            goto L92
        L72:
            if (r0 < r1) goto L77
            goto L9c
        L77:
            goto L4a
        L7b:
            int r1 = r3.length
            goto L55
        L80:
            int r2 = r3.length
            goto L45
        L85:
            int r2 = r2 + (-1)
            goto L4
        L8b:
            goto L13
        L8e:
            goto L36
        L92:
            if (r0 <= 0) goto L97
            goto L13
        L97:
            goto L10
        L9b:
            goto L68
        L9c:
            goto L50
    }

    /* JADX INFO: renamed from: c */
    public static int M464c(int r6) {
            goto L41
        L4:
            int[][] r4 = r0.f453e
            goto L2a
        La:
            int[][] r0 = r0.f453e
            goto L7c
        L10:
            r4 = r4[r5]
            goto Lb9
        L16:
            r0 = 10
            goto L75
        L1d:
            goto L49
        L20:
            goto Lb3
        L24:
            r1 = r4[r1]
            goto Ld3
        L2a:
            r5 = 0
            goto L9e
        L2f:
            goto L20
        L32:
            goto Lc5
        L36:
            r6 = r0[r6]
            goto L64
        L3c:
            r1 = r1 ^ r2
            goto La
        L41:
            goto L32
        L44:
            goto L16
        L48:
            return r1
        L49:
            goto L2f
        L4d:
            r2 = r2[r3]
            goto L3c
        L53:
            r6 = r6 & 255(0xff, float:3.57E-43)
            goto L4
        L59:
            r5 = 1
            goto L10
        L5e:
            int[][] r2 = r0.f453e
            goto Lce
        L64:
            int r1 = r1 + r6
            goto L48
        L69:
            r2 = r2 & 255(0xff, float:3.57E-43)
            goto Lc8
        L6f:
            r3 = r3 & 255(0xff, float:3.57E-43)
            goto L53
        L75:
            r1 = 21
            goto L92
        L7c:
            r2 = 3
            goto L98
        L81:
            int r1 = r6 >>> 24
            goto L87
        L87:
            int r2 = r6 >>> 16
            goto L69
        L8d:
            int r1 = r1 + r2
            goto L5e
        L92:
            int r0 = r0 + r1
            goto Lad
        L98:
            r0 = r0[r2]
            goto L36
        L9e:
            r4 = r4[r5]
            goto L24
        La4:
            if (r0 <= 0) goto La9
            goto L20
        La9:
            goto L1d
        Lad:
            int r0 = r0 % r1
            goto La4
        Lb3:
            com.mastercard.terminalsdk.internal.e r0 = com.mastercard.terminalsdk.internal.C2200e.f450c
            goto L81
        Lb9:
            r2 = r4[r2]
            goto L8d
        Lbf:
            r2 = r2[r4]
            goto L4d
        Lc5:
            goto L44
        Lc8:
            int r3 = r6 >>> 8
            goto L6f
        Lce:
            r4 = 2
            goto Lbf
        Ld3:
            int[][] r4 = r0.f453e
            goto L59
    }

    /* JADX INFO: renamed from: c */
    public static int[] M465c(char[] r10, int[] r11, bool r12) {
            goto L12f
        L4:
            r2 = 16
            goto L37
        La:
            r1 = 10
            goto L101
        L11:
            return r5
        L12:
            goto L117
        L16:
            goto L132
        L19:
            r9 = r5
            goto L10d
        L1e:
            char r0 = (char) r2
            goto L5b
        L23:
            if (r12 == 0) goto L28
            goto L3f
        L28:
            goto L3c
        L2c:
            char r7 = r10[r6]
            goto L4c
        L32:
            r7 = r0
        L33:
            goto L43
        L37:
            int r1 = r1 << r2
            goto Ld2
        L3c:
            DMuGNnpNZDLPUnWT(r11)
        L3f:
            goto L11
        L43:
            if (r7 < r2) goto L48
            goto Lb9
        L48:
            goto L6c
        L4c:
            int r5 = r5 + r7
            goto Lbd
        L51:
            r0 = 0
            goto L136
        L56:
            r2 = r2 ^ r5
            goto L98
        L5b:
            r10[r3] = r0
            goto Lb1
        L61:
            r1 = r9
            goto Lb7
        L66:
            r10[r6] = r0
            goto L23
        L6c:
            r8 = r11[r7]
            goto L13c
        L72:
            r0 = 32
            goto La
        L79:
            r2 = r11[r2]
            goto L56
        L7f:
            r1 = r1 ^ r2
            goto La0
        L84:
            int r5 = r5 << r2
            goto La6
        L89:
            if (r0 <= 0) goto L8e
            goto L121
        L8e:
            goto L11e
        L92:
            r10[r0] = r7
            goto L1e
        L98:
            int[] r5 = new int[]{r2, r1}
            goto Lfb
        La0:
            r2 = 17
            goto L79
        La6:
            r6 = 3
            goto L2c
        Lab:
            char r4 = r10[r3]
            goto Lf6
        Lb1:
            int r0 = r1 >>> 16
            goto Le3
        Lb7:
            goto L33
        Lb9:
            goto L141
        Lbd:
            if (r12 == 0) goto Lc2
            goto Ldf
        Lc2:
            goto Ldc
        Lc6:
            char r5 = r10[r4]
            goto L84
        Lcc:
            r10[r4] = r0
            goto L12a
        Ld2:
            r3 = 1
            goto Lab
        Ld7:
            r5 = r5 ^ r8
            goto L107
        Ldc:
            BOmhQvPMXMkkXPsm(r11)
        Ldf:
            goto L32
        Le3:
            char r0 = (char) r0
            goto Lcc
        Le8:
            int r0 = r0 % r1
            goto L89
        Lee:
            int r8 = WCZigPugcGrjPwXb(r1)
            goto Ld7
        Lf6:
            int r1 = r1 + r4
            goto L125
        Lfb:
            int r7 = r2 >>> 16
            goto L112
        L101:
            int r0 = r0 + r1
            goto Le8
        L107:
            int r7 = r7 + 1
            goto L19
        L10d:
            r5 = r1
            goto L61
        L112:
            char r7 = (char) r7
            goto L92
        L117:
            goto L121
        L11a:
            goto L16
        L11e:
            goto L12
        L121:
            goto L51
        L125:
            r4 = 2
            goto Lc6
        L12a:
            char r0 = (char) r1
            goto L66
        L12f:
            goto L11a
        L132:
            goto L72
        L136:
            char r1 = r10[r0]
            goto L4
        L13c:
            r1 = r1 ^ r8
            goto Lee
        L141:
            r2 = r11[r2]
            goto L7f
    }
}

