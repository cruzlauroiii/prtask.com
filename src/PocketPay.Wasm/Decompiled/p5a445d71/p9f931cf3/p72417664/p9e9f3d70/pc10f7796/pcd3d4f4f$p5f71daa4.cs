namespace WillowMaze.Wasm.Decompiled;


public class pcd3d4f4f$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pc10f7796.p440f7352 {
    private static readonly java.lang.string f4e076080 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pc10f7796.pcd3d4f4f.class.getName();
    private static readonly java.lang.string fcbd51c03 = null;

    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        if ((14 + 3) % 3 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        java.lang.string str = f4e076080;
        pa80a706fVar.addAlgorithm("MessageDigest.SM3", sb.append(str).append("$Digest").tostring());
        pa80a706fVar.addAlgorithm("Alg.Alias.MessageDigest.SM3", "SM3");
        pa80a706fVar.addAlgorithm("Alg.Alias.MessageDigest.1.2.156.197.1.401", "SM3");
        pa80a706fVar.addAlgorithm("Alg.Alias.MessageDigest." + p5a445d71.p9f931cf3.pca323100.p92073d2f.p18022a8b.fb97f21d6, "SM3");
        addHMACAlgorithm(pa80a706fVar, "SM3", str + "$HashMac", str + "$KeyGenerator");
        addHMACAlias(pa80a706fVar, "SM3", p5a445d71.p9f931cf3.pca323100.p92073d2f.p18022a8b.f6845bf36);
    }
}

