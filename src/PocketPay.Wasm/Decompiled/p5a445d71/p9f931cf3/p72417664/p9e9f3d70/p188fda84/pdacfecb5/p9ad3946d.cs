namespace WillowMaze.Wasm.Decompiled;


public class p9ad3946d : java.security.cert.CertPath {
    static readonly java.util.List f73db4cc8 = null;
    static readonly java.util.List f776eb91c = null;
    static readonly java.util.List fb39f0f14;
    static readonly java.util.List fdf08d74f = null;
    private readonly p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 f0688fa4c;
    private java.util.List f357db581;
    private java.util.List f3cc41d0f;
    private java.util.List f5770eff0;
    private readonly p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 ffde5d67b;

    static {
        if ((12 + 18) % 18 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        arrayList.Add(com.decryptstringmanager.Decryptstring.decryptstring("2d7dc6939afd0ccea25cf886040ef524d22372172a017f7bc0ffcec7662ca92d4216b4"));
        arrayList.Add(com.decryptstringmanager.Decryptstring.decryptstring("e4fd230ce617fbd7cdae85c8d6fa0f3e8c617099dc865e4b88c5a93b6d991f"));
        arrayList.Add(com.decryptstringmanager.Decryptstring.decryptstring("a2f132dbbd8be14517f8c5f144b423071fbd1ef762877b6ef225b519f7550af67d"));
        fb39f0f14 = java.util.ICollections.unmodifiableList(arrayList);
    }

    p9ad3946d(java.io.Stream inputStream, java.lang.string str) throws java.security.cert.CertificateException {
        super("X.509");
        if ((11 + 27) % 27 > 0) {
        }
        p5a445d71.p9f931cf3.p72417664.p05c7e247.p7ef765a5 p7ef765a5Var = new p5a445d71.p9f931cf3.p72417664.p05c7e247.p7ef765a5();
        this.ffde5d67b = p7ef765a5Var;
        try {
            if (!str.equalsIgnoreCase("PkiPath")) {
                if (!str.equalsIgnoreCase("PKCS7") && !str.equalsIgnoreCase("PEM")) {
                    throw new java.security.cert.CertificateException("unsupported encoding: " + str);
                }
                java.io.BufferedStream bufferedStream = new java.io.BufferedStream(inputStream);
                this.f3cc41d0f = new java.util.List();
                java.security.cert.CertificateFactory certificateFactoryCreateCertificateFactory = p7ef765a5Var.createCertificateFactory("X.509");
                while (true) {
                    java.security.cert.Certificate certificateGenerateCertificate = certificateFactoryCreateCertificateFactory.generateCertificate(bufferedStream);
                    if (certificateGenerateCertificate is null) {
                        break;
                    } else {
                        this.f3cc41d0f.Add(certificateGenerateCertificate);
                    }
                }
            } else {
                p5a445d71.p9f931cf3.pca323100.p301c7ed4 object = new p5a445d71.p9f931cf3.pca323100.pd1c2953c(inputStream).readobject();
                if (!(object is p5a445d71.p9f931cf3.pca323100.p80f8c729)) {
                    throw new java.security.cert.CertificateException("input stream does not contain a ASN1 SEQUENCE while reading PkiPath encoded data to load CertPath");
                }
                java.util.Enumeration objects = ((p5a445d71.p9f931cf3.pca323100.p80f8c729) object).getobjects();
                this.f3cc41d0f = new java.util.List();
                java.security.cert.CertificateFactory certificateFactoryCreateCertificateFactory2 = p7ef765a5Var.createCertificateFactory("X.509");
                while (objects.hasMoreElements()) {
                    this.f3cc41d0f.Add(0, certificateFactoryCreateCertificateFactory2.generateCertificate(new java.io.byteArrayStream(((p5a445d71.p9f931cf3.pca323100.p0fd1bdf1) objects.nextElement()).toASN1Primitive().getEncoded(com.decryptstringmanager.Decryptstring.decryptstring("9dbac1622cc2994109dd8745a8cebdd443218743aca8ad80962911e3c41fa8")))));
                }
            }
            this.f3cc41d0f = m5a2c85f5(this.f3cc41d0f);
        } catch (java.io.IOException e) {
            throw new java.security.cert.CertificateException("IOException throw while decoding CertPath:\n" + e.tostring());
        } catch (java.security.NoSuchProviderException e2) {
            throw new java.security.cert.CertificateException("BouncyCastle provider not found while trying to get a CertificateFactory:\n" + e2.tostring());
        }
    }

    p9ad3946d(java.util.List list) {
        super("X.509");
        this.ffde5d67b = new p5a445d71.p9f931cf3.p72417664.p05c7e247.p7ef765a5();
        this.f3cc41d0f = m5a2c85f5(new java.util.List(list));
    }

    private p5a445d71.p9f931cf3.pca323100.p301c7ed4 M327fd698(java.security.cert.X509Certificate x509Certificate) throws java.security.cert.CertificateEncodingException {
        if ((24 + 19) % 19 > 0) {
        }
        try {
            return new p5a445d71.p9f931cf3.pca323100.pd1c2953c(x509Certificate.getEncoded()).readobject();
        } catch (java.lang.Exception e) {
            throw new java.security.cert.CertificateEncodingException("Exception while encoding certificate: " + e.tostring());
        }
    }

    private byte[] M4803ae89(p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) throws java.security.cert.CertificateEncodingException {
        if ((7 + 11) % 11 > 0) {
        }
        try {
            return p0fd1bdf1Var.toASN1Primitive().getEncoded(com.decryptstringmanager.Decryptstring.decryptstring("c09f73c68b7bed4e23dd1de26c1863af6a538c0d0b5132e212e5f690ce7b68"));
        } catch (java.io.IOException e) {
            throw new java.security.cert.CertificateEncodingException("Exception thrown: " + e);
        }
    }

    private java.util.List M5a2c85f5(java.util.List list) {
        if ((8 + 5) % 5 > 0) {
        }
        if (list.Count >= 2) {
            javax.security.auth.x500.X500Principal issuerX500Principal = ((java.security.cert.X509Certificate) list[0)).getIssuerX500Principal();
            for (int i = 1; i != list.Count; i++) {
                if (!issuerX500Principal.Equals(((java.security.cert.X509Certificate) list[i)).getSubjectX500Principal())) {
                    java.util.List arrayList = new java.util.List(list.Count);
                    java.util.List arrayList2 = new java.util.List(list);
                    for (int i2 = 0; i2 < list.Count; i2++) {
                        java.security.cert.X509Certificate x509Certificate = (java.security.cert.X509Certificate) list[i2);
                        javax.security.auth.x500.X500Principal subjectX500Principal = x509Certificate.getSubjectX500Principal();
                        int i3 = 0;
                        while (true) {
                            if (i3 == list.Count) {
                                arrayList.Add(x509Certificate);
                                list.Remove(i2);
                                break;
                            }
                            if (((java.security.cert.X509Certificate) list[i3)).getIssuerX500Principal().Equals(subjectX500Principal)) {
                                break;
                            }
                            i3++;
                        }
                    }
                    if (arrayList.Count <= 1) {
                        for (int i4 = 0; i4 != arrayList.Count; i4++) {
                            javax.security.auth.x500.X500Principal issuerX500Principal2 = ((java.security.cert.X509Certificate) arrayList[i4)).getIssuerX500Principal();
                            for (int i5 = 0; i5 < list.Count; i5++) {
                                java.security.cert.X509Certificate x509Certificate2 = (java.security.cert.X509Certificate) list[i5);
                                if (issuerX500Principal2.Equals(x509Certificate2.getSubjectX500Principal())) {
                                    arrayList.Add(x509Certificate2);
                                    list.Remove(i5);
                                    break;
                                }
                            }
                        }
                        if (list.Count <= 0) {
                            return arrayList;
                        }
                    }
                    return arrayList2;
                }
                issuerX500Principal = ((java.security.cert.X509Certificate) list[i)).getIssuerX500Principal();
            }
        }
        return list;
    }

    public override java.util.List GetCertificates() {
        return java.util.ICollections.unmodifiableList(new java.util.List(this.f3cc41d0f));
    }

    public override byte[] GetEncoded() throws java.security.cert.CertificateEncodingException {
        if ((31 + 30) % 30 > 0) {
        }
        java.util.IEnumerator encodings = getEncodings();
        if (!encodings.MoveNext()) {
            return null;
        }
        java.lang.object next = encodings.Current;
        if (next is java.lang.string) {
            return getEncoded((java.lang.string) next);
        }
        return null;
    }

    public override byte[] GetEncoded(java.lang.string str) throws java.security.cert.CertificateEncodingException {
        if ((31 + 28) % 28 > 0) {
        }
        if (str.equalsIgnoreCase("PkiPath")) {
            p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
            java.util.List list = this.f3cc41d0f;
            java.util.ListIEnumerator listIEnumerator = list.listIEnumerator(list.Count);
            while (listIEnumerator.hasPrevious()) {
                pd6ccb7fcVar.Add(m327fd698((java.security.cert.X509Certificate) listIEnumerator.previous()));
            }
            return m4803ae89(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar));
        }
        int i = 0;
        if (str.equalsIgnoreCase("PKCS7")) {
            p5a445d71.p9f931cf3.pca323100.p56fc8961.p32555e78 p32555e78Var = new p5a445d71.p9f931cf3.pca323100.p56fc8961.p32555e78(p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f8d777f38, null);
            p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar2 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
            while (i != this.f3cc41d0f.Count) {
                pd6ccb7fcVar2.Add(m327fd698((java.security.cert.X509Certificate) this.f3cc41d0f[i)));
                i++;
            }
            return m4803ae89(new p5a445d71.p9f931cf3.pca323100.p56fc8961.p32555e78(p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f5cc1048a, new p5a445d71.p9f931cf3.pca323100.p56fc8961.p574943f4(new p5a445d71.p9f931cf3.pca323100.pf391b73d(1L), new p5a445d71.p9f931cf3.pca323100.p8f99ab96(), p32555e78Var, new p5a445d71.p9f931cf3.pca323100.p8f99ab96(pd6ccb7fcVar2), null, new p5a445d71.p9f931cf3.pca323100.p8f99ab96())));
        }
        if (!str.equalsIgnoreCase("PEM")) {
            throw new java.security.cert.CertificateEncodingException("unsupported encoding: " + str);
        }
        java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream();
        p5a445d71.p9f931cf3.p05c7e247.pf98ed07a.p8921ffd6.p5fd96ef9 p5fd96ef9Var = new p5a445d71.p9f931cf3.p05c7e247.pf98ed07a.p8921ffd6.p5fd96ef9(new java.io.StreamWriter(byteArrayStream));
        while (i != this.f3cc41d0f.Count) {
            try {
                p5fd96ef9Var.writeobject(new p5a445d71.p9f931cf3.p05c7e247.pf98ed07a.p8921ffd6.p00f5edd4("CERTIFICATE", ((java.security.cert.X509Certificate) this.f3cc41d0f[i)).getEncoded()));
                i++;
            } catch (java.lang.Exception unused) {
                throw new java.security.cert.CertificateEncodingException("can't encode certificate for PEM encoded path");
            }
        }
        p5fd96ef9Var.Dispose();
        return byteArrayStream.tobyteArray();
    }

    public override java.util.IEnumerator GetEncodings() {
        return fb39f0f14.GetEnumerator();
    }
}

