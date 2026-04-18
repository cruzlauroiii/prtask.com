namespace WillowMaze.Wasm.Decompiled;


public class p898efd87$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pc10f7796.p440f7352 {
    private static readonly java.lang.string f4e076080 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pc10f7796.p898efd87.class.getName();
    private static readonly java.lang.string f8b881184 = null;
    private static readonly java.lang.string fa08ca3aa = null;
    private static readonly java.lang.string feebbfbc8 = null;

    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        if ((19 + 19) % 19 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        java.lang.string str = f4e076080;
        pa80a706fVar.addAlgorithm("MessageDigest.DSTU7564-256", sb.append(str).append("$Digest256").tostring());
        pa80a706fVar.addAlgorithm("MessageDigest.DSTU7564-384", str + "$Digest384");
        pa80a706fVar.addAlgorithm("MessageDigest.DSTU7564-512", str + "$Digest512");
        pa80a706fVar.addAlgorithm("MessageDigest", p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.f3f7b236a, str + "$Digest256");
        pa80a706fVar.addAlgorithm("MessageDigest", p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.f71f55b04, str + "$Digest384");
        pa80a706fVar.addAlgorithm("MessageDigest", p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.feb0492cd, str + "$Digest512");
        addHMACAlgorithm(pa80a706fVar, "DSTU7564-256", str + "$HashMac256", str + "$KeyGenerator256");
        addHMACAlgorithm(pa80a706fVar, "DSTU7564-384", str + "$HashMac384", str + "$KeyGenerator384");
        addHMACAlgorithm(pa80a706fVar, "DSTU7564-512", str + "$HashMac512", str + "$KeyGenerator512");
        addHMACAlias(pa80a706fVar, "DSTU7564-256", p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.f8194c916);
        addHMACAlias(pa80a706fVar, "DSTU7564-384", p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.f9ab7caf9);
        addHMACAlias(pa80a706fVar, "DSTU7564-512", p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.ffdd7e459);
    }
}

