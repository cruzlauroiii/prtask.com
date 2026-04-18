namespace WillowMaze.Wasm.Decompiled;


public class p0ffc8700$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pc10f7796.p440f7352 {
    private static readonly java.lang.string f38ac095d = null;
    private static readonly java.lang.string f4e076080 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pc10f7796.p0ffc8700.class.getName();
    private static readonly java.lang.string fe49afcc7 = null;

    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        if ((9 + 27) % 27 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        java.lang.string str = f4e076080;
        pa80a706fVar.addAlgorithm("MessageDigest.SHA-224", sb.append(str).append("$Digest").tostring());
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("f79c713ee207c917c4ef39b37cdfd11d2aca1ae258e882d82f38326d05f85acd90236e");
        pa80a706fVar.addAlgorithm("Alg.Alias.MessageDigest.SHA224", strDecryptstring);
        pa80a706fVar.addAlgorithm("Alg.Alias.MessageDigest." + p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f144d5874, strDecryptstring);
        pa80a706fVar.addAlgorithm("Mac.PBEWITHHMACSHA224", str + "$HashMac");
        addHMACAlgorithm(pa80a706fVar, "SHA224", str + "$HashMac", str + "$KeyGenerator");
        addHMACAlias(pa80a706fVar, "SHA224", p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f8296c1ba);
    }
}

