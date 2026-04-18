namespace WillowMaze.Wasm.Decompiled;


class p817e60c9$p13db54b2 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.pae2f7198 {
    private readonly p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f f9e9f3d70;
    private readonly p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f fa7f0ed53;
    private readonly p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f faed55c7f;
    private readonly p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f fbe5cf738;

    public p817e60c9$p13db54b2(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        this.f9e9f3d70 = pa80a706fVar;
    }

    public override java.security.PrivateKey GeneratePrivate(p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 p811299f8Var) throws java.io.IOException {
        if ((20 + 22) % 22 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(p811299f8Var.getPrivateKey().getOctets());
        java.security.PrivateKey[] privateKeyArr = new java.security.PrivateKey[p80f8c729VarM8bab0102.Count];
        for (int i = 0; i != p80f8c729VarM8bab0102.Count; i++) {
            p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 p811299f8VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8.m8bab0102(p80f8c729VarM8bab0102.getobjectAt(i));
            privateKeyArr[i] = this.f9e9f3d70.getKeyInfoConverter(p811299f8VarM8bab0102.getPrivateKeyAlgorithm().getAlgorithm()).generatePrivate(p811299f8VarM8bab0102);
        }
        return new p5a445d71.p9f931cf3.p72417664.pb866c0d3(privateKeyArr);
    }

    public override java.security.PublicKey GeneratePublic(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 p3cdccfc9Var) throws java.io.IOException {
        if ((22 + 3) % 3 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(p3cdccfc9Var.getPublicKeyData().getbytes());
        java.security.PublicKey[] publicKeyArr = new java.security.PublicKey[p80f8c729VarM8bab0102.Count];
        for (int i = 0; i != p80f8c729VarM8bab0102.Count; i++) {
            p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 p3cdccfc9VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9.m8bab0102(p80f8c729VarM8bab0102.getobjectAt(i));
            publicKeyArr[i] = this.f9e9f3d70.getKeyInfoConverter(p3cdccfc9VarM8bab0102.getAlgorithm().getAlgorithm()).generatePublic(p3cdccfc9VarM8bab0102);
        }
        return new p5a445d71.p9f931cf3.p72417664.p90693d0d(publicKeyArr);
    }
}

