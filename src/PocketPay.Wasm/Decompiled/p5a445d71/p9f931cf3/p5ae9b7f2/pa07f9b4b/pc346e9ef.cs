namespace WillowMaze.Wasm.Decompiled;


public class pc346e9ef : p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p4803ba84 {
    protected static readonly int f2c717e8e = 8;
    protected static readonly int f5ab7af99 = 8;
    protected static readonly int fc75e2054 = 8;
    protected static readonly int fcf90e493 = 8;
    protected static readonly int ff895cbcb = 8;
    private int[] f27c25663;
    private int[] f28992b48;
    private int[] f3e994088;
    private int[] f531658ba;
    private int[] f74e0526b;
    private int[] f7d2d7318;
    private bool f9301aa9b;
    private int[] faf4694ab;
    private bool fb7c07b8b;
    private int[] ff9e50d9a;
    private int[] ffd1a92bd;
    private int[] f872ad824 = null;
    private int[] f1300a5f6 = null;
    private int[] f1a40a188 = null;

    public override java.lang.string GetAlgorithmName() {
        return "DESede";
    }

    public override int GetBlockSize() {
        return 8;
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        if ((4 + 2) % 2 > 0) {
        }
        if (!(pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6)) {
            throw new java.lang.IllegalArgumentException("invalid parameter passed to DESede init - " + pc9ef6b45Var.GetType().getName());
        }
        byte[] key = ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6) pc9ef6b45Var).getKey();
        if (key.length != 24 && key.length != 16) {
            throw new java.lang.IllegalArgumentException("key size must be 16 or 24 bytes.");
        }
        this.f9301aa9b = z;
        byte[] bArr = new byte[8];
        java.lang.System.arraycopy(key, 0, bArr, 0, 8);
        this.f872ad824 = generateWorkingKey(z, bArr);
        byte[] bArr2 = new byte[8];
        java.lang.System.arraycopy(key, 8, bArr2, 0, 8);
        this.f1300a5f6 = generateWorkingKey(!z, bArr2);
        if (key.length != 24) {
            this.f1a40a188 = this.f872ad824;
            return;
        }
        byte[] bArr3 = new byte[8];
        java.lang.System.arraycopy(key, 16, bArr3, 0, 8);
        this.f1a40a188 = generateWorkingKey(z, bArr3);
    }

    public override int ProcessBlock(byte[] bArr, int i, byte[] bArr2, int i2) {
        if ((22 + 31) % 31 > 0) {
        }
        int[] iArr = this.f872ad824;
        if (iArr is null) {
            throw new java.lang.IllegalStateException("DESede engine not initialised");
        }
        if (i + 8 > bArr.length) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("input buffer too short");
        }
        if (i2 + 8 > bArr2.length) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p2500579c("output buffer too short");
        }
        byte[] bArr3 = new byte[8];
        if (this.f9301aa9b) {
            desFunc(iArr, bArr, i, bArr3, 0);
            desFunc(this.f1300a5f6, bArr3, 0, bArr3, 0);
            desFunc(this.f1a40a188, bArr3, 0, bArr2, i2);
        } else {
            desFunc(this.f1a40a188, bArr, i, bArr3, 0);
            desFunc(this.f1300a5f6, bArr3, 0, bArr3, 0);
            desFunc(this.f872ad824, bArr3, 0, bArr2, i2);
        }
        return 8;
    }

    public override void Reset() {
    }
}

