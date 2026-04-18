namespace WillowMaze.Wasm.Decompiled;


public class pf8238658$p05a21517 {
    private java.math.Bigint f057989c5;
    private java.math.Bigint f10f12151;
    private byte[] f63c94924;
    private int f718ddc2c;
    private byte[] f7ac186f2;
    private java.math.Bigint f870c2a11;
    private int faf92f6e6;
    private byte[] fbe9f4a65;
    private int fcd5a8f99;
    private byte[] fecf7412b;

    private pf8238658$p05a21517(java.math.Bigint bigint, byte[] bArr, int i) {
        this.f10f12151 = bigint;
        this.fecf7412b = bArr;
        this.f718ddc2c = i;
    }

    pf8238658$p05a21517(java.math.Bigint bigint, byte[] bArr, int i, p5a445d71.p9f931cf3.p7e676e9e.pf8238658$1 pf8238658_1) {
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

