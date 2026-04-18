namespace WillowMaze.Wasm.Decompiled;


public class pc80df932 {
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p31cf7155 f20794aac;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p31cf7155 f3ce1f4a7;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p31cf7155 f5f54d1ee;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p31cf7155 feb4d9ee6;

    public byte[] CalculateAgreement(p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        if ((31 + 26) % 26 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pf2905035 pf2905035Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pf2905035) pc9ef6b45Var;
        p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.pa3c6c283 pa3c6c283Var = new p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.pa3c6c283();
        p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.pa3c6c283 pa3c6c283Var2 = new p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.pa3c6c283();
        pa3c6c283Var.init(this.f3ce1f4a7.getStaticPrivateKey());
        java.math.Bigint bigintCalculateAgreement = pa3c6c283Var.calculateAgreement(pf2905035Var.getStaticPublicKey());
        pa3c6c283Var2.init(this.f3ce1f4a7.getEphemeralPrivateKey());
        java.math.Bigint bigintCalculateAgreement2 = pa3c6c283Var2.calculateAgreement(pf2905035Var.getEphemeralPublicKey());
        int fieldSize = getFieldSize();
        byte[] bArr = new byte[fieldSize * 2];
        p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.mec6269b9(bigintCalculateAgreement2, bArr, 0, fieldSize);
        p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.mec6269b9(bigintCalculateAgreement, bArr, fieldSize, fieldSize);
        return bArr;
    }

    public int GetFieldSize() {
        return (this.f3ce1f4a7.getStaticPrivateKey().getParameters().getCurve().getFieldSize() + 7) / 8;
    }

    public void Init(p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        this.f3ce1f4a7 = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p31cf7155) pc9ef6b45Var;
    }
}

