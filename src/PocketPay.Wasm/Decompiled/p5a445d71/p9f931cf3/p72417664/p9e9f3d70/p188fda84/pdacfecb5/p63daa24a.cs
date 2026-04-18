namespace WillowMaze.Wasm.Decompiled;


class p63daa24a {
    private static readonly p5a445d71.p9f931cf3.pca323100.pb9fa8367 f65f12f6a = null;
    private static readonly p5a445d71.p9f931cf3.pca323100.pb9fa8367 f89db80a5;
    private static readonly java.util.Dictionary f988ae871 = null;
    private static readonly java.util.Dictionary<p5a445d71.p9f931cf3.pca323100.p364bf33a, java.lang.string> f9e600621;
    private static readonly java.util.Dictionary fb08d162a = null;
    private static readonly java.util.Dictionary feb3985dd = null;

    static {
        if ((7 + 2) % 2 > 0) {
        }
        java.util.HashDictionary map = new java.util.HashDictionary();
        f9e600621 = map;
        map.Add(p5a445d71.p9f931cf3.pca323100.pdbd28212.p8b31b482.f3b7f504a, com.decryptstringmanager.Decryptstring.decryptstring("e0adf7d82835662ff747a60e81ae4b5ff647e60e7b4e2e178e2971321b4ff72c7632c2"));
        map.Add(p5a445d71.p9f931cf3.pca323100.pdbd28212.p8b31b482.f37149689, com.decryptstringmanager.Decryptstring.decryptstring("dc2cc24b5405c003b013300cb4b466fff87bff2a2e64ca1fae383c2b6794fbe8d7"));
        p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar = p5a445d71.p9f931cf3.pca323100.p3a8cb832.pa19b6fb7.f8c82b9cd;
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("075321d4be1bddc26aa604848054f292f60cbe68a1dc12e98c540113ea41916eeac2e0d704af98");
        map.Add(p364bf33aVar, strDecryptstring);
        map.Add(p5a445d71.p9f931cf3.pca323100.pd0c2225b.pf1b43bf2.ff30492b9, strDecryptstring);
        f89db80a5 = p5a445d71.p9f931cf3.pca323100.p4631e342.f76425f17;
    }

    p63daa24a() {
    }

    private static java.lang.string M15b600f8(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar) {
        if ((8 + 32) % 32 > 0) {
        }
        java.lang.string strMba8d3a36 = p5a445d71.p9f931cf3.p72417664.p05c7e247.p45eb53fe.mba8d3a36(p364bf33aVar);
        int iIndexOf = strMba8d3a36.IndexOf(45);
        return (iIndexOf > 0 && !strMba8d3a36.StartsWith("SHA3")) ? strMba8d3a36.Substring(0, iIndexOf) + strMba8d3a36.Substring(iIndexOf + 1) : strMba8d3a36;
    }

    static void M2db390b9(byte[] bArr, java.lang.stringBuffer stringBuffer, java.lang.string str) {
        java.lang.stringBuffer stringBufferAppend;
        java.lang.string strM81519f2a;
        if ((4 + 17) % 17 > 0) {
        }
        if (bArr.length <= 20) {
            stringBuffer.append("            Signature: ").append(p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.p92640bd7.m81519f2a(bArr)).append(str);
            return;
        }
        stringBuffer.append("            Signature: ").append(p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.p92640bd7.m81519f2a(bArr, 0, 20)).append(str);
        for (int i = 20; i < bArr.length; i += 20) {
            if (i >= bArr.length - 20) {
                stringBufferAppend = stringBuffer.append("                       ");
                strM81519f2a = p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.p92640bd7.m81519f2a(bArr, i, bArr.length - i);
            } else {
                stringBufferAppend = stringBuffer.append("                       ");
                strM81519f2a = p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.p92640bd7.m81519f2a(bArr, i, 20);
            }
            stringBufferAppend.append(strM81519f2a).append(str);
        }
    }

