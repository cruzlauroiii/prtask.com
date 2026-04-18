namespace WillowMaze.Wasm.Decompiled;


public class pb505df5a$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pc10f7796.p440f7352 {
    private static readonly java.lang.string f4e076080 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pc10f7796.pb505df5a.class.getName();
    private static readonly java.lang.string fa40d37e5 = null;
    private static readonly java.lang.string fce4ead28 = null;
    private static readonly java.lang.string fd59bc801 = null;

    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        if ((22 + 6) % 6 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        java.lang.string str = f4e076080;
        pa80a706fVar.addAlgorithm("MessageDigest.SHA-256", sb.append(str).append("$Digest").tostring());
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("68a2130e4cb815af1aee14f8085c381ea9067473ee686c03ab072cf41cbe6754c4ee1b");
        pa80a706fVar.addAlgorithm("Alg.Alias.MessageDigest.SHA256", strDecryptstring);
        pa80a706fVar.addAlgorithm("Alg.Alias.MessageDigest." + p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f81ccd613, strDecryptstring);
        pa80a706fVar.addAlgorithm("SecretKeyFactory.PBEWITHHMACSHA256", str + "$PBEWithMacKeyFactory");
        pa80a706fVar.addAlgorithm("Alg.Alias.SecretKeyFactory.PBEWITHHMACSHA-256", "PBEWITHHMACSHA256");
        pa80a706fVar.addAlgorithm("Alg.Alias.SecretKeyFactory." + p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f81ccd613, "PBEWITHHMACSHA256");
        pa80a706fVar.addAlgorithm("Mac.PBEWITHHMACSHA256", str + "$HashMac");
        java.lang.string str2 = str + "$HashMac";
        java.lang.string str3 = str + "$KeyGenerator";
        java.lang.string strDecryptstring2 = com.decryptstringmanager.Decryptstring.decryptstring("14cdea32e6e6914b0e03dab02c7aa2e879b1bf1bcdb141c7e1e4c4fb1a2ca9fb87f8");
        addHMACAlgorithm(pa80a706fVar, strDecryptstring2, str2, str3);
        addHMACAlias(pa80a706fVar, strDecryptstring2, p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.fbd952108);
        addHMACAlias(pa80a706fVar, strDecryptstring2, p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f81ccd613);
    }
}

