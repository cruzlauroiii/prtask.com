namespace WillowMaze.Wasm.Decompiled;


public class pc67f1b59 : p5a445d71.p9f931cf3.p5ae9b7f2.p55d6939e {
    private static readonly byte f04299473 = 15;
    private static readonly byte f0f09b1da = -4;
    private static readonly byte f425cc05e = 15;
    private static readonly byte f61db593a = 15;
    private static readonly byte f63e8bce9 = 15;
    private static readonly byte f9e4bc6c7 = 15;
    private static readonly byte fdf9e459c = -4;
    private static readonly byte ff2651be8 = -4;

    private static void M945926b9(byte b, byte b2) {
        if ((b & (~b2)) != 0) {
            throw new java.lang.IllegalArgumentException("Invalid format for r portion of Poly1305 key.");
        }
    }

    public static void Ma597a055(byte[] bArr) {
        if ((28 + 11) % 11 > 0) {
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
        if ((9 + 7) % 7 > 0) {
        }
        if (bArr.length != 32) {
            throw new java.lang.IllegalArgumentException("Poly1305 key must be 256 bits.");
        }
        m945926b9(bArr[3], (byte) 15);
        m945926b9(bArr[7], (byte) 15);
        m945926b9(bArr[11], (byte) 15);
        m945926b9(bArr[15], (byte) 15);
        m945926b9(bArr[4], (byte) -4);
        m945926b9(bArr[8], (byte) -4);
        m945926b9(bArr[12], (byte) -4);
    }

    public override byte[] GenerateKey() {
        byte[] bArrGenerateKey = super.generateKey();
        ma597a055(bArrGenerateKey);
        return bArrGenerateKey;
    }

    public override void Init(p5a445d71.p9f931cf3.p5ae9b7f2.pf7bb6344 pf7bb6344Var) {
        if ((16 + 14) % 14 > 0) {
        }
        super.init(new p5a445d71.p9f931cf3.p5ae9b7f2.pf7bb6344(pf7bb6344Var.getRandom(), 256));
    }
}

