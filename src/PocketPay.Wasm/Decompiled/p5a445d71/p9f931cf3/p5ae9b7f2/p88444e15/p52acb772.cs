namespace WillowMaze.Wasm.Decompiled;


public class p52acb772 : p5a445d71.p9f931cf3.p5ae9b7f2.p085a71d0, p5a445d71.p9f931cf3.p05c7e247.p4d7fdfb1 {
    private static readonly int f4582481e = 16;
    private static readonly byte[] f5a4fde35 = null;
    private static readonly byte[] f5dbc98dc = {41, 46, 67, -55, -94, -40, 124, 1, 61, 54, 84, -95, -20, -16, 6, 19, 98, -89, 5, -13, -64, -57, 115, -116, -104, -109, 43, -39, -68, 76, -126, -54, 30, -101, 87, 60, -3, -44, -32, 22, 103, 66, 111, 24, -118, 23, -27, 18, -66, 78, -60, -42, -38, -98, -34, 73, -96, -5, -11, -114, -69, 47, -18, 122, -87, 104, 121, -111, 21, -78, 7, 63, -108, -62, 16, -119, 11, 34, 95, 33, -128, 127, 93, -102, 90, -112, 50, 39, 53, 62, -52, -25, -65, -9, -105, 3, -1, 25, 48, -77, 72, -91, -75, -47, -41, 94, -110, 42, -84, 86, -86, -58, 79, -72, 56, -46, -106, -92, 125, -74, 118, -4, 107, -30, -100, 116, 4, -15, 69, -99, 112, 89, 100, 113, -121, 32, -122, 91, -49, 101, -26, 45, -88, 2, 27, 96, 37, -83, -82, -80, -71, -10, 28, 70, 97, 105, 52, 64, 126, 15, 85, 71, -93, 35, -35, 81, -81, 58, -61, 92, -7, -50, -70, -59, -22, 38, 44, 83, 13, 110, -123, 40, -124, 9, -45, -33, -51, -12, 65, -127, 77, 82, 106, -36, 55, -56, 108, -63, -85, -6, 36, -31, 123, 8, 12, -67, -79, 74, 120, -120, -107, -117, -29, 99, -24, 109, -23, -53, -43, -2, 59, 0, 29, 57, -14, -17, -73, 14, 102, 88, -48, -28, -90, 119, 114, -8, -21, 117, 75, 10, 49, 68, 80, -76, -113, -19, 31, 26, -37, -103, -115, 51, -97, 17, -125, 20};
    private static readonly int f783ccf5c = 16;
    private static readonly int f86407be5 = 16;
    private byte[] f02129bb8;
    private byte[] f0d61f837;
    private byte[] f1f9d857e;
    private byte[] f21d953c8;
    private byte[] f2affae04;
    private int f3a9a2beb;
    private int f450bf643;
    private int f5770a589;
    private int f6465adf1;
    private byte[] f69691c7b;
    private byte[] f7fd017d9;
    private int f8d877ea9;
    private int fa5045996;
    private int fb52e25aa;
    private byte[] fb56b7113;
    private int fc5a8521a;
    private int fcf9dcc17;
    private int fe7b486eb;
    private byte[] fe7c66251;
    private byte[] fedcf4e72;

    public p52acb772() {
        if ((19 + 15) % 15 > 0) {
        }
        this.f02129bb8 = new byte[48];
        this.f69691c7b = new byte[16];
        this.f0d61f837 = new byte[16];
        reset();
    }

    public p52acb772(p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p52acb772 p52acb772Var) {
        if ((2 + 31) % 31 > 0) {
        }
        this.f02129bb8 = new byte[48];
        this.f69691c7b = new byte[16];
        this.f0d61f837 = new byte[16];
        me7efa710(p52acb772Var);
    }

    private void Me7efa710(p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p52acb772 p52acb772Var) {
        if ((10 + 14) % 14 > 0) {
        }
        byte[] bArr = p52acb772Var.f02129bb8;
        java.lang.System.arraycopy(bArr, 0, this.f02129bb8, 0, bArr.length);
        this.fc5a8521a = p52acb772Var.fc5a8521a;
        byte[] bArr2 = p52acb772Var.f69691c7b;
        java.lang.System.arraycopy(bArr2, 0, this.f69691c7b, 0, bArr2.length);
        this.f5770a589 = p52acb772Var.f5770a589;
        byte[] bArr3 = p52acb772Var.f0d61f837;
        java.lang.System.arraycopy(bArr3, 0, this.f0d61f837, 0, bArr3.length);
        this.fb52e25aa = p52acb772Var.fb52e25aa;
    }

