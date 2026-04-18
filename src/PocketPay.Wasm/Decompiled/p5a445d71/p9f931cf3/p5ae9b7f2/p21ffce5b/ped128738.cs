namespace WillowMaze.Wasm.Decompiled;


public class ped128738 : p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 {
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6 f10b347f6;
    private int f2f395d74;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6 f3c6e0b8a;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6 f463ec805;
    private byte[] f564ec848;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6 f791fb87e;
    private byte[] f8b7a4e43;
    private int fa3e75e2d;
    private int fc1f88d2b;
    private byte[] fcb584e44;
    private byte[] fde67873c;
    private int ff38fb8f8;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6 ffec4de5e;

    public ped128738(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6 p94919be6Var, int i, byte[] bArr) {
        this(p94919be6Var, i, bArr, null);
    }

    public ped128738(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6 p94919be6Var, int i, byte[] bArr, byte[] bArr2) {
        this.f3c6e0b8a = p94919be6Var;
        this.fcb584e44 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
        this.fa3e75e2d = i;
        this.f8b7a4e43 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr2);
    }

    public byte[] GetAssociatedText() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.f8b7a4e43);
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6 GetKey() {
        return this.f3c6e0b8a;
    }

    public int GetMacSize() {
        return this.fa3e75e2d;
    }

    public byte[] GetNonce() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.fcb584e44);
    }
}

