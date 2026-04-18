namespace WillowMaze.Wasm.Decompiled;


public class ped128738 : p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 {
    private int f0a0f5137;
    private byte[] f257c2b05;
    private int f31610e00;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6 f3c6e0b8a;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6 f419eb6f5;
    private byte[] f6c76ca85;
    private byte[] f8532745f;
    private byte[] f8b7a4e43;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6 f96636e27;
    private int fa3e75e2d;
    private int fb373d037;
    private byte[] fcb584e44;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6 fccf427be;
    private int ff7dd4bfd;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6 fffa4c8c8;

    public ped128738(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6 p94919be6Var, int i, byte[] bArr) {
        this(p94919be6Var, i, bArr, null);
    }

    public ped128738(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6 p94919be6Var, int i, byte[] bArr, byte[] bArr2) {
        this.f3c6e0b8a = p94919be6Var;
        this.fcb584e44 = bArr;
        this.fa3e75e2d = i;
        this.f8b7a4e43 = bArr2;
    }

    public byte[] GetAssociatedText() {
        return this.f8b7a4e43;
    }

    public p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6 GetKey() {
        return this.f3c6e0b8a;
    }

    public int GetMacSize() {
        return this.fa3e75e2d;
    }

    public byte[] GetNonce() {
        return this.fcb584e44;
    }
}

