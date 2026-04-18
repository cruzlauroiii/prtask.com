namespace WillowMaze.Wasm.Decompiled;


public class p59b6d1f8$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pc10f7796.p440f7352 {
    private static readonly java.lang.string f447e9a09 = null;
    private static readonly java.lang.string f4e076080 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pc10f7796.p59b6d1f8.class.getName();
    private static readonly java.lang.string f5699f839 = null;
    private static readonly java.lang.string f7669c618 = null;
    private static readonly java.lang.string fc02872e4 = null;

    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        if ((29 + 24) % 24 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        java.lang.string str = f4e076080;
        pa80a706fVar.addAlgorithm("MessageDigest.MD4", sb.append(str).append("$Digest").tostring());
        pa80a706fVar.addAlgorithm("Alg.Alias.MessageDigest." + p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.fc93d3bf7, "MD4");
        addHMACAlgorithm(pa80a706fVar, "MD4", str + "$HashMac", str + "$KeyGenerator");
    }
}

