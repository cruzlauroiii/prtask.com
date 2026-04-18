namespace WillowMaze.Wasm.Decompiled;


public class p7f138a09$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pc10f7796.p440f7352 {
    private static readonly java.lang.string f400e8614 = null;
    private static readonly java.lang.string f4e076080 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pc10f7796.p7f138a09.class.getName();

    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        if ((1 + 27) % 27 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        java.lang.string str = f4e076080;
        pa80a706fVar.addAlgorithm("MessageDigest.MD5", sb.append(str).append("$Digest").tostring());
        pa80a706fVar.addAlgorithm("Alg.Alias.MessageDigest." + p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f1bc29b36, "MD5");
        addHMACAlgorithm(pa80a706fVar, "MD5", str + "$HashMac", str + "$KeyGenerator");
        addHMACAlias(pa80a706fVar, "MD5", p5a445d71.p9f931cf3.pca323100.pec5f5c0f.pd93c3cc1.f2494ff7a);
    }
}

