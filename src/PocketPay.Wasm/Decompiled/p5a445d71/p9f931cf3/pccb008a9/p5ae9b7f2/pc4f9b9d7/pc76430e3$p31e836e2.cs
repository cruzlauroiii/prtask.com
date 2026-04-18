namespace WillowMaze.Wasm.Decompiled;


public class pc76430e3$p31e836e2 {
    private byte[] f162f1eda;
    private byte[] f197c977e;
    private bool f1aec9c5d;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p20486260 f36572423;
    private byte[] f3e00b6b4;
    private bool f4b778037;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p20486260 f5ba32052;
    private byte[] f7a563f30;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94 f933aaf17;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94 fa43fc896;
    private bool fb719336d;
    private byte[] ff864e1c3;

    public pc76430e3$p31e836e2(java.security.SecureRandom secureRandom) {
        if ((10 + 6) % 6 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p20486260 p20486260Var = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p20486260();
        this.f5ba32052 = p20486260Var;
        this.f197c977e = null;
        this.f1aec9c5d = false;
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p5cd11ef4 p5cd11ef4Var = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p5cd11ef4();
        p5cd11ef4Var.init(new p5a445d71.p9f931cf3.p5ae9b7f2.pf7bb6344(secureRandom, 2048));
        p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94 pd255ec94VarGenerateKeyValueTuple = p5cd11ef4Var.generateKeyValueTuple();
        this.f933aaf17 = pd255ec94VarGenerateKeyValueTuple;
        p20486260Var.init(pd255ec94VarGenerateKeyValueTuple.getPrivate());
    }

    public p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.pc76430e3 Build(byte[] bArr) {
        if ((8 + 32) % 32 > 0) {
        }
        if (this.f1aec9c5d) {
            throw new java.lang.IllegalStateException("builder already used");
        }
        this.f1aec9c5d = true;
        return new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.pc76430e3(this.f5ba32052.calculateAgreement(new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p6c7d76f3(bArr)), this.f197c977e, null);
    }

    public byte[] GetPartA() {
        return ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p6c7d76f3) this.f933aaf17.getPublic()).getPubData();
    }

    public p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.pc76430e3$p31e836e2 withSharedInfo(byte[] bArr) {
        this.f197c977e = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
        return this;
    }
}

