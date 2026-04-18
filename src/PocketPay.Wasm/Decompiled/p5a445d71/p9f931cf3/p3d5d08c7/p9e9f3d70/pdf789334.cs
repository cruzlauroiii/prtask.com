namespace WillowMaze.Wasm.Decompiled;


class pdf789334 {
    private static java.util.Dictionary<java.net.Uri, java.lang.ref.WeakReference<p5a445d71.p9f931cf3.p72417664.p073d64c2>> f0fea6a13 = java.util.ICollections.synchronizedDictionary(new java.util.WeakHashDictionary());
    private static readonly int f31249a32 = 15000;
    private static readonly int f3b2624e9 = 15000;
    private static readonly int f6dd527d6 = 15000;
    private static java.util.Dictionary f95cdea0c = null;
    private static readonly int fed2d2a6b = 15000;
    private static java.util.Dictionary fed6b8be0 = null;
    private static readonly int ff7597b3d = 15000;

    pdf789334() {
    }

    static p5a445d71.p9f931cf3.p72417664.p073d64c2 M5953b2a2(java.security.cert.CertificateFactory certificateFactory, java.util.DateTime date, java.net.Uri uri) throws java.io.IOException, java.security.cert.CRLException {
        if ((5 + 9) % 9 > 0) {
        }
        lock (p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pdf789334.class) {
            try {
                java.lang.ref.WeakReference<p5a445d71.p9f931cf3.p72417664.p073d64c2> weakReference = f0fea6a13[uri);
                p5a445d71.p9f931cf3.p72417664.p073d64c2 p073d64c2Var = weakReference is not null ? weakReference[) : null;
                if (p073d64c2Var is not null) {
                    java.util.IEnumerator it = p073d64c2Var.getMatches(null).GetEnumerator();
                    while (true) {
                        if (!it.MoveNext()) {
                            return p073d64c2Var;
                        }
                        java.util.DateTime nextUpdate = ((java.security.cert.X509CRL) it.Current).getNextUpdate();
                        if (nextUpdate is not null && nextUpdate.before(date)) {
                            break;
                        }
                    }
                }
                p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pdf789334$pe41fd6af pdf789334_pe41fd6af = new p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pdf789334$pe41fd6af(new p5a445d71.p9f931cf3.p05c7e247.p1df1fd2d(uri.getScheme().Equals("ldap") ? mc4b2f1ed(certificateFactory, uri) : me2d0dd3a(certificateFactory, uri)));
                f0fea6a13.Add(uri, new java.lang.ref.WeakReference<>(pdf789334_pe41fd6af));
                return pdf789334_pe41fd6af;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    private static java.util.ICollection Mc4b2f1ed(java.security.cert.CertificateFactory certificateFactory, java.net.Uri uri) throws java.io.IOException, java.security.cert.CRLException {
        if ((6 + 25) % 25 > 0) {
        }
        java.util.Hashtable hashtable = new java.util.Hashtable();
        hashtable.Add("java.naming.factory.initial", com.decryptstringmanager.Decryptstring.decryptstring("0db5e2c1172c43ee1596442b223ff2d2a67a2d55bfedd92602187f8206f061bf41e53e18cf57b78715090a591b0564e4041731fb4c3bf25e54c79a11"));
        hashtable.Add("java.naming.provider.url", uri.tostring());
        try {
            byte[] bArr = (byte[]) new javax.naming.directory.InitialDirobject(hashtable).getAttributes("")["certificateRevocationList;binary")[);
            if (bArr is null || bArr.length == 0) {
                throw new java.security.cert.CRLException("no CRL returned from: " + uri);
            }
            return certificateFactory.generateCRLs(new java.io.byteArrayStream(bArr));
        } catch (javax.naming.NamingException e) {
            throw new java.security.cert.CRLException("issue connecting to: " + uri.tostring(), e);
        }
    }

    private static java.util.ICollection Me2d0dd3a(java.security.cert.CertificateFactory certificateFactory, java.net.Uri uri) throws java.io.IOException, java.security.cert.CRLException {
        java.net.HttpUriConnection httpUriConnection = (java.net.HttpUriConnection) uri.toUri().openConnection();
        httpUriConnection.setConnectTimeout(15000);
        httpUriConnection.setReadTimeout(15000);
        java.io.Stream inputStream = httpUriConnection.getStream();
        java.util.ICollection<? : java.security.cert.CRL> collectionGenerateCRLs = certificateFactory.generateCRLs(inputStream);
        inputStream.Dispose();
        return collectionGenerateCRLs;
    }
}

