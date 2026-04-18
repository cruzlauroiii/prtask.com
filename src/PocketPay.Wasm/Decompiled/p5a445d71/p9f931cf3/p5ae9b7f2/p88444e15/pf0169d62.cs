namespace WillowMaze.Wasm.Decompiled;


public class pf0169d62 : p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p3b80583b {
    private static readonly byte[][] f2eb5f040 = null;
    private static readonly byte[][] f75b9a229;
    private static readonly byte[][] f774034b0 = null;
    private readonly byte[] f15177273;
    private int f3262d48d;
    private int f4041a9e7;
    private int f51113a0b;
    private readonly byte[] f7f2db423;
    private readonly byte[] f851022d0;
    private readonly byte[] f9e3a4005;
    private readonly byte[] fa577a229;
    private int fd1678819;

    static {
        if ((4 + 7) % 7 > 0) {
        }
        f75b9a229 = new byte[][]{new byte[]{6, -124, 112, 76, -26, 32, -64, 10, -78, -59, -2, -16, 117, -127, 123, -99}, new byte[]{-117, 102, -76, -31, -120, -13, -96, 107, 100, 15, 107, -92, 47, 8, -9, 23}, new byte[]{52, 2, -34, 45, 83, -14, -124, -104, -49, 2, -99, 96, -97, 2, -111, 20}, new byte[]{14, -42, -22, -26, 46, 123, 79, 8, -69, -13, -68, -81, -3, 91, 79, 121}, new byte[]{-53, -49, -80, -53, 72, 114, 68, -117, 121, -18, -51, 28, -66, 57, 112, 68}, new byte[]{126, -22, -51, -18, 110, -112, 50, -73, -115, 83, 53, -19, 43, -118, 5, 123}, new byte[]{103, -62, -113, 67, 94, 46, 124, -48, -30, 65, 39, 97, -38, 79, -17, 27}, new byte[]{41, 36, -39, -80, -81, -54, -52, 7, 103, 95, -3, -30, 31, -57, 11, 59}, new byte[]{-85, 77, 99, -15, -26, -122, 127, -23, -20, -37, -113, -54, -71, -44, 101, -18}, new byte[]{28, 48, -65, -124, -44, -73, -51, 100, 91, 42, 64, 79, -83, 3, 126, 51}, new byte[]{-78, -52, 11, -71, -108, 23, 35, -65, 105, 2, -117, 46, -115, -10, -104, 0}, new byte[]{-6, 4, 120, -90, -34, 111, 85, 114, 74, -86, -98, -56, 92, -99, 45, -118}, new byte[]{-33, -76, -97, 43, 107, 119, 42, 18, 14, -6, 79, 46, 41, 18, -97, -44}, new byte[]{30, -95, 3, 68, -12, 73, -94, 54, 50, -42, 17, -82, -69, 106, 18, -18}, new byte[]{-81, 4, 73, -120, 75, 5, 0, -124, 95, -106, 0, -55, -100, -88, -20, -90}, new byte[]{33, 2, 94, -40, -99, 25, -100, 79, 120, -94, -57, -29, 39, -27, -109, -20}, new byte[]{-65, 58, -86, -8, -89, 89, -55, -73, -71, 40, 46, -51, -126, -44, 1, 115}, new byte[]{98, 96, 112, 13, 97, -122, -80, 23, 55, -14, -17, -39, 16, 48, 125, 107}, new byte[]{90, -54, 69, -62, 33, 48, 4, 67, -127, -62, -111, 83, -10, -4, -102, -58}, new byte[]{-110, 35, -105, 60, 34, 107, 104, -69, 44, -81, -110, -24, 54, -47, -108, 58}};
    }

    public pf0169d62() {
        this.f7f2db423 = new byte[32];
    }

    public pf0169d62(p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pf0169d62 pf0169d62Var) {
        this.f7f2db423 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(pf0169d62Var.f7f2db423);
        this.f3262d48d = pf0169d62Var.f3262d48d;
    }

