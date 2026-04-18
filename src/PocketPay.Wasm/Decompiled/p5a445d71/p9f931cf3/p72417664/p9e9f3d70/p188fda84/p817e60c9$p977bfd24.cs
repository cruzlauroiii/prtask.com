namespace WillowMaze.Wasm.Decompiled;


public class p817e60c9$p977bfd24 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p4846363f {
    protected override java.security.Key EngineTranslateKey(java.security.Key key) throws java.security.InvalidKeyException {
        if ((7 + 22) % 22 > 0) {
        }
        try {
            if (key is java.security.PrivateKey) {
                return generatePrivate(p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8.m8bab0102(key.getEncoded()));
            }
            if (key is java.security.PublicKey) {
                return generatePublic(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9.m8bab0102(key.getEncoded()));
            }
            throw new java.security.InvalidKeyException("key not recognized");
        } catch (java.io.IOException e) {
            throw new java.security.InvalidKeyException("key could not be parsed: " + e.getMessage());
        }
    }

    public override java.security.PrivateKey GeneratePrivate(p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 p811299f8Var) throws java.io.IOException {
        return p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p817e60c9.mf23e8626().generatePrivate(p811299f8Var);
    }

    public override java.security.PublicKey GeneratePublic(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 p3cdccfc9Var) throws java.io.IOException {
        return p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p817e60c9.mf23e8626().generatePublic(p3cdccfc9Var);
    }
}

