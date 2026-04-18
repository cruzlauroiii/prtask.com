namespace WillowMaze.Wasm.Decompiled;


public class p69febc5e$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pc10f7796.p440f7352 {
    private static readonly java.lang.string f4e076080 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pc10f7796.p69febc5e.class.getName();
    private static readonly java.lang.string f6059d5c0 = null;
    private static readonly java.lang.string fece53f88 = null;

    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        if ((24 + 15) % 15 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        java.lang.string str = f4e076080;
        pa80a706fVar.addAlgorithm("MessageDigest.BLAKE2S-256", sb.append(str).append("$Blake2s256").tostring());
        pa80a706fVar.addAlgorithm("Alg.Alias.MessageDigest." + p5a445d71.p9f931cf3.pca323100.pbc957e26.pce2825c4.f609c5ad3, "BLAKE2S-256");
        pa80a706fVar.addAlgorithm("MessageDigest.BLAKE2S-224", str + "$Blake2s224");
        pa80a706fVar.addAlgorithm("Alg.Alias.MessageDigest." + p5a445d71.p9f931cf3.pca323100.pbc957e26.pce2825c4.f22d7beb5, "BLAKE2S-224");
        pa80a706fVar.addAlgorithm("MessageDigest.BLAKE2S-160", str + "$Blake2s160");
        pa80a706fVar.addAlgorithm("Alg.Alias.MessageDigest." + p5a445d71.p9f931cf3.pca323100.pbc957e26.pce2825c4.f17ead573, "BLAKE2S-160");
        pa80a706fVar.addAlgorithm("MessageDigest.BLAKE2S-128", str + "$Blake2s128");
        pa80a706fVar.addAlgorithm("Alg.Alias.MessageDigest." + p5a445d71.p9f931cf3.pca323100.pbc957e26.pce2825c4.f928e1e45, "BLAKE2S-128");
    }
}

