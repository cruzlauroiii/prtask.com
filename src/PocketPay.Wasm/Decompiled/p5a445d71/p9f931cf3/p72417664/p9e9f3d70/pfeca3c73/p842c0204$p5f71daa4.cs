namespace WillowMaze.Wasm.Decompiled;


public class p842c0204$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.pf0f6addc {
    private static readonly java.lang.string f2fa0c213 = null;
    private static readonly java.lang.string f3a08408f = null;
    private static readonly java.lang.string f80e38242 = null;
    private static readonly java.lang.string f82b9ff1f = null;
    private static readonly java.lang.string fe83af69d = com.decryptstringmanager.Decryptstring.decryptstring("d15de5f924c555e28b955c1f3545fbc6028775e2b3ccc008ce86586b27ce4e4d4f2ec7b329a7336148410dad7588548ab1558393cda40bf78c3d6f4e69aa5eab2714adb5a4d8");
    private static readonly java.lang.string f4e076080 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p842c0204.class.getName();

    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        if ((14 + 21) % 21 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        java.lang.string str = f4e076080;
        pa80a706fVar.addAlgorithm("Cipher.DESEDE", sb.append(str).append("$ECB").tostring());
        pa80a706fVar.addAlgorithm("Cipher", p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.fb71f0566, str + "$CBC");
        pa80a706fVar.addAlgorithm("Cipher.DESEDEWRAP", str + "$Wrap");
        pa80a706fVar.addAlgorithm("Cipher", p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.fcd77b649, str + "$Wrap");
        pa80a706fVar.addAlgorithm("Cipher.DESEDERFC3211WRAP", str + "$RFC3211");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher.DESEDERFC3217WRAP", "DESEDEWRAP");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher.TDEA", "DESEDE");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher.TDEAWRAP", "DESEDEWRAP");
        pa80a706fVar.addAlgorithm("Alg.Alias.KeyGenerator.TDEA", "DESEDE");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameters.TDEA", "DESEDE");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameterGenerator.TDEA", "DESEDE");
        pa80a706fVar.addAlgorithm("Alg.Alias.SecretKeyFactory.TDEA", "DESEDE");
        if (pa80a706fVar.hasAlgorithm("MessageDigest", com.decryptstringmanager.Decryptstring.decryptstring("635e6fc29500b1a3a779084558ff309f77c04fc9f39510b0dc1c9764ca046afd34"))) {
            pa80a706fVar.addAlgorithm("Cipher.PBEWITHSHAAND3-KEYTRIPLEDES-CBC", str + "$PBEWithSHAAndDES3Key");
            pa80a706fVar.addAlgorithm("Cipher.PBEWITHSHAAND2-KEYTRIPLEDES-CBC", str + "$PBEWithSHAAndDES2Key");
            pa80a706fVar.addAlgorithm("Alg.Alias.Cipher", p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f5a0c0af8, "PBEWITHSHAAND3-KEYTRIPLEDES-CBC");
            pa80a706fVar.addAlgorithm("Alg.Alias.Cipher", p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f4a555016, "PBEWITHSHAAND2-KEYTRIPLEDES-CBC");
            pa80a706fVar.addAlgorithm("Alg.Alias.Cipher.PBEWITHSHA1ANDDESEDE", "PBEWITHSHAAND3-KEYTRIPLEDES-CBC");
            pa80a706fVar.addAlgorithm("Alg.Alias.Cipher.PBEWITHSHA1AND3-KEYTRIPLEDES-CBC", "PBEWITHSHAAND3-KEYTRIPLEDES-CBC");
            pa80a706fVar.addAlgorithm("Alg.Alias.Cipher.PBEWITHSHA1AND2-KEYTRIPLEDES-CBC", "PBEWITHSHAAND2-KEYTRIPLEDES-CBC");
            pa80a706fVar.addAlgorithm("Alg.Alias.Cipher.PBEWITHSHAAND3-KEYDESEDE-CBC", "PBEWITHSHAAND3-KEYTRIPLEDES-CBC");
            pa80a706fVar.addAlgorithm("Alg.Alias.Cipher.PBEWITHSHAAND2-KEYDESEDE-CBC", "PBEWITHSHAAND2-KEYTRIPLEDES-CBC");
            pa80a706fVar.addAlgorithm("Alg.Alias.Cipher.PBEWITHSHA1AND3-KEYDESEDE-CBC", "PBEWITHSHAAND3-KEYTRIPLEDES-CBC");
            pa80a706fVar.addAlgorithm("Alg.Alias.Cipher.PBEWITHSHA1AND2-KEYDESEDE-CBC", "PBEWITHSHAAND2-KEYTRIPLEDES-CBC");
            pa80a706fVar.addAlgorithm("Alg.Alias.Cipher.PBEWITHSHA1ANDDESEDE-CBC", "PBEWITHSHAAND3-KEYTRIPLEDES-CBC");
        }
        pa80a706fVar.addAlgorithm("KeyGenerator.DESEDE", str + "$KeyGenerator");
        pa80a706fVar.addAlgorithm("KeyGenerator." + p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.fb71f0566, str + "$KeyGenerator3");
        pa80a706fVar.addAlgorithm("KeyGenerator.DESEDEWRAP", str + "$KeyGenerator");
        pa80a706fVar.addAlgorithm("SecretKeyFactory.DESEDE", str + "$KeyFactory");
        pa80a706fVar.addAlgorithm("SecretKeyFactory", p5a445d71.p9f931cf3.pca323100.p3a8cb832.pa19b6fb7.f1d6c3e83, str + "$KeyFactory");
        pa80a706fVar.addAlgorithm("Mac.DESEDECMAC", str + "$CMAC");
        pa80a706fVar.addAlgorithm("Mac.DESEDEMAC", str + "$CBCMAC");
        pa80a706fVar.addAlgorithm("Alg.Alias.Mac.DESEDE", "DESEDEMAC");
        pa80a706fVar.addAlgorithm("Mac.DESEDEMAC/CFB8", str + "$DESedeCFB8");
        pa80a706fVar.addAlgorithm("Alg.Alias.Mac.DESEDE/CFB8", "DESEDEMAC/CFB8");
        pa80a706fVar.addAlgorithm("Mac.DESEDEMAC64", str + "$DESede64");
        pa80a706fVar.addAlgorithm("Alg.Alias.Mac.DESEDE64", "DESEDEMAC64");
        pa80a706fVar.addAlgorithm("Mac.DESEDEMAC64WITHISO7816-4PADDING", str + "$DESede64with7816d4");
        pa80a706fVar.addAlgorithm("Alg.Alias.Mac.DESEDE64WITHISO7816-4PADDING", "DESEDEMAC64WITHISO7816-4PADDING");
        pa80a706fVar.addAlgorithm("Alg.Alias.Mac.DESEDEISO9797ALG1MACWITHISO7816-4PADDING", "DESEDEMAC64WITHISO7816-4PADDING");
        pa80a706fVar.addAlgorithm("Alg.Alias.Mac.DESEDEISO9797ALG1WITHISO7816-4PADDING", "DESEDEMAC64WITHISO7816-4PADDING");
        pa80a706fVar.addAlgorithm("AlgorithmParameters.DESEDE", "p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p3c20021f");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameters." + p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.fb71f0566, "DESEDE");
        pa80a706fVar.addAlgorithm("AlgorithmParameterGenerator.DESEDE", str + "$AlgParamGen");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameterGenerator." + p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.fb71f0566, "DESEDE");
        pa80a706fVar.addAlgorithm("SecretKeyFactory.PBEWITHSHAAND3-KEYTRIPLEDES-CBC", str + "$PBEWithSHAAndDES3KeyFactory");
        pa80a706fVar.addAlgorithm("SecretKeyFactory.PBEWITHSHAAND2-KEYTRIPLEDES-CBC", str + "$PBEWithSHAAndDES2KeyFactory");
        pa80a706fVar.addAlgorithm("Alg.Alias.SecretKeyFactory.PBEWITHSHA1ANDDESEDE", "PBEWITHSHAAND3-KEYTRIPLEDES-CBC");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameters.PBEWITHSHAAND3-KEYTRIPLEDES", "PKCS12PBE");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameters.PBEWITHSHAAND2-KEYTRIPLEDES", "PKCS12PBE");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameters.PBEWITHSHAAND3-KEYTRIPLEDES-CBC", "PKCS12PBE");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameters.PBEWITHSHAAND2-KEYTRIPLEDES-CBC", "PKCS12PBE");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameters.PBEWITHSHAANDDES3KEY-CBC", "PKCS12PBE");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameters.PBEWITHSHAANDDES2KEY-CBC", "PKCS12PBE");
        pa80a706fVar.addAlgorithm("Alg.Alias.SecretKeyFactory.PBE", "PBEWITHSHAAND3-KEYTRIPLEDES-CBC");
        pa80a706fVar.addAlgorithm("Alg.Alias.SecretKeyFactory.1.2.840.113549.1.12.1.3", "PBEWITHSHAAND3-KEYTRIPLEDES-CBC");
        pa80a706fVar.addAlgorithm("Alg.Alias.SecretKeyFactory.1.2.840.113549.1.12.1.4", "PBEWITHSHAAND2-KEYTRIPLEDES-CBC");
        pa80a706fVar.addAlgorithm("Alg.Alias.SecretKeyFactory.PBEWithSHAAnd3KeyTripleDES", "PBEWITHSHAAND3-KEYTRIPLEDES-CBC");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameters.1.2.840.113549.1.12.1.3", "PKCS12PBE");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameters.1.2.840.113549.1.12.1.4", "PKCS12PBE");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher.PBEWithSHAAnd3KeyTripleDES", "PBEWITHSHAAND3-KEYTRIPLEDES-CBC");
    }
}

