namespace WillowMaze.Wasm.Decompiled;


public class p7b2e7111 : p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 {
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6 f12ff3536;
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6 f3c6e0b8a;
    private readonly byte[] f5ac63815;
    private readonly byte[] f6c322698;
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6 f8701ab3f;
    private readonly byte[] fb5ce0955;
    private readonly byte[] ff155961b;

    public p7b2e7111(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6 p94919be6Var, byte[] bArr) {
        this.f3c6e0b8a = p94919be6Var;
        this.f6c322698 = XhkMUcfPqvAGLVPE(bArr);
    }

    public static byte[] XhkMUcfPqvAGLVPE(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6 GetKey() {
        return this.f3c6e0b8a;
    }

    public byte[] GetTweak() {
        return this.f6c322698;
    }
}

