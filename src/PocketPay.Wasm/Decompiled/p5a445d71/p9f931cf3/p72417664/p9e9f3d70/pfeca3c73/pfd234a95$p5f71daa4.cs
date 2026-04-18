namespace WillowMaze.Wasm.Decompiled;


public class pfd234a95$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.pf0f6addc {
    private static readonly java.lang.string f4e076080 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.pfd234a95.class.getName();
    private static readonly java.lang.string f62a9eeca = null;
    private static readonly java.lang.string f9210283c = null;
    private static readonly java.lang.string fc31170aa = null;
    private static readonly java.lang.string ff8f193cc = null;

    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        if ((10 + 3) % 3 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        java.lang.string str = f4e076080;
        pa80a706fVar.addAlgorithm("Cipher.ARC4", sb.append(str).append("$Base").tostring());
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher", p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f374315ed, "ARC4");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher.ARCFOUR", "ARC4");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher.RC4", "ARC4");
        pa80a706fVar.addAlgorithm("KeyGenerator.ARC4", str + "$KeyGen");
        pa80a706fVar.addAlgorithm("Alg.Alias.KeyGenerator.RC4", "ARC4");
        pa80a706fVar.addAlgorithm("Alg.Alias.KeyGenerator.1.2.840.113549.3.4", "ARC4");
        pa80a706fVar.addAlgorithm("SecretKeyFactory.PBEWITHSHAAND128BITRC4", str + "$PBEWithSHAAnd128BitKeyFactory");
        pa80a706fVar.addAlgorithm("SecretKeyFactory.PBEWITHSHAAND40BITRC4", str + "$PBEWithSHAAnd40BitKeyFactory");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameters." + p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f536c853a, "PKCS12PBE");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameters." + p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.fe6f69992, "PKCS12PBE");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameters.PBEWITHSHAAND40BITRC4", "PKCS12PBE");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameters.PBEWITHSHAAND128BITRC4", "PKCS12PBE");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameters.PBEWITHSHAANDRC4", "PKCS12PBE");
        pa80a706fVar.addAlgorithm("Cipher.PBEWITHSHAAND128BITRC4", str + "$PBEWithSHAAnd128Bit");
        pa80a706fVar.addAlgorithm("Cipher.PBEWITHSHAAND40BITRC4", str + "$PBEWithSHAAnd40Bit");
        pa80a706fVar.addAlgorithm("Alg.Alias.SecretKeyFactory", p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f536c853a, "PBEWITHSHAAND128BITRC4");
        pa80a706fVar.addAlgorithm("Alg.Alias.SecretKeyFactory", p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.fe6f69992, "PBEWITHSHAAND40BITRC4");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher.PBEWITHSHA1AND128BITRC4", "PBEWITHSHAAND128BITRC4");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher.PBEWITHSHA1AND40BITRC4", "PBEWITHSHAAND40BITRC4");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher", p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f536c853a, "PBEWITHSHAAND128BITRC4");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher", p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.fe6f69992, "PBEWITHSHAAND40BITRC4");
    }
}

