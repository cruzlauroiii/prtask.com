namespace WillowMaze.Wasm.Decompiled;


public class p3669dfbe : p5a445d71.p9f931cf3.p72417664.paae5f464 : javax.crypto.interfaces.PBEKey {
    private readonly byte[] f2d104344;
    private readonly int f40e092b2;
    private readonly int f4f62df5f;
    private readonly byte[] f64a0b10e;
    private readonly int f83d68c4e;
    private readonly byte[] fa3158c66;
    private readonly byte[] fceb20772;

    public p3669dfbe(char[] cArr, p5a445d71.p9f931cf3.p5ae9b7f2.p63c054ed p63c054edVar, byte[] bArr, int i) {
        super(cArr, p63c054edVar);
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

