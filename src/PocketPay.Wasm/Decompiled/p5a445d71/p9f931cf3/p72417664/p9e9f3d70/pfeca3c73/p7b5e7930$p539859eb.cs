namespace WillowMaze.Wasm.Decompiled;


public readonly class p7b5e7930$p539859eb : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p7b5e7930$pfe43b677 {
    public p7b5e7930$p539859eb() {
        super("TLS11KDF");
    }

    protected override javax.crypto.SecretKey EngineGenerateSecret(java.security.spec.KeySpec keySpec) throws java.security.spec.InvalidKeySpecException {
        if (keySpec is p5a445d71.p9f931cf3.p72417664.pb979c293.p6672a3b4) {
            return new javax.crypto.spec.SecretKeySpec(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p7b5e7930.mf23e8626((p5a445d71.p9f931cf3.p72417664.pb979c293.p6672a3b4) keySpec), this.fcde54e56);
        }
        throw new java.security.spec.InvalidKeySpecException("Invalid KeySpec");
    }
}

