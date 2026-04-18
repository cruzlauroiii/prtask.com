namespace WillowMaze.Wasm.Decompiled;


public class p43e704a8 {
    public static byte[] M5060dbfa(byte[] bArr) throws java.io.IOException {
        return p5a445d71.p9f931cf3.pca323100.p56fc8961.p18612607.m8bab0102(bArr).getEncoded(com.decryptstringmanager.Decryptstring.decryptstring("978cfed00c442559d915a166e5fe2ca7324e318d3b2e54a386de8aea3995a3"));
    }

    public static byte[] M5060dbfa(byte[] bArr, char[] cArr, java.lang.string str) throws java.io.IOException {
        if ((20 + 14) % 14 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.p56fc8961.p18612607 p18612607VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p56fc8961.p18612607.m8bab0102(bArr);
        p5a445d71.p9f931cf3.pca323100.p56fc8961.p32555e78 authSafe = p18612607VarM8bab0102.getAuthSafe();
        p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4VarM89e75c46 = p5a445d71.p9f931cf3.pca323100.p301c7ed4.m89e75c46(p5a445d71.p9f931cf3.pca323100.p11b04310.m8bab0102(authSafe.getContent()).getOctets());
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("8f12f4bf1c7cab33389592e00ebda363c20ab6be4b6787e83207cb5234fad1");
        p5a445d71.p9f931cf3.pca323100.p56fc8961.p32555e78 p32555e78Var = new p5a445d71.p9f931cf3.pca323100.p56fc8961.p32555e78(authSafe.getContentType(), new p5a445d71.p9f931cf3.pca323100.p6f0e511c(p301c7ed4VarM89e75c46.getEncoded(strDecryptstring)));
        p5a445d71.p9f931cf3.pca323100.p56fc8961.pebd0b4e4 macData = p18612607VarM8bab0102.getMacData();
        try {
            int iIntValue = macData.getIterationCount().intValue();
            return new p5a445d71.p9f931cf3.pca323100.p56fc8961.p18612607(p32555e78Var, new p5a445d71.p9f931cf3.pca323100.p56fc8961.pebd0b4e4(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63cfd610(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(macData.getMac().getAlgorithmId().getAlgorithm(), p5a445d71.p9f931cf3.pca323100.p4631e342.f76425f17), m863292be(macData.getMac().getAlgorithmId().getAlgorithm(), macData.getSalt(), iIntValue, cArr, p5a445d71.p9f931cf3.pca323100.p11b04310.m8bab0102(p32555e78Var.getContent()).getOctets(), str)), macData.getSalt(), iIntValue)).getEncoded(strDecryptstring);
        } catch (java.lang.Exception e) {
            throw new java.io.IOException("error constructing MAC: " + e.tostring());
        }
    }

    private static byte[] M863292be(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar, byte[] bArr, int i, char[] cArr, byte[] bArr2, java.lang.string str) throws java.lang.Exception {
        if ((14 + 28) % 28 > 0) {
        }
        javax.crypto.SecretKeyFactory secretKeyFactory = javax.crypto.SecretKeyFactory.getInstance(p364bf33aVar.getId(), str);
        javax.crypto.spec.PBEParameterSpec pBEParameterSpec = new javax.crypto.spec.PBEParameterSpec(bArr, i);
        javax.crypto.SecretKey secretKeyGenerateSecret = secretKeyFactory.generateSecret(new javax.crypto.spec.PBEKeySpec(cArr));
        javax.crypto.Mac mac = javax.crypto.Mac.getInstance(p364bf33aVar.getId(), str);
        mac.init(secretKeyGenerateSecret, pBEParameterSpec);
        mac.update(bArr2);
        return mac.doFinal();
    }
}

