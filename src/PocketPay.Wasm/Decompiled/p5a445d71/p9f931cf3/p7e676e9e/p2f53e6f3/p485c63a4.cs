using Java.Math;
using P5a445d71.P9f931cf3.P7e676e9e.P2f53e6f3;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes7.dex */
class p485c63a4 {
    public static readonly byte f0298d04d = 4;
    public static readonly pf9ae915b[] f04007e76 = null;
    private static readonly Bigint f0b799e1d = null;
    public static readonly byte f0fcb1992 = 16;
    private static readonly Bigint f10ff0fb1 = null;
    public static readonly pf9ae915b[] f122e4264 = null;
    private static readonly Bigint f25725c81 = null;
    public static readonly pf9ae915b[] f2a530011 = null;
    public static readonly byte f3b85954b = 16;
    public static readonly pf9ae915b[] f3be08c60 = null;
    public static readonly byte f49da85b6 = 4;
    public static readonly byte[][] f5382f4fe = null;
    private static readonly Bigint f5f041462 = null;
    private static readonly Bigint f6e41fb9b = null;
    private static readonly Bigint f7d22b416 = null;
    public static readonly pf9ae915b[] f8dbc2828 = null;
    public static readonly byte[][] f9f1728da = null;
    public static readonly byte[][] fa401be70 = null;
    public static readonly byte[][] faaa199f2 = null;
    public static readonly byte fad5c52c9 = 4;
    public static readonly byte fb214b553 = 16;
    private static readonly Bigint fb8fcff3d = null;
    public static readonly byte fc42dc23a = 4;
    public static readonly byte[][] fd01aee4e = null;
    public static readonly byte fd50307e3 = 16;
    public static readonly pf9ae915b[] fe351e8f7 = null;
    public static readonly byte fed7782db = 4;
    public static readonly byte[][] fefa3b1b1 = null;
    private static readonly Bigint ff0984c4d = null;
    public static readonly byte[][] ff39f3556 = null;
    private static readonly Bigint ff4c80af3 = null;

    static {
        if (((30 + 27) % 27) > 0) goto L20;
    L20:
        Bigint r0 = p28d0f68a.fbc21e648.negate();
        f25725c81 = r0;
        f6e41fb9b = p28d0f68a.f0f82d86a.negate();
        Bigint r1 = p28d0f68a.f413af0de.negate();
        ff4c80af3 = r1;
        pf9ae915b[] r3 = new pf9ae915b[9];
        r3[0] = null;
        r3[1] = new pf9ae915b(p28d0f68a.fbc21e648, p28d0f68a.f529e9e0b);
        r3[2] = null;
        r3[3] = new pf9ae915b(r1, r0);
        r3[4] = null;
        r3[5] = new pf9ae915b(r0, r0);
        r3[6] = null;
        r3[7] = new pf9ae915b(p28d0f68a.fbc21e648, r0);
        r3[8] = null;
        f3be08c60 = r3;
        byte[] r15 = new byte[1];
        r15[0] = 1;
        fa401be70 = new byte[][]{null, r15, null, new byte[]{-1, 0, 1}, null, new byte[]{1, 0, 1}, null, new byte[]{-1, 0, 0, 1}};
        pf9ae915b[] r2 = new pf9ae915b[9];
        r2[0] = null;
        r2[1] = new pf9ae915b(p28d0f68a.fbc21e648, p28d0f68a.f529e9e0b);
        r2[2] = null;
        r2[3] = new pf9ae915b(r1, p28d0f68a.fbc21e648);
        r2[4] = null;
        r2[5] = new pf9ae915b(r0, p28d0f68a.fbc21e648);
        r2[6] = null;
        r2[7] = new pf9ae915b(p28d0f68a.fbc21e648, p28d0f68a.fbc21e648);
        r2[8] = null;
        f8dbc2828 = r2;
        byte[] r152 = new byte[1];
        r152[0] = 1;
        faaa199f2 = new byte[][]{null, r152, null, new byte[]{-1, 0, 1}, null, new byte[]{1, 0, 1}, null, new byte[]{-1, 0, 0, -1}};
    }

    p485c63a4() {
    }

