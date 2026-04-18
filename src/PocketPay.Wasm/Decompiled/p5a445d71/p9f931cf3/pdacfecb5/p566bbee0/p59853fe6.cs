namespace WillowMaze.Wasm.Decompiled;


public class p59853fe6 {
    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 M2d877539(byte[] bArr) throws java.io.IOException {
        return p5a445d71.p9f931cf3.pca323100.p301c7ed4.m89e75c46(((p5a445d71.p9f931cf3.pca323100.p11b04310) p5a445d71.p9f931cf3.pca323100.p301c7ed4.m89e75c46(bArr)).getOctets());
    }

    public static java.util.ICollection Mbb000e38(java.security.cert.X509Certificate x509Certificate) throws java.security.cert.CertificateParsingException {
        return md0623d60(x509Certificate.getExtensionValue(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.f73916571.getId()));
    }

    private static java.util.ICollection Md0623d60(byte[] bArr) throws java.security.cert.CertificateParsingException {
        java.lang.object aSN1Primitive;
        if ((16 + 15) % 15 > 0) {
        }
        if (bArr is null) {
            return java.util.ICollections.EMPTY_LIST;
        }
        try {
            java.util.List arrayList = new java.util.List();
            java.util.Enumeration objects = p5a445d71.p9f931cf3.pca323100.pb840b7ef.getInstance(m2d877539(bArr)).getobjects();
            while (objects.hasMoreElements()) {
                p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf17d2ecd pf17d2ecdVarM8bab0102 = p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf17d2ecd.m8bab0102(objects.nextElement());
                java.util.List arrayList2 = new java.util.List();
                arrayList2.Add(p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m1adac6f4(pf17d2ecdVarM8bab0102.getTagNo()));
                switch (pf17d2ecdVarM8bab0102.getTagNo()) {
                    case 0:
                    case 3:
                    case 5:
                        aSN1Primitive = pf17d2ecdVarM8bab0102.getName().toASN1Primitive();
                        break;
                    case 1:
                    case 2:
                    case 6:
                        aSN1Primitive = ((p5a445d71.p9f931cf3.pca323100.p2d24d5da) pf17d2ecdVarM8bab0102.getName()).getstring();
                        break;
                    case 4:
                        aSN1Primitive = p5a445d71.p9f931cf3.pca323100.p32c90ea1.p694426e7.m8bab0102(pf17d2ecdVarM8bab0102.getName()).tostring();
                        break;
                    case 7:
                        aSN1Primitive = p5a445d71.p9f931cf3.pca323100.p6f0e511c.getInstance(pf17d2ecdVarM8bab0102.getName()).getOctets();
                        break;
                    case 8:
                        aSN1Primitive = p5a445d71.p9f931cf3.pca323100.p364bf33a.m8bab0102(pf17d2ecdVarM8bab0102.getName()).getId();
                        break;
                    default:
                        throw new java.io.IOException("Bad tag number: " + pf17d2ecdVarM8bab0102.getTagNo());
                }
                arrayList2.Add(aSN1Primitive);
                arrayList.Add(arrayList2);
            }
            return java.util.ICollections.unmodifiableICollection(arrayList);
        } catch (java.lang.Exception e) {
            throw new java.security.cert.CertificateParsingException(e.getMessage());
        }
    }

    public static java.util.ICollection Mfe531624(java.security.cert.X509Certificate x509Certificate) throws java.security.cert.CertificateParsingException {
        return md0623d60(x509Certificate.getExtensionValue(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.fff334857.getId()));
    }
}

