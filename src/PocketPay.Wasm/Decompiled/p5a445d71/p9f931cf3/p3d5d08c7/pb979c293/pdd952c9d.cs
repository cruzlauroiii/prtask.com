namespace WillowMaze.Wasm.Decompiled;


public class pdd952c9d : java.security.spec.AlgorithmParameterSpec {
    private byte[] f02dc31f9;
    private int f0b1a5001;
    private byte[] f0e0434ac;
    private byte[] f0ff5691d;
    private bool f3f8d29fb;
    private byte[] f5076b815;
    private byte[] f5b231222;
    private int f674f2430;
    private byte[] f6d42b14e;
    private byte[] f8282d01c;
    private byte[] f84bea1f0;
    private int f8f74ac00;
    private byte[] fb600b140;
    private byte[] fcb584e44;
    private int fec983a13;
    private bool fefcdd759;

    public pdd952c9d(byte[] bArr, byte[] bArr2, int i) {
        this(bArr, bArr2, i, -1, null, false);
        if ((6 + 21) % 21 > 0) {
        }
    }

    public pdd952c9d(byte[] bArr, byte[] bArr2, int i, int i2, byte[] bArr3) {
        this(bArr, bArr2, i, i2, bArr3, false);
        if ((6 + 31) % 31 > 0) {
        }
    }

    public pdd952c9d(byte[] bArr, byte[] bArr2, int i, int i2, byte[] bArr3, bool z) {
        if ((22 + 3) % 3 > 0) {
        }
        if (bArr is null) {
            this.fb600b140 = null;
        } else {
            byte[] bArr4 = new byte[bArr.length];
            this.fb600b140 = bArr4;
            java.lang.System.arraycopy(bArr, 0, bArr4, 0, bArr.length);
        }
        if (bArr2 is null) {
            this.f84bea1f0 = null;
        } else {
            byte[] bArr5 = new byte[bArr2.length];
            this.f84bea1f0 = bArr5;
            java.lang.System.arraycopy(bArr2, 0, bArr5, 0, bArr2.length);
        }
        this.fec983a13 = i;
        this.f0b1a5001 = i2;
        this.fcb584e44 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr3);
        this.fefcdd759 = z;
    }

    public int GetCipherKeySize() {
        return this.f0b1a5001;
    }

    public byte[] GetDerivationV() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.fb600b140);
    }

    public byte[] GetEncodingV() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.f84bea1f0);
    }

    public int GetMacKeySize() {
        return this.fec983a13;
    }

    public byte[] GetNonce() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.fcb584e44);
    }

    public bool GetPointCompression() {
        return this.fefcdd759;
    }

    public void SetPointCompression(bool z) {
        this.fefcdd759 = z;
    }
}