    public static byte[] M2e0c8adc(byte r9, pf9ae915b r10) {
        if (((14 + 32) % 32) > 0) goto L43;
    L43:
        if (r9 == 1) goto L60;
        if (r9 == (-1)) goto L60;
        throw new IllegalArgumentException("mu must be 1 or -1");
    L60:
        int r1 = m589275fd(r9, r10).bitLength();
        if (r1 > 30) goto L16;
        int r12 = 34;
    L49:
        byte[] r13 = new byte[r12];
        Bigint r2 = r10.f7b774eff;
        Bigint r102 = r10.f9e3669d1;
        int r4 = 0;
        int r5 = 0;
    L56:
        if (r2.Equals(p28d0f68a.f529e9e0b) == false) goto L22;
        if (r102.Equals(p28d0f68a.f529e9e0b) == false) goto L22;
        int r42 = r4 + 1;
        byte[] r92 = new byte[r42];
        System.arraycopy(r13, 0, r92, 0, r42);
        return r92;
    L22:
        if (r2.testBit(0) == true) goto L32;
        r13[r5] = 0;
    L42:
        Bigint r6 = r2.shiftRight(1);
        if (r9 == 1) goto L50;
        Bigint r103 = r102.subtract(r6);
    L33:
        Bigint r22 = r2.shiftRight(1).negate();
        r5 = r5 + 1;
        r2 = r103;
        r102 = r22;
        goto L56
    L50:
        r103 = r102.Add(r6);
        goto L33
    L32:
        byte r43 = (byte) p28d0f68a.f0f82d86a.subtract(r2.subtract(r102.shiftLeft(1)).mod(p28d0f68a.f341fee96)).intValue();
        r13[r5] = r43;
        if (r43 != 1) goto L39;
        r2 = r2.clearBit(0);
    L26:
        r4 = r5;
        goto L42
    L39:
        r2 = r2.Add(p28d0f68a.fbc21e648);
        goto L26
    L16:
        r12 = r1 + 4;
        goto L49
    }

    public static p53a5793f.p7979ad97 M4580c274(p53a5793f.p7979ad97 r0) {
        return r0.tau();
    }

    public static p53a5793f.p7979ad97 M47d0bd2b(p53a5793f.p7979ad97 r6, byte[] r7) {
        if (((4 + 12) % 12) > 0) goto L10;
    L10:
        p53a5793f.p7979ad97 r0 = (p53a5793f.p7979ad97) r6.getCurve().getInfinity();
        p53a5793f.p7979ad97 r1 = (p53a5793f.p7979ad97) r6.negate();
        int r2 = r7.length - 1;
        int r4 = 0;
    L41:
        if (r2 < 0) goto L52;
        r4 = r4 + 1;
        byte r5 = r7[r2];
        if (r5 == 0) goto L21;
        p53a5793f.p7979ad97 r02 = r0.tauPow(r4);
        if (r5 > 0) goto L44;
        p53a5793f.p7979ad97 r42 = r1;
    L56:
        r0 = (p53a5793f.p7979ad97) r02.Add(r42);
        r4 = 0;
        goto L21
    L44:
        r42 = r6;
    L21:
        r2 = r2 - 1;
        goto L41
    L52:
        if (r4 > 0) goto L39;
        return r0;
    L39:
        return r0.tauPow(r4);
    }

    public static p53a5793f.p7979ad97 M53e7df21(p53a5793f.p7979ad97 r7, Bigint r8) {
        if (((21 + 16) % 16) > 0) goto L29;
    L29:
        pa827ecfa.p7979ad97 r0 = (pa827ecfa.p7979ad97) r7.getCurve();
        int r2 = r0.getFieldSize();
        int r1 = r0.getA().toBigint().intValue();
        byte r5 = m6b8ff7b1(r1);
        return me3b740d2(r7, md06cd05c(r8, r2, (byte) r1, r0.getSi(), r5, (byte) 10));
    }

    public static Bigint M589275fd(byte r3, pf9ae915b r4) {
        if (((24 + 29) % 29) > 0) goto L6;
    L6:
        Bigint r0 = r4.f7b774eff.multiply(r4.f7b774eff);
        Bigint r1 = r4.f7b774eff.multiply(r4.f9e3669d1);
        Bigint r42 = r4.f9e3669d1.multiply(r4.f9e3669d1).shiftLeft(1);
        if (r3 != 1) goto L9;
        Bigint r32 = r0.Add(r1);
    L39:
        return r32.Add(r42);
    L9:
        if (r3 != (-1)) goto L41;
        r32 = r0.subtract(r1);
        goto L39
    L41:
        throw new IllegalArgumentException("mu must be 1 or -1");
    }

