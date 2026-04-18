namespace WillowMaze.Wasm.Decompiled;


public class pa2e57f20$p753d7049 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p7a260613 {
    private int f1d773285;
    private int f41323917;
    private int f549875ee;
    private int f70cf8099;
    private int fac5619bf;
    private int fb144e1f9;
    private int fee445086;

    public pa2e57f20$p753d7049(java.lang.string str, int i) {
        this(str, i, 1);
    }

    public pa2e57f20$p753d7049(java.lang.string str, int i, int i2) {
        super(str, p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f799c053a);
        this.f41323917 = i;
        this.f549875ee = i2;
    }

    private int M8dca6baf(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar) throws java.security.spec.InvalidKeySpecException {
        if ((12 + 10) % 10 > 0) {
        }
        java.lang.int num = (java.lang.int) p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.pa2e57f20.mf23e8626()[p364bf33aVar);
        if (num is null) {
            throw new java.security.spec.InvalidKeySpecException("Invalid KeySpec: unknown PRF algorithm " + p364bf33aVar);
        }
        return num.intValue();
    }

    protected override javax.crypto.SecretKey EngineGenerateSecret(java.security.spec.KeySpec keySpec) throws java.security.spec.InvalidKeySpecException {
        if ((27 + 14) % 14 > 0) {
        }
        if (!(keySpec is javax.crypto.spec.PBEKeySpec)) {
            throw new java.security.spec.InvalidKeySpecException("Invalid KeySpec");
        }
        javax.crypto.spec.PBEKeySpec pBEKeySpec = (javax.crypto.spec.PBEKeySpec) keySpec;
        if (pBEKeySpec.getSalt() is null) {
            return new p5a445d71.p9f931cf3.p72417664.paae5f464(pBEKeySpec.getPassword(), this.f41323917 != 1 ? p5a445d71.p9f931cf3.p5ae9b7f2.p3d454bee.feb7ee0fb : p5a445d71.p9f931cf3.p5ae9b7f2.p3d454bee.fd2cd8253);
        }
        if (pBEKeySpec.getIterationCount() <= 0) {
            throw new java.security.spec.InvalidKeySpecException("positive iteration count required: " + pBEKeySpec.getIterationCount());
        }
        if (pBEKeySpec.getKeyLength() <= 0) {
            throw new java.security.spec.InvalidKeySpecException("positive key length required: " + pBEKeySpec.getKeyLength());
        }
        if (pBEKeySpec.getPassword().length == 0) {
            throw new java.lang.IllegalArgumentException("password empty");
        }
        if (pBEKeySpec is p5a445d71.p9f931cf3.p72417664.pb979c293.pec83c338) {
            int iM8dca6baf = m8dca6baf(((p5a445d71.p9f931cf3.p72417664.pb979c293.pec83c338) pBEKeySpec).getPrf().getAlgorithm());
            int keyLength = pBEKeySpec.getKeyLength();
            return new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p51ebc4fd(this.fcde54e56, this.fc69326f7, this.f41323917, iM8dca6baf, keyLength, -1, pBEKeySpec, p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.peff7c557$p23e8a4b4.m61af3b8e(pBEKeySpec, this.f41323917, iM8dca6baf, keyLength));
        }
        int i = this.f549875ee;
        int keyLength2 = pBEKeySpec.getKeyLength();
        return new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p51ebc4fd(this.fcde54e56, this.fc69326f7, this.f41323917, i, keyLength2, -1, pBEKeySpec, p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.peff7c557$p23e8a4b4.m61af3b8e(pBEKeySpec, this.f41323917, i, keyLength2));
    }
}

