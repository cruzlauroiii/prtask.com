namespace WillowMaze.Wasm.Decompiled;


public class p80ac4ad5$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.pf0f6addc {
    private static readonly java.lang.string f1fbe961a = null;
    private static readonly java.lang.string f4410b5d2 = null;
    private static readonly java.lang.string fd8509598 = null;
    private static readonly java.lang.string fe83af69d = com.decryptstringmanager.Decryptstring.decryptstring("f0fc3568dc6b6a5000cfde694cd61e438e7af26ea2f09412f0ed57f38037aac800f6ceef928f4badcec1c55315745db1c381bb4518a342c8cff443ea3ec08aca5db57100b960");
    private static readonly java.lang.string f4e076080 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p80ac4ad5.class.getName();

    private void Ma4b1b5d0(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar, p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar, java.lang.string str) {
        pa80a706fVar.addAlgorithm("Alg.Alias.KeyGenerator." + p364bf33aVar.getId(), str);
        pa80a706fVar.addAlgorithm("Alg.Alias.KeyFactory." + p364bf33aVar.getId(), str);
    }

    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        if ((25 + 5) % 5 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        java.lang.string str = f4e076080;
        pa80a706fVar.addAlgorithm("Cipher.DES", sb.append(str).append("$ECB").tostring());
        pa80a706fVar.addAlgorithm("Cipher", p5a445d71.p9f931cf3.pca323100.p3a8cb832.pa19b6fb7.ff7b7074e, str + "$CBC");
        ma4b1b5d0(pa80a706fVar, p5a445d71.p9f931cf3.pca323100.p3a8cb832.pa19b6fb7.ff7b7074e, "DES");
        pa80a706fVar.addAlgorithm("Cipher.DESRFC3211WRAP", str + "$RFC3211");
        pa80a706fVar.addAlgorithm("KeyGenerator.DES", str + "$KeyGenerator");
        pa80a706fVar.addAlgorithm("SecretKeyFactory.DES", str + "$KeyFactory");
        pa80a706fVar.addAlgorithm("Mac.DESCMAC", str + "$CMAC");
        pa80a706fVar.addAlgorithm("Mac.DESMAC", str + "$CBCMAC");
        pa80a706fVar.addAlgorithm("Alg.Alias.Mac.DES", "DESMAC");
        pa80a706fVar.addAlgorithm("Mac.DESMAC/CFB8", str + "$DESCFB8");
        pa80a706fVar.addAlgorithm("Alg.Alias.Mac.DES/CFB8", "DESMAC/CFB8");
        pa80a706fVar.addAlgorithm("Mac.DESMAC64", str + "$DES64");
        pa80a706fVar.addAlgorithm("Alg.Alias.Mac.DES64", "DESMAC64");
        pa80a706fVar.addAlgorithm("Mac.DESMAC64WITHISO7816-4PADDING", str + "$DES64with7816d4");
        pa80a706fVar.addAlgorithm("Alg.Alias.Mac.DES64WITHISO7816-4PADDING", "DESMAC64WITHISO7816-4PADDING");
        pa80a706fVar.addAlgorithm("Alg.Alias.Mac.DESISO9797ALG1MACWITHISO7816-4PADDING", "DESMAC64WITHISO7816-4PADDING");
        pa80a706fVar.addAlgorithm("Alg.Alias.Mac.DESISO9797ALG1WITHISO7816-4PADDING", "DESMAC64WITHISO7816-4PADDING");
        pa80a706fVar.addAlgorithm("Mac.DESWITHISO9797", str + "$DES9797Alg3");
        pa80a706fVar.addAlgorithm("Alg.Alias.Mac.DESISO9797MAC", "DESWITHISO9797");
        pa80a706fVar.addAlgorithm("Mac.ISO9797ALG3MAC", str + "$DES9797Alg3");
        pa80a706fVar.addAlgorithm("Alg.Alias.Mac.ISO9797ALG3", "ISO9797ALG3MAC");
        pa80a706fVar.addAlgorithm("Mac.ISO9797ALG3WITHISO7816-4PADDING", str + "$DES9797Alg3with7816d4");
        pa80a706fVar.addAlgorithm("Alg.Alias.Mac.ISO9797ALG3MACWITHISO7816-4PADDING", "ISO9797ALG3WITHISO7816-4PADDING");
        pa80a706fVar.addAlgorithm("AlgorithmParameters.DES", "p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p3c20021f");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameters", p5a445d71.p9f931cf3.pca323100.p3a8cb832.pa19b6fb7.ff7b7074e, "DES");
        pa80a706fVar.addAlgorithm("AlgorithmParameterGenerator.DES", str + "$AlgParamGen");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameterGenerator." + p5a445d71.p9f931cf3.pca323100.p3a8cb832.pa19b6fb7.ff7b7074e, "DES");
        pa80a706fVar.addAlgorithm("Cipher.PBEWITHMD2ANDDES", str + "$PBEWithMD2");
        pa80a706fVar.addAlgorithm("Cipher.PBEWITHMD5ANDDES", str + "$PBEWithMD5");
        pa80a706fVar.addAlgorithm("Cipher.PBEWITHSHA1ANDDES", str + "$PBEWithSHA1");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher", p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.ffa67ee11, "PBEWITHMD2ANDDES");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher", p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f4ae0fad8, "PBEWITHMD5ANDDES");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher", p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f2bcba392, "PBEWITHSHA1ANDDES");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher.PBEWITHMD2ANDDES-CBC", "PBEWITHMD2ANDDES");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher.PBEWITHMD5ANDDES-CBC", "PBEWITHMD5ANDDES");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher.PBEWITHSHA1ANDDES-CBC", "PBEWITHSHA1ANDDES");
        pa80a706fVar.addAlgorithm("SecretKeyFactory.PBEWITHMD2ANDDES", str + "$PBEWithMD2KeyFactory");
        pa80a706fVar.addAlgorithm("SecretKeyFactory.PBEWITHMD5ANDDES", str + "$PBEWithMD5KeyFactory");
        pa80a706fVar.addAlgorithm("SecretKeyFactory.PBEWITHSHA1ANDDES", str + "$PBEWithSHA1KeyFactory");
        pa80a706fVar.addAlgorithm("Alg.Alias.SecretKeyFactory.PBEWITHMD2ANDDES-CBC", "PBEWITHMD2ANDDES");
        pa80a706fVar.addAlgorithm("Alg.Alias.SecretKeyFactory.PBEWITHMD5ANDDES-CBC", "PBEWITHMD5ANDDES");
        pa80a706fVar.addAlgorithm("Alg.Alias.SecretKeyFactory.PBEWITHSHA1ANDDES-CBC", "PBEWITHSHA1ANDDES");
        pa80a706fVar.addAlgorithm("Alg.Alias.SecretKeyFactory." + p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.ffa67ee11, "PBEWITHMD2ANDDES");
        pa80a706fVar.addAlgorithm("Alg.Alias.SecretKeyFactory." + p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f4ae0fad8, "PBEWITHMD5ANDDES");
        pa80a706fVar.addAlgorithm("Alg.Alias.SecretKeyFactory." + p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f2bcba392, "PBEWITHSHA1ANDDES");
    }
}

