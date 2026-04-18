namespace WillowMaze.Wasm.Decompiled;


public class p13ffa8c9$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pc10f7796.p440f7352 {
    private static readonly java.lang.string f4e076080 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pc10f7796.p13ffa8c9.class.getName();
    private static readonly java.lang.string f74e3116d = null;

    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        if ((11 + 18) % 18 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        java.lang.string str = f4e076080;
        pa80a706fVar.addAlgorithm("MessageDigest.RIPEMD160", sb.append(str).append("$Digest").tostring());
        pa80a706fVar.addAlgorithm("Alg.Alias.MessageDigest." + p5a445d71.p9f931cf3.pca323100.p204b173b.pd07b2240.f742a86b1, "RIPEMD160");
        addHMACAlgorithm(pa80a706fVar, "RIPEMD160", str + "$HashMac", str + "$KeyGenerator");
        addHMACAlias(pa80a706fVar, "RIPEMD160", p5a445d71.p9f931cf3.pca323100.pec5f5c0f.pd93c3cc1.f7e07dbb5);
        pa80a706fVar.addAlgorithm("SecretKeyFactory.PBEWITHHMACRIPEMD160", str + "$PBEWithHmacKeyFactory");
        pa80a706fVar.addAlgorithm("Mac.PBEWITHHMACRIPEMD160", str + "$PBEWithHmac");
    }
}

