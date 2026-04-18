namespace WillowMaze.Wasm.Decompiled;


public class pa45d8731$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.pf0f6addc {
    private static readonly java.lang.string f4e076080 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.pa45d8731.class.getName();
    private static readonly java.lang.string fbd7539a8 = null;
    private static readonly java.lang.string fbf311cc1 = null;
    private static readonly java.lang.string fcfab949a = null;

    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        if ((5 + 13) % 13 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        java.lang.string str = f4e076080;
        pa80a706fVar.addAlgorithm("AlgorithmParameterGenerator.RC2", sb.append(str).append("$AlgParamGen").tostring());
        pa80a706fVar.addAlgorithm("AlgorithmParameterGenerator.1.2.840.113549.3.2", str + "$AlgParamGen");
        pa80a706fVar.addAlgorithm("KeyGenerator.RC2", str + "$KeyGenerator");
        pa80a706fVar.addAlgorithm("KeyGenerator.1.2.840.113549.3.2", str + "$KeyGenerator");
        pa80a706fVar.addAlgorithm("AlgorithmParameters.RC2", str + "$AlgParams");
        pa80a706fVar.addAlgorithm("AlgorithmParameters.1.2.840.113549.3.2", str + "$AlgParams");
        pa80a706fVar.addAlgorithm("Cipher.RC2", str + "$ECB");
        pa80a706fVar.addAlgorithm("Cipher.RC2WRAP", str + "$Wrap");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher", p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.fecae7e01, "RC2WRAP");
        pa80a706fVar.addAlgorithm("Cipher", p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f6b43771d, str + "$CBC");
        pa80a706fVar.addAlgorithm("Mac.RC2MAC", str + "$CBCMAC");
        pa80a706fVar.addAlgorithm("Alg.Alias.Mac.RC2", "RC2MAC");
        pa80a706fVar.addAlgorithm("Mac.RC2MAC/CFB8", str + "$CFB8MAC");
        pa80a706fVar.addAlgorithm("Alg.Alias.Mac.RC2/CFB8", "RC2MAC/CFB8");
        pa80a706fVar.addAlgorithm("Alg.Alias.SecretKeyFactory.PBEWITHMD2ANDRC2-CBC", "PBEWITHMD2ANDRC2");
        pa80a706fVar.addAlgorithm("Alg.Alias.SecretKeyFactory.PBEWITHMD5ANDRC2-CBC", "PBEWITHMD5ANDRC2");
        pa80a706fVar.addAlgorithm("Alg.Alias.SecretKeyFactory.PBEWITHSHA1ANDRC2-CBC", "PBEWITHSHA1ANDRC2");
        pa80a706fVar.addAlgorithm("Alg.Alias.SecretKeyFactory", p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f6e218f9f, "PBEWITHMD2ANDRC2");
        pa80a706fVar.addAlgorithm("Alg.Alias.SecretKeyFactory", p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f6f2acf77, "PBEWITHMD5ANDRC2");
        pa80a706fVar.addAlgorithm("Alg.Alias.SecretKeyFactory", p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f438db460, "PBEWITHSHA1ANDRC2");
        pa80a706fVar.addAlgorithm("Alg.Alias.SecretKeyFactory.1.2.840.113549.1.12.1.5", "PBEWITHSHAAND128BITRC2-CBC");
        pa80a706fVar.addAlgorithm("Alg.Alias.SecretKeyFactory.1.2.840.113549.1.12.1.6", "PBEWITHSHAAND40BITRC2-CBC");
        pa80a706fVar.addAlgorithm("SecretKeyFactory.PBEWITHMD2ANDRC2", str + "$PBEWithMD2KeyFactory");
        pa80a706fVar.addAlgorithm("SecretKeyFactory.PBEWITHMD5ANDRC2", str + "$PBEWithMD5KeyFactory");
        pa80a706fVar.addAlgorithm("SecretKeyFactory.PBEWITHSHA1ANDRC2", str + "$PBEWithSHA1KeyFactory");
        pa80a706fVar.addAlgorithm("SecretKeyFactory.PBEWITHSHAAND128BITRC2-CBC", str + "$PBEWithSHAAnd128BitKeyFactory");
        pa80a706fVar.addAlgorithm("SecretKeyFactory.PBEWITHSHAAND40BITRC2-CBC", str + "$PBEWithSHAAnd40BitKeyFactory");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher", p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f6e218f9f, "PBEWITHMD2ANDRC2");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher", p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f6f2acf77, "PBEWITHMD5ANDRC2");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher", p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f438db460, "PBEWITHSHA1ANDRC2");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameters.1.2.840.113549.1.12.1.5", "PKCS12PBE");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameters.1.2.840.113549.1.12.1.6", "PKCS12PBE");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameters.PBEWithSHAAnd3KeyTripleDES", "PKCS12PBE");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher", p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.ff98f3443, "PBEWITHSHAAND128BITRC2-CBC");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher", p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f946b7d9a, "PBEWITHSHAAND40BITRC2-CBC");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher.PBEWITHSHA1AND128BITRC2-CBC", "PBEWITHSHAAND128BITRC2-CBC");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher.PBEWITHSHA1AND40BITRC2-CBC", "PBEWITHSHAAND40BITRC2-CBC");
        pa80a706fVar.addAlgorithm("Cipher.PBEWITHSHA1ANDRC2", str + "$PBEWithSHA1AndRC2");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher.PBEWITHSHAANDRC2-CBC", "PBEWITHSHA1ANDRC2");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher.PBEWITHSHA1ANDRC2-CBC", "PBEWITHSHA1ANDRC2");
        pa80a706fVar.addAlgorithm("Cipher.PBEWITHSHAAND128BITRC2-CBC", str + "$PBEWithSHAAnd128BitRC2");
        pa80a706fVar.addAlgorithm("Cipher.PBEWITHSHAAND40BITRC2-CBC", str + "$PBEWithSHAAnd40BitRC2");
        pa80a706fVar.addAlgorithm("Cipher.PBEWITHMD5ANDRC2", str + "$PBEWithMD5AndRC2");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher.PBEWITHMD5ANDRC2-CBC", "PBEWITHMD5ANDRC2");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameters.PBEWITHSHA1ANDRC2", "PKCS12PBE");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameters.PBEWITHSHAANDRC2", "PKCS12PBE");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameters.PBEWITHSHA1ANDRC2-CBC", "PKCS12PBE");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameters.PBEWITHSHAAND40BITRC2-CBC", "PKCS12PBE");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameters.PBEWITHSHAAND128BITRC2-CBC", "PKCS12PBE");
    }
}

