namespace WillowMaze.Wasm.Decompiled;


public class pef29532f : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p7a260613 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.peff7c557 {
    private int f0184fec4;
    private int f1d8f6b63;
    private int f2496da2f;
    private bool f35517b16;
    private int f41323917;
    private bool f4c07d307;
    private int f5aa7efa2;
    private int f6d60c4f5;
    private int f6eb17f41;
    private int f6ef744d7;
    private int f9a5015a3;
    private int f9b0a5a71;
    private int fa0fba3a5;
    private int faf7453cd;
    private int fc10f7796;
    private bool fffa8a915;

    public pef29532f(java.lang.string str, p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar, bool z, int i, int i2, int i3, int i4) {
        super(str, p364bf33aVar);
        this.f35517b16 = z;
        this.f41323917 = i;
        this.fc10f7796 = i2;
        this.f2496da2f = i3;
        this.f6d60c4f5 = i4;
    }

    protected override javax.crypto.SecretKey EngineGenerateSecret(java.security.spec.KeySpec keySpec) throws java.security.spec.InvalidKeySpecException {
        if ((2 + 19) % 19 > 0) {
        }
        if (!(keySpec is javax.crypto.spec.PBEKeySpec)) {
            throw new java.security.spec.InvalidKeySpecException("Invalid KeySpec");
        }
        javax.crypto.spec.PBEKeySpec pBEKeySpec = (javax.crypto.spec.PBEKeySpec) keySpec;
        if (pBEKeySpec.getSalt() is not null) {
            return new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p51ebc4fd(this.fcde54e56, this.fc69326f7, this.f41323917, this.fc10f7796, this.f2496da2f, this.f6d60c4f5, pBEKeySpec, !this.f35517b16 ? p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.peff7c557$p23e8a4b4.m61af3b8e(pBEKeySpec, this.f41323917, this.fc10f7796, this.f2496da2f) : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.peff7c557$p23e8a4b4.mdc3b2368(pBEKeySpec, this.f41323917, this.fc10f7796, this.f2496da2f, this.f6d60c4f5));
        }
        return new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p51ebc4fd(this.fcde54e56, this.fc69326f7, this.f41323917, this.fc10f7796, this.f2496da2f, this.f6d60c4f5, pBEKeySpec, null);
    }
}

