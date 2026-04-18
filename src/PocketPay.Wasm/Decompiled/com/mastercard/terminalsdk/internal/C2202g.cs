namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: com.mastercard.terminalsdk.internal.g */
/* JADX INFO: loaded from: classes2.dex */
public class C2202g : java.io.FilterStream {

    /* JADX INFO: renamed from: a */
    private static readonly int[] f454a = null;

    /* JADX INFO: renamed from: b */
    private static readonly int[] f455b = null;

    /* JADX INFO: renamed from: c */
    private static readonly int[] f456c = null;

    /* JADX INFO: renamed from: d */
    private static readonly int[] f457d = null;

    /* JADX INFO: renamed from: e */
    private static readonly byte[] f458e = null;

    /* JADX INFO: renamed from: f */
    private readonly int[] f459f;

    /* JADX INFO: renamed from: g */
    private readonly int[] f460g;

    /* JADX INFO: renamed from: h */
    private readonly byte[][] f461h;

    /* JADX INFO: renamed from: i */
    private readonly int f462i;

    /* JADX INFO: renamed from: j */
    private readonly byte[] f463j;

    /* JADX INFO: renamed from: l */
    private int f464l;

    /* JADX INFO: renamed from: m */
    private int f465m;

    /* JADX INFO: renamed from: n */
    private readonly byte[] f466n;

    /* JADX INFO: renamed from: o */
    private int f467o;

    static {
            goto L16
        L4:
            com.mastercard.terminalsdk.internal.C2202g.f457d = r0
            goto L34
        La:
            int[] r0 = com.mastercard.terminalsdk.internal.C2203h.f472e
            goto L3a
        L10:
            com.mastercard.terminalsdk.internal.C2202g.f454a = r0
            goto L1d
        L16:
            goto L1e
        L19:
            goto L49
        L1d:
            return
        L1e:
            goto L40
        L22:
            com.mastercard.terminalsdk.internal.C2202g.f458e = r0
            goto L2e
        L28:
            com.mastercard.terminalsdk.internal.C2202g.f455b = r0
            goto La
        L2e:
            int[] r0 = com.mastercard.terminalsdk.internal.C2203h.f468a
            goto L4
        L34:
            int[] r0 = com.mastercard.terminalsdk.internal.C2203h.f470c
            goto L28
        L3a:
            com.mastercard.terminalsdk.internal.C2202g.f456c = r0
            goto L43
        L40:
            goto L19
        L43:
            int[] r0 = com.mastercard.terminalsdk.internal.C2203h.f474i
            goto L10
        L49:
            byte[] r0 = com.mastercard.terminalsdk.internal.C2203h.f469b
            goto L22
    }

    public C2202g(java.io.Stream r2, int r3, byte[] r4, byte[][] r5) {
            r1 = this;
            goto L6d
        L4:
            r2 = 4
            goto L9
        L9:
            int[] r2 = new int[r2]
            goto L35
        Lf:
            byte[] r0 = new byte[r2]
            goto L5c
        L15:
            byte[][] r2 = ZVPSNbTrXfwleYOf(r1, r5)
            goto L1d
        L1d:
            r1.f461h = r2
            goto L62
        L23:
            r1.f464l = r2
            goto L29
        L29:
            r1.f465m = r2
            goto L50
        L2f:
            r1.f467o = r0
            goto L23
        L35:
            r1.f459f = r2
            goto L74
        L3b:
            r1.f463j = r0
            goto Lf
        L41:
            r0 = 2147483647(0x7fffffff, float:NaN)
            goto L2f
        L48:
            int[] r2 = ogmSwmCEKCwhCbVR(r4, r3)
            goto L67
        L50:
            r1.f462i = r3
            goto L48
        L56:
            byte[] r0 = new byte[r2]
            goto L3b
        L5c:
            r1.f466n = r0
            goto L41
        L62:
            return
        L63:
            goto L81
        L67:
            r1.f460g = r2
            goto L15
        L6d:
            goto L63
        L70:
            goto L7a
        L74:
            r2 = 16
            goto L56
        L7a:
            r1.<init>(r2)
            goto L4
        L81:
            goto L70
    }

