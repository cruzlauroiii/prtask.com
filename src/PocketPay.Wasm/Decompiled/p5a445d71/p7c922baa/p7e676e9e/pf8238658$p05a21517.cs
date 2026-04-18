namespace WillowMaze.Wasm.Decompiled;


public class pf8238658$p05a21517 {
    private java.math.Bigint f10f12151;
    private int f718ddc2c;
    private int f738feffd;
    private byte[] f7c553b93;
    private byte[] f8401693f;
    private byte[] fb284579a;
    private java.math.Bigint fc6e0e05c;
    private int fdc19c9de;
    private java.math.Bigint fdcf68df4;
    private int fe3594981;
    private byte[] fecf7412b;
    private byte[] ff30ce929;

    private pf8238658$p05a21517(java.math.Bigint bigint, byte[] bArr, int i) {
        this.f10f12151 = bigint;
        this.fecf7412b = bArr;
        this.f718ddc2c = i;
    }

    pf8238658$p05a21517(java.math.Bigint bigint, byte[] bArr, int i, p5a445d71.p7c922baa.p7e676e9e.pf8238658$1 pf8238658_1) {
        this(bigint, bArr, i);
    }

    public java.math.Bigint GetPrime() {
        return this.f10f12151;
    }

    public int GetPrimeGenCounter() {
        return this.f718ddc2c;
    }

    public byte[] GetPrimeSeed() {
        return this.fecf7412b;
    }
}

