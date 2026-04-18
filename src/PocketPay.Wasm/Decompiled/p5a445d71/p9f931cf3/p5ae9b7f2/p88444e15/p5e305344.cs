namespace WillowMaze.Wasm.Decompiled;


public class p5e305344 : p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pe86c57ec {
    private static readonly int f18a8bf53 = 32;
    private static readonly int f4582481e = 32;
    private static readonly int f6955fd22 = 32;
    private static readonly int ff518d011 = 32;
    private int[] f02129bb8;
    private int f0580f09c;
    private int f0c5d6f18;
    private int f106530dc;
    private int f1298c141;
    private int f175405ae;
    private int f1a3e10f8;
    private int f2ac6cc2e;
    private int f3b3736ef;
    private int f5701b7fa;
    private int f6b57370b;
    private int f6be27b14;
    private int f72d1bdc6;
    private int f83065208;
    private int f837f6caf;
    private int f892cb755;
    private int f8ded8068;
    private int f90caf5c6;
    private int f999100b1;
    private int f9b810c07;
    private int fa78f56ff;
    private int fab4adf85;
    private int fb1476321;
    private int fb60df228;
    private int fb9e63da2;
    private int fbc744b58;
    private int fc3eb05be;
    private int fc561c9fa;
    private int fc5a8521a;
    private int fca2bf3f6;
    private int[] fcefc6c7f;
    private int fdb431ba1;
    private int fe068ca8e;
    private int fe4135e5e;

    public p5e305344() {
        this.f02129bb8 = new int[16];
        reset();
    }

    public p5e305344(p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p5e305344 p5e305344Var) {
        super(p5e305344Var);
        this.f02129bb8 = new int[16];
        me7efa710(p5e305344Var);
    }

    private int M04f02161(int i, int i2, int i3, int i4, int i5, int i6) {
        return m7f49bbe2(i + m3667f6a0(i2, i3, i4) + i5 + 1836072691, i6);
    }

    private int M1779cf3a(int i, int i2, int i3) {
        return ((~i2) | i) ^ i3;
    }

    private int M3667f6a0(int i, int i2, int i3) {
        return (i & i2) | ((~i) & i3);
    }

    private int M43133f28(int i, int i2, int i3, int i4, int i5, int i6) {
        return m7f49bbe2(i + m1779cf3a(i2, i3, i4) + i5 + 1548603684, i6);
    }

    private int M4b6bf4b5(int i, int i2, int i3, int i4, int i5, int i6) {
        return m7f49bbe2(i + m1779cf3a(i2, i3, i4) + i5 + 1859775393, i6);
    }

    private int M6e1fcd70(int i, int i2, int i3) {
        return (i & i3) | ((~i3) & i2);
    }

    private int M7f49bbe2(int i, int i2) {
        return (i << i2) | (i >>> (32 - i2));
    }

    private int M9a2c8bc6(int i, int i2, int i3, int i4, int i5, int i6) {
        return m7f49bbe2(i + mbd19836d(i2, i3, i4) + i5, i6);
    }

    private int Mbd19836d(int i, int i2, int i3) {
        return (i ^ i2) ^ i3;
    }

    private void Md6261d3b(int i, byte[] bArr, int i2) {
        bArr[i2] = (byte) i;
        bArr[i2 + 1] = (byte) (i >>> 8);
        bArr[i2 + 2] = (byte) (i >>> 16);
        bArr[i2 + 3] = (byte) (i >>> 24);
    }

    private int Mddb87d7d(int i, int i2, int i3, int i4, int i5, int i6) {
        return m7f49bbe2(i + m6e1fcd70(i2, i3, i4) + i5 + 1352829926, i6);
    }

    private int Me1dffc87(int i, int i2, int i3, int i4, int i5, int i6) {
        return m7f49bbe2(i + mbd19836d(i2, i3, i4) + i5, i6);
    }

    private int Me7e0e724(int i, int i2, int i3, int i4, int i5, int i6) {
        return m7f49bbe2(((i + m6e1fcd70(i2, i3, i4)) + i5) - 1894007588, i6);
    }

