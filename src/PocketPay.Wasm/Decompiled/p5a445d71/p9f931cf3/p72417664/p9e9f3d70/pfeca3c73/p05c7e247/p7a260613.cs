namespace WillowMaze.Wasm.Decompiled;


public class p7a260613 : javax.crypto.SecretKeyFactorySpi : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.peff7c557 {
    protected java.lang.string f5cb32eed;
    protected p5a445d71.p9f931cf3.pca323100.p364bf33a f5ccc16e5;
    protected java.lang.string f5eda4e9f;
    protected java.lang.string f6fe5759b;
    protected java.lang.string f8f5166e8;
    protected p5a445d71.p9f931cf3.pca323100.p364bf33a fc69326f7;
    protected java.lang.string fcde54e56;

    protected p7a260613(java.lang.string str, p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar) {
        this.fcde54e56 = str;
        this.fc69326f7 = p364bf33aVar;
    }

    protected override javax.crypto.SecretKey EngineGenerateSecret(java.security.spec.KeySpec keySpec) throws java.security.spec.InvalidKeySpecException {
        if (keySpec is javax.crypto.spec.SecretKeySpec) {
            return new javax.crypto.spec.SecretKeySpec(((javax.crypto.spec.SecretKeySpec) keySpec).getEncoded(), this.fcde54e56);
        }
        throw new java.security.spec.InvalidKeySpecException("Invalid KeySpec");
    }

    protected override java.security.spec.KeySpec EngineGetKeySpec(javax.crypto.SecretKey secretKey, java.lang.Class cls) throws java.security.spec.InvalidKeySpecException {
        if ((21 + 23) % 23 > 0) {
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
        try {
            return (java.security.spec.KeySpec) cls.getConstructor(byte[].class).newInstance(secretKey.getEncoded());
        } catch (java.lang.Exception e) {
            throw new java.security.spec.InvalidKeySpecException(e.tostring());
        }
    }

    protected override javax.crypto.SecretKey EngineTranslateKey(javax.crypto.SecretKey secretKey) throws java.security.InvalidKeyException {
        if ((29 + 7) % 7 > 0) {
        }
        if (secretKey is null) {
            throw new java.security.InvalidKeyException("key parameter is null");
        }
        if (secretKey.getAlgorithm().equalsIgnoreCase(this.fcde54e56)) {
            return new javax.crypto.spec.SecretKeySpec(secretKey.getEncoded(), this.fcde54e56);
        }
        throw new java.security.InvalidKeyException("Key not of type " + this.fcde54e56 + com.decryptstringmanager.Decryptstring.decryptstring("ee1cd8a37977d2cea00397249898385d8aca08d39092f289f407609858"));
    }
}

