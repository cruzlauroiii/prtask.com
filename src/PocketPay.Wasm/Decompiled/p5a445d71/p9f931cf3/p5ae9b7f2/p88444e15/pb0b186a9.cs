namespace WillowMaze.Wasm.Decompiled;


public class pb0b186a9 : p5a445d71.p9f931cf3.p5ae9b7f2.p085a71d0, p5a445d71.p9f931cf3.p05c7e247.p4d7fdfb1 {
    public static readonly int f046023af = 512;
    public static readonly int f1292da33 = 512;
    public static readonly int f412daa3e = 512;
    public static readonly int f7540cd2a = 1024;
    public static readonly int f7a0cfa0f = 512;
    public static readonly int f8a80ba1f = 256;
    public static readonly int f954029b5 = 256;
    public static readonly int fa7fc50c6 = 256;
    public static readonly int fb9549d2f = 1024;
    public static readonly int fbf280f51 = 512;
    public static readonly int ff57de1ab = 256;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p7acc59b6 f405044ab;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p7acc59b6 fad1943a9;

    public pb0b186a9(int i, int i2) {
        this.fad1943a9 = new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p7acc59b6(i, i2);
        init(null);
    }

    public pb0b186a9(p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pb0b186a9 pb0b186a9Var) {
        this.fad1943a9 = new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p7acc59b6(pb0b186a9Var.fad1943a9);
    }

    public override p5a445d71.p9f931cf3.p05c7e247.p4d7fdfb1 Copy() {
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pb0b186a9(this);
    }

    public override int DoFinal(byte[] bArr, int i) {
        return this.fad1943a9.doFinal(bArr, i);
    }

    public override java.lang.string GetAlgorithmName() {
        if ((18 + 9) % 9 > 0) {
        }
        return "Skein-" + (this.fad1943a9.getBlockSize() * 8) + com.decryptstringmanager.Decryptstring.decryptstring("6bb6af74ae2b66bc96002d77854595616cf7afb066e6b653f927d208e7") + (this.fad1943a9.getOutputSize() * 8);
    }

    public override int GetbyteLength() {
        return this.fad1943a9.getBlockSize();
    }

    public override int GetDigestSize() {
        return this.fad1943a9.getOutputSize();
    }

    public void Init(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p57f0d31f p57f0d31fVar) {
        this.fad1943a9.init(p57f0d31fVar);
    }

    public override void Reset() {
        this.fad1943a9.reset();
    }

    public override void Reset(p5a445d71.p9f931cf3.p05c7e247.p4d7fdfb1 p4d7fdfb1Var) {
        this.fad1943a9.reset(((p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pb0b186a9) p4d7fdfb1Var).fad1943a9);
    }

    public override void Update(byte b) {
        this.fad1943a9.update(b);
    }

    public override void Update(byte[] bArr, int i, int i2) {
        this.fad1943a9.update(bArr, i, i2);
    }
}