    private void Me7efa710(p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p5e305344 p5e305344Var) {
        if ((11 + 8) % 8 > 0) {
        }
        super.copyIn(p5e305344Var);
        this.fe068ca8e = p5e305344Var.fe068ca8e;
        this.f106530dc = p5e305344Var.f106530dc;
        this.fca2bf3f6 = p5e305344Var.fca2bf3f6;
        this.fb1476321 = p5e305344Var.fb1476321;
        this.f6b57370b = p5e305344Var.f6b57370b;
        this.f83065208 = p5e305344Var.f83065208;
        this.f2ac6cc2e = p5e305344Var.f2ac6cc2e;
        this.f3b3736ef = p5e305344Var.f3b3736ef;
        int[] iArr = p5e305344Var.f02129bb8;
        java.lang.System.arraycopy(iArr, 0, this.f02129bb8, 0, iArr.length);
        this.fc5a8521a = p5e305344Var.fc5a8521a;
    }

    private int Mfe5c3684(int i, int i2, int i3, int i4, int i5, int i6) {
        return m7f49bbe2(i + m3667f6a0(i2, i3, i4) + i5 + 1518500249, i6);
    }

    public override p5a445d71.p9f931cf3.p05c7e247.p4d7fdfb1 Copy() {
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p5e305344(this);
    }

    public override int DoFinal(byte[] bArr, int i) {
        if ((28 + 16) % 16 > 0) {
        }
        finish();
        md6261d3b(this.fe068ca8e, bArr, i);
        md6261d3b(this.f106530dc, bArr, i + 4);
        md6261d3b(this.fca2bf3f6, bArr, i + 8);
        md6261d3b(this.fb1476321, bArr, i + 12);
        md6261d3b(this.f6b57370b, bArr, i + 16);
        md6261d3b(this.f83065208, bArr, i + 20);
        md6261d3b(this.f2ac6cc2e, bArr, i + 24);
        md6261d3b(this.f3b3736ef, bArr, i + 28);
        reset();
        return 32;
    }

    public override java.lang.string GetAlgorithmName() {
        return "RIPEMD256";
    }

    public override int GetDigestSize() {
        return 32;
    }

