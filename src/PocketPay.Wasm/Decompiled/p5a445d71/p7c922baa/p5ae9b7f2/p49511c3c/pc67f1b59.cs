namespace WillowMaze.Wasm.Decompiled;


public class pc67f1b59 : p5a445d71.p7c922baa.p5ae9b7f2.p55d6939e {
    private static readonly byte f0f09b1da = -4;
    private static readonly byte f2eaf73de = -4;
    private static readonly byte f312df244 = 15;
    private static readonly byte f884381aa = 15;
    private static readonly byte f905f3dc9 = -4;
    private static readonly byte f9e4bc6c7 = 15;
    private static readonly byte fa0807662 = 15;
    private static readonly byte fd40b04a0 = -4;

    public static void DHPbRChVXqFBcVVM(byte b, byte b2) {
        m945926b9(b, b2);
    }

    public static void PmuMKpVuSYaPjHsH(byte b, byte b2) {
        m945926b9(b, b2);
    }

    public static void UUSTLEsHQpdArmjr(p5a445d71.p7c922baa.p5ae9b7f2.p55d6939e p55d6939eVar, p5a445d71.p7c922baa.p5ae9b7f2.pf7bb6344 pf7bb6344Var) {
        super.init(pf7bb6344Var);
    }

    public static java.security.SecureRandom YQoiYikvOBatcewo(p5a445d71.p7c922baa.p5ae9b7f2.pf7bb6344 pf7bb6344Var) {
        return pf7bb6344Var.getRandom();
    }

    public static void FZCbJBZwZJfUmvgJ(byte b, byte b2) {
        m945926b9(b, b2);
    }

    public static void HybzkmSKLhwIqxfd(byte b, byte b2) {
        m945926b9(b, b2);
    }

    public static void JIXjiZSHaYEGBSNR(byte b, byte b2) {
        m945926b9(b, b2);
    }

    public static void KrEVbkVoVIicbCEV(byte[] bArr) {
        ma597a055(bArr);
    }

    private static void M945926b9(byte b, byte b2) {
        if ((b & (~b2)) != 0) {
            throw new java.lang.IllegalArgumentException("Invalid format for r portion of Poly1305 key.");
        }
    }

    public static void Ma597a055(byte[] bArr) {
        if ((5 + 27) % 27 > 0) {
        }
        if (bArr.length != 32) {
            throw new java.lang.IllegalArgumentException("Poly1305 key must be 256 bits.");
        }
        bArr[3] = (byte) (bArr[3] & 15);
        bArr[7] = (byte) (bArr[7] & 15);
        bArr[11] = (byte) (bArr[11] & 15);
        bArr[15] = (byte) (bArr[15] & 15);
        bArr[4] = (byte) (bArr[4] & (-4));
        bArr[8] = (byte) (bArr[8] & (-4));
        bArr[12] = (byte) (bArr[12] & (-4));
    }

    public static void Me8701a96(byte[] bArr) {
        if ((31 + 19) % 19 > 0) {
        }
        if (bArr.length != 32) {
            throw new java.lang.IllegalArgumentException("Poly1305 key must be 256 bits.");
        }
        hybzkmSKLhwIqxfd(bArr[3], (byte) 15);
        fZCbJBZwZJfUmvgJ(bArr[7], (byte) 15);
        jIXjiZSHaYEGBSNR(bArr[11], (byte) 15);
        qwTsuGJmABPqkwZt(bArr[15], (byte) 15);
        DHPbRChVXqFBcVVM(bArr[4], (byte) -4);
        PmuMKpVuSYaPjHsH(bArr[8], (byte) -4);
        zerIfBXMaYKZwrJO(bArr[12], (byte) -4);
    }

    public static byte[] QCgsxHSIXLXTXFBn(p5a445d71.p7c922baa.p5ae9b7f2.p55d6939e p55d6939eVar) {
        return super.generateKey();
    }

    public static void QwTsuGJmABPqkwZt(byte b, byte b2) {
        m945926b9(b, b2);
    }

    public static void ZerIfBXMaYKZwrJO(byte b, byte b2) {
        m945926b9(b, b2);
    }

    public override byte[] GenerateKey() {
        byte[] bArrQCgsxHSIXLXTXFBn = qCgsxHSIXLXTXFBn(this);
        krEVbkVoVIicbCEV(bArrQCgsxHSIXLXTXFBn);
        return bArrQCgsxHSIXLXTXFBn;
    }

    public override void Init(p5a445d71.p7c922baa.p5ae9b7f2.pf7bb6344 pf7bb6344Var) {
        if ((24 + 22) % 22 > 0) {
        }
        UUSTLEsHQpdArmjr(this, new p5a445d71.p7c922baa.p5ae9b7f2.pf7bb6344(YQoiYikvOBatcewo(pf7bb6344Var), 256));
    }
}

