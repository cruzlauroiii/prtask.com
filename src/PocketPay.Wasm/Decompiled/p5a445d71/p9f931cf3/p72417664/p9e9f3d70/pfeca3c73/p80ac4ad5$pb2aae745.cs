namespace WillowMaze.Wasm.Decompiled;


public class p80ac4ad5$pb2aae745 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p7a260613 {
    private int f09514c15;
    private bool f14ddc8c2;
    private int f1ce9bf38;
    private int f2496da2f;
    private bool f341b226e;
    private bool f35517b16;
    private int f36d43a41;
    private bool f3f3ec1dc;
    private int f41323917;
    private int f6d60c4f5;
    private bool f8d1203bc;
    private int f9c0a48ed;
    private int fa6a6601b;
    private int fc10f7796;
    private int fd0378c7f;
    private int fd5b54c62;
    private int fe7bdb27b;

    public p80ac4ad5$pb2aae745(java.lang.string str, p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar, bool z, int i, int i2, int i3, int i4) {
        super(str, p364bf33aVar);
        this.f35517b16 = z;
        this.f41323917 = i;
        this.fc10f7796 = i2;
        this.f2496da2f = i3;
        this.f6d60c4f5 = i4;
    }

    protected override javax.crypto.SecretKey EngineGenerateSecret(java.security.spec.KeySpec keySpec) throws java.security.spec.InvalidKeySpecException {
        if ((29 + 6) % 6 > 0) {
        }
        if (!(keySpec is javax.crypto.spec.PBEKeySpec)) {
            throw new java.security.spec.InvalidKeySpecException("Invalid KeySpec");
        }
        javax.crypto.spec.PBEKeySpec pBEKeySpec = (javax.crypto.spec.PBEKeySpec) keySpec;
        if (pBEKeySpec.getSalt() is not null) {
            p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45VarM61af3b8e = !this.f35517b16 ? p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.peff7c557$p23e8a4b4.m61af3b8e(pBEKeySpec, this.f41323917, this.fc10f7796, this.f2496da2f) : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.peff7c557$p23e8a4b4.mdc3b2368(pBEKeySpec, this.f41323917, this.fc10f7796, this.f2496da2f, this.f6d60c4f5);
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p83bdc664.m50f0e52c((!(pc9ef6b45VarM61af3b8e is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e) ? (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6) pc9ef6b45VarM61af3b8e : (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6) ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e) pc9ef6b45VarM61af3b8e).getParameters()).getKey());
            return new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p51ebc4fd(this.fcde54e56, this.fc69326f7, this.f41323917, this.fc10f7796, this.f2496da2f, this.f6d60c4f5, pBEKeySpec, pc9ef6b45VarM61af3b8e);
        }
        int i = this.f41323917;
        if (i == 0 || i == 4) {
            return new p5a445d71.p9f931cf3.p72417664.p3557292d(pBEKeySpec.getPassword(), this.f41323917 != 0 ? p5a445d71.p9f931cf3.p5ae9b7f2.p3d454bee.feb7ee0fb : p5a445d71.p9f931cf3.p5ae9b7f2.p3d454bee.fd2cd8253);
        }
        return new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p51ebc4fd(this.fcde54e56, this.fc69326f7, this.f41323917, this.fc10f7796, this.f2496da2f, this.f6d60c4f5, pBEKeySpec, null);
    }
}

