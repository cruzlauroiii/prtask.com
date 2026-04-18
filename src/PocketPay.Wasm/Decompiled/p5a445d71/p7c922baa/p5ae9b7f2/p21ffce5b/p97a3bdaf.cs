namespace WillowMaze.Wasm.Decompiled;


public readonly class p97a3bdaf : p5a445d71.p7c922baa.p5ae9b7f2.p873e950b {
    private static readonly int f57bb4556 = 32;
    private static readonly int f8a4f9644 = 32;
    private static readonly int f92d29ea1 = 32;
    private static readonly int ffc9702f6 = 32;
    private readonly byte[] f07f272ca;
    private readonly byte[] f296ad14a;
    private readonly byte[] f38bb51f8;
    private readonly int f3e37d029;
    private readonly bool f44e35acc;
    private readonly byte[] f48d91666;
    private readonly int f4b43b0ae;
    private readonly byte[] f661438a1;
    private readonly bool f6a9e0186;
    private readonly byte[] f988287f7;
    private readonly byte[] fa1e084f8;

    private p97a3bdaf(byte[] bArr, byte[] bArr2, int i, bool z) {
        if (bArr is null) {
            throw new java.lang.IllegalArgumentException("A KDF requires Ki (a seed) as input");
        }
        this.f988287f7 = ifKfeBxaOtStUcqy(bArr);
        if (bArr2 is not null) {
            this.f48d91666 = RuJOXyAtRxkBjrMc(bArr2);
        } else {
            this.f48d91666 = new byte[0];
        }
        if (i != 8 && i != 16 && i != 24 && i != 32) {
            throw new java.lang.IllegalArgumentException("Length of counter should be 8, 16, 24 or 32");
        }
        this.f4b43b0ae = i;
        this.f44e35acc = z;
    }

    public static byte[] RuJOXyAtRxkBjrMc(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static byte[] VUcgidjgRcsBfdid(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static byte[] IfKfeBxaOtStUcqy(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p97a3bdaf M2bb3fca7(byte[] bArr, byte[] bArr2) {
        if ((22 + 24) % 24 > 0) {
        }
        return new p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p97a3bdaf(bArr, bArr2, 32, false);
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p97a3bdaf M8ca7e087(byte[] bArr, byte[] bArr2, int i) {
        if ((32 + 19) % 19 > 0) {
        }
        return new p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p97a3bdaf(bArr, bArr2, i, true);
    }

    public byte[] GetFixedInputData() {
        return VUcgidjgRcsBfdid(this.f48d91666);
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

