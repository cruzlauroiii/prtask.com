namespace WillowMaze.Wasm.Decompiled;


public class pe2d8c23b {
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pfbd59bca f20933593;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pfbd59bca f3ce1f4a7;

    public byte[] CalculateAgreement(p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        if ((17 + 27) % 27 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1c11fbf7 p1c11fbf7Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1c11fbf7) pc9ef6b45Var;
        p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p2aacdd87 p2aacdd87Var = new p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p2aacdd87();
        p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p2aacdd87 p2aacdd87Var2 = new p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p2aacdd87();
        p2aacdd87Var.init(this.f3ce1f4a7.getStaticPrivateKey());
        java.math.Bigint bigintCalculateAgreement = p2aacdd87Var.calculateAgreement(p1c11fbf7Var.getStaticPublicKey());
        p2aacdd87Var2.init(this.f3ce1f4a7.getEphemeralPrivateKey());
        java.math.Bigint bigintCalculateAgreement2 = p2aacdd87Var2.calculateAgreement(p1c11fbf7Var.getEphemeralPublicKey());
        int fieldSize = getFieldSize();
        byte[] bArr = new byte[fieldSize * 2];
        p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.mec6269b9(bigintCalculateAgreement2, bArr, 0, fieldSize);
        p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.mec6269b9(bigintCalculateAgreement, bArr, fieldSize, fieldSize);
        return bArr;
    }

    public int GetFieldSize() {
        return (this.f3ce1f4a7.getStaticPrivateKey().getParameters().getP().bitLength() + 7) / 8;
    }

    public void Init(p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        this.f3ce1f4a7 = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pfbd59bca) pc9ef6b45Var;
    }
}

