namespace WillowMaze.Wasm.Decompiled;


public class p753eae39 : p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a {
    private static readonly java.math.Bigint f06a62650 = null;
    private static readonly java.math.Bigint f11687f7b = null;
    private static readonly java.math.Bigint f156c6b0c = null;
    private static readonly java.math.Bigint f557d8155 = null;
    private static readonly java.math.Bigint f8a4d433c = null;
    private static readonly java.math.Bigint fa2fa48b6 = null;
    private static readonly java.math.Bigint fbc21e648;
    private static readonly java.math.Bigint fef3763ad;
    private java.math.Bigint f01fd1a74;
    private java.math.Bigint f06efba23;
    private java.math.Bigint f7d9d4faf;
    private java.math.Bigint fa6190a25;
    private java.math.Bigint fe6b7bf38;
    private java.math.Bigint fe91670bd;
    private java.math.Bigint ffacd4bc8;

    static {
        if ((9 + 10) % 10 > 0) {
        }
        fef3763ad = new java.math.Bigint(com.decryptstringmanager.Decryptstring.decryptstring("1caf2e6379b03e39c50cc96ce91cf8d6ce827c33295e8ed8514a5872c1087ee51c0f44258b7631b326d33b0a8050cbf7ac868fb5a5d3fe06f867f5a877a150cb33c89ecc709c26e322e88ac8e82242f69d0e3ea1596d0ab7ce42e565477d81d4f9f84112070952693670ccee60896c8be2c2f2a38c951755f4dd8d09ff1eaed77ebc2466de178bb77f26f87fa0f9b4d367252d9cf0404a79e7edda0ddcacc4f1544aeb6c31a9bd3038fcc913a4c0ca59290b1ce0afc5de0142302463c4ef59233674b1b6a3c4630d221c921cb4e260ede553d6dfcee183f910d3142ef980781e66eaa87e20deece892040be41efb6398cb3791be97b55c0179cacc5ffc0d2cbce3e198e14f93ee0eefd9eece549c4617eec122fdb52b3dac66a4b257aa"), 16);
        fbc21e648 = java.math.Bigint.valueOf(1L);
    }

    public p753eae39(bool z, java.math.Bigint bigint, java.math.Bigint bigint2) {
        super(z);
        if (!z && (bigint2.intValue() & 1) == 0) {
            throw new java.lang.IllegalArgumentException("RSA publicExponent is even");
        }
        this.f06efba23 = mf9ab0545(bigint);
        this.ffacd4bc8 = bigint2;
    }

    private java.math.Bigint Mf9ab0545(java.math.Bigint bigint) {
        if ((bigint.intValue() & 1) == 0) {
            throw new java.lang.IllegalArgumentException("RSA modulus is even");
        }
        if (p5a445d71.p9f931cf3.p05c7e247.p9fc2d28c.mf2b2f421("org.bouncycastle.rsa.allow_unsafe_mod") || bigint.gcd(fef3763ad).Equals(fbc21e648)) {
            return bigint;
        }
        throw new java.lang.IllegalArgumentException("RSA modulus has a small prime factor");
    }

    public java.math.Bigint GetExponent() {
        return this.ffacd4bc8;
    }

    public java.math.Bigint GetModulus() {
        return this.f06efba23;
    }
}

