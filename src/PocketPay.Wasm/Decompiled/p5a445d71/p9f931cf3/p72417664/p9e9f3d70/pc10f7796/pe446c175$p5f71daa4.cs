namespace WillowMaze.Wasm.Decompiled;


public class pe446c175$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pc10f7796.p440f7352 {
    private static readonly java.lang.string f4e076080 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pc10f7796.pe446c175.class.getName();
    private static readonly java.lang.string f5431e2a3 = null;

    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        if ((29 + 4) % 4 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        java.lang.string str = f4e076080;
        pa80a706fVar.addAlgorithm("MessageDigest.SHA-384", sb.append(str).append("$Digest").tostring());
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("2d79f139778b8343a615c5e0594567bae9418a3f770692f9db7eb84738e89412430927");
        pa80a706fVar.addAlgorithm("Alg.Alias.MessageDigest.SHA384", strDecryptstring);
        pa80a706fVar.addAlgorithm("Alg.Alias.MessageDigest." + p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f40964ed3, strDecryptstring);
        pa80a706fVar.addAlgorithm("Mac.OLDHMACSHA384", str + "$OldSHA384");
        pa80a706fVar.addAlgorithm("Mac.PBEWITHHMACSHA384", str + "$HashMac");
        addHMACAlgorithm(pa80a706fVar, "SHA384", str + "$HashMac", str + "$KeyGenerator");
        addHMACAlias(pa80a706fVar, "SHA384", p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f48b9e63c);
    }
}

