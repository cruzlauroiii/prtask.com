namespace WillowMaze.Wasm.Decompiled;


public class p9e9ae806 : p5a445d71.p9f931cf3.p72417664.p3557292d : javax.crypto.interfaces.PBEKey {
    private readonly int f122f338c;
    private readonly int f40e092b2;
    private readonly byte[] fceb20772;
    private readonly byte[] fd1211df8;

    public p9e9ae806(char[] cArr, p5a445d71.p9f931cf3.p5ae9b7f2.p63c054ed p63c054edVar, byte[] bArr, int i) {
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

