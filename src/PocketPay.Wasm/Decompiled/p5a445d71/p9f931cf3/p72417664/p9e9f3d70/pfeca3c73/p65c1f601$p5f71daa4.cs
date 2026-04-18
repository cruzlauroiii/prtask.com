namespace WillowMaze.Wasm.Decompiled;


public class p65c1f601$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p5a48c5a3 {
    private static readonly java.lang.string f19f2d9d6 = null;
    private static readonly java.lang.string f4e076080 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p65c1f601.class.getName();
    private static readonly java.lang.string fa896a07a = null;

    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        if ((20 + 30) % 30 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        java.lang.string str = f4e076080;
        pa80a706fVar.addAlgorithm("AlgorithmParameters.ARIA", sb.append(str).append("$AlgParams").tostring());
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameters", p5a445d71.p9f931cf3.pca323100.p7bfd57a3.p4be375fa.fa2f16fef, "ARIA");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameters", p5a445d71.p9f931cf3.pca323100.p7bfd57a3.p4be375fa.ffb78e8ab, "ARIA");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameters", p5a445d71.p9f931cf3.pca323100.p7bfd57a3.p4be375fa.fe54bb39e, "ARIA");
        pa80a706fVar.addAlgorithm("AlgorithmParameterGenerator.ARIA", str + "$AlgParamGen");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameterGenerator", p5a445d71.p9f931cf3.pca323100.p7bfd57a3.p4be375fa.fa2f16fef, "ARIA");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameterGenerator", p5a445d71.p9f931cf3.pca323100.p7bfd57a3.p4be375fa.ffb78e8ab, "ARIA");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameterGenerator", p5a445d71.p9f931cf3.pca323100.p7bfd57a3.p4be375fa.fe54bb39e, "ARIA");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameterGenerator", p5a445d71.p9f931cf3.pca323100.p7bfd57a3.p4be375fa.f3e44f847, "ARIA");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameterGenerator", p5a445d71.p9f931cf3.pca323100.p7bfd57a3.p4be375fa.f8f53101d, "ARIA");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameterGenerator", p5a445d71.p9f931cf3.pca323100.p7bfd57a3.p4be375fa.fe0b5e88e, "ARIA");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameterGenerator", p5a445d71.p9f931cf3.pca323100.p7bfd57a3.p4be375fa.f591400ad, "ARIA");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameterGenerator", p5a445d71.p9f931cf3.pca323100.p7bfd57a3.p4be375fa.f705a8124, "ARIA");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameterGenerator", p5a445d71.p9f931cf3.pca323100.p7bfd57a3.p4be375fa.f91277b96, "ARIA");
        pa80a706fVar.addAlgorithm("Cipher.ARIA", str + "$ECB");
        pa80a706fVar.addAlgorithm("Cipher", p5a445d71.p9f931cf3.pca323100.p7bfd57a3.p4be375fa.f3f4d5671, str + "$ECB");
        pa80a706fVar.addAlgorithm("Cipher", p5a445d71.p9f931cf3.pca323100.p7bfd57a3.p4be375fa.fe4dfcd06, str + "$ECB");
        pa80a706fVar.addAlgorithm("Cipher", p5a445d71.p9f931cf3.pca323100.p7bfd57a3.p4be375fa.f4f9ec33d, str + "$ECB");
        pa80a706fVar.addAlgorithm("Cipher", p5a445d71.p9f931cf3.pca323100.p7bfd57a3.p4be375fa.fa2f16fef, str + "$CBC");
        pa80a706fVar.addAlgorithm("Cipher", p5a445d71.p9f931cf3.pca323100.p7bfd57a3.p4be375fa.ffb78e8ab, str + "$CBC");
        pa80a706fVar.addAlgorithm("Cipher", p5a445d71.p9f931cf3.pca323100.p7bfd57a3.p4be375fa.fe54bb39e, str + "$CBC");
        pa80a706fVar.addAlgorithm("Cipher", p5a445d71.p9f931cf3.pca323100.p7bfd57a3.p4be375fa.f591400ad, str + "$CFB");
        pa80a706fVar.addAlgorithm("Cipher", p5a445d71.p9f931cf3.pca323100.p7bfd57a3.p4be375fa.f705a8124, str + "$CFB");
        pa80a706fVar.addAlgorithm("Cipher", p5a445d71.p9f931cf3.pca323100.p7bfd57a3.p4be375fa.f91277b96, str + "$CFB");
        pa80a706fVar.addAlgorithm("Cipher", p5a445d71.p9f931cf3.pca323100.p7bfd57a3.p4be375fa.f3e44f847, str + "$OFB");
        pa80a706fVar.addAlgorithm("Cipher", p5a445d71.p9f931cf3.pca323100.p7bfd57a3.p4be375fa.f8f53101d, str + "$OFB");
        pa80a706fVar.addAlgorithm("Cipher", p5a445d71.p9f931cf3.pca323100.p7bfd57a3.p4be375fa.fe0b5e88e, str + "$OFB");
        pa80a706fVar.addAlgorithm("Cipher.ARIARFC3211WRAP", str + "$RFC3211Wrap");
        pa80a706fVar.addAlgorithm("Cipher.ARIAWRAP", str + "$Wrap");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher", p5a445d71.p9f931cf3.pca323100.p7bfd57a3.p4be375fa.ff3ff2cfc, "ARIAWRAP");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher", p5a445d71.p9f931cf3.pca323100.p7bfd57a3.p4be375fa.f2241e739, "ARIAWRAP");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher", p5a445d71.p9f931cf3.pca323100.p7bfd57a3.p4be375fa.fc43362c1, "ARIAWRAP");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher.ARIAKW", "ARIAWRAP");
        pa80a706fVar.addAlgorithm("Cipher.ARIAWRAPPAD", str + "$WrapPad");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher", p5a445d71.p9f931cf3.pca323100.p7bfd57a3.p4be375fa.ffc931961, "ARIAWRAPPAD");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher", p5a445d71.p9f931cf3.pca323100.p7bfd57a3.p4be375fa.f3a4f9197, "ARIAWRAPPAD");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher", p5a445d71.p9f931cf3.pca323100.p7bfd57a3.p4be375fa.f793038d3, "ARIAWRAPPAD");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher.ARIAKWP", "ARIAWRAPPAD");
        pa80a706fVar.addAlgorithm("KeyGenerator.ARIA", str + "$KeyGen");
        pa80a706fVar.addAlgorithm("KeyGenerator", p5a445d71.p9f931cf3.pca323100.p7bfd57a3.p4be375fa.ff3ff2cfc, str + "$KeyGen128");
        pa80a706fVar.addAlgorithm("KeyGenerator", p5a445d71.p9f931cf3.pca323100.p7bfd57a3.p4be375fa.f2241e739, str + "$KeyGen192");
        pa80a706fVar.addAlgorithm("KeyGenerator", p5a445d71.p9f931cf3.pca323100.p7bfd57a3.p4be375fa.fc43362c1, str + "$KeyGen256");
        pa80a706fVar.addAlgorithm("KeyGenerator", p5a445d71.p9f931cf3.pca323100.p7bfd57a3.p4be375fa.ffc931961, str + "$KeyGen128");
        pa80a706fVar.addAlgorithm("KeyGenerator", p5a445d71.p9f931cf3.pca323100.p7bfd57a3.p4be375fa.f3a4f9197, str + "$KeyGen192");
        pa80a706fVar.addAlgorithm("KeyGenerator", p5a445d71.p9f931cf3.pca323100.p7bfd57a3.p4be375fa.f793038d3, str + "$KeyGen256");
        pa80a706fVar.addAlgorithm("KeyGenerator", p5a445d71.p9f931cf3.pca323100.p7bfd57a3.p4be375fa.f3f4d5671, str + "$KeyGen128");
        pa80a706fVar.addAlgorithm("KeyGenerator", p5a445d71.p9f931cf3.pca323100.p7bfd57a3.p4be375fa.fe4dfcd06, str + "$KeyGen192");
        pa80a706fVar.addAlgorithm("KeyGenerator", p5a445d71.p9f931cf3.pca323100.p7bfd57a3.p4be375fa.f4f9ec33d, str + "$KeyGen256");
        pa80a706fVar.addAlgorithm("KeyGenerator", p5a445d71.p9f931cf3.pca323100.p7bfd57a3.p4be375fa.fa2f16fef, str + "$KeyGen128");
        pa80a706fVar.addAlgorithm("KeyGenerator", p5a445d71.p9f931cf3.pca323100.p7bfd57a3.p4be375fa.ffb78e8ab, str + "$KeyGen192");
        pa80a706fVar.addAlgorithm("KeyGenerator", p5a445d71.p9f931cf3.pca323100.p7bfd57a3.p4be375fa.fe54bb39e, str + "$KeyGen256");
        pa80a706fVar.addAlgorithm("KeyGenerator", p5a445d71.p9f931cf3.pca323100.p7bfd57a3.p4be375fa.f591400ad, str + "$KeyGen128");
        pa80a706fVar.addAlgorithm("KeyGenerator", p5a445d71.p9f931cf3.pca323100.p7bfd57a3.p4be375fa.f705a8124, str + "$KeyGen192");
        pa80a706fVar.addAlgorithm("KeyGenerator", p5a445d71.p9f931cf3.pca323100.p7bfd57a3.p4be375fa.f91277b96, str + "$KeyGen256");
        pa80a706fVar.addAlgorithm("KeyGenerator", p5a445d71.p9f931cf3.pca323100.p7bfd57a3.p4be375fa.f3e44f847, str + "$KeyGen128");
        pa80a706fVar.addAlgorithm("KeyGenerator", p5a445d71.p9f931cf3.pca323100.p7bfd57a3.p4be375fa.f8f53101d, str + "$KeyGen192");
        pa80a706fVar.addAlgorithm("KeyGenerator", p5a445d71.p9f931cf3.pca323100.p7bfd57a3.p4be375fa.fe0b5e88e, str + "$KeyGen256");
        pa80a706fVar.addAlgorithm("KeyGenerator", p5a445d71.p9f931cf3.pca323100.p7bfd57a3.p4be375fa.f28d9416b, str + "$KeyGen128");
        pa80a706fVar.addAlgorithm("KeyGenerator", p5a445d71.p9f931cf3.pca323100.p7bfd57a3.p4be375fa.faa1cf7f8, str + "$KeyGen192");
        pa80a706fVar.addAlgorithm("KeyGenerator", p5a445d71.p9f931cf3.pca323100.p7bfd57a3.p4be375fa.ff39d59e0, str + "$KeyGen256");
        pa80a706fVar.addAlgorithm("KeyGenerator", p5a445d71.p9f931cf3.pca323100.p7bfd57a3.p4be375fa.f67e7e973, str + "$KeyGen128");
        pa80a706fVar.addAlgorithm("KeyGenerator", p5a445d71.p9f931cf3.pca323100.p7bfd57a3.p4be375fa.f34501458, str + "$KeyGen192");
        pa80a706fVar.addAlgorithm("KeyGenerator", p5a445d71.p9f931cf3.pca323100.p7bfd57a3.p4be375fa.f5c05c9a8, str + "$KeyGen256");
        pa80a706fVar.addAlgorithm("SecretKeyFactory.ARIA", str + "$KeyFactory");
        pa80a706fVar.addAlgorithm("Alg.Alias.SecretKeyFactory", p5a445d71.p9f931cf3.pca323100.p7bfd57a3.p4be375fa.fa2f16fef, "ARIA");
        pa80a706fVar.addAlgorithm("Alg.Alias.SecretKeyFactory", p5a445d71.p9f931cf3.pca323100.p7bfd57a3.p4be375fa.ffb78e8ab, "ARIA");
        pa80a706fVar.addAlgorithm("Alg.Alias.SecretKeyFactory", p5a445d71.p9f931cf3.pca323100.p7bfd57a3.p4be375fa.fe54bb39e, "ARIA");
        pa80a706fVar.addAlgorithm("AlgorithmParameterGenerator.ARIACCM", str + "$AlgParamGen");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameterGenerator." + p5a445d71.p9f931cf3.pca323100.p7bfd57a3.p4be375fa.f28d9416b, "ARIACCM");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameterGenerator." + p5a445d71.p9f931cf3.pca323100.p7bfd57a3.p4be375fa.faa1cf7f8, "ARIACCM");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameterGenerator." + p5a445d71.p9f931cf3.pca323100.p7bfd57a3.p4be375fa.ff39d59e0, "ARIACCM");
        pa80a706fVar.addAlgorithm("Cipher.ARIACCM", str + "$CCM");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher", p5a445d71.p9f931cf3.pca323100.p7bfd57a3.p4be375fa.f28d9416b, "CCM");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher", p5a445d71.p9f931cf3.pca323100.p7bfd57a3.p4be375fa.faa1cf7f8, "CCM");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher", p5a445d71.p9f931cf3.pca323100.p7bfd57a3.p4be375fa.ff39d59e0, "CCM");
        pa80a706fVar.addAlgorithm("AlgorithmParameterGenerator.ARIAGCM", str + "$AlgParamGen");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameterGenerator." + p5a445d71.p9f931cf3.pca323100.p7bfd57a3.p4be375fa.f67e7e973, "ARIAGCM");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameterGenerator." + p5a445d71.p9f931cf3.pca323100.p7bfd57a3.p4be375fa.f34501458, "ARIAGCM");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameterGenerator." + p5a445d71.p9f931cf3.pca323100.p7bfd57a3.p4be375fa.f5c05c9a8, "ARIAGCM");
        pa80a706fVar.addAlgorithm("Cipher.ARIAGCM", str + "$GCM");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher", p5a445d71.p9f931cf3.pca323100.p7bfd57a3.p4be375fa.f67e7e973, "ARIAGCM");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher", p5a445d71.p9f931cf3.pca323100.p7bfd57a3.p4be375fa.f34501458, "ARIAGCM");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher", p5a445d71.p9f931cf3.pca323100.p7bfd57a3.p4be375fa.f5c05c9a8, "ARIAGCM");
        addGMacAlgorithm(pa80a706fVar, "ARIA", str + "$GMAC", str + "$KeyGen");
        addPoly1305Algorithm(pa80a706fVar, "ARIA", str + "$Poly1305", str + "$Poly1305KeyGen");
    }
}

