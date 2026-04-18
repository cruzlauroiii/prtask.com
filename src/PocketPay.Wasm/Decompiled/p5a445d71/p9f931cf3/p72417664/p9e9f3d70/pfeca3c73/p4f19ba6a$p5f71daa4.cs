namespace WillowMaze.Wasm.Decompiled;


public class p4f19ba6a$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p5a48c5a3 {
    private static readonly java.lang.string f292b9a87 = null;
    private static readonly java.lang.string f4e076080 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p4f19ba6a.class.getName();

    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        if ((15 + 31) % 31 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        java.lang.string str = f4e076080;
        pa80a706fVar.addAlgorithm("AlgorithmParameters.DSTU7624", sb.append(str).append("$AlgParams").tostring());
        pa80a706fVar.addAlgorithm("AlgorithmParameters", p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.f6aa11d6d, str + "$AlgParams");
        pa80a706fVar.addAlgorithm("AlgorithmParameters", p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.f55ae875e, str + "$AlgParams");
        pa80a706fVar.addAlgorithm("AlgorithmParameters", p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.f0c28c26e, str + "$AlgParams");
        pa80a706fVar.addAlgorithm("AlgorithmParameterGenerator.DSTU7624", str + "$AlgParamGen128");
        pa80a706fVar.addAlgorithm("AlgorithmParameterGenerator", p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.f6aa11d6d, str + "$AlgParamGen128");
        pa80a706fVar.addAlgorithm("AlgorithmParameterGenerator", p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.f55ae875e, str + "$AlgParamGen256");
        pa80a706fVar.addAlgorithm("AlgorithmParameterGenerator", p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.f0c28c26e, str + "$AlgParamGen512");
        pa80a706fVar.addAlgorithm("Cipher.DSTU7624", str + "$ECB_128");
        pa80a706fVar.addAlgorithm("Cipher.DSTU7624-128", str + "$ECB_128");
        pa80a706fVar.addAlgorithm("Cipher.DSTU7624-256", str + "$ECB_256");
        pa80a706fVar.addAlgorithm("Cipher.DSTU7624-512", str + "$ECB_512");
        pa80a706fVar.addAlgorithm("Cipher", p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.fb4f6907b, str + "$ECB128");
        pa80a706fVar.addAlgorithm("Cipher", p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.f74b70904, str + "$ECB256");
        pa80a706fVar.addAlgorithm("Cipher", p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.f152c68f0, str + "$ECB512");
        pa80a706fVar.addAlgorithm("Cipher", p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.f6aa11d6d, str + "$CBC128");
        pa80a706fVar.addAlgorithm("Cipher", p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.f55ae875e, str + "$CBC256");
        pa80a706fVar.addAlgorithm("Cipher", p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.f0c28c26e, str + "$CBC512");
        pa80a706fVar.addAlgorithm("Cipher", p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.fd2bee720, str + "$OFB128");
        pa80a706fVar.addAlgorithm("Cipher", p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.f1d9e7044, str + "$OFB256");
        pa80a706fVar.addAlgorithm("Cipher", p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.f79d8df3c, str + "$OFB512");
        pa80a706fVar.addAlgorithm("Cipher", p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.f50f83c36, str + "$CFB128");
        pa80a706fVar.addAlgorithm("Cipher", p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.ff962c2f2, str + "$CFB256");
        pa80a706fVar.addAlgorithm("Cipher", p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.f88aad734, str + "$CFB512");
        pa80a706fVar.addAlgorithm("Cipher", p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.f901503a4, str + "$CTR128");
        pa80a706fVar.addAlgorithm("Cipher", p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.fa4744f7c, str + "$CTR256");
        pa80a706fVar.addAlgorithm("Cipher", p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.fb1cf9d99, str + "$CTR512");
        pa80a706fVar.addAlgorithm("Cipher", p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.f20503ced, str + "$CCM128");
        pa80a706fVar.addAlgorithm("Cipher", p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.f6806966f, str + "$CCM256");
        pa80a706fVar.addAlgorithm("Cipher", p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.f19d18ca0, str + "$CCM512");
        pa80a706fVar.addAlgorithm("Cipher.DSTU7624KW", str + "$Wrap");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher.DSTU7624WRAP", "DSTU7624KW");
        pa80a706fVar.addAlgorithm("Cipher.DSTU7624-128KW", str + "$Wrap128");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher." + p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.f435645d0.getId(), "DSTU7624-128KW");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher.DSTU7624-128WRAP", "DSTU7624-128KW");
        pa80a706fVar.addAlgorithm("Cipher.DSTU7624-256KW", str + "$Wrap256");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher." + p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.f65ae0c88.getId(), "DSTU7624-256KW");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher.DSTU7624-256WRAP", "DSTU7624-256KW");
        pa80a706fVar.addAlgorithm("Cipher.DSTU7624-512KW", str + "$Wrap512");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher." + p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.f03050f04.getId(), "DSTU7624-512KW");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher.DSTU7624-512WRAP", "DSTU7624-512KW");
        pa80a706fVar.addAlgorithm("Mac.DSTU7624GMAC", str + "$GMAC");
        pa80a706fVar.addAlgorithm("Mac.DSTU7624-128GMAC", str + "$GMAC128");
        pa80a706fVar.addAlgorithm("Alg.Alias.Mac." + p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.f5a481f96.getId(), "DSTU7624-128GMAC");
        pa80a706fVar.addAlgorithm("Mac.DSTU7624-256GMAC", str + "$GMAC256");
        pa80a706fVar.addAlgorithm("Alg.Alias.Mac." + p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.fc231b1a0.getId(), "DSTU7624-256GMAC");
        pa80a706fVar.addAlgorithm("Mac.DSTU7624-512GMAC", str + "$GMAC512");
        pa80a706fVar.addAlgorithm("Alg.Alias.Mac." + p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.f5618a25d.getId(), "DSTU7624-512GMAC");
        pa80a706fVar.addAlgorithm("KeyGenerator.DSTU7624", str + "$KeyGen");
        pa80a706fVar.addAlgorithm("KeyGenerator", p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.f435645d0, str + "$KeyGen128");
        pa80a706fVar.addAlgorithm("KeyGenerator", p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.f65ae0c88, str + "$KeyGen256");
        pa80a706fVar.addAlgorithm("KeyGenerator", p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.f03050f04, str + "$KeyGen512");
        pa80a706fVar.addAlgorithm("KeyGenerator", p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.fb4f6907b, str + "$KeyGen128");
        pa80a706fVar.addAlgorithm("KeyGenerator", p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.f74b70904, str + "$KeyGen256");
        pa80a706fVar.addAlgorithm("KeyGenerator", p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.f152c68f0, str + "$KeyGen512");
        pa80a706fVar.addAlgorithm("KeyGenerator", p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.f6aa11d6d, str + "$KeyGen128");
        pa80a706fVar.addAlgorithm("KeyGenerator", p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.f55ae875e, str + "$KeyGen256");
        pa80a706fVar.addAlgorithm("KeyGenerator", p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.f0c28c26e, str + "$KeyGen512");
        pa80a706fVar.addAlgorithm("KeyGenerator", p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.fd2bee720, str + "$KeyGen128");
        pa80a706fVar.addAlgorithm("KeyGenerator", p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.f1d9e7044, str + "$KeyGen256");
        pa80a706fVar.addAlgorithm("KeyGenerator", p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.f79d8df3c, str + "$KeyGen512");
        pa80a706fVar.addAlgorithm("KeyGenerator", p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.f50f83c36, str + "$KeyGen128");
        pa80a706fVar.addAlgorithm("KeyGenerator", p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.ff962c2f2, str + "$KeyGen256");
        pa80a706fVar.addAlgorithm("KeyGenerator", p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.f88aad734, str + "$KeyGen512");
        pa80a706fVar.addAlgorithm("KeyGenerator", p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.f901503a4, str + "$KeyGen128");
        pa80a706fVar.addAlgorithm("KeyGenerator", p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.fa4744f7c, str + "$KeyGen256");
        pa80a706fVar.addAlgorithm("KeyGenerator", p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.fb1cf9d99, str + "$KeyGen512");
        pa80a706fVar.addAlgorithm("KeyGenerator", p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.f20503ced, str + "$KeyGen128");
        pa80a706fVar.addAlgorithm("KeyGenerator", p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.f6806966f, str + "$KeyGen256");
        pa80a706fVar.addAlgorithm("KeyGenerator", p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.f19d18ca0, str + "$KeyGen512");
        pa80a706fVar.addAlgorithm("KeyGenerator", p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.f5a481f96, str + "$KeyGen128");
        pa80a706fVar.addAlgorithm("KeyGenerator", p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.fc231b1a0, str + "$KeyGen256");
        pa80a706fVar.addAlgorithm("KeyGenerator", p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.f5618a25d, str + "$KeyGen512");
    }
}

