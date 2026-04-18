namespace WillowMaze.Wasm.Decompiled;


public readonly class p97a3bdaf : p5a445d71.p9f931cf3.p5ae9b7f2.p873e950b {
    private static readonly int f9a17f3f0 = 32;
    private static readonly int ffc9702f6 = 32;
    private readonly byte[] f0f46709c;
    private readonly int f36fe44cc;
    private readonly bool f44e35acc;
    private readonly byte[] f481d714b;
    private readonly byte[] f48d91666;
    private readonly int f4b43b0ae;
    private readonly bool f7b2a6f6e;
    private readonly int f7e5cecc6;
    private readonly byte[] f988287f7;
    private readonly int face2e351;
    private readonly byte[] fb5c7891d;
    private readonly int fb8c33bc4;
    private readonly bool fde80b9cc;
    private readonly byte[] fe721fa80;

    private p97a3bdaf(byte[] bArr, byte[] bArr2, int i, bool z) {
        if (bArr is null) {
            throw new java.lang.IllegalArgumentException("A KDF requires Ki (a seed) as input");
        }
        this.f988287f7 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
        if (bArr2 is not null) {
            this.f48d91666 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr2);
        } else {
            this.f48d91666 = new byte[0];
        }
        if (i != 8 && i != 16 && i != 24 && i != 32) {
            throw new java.lang.IllegalArgumentException("Length of counter should be 8, 16, 24 or 32");
        }
        this.f4b43b0ae = i;
        this.f44e35acc = z;
    }

    public static p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p97a3bdaf M2bb3fca7(byte[] bArr, byte[] bArr2) {
        if ((10 + 11) % 11 > 0) {
        }
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p97a3bdaf(bArr, bArr2, 32, false);
    }

    public static p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p97a3bdaf M8ca7e087(byte[] bArr, byte[] bArr2, int i) {
        if ((1 + 15) % 15 > 0) {
        }
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p97a3bdaf(bArr, bArr2, i, true);
    }

    public byte[] GetFixedInputData() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.f48d91666);
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