    public static int ColceHrorxaEAOfr(java.io.Stream r1) {
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

    public static void DhlvimkoeRVJtWvN(com.mastercard.terminalsdk.internal.C2202g r0, byte[] r1, int r2, byte[] r3, int r4) {
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
            r0.m450c(r1, r2, r3, r4)
            goto Lb
        L17:
            goto L7
    }

    public static int JnJrQmRCmqojLVrk(com.mastercard.terminalsdk.internal.C2202g r1) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            int r0 = r1.m448a()
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static int MnRUesIHuhSOvhOR(com.mastercard.terminalsdk.internal.C2202g r1) {
            goto L14
        L4:
            goto L17
        L7:
            int r0 = r1.m448a()
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

    public static byte[][] ZVPSNbTrXfwleYOf(com.mastercard.terminalsdk.internal.C2202g r1, byte[][] r2) {
            goto Lf
        L4:
            byte[][] r0 = r1.m449a(r2)
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

    /* JADX INFO: renamed from: a */
    private int M448a() throws java.io.IOException {
            r7 = this;
            goto Leb
        L4:
            r7.<init>(r0)
            goto L11f
        Lb:
            goto L7b
        Le:
            goto L101
        L12:
            if (r2 >= r1) goto L17
            goto Lb8
        L17:
            goto L28
        L1b:
            r0 = 15
            goto L58
        L22:
            java.io.Stream r0 = r7.in
            goto L12a
        L28:
            if (r2 >= r1) goto L2d
            goto L42
        L2d:
            goto L74
        L31:
            if (r0 == r1) goto L36
            goto L13a
        L36:
            goto L161
        L3a:
            java.lang.IllegalStateException r7 = new java.lang.IllegalStateException
            goto L4
        L40:
            goto L13a
        L42:
            goto L3a
        L46:
            int r0 = r7.f464l
            goto L119
        L4c:
            r1 = 2147483647(0x7fffffff, float:NaN)
            goto L6b
        L53:
            byte r3 = (byte) r2
            goto L150
        L58:
            r1 = 17
            goto Lc8
        L5f:
            int r7 = r7.f465m
            goto L7a
        L65:
            java.io.Stream r0 = r7.in
            goto Laf
        L6b:
            if (r0 == r1) goto L70
            goto Lc4
        L70:
            goto L65
        L74:
            byte[] r0 = r7.f463j
            goto La3
        L7a:
            return r7
        L7b:
            goto Lfa
        L7f:
            if (r2 >= 0) goto L84
            goto L120
        L84:
            goto Lb7
        L88:
            r2 = 15
            goto Lda
        L8e:
            r7.f467o = r0
            goto L170
        L94:
            r7.f465m = r1
            goto L40
        L9a:
            if (r0 <= 0) goto L9f
            goto Le
        L9f:
            goto Lb
        La3:
            byte[] r2 = r7.f466n
            goto L13e
        La9:
            int r6 = 16 - r2
            goto Lf2
        Laf:
            int r0 = zwoIBnbuAZSnxHtz(r0)
            goto Lc2
        Lb7:
            r2 = 1
        Lb8:
            goto Ld4
        Lbc:
            int r0 = r0 % r1
            goto L9a
        Lc2:
            r7.f467o = r0
        Lc4:
            goto L46
        Lc8:
            int r0 = r0 + r1
            goto Lbc
        Lce:
            r0[r4] = r3
            goto L15b
        Ld4:
            java.io.Stream r3 = r7.in
            goto L16a
        Lda:
            r0 = r0[r2]
            goto L124
        Le0:
            int r1 = r1 - r0
        Le1:
            goto L94
        Le5:
            java.lang.IllegalStateException r7 = new java.lang.IllegalStateException
            goto L132
        Leb:
            goto Lfd
        Lee:
            goto L1b
        Lf2:
            int r3 = zqrqKDgVRwPYIEUO(r3, r5, r2, r6)
            goto L107
        Lfa:
            goto Le
        Lfd:
            goto L167
        L101:
            int r0 = r7.f467o
            goto L4c
        L107:
            if (r3 > 0) goto L10c
            goto L17
        L10c:
            goto L14b
        L110:
            if (r0 < 0) goto L115
            goto Le1
        L115:
            goto L145
        L119:
            r1 = 16
            goto L31
        L11f:
            throw r7
        L120:
            goto Le5
        L124:
            r0 = r0 & 255(0xff, float:3.57E-43)
            goto Le0
        L12a:
            int r0 = ColceHrorxaEAOfr(r0)
            goto L8e
        L132:
            r7.<init>(r0)
            goto L139
        L139:
            throw r7
        L13a:
            goto L5f
        L13e:
            DhlvimkoeRVJtWvN(r7, r0, r4, r2, r4)
            goto L22
        L145:
            byte[] r0 = r7.f466n
            goto L88
        L14b:
            int r2 = r2 + r3
            goto L12
        L150:
            r4 = 0
            goto Lce
        L155:
            int r2 = r7.f467o
            goto L53
        L15b:
            java.lang.string r0 = "unexpected block size"
            goto L7f
        L161:
            byte[] r0 = r7.f463j
            goto L155
        L167:
            goto Lee
        L16a:
            byte[] r5 = r7.f463j
            goto La9
        L170:
            r7.f464l = r4
            goto L110
    }

    /* JADX INFO: renamed from: a */
    private byte[][] M449a(byte[][] r7) {
            r6 = this;
            goto L27
        L4:
            return r6
        L5:
            goto L66
        L9:
            r1 = r0
        La:
            goto L5a
        Le:
            if (r2 < r4) goto L13
            goto La5
        L13:
            goto L3f
        L17:
            goto La
        L18:
            goto L4
        L1c:
            int r4 = r3.length
            goto Le
        L21:
            r3 = r3[r2]
            goto L7c
        L27:
            goto L69
        L2a:
            goto L53
        L2e:
            byte[][] r6 = new byte[r6][]
            goto L93
        L34:
            r6[r1] = r2
            goto La9
        L3a:
            int r2 = r2.length
            goto Lae
        L3f:
            r4 = r6[r1]
            goto L21
        L45:
            int r6 = r7.length
            goto L2e
        L4a:
            if (r1 < r2) goto L4f
            goto L18
        L4f:
            goto L98
        L53:
            r0 = 10
            goto L5f
        L5a:
            int r2 = r7.length
            goto L4a
        L5f:
            r1 = 4
            goto L9e
        L66:
            goto Lc0
        L69:
            goto L6d
        L6d:
            goto L2a
        L70:
            int r2 = r2 + 1
            goto La4
        L76:
            r3 = r7[r1]
            goto L1c
        L7c:
            byte r5 = (byte) r2
            goto L8d
        L81:
            int r0 = r0 % r1
            goto Lb4
        L87:
            int r1 = r1 + 1
            goto L17
        L8d:
            r4[r3] = r5
            goto L70
        L93:
            r0 = 0
            goto L9
        L98:
            r2 = r7[r1]
            goto L3a
        L9e:
            int r0 = r0 + r1
            goto L81
        La4:
            goto Laa
        La5:
            goto L87
        La9:
            r2 = r0
        Laa:
            goto L76
        Lae:
            byte[] r2 = new byte[r2]
            goto L34
        Lb4:
            if (r0 <= 0) goto Lb9
            goto Lc0
        Lb9:
            goto Lbd
        Lbd:
            goto L5
        Lc0:
            goto L45
    }

    /* JADX INFO: renamed from: c */
    private void M450c(byte[] r22, int r23, byte[] r24, int r25) {
            r21 = this;
            goto L531
        L4:
            r7 = r7 ^ r8
            goto L579
        L9:
            r23 = r1
            goto L4a0
        Lf:
            int r2 = r23 + 9
            goto L3d
        L15:
            r10 = r5[r10]
            goto L525
        L1b:
            int r7 = r25 + 4
            goto L753
        L21:
            byte r6 = (byte) r6
            goto L810
        L26:
            goto L46a
        L29:
            goto L62e
        L2d:
            r10 = r10 ^ r11
            goto L690
        L32:
            r24[r3] = r10
            goto L628
        L38:
            r2 = r2 | r3
            goto L342
        L3d:
            r6 = r22[r6]
            goto L236
        L43:
            r10 = r4[r10]
            goto L549
        L49:
            r10 = r5[r10]
            goto L5a
        L4f:
            int r4 = r23 + 2
            goto L3e8
        L55:
            r4 = r4 ^ r11
            goto L85c
        L5a:
            r10 = r10 & 255(0xff, float:3.57E-43)
            goto L9f
        L60:
            r7 = r11[r7]
            goto L2c6
        L66:
            r6 = r22[r6]
            goto L86b
        L6c:
            r13 = r9[r4]
            goto L37e
        L72:
            int r2 = r23 + 5
            goto L5fc
        L78:
            byte r10 = (byte) r10
            goto L32
        L7d:
            int r7 = r7 << 8
            goto L3ee
        L83:
            int[] r5 = r0.f460g
            goto L118
        L89:
            int r6 = r6 >>> 8
            goto L828
        L8f:
            r10 = r10 ^ r11
            goto Lc2
        L94:
            r2 = r2 ^ r8
            goto L741
        L99:
            r4 = r4 & 255(0xff, float:3.57E-43)
            goto L5b2
        L9f:
            r10 = r4[r10]
            goto L8b1
        La5:
            r24[r25] = r7
            goto L452
        Lab:
            r9 = r9 ^ r10
            goto L845
        Lb0:
            r6 = r6 & 255(0xff, float:3.57E-43)
            goto L51f
        Lb6:
            r5 = r5 & 255(0xff, float:3.57E-43)
            goto Lbc
        Lbc:
            r5 = r11[r5]
            goto L655
        Lc2:
            byte r10 = (byte) r10
            goto L2d1
        Lc7:
            r1 = 5
            goto L390
        Lce:
            r24[r2] = r6
            goto L330
        Ld4:
            r2 = r22[r2]
            goto L717
        Lda:
            r9 = r0[r20]
            goto L171
        Le0:
            r10 = r5[r10]
            goto L573
        Le6:
            byte[][] r0 = r0.f461h
            goto L106
        Lec:
            int r3 = r25 + 9
            goto L7ce
        Lf2:
            int r7 = r16 >>> 8
            goto L7f8
        Lf8:
            if (r2 < r3) goto Lfd
            goto L4a8
        Lfd:
            goto L2ae
        L101:
            r3 = r3 ^ r7
            goto L7da
        L106:
            r6 = r0[r18]
            goto L14d
        L10c:
            r2 = r1[r23]
            goto L7d4
        L112:
            r17 = r4
            goto L61c
        L118:
            r16 = r5[r1]
            goto L7a6
        L11e:
            r6 = r4[r6]
            goto L6d2
        L124:
            r10 = r4[r10]
            goto L231
        L12a:
            r7 = r13[r22]
            goto L5a7
        L130:
            r2 = r1[r2]
            goto L50d
        L136:
            int r7 = r25 + 8
            goto L18e
        L13c:
            r7 = r5[r7]
            goto L617
        L142:
            r10 = r4[r10]
            goto L64f
        L148:
            r2 = r2 | r8
            goto L416
        L14d:
            r7 = r6[r18]
            goto L16b
        L153:
            r2 = r22[r2]
            goto L31e
        L159:
            r9 = r5[r9]
            goto L6c5
        L15f:
            r4 = r4 & 255(0xff, float:3.57E-43)
            goto L264
        L165:
            int r10 = r2 >>> 16
            goto Lab
        L16b:
            r7 = r5[r7]
            goto L17d
        L171:
            r10 = r9[r18]
            goto L209
        L177:
            r10 = r4[r10]
            goto L65a
        L17d:
            int r7 = r7 >>> 24
            goto L336
        L183:
            byte r10 = (byte) r10
            goto L252
        L188:
            r9 = r4[r9]
            goto L165
        L18e:
            r10 = r0[r17]
            goto L644
        L194:
            r6 = r20
            goto L4a6
        L19a:
            int r7 = r7 << 24
            goto L5c3
        L1a0:
            int r2 = r23 + 2
            goto L513
        L1a6:
            byte r3 = (byte) r3
            goto L622
        L1ab:
            r10 = r5[r10]
            goto L39c
        L1b1:
            r16 = r9[r5]
            goto L8c8
        L1b7:
            r7 = r7 & 255(0xff, float:3.57E-43)
            goto L7b6
        L1bd:
            int r10 = r10 >>> 24
            goto L75f
        L1c3:
            r6 = r6 ^ r7
            goto L422
        L1c8:
            r7 = r8[r7]
            goto L735
        L1ce:
            r16 = r3[r16]
            goto L7ec
        L1d4:
            r3 = r3 & 255(0xff, float:3.57E-43)
            goto L38
        L1da:
            r10 = r4[r10]
            goto L6de
        L1e0:
            r7 = r8[r7]
            goto L1b7
        L1e6:
            r6 = r12[r6]
            goto L3d7
        L1ec:
            r11 = r3[r11]
            goto L473
        L1f2:
            int r6 = r23 + 6
            goto L153
        L1f8:
            r1 = r1 ^ r7
            goto L318
        L1fd:
            int r3 = r25 + 11
            goto L446
        L203:
            r16 = r8[r16]
            goto L9
        L209:
            r10 = r5[r10]
            goto L484
        L20f:
            r10 = r8[r17]
            goto L366
        L215:
            int r3 = r25 + 3
            goto Lda
        L21b:
            r2 = r4
        L21c:
            goto L33c
        L220:
            byte r10 = (byte) r10
            goto L893
        L225:
            r24[r7] = r10
            goto L794
        L22b:
            int r2 = r23 + 1
            goto L2ba
        L231:
            r2 = r2 ^ r10
            goto L3d2
        L236:
            int r6 = r6 << 24
            goto L2b4
        L23c:
            r0 = r0 ^ r1
            goto L6a7
        L241:
            r24[r3] = r9
            goto L215
        L247:
            r1 = r1 ^ r7
            goto L561
        L24c:
            byte[][] r9 = r0.f461h
            goto L5f0
        L252:
            r24[r7] = r10
            goto L1b
        L258:
            r0 = r0[r22]
            goto L684
        L25e:
            r6 = r9[r22]
            goto L839
        L264:
            r2 = r2 | r4
            goto L5eb
        L269:
            int r6 = r23 + 8
            goto L765
        L26f:
            r6 = r6 ^ r7
            goto L6bf
        L274:
            int r7 = r7 >>> 16
            goto L5c9
        L27a:
            r10 = r10 & 255(0xff, float:3.57E-43)
            goto L124
        L280:
            r7 = r22[r7]
            goto L19a
        L286:
            r6 = r6 ^ r7
            goto L5e0
        L28b:
            r16 = r8[r16]
            goto L3ae
        L291:
            int r6 = r1 >>> 24
            goto L490
        L297:
            r2 = r2 | r7
            goto L3f3
        L29c:
            r7 = r8[r7]
            goto L634
        L2a2:
            int r2 = r23 + 3
            goto L590
        L2a8:
            r10 = r0[r20]
            goto L49
        L2ae:
            int[] r3 = com.mastercard.terminalsdk.internal.C2202g.f457d
            goto L666
        L2b4:
            int r7 = r23 + 10
            goto L81c
        L2ba:
            r3 = r22[r23]
            goto L862
        L2c0:
            r20 = r6
            goto L4b2
        L2c6:
            r1 = r1 ^ r7
            goto L80a
        L2cb:
            int r2 = r2 << 16
            goto L888
        L2d1:
            r24[r7] = r10
            goto L136
        L2d7:
            int r10 = r10 >>> 16
            goto L43a
        L2dd:
            int r2 = r2 + 1
            goto L678
        L2e3:
            r16 = r8[r16]
            goto L5cf
        L2e9:
            r11 = r8[r11]
            goto L4e0
        L2ef:
            r10 = r10 ^ r11
            goto L4fd
        L2f4:
            r9 = r9[r7]
            goto L1b1
        L2fa:
            int r0 = r0 % r1
            goto L60e
        L300:
            int r7 = r7 >>> 8
            goto L7e6
        L306:
            int r3 = r23 + 3
            goto L38a
        L30c:
            r4 = r4 & 255(0xff, float:3.57E-43)
            goto L77d
        L312:
            r20 = r6
            goto L729
        L318:
            r7 = r15[r20]
            goto L29c
        L31e:
            r2 = r2 & 255(0xff, float:3.57E-43)
            goto L7a0
        L324:
            r7 = r3[r4]
            goto L46e
        L32a:
            int r7 = r23 + 15
            goto L56d
        L330:
            int r2 = r25 + 15
            goto L25e
        L336:
            r7 = r4[r7]
            goto L66c
        L33c:
            int r3 = r0.f462i
            goto Lf8
        L342:
            int[] r3 = r0.f460g
            goto L508
        L348:
            r1[r4] = r2
            goto Lf
        L34e:
            r0 = r4[r0]
            goto L23c
        L354:
            r16 = r15[r17]
            goto L2e3
        L35a:
            r1 = r1 & 255(0xff, float:3.57E-43)
            goto L899
        L360:
            r23 = r1
            goto L112
        L366:
            r10 = r5[r10]
            goto L8d4
        L36c:
            r15 = r9[r6]
            goto L3c0
        L372:
            int r3 = r25 + 14
            goto L584
        L378:
            r3 = r3[r7]
            goto L45e
        L37e:
            r14 = r13[r5]
            goto L4b8
        L384:
            r2 = r2 & 255(0xff, float:3.57E-43)
            goto L4da
        L38a:
            r4 = r22[r4]
            goto L99
        L390:
            int r0 = r0 + r1
            goto L2fa
        L396:
            int r2 = r23 + 1
            goto L130
        L39c:
            int r10 = r10 >>> 8
            goto L700
        L3a2:
            r10 = r10 & 255(0xff, float:3.57E-43)
            goto L177
        L3a8:
            r8[r22] = r3
            goto L2dd
        L3ae:
            int r16 = r16 >>> 24
            goto L1ce
        L3b4:
            r7 = r14[r7]
            goto L1c3
        L3ba:
            r10 = r4[r10]
            goto L479
        L3c0:
            r16 = r15[r5]
            goto L4cf
        L3c6:
            int r7 = r25 + 10
            goto L410
        L3cc:
            int r4 = r4 << 24
            goto L1f2
        L3d2:
            byte r2 = (byte) r2
            goto L42e
        L3d7:
            r6 = r16 ^ r6
            goto L354
        L3dd:
            r3 = r3 ^ r7
            goto L706
        L3e2:
            r5 = r8[r16]
            goto Lb6
        L3e8:
            r2 = r22[r2]
            goto L384
        L3ee:
            r2 = r2 | r7
            goto L7f2
        L3f3:
            r7 = 3
            goto L378
        L3f8:
            int[] r14 = com.mastercard.terminalsdk.internal.C2202g.f456c
            goto L36c
        L3fe:
            r3 = r3[r7]
            goto L12a
        L404:
            r7 = r7 & 255(0xff, float:3.57E-43)
            goto L297
        L40a:
            r1[r5] = r2
            goto L72
        L410:
            r10 = r8[r20]
            goto L804
        L416:
            r7 = r22[r7]
            goto L404
        L41c:
            r7 = r7 & 255(0xff, float:3.57E-43)
            goto L60
        L422:
            r7 = r9[r17]
            goto L1e0
        L428:
            r10 = r4[r10]
            goto L8bc
        L42e:
            r24[r3] = r2
            goto L1a0
        L434:
            r10 = r5[r10]
            goto L660
        L43a:
            r10 = r10 & 255(0xff, float:3.57E-43)
            goto L3ba
        L440:
            int r6 = r6 >>> 16
            goto Lb0
        L446:
            r10 = r9[r20]
            goto Le0
        L44c:
            r5 = r18
            goto L194
        L452:
            int r7 = r25 + 2
            goto L68a
        L458:
            int r8 = r8 << 8
            goto L148
        L45e:
            r2 = r2 ^ r3
            goto L850
        L463:
            r10 = r10 & 255(0xff, float:3.57E-43)
            goto L43
        L469:
            return
        L46a:
            goto L6cb
        L46e:
            r2 = r2 ^ r7
            goto L348
        L473:
            int[] r12 = com.mastercard.terminalsdk.internal.C2202g.f455b
            goto L6c
        L479:
            int r11 = r2 >>> 16
            goto L64a
        L47f:
            r10 = r10 ^ r11
            goto L78
        L484:
            int r10 = r10 >>> 8
            goto L54f
        L48a:
            r3 = r4[r3]
            goto L291
        L490:
            r3 = r3 ^ r6
            goto L1a6
        L495:
            r2 = r2 | r4
            goto L58a
        L49a:
            r5 = r5[r7]
            goto L4d5
        L4a0:
            int r1 = r16 >>> 16
            goto L35a
        L4a6:
            goto L21c
        L4a8:
            goto L360
        L4ac:
            r24[r3] = r2
            goto L396
        L4b2:
            int r6 = r19 >>> 16
            goto L5e5
        L4b8:
            r14 = r8[r14]
            goto L71d
        L4be:
            r2 = r2 | r4
            goto L89f
        L4c3:
            r10 = r0[r18]
            goto L434
        L4c9:
            r6 = r6 & 255(0xff, float:3.57E-43)
            goto L5be
        L4cf:
            r16 = r8[r16]
            goto L6b2
        L4d5:
            r3 = r3 ^ r5
            goto L602
        L4da:
            int r2 = r2 << 16
            goto L712
        L4e0:
            int r11 = r11 >>> 24
            goto L1ec
        L4e6:
            int r6 = r23 + 11
            goto L6e3
        L4ec:
            r16 = r13[r20]
            goto L203
        L4f2:
            r7 = r10[r20]
            goto L608
        L4f8:
            r6 = r6 ^ r7
            goto L4f2
        L4fd:
            byte r10 = (byte) r10
            goto L5da
        L502:
            r0 = r0 & 255(0xff, float:3.57E-43)
            goto L34e
        L508:
            r5 = 0
            goto L7c2
        L50d:
            int r3 = r25 + 5
            goto L723
        L513:
            r2 = r1[r2]
            goto Lec
        L519:
            int r2 = r2 << 16
            goto L5a2
        L51f:
            r6 = r4[r6]
            goto L74d
        L525:
            int r10 = r10 >>> 24
            goto L428
        L52b:
            r6 = r5[r6]
            goto L440
        L531:
            goto L6ce
        L534:
            goto L6b8
        L538:
            r24[r3] = r2
            goto L2a2
        L53e:
            r19 = r8[r19]
            goto L2c0
        L544:
            r2 = r2 | r6
            goto L269
        L549:
            int r11 = r2 >>> 8
            goto L6e9
        L54f:
            r10 = r10 & 255(0xff, float:3.57E-43)
            goto L142
        L555:
            r8 = r8 & 255(0xff, float:3.57E-43)
            goto L458
        L55b:
            int r7 = r25 + 6
            goto L20f
        L561:
            r7 = r9[r20]
            goto L8a5
        L567:
            r7 = r8[r7]
            goto L777
        L56d:
            r8 = r22[r8]
            goto L555
        L573:
            int r10 = r10 >>> 8
            goto L463
        L579:
            byte r7 = (byte) r7
            goto La5
        L57e:
            r7 = r22
            goto L6a1
        L584:
            r6 = r8[r22]
            goto L52b
        L58a:
            int r4 = r23 + 4
            goto L7e0
        L590:
            r1 = r1[r2]
            goto L84a
        L596:
            int r2 = r23 + 13
            goto L280
        L59c:
            int r11 = r2 >>> 8
            goto L8f
        L5a2:
            r2 = r2 | r7
            goto L32a
        L5a7:
            r7 = r8[r7]
            goto L274
        L5ad:
            r2 = r2 ^ r6
            goto L40a
        L5b2:
            int r4 = r4 << 8
            goto L495
        L5b8:
            r14 = r12[r14]
            goto L7b1
        L5be:
            r2 = r2 | r6
            goto L87d
        L5c3:
            int r8 = r23 + 14
            goto Ld4
        L5c9:
            r7 = r7 & 255(0xff, float:3.57E-43)
            goto L82e
        L5cf:
            r22 = r7
            goto Lf2
        L5d5:
            r1 = 4
            goto L21b
        L5da:
            r24[r7] = r10
            goto L3c6
        L5e0:
            byte r6 = (byte) r6
            goto Lce
        L5e5:
            r6 = r6 & 255(0xff, float:3.57E-43)
            goto L1e6
        L5eb:
            r4 = 1
            goto L324
        L5f0:
            r10 = r9[r5]
            goto L88d
        L5f6:
            r7 = r7 & 255(0xff, float:3.57E-43)
            goto L7d
        L5fc:
            r4 = r22[r4]
            goto L3cc
        L602:
            r8[r18] = r4
            goto L83f
        L608:
            r7 = r8[r7]
            goto L6ac
        L60e:
            if (r0 <= 0) goto L613
            goto L29
        L613:
            goto L26
        L617:
            r1 = r1 ^ r7
            goto L882
        L61c:
            r18 = r5
            goto L312
        L622:
            r24[r7] = r3
            goto L372
        L628:
            int r3 = r25 + 7
            goto L8df
        L62e:
            r0 = r21
            goto L747
        L634:
            int r7 = r7 >>> 8
            goto L6f4
        L63a:
            byte r2 = (byte) r2
            goto L4ac
        L63f:
            r10 = r10 ^ r11
            goto L183
        L644:
            r10 = r5[r10]
            goto L27a
        L64a:
            r10 = r10 ^ r11
            goto L220
        L64f:
            int r11 = r2 >>> 8
            goto L63f
        L655:
            r4 = r4 ^ r5
            goto L83
        L65a:
            int r11 = r2 >>> 16
            goto L47f
        L660:
            r10 = r10 & 255(0xff, float:3.57E-43)
            goto L1da
        L666:
            int[] r8 = r0.f459f
            goto L24c
        L66c:
            int r8 = r2 >>> 24
            goto L4
        L672:
            int[] r1 = r0.f460g
            goto L10c
        L678:
            int r1 = r23 + 4
            goto L57e
        L67e:
            int r4 = r16 >>> 8
            goto L30c
        L684:
            r0 = r5[r0]
            goto L502
        L68a:
            r8 = r0[r17]
            goto L70c
        L690:
            byte r10 = (byte) r10
            goto L6fa
        L695:
            r10 = r4[r10]
            goto L59c
        L69b:
            r10 = r5[r10]
            goto L1bd
        L6a1:
            r4 = r17
            goto L44c
        L6a7:
            byte r0 = (byte) r0
            goto L6ee
        L6ac:
            int r7 = r7 >>> 24
            goto L759
        L6b2:
            r17 = r4
            goto L67e
        L6b8:
            r0 = 6
            goto Lc7
        L6bf:
            int r7 = r1 + 1
            goto L78e
        L6c5:
            int r9 = r9 >>> 16
            goto L871
        L6cb:
            goto L29
        L6ce:
            goto L868
        L6d2:
            int r7 = r1 >>> 8
            goto L834
        L6d8:
            r7 = r8[r7]
            goto L300
        L6de:
            r2 = r2 ^ r10
            goto L63a
        L6e3:
            r7 = r22[r7]
            goto L5f6
        L6e9:
            r10 = r10 ^ r11
            goto L7ac
        L6ee:
            r24[r2] = r0
            goto L469
        L6f4:
            r7 = r7 & 255(0xff, float:3.57E-43)
            goto L856
        L6fa:
            r24[r7] = r10
            goto L55b
        L700:
            r10 = r10 & 255(0xff, float:3.57E-43)
            goto L695
        L706:
            int r7 = r23 + 3
            goto L49a
        L70c:
            r9 = r8[r18]
            goto L159
        L712:
            r2 = r2 | r3
            goto L306
        L717:
            r2 = r2 & 255(0xff, float:3.57E-43)
            goto L519
        L71d:
            int r14 = r14 >>> 16
            goto L76b
        L723:
            r10 = r6[r17]
            goto L15
        L729:
            r22 = r7
            goto L672
        L72f:
            r3 = r6[r22]
            goto L788
        L735:
            r7 = r7 & 255(0xff, float:3.57E-43)
            goto L771
        L73b:
            r7 = r9[r22]
            goto L1c8
        L741:
            r1[r6] = r2
            goto L596
        L747:
            int[] r1 = r0.f459f
            goto L22b
        L74d:
            int r7 = r1 >>> 16
            goto L286
        L753:
            r0 = r0[r22]
            goto L4c3
        L759:
            r7 = r3[r7]
            goto L4ec
        L75f:
            r10 = r4[r10]
            goto L8ab
        L765:
            r4 = r22[r4]
            goto L15f
        L76b:
            r14 = r14 & 255(0xff, float:3.57E-43)
            goto L5b8
        L771:
            r7 = r11[r7]
            goto L3dd
        L777:
            int r7 = r7 >>> 24
            goto L3fe
        L77d:
            r4 = r14[r4]
            goto L55
        L783:
            byte r2 = (byte) r2
            goto L538
        L788:
            r3 = r5[r3]
            goto L7c8
        L78e:
            r7 = r5[r7]
            goto L4f8
        L794:
            int r7 = r25 + 12
            goto L2a8
        L79a:
            r7 = r14[r7]
            goto L8da
        L7a0:
            int r2 = r2 << 16
            goto L4be
        L7a6:
            r4 = r4 ^ r16
            goto L8c2
        L7ac:
            byte r10 = (byte) r10
            goto L225
        L7b1:
            r11 = r11 ^ r14
            goto L3f8
        L7b6:
            r7 = r11[r7]
            goto L26f
        L7bc:
            int r6 = r6 << 8
            goto L544
        L7c2:
            r6 = r3[r5]
            goto L5ad
        L7c8:
            int r3 = r3 >>> 24
            goto L48a
        L7ce:
            r10 = r6[r20]
            goto L69b
        L7d4:
            int r3 = r25 + 1
            goto L877
        L7da:
            r7 = r15[r22]
            goto L6d8
        L7e0:
            r3 = r22[r3]
            goto L1d4
        L7e6:
            r7 = r7 & 255(0xff, float:3.57E-43)
            goto L79a
        L7ec:
            r19 = r13[r17]
            goto L53e
        L7f2:
            int r7 = r23 + 12
            goto L7fe
        L7f8:
            r7 = r7 & 255(0xff, float:3.57E-43)
            goto L3b4
        L7fe:
            r6 = r22[r6]
            goto L4c9
        L804:
            r10 = r5[r10]
            goto L2d7
        L80a:
            int r7 = r23 + 2
            goto L13c
        L810:
            r24[r3] = r6
            goto L258
        L816:
            int[] r5 = r0.f459f
            goto Le6
        L81c:
            r2 = r22[r2]
            goto L822
        L822:
            r2 = r2 & 255(0xff, float:3.57E-43)
            goto L2cb
        L828:
            r6 = r6 & 255(0xff, float:3.57E-43)
            goto L11e
        L82e:
            r7 = r12[r7]
            goto L101
        L834:
            r6 = r6 ^ r7
            goto L21
        L839:
            r6 = r5[r6]
            goto L89
        L83f:
            r8[r17] = r6
            goto L8b6
        L845:
            byte r9 = (byte) r9
            goto L241
        L84a:
            int r2 = r25 + 13
            goto L72f
        L850:
            r1[r7] = r2
            goto L5d5
        L856:
            r7 = r14[r7]
            goto L247
        L85c:
            int[] r11 = com.mastercard.terminalsdk.internal.C2202g.f454a
            goto L2f4
        L862:
            int r3 = r3 << 24
            goto L4f
        L868:
            goto L534
        L86b:
            r6 = r6 & 255(0xff, float:3.57E-43)
            goto L7bc
        L871:
            r9 = r9 & 255(0xff, float:3.57E-43)
            goto L188
        L877:
            byte[] r4 = com.mastercard.terminalsdk.internal.C2202g.f458e
            goto L816
        L87d:
            r6 = 2
            goto L8ce
        L882:
            r7 = r10[r22]
            goto L567
        L888:
            r2 = r2 | r6
            goto L4e6
        L88d:
            r11 = r10[r5]
            goto L2e9
        L893:
            r24[r3] = r10
            goto L1fd
        L899:
            r1 = r12[r1]
            goto L1f8
        L89f:
            int r4 = r23 + 7
            goto L66
        L8a5:
            r7 = r8[r7]
            goto L41c
        L8ab:
            int r11 = r2 >>> 24
            goto L2ef
        L8b1:
            r2 = r2 ^ r10
            goto L783
        L8b6:
            r8[r20] = r1
            goto L3a8
        L8bc:
            int r11 = r2 >>> 24
            goto L2d
        L8c2:
            r16 = r10[r17]
            goto L28b
        L8c8:
            r18 = r5
            goto L3e2
        L8ce:
            r8 = r3[r6]
            goto L94
        L8d4:
            int r10 = r10 >>> 16
            goto L3a2
        L8da:
            r3 = r3 ^ r7
            goto L73b
        L8df:
            r10 = r9[r17]
            goto L1ab
    }

    public static void DAXGsvEKKcOHyZlY(java.io.FilterStream r0) {
            goto L10
        L4:
            super.Dispose()
            goto Lb
        Lb:
            return
        Lc:
            goto L17
        L10:
            goto Lc
        L13:
            goto L4
        L17:
            goto L13
    }

    public static int OYEsgakMOChmhRpy(java.io.Stream r1, byte[] r2, int r3, int r4) {
            goto L11
        L4:
            int r0 = r1.read(r2, r3, r4)
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

    public static int[] OgmSwmCEKCwhCbVR(byte[] r1, int r2) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            int[] r0 = com.mastercard.terminalsdk.internal.C2203h.m453a(r1, r2)
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static int UYPxGBpzYOfoOlSV(com.mastercard.terminalsdk.internal.C2202g r1) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            int r0 = r1.m448a()
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static int VbHRkpeqTIBVAIBL(java.io.Stream r1) {
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

    public static int ZqrqKDgVRwPYIEUO(java.io.Stream r1, byte[] r2, int r3, int r4) {
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

    public static int ZwoIBnbuAZSnxHtz(java.io.Stream r1) {
            goto Lc
        L4:
            int r0 = r1.read()
            goto L16
        Lc:
            goto L17
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            return r0
        L17:
            goto L13
    }

    @Override // java.io.FilterStream, java.io.Stream
    public int Available() throws java.io.IOException {
            r1 = this;
            goto L21
        L4:
            int r1 = r1.f464l
            goto L1c
        La:
            int r0 = r1.f465m
            goto L4
        L10:
            return r0
        L11:
            goto L28
        L15:
            MnRUesIHuhSOvhOR(r1)
            goto La
        L1c:
            int r0 = r0 - r1
            goto L10
        L21:
            goto L11
        L24:
            goto L15
        L28:
            goto L24
    }

    @Override // java.io.FilterStream, java.io.Stream, java.io.IDisposable, java.lang.AutoIDisposable
    public void Close() throws java.io.IOException {
            r0 = this;
            goto L9
        L4:
            return
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            dAXGsvEKKcOHyZlY(r0)
            goto L4
    }

    @Override // java.io.FilterStream, java.io.Stream
    public void Mark(int r1) {
            r0 = this;
            goto L16
        L4:
            monitor-enter(r0)
            goto Lc
        L9:
            goto L19
        Lc:
            monitor-exit(r0)
            goto L11
        L11:
            return
        L12:
            goto L9
        L16:
            goto L12
        L19:
            goto L4
    }

    @Override // java.io.FilterStream, java.io.Stream
    public bool MarkSupported() {
            r0 = this;
            goto L11
        L4:
            return r0
        L5:
            goto Le
        L9:
            r0 = 0
            goto L4
        Le:
            goto L14
        L11:
            goto L5
        L14:
            goto L9
    }

    @Override // java.io.FilterStream, java.io.Stream
    public int Read() throws java.io.IOException {
            r3 = this;
            goto L3c
        L4:
            r3 = r1[r0]
            goto L20
        La:
            if (r0 >= r1) goto Lf
            goto L7f
        Lf:
            goto L79
        L13:
            goto L84
        L16:
            goto L35
        L1a:
            int r0 = r0 % r1
            goto L51
        L20:
            r3 = r3 & 255(0xff, float:3.57E-43)
            goto L83
        L26:
            int r0 = r3.f464l
            goto L2f
        L2c:
            goto L3f
        L2f:
            int r1 = r3.f465m
            goto La
        L35:
            uYPxGBpzYOfoOlSV(r3)
            goto L26
        L3c:
            goto L69
        L3f:
            goto L4a
        L43:
            r1 = 2
            goto L73
        L4a:
            r0 = 21
            goto L43
        L51:
            if (r0 <= 0) goto L56
            goto L16
        L56:
            goto L13
        L5a:
            byte[] r1 = r3.f466n
            goto L60
        L60:
            int r2 = r0 + 1
            goto L6d
        L66:
            goto L16
        L69:
            goto L2c
        L6d:
            r3.f464l = r2
            goto L4
        L73:
            int r0 = r0 + r1
            goto L1a
        L79:
            r3 = -1
            goto L7e
        L7e:
            return r3
        L7f:
            goto L5a
        L83:
            return r3
        L84:
            goto L66
    }

    @Override // java.io.FilterStream, java.io.Stream
    public int Read(byte[] r3) throws java.io.IOException {
            r2 = this;
            goto L22
        L4:
            int r0 = r0 % r1
            goto L2e
        La:
            goto L12
        Ld:
            goto L1d
        L11:
            return r2
        L12:
            goto L16
        L16:
            goto Ld
        L19:
            goto L44
        L1d:
            r0 = 0
            goto L29
        L22:
            goto L19
        L25:
            goto L3d
        L29:
            int r1 = r3.length
            goto L47
        L2e:
            if (r0 <= 0) goto L33
            goto Ld
        L33:
            goto La
        L37:
            int r0 = r0 + r1
            goto L4
        L3d:
            r0 = 11
            goto L4f
        L44:
            goto L25
        L47:
            int r2 = oYEsgakMOChmhRpy(r2, r3, r0, r1)
            goto L11
        L4f:
            r1 = 16
            goto L37
    }

    @Override // java.io.FilterStream, java.io.Stream
    public int Read(byte[] r7, int r8, int r9) throws java.io.IOException {
            r6 = this;
            goto L3f
        L4:
            if (r1 < r0) goto L9
            goto L23
        L9:
            goto La7
        Ld:
            int r3 = r1 + 1
            goto L6f
        L13:
            r6.f464l = r5
            goto L27
        L19:
            if (r0 <= 0) goto L1e
            goto Lbb
        L1e:
            goto Lb8
        L22:
            goto L54
        L23:
            goto L9d
        L27:
            r2 = r4[r2]
            goto L58
        L2d:
            r1 = r3
            goto L22
        L32:
            int r5 = r2 + 1
            goto L13
        L38:
            r0 = 28
            goto L96
        L3f:
            goto L4f
        L42:
            goto L38
        L46:
            int r3 = r6.f465m
            goto L75
        L4c:
            goto Lbb
        L4f:
            goto L8d
        L53:
            r1 = r8
        L54:
            goto L4
        L58:
            r7[r1] = r2
            goto L2d
        L5e:
            int r0 = r0 % r1
            goto L19
        L64:
            int r2 = r6.f464l
            goto L46
        L6a:
            return r9
        L6b:
            goto Ld
        L6f:
            byte[] r4 = r6.f466n
            goto L32
        L75:
            if (r2 >= r3) goto L7a
            goto L6b
        L7a:
            goto L7e
        L7e:
            if (r1 == r8) goto L83
            goto Lc0
        L83:
            goto Lae
        L87:
            int r0 = r0 + r1
            goto L5e
        L8d:
            goto L42
        L90:
            int r0 = r8 + r9
            goto L53
        L96:
            r1 = 32
            goto L87
        L9d:
            return r9
        L9e:
            goto L4c
        La2:
            int r9 = r9 - r0
            goto L6a
        La7:
            JnJrQmRCmqojLVrk(r6)
            goto L64
        Lae:
            r6 = -1
            goto Lbf
        Lb3:
            int r0 = r0 - r1
            goto La2
        Lb8:
            goto L9e
        Lbb:
            goto L90
        Lbf:
            return r6
        Lc0:
            goto Lb3
    }

    @Override // java.io.FilterStream, java.io.Stream
    public void Reset() throws java.io.IOException {
            r0 = this;
            goto L7
        L4:
            goto La
        L7:
            goto L14
        La:
            goto Le
        Le:
            monitor-enter(r0)
            goto L18
        L13:
            return
        L14:
            goto L4
        L18:
            monitor-exit(r0)
            goto L13
    }

    @Override // java.io.FilterStream, java.io.Stream
    public long Skip(long r5) throws java.io.IOException {
            r4 = this;
            goto L11
        L4:
            int r0 = r0 % r1
            goto L35
        La:
            r1 = 27
            goto L5e
        L11:
            goto L4e
        L14:
            goto L2e
        L18:
            int r2 = vbHRkpeqTIBVAIBL(r4)
            goto L71
        L20:
            if (r2 != r3) goto L25
            goto L47
        L25:
            goto L52
        L29:
            long r0 = r0 + r2
            goto L46
        L2e:
            r0 = 15
            goto La
        L35:
            if (r0 <= 0) goto L3a
            goto L67
        L3a:
            goto L64
        L3e:
            goto L14
        L41:
            return r0
        L42:
            goto L4b
        L46:
            goto L5a
        L47:
            goto L41
        L4b:
            goto L67
        L4e:
            goto L3e
        L52:
            r2 = 1
            goto L29
        L58:
            r0 = 0
        L5a:
            goto L6b
        L5e:
            int r0 = r0 + r1
            goto L4
        L64:
            goto L42
        L67:
            goto L58
        L6b:
            int r2 = (r0 > r5 ? 1 : (r0 == r5 ? 0 : -1))
            goto L76
        L71:
            r3 = -1
            goto L20
        L76:
            if (r2 < 0) goto L7b
            goto L47
        L7b:
            goto L18
    }
}

