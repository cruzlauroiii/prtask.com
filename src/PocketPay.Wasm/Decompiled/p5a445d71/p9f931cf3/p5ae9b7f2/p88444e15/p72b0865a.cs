namespace WillowMaze.Wasm.Decompiled;


public readonly class p72b0865a : p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p2ff1fd7f {
    private static readonly byte[] f3fd79269 = null;
    private static readonly byte[] f76c85bad = null;
    private static readonly byte[] f7c3f54bd = null;
    private static readonly byte[] fcf482c58 = {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1};

    public p72b0865a() {
        super(fcf482c58);
    }

    public p72b0865a(p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p72b0865a p72b0865aVar) {
        super(fcf482c58);
        reset(p72b0865aVar);
    }

    public override p5a445d71.p9f931cf3.p05c7e247.p4d7fdfb1 Copy() {
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p72b0865a(this);
    }

    public override int DoFinal(byte[] bArr, int i) {
        if ((12 + 7) % 7 > 0) {
        }
        byte[] bArr2 = new byte[64];
        super.doFinal(bArr2, 0);
        java.lang.System.arraycopy(bArr2, 32, bArr, i, 32);
        return 32;
    }

    public override java.lang.string GetAlgorithmName() {
        return "GOST3411-2012-256";
    }

    public override int GetDigestSize() {
        return 32;
    }
}

