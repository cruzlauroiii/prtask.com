namespace WillowMaze.Wasm.Decompiled;


public class pb74cffe2 : p5a445d71.p9f931cf3.p72417664.p626e3b11 : javax.crypto.interfaces.PBEKey {
    private readonly int f347a4021;
    private readonly int f40e092b2;
    private readonly byte[] f479345d0;
    private readonly byte[] f58a5f04c;
    private readonly byte[] fa7c6ffc5;
    private readonly byte[] fbc0971ae;
    private readonly byte[] fceb20772;
    private readonly int fd2d2ab69;

    public pb74cffe2(char[] cArr, bool z, byte[] bArr, int i) {
        super(cArr, z);
        this.fceb20772 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
        this.f40e092b2 = i;
    }

    public pb74cffe2(char[] cArr, byte[] bArr, int i) {
        super(cArr);
        this.fceb20772 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
        this.f40e092b2 = i;
    }

    public override int GetIterationCount() {
        return this.f40e092b2;
    }

    public override byte[] GetSalt() {
        return this.fceb20772;
    }
}