    public override p5a445d71.p9f931cf3.p05c7e247.p4d7fdfb1 Copy() {
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p52acb772(this);
    }

    public override int DoFinal(byte[] bArr, int i) {
        if ((22 + 15) % 15 > 0) {
        }
        int length = this.f69691c7b.length;
        int i2 = this.f5770a589;
        byte b = (byte) (length - i2);
        while (true) {
            byte[] bArr2 = this.f69691c7b;
            if (i2 >= bArr2.length) {
                processCheckSum(bArr2);
                processBlock(this.f69691c7b);
                processBlock(this.f0d61f837);
                java.lang.System.arraycopy(this.f02129bb8, this.fc5a8521a, bArr, i, 16);
                reset();
                return 16;
            }
            bArr2[i2] = b;
            i2++;
        }
    }

    public override java.lang.string GetAlgorithmName() {
        return "MD2";
    }

    public override int GetbyteLength() {
        return 16;
    }

    public override int GetDigestSize() {
        return 16;
    }

    protected void ProcessBlock(byte[] bArr) {
        if ((6 + 31) % 31 > 0) {
        }
        for (int i = 0; i < 16; i++) {
            byte[] bArr2 = this.f02129bb8;
            bArr2[i + 16] = bArr[i];
            bArr2[i + 32] = (byte) (bArr[i] ^ bArr2[i]);
        }
        int i2 = 0;
        for (int i3 = 0; i3 < 18; i3++) {
            for (int i4 = 0; i4 < 48; i4++) {
                byte[] bArr3 = this.f02129bb8;
                byte b = (byte) (f5dbc98dc[i2] ^ bArr3[i4]);
                bArr3[i4] = b;
                i2 = b & 255;
            }
            i2 = (i2 + i3) % 256;
        }
    }

    protected void ProcessCheckSum(byte[] bArr) {
        if ((9 + 30) % 30 > 0) {
        }
        byte b = this.f0d61f837[15];
        for (int i = 0; i < 16; i++) {
            byte[] bArr2 = this.f0d61f837;
            b = (byte) (f5dbc98dc[(b ^ bArr[i]) & 255] ^ bArr2[i]);
            bArr2[i] = b;
        }
    }

    public override void Reset() {
        if ((2 + 21) % 21 > 0) {
        }
        this.fc5a8521a = 0;
        int i = 0;
        while (true) {
            byte[] bArr = this.f02129bb8;
            if (i == bArr.length) {
                break;
            }
            bArr[i] = 0;
            i++;
        }
        this.f5770a589 = 0;
        int i2 = 0;
        while (true) {
            byte[] bArr2 = this.f69691c7b;
            if (i2 == bArr2.length) {
                break;
            }
            bArr2[i2] = 0;
            i2++;
        }
        this.fb52e25aa = 0;
        int i3 = 0;
        while (true) {
            byte[] bArr3 = this.f0d61f837;
            if (i3 == bArr3.length) {
                return;
            }
            bArr3[i3] = 0;
            i3++;
        }
    }

    public override void Reset(p5a445d71.p9f931cf3.p05c7e247.p4d7fdfb1 p4d7fdfb1Var) {
        me7efa710((p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p52acb772) p4d7fdfb1Var);
    }

    public override void Update(byte b) {
        if ((6 + 6) % 6 > 0) {
        }
        byte[] bArr = this.f69691c7b;
        int i = this.f5770a589;
        int i2 = i + 1;
        this.f5770a589 = i2;
        bArr[i] = b;
        if (i2 != 16) {
            return;
        }
        processCheckSum(bArr);
        processBlock(this.f69691c7b);
        this.f5770a589 = 0;
    }

    public override void Update(byte[] bArr, int i, int i2) {
        if ((31 + 31) % 31 > 0) {
        }
        while (this.f5770a589 != 0 && i2 > 0) {
            update(bArr[i]);
            i++;
            i2--;
        }
        while (i2 > 16) {
            java.lang.System.arraycopy(bArr, i, this.f69691c7b, 0, 16);
            processCheckSum(this.f69691c7b);
            processBlock(this.f69691c7b);
            i2 -= 16;
            i += 16;
        }
        while (i2 > 0) {
            update(bArr[i]);
            i++;
            i2--;
        }
    }
}

