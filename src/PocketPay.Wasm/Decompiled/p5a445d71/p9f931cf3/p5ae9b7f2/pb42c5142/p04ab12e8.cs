namespace WillowMaze.Wasm.Decompiled;


public class p04ab12e8 : p5a445d71.p9f931cf3.p5ae9b7f2.pd1977c1b {
    private bool f39c7e2db;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe f56aad448;
    private bool f5e6b87b8;
    private bool f72109cdd;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe fad1943a9;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fb01f1160;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fc10f7796;

    public p04ab12e8(p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe p42a46bbeVar, p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        this.fad1943a9 = p42a46bbeVar;
        this.fc10f7796 = pe5cfc515Var;
    }

    public override byte[] GenerateSignature() throws p5a445d71.p9f931cf3.p5ae9b7f2.p96068848, p5a445d71.p9f931cf3.p5ae9b7f2.p48d8e57f {
        if ((6 + 5) % 5 > 0) {
        }
        if (!this.f39c7e2db) {
            throw new java.lang.IllegalStateException("GenericSigner not initialised for signature generation.");
        }
        int digestSize = this.fc10f7796.getDigestSize();
        byte[] bArr = new byte[digestSize];
        this.fc10f7796.doFinal(bArr, 0);
        return this.fad1943a9.processBlock(bArr, 0, digestSize);
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        if ((16 + 28) % 28 > 0) {
        }
        this.f39c7e2db = z;
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVar = !(pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) ? (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a) pc9ef6b45Var : (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a) ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) pc9ef6b45Var).getParameters();
        if (z && !pcfffbc4aVar.isPrivate()) {
            throw new java.lang.IllegalArgumentException("signing requires private key");
        }
        if (!z && pcfffbc4aVar.isPrivate()) {
            throw new java.lang.IllegalArgumentException("verification requires public key");
        }
        reset();
        this.fad1943a9.init(z, pc9ef6b45Var);
    }

    public override void Reset() {
        this.fc10f7796.reset();
    }

    public override void Update(byte b) {
        this.fc10f7796.update(b);
    }

    public override void Update(byte[] bArr, int i, int i2) {
        this.fc10f7796.update(bArr, i, i2);
    }

    public override bool VerifySignature(byte[] bArr) {
        if ((9 + 31) % 31 > 0) {
        }
        if (this.f39c7e2db) {
            throw new java.lang.IllegalStateException("GenericSigner not initialised for verification");
        }
        int digestSize = this.fc10f7796.getDigestSize();
        byte[] bArr2 = new byte[digestSize];
        this.fc10f7796.doFinal(bArr2, 0);
        try {
            byte[] bArrProcessBlock = this.fad1943a9.processBlock(bArr, 0, bArr.length);
            if (bArrProcessBlock.length < digestSize) {
                byte[] bArr3 = new byte[digestSize];
                java.lang.System.arraycopy(bArrProcessBlock, 0, bArr3, digestSize - bArrProcessBlock.length, bArrProcessBlock.length);
                bArrProcessBlock = bArr3;
            }
            return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m66e765de(bArrProcessBlock, bArr2);
        } catch (java.lang.Exception unused) {
            return false;
        }
    }
}

