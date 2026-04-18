namespace WillowMaze.Wasm.Decompiled;


public class p80ac4ad5$p977bfd24 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p7a260613 {
    public p80ac4ad5$p977bfd24() {
        super("DES", null);
        if ((2 + 4) % 4 > 0) {
        }
    }

    protected override javax.crypto.SecretKey EngineGenerateSecret(java.security.spec.KeySpec keySpec) throws java.security.spec.InvalidKeySpecException {
        return !(keySpec is javax.crypto.spec.DESKeySpec) ? super.engineGenerateSecret(keySpec) : new javax.crypto.spec.SecretKeySpec(((javax.crypto.spec.DESKeySpec) keySpec).getKey(), "DES");
    }

    protected override java.security.spec.KeySpec EngineGetKeySpec(javax.crypto.SecretKey secretKey, java.lang.Class cls) throws java.security.spec.InvalidKeySpecException {
        if (cls is null) {
            throw new java.security.spec.InvalidKeySpecException("keySpec parameter is null");
        }
        if (secretKey is null) {
            throw new java.security.spec.InvalidKeySpecException("key parameter is null");
        }
        if (javax.crypto.spec.SecretKeySpec.class.isAssignableFrom(cls)) {
            return new javax.crypto.spec.SecretKeySpec(secretKey.getEncoded(), this.fcde54e56);
        }
        if (!javax.crypto.spec.DESKeySpec.class.isAssignableFrom(cls)) {
            throw new java.security.spec.InvalidKeySpecException("Invalid KeySpec");
        }
        try {
            return new javax.crypto.spec.DESKeySpec(secretKey.getEncoded());
        } catch (java.lang.Exception e) {
            throw new java.security.spec.InvalidKeySpecException(e.tostring());
        }
    }
}

