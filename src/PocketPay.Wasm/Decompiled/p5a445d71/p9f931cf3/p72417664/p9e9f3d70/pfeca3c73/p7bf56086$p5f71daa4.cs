namespace WillowMaze.Wasm.Decompiled;


public class p7bf56086$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p5a48c5a3 {
    private static readonly java.lang.string f4e076080 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p7bf56086.class.getName();
    private static readonly java.lang.string f51b69310 = null;
    private static readonly java.lang.string f8eb7d5c7 = null;

    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        if ((17 + 18) % 18 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        java.lang.string str = f4e076080;
        pa80a706fVar.addAlgorithm("AlgorithmParameters.CAMELLIA", sb.append(str).append("$AlgParams").tostring());
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameters", p5a445d71.p9f931cf3.pca323100.pccb3669c.p3a062925.fcb3a47ce, "CAMELLIA");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameters", p5a445d71.p9f931cf3.pca323100.pccb3669c.p3a062925.fe9b51a84, "CAMELLIA");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameters", p5a445d71.p9f931cf3.pca323100.pccb3669c.p3a062925.fcd5fd581, "CAMELLIA");
        pa80a706fVar.addAlgorithm("AlgorithmParameterGenerator.CAMELLIA", str + "$AlgParamGen");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameterGenerator", p5a445d71.p9f931cf3.pca323100.pccb3669c.p3a062925.fcb3a47ce, "CAMELLIA");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameterGenerator", p5a445d71.p9f931cf3.pca323100.pccb3669c.p3a062925.fe9b51a84, "CAMELLIA");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameterGenerator", p5a445d71.p9f931cf3.pca323100.pccb3669c.p3a062925.fcd5fd581, "CAMELLIA");
        pa80a706fVar.addAlgorithm("Cipher.CAMELLIA", str + "$ECB");
        pa80a706fVar.addAlgorithm("Cipher", p5a445d71.p9f931cf3.pca323100.pccb3669c.p3a062925.fcb3a47ce, str + "$CBC");
        pa80a706fVar.addAlgorithm("Cipher", p5a445d71.p9f931cf3.pca323100.pccb3669c.p3a062925.fe9b51a84, str + "$CBC");
        pa80a706fVar.addAlgorithm("Cipher", p5a445d71.p9f931cf3.pca323100.pccb3669c.p3a062925.fcd5fd581, str + "$CBC");
        pa80a706fVar.addAlgorithm("Cipher.CAMELLIARFC3211WRAP", str + "$RFC3211Wrap");
        pa80a706fVar.addAlgorithm("Cipher.CAMELLIAWRAP", str + "$Wrap");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher", p5a445d71.p9f931cf3.pca323100.pccb3669c.p3a062925.f192db499, "CAMELLIAWRAP");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher", p5a445d71.p9f931cf3.pca323100.pccb3669c.p3a062925.f7c229982, "CAMELLIAWRAP");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher", p5a445d71.p9f931cf3.pca323100.pccb3669c.p3a062925.f86b40f3d, "CAMELLIAWRAP");
        pa80a706fVar.addAlgorithm("SecretKeyFactory.CAMELLIA", str + "$KeyFactory");
        pa80a706fVar.addAlgorithm("Alg.Alias.SecretKeyFactory", p5a445d71.p9f931cf3.pca323100.pccb3669c.p3a062925.fcb3a47ce, "CAMELLIA");
        pa80a706fVar.addAlgorithm("Alg.Alias.SecretKeyFactory", p5a445d71.p9f931cf3.pca323100.pccb3669c.p3a062925.fe9b51a84, "CAMELLIA");
        pa80a706fVar.addAlgorithm("Alg.Alias.SecretKeyFactory", p5a445d71.p9f931cf3.pca323100.pccb3669c.p3a062925.fcd5fd581, "CAMELLIA");
        pa80a706fVar.addAlgorithm("KeyGenerator.CAMELLIA", str + "$KeyGen");
        pa80a706fVar.addAlgorithm("KeyGenerator", p5a445d71.p9f931cf3.pca323100.pccb3669c.p3a062925.f192db499, str + "$KeyGen128");
        pa80a706fVar.addAlgorithm("KeyGenerator", p5a445d71.p9f931cf3.pca323100.pccb3669c.p3a062925.f7c229982, str + "$KeyGen192");
        pa80a706fVar.addAlgorithm("KeyGenerator", p5a445d71.p9f931cf3.pca323100.pccb3669c.p3a062925.f86b40f3d, str + "$KeyGen256");
        pa80a706fVar.addAlgorithm("KeyGenerator", p5a445d71.p9f931cf3.pca323100.pccb3669c.p3a062925.fcb3a47ce, str + "$KeyGen128");
        pa80a706fVar.addAlgorithm("KeyGenerator", p5a445d71.p9f931cf3.pca323100.pccb3669c.p3a062925.fe9b51a84, str + "$KeyGen192");
        pa80a706fVar.addAlgorithm("KeyGenerator", p5a445d71.p9f931cf3.pca323100.pccb3669c.p3a062925.fcd5fd581, str + "$KeyGen256");
        addGMacAlgorithm(pa80a706fVar, "CAMELLIA", str + "$GMAC", str + "$KeyGen");
        addPoly1305Algorithm(pa80a706fVar, "CAMELLIA", str + "$Poly1305", str + "$Poly1305KeyGen");
    }
}