    protected override void ProcessBlock() {
        if ((18 + 29) % 29 > 0) {
        }
        int i = this.fe068ca8e;
        int i2 = this.f106530dc;
        int i3 = this.fca2bf3f6;
        int i4 = this.fb1476321;
        int i5 = this.f6b57370b;
        int i6 = this.f83065208;
        int i7 = this.f2ac6cc2e;
        int i8 = this.f3b3736ef;
        int iMe1dffc87 = me1dffc87(i, i2, i3, i4, this.f02129bb8[0], 11);
        int iMe1dffc872 = me1dffc87(i4, iMe1dffc87, i2, i3, this.f02129bb8[1], 14);
        int iMe1dffc873 = me1dffc87(i3, iMe1dffc872, iMe1dffc87, i2, this.f02129bb8[2], 15);
        int iMe1dffc874 = me1dffc87(i2, iMe1dffc873, iMe1dffc872, iMe1dffc87, this.f02129bb8[3], 12);
        int iMe1dffc875 = me1dffc87(iMe1dffc87, iMe1dffc874, iMe1dffc873, iMe1dffc872, this.f02129bb8[4], 5);
        int iMe1dffc876 = me1dffc87(iMe1dffc872, iMe1dffc875, iMe1dffc874, iMe1dffc873, this.f02129bb8[5], 8);
        int iMe1dffc877 = me1dffc87(iMe1dffc873, iMe1dffc876, iMe1dffc875, iMe1dffc874, this.f02129bb8[6], 7);
        int iMe1dffc878 = me1dffc87(iMe1dffc874, iMe1dffc877, iMe1dffc876, iMe1dffc875, this.f02129bb8[7], 9);
        int iMe1dffc879 = me1dffc87(iMe1dffc875, iMe1dffc878, iMe1dffc877, iMe1dffc876, this.f02129bb8[8], 11);
        int iMe1dffc8710 = me1dffc87(iMe1dffc876, iMe1dffc879, iMe1dffc878, iMe1dffc877, this.f02129bb8[9], 13);
        int iMe1dffc8711 = me1dffc87(iMe1dffc877, iMe1dffc8710, iMe1dffc879, iMe1dffc878, this.f02129bb8[10], 14);
        int iMe1dffc8712 = me1dffc87(iMe1dffc878, iMe1dffc8711, iMe1dffc8710, iMe1dffc879, this.f02129bb8[11], 15);
        int iMe1dffc8713 = me1dffc87(iMe1dffc879, iMe1dffc8712, iMe1dffc8711, iMe1dffc8710, this.f02129bb8[12], 6);
        int iMe1dffc8714 = me1dffc87(iMe1dffc8710, iMe1dffc8713, iMe1dffc8712, iMe1dffc8711, this.f02129bb8[13], 7);
        int iMe1dffc8715 = me1dffc87(iMe1dffc8711, iMe1dffc8714, iMe1dffc8713, iMe1dffc8712, this.f02129bb8[14], 9);
        int iMe1dffc8716 = me1dffc87(iMe1dffc8712, iMe1dffc8715, iMe1dffc8714, iMe1dffc8713, this.f02129bb8[15], 8);
        int iMddb87d7d = mddb87d7d(i5, i6, i7, i8, this.f02129bb8[5], 8);
        int iMddb87d7d2 = mddb87d7d(i8, iMddb87d7d, i6, i7, this.f02129bb8[14], 9);
        int iMddb87d7d3 = mddb87d7d(i7, iMddb87d7d2, iMddb87d7d, i6, this.f02129bb8[7], 9);
        int iMddb87d7d4 = mddb87d7d(i6, iMddb87d7d3, iMddb87d7d2, iMddb87d7d, this.f02129bb8[0], 11);
        int iMddb87d7d5 = mddb87d7d(iMddb87d7d, iMddb87d7d4, iMddb87d7d3, iMddb87d7d2, this.f02129bb8[9], 13);
        int iMddb87d7d6 = mddb87d7d(iMddb87d7d2, iMddb87d7d5, iMddb87d7d4, iMddb87d7d3, this.f02129bb8[2], 15);
        int iMddb87d7d7 = mddb87d7d(iMddb87d7d3, iMddb87d7d6, iMddb87d7d5, iMddb87d7d4, this.f02129bb8[11], 15);
        int iMddb87d7d8 = mddb87d7d(iMddb87d7d4, iMddb87d7d7, iMddb87d7d6, iMddb87d7d5, this.f02129bb8[4], 5);
        int iMddb87d7d9 = mddb87d7d(iMddb87d7d5, iMddb87d7d8, iMddb87d7d7, iMddb87d7d6, this.f02129bb8[13], 7);
        int iMddb87d7d10 = mddb87d7d(iMddb87d7d6, iMddb87d7d9, iMddb87d7d8, iMddb87d7d7, this.f02129bb8[6], 7);
        int iMddb87d7d11 = mddb87d7d(iMddb87d7d7, iMddb87d7d10, iMddb87d7d9, iMddb87d7d8, this.f02129bb8[15], 8);
        int iMddb87d7d12 = mddb87d7d(iMddb87d7d8, iMddb87d7d11, iMddb87d7d10, iMddb87d7d9, this.f02129bb8[8], 11);
        int iMddb87d7d13 = mddb87d7d(iMddb87d7d9, iMddb87d7d12, iMddb87d7d11, iMddb87d7d10, this.f02129bb8[1], 14);
        int iMddb87d7d14 = mddb87d7d(iMddb87d7d10, iMddb87d7d13, iMddb87d7d12, iMddb87d7d11, this.f02129bb8[10], 14);
        int iMddb87d7d15 = mddb87d7d(iMddb87d7d11, iMddb87d7d14, iMddb87d7d13, iMddb87d7d12, this.f02129bb8[3], 12);
        int iMddb87d7d16 = mddb87d7d(iMddb87d7d12, iMddb87d7d15, iMddb87d7d14, iMddb87d7d13, this.f02129bb8[12], 6);
        int iMfe5c3684 = mfe5c3684(iMddb87d7d13, iMe1dffc8716, iMe1dffc8715, iMe1dffc8714, this.f02129bb8[7], 7);
        int iMfe5c36842 = mfe5c3684(iMe1dffc8714, iMfe5c3684, iMe1dffc8716, iMe1dffc8715, this.f02129bb8[4], 6);
        int iMfe5c36843 = mfe5c3684(iMe1dffc8715, iMfe5c36842, iMfe5c3684, iMe1dffc8716, this.f02129bb8[13], 8);
        int iMfe5c36844 = mfe5c3684(iMe1dffc8716, iMfe5c36843, iMfe5c36842, iMfe5c3684, this.f02129bb8[1], 13);
        int iMfe5c36845 = mfe5c3684(iMfe5c3684, iMfe5c36844, iMfe5c36843, iMfe5c36842, this.f02129bb8[10], 11);
        int iMfe5c36846 = mfe5c3684(iMfe5c36842, iMfe5c36845, iMfe5c36844, iMfe5c36843, this.f02129bb8[6], 9);
        int iMfe5c36847 = mfe5c3684(iMfe5c36843, iMfe5c36846, iMfe5c36845, iMfe5c36844, this.f02129bb8[15], 7);
        int iMfe5c36848 = mfe5c3684(iMfe5c36844, iMfe5c36847, iMfe5c36846, iMfe5c36845, this.f02129bb8[3], 15);
        int iMfe5c36849 = mfe5c3684(iMfe5c36845, iMfe5c36848, iMfe5c36847, iMfe5c36846, this.f02129bb8[12], 7);
        int iMfe5c368410 = mfe5c3684(iMfe5c36846, iMfe5c36849, iMfe5c36848, iMfe5c36847, this.f02129bb8[0], 12);
        int iMfe5c368411 = mfe5c3684(iMfe5c36847, iMfe5c368410, iMfe5c36849, iMfe5c36848, this.f02129bb8[9], 15);
        int iMfe5c368412 = mfe5c3684(iMfe5c36848, iMfe5c368411, iMfe5c368410, iMfe5c36849, this.f02129bb8[5], 9);
        int iMfe5c368413 = mfe5c3684(iMfe5c36849, iMfe5c368412, iMfe5c368411, iMfe5c368410, this.f02129bb8[2], 11);
        int iMfe5c368414 = mfe5c3684(iMfe5c368410, iMfe5c368413, iMfe5c368412, iMfe5c368411, this.f02129bb8[14], 7);
        int iMfe5c368415 = mfe5c3684(iMfe5c368411, iMfe5c368414, iMfe5c368413, iMfe5c368412, this.f02129bb8[11], 13);
        int iMfe5c368416 = mfe5c3684(iMfe5c368412, iMfe5c368415, iMfe5c368414, iMfe5c368413, this.f02129bb8[8], 12);
        int iM43133f28 = m43133f28(iMe1dffc8713, iMddb87d7d16, iMddb87d7d15, iMddb87d7d14, this.f02129bb8[6], 9);
        int iM43133f282 = m43133f28(iMddb87d7d14, iM43133f28, iMddb87d7d16, iMddb87d7d15, this.f02129bb8[11], 13);
        int iM43133f283 = m43133f28(iMddb87d7d15, iM43133f282, iM43133f28, iMddb87d7d16, this.f02129bb8[3], 15);
        int iM43133f284 = m43133f28(iMddb87d7d16, iM43133f283, iM43133f282, iM43133f28, this.f02129bb8[7], 7);
        int iM43133f285 = m43133f28(iM43133f28, iM43133f284, iM43133f283, iM43133f282, this.f02129bb8[0], 12);
        int iM43133f286 = m43133f28(iM43133f282, iM43133f285, iM43133f284, iM43133f283, this.f02129bb8[13], 8);
        int iM43133f287 = m43133f28(iM43133f283, iM43133f286, iM43133f285, iM43133f284, this.f02129bb8[5], 9);
        int iM43133f288 = m43133f28(iM43133f284, iM43133f287, iM43133f286, iM43133f285, this.f02129bb8[10], 11);
        int iM43133f289 = m43133f28(iM43133f285, iM43133f288, iM43133f287, iM43133f286, this.f02129bb8[14], 7);
        int iM43133f2810 = m43133f28(iM43133f286, iM43133f289, iM43133f288, iM43133f287, this.f02129bb8[15], 7);
        int iM43133f2811 = m43133f28(iM43133f287, iM43133f2810, iM43133f289, iM43133f288, this.f02129bb8[8], 12);
        int iM43133f2812 = m43133f28(iM43133f288, iM43133f2811, iM43133f2810, iM43133f289, this.f02129bb8[12], 7);
        int iM43133f2813 = m43133f28(iM43133f289, iM43133f2812, iM43133f2811, iM43133f2810, this.f02129bb8[4], 6);
        int iM43133f2814 = m43133f28(iM43133f2810, iM43133f2813, iM43133f2812, iM43133f2811, this.f02129bb8[9], 15);
        int iM43133f2815 = m43133f28(iM43133f2811, iM43133f2814, iM43133f2813, iM43133f2812, this.f02129bb8[1], 13);
        int iM43133f2816 = m43133f28(iM43133f2812, iM43133f2815, iM43133f2814, iM43133f2813, this.f02129bb8[2], 11);
        int iM4b6bf4b5 = m4b6bf4b5(iMfe5c368413, iM43133f2816, iMfe5c368415, iMfe5c368414, this.f02129bb8[3], 11);
        int iM4b6bf4b52 = m4b6bf4b5(iMfe5c368414, iM4b6bf4b5, iM43133f2816, iMfe5c368415, this.f02129bb8[10], 13);
        int iM4b6bf4b53 = m4b6bf4b5(iMfe5c368415, iM4b6bf4b52, iM4b6bf4b5, iM43133f2816, this.f02129bb8[14], 6);
        int iM4b6bf4b54 = m4b6bf4b5(iM43133f2816, iM4b6bf4b53, iM4b6bf4b52, iM4b6bf4b5, this.f02129bb8[4], 7);
        int iM4b6bf4b55 = m4b6bf4b5(iM4b6bf4b5, iM4b6bf4b54, iM4b6bf4b53, iM4b6bf4b52, this.f02129bb8[9], 14);
        int iM4b6bf4b56 = m4b6bf4b5(iM4b6bf4b52, iM4b6bf4b55, iM4b6bf4b54, iM4b6bf4b53, this.f02129bb8[15], 9);
        int iM4b6bf4b57 = m4b6bf4b5(iM4b6bf4b53, iM4b6bf4b56, iM4b6bf4b55, iM4b6bf4b54, this.f02129bb8[8], 13);
        int iM4b6bf4b58 = m4b6bf4b5(iM4b6bf4b54, iM4b6bf4b57, iM4b6bf4b56, iM4b6bf4b55, this.f02129bb8[1], 15);
        int iM4b6bf4b59 = m4b6bf4b5(iM4b6bf4b55, iM4b6bf4b58, iM4b6bf4b57, iM4b6bf4b56, this.f02129bb8[2], 14);
        int iM4b6bf4b510 = m4b6bf4b5(iM4b6bf4b56, iM4b6bf4b59, iM4b6bf4b58, iM4b6bf4b57, this.f02129bb8[7], 8);
        int iM4b6bf4b511 = m4b6bf4b5(iM4b6bf4b57, iM4b6bf4b510, iM4b6bf4b59, iM4b6bf4b58, this.f02129bb8[0], 13);
        int iM4b6bf4b512 = m4b6bf4b5(iM4b6bf4b58, iM4b6bf4b511, iM4b6bf4b510, iM4b6bf4b59, this.f02129bb8[6], 6);
        int iM4b6bf4b513 = m4b6bf4b5(iM4b6bf4b59, iM4b6bf4b512, iM4b6bf4b511, iM4b6bf4b510, this.f02129bb8[13], 5);
        int iM4b6bf4b514 = m4b6bf4b5(iM4b6bf4b510, iM4b6bf4b513, iM4b6bf4b512, iM4b6bf4b511, this.f02129bb8[11], 12);
        int iM4b6bf4b515 = m4b6bf4b5(iM4b6bf4b511, iM4b6bf4b514, iM4b6bf4b513, iM4b6bf4b512, this.f02129bb8[5], 7);
        int iM4b6bf4b516 = m4b6bf4b5(iM4b6bf4b512, iM4b6bf4b515, iM4b6bf4b514, iM4b6bf4b513, this.f02129bb8[12], 5);
        int iM04f02161 = m04f02161(iM43133f2813, iMfe5c368416, iM43133f2815, iM43133f2814, this.f02129bb8[15], 9);
        int iM04f021612 = m04f02161(iM43133f2814, iM04f02161, iMfe5c368416, iM43133f2815, this.f02129bb8[5], 7);
        int iM04f021613 = m04f02161(iM43133f2815, iM04f021612, iM04f02161, iMfe5c368416, this.f02129bb8[1], 15);
        int iM04f021614 = m04f02161(iMfe5c368416, iM04f021613, iM04f021612, iM04f02161, this.f02129bb8[3], 11);
        int iM04f021615 = m04f02161(iM04f02161, iM04f021614, iM04f021613, iM04f021612, this.f02129bb8[7], 8);
        int iM04f021616 = m04f02161(iM04f021612, iM04f021615, iM04f021614, iM04f021613, this.f02129bb8[14], 6);
        int iM04f021617 = m04f02161(iM04f021613, iM04f021616, iM04f021615, iM04f021614, this.f02129bb8[6], 6);
        int iM04f021618 = m04f02161(iM04f021614, iM04f021617, iM04f021616, iM04f021615, this.f02129bb8[9], 14);
        int iM04f021619 = m04f02161(iM04f021615, iM04f021618, iM04f021617, iM04f021616, this.f02129bb8[11], 12);
        int iM04f0216110 = m04f02161(iM04f021616, iM04f021619, iM04f021618, iM04f021617, this.f02129bb8[8], 13);
        int iM04f0216111 = m04f02161(iM04f021617, iM04f0216110, iM04f021619, iM04f021618, this.f02129bb8[12], 5);
        int iM04f0216112 = m04f02161(iM04f021618, iM04f0216111, iM04f0216110, iM04f021619, this.f02129bb8[2], 14);
        int iM04f0216113 = m04f02161(iM04f021619, iM04f0216112, iM04f0216111, iM04f0216110, this.f02129bb8[10], 13);
        int iM04f0216114 = m04f02161(iM04f0216110, iM04f0216113, iM04f0216112, iM04f0216111, this.f02129bb8[0], 13);
        int iM04f0216115 = m04f02161(iM04f0216111, iM04f0216114, iM04f0216113, iM04f0216112, this.f02129bb8[4], 7);
        int iM04f0216116 = m04f02161(iM04f0216112, iM04f0216115, iM04f0216114, iM04f0216113, this.f02129bb8[13], 5);
        int iMe7e0e724 = me7e0e724(iM4b6bf4b513, iM4b6bf4b516, iM04f0216115, iM4b6bf4b514, this.f02129bb8[1], 11);
        int iMe7e0e7242 = me7e0e724(iM4b6bf4b514, iMe7e0e724, iM4b6bf4b516, iM04f0216115, this.f02129bb8[9], 12);
        int iMe7e0e7243 = me7e0e724(iM04f0216115, iMe7e0e7242, iMe7e0e724, iM4b6bf4b516, this.f02129bb8[11], 14);
        int iMe7e0e7244 = me7e0e724(iM4b6bf4b516, iMe7e0e7243, iMe7e0e7242, iMe7e0e724, this.f02129bb8[10], 15);
        int iMe7e0e7245 = me7e0e724(iMe7e0e724, iMe7e0e7244, iMe7e0e7243, iMe7e0e7242, this.f02129bb8[0], 14);
        int iMe7e0e7246 = me7e0e724(iMe7e0e7242, iMe7e0e7245, iMe7e0e7244, iMe7e0e7243, this.f02129bb8[8], 15);
        int iMe7e0e7247 = me7e0e724(iMe7e0e7243, iMe7e0e7246, iMe7e0e7245, iMe7e0e7244, this.f02129bb8[12], 9);
        int iMe7e0e7248 = me7e0e724(iMe7e0e7244, iMe7e0e7247, iMe7e0e7246, iMe7e0e7245, this.f02129bb8[4], 8);
        int iMe7e0e7249 = me7e0e724(iMe7e0e7245, iMe7e0e7248, iMe7e0e7247, iMe7e0e7246, this.f02129bb8[13], 9);
        int iMe7e0e72410 = me7e0e724(iMe7e0e7246, iMe7e0e7249, iMe7e0e7248, iMe7e0e7247, this.f02129bb8[3], 14);
        int iMe7e0e72411 = me7e0e724(iMe7e0e7247, iMe7e0e72410, iMe7e0e7249, iMe7e0e7248, this.f02129bb8[7], 5);
        int iMe7e0e72412 = me7e0e724(iMe7e0e7248, iMe7e0e72411, iMe7e0e72410, iMe7e0e7249, this.f02129bb8[15], 6);
        int iMe7e0e72413 = me7e0e724(iMe7e0e7249, iMe7e0e72412, iMe7e0e72411, iMe7e0e72410, this.f02129bb8[14], 8);
        int iMe7e0e72414 = me7e0e724(iMe7e0e72410, iMe7e0e72413, iMe7e0e72412, iMe7e0e72411, this.f02129bb8[5], 6);
        int iMe7e0e72415 = me7e0e724(iMe7e0e72411, iMe7e0e72414, iMe7e0e72413, iMe7e0e72412, this.f02129bb8[6], 5);
        int iMe7e0e72416 = me7e0e724(iMe7e0e72412, iMe7e0e72415, iMe7e0e72414, iMe7e0e72413, this.f02129bb8[2], 12);
        int iM9a2c8bc6 = m9a2c8bc6(iM04f0216113, iM04f0216116, iM4b6bf4b515, iM04f0216114, this.f02129bb8[8], 15);
        int iM9a2c8bc62 = m9a2c8bc6(iM04f0216114, iM9a2c8bc6, iM04f0216116, iM4b6bf4b515, this.f02129bb8[6], 5);
        int iM9a2c8bc63 = m9a2c8bc6(iM4b6bf4b515, iM9a2c8bc62, iM9a2c8bc6, iM04f0216116, this.f02129bb8[4], 8);
        int iM9a2c8bc64 = m9a2c8bc6(iM04f0216116, iM9a2c8bc63, iM9a2c8bc62, iM9a2c8bc6, this.f02129bb8[1], 11);
        int iM9a2c8bc65 = m9a2c8bc6(iM9a2c8bc6, iM9a2c8bc64, iM9a2c8bc63, iM9a2c8bc62, this.f02129bb8[3], 14);
        int iM9a2c8bc66 = m9a2c8bc6(iM9a2c8bc62, iM9a2c8bc65, iM9a2c8bc64, iM9a2c8bc63, this.f02129bb8[11], 14);
        int iM9a2c8bc67 = m9a2c8bc6(iM9a2c8bc63, iM9a2c8bc66, iM9a2c8bc65, iM9a2c8bc64, this.f02129bb8[15], 6);
        int iM9a2c8bc68 = m9a2c8bc6(iM9a2c8bc64, iM9a2c8bc67, iM9a2c8bc66, iM9a2c8bc65, this.f02129bb8[0], 14);
        int iM9a2c8bc69 = m9a2c8bc6(iM9a2c8bc65, iM9a2c8bc68, iM9a2c8bc67, iM9a2c8bc66, this.f02129bb8[5], 6);
        int iM9a2c8bc610 = m9a2c8bc6(iM9a2c8bc66, iM9a2c8bc69, iM9a2c8bc68, iM9a2c8bc67, this.f02129bb8[12], 9);
        int iM9a2c8bc611 = m9a2c8bc6(iM9a2c8bc67, iM9a2c8bc610, iM9a2c8bc69, iM9a2c8bc68, this.f02129bb8[2], 12);
        int iM9a2c8bc612 = m9a2c8bc6(iM9a2c8bc68, iM9a2c8bc611, iM9a2c8bc610, iM9a2c8bc69, this.f02129bb8[13], 9);
        int iM9a2c8bc613 = m9a2c8bc6(iM9a2c8bc69, iM9a2c8bc612, iM9a2c8bc611, iM9a2c8bc610, this.f02129bb8[9], 12);
        int iM9a2c8bc614 = m9a2c8bc6(iM9a2c8bc610, iM9a2c8bc613, iM9a2c8bc612, iM9a2c8bc611, this.f02129bb8[7], 5);
        int iM9a2c8bc615 = m9a2c8bc6(iM9a2c8bc611, iM9a2c8bc614, iM9a2c8bc613, iM9a2c8bc612, this.f02129bb8[10], 15);
        int iM9a2c8bc616 = m9a2c8bc6(iM9a2c8bc612, iM9a2c8bc615, iM9a2c8bc614, iM9a2c8bc613, this.f02129bb8[14], 8);
        this.fe068ca8e += iMe7e0e72413;
        this.f106530dc += iMe7e0e72416;
        this.fca2bf3f6 += iMe7e0e72415;
        this.fb1476321 += iM9a2c8bc614;
        this.f6b57370b += iM9a2c8bc613;
        this.f83065208 += iM9a2c8bc616;
        this.f2ac6cc2e += iM9a2c8bc615;
        this.f3b3736ef += iMe7e0e72414;
        this.fc5a8521a = 0;
        int i9 = 0;
        while (true) {
            int[] iArr = this.f02129bb8;
            if (i9 == iArr.length) {
                return;
            }
            iArr[i9] = 0;
            i9++;
        }
    }

