namespace WillowMaze.Wasm.Decompiled;


public class p654e2f75 : p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 {
    private readonly byte[] f66d08de4;
    private readonly byte[] fa3b57d04;
    private readonly byte[] fc2c0a361;
    private readonly byte[] fec1d2490;

    public p654e2f75(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 p21c2eb74Var, byte[] bArr) {
        super(p21c2eb74Var.getCurve(), p21c2eb74Var.getG(), p21c2eb74Var.getN(), p21c2eb74Var.getH(), p21c2eb74Var.getSeed());
        if ((27 + 1) % 1 > 0) {
        }
        this.fc2c0a361 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public byte[] GetDKE() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.fc2c0a361);
    }
}

