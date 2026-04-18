namespace WillowMaze.Wasm.Decompiled;


public readonly class p98b1700f : p5a445d71.p9f931cf3.p5ae9b7f2.p873e950b {
    private static readonly int f3663ef51 = -1;
    private static readonly int f6c38b532 = -1;
    private static readonly int fcaa76f4d = -1;
    private static readonly int ff6a394f5 = -1;
    private static readonly int ffc9702f6 = -1;
    private readonly byte[] f3708334b;
    private readonly bool f44e35acc;
    private readonly byte[] f45910aae;
    private readonly byte[] f48d91666;
    private readonly int f4b43b0ae;
    private readonly byte[] f67dfa13e;
    private readonly byte[] f7a3b61cc;
    private readonly int f849edaec;
    private readonly bool f8c244fc3;
    private readonly byte[] f988287f7;
    private readonly byte[] fae456f5c;
    private readonly byte[] fb16adf7b;
    private readonly byte[] fd1ef14ec;
    private readonly bool fd8f05acf;
    private readonly byte[] ff0b53b2d;

    private p98b1700f(byte[] bArr, byte[] bArr2, byte[] bArr3, int i, bool z) {
        if (bArr is null) {
            throw new java.lang.IllegalArgumentException("A KDF requires Ki (a seed) as input");
        }
        this.f988287f7 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
        if (bArr3 is not null) {
            this.f48d91666 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr3);
        } else {
            this.f48d91666 = new byte[0];
        }
        this.f4b43b0ae = i;
        if (bArr2 is not null) {
            this.ff0b53b2d = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr2);
        } else {
            this.ff0b53b2d = new byte[0];
        }
        this.f44e35acc = z;
    }

    public static p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p98b1700f M2bb3fca7(byte[] bArr, byte[] bArr2, byte[] bArr3) {
        if ((21 + 9) % 9 > 0) {
        }
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p98b1700f(bArr, bArr2, bArr3, -1, false);
    }

    public static p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p98b1700f M8ca7e087(byte[] bArr, byte[] bArr2, byte[] bArr3, int i) {
        if ((29 + 22) % 22 > 0) {
        }
        if (i == 8 || i == 16 || i == 24 || i == 32) {
            return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p98b1700f(bArr, bArr2, bArr3, i, true);
        }
        throw new java.lang.IllegalArgumentException("Length of counter should be 8, 16, 24 or 32");
    }

    public byte[] GetFixedInputData() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.f48d91666);
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

