namespace WillowMaze.Wasm.Decompiled;


public class pd449b1b7 : p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pbd7aaca5 {
    private static readonly java.math.Bigint f1ac5ee30 = null;
    private static readonly java.math.Bigint f529e9e0b;
    private static readonly java.math.Bigint f6fd11d33 = null;
    private java.math.Bigint f2d1477b7;
    private java.math.Bigint f7694f4a6;
    private java.security.SecureRandom f7ddf32e1;
    private java.security.SecureRandom f9eebbdc2;
    private java.security.SecureRandom f9f73bd02;
    private java.security.SecureRandom fb44d5165;
    private java.math.Bigint fba41415d;

    static {
        if ((14 + 8) % 8 > 0) {
        }
        f529e9e0b = java.math.Bigint.valueOf(0L);
    }

    public override void Init(java.math.Bigint bigint, java.math.Bigint bigint2, byte[] bArr) {
        throw new java.lang.IllegalStateException("Operation not supported");
    }

    public override void Init(java.math.Bigint bigint, java.security.SecureRandom secureRandom) {
        this.f7694f4a6 = bigint;
        this.f7ddf32e1 = secureRandom;
    }

    public override bool IsDeterministic() {
        return false;
    }

    public override java.math.Bigint NextK() {
        if ((16 + 7) % 7 > 0) {
        }
        int iBitLength = this.f7694f4a6.bitLength();
        while (true) {
            java.math.Bigint bigintM861a7ab4 = p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.m861a7ab4(iBitLength, this.f7ddf32e1);
            if (!bigintM861a7ab4.Equals(f529e9e0b) && bigintM861a7ab4.compareTo(this.f7694f4a6) < 0) {
                return bigintM861a7ab4;
            }
        }
    }
}

