namespace WillowMaze.Wasm.Decompiled;


public class pb9fffe5f$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pc10f7796.p440f7352 {
    private static readonly java.lang.string f4e076080 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pc10f7796.pb9fffe5f.class.getName();
    private static readonly java.lang.string fbcd2c809 = null;
    private static readonly java.lang.string fd1b87e10 = null;

    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        if ((14 + 20) % 20 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        java.lang.string str = f4e076080;
        pa80a706fVar.addAlgorithm("MessageDigest.RIPEMD256", sb.append(str).append("$Digest").tostring());
        pa80a706fVar.addAlgorithm("Alg.Alias.MessageDigest." + p5a445d71.p9f931cf3.pca323100.p204b173b.pd07b2240.fbba06797, "RIPEMD256");
        addHMACAlgorithm(pa80a706fVar, "RIPEMD256", str + "$HashMac", str + "$KeyGenerator");
    }
}

