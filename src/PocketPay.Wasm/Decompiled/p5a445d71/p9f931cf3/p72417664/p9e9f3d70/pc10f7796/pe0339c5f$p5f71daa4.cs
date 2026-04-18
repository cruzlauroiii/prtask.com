namespace WillowMaze.Wasm.Decompiled;


public class pe0339c5f$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pc10f7796.p440f7352 {
    private static readonly java.lang.string f2ea0da6f = null;
    private static readonly java.lang.string f4e076080 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pc10f7796.pe0339c5f.class.getName();

    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        if ((13 + 13) % 13 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        java.lang.string str = f4e076080;
        pa80a706fVar.addAlgorithm("MessageDigest.GOST3411", sb.append(str).append("$Digest").tostring());
        pa80a706fVar.addAlgorithm("Alg.Alias.MessageDigest.GOST", "GOST3411");
        pa80a706fVar.addAlgorithm("Alg.Alias.MessageDigest.GOST-3411", "GOST3411");
        pa80a706fVar.addAlgorithm("Alg.Alias.MessageDigest." + p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.f22a47664, "GOST3411");
        addHMACAlgorithm(pa80a706fVar, "GOST3411", str + "$HashMac", str + "$KeyGenerator");
        addHMACAlias(pa80a706fVar, "GOST3411", p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.f22a47664);
        pa80a706fVar.addAlgorithm("MessageDigest.GOST3411-2012-256", str + "$Digest2012_256");
        pa80a706fVar.addAlgorithm("Alg.Alias.MessageDigest.GOST-2012-256", "GOST3411-2012-256");
        pa80a706fVar.addAlgorithm("Alg.Alias.MessageDigest.GOST-3411-2012-256", "GOST3411-2012-256");
        pa80a706fVar.addAlgorithm("Alg.Alias.MessageDigest." + p5a445d71.p9f931cf3.pca323100.pa3a9d01b.pe227bd0e.f86d3c5ee, "GOST3411-2012-256");
        addHMACAlgorithm(pa80a706fVar, "GOST3411-2012-256", str + "$HashMac2012_256", str + "$KeyGenerator2012_256");
        addHMACAlias(pa80a706fVar, "GOST3411-2012-256", p5a445d71.p9f931cf3.pca323100.pa3a9d01b.pe227bd0e.f1057174d);
        pa80a706fVar.addAlgorithm("MessageDigest.GOST3411-2012-512", str + "$Digest2012_512");
        pa80a706fVar.addAlgorithm("Alg.Alias.MessageDigest.GOST-2012-512", "GOST3411-2012-512");
        pa80a706fVar.addAlgorithm("Alg.Alias.MessageDigest.GOST-3411-2012-512", "GOST3411-2012-512");
        pa80a706fVar.addAlgorithm("Alg.Alias.MessageDigest." + p5a445d71.p9f931cf3.pca323100.pa3a9d01b.pe227bd0e.f7fbdf1f9, "GOST3411-2012-512");
        addHMACAlgorithm(pa80a706fVar, "GOST3411-2012-512", str + "$HashMac2012_512", str + "$KeyGenerator2012_512");
        addHMACAlias(pa80a706fVar, "GOST3411-2012-512", p5a445d71.p9f931cf3.pca323100.pa3a9d01b.pe227bd0e.f9e8f2ee9);
        pa80a706fVar.addAlgorithm("SecretKeyFactory.PBEWITHHMACGOST3411", str + "$PBEWithMacKeyFactory");
        pa80a706fVar.addAlgorithm("Alg.Alias.SecretKeyFactory." + p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.f22a47664, "PBEWITHHMACGOST3411");
    }
}

