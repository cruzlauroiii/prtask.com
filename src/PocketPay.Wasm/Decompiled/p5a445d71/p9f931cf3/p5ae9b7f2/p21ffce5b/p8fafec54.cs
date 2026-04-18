namespace WillowMaze.Wasm.Decompiled;


public readonly class p8fafec54 : p5a445d71.p9f931cf3.p5ae9b7f2.p873e950b {
    private byte[] f052d6dca;
    private byte[] f165f9926;
    private int f4b38d79c;
    private int f4b43b0ae;
    private byte[] f5319a6e8;
    private byte[] f7eea07ea;
    private byte[] f83e33f64;
    private byte[] f988287f7;
    private byte[] fb4524c93;
    private int fc6e6faab;
    private int fc8a04b44;
    private int fce587703;
    private byte[] fe52bd849;
    private byte[] ff06f5bff;

    public p8fafec54(byte[] bArr, byte[] bArr2, int i) {
        this(bArr, null, bArr2, i);
    }

    public p8fafec54(byte[] bArr, byte[] bArr2, byte[] bArr3, int i) {
        if (bArr is null) {
            throw new java.lang.IllegalArgumentException("A KDF requires Ki (a seed) as input");
        }
        this.f988287f7 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
        if (bArr2 is not null) {
            this.fb4524c93 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr2);
        } else {
            this.fb4524c93 = new byte[0];
        }
        if (bArr3 is not null) {
            this.f165f9926 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr3);
        } else {
            this.f165f9926 = new byte[0];
        }
        if (i != 8 && i != 16 && i != 24 && i != 32) {
            throw new java.lang.IllegalArgumentException("Length of counter should be 8, 16, 24 or 32");
        }
        this.f4b43b0ae = i;
    }

    public byte[] GetFixedInputData() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.f165f9926);
    }

    public byte[] GetFixedInputDataCounterPrefix() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.fb4524c93);
    }

    public byte[] GetFixedInputDataCounterSuffix() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.f165f9926);
    }

    public byte[] GetKI() {
        return this.f988287f7;
    }

    public int GetR() {
        return this.f4b43b0ae;
    }
}