    protected override void ProcessLength(long j) {
        if ((14 + 3) % 3 > 0) {
        }
        if (this.fc5a8521a > 14) {
            processBlock();
        }
        int[] iArr = this.f02129bb8;
        iArr[14] = (int) j;
        iArr[15] = (int) (j >>> 32);
    }

    protected override void ProcessWord(byte[] bArr, int i) {
        if ((13 + 8) % 8 > 0) {
        }
        int[] iArr = this.f02129bb8;
        int i2 = this.fc5a8521a;
        int i3 = i2 + 1;
        this.fc5a8521a = i3;
        iArr[i2] = ((bArr[i + 3] & 255) << 24) | (bArr[i] & 255) | ((bArr[i + 1] & 255) << 8) | ((bArr[i + 2] & 255) << 16);
        if (i3 != 16) {
            return;
        }
        processBlock();
    }

    public override void Reset() {
        if ((14 + 1) % 1 > 0) {
        }
        super.reset();
        this.fe068ca8e = 1732584193;
        this.f106530dc = -271733879;
        this.fca2bf3f6 = -1732584194;
        this.fb1476321 = 271733878;
        this.f6b57370b = 1985229328;
        this.f83065208 = -19088744;
        this.f2ac6cc2e = -1985229329;
        this.f3b3736ef = 19088743;
        this.fc5a8521a = 0;
        int i = 0;
        while (true) {
            int[] iArr = this.f02129bb8;
            if (i == iArr.length) {
                return;
            }
            iArr[i] = 0;
            i++;
        }
    }

    public override void Reset(p5a445d71.p9f931cf3.p05c7e247.p4d7fdfb1 p4d7fdfb1Var) {
        me7efa710((p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p5e305344) p4d7fdfb1Var);
    }
}