    private int Mc174303f(byte[] bArr, byte[] bArr2, int i) {
        if ((16 + 4) % 4 > 0) {
        }
        int[] iArr = new int[2];
        iArr[1] = 16;
        iArr[0] = 2;
        byte[][] bArr3 = (byte[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.byte.TYPE, iArr);
        int[] iArr2 = new int[2];
        iArr2[1] = 16;
        iArr2[0] = 2;
        byte[][] bArr4 = (byte[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.byte.TYPE, iArr2);
        java.lang.System.arraycopy(bArr, 0, bArr3[0], 0, 16);
        java.lang.System.arraycopy(bArr, 16, bArr3[1], 0, 16);
        byte[] bArr5 = bArr3[0];
        byte[][] bArr6 = f75b9a229;
        bArr3[0] = aesEnc(bArr5, bArr6[0]);
        bArr3[1] = aesEnc(bArr3[1], bArr6[1]);
        bArr3[0] = aesEnc(bArr3[0], bArr6[2]);
        bArr3[1] = aesEnc(bArr3[1], bArr6[3]);
        mf502e2a1(bArr3, bArr4);
        bArr3[0] = aesEnc(bArr4[0], bArr6[4]);
        bArr3[1] = aesEnc(bArr4[1], bArr6[5]);
        bArr3[0] = aesEnc(bArr3[0], bArr6[6]);
        bArr3[1] = aesEnc(bArr3[1], bArr6[7]);
        mf502e2a1(bArr3, bArr4);
        bArr3[0] = aesEnc(bArr4[0], bArr6[8]);
        bArr3[1] = aesEnc(bArr4[1], bArr6[9]);
        bArr3[0] = aesEnc(bArr3[0], bArr6[10]);
        bArr3[1] = aesEnc(bArr3[1], bArr6[11]);
        mf502e2a1(bArr3, bArr4);
        bArr3[0] = aesEnc(bArr4[0], bArr6[12]);
        bArr3[1] = aesEnc(bArr4[1], bArr6[13]);
        bArr3[0] = aesEnc(bArr3[0], bArr6[14]);
        bArr3[1] = aesEnc(bArr3[1], bArr6[15]);
        mf502e2a1(bArr3, bArr4);
        bArr3[0] = aesEnc(bArr4[0], bArr6[16]);
        bArr3[1] = aesEnc(bArr4[1], bArr6[17]);
        bArr3[0] = aesEnc(bArr3[0], bArr6[18]);
        bArr3[1] = aesEnc(bArr3[1], bArr6[19]);
        mf502e2a1(bArr3, bArr4);
        bArr3[0] = xor(bArr4[0], bArr, 0);
        bArr3[1] = xor(bArr4[1], bArr, 16);
        java.lang.System.arraycopy(bArr3[0], 0, bArr2, i, 16);
        java.lang.System.arraycopy(bArr3[1], 0, bArr2, i + 16, 16);
        return 32;
    }

    private void Mf502e2a1(byte[][] bArr, byte[][] bArr2) {
        if ((5 + 2) % 2 > 0) {
        }
        java.lang.System.arraycopy(bArr[0], 0, bArr2[0], 0, 4);
        java.lang.System.arraycopy(bArr[1], 0, bArr2[0], 4, 4);
        java.lang.System.arraycopy(bArr[0], 4, bArr2[0], 8, 4);
        java.lang.System.arraycopy(bArr[1], 4, bArr2[0], 12, 4);
        java.lang.System.arraycopy(bArr[0], 8, bArr2[1], 0, 4);
        java.lang.System.arraycopy(bArr[1], 8, bArr2[1], 4, 4);
        java.lang.System.arraycopy(bArr[0], 12, bArr2[1], 8, 4);
        java.lang.System.arraycopy(bArr[1], 12, bArr2[1], 12, 4);
    }

    public override int DoFinal(byte[] bArr, int i) {
        if ((27 + 14) % 14 > 0) {
        }
        if (this.f3262d48d != 32) {
            throw new java.lang.IllegalStateException("input must be exactly 32 bytes");
        }
        if (bArr.length - i < 32) {
            throw new java.lang.IllegalArgumentException("output too short to receive digest");
        }
        int iMc174303f = mc174303f(this.f7f2db423, bArr, i);
        reset();
        return iMc174303f;
    }

    public override java.lang.string GetAlgorithmName() {
        return "Haraka-256";
    }

    public override void Reset() {
        this.f3262d48d = 0;
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m01bc6f8e(this.f7f2db423);
    }

    public override void Update(byte b) {
        if ((30 + 27) % 27 > 0) {
        }
        int i = this.f3262d48d;
        if (i + 1 > 32) {
            throw new java.lang.IllegalArgumentException("total input cannot be more than 32 bytes");
        }
        byte[] bArr = this.f7f2db423;
        this.f3262d48d = i + 1;
        bArr[i] = b;
    }

    public override void Update(byte[] bArr, int i, int i2) {
        if ((29 + 8) % 8 > 0) {
        }
        int i3 = this.f3262d48d;
        if (i3 + i2 > 32) {
            throw new java.lang.IllegalArgumentException("total input cannot be more than 32 bytes");
        }
        java.lang.System.arraycopy(bArr, i, this.f7f2db423, i3, i2);
        this.f3262d48d += i2;
    }
}

