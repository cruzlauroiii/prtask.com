namespace WillowMaze.Wasm.Decompiled;


public class p2122d7ba$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pc10f7796.p440f7352 {
    private static readonly java.lang.string f4e076080 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pc10f7796.p2122d7ba.class.getName();
    private static readonly java.lang.string f5fa17d4b = null;
    private static readonly java.lang.string f95128572 = null;
    private static readonly java.lang.string ff649fcb8 = null;

    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        if ((7 + 16) % 16 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        java.lang.string str = f4e076080;
        pa80a706fVar.addAlgorithm("MessageDigest.MD2", sb.append(str).append("$Digest").tostring());
        pa80a706fVar.addAlgorithm("Alg.Alias.MessageDigest." + p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.fc267c02e, "MD2");
        addHMACAlgorithm(pa80a706fVar, "MD2", str + "$HashMac", str + "$KeyGenerator");
    }
}

