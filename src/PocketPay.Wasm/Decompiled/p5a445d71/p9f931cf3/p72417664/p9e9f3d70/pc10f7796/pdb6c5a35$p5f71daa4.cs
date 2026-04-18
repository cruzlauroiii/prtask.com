namespace WillowMaze.Wasm.Decompiled;


public class pdb6c5a35$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pc10f7796.p440f7352 {
    private static readonly java.lang.string f3fe64e32 = null;
    private static readonly java.lang.string f4e076080 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pc10f7796.pdb6c5a35.class.getName();

    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        if ((9 + 21) % 21 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        java.lang.string str = f4e076080;
        pa80a706fVar.addAlgorithm("MessageDigest.SHA-512", sb.append(str).append("$Digest").tostring());
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("f7a359557b78ac5c7f69149ac4110830fa5762d6c1c43bc66a41412406ab45f501ff2e");
        pa80a706fVar.addAlgorithm("Alg.Alias.MessageDigest.SHA512", strDecryptstring);
        pa80a706fVar.addAlgorithm("Alg.Alias.MessageDigest." + p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f17fdb97b, strDecryptstring);
        pa80a706fVar.addAlgorithm("MessageDigest.SHA-512/224", str + "$DigestT224");
        pa80a706fVar.addAlgorithm("Alg.Alias.MessageDigest.SHA512/224", "SHA-512/224");
        pa80a706fVar.addAlgorithm("Alg.Alias.MessageDigest.SHA512224", "SHA-512/224");
        pa80a706fVar.addAlgorithm("Alg.Alias.MessageDigest.SHA-512(224)", "SHA-512/224");
        pa80a706fVar.addAlgorithm("Alg.Alias.MessageDigest.SHA512(224)", "SHA-512/224");
        pa80a706fVar.addAlgorithm("Alg.Alias.MessageDigest." + p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.fb0c92956, "SHA-512/224");
        pa80a706fVar.addAlgorithm("MessageDigest.SHA-512/256", str + "$DigestT256");
        java.lang.string strDecryptstring2 = com.decryptstringmanager.Decryptstring.decryptstring("1fadd57e30b5b22c18dcd01e83ac86e755ad00d3fbc713818a1c2983552bc7d0087a039bbf1c90");
        pa80a706fVar.addAlgorithm("Alg.Alias.MessageDigest.SHA512/256", strDecryptstring2);
        pa80a706fVar.addAlgorithm("Alg.Alias.MessageDigest.SHA512256", strDecryptstring2);
        pa80a706fVar.addAlgorithm("Alg.Alias.MessageDigest.SHA-512(256)", strDecryptstring2);
        pa80a706fVar.addAlgorithm("Alg.Alias.MessageDigest.SHA512(256)", strDecryptstring2);
        pa80a706fVar.addAlgorithm("Alg.Alias.MessageDigest." + p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.fbbffb7b2, strDecryptstring2);
        pa80a706fVar.addAlgorithm("Mac.OLDHMACSHA512", str + "$OldSHA512");
        pa80a706fVar.addAlgorithm("Mac.PBEWITHHMACSHA512", str + "$HashMac");
        java.lang.string str2 = str + "$HashMac";
        java.lang.string str3 = str + "$KeyGenerator";
        java.lang.string strDecryptstring3 = com.decryptstringmanager.Decryptstring.decryptstring("af2dc02e35eb35ba8837015eb0002643e732d1feefa0886dce9e8e8fa6a12da3204c");
        addHMACAlgorithm(pa80a706fVar, strDecryptstring3, str2, str3);
        addHMACAlias(pa80a706fVar, strDecryptstring3, p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f151e9a83);
        addHMACAlgorithm(pa80a706fVar, "SHA512/224", str + "$HashMacT224", str + "$KeyGeneratorT224");
        addHMACAlgorithm(pa80a706fVar, "SHA512/256", str + "$HashMacT256", str + "$KeyGeneratorT256");
    }
}

