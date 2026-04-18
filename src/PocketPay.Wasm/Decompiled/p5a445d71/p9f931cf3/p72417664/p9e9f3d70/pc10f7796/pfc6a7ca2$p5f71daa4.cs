namespace WillowMaze.Wasm.Decompiled;


public class pfc6a7ca2$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pc10f7796.p440f7352 {
    private static readonly java.lang.string f4e076080 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pc10f7796.pfc6a7ca2.class.getName();
    private static readonly java.lang.string ff6b9ff21 = null;
    private static readonly java.lang.string ffc8fb760 = null;

    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        if ((25 + 21) % 21 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        java.lang.string str = f4e076080;
        pa80a706fVar.addAlgorithm("MessageDigest.WHIRLPOOL", sb.append(str).append("$Digest").tostring());
        pa80a706fVar.addAlgorithm("MessageDigest", p5a445d71.p9f931cf3.pca323100.pe906ec77.p6386ed45.fced93693, str + "$Digest");
        addHMACAlgorithm(pa80a706fVar, "WHIRLPOOL", str + "$HashMac", str + "$KeyGenerator");
    }
}