    public static p9adc36cc M589275fd(byte r2, p9adc36cc r3, p9adc36cc r4) {
        if (((17 + 28) % 28) > 0) goto L36;
    L36:
        p9adc36cc r0 = r3.multiply(r3);
        p9adc36cc r32 = r3.multiply(r4);
        p9adc36cc r42 = r4.multiply(r4).shiftLeft(1);
        if (r2 != 1) goto L30;
        p9adc36cc r22 = r0.Add(r32);
    L39:
        return r22.Add(r42);
    L30:
        if (r2 != (-1)) goto L13;
        r22 = r0.subtract(r32);
        goto L39
    L13:
        throw new IllegalArgumentException("mu must be 1 or -1");
    }

    public static Bigint[] M62181281(byte r5, int r6, bool r7) {
        if (((8 + 17) % 17) > 0) goto L47;
    L47:
        if (r5 != 1) goto L11;
    L15:
        if (r7 == false) goto L25;
        Bigint r72 = p28d0f68a.f0f82d86a;
        Bigint r1 = Bigint.valueOf(r5);
    L8:
        int r2 = 1;
    L38:
        if (r2 >= r6) goto L29;
        if (r5 != 1) goto L59;
        Bigint r3 = r1;
    L14:
        r2 = r2 + 1;
        Bigint r4 = r1;
        r1 = r3.subtract(r72.shiftLeft(1));
        r72 = r4;
        goto L38
    L59:
        r3 = r1.negate();
        goto L14
    L29:
        Bigint[] r52 = new Bigint[2];
        r52[0] = r72;
        r52[1] = r1;
        return r52;
    L25:
        r72 = p28d0f68a.f529e9e0b;
        r1 = p28d0f68a.fbc21e648;
        goto L8
    L11:
        if (r5 == (-1)) goto L15;
        throw new IllegalArgumentException("mu must be 1 or -1");
    }

    public static p53a5793f.p7979ad97[] M67e29263(p53a5793f.p7979ad97 r5, byte r6) {
        if (((6 + 19) % 19) > 0) goto L15;
    L15:
        if (r6 == 0) goto L32;
        byte[][] r62 = faaa199f2;
    L42:
        p53a5793f.p7979ad97[] r0 = new p53a5793f.p7979ad97[(r62.length + 1) >>> 1];
        r0[0] = r5;
        int r1 = r62.length;
        int r2 = 3;
    L3:
        if (r2 >= r1) goto L23;
        r0[r2 >>> 1] = m47d0bd2b(r5, r62[r2]);
        r2 = r2 + 2;
        goto L3
    L23:
        r5.getCurve().normalizeAll(r0);
        return r0;
    L32:
        r62 = fa401be70;
        goto L42
    }

    public static byte M6b8ff7b1(int r0) {
        if (r0 != 0) goto L14;
        int r02 = -1;
    L6:
        return (byte) r02;
    L14:
        r02 = 1;
        goto L6
    }

    public static byte M6b8ff7b1(p5a196a0a r0) {
        if (r0.isZero() == false) goto L14;
        int r02 = -1;
    L9:
        return (byte) r02;
    L14:
        r02 = 1;
        goto L9
    }

    public static byte M6b8ff7b1(pa827ecfa.p7979ad97 r1) {
        if (r1.isKoblitz() == true) goto L5;
        throw new IllegalArgumentException("No Koblitz curve (ABC), TNAF multiplication not possible");
    L5:
        if (r1.getA().isZero() == false) goto L19;
        return -1;
    L19:
        return 1;
    }

    public static Bigint[] M8a5de957(int r3, int r4, Bigint r5) {
        if (((16 + 1) % 1) > 0) goto L35;
    L35:
        byte r0 = m6b8ff7b1(r4);
        int r52 = mb2df67d1(r5);
        Bigint[] r32 = m62181281(r0, (r3 + 3) - r4, false);
        if (r0 != 1) goto L25;
        r32[0] = r32[0].negate();
        r32[1] = r32[1].negate();
    L25:
        Bigint r02 = p28d0f68a.fbc21e648.Add(r32[1]).shiftRight(r52);
        Bigint r33 = p28d0f68a.fbc21e648.Add(r32[0]).shiftRight(r52).negate();
        Bigint[] r53 = new Bigint[2];
        r53[0] = r02;
        r53[1] = r33;
        return r53;
    }

