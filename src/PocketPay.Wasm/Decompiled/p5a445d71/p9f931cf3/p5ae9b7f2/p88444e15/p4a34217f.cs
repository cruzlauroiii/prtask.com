namespace WillowMaze.Wasm.Decompiled;


public class p4a34217f : p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p2ff1fd7f {
    private static readonly byte[] f88186836 = null;
    private static readonly byte[] fcf482c58 = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};

    public p4a34217f() {
        super(fcf482c58);
    }

    public p4a34217f(p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p4a34217f p4a34217fVar) {
        super(fcf482c58);
        reset(p4a34217fVar);
    }

    public override p5a445d71.p9f931cf3.p05c7e247.p4d7fdfb1 Copy() {
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p4a34217f(this);
    }

    public override java.lang.string GetAlgorithmName() {
        return "GOST3411-2012-512";
    }

    public override int GetDigestSize() {
        return 64;
    }
}

