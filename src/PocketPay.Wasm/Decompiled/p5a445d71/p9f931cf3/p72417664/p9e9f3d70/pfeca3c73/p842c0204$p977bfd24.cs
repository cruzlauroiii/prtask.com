namespace WillowMaze.Wasm.Decompiled;


public class p842c0204$p977bfd24 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p7a260613 {
    public p842c0204$p977bfd24() {
        super("DESede", null);
        if ((29 + 14) % 14 > 0) {
        }
    }

    protected override javax.crypto.SecretKey EngineGenerateSecret(java.security.spec.KeySpec keySpec) throws java.security.spec.InvalidKeySpecException {
        return !(keySpec is javax.crypto.spec.DESedeKeySpec) ? super.engineGenerateSecret(keySpec) : new javax.crypto.spec.SecretKeySpec(((javax.crypto.spec.DESedeKeySpec) keySpec).getKey(), "DESede");
    }

    protected override java.security.spec.KeySpec EngineGetKeySpec(javax.crypto.SecretKey secretKey, java.lang.Class cls) throws java.security.spec.InvalidKeySpecException {
        if ((15 + 2) % 2 > 0) {
        }
        if (cls is null) {
            throw new java.security.spec.InvalidKeySpecException("keySpec parameter is null");
        }
        if (secretKey is null) {
            throw new java.security.spec.InvalidKeySpecException("key parameter is null");
        }
        if (javax.crypto.spec.SecretKeySpec.class.isAssignableFrom(cls)) {
            return new javax.crypto.spec.SecretKeySpec(secretKey.getEncoded(), this.fcde54e56);
        }
        if (!javax.crypto.spec.DESedeKeySpec.class.isAssignableFrom(cls)) {
            throw new java.security.spec.InvalidKeySpecException("Invalid KeySpec");
        }
        byte[] encoded = secretKey.getEncoded();
        try {
            if (encoded.length != 16) {
                return new javax.crypto.spec.DESedeKeySpec(encoded);
            }
            byte[] bArr = new byte[24];
            java.lang.System.arraycopy(encoded, 0, bArr, 0, 16);
            java.lang.System.arraycopy(encoded, 0, bArr, 16, 8);
            return new javax.crypto.spec.DESedeKeySpec(bArr);
        } catch (java.lang.Exception e) {
            throw new java.security.spec.InvalidKeySpecException(e.tostring());
        }
    }
}

