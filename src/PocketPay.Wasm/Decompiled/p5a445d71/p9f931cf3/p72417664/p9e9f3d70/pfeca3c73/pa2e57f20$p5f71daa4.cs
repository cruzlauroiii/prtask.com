namespace WillowMaze.Wasm.Decompiled;


public class pa2e57f20$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.pf0f6addc {
    private static readonly java.lang.string f4e076080 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.pa2e57f20.class.getName();
    private static readonly java.lang.string ff46e3a60 = null;

    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        if ((30 + 14) % 14 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        java.lang.string str = f4e076080;
        pa80a706fVar.addAlgorithm("AlgorithmParameters.PBKDF2", sb.append(str).append("$AlgParams").tostring());
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameters." + p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f799c053a, "PBKDF2");
        pa80a706fVar.addAlgorithm("SecretKeyFactory.PBKDF2", str + "$PBKDF2withUTF8");
        pa80a706fVar.addAlgorithm("Alg.Alias.SecretKeyFactory.PBKDF2WITHHMACSHA1", "PBKDF2");
        pa80a706fVar.addAlgorithm("Alg.Alias.SecretKeyFactory.PBKDF2WITHHMACSHA1ANDUTF8", "PBKDF2");
        pa80a706fVar.addAlgorithm("Alg.Alias.SecretKeyFactory." + p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f799c053a, "PBKDF2");
        pa80a706fVar.addAlgorithm("SecretKeyFactory.PBKDF2WITHASCII", str + "$PBKDF2with8BIT");
        pa80a706fVar.addAlgorithm("Alg.Alias.SecretKeyFactory.PBKDF2WITH8BIT", "PBKDF2WITHASCII");
        pa80a706fVar.addAlgorithm("Alg.Alias.SecretKeyFactory.PBKDF2WITHHMACSHA1AND8BIT", "PBKDF2WITHASCII");
        pa80a706fVar.addAlgorithm("SecretKeyFactory.PBKDF2WITHHMACSHA224", str + "$PBKDF2withSHA224");
        pa80a706fVar.addAlgorithm("SecretKeyFactory.PBKDF2WITHHMACSHA256", str + "$PBKDF2withSHA256");
        pa80a706fVar.addAlgorithm("SecretKeyFactory.PBKDF2WITHHMACSHA384", str + "$PBKDF2withSHA384");
        pa80a706fVar.addAlgorithm("SecretKeyFactory.PBKDF2WITHHMACSHA512", str + "$PBKDF2withSHA512");
        pa80a706fVar.addAlgorithm("SecretKeyFactory.PBKDF2WITHHMACSHA3-224", str + "$PBKDF2withSHA3_224");
        pa80a706fVar.addAlgorithm("SecretKeyFactory.PBKDF2WITHHMACSHA3-256", str + "$PBKDF2withSHA3_256");
        pa80a706fVar.addAlgorithm("SecretKeyFactory.PBKDF2WITHHMACSHA3-384", str + "$PBKDF2withSHA3_384");
        pa80a706fVar.addAlgorithm("SecretKeyFactory.PBKDF2WITHHMACSHA3-512", str + "$PBKDF2withSHA3_512");
        pa80a706fVar.addAlgorithm("SecretKeyFactory.PBKDF2WITHHMACGOST3411", str + "$PBKDF2withGOST3411");
        pa80a706fVar.addAlgorithm("SecretKeyFactory.PBKDF2WITHHMACSM3", str + "$PBKDF2withSM3");
    }
}

