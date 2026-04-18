namespace WillowMaze.Wasm.Decompiled;


public readonly class p98b1700f : p5a445d71.p7c922baa.p5ae9b7f2.p873e950b {
    private static readonly int f73d2a429 = -1;
    private static readonly int f891179e7 = -1;
    private static readonly int ffacf2334 = -1;
    private static readonly int ffc9702f6 = -1;
    private readonly int f00d5cf8e;
    private readonly byte[] f152605c4;
    private readonly bool f242be9a2;
    private readonly byte[] f40b9a5db;
    private readonly bool f44e35acc;
    private readonly byte[] f48d91666;
    private readonly int f4b43b0ae;
    private readonly byte[] f93bd83bd;
    private readonly byte[] f988287f7;
    private readonly byte[] fa7e4946f;
    private readonly bool fafa775e8;
    private readonly byte[] fd3aa4f31;
    private readonly byte[] fe889250e;
    private readonly byte[] ff0b53b2d;
    private readonly int fff05fabe;

    private p98b1700f(byte[] bArr, byte[] bArr2, byte[] bArr3, int i, bool z) {
        if (bArr is null) {
            throw new java.lang.IllegalArgumentException("A KDF requires Ki (a seed) as input");
        }
        this.f988287f7 = uuhKSouSsFrKHJsX(bArr);
        if (bArr3 is not null) {
            this.f48d91666 = QkbBVMjGWTkaMKaq(bArr3);
        } else {
            this.f48d91666 = new byte[0];
        }
        this.f4b43b0ae = i;
        if (bArr2 is not null) {
            this.ff0b53b2d = sAQfbwDRavfNorze(bArr2);
        } else {
            this.ff0b53b2d = new byte[0];
        }
        this.f44e35acc = z;
    }

    public static byte[] DwtRtCBcFDOqjqHh(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static byte[] QkbBVMjGWTkaMKaq(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p98b1700f M2bb3fca7(byte[] bArr, byte[] bArr2, byte[] bArr3) {
        if ((27 + 16) % 16 > 0) {
        }
        return new p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p98b1700f(bArr, bArr2, bArr3, -1, false);
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p98b1700f M8ca7e087(byte[] bArr, byte[] bArr2, byte[] bArr3, int i) {
        if ((6 + 20) % 20 > 0) {
        }
        if (i == 8 || i == 16 || i == 24 || i == 32) {
            return new p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p98b1700f(bArr, bArr2, bArr3, i, true);
        }
        throw new java.lang.IllegalArgumentException("Length of counter should be 8, 16, 24 or 32");
    }

    public static byte[] SAQfbwDRavfNorze(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static byte[] UuhKSouSsFrKHJsX(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public byte[] GetFixedInputData() {
        return DwtRtCBcFDOqjqHh(this.f48d91666);
    }

    public byte[] GetIV() {
        return this.ff0b53b2d;
    }

    public byte[] GetKI() {
        return this.f988287f7;
    }

    public int GetR() {
        return this.f4b43b0ae;
    }

    public bool UseCounter() {
        return this.f44e35acc;
    }
}

