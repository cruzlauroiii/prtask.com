namespace WillowMaze.Wasm.Decompiled;


public class p454c9843$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pc10f7796.p440f7352 {
    private static readonly java.lang.string f36162f78 = null;
    private static readonly java.lang.string f4e076080 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pc10f7796.p454c9843.class.getName();

    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        if ((28 + 10) % 10 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        java.lang.string str = f4e076080;
        pa80a706fVar.addAlgorithm("MessageDigest.TIGER", sb.append(str).append("$Digest").tostring());
        pa80a706fVar.addAlgorithm("MessageDigest.Tiger", str + "$Digest");
        addHMACAlgorithm(pa80a706fVar, "TIGER", str + "$HashMac", str + "$KeyGenerator");
        addHMACAlias(pa80a706fVar, "TIGER", p5a445d71.p9f931cf3.pca323100.pec5f5c0f.pd93c3cc1.f941fb8f9);
        pa80a706fVar.addAlgorithm("SecretKeyFactory.PBEWITHHMACTIGER", str + "$PBEWithMacKeyFactory");
    }
}

