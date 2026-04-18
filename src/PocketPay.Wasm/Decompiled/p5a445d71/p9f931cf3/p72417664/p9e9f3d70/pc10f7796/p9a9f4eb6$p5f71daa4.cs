namespace WillowMaze.Wasm.Decompiled;


public class p9a9f4eb6$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pc10f7796.p440f7352 {
    private static readonly java.lang.string f1280c651 = null;
    private static readonly java.lang.string f1e68e4e6 = null;
    private static readonly java.lang.string f4e076080 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pc10f7796.p9a9f4eb6.class.getName();
    private static readonly java.lang.string fab5d5675 = null;
    private static readonly java.lang.string fb7cf4e56 = null;

    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        if ((26 + 30) % 30 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        java.lang.string str = f4e076080;
        pa80a706fVar.addAlgorithm("MessageDigest.SHA-1", sb.append(str).append("$Digest").tostring());
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("26571506697794214efdd22f0713ff4b65fadd42f1c40bf76330b1508b9682e2f9");
        pa80a706fVar.addAlgorithm("Alg.Alias.MessageDigest.SHA1", strDecryptstring);
        pa80a706fVar.addAlgorithm("Alg.Alias.MessageDigest.SHA", strDecryptstring);
        pa80a706fVar.addAlgorithm("Alg.Alias.MessageDigest." + p5a445d71.p9f931cf3.pca323100.p3a8cb832.pa19b6fb7.f0d5031d3, strDecryptstring);
        addHMACAlgorithm(pa80a706fVar, "SHA1", str + "$HashMac", str + "$KeyGenerator");
        addHMACAlias(pa80a706fVar, "SHA1", p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.fa247b21c);
        addHMACAlias(pa80a706fVar, "SHA1", p5a445d71.p9f931cf3.pca323100.pec5f5c0f.pd93c3cc1.f38453936);
        pa80a706fVar.addAlgorithm("Mac.PBEWITHHMACSHA", str + "$SHA1Mac");
        pa80a706fVar.addAlgorithm("Mac.PBEWITHHMACSHA1", str + "$SHA1Mac");
        pa80a706fVar.addAlgorithm("Alg.Alias.SecretKeyFactory.PBEWITHHMACSHA", "PBEWITHHMACSHA1");
        pa80a706fVar.addAlgorithm("Alg.Alias.SecretKeyFactory." + p5a445d71.p9f931cf3.pca323100.p3a8cb832.pa19b6fb7.f0d5031d3, "PBEWITHHMACSHA1");
        pa80a706fVar.addAlgorithm("Alg.Alias.Mac." + p5a445d71.p9f931cf3.pca323100.p3a8cb832.pa19b6fb7.f0d5031d3, "PBEWITHHMACSHA");
        pa80a706fVar.addAlgorithm("SecretKeyFactory.PBEWITHHMACSHA1", str + "$PBEWithMacKeyFactory");
    }
}

