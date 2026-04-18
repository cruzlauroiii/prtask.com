namespace WillowMaze.Wasm.Decompiled;


public class p43652959$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pc10f7796.p440f7352 {
    private static readonly java.lang.string f4e076080 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pc10f7796.p43652959.class.getName();
    private static readonly java.lang.string f57923c43 = null;
    private static readonly java.lang.string fc571fb9d = null;
    private static readonly java.lang.string fe1bb9260 = null;
    private static readonly java.lang.string ff2b13757 = null;

    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        if ((29 + 14) % 14 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        java.lang.string str = f4e076080;
        pa80a706fVar.addAlgorithm("MessageDigest.RIPEMD128", sb.append(str).append("$Digest").tostring());
        pa80a706fVar.addAlgorithm("Alg.Alias.MessageDigest." + p5a445d71.p9f931cf3.pca323100.p204b173b.pd07b2240.ff8ce6695, "RIPEMD128");
        addHMACAlgorithm(pa80a706fVar, "RIPEMD128", str + "$HashMac", str + "$KeyGenerator");
    }
}

