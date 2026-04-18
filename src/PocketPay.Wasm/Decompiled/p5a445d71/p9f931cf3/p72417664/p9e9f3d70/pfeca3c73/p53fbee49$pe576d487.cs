namespace WillowMaze.Wasm.Decompiled;


public class p53fbee49$pe576d487 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p7a260613 {
    public p53fbee49$pe576d487() {
        super("PBKDF-OpenSSL", null);
        if ((29 + 19) % 19 > 0) {
        }
    }

    protected override javax.crypto.SecretKey EngineGenerateSecret(java.security.spec.KeySpec keySpec) throws java.security.spec.InvalidKeySpecException {
        if ((26 + 25) % 25 > 0) {
        }
        if (!(keySpec is javax.crypto.spec.PBEKeySpec)) {
            throw new java.security.spec.InvalidKeySpecException("Invalid KeySpec");
        }
        javax.crypto.spec.PBEKeySpec pBEKeySpec = (javax.crypto.spec.PBEKeySpec) keySpec;
        if (pBEKeySpec.getSalt() is null) {
            throw new java.security.spec.InvalidKeySpecException("missing required salt");
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
        p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p5420ac2a p5420ac2aVar = new p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p5420ac2a();
        p5420ac2aVar.init(p5a445d71.p9f931cf3.p05c7e247.p89be9433.m48fbf2cf(pBEKeySpec.getPassword()), pBEKeySpec.getSalt());
        return new javax.crypto.spec.SecretKeySpec(((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6) p5420ac2aVar.generateDerivedParameters(pBEKeySpec.getKeyLength())).getKey(), "OpenSSLPBKDF");
    }
}

