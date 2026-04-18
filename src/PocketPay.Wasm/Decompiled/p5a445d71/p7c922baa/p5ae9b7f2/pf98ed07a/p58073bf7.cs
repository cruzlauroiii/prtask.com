namespace WillowMaze.Wasm.Decompiled;


public class p58073bf7 : java.io.Stream {
    protected p5a445d71.p7c922baa.p5ae9b7f2.pd1977c1b fdb56a74d;
    protected p5a445d71.p7c922baa.p5ae9b7f2.pd1977c1b fefdf7c01;

    public p58073bf7(p5a445d71.p7c922baa.p5ae9b7f2.pd1977c1b pd1977c1bVar) {
        this.fdb56a74d = pd1977c1bVar;
    }

    public static void RBCajFGLdztFYsZi(p5a445d71.p7c922baa.p5ae9b7f2.pd1977c1b pd1977c1bVar, byte[] bArr, int i, int i2) {
        pd1977c1bVar.update(bArr, i, i2);
    }

    public static void ZWzUYfyDCFxJjYbf(p5a445d71.p7c922baa.p5ae9b7f2.pd1977c1b pd1977c1bVar, byte b) {
        pd1977c1bVar.update(b);
    }

    public p5a445d71.p7c922baa.p5ae9b7f2.pd1977c1b GetSigner() {
        return this.fdb56a74d;
    }

    public override void Write(int i) throws java.io.IOException {
        zWzUYfyDCFxJjYbf(this.fdb56a74d, (byte) i);
    }

    public override void Write(byte[] bArr, int i, int i2) throws java.io.IOException {
        RBCajFGLdztFYsZi(this.fdb56a74d, bArr, i, i2);
    }
}