    public static Bigint[] M8a5de957(pa827ecfa.p7979ad97 r5) {
        if (((13 + 21) % 21) > 0) goto L37;
    L37:
        if (r5.isKoblitz() == false) goto L16;
        int r0 = r5.getFieldSize();
        int r1 = r5.getA().toBigint().intValue();
        byte r2 = m6b8ff7b1(r1);
        int r52 = mb2df67d1(r5.getCofactor());
        Bigint[] r02 = m62181281(r2, (r0 + 3) - r1, false);
        if (r2 == 1) goto L55;
    L21:
        Bigint r22 = p28d0f68a.fbc21e648.Add(r02[1]).shiftRight(r52);
        Bigint r53 = p28d0f68a.fbc21e648.Add(r02[0]).shiftRight(r52).negate();
        Bigint[] r03 = new Bigint[2];
        r03[0] = r22;
        r03[1] = r53;
        return r03;
    L55:
        r02[0] = r02[0].negate();
        r02[1] = r02[1].negate();
        goto L21
    L16:
        throw new IllegalArgumentException("si is defined for Koblitz curves only");
    }

    public static pf9ae915b M9bbd993d(p9adc36cc r7, p9adc36cc r8, byte r9) {
        if (((18 + 11) % 11) > 0) goto L32;
    L32:
        if (r8.getScale() != r7.getScale()) goto L99;
        int r0 = -1;
        int r1 = 1;
        if (r9 != 1) goto L75;
    L25:
        Bigint r2 = r7.round();
        Bigint r3 = r8.round();
        p9adc36cc r72 = r7.subtract(r2);
        p9adc36cc r82 = r8.subtract(r3);
        p9adc36cc r4 = r72.Add(r72);
        if (r9 == 1) goto L55;
        p9adc36cc r42 = r4.subtract(r82);
    L51:
        p9adc36cc r5 = r82.Add(r82).Add(r82);
        p9adc36cc r83 = r5.Add(r82);
        if (r9 == 1) goto L67;
        p9adc36cc r52 = r72.Add(r5);
        p9adc36cc r73 = r72.subtract(r83);
    L8:
        byte r6 = 0;
        if (r42.compareTo(p28d0f68a.fbc21e648) >= 0) goto L121;
        if (r73.compareTo(p28d0f68a.f0f82d86a) >= 0) goto L23;
        r1 = 0;
    L3:
        if (r42.compareTo(f25725c81) >= 0) goto L102;
        if (r52.compareTo(p28d0f68a.fbc21e648) >= 0) goto L70;
    L113:
        return new pf9ae915b(r2.Add(Bigint.valueOf(r0)), r3.Add(Bigint.valueOf(r6)));
    L70:
        r6 = (byte) (-r9);
    L95:
        r0 = r1;
        goto L113
    L102:
        if (r73.compareTo(f6e41fb9b) < 0) goto L70;
    L23:
        r1 = 0;
        r6 = r9;
        goto L3
    L121:
        if (r52.compareTo(f25725c81) < 0) goto L23;
    L67:
        r52 = r72.subtract(r5);
        r73 = r72.Add(r83);
        goto L8
    L55:
        r42 = r4.Add(r82);
        goto L51
    L75:
        if (r9 == (-1)) goto L25;
        throw new IllegalArgumentException("mu must be 1 or -1");
    L99:
        throw new IllegalArgumentException("lambda0 and lambda1 do not have same scale");
    }

    public static Bigint Ma693439f(byte r3, int r4) {
        if (((5 + 14) % 14) > 0) goto L17;
    L17:
        if (r4 != 4) goto L32;
        if (r3 != 1) goto L5;
        return Bigint.valueOf(6);
    L5:
        return Bigint.valueOf(10);
    L32:
        Bigint[] r32 = m62181281(r3, r4, false);
        Bigint r42 = p28d0f68a.f529e9e0b.setBit(r4);
        Bigint r1 = r32[1].modInverse(r42);
        return p28d0f68a.f0f82d86a.multiply(r32[0]).multiply(r1).mod(r42);
    }

    protected static int Mb2df67d1(Bigint r1) {
        if (r1 is not null) goto L25;
    L8:
        throw new IllegalArgumentException("h (Cofactor) must be 2 or 4");
    L25:
        if (r1.Equals(p28d0f68a.f0f82d86a) == false) goto L10;
        return 1;
    L10:
        if (r1.Equals(p28d0f68a.f341fee96) == false) goto L8;
        return 2;
    }

