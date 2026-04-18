namespace WillowMaze.Wasm.Decompiled;


public class p6273f27e$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.pf0f6addc {
    private static readonly java.lang.string f4cc82fed = null;
    private static readonly java.lang.string f4e076080 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p6273f27e.class.getName();
    private static readonly java.lang.string f8b8ae878 = null;

    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        if ((18 + 12) % 12 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        java.lang.string str = f4e076080;
        pa80a706fVar.addAlgorithm("Cipher.CHACHA", sb.append(str).append("$Base").tostring());
        pa80a706fVar.addAlgorithm("KeyGenerator.CHACHA", str + "$KeyGen");
        pa80a706fVar.addAlgorithm("Cipher.CHACHA7539", str + "$Base7539");
        pa80a706fVar.addAlgorithm("KeyGenerator.CHACHA7539", str + "$KeyGen7539");
        pa80a706fVar.addAlgorithm("AlgorithmParameters.CHACHA7539", str + "$AlgParams");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher.CHACHA20", "CHACHA7539");
        pa80a706fVar.addAlgorithm("Alg.Alias.KeyGenerator.CHACHA20", "CHACHA7539");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameters.CHACHA20", "CHACHA7539");
        pa80a706fVar.addAlgorithm("Alg.Alias.KeyGenerator.CHACHA20-POLY1305", "CHACHA7539");
        pa80a706fVar.addAlgorithm("Alg.Alias.KeyGenerator." + p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.fe5c6460c, "CHACHA7539");
        pa80a706fVar.addAlgorithm("Cipher.CHACHA20-POLY1305", str + "$BaseCC20P1305");
        pa80a706fVar.addAlgorithm("AlgorithmParameters.CHACHA20-POLY1305", str + "$AlgParamsCC1305");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher." + p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.fe5c6460c, "CHACHA20-POLY1305");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameters." + p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.fe5c6460c, "CHACHA20-POLY1305");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher.OID." + p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.fe5c6460c, "CHACHA20-POLY1305");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameters.OID." + p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.fe5c6460c, "CHACHA20-POLY1305");
    }
}

