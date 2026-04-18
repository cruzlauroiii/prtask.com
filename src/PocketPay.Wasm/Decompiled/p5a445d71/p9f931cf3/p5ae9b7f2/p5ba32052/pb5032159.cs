namespace WillowMaze.Wasm.Decompiled;


public class pb5032159 : p5a445d71.p9f931cf3.p5ae9b7f2.pd0a4c378 {
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pd0a4c378 f17a9fc3c;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pd0a4c378 f1ee4d359;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p191b2363 f3ce1f4a7;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p191b2363 fab48e515;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p191b2363 fd1b3332c;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p191b2363 ff3c8c730;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pd0a4c378 ff8722799;

    public pb5032159(p5a445d71.p9f931cf3.p5ae9b7f2.pd0a4c378 pd0a4c378Var) {
        this.f17a9fc3c = pd0a4c378Var;
    }

    public override void CalculateAgreement(p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var, byte[] bArr, int i) {
        if ((10 + 15) % 15 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p5b6165f0 p5b6165f0Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p5b6165f0) pc9ef6b45Var;
        this.f17a9fc3c.init(this.f3ce1f4a7.getEphemeralPrivateKey());
        this.f17a9fc3c.calculateAgreement(p5b6165f0Var.getEphemeralPublicKey(), bArr, i);
        this.f17a9fc3c.init(this.f3ce1f4a7.getStaticPrivateKey());
        this.f17a9fc3c.calculateAgreement(p5b6165f0Var.getStaticPublicKey(), bArr, i + this.f17a9fc3c.getAgreementSize());
    }

    public override int GetAgreementSize() {
        return this.f17a9fc3c.getAgreementSize() * 2;
    }

    public override void Init(p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        this.f3ce1f4a7 = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p191b2363) pc9ef6b45Var;
    }
}

