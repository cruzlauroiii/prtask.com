namespace WillowMaze.Wasm.Decompiled;


public class pd90f74e6$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pc10f7796.p440f7352 {
    private static readonly java.lang.string f254e1a2e = null;
    private static readonly java.lang.string f4e076080 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pc10f7796.pd90f74e6.class.getName();
    private static readonly java.lang.string fbc256e9c = null;

    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        if ((11 + 20) % 20 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        java.lang.string str = f4e076080;
        pa80a706fVar.addAlgorithm("MessageDigest.SHA3-224", sb.append(str).append("$Digest224").tostring());
        pa80a706fVar.addAlgorithm("MessageDigest.SHA3-256", str + "$Digest256");
        pa80a706fVar.addAlgorithm("MessageDigest.SHA3-384", str + "$Digest384");
        pa80a706fVar.addAlgorithm("MessageDigest.SHA3-512", str + "$Digest512");
        pa80a706fVar.addAlgorithm("MessageDigest", p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.fdc8713b0, str + "$Digest224");
        pa80a706fVar.addAlgorithm("MessageDigest", p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.fd72a4f2d, str + "$Digest256");
        pa80a706fVar.addAlgorithm("MessageDigest", p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.fb2a4c58f, str + "$Digest384");
        pa80a706fVar.addAlgorithm("MessageDigest", p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f16c6e824, str + "$Digest512");
        pa80a706fVar.addAlgorithm("MessageDigest.SHAKE256-512", str + "$DigestShake256_512");
        pa80a706fVar.addAlgorithm("MessageDigest.SHAKE128-256", str + "$DigestShake128_256");
        pa80a706fVar.addAlgorithm("MessageDigest", p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f57bfa9af, str + "$DigestShake256_512");
        pa80a706fVar.addAlgorithm("MessageDigest", p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f79d40c1f, str + "$DigestShake128_256");
        pa80a706fVar.addAlgorithm("Alg.Alias.MessageDigest.SHAKE256", "SHAKE256-512");
        pa80a706fVar.addAlgorithm("Alg.Alias.MessageDigest.SHAKE128", "SHAKE128-256");
        addHMACAlgorithm(pa80a706fVar, "SHA3-224", str + "$HashMac224", str + "$KeyGenerator224");
        addHMACAlias(pa80a706fVar, "SHA3-224", p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.fc3ec529c);
        java.lang.string str2 = str + "$HashMac256";
        java.lang.string str3 = str + "$KeyGenerator256";
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("5443783482143b582879d28356414f44a545e0ebacabecc8af6f433e704a881829f714f4");
        addHMACAlgorithm(pa80a706fVar, strDecryptstring, str2, str3);
        addHMACAlias(pa80a706fVar, strDecryptstring, p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f3b10e22a);
        addHMACAlgorithm(pa80a706fVar, "SHA3-384", str + "$HashMac384", str + "$KeyGenerator384");
        addHMACAlias(pa80a706fVar, "SHA3-384", p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f34b2aacd);
        addHMACAlgorithm(pa80a706fVar, "SHA3-512", str + "$HashMac512", str + "$KeyGenerator512");
        addHMACAlias(pa80a706fVar, "SHA3-512", p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f1f23d4db);
    }
}