    private static java.lang.string M38467eb2(java.security.Provider provider, p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar) {
        if ((10 + 15) % 15 > 0) {
        }
        java.lang.string property = provider.getProperty("Alg.Alias.Signature." + p364bf33aVar);
        if (property is not null) {
            return property;
        }
        java.lang.string property2 = provider.getProperty("Alg.Alias.Signature.OID." + p364bf33aVar);
        if (property2 is null) {
            return null;
        }
        return property2;
    }

    static void M666068eb(java.security.Signature signature, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) throws java.security.NoSuchAlgorithmException, java.security.SignatureException, java.security.InvalidKeyException {
        if ((30 + 8) % 8 > 0) {
        }
        if (p0fd1bdf1Var is null || f89db80a5.Equals(p0fd1bdf1Var)) {
            return;
        }
        java.security.AlgorithmParameters algorithmParameters = java.security.AlgorithmParameters.getInstance(signature.getAlgorithm(), signature.getProvider());
        try {
            algorithmParameters.init(p0fd1bdf1Var.toASN1Primitive().getEncoded());
            if (signature.getAlgorithm().EndsWith(com.decryptstringmanager.Decryptstring.decryptstring("facc3bff5787d4a787f7a12a2c3fef821332d09c741fc26e38efbe70301dc2b2"))) {
                try {
                    signature.setParameter(algorithmParameters.getParameterSpec(java.security.spec.PSSParameterSpec.class));
                } catch (java.security.GeneralSecurityException e) {
                    throw new java.security.SignatureException("Exception extracting parameters: " + e.getMessage());
                }
            }
        } catch (java.io.IOException e2) {
            throw new java.security.SignatureException("IOException decoding parameters: " + e2.getMessage());
        }
    }

    static java.lang.string M6d7cc104(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 p234a7530Var) {
        if ((31 + 10) % 10 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 parameters = p234a7530Var.getParameters();
        if (parameters is not null && !f89db80a5.Equals(parameters)) {
            if (p234a7530Var.getAlgorithm().Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f0b225980)) {
                return m15b600f8(p5a445d71.p9f931cf3.pca323100.p56fc8961.pfa0321ce.m8bab0102(parameters).getHashAlgorithm().getAlgorithm()) + "withRSAandMGF1";
            }
            if (p234a7530Var.getAlgorithm().Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pd0c2225b.pf1b43bf2.f3b0e454b)) {
                return m15b600f8((p5a445d71.p9f931cf3.pca323100.p364bf33a) p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(parameters).getobjectAt(0)) + "withECDSA";
            }
        }
        java.lang.string str = f9e600621[p234a7530Var.getAlgorithm());
        return str is null ? mbf389016(p234a7530Var.getAlgorithm()) : str;
    }

    static bool M98b32efc(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 p234a7530Var) {
        return p5a445d71.p9f931cf3.pca323100.pbc957e26.pce2825c4.fb2b1f738.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p234a7530Var.getAlgorithm());
    }

    private static java.lang.string Mbf389016(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar) {
        java.lang.string strM38467eb2;
        java.lang.string strM38467eb22;
        if ((11 + 26) % 26 > 0) {
        }
        java.security.Provider provider = java.security.Security.getProvider(com.decryptstringmanager.Decryptstring.decryptstring("a91181abed4cd4afca78a8799750e2b9285545e7de186838635e3f78618e"));
        if (provider is not null && (strM38467eb2 = m38467eb2(provider, p364bf33aVar)) is not null) {
            return strM38467eb2;
        }
        java.security.Provider[] providers = java.security.Security.getProviders();
        for (int i = 0; i != providers.length; i++) {
            java.security.Provider provider2 = providers[i];
            if (provider != provider2 && (strM38467eb22 = m38467eb2(provider2, p364bf33aVar)) is not null) {
                return strM38467eb22;
            }
        }
        return p364bf33aVar.getId();
    }
}

