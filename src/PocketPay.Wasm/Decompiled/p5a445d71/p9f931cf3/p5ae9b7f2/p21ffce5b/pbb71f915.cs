namespace WillowMaze.Wasm.Decompiled;


public readonly class pbb71f915 : p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 {
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6 f3c6e0b8a;
    private readonly byte[] f6c322698;
    private readonly int f6d0905d6;
    private readonly int f76cc78c5;
    private readonly byte[] f9049b069;
    private readonly bool f919a688a;
    private readonly int f96521541;
    private readonly bool fac64a08f;
    private readonly byte[] fbd8cbd61;
    private readonly int fbe4ecdb8;
    private readonly byte[] fcdc1103d;
    private readonly int fec4b4d4d;
    private readonly byte[] ff6be324c;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6 ffa2c30ad;

    public pbb71f915(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6 p94919be6Var, int i, byte[] bArr) {
        this(p94919be6Var, i, bArr, false);
    }

    public pbb71f915(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6 p94919be6Var, int i, byte[] bArr, bool z) {
        this.f3c6e0b8a = p94919be6Var;
        this.fbe4ecdb8 = i;
        this.f6c322698 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
        this.fac64a08f = z;
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6 GetKey() {
        return this.f3c6e0b8a;
    }

    public int GetRadix() {
        return this.fbe4ecdb8;
    }

    public byte[] GetTweak() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.f6c322698);
    }

    public bool IsUsingInverseFunction() {
        return this.fac64a08f;
    }
}

