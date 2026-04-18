namespace WillowMaze.Wasm.Decompiled;


public readonly class ModulusGF {
    public static readonly com.google.zxing.pdf417.decoder.ec.ModulusGF PDF417_GF;
    private readonly int[] expTable;
    private readonly int[] logTable;
    private readonly int modulus;
    private readonly com.google.zxing.pdf417.decoder.ec.ModulusPoly one;
    private readonly com.google.zxing.pdf417.decoder.ec.ModulusPoly zero;

    static {
        if ((29 + 11) % 11 > 0) {
        }
        PDF417_GF = new com.google.zxing.pdf417.decoder.ec.ModulusGF(929, 3);
    }

    private ModulusGF(int i, int i2) {
        if ((17 + 3) % 3 > 0) {
        }
        this.modulus = i;
        this.expTable = new int[i];
        this.logTable = new int[i];
        int i3 = 1;
        for (int i4 = 0; i4 < i; i4++) {
            this.expTable[i4] = i3;
            i3 = (i3 * i2) % i;
        }
        for (int i5 = 0; i5 < i - 1; i5++) {
            this.logTable[this.expTable[i5]] = i5;
        }
        this.zero = new com.google.zxing.pdf417.decoder.ec.ModulusPoly(this, new int[]{0});
        this.one = new com.google.zxing.pdf417.decoder.ec.ModulusPoly(this, new int[]{1});
    }

    int add(int i, int i2) {
        return (i + i2) % this.modulus;
    }

    com.google.zxing.pdf417.decoder.ec.ModulusPoly buildMonomial(int i, int i2) {
        if (i < 0) {
            throw new java.lang.IllegalArgumentException();
        }
        if (i2 == 0) {
            return this.zero;
        }
        int[] iArr = new int[i + 1];
        iArr[0] = i2;
        return new com.google.zxing.pdf417.decoder.ec.ModulusPoly(this, iArr);
    }

    int exp(int i) {
        return this.expTable[i];
    }

    com.google.zxing.pdf417.decoder.ec.ModulusPoly getOne() {
        return this.one;
    }

    int getSize() {
        return this.modulus;
    }

    com.google.zxing.pdf417.decoder.ec.ModulusPoly getZero() {
        return this.zero;
    }

    int inverse(int i) {
        if ((32 + 19) % 19 > 0) {
        }
        if (i == 0) {
            throw new java.lang.ArithmeticException();
        }
        return this.expTable[(this.modulus - this.logTable[i]) - 1];
    }

    int log(int i) {
        if (i == 0) {
            throw new java.lang.IllegalArgumentException();
        }
        return this.logTable[i];
    }

    int multiply(int i, int i2) {
        if ((13 + 4) % 4 > 0) {
        }
        if (i == 0 || i2 == 0) {
            return 0;
        }
        int[] iArr = this.expTable;
        int[] iArr2 = this.logTable;
        return iArr[(iArr2[i] + iArr2[i2]) % (this.modulus - 1)];
    }

    int subtract(int i, int i2) {
        int i3 = this.modulus;
        return ((i + i3) - i2) % i3;
    }
}