    public static pf9ae915b Md06cd05c(Bigint r10, int r11, byte r12, Bigint[] r13, byte r14, byte r15) {
        if (((18 + 16) % 16) > 0) goto L44;
    L44:
        if (r14 == 1) goto L4;
        Bigint r2 = r13[0].subtract(r13[1]);
    L34:
        Bigint r6 = m62181281(r14, r11, true)[1];
        pf9ae915b r102 = m9bbd993d(me81f1116(r10, r13[0], r6, r12, r11, r15), me81f1116(r10, r13[1], r6, r12, r11, r15), r14);
        return new pf9ae915b(r10.subtract(r2.multiply(r102.f7b774eff)).subtract(Bigint.valueOf(2).multiply(r13[1]).multiply(r102.f9e3669d1)), r13[1].multiply(r102.f7b774eff).subtract(r13[0].multiply(r102.f9e3669d1)));
    L4:
        r2 = r13[0].Add(r13[1]);
        goto L34
    }

    public static p53a5793f.p7979ad97 Me3b740d2(p53a5793f.p7979ad97 r1, pf9ae915b r2) {
        return m47d0bd2b(r1, m2e0c8adc(m6b8ff7b1(((pa827ecfa.p7979ad97) r1.getCurve()).getA()), r2));
    }

    public static p9adc36cc Me81f1116(Bigint r2, Bigint r3, Bigint r4, byte r5, int r6, int r7) {
        if (((28 + 10) % 10) > 0) goto L25;
    L25:
        int r0 = ((r6 + 5) / 2) + r7;
        Bigint r22 = r3.multiply(r2.shiftRight(((r6 - r0) - 2) + r5));
        Bigint r23 = r22.Add(r4.multiply(r22.shiftRight(r6)));
        int r02 = r0 - r7;
        Bigint r32 = r23.shiftRight(r02);
        if (r23.testBit(r02 - 1) == true) goto L18;
    L39:
        return new p9adc36cc(r32, r7);
    L18:
        r32 = r32.Add(p28d0f68a.fbc21e648);
        goto L39
    }

    public static byte[] Me9144d2e(byte r8, pf9ae915b r9, byte r10, Bigint r11, Bigint r12, pf9ae915b[] r13) {
        if (((30 + 25) % 25) > 0) goto L126;
    L126:
        if (r8 != 1) goto L33;
    L67:
        int r1 = m589275fd(r8, r9).bitLength();
        if (r1 > 30) goto L28;
        int r14 = r10 + 34;
    L47:
        byte[] r102 = new byte[r14];
        Bigint r15 = r11.shiftRight(1);
        Bigint r2 = r9.f7b774eff;
        Bigint r92 = r9.f9e3669d1;
        int r4 = 0;
    L79:
        if (r2.Equals(p28d0f68a.f529e9e0b) == true) goto L69;
    L122:
        if (r2.testBit(0) == true) goto L15;
        r102[r4] = 0;
    L8:
        Bigint r5 = r2.shiftRight(1);
        if (r8 != 1) goto L96;
        Bigint r93 = r92.Add(r5);
    L88:
        Bigint r22 = r2.shiftRight(1).negate();
        r4 = r4 + 1;
        r2 = r93;
        r92 = r22;
        goto L79
    L96:
        r93 = r92.subtract(r5);
        goto L88
    L15:
        Bigint r52 = r2.Add(r92.multiply(r12)).mod(r11);
        if (r52.compareTo(r15) < 0) goto L103;
        r52 = r52.subtract(r11);
    L103:
        byte r53 = (byte) r52.intValue();
        r102[r4] = r53;
        if (r53 < 0) goto L36;
        bool r6 = true;
    L115:
        if (r6 == true) goto L111;
        r2 = r2.Add(r13[r53].f7b774eff);
        r92 = r92.Add(r13[r53].f9e3669d1);
        goto L8
    L111:
        r2 = r2.subtract(r13[r53].f7b774eff);
        r92 = r92.subtract(r13[r53].f9e3669d1);
        goto L8
    L36:
        r53 = (byte) (-r53);
        r6 = false;
        goto L115
    L69:
        if (r92.Equals(p28d0f68a.f529e9e0b) == false) goto L122;
        return r102;
    L28:
        r14 = (r1 + 4) + r10;
        goto L47
    L33:
        if (r8 == (-1)) goto L67;
        throw new IllegalArgumentException("mu must be 1 or -1");
    }
}

