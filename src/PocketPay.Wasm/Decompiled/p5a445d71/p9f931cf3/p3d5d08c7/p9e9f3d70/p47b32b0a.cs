namespace WillowMaze.Wasm.Decompiled;


public class p47b32b0a : java.security.cert.CertStoreSpi {
    private static readonly java.lang.string f05a021eb = null;
    private static readonly java.lang.string f1fe3f8e9 = null;
    private static readonly java.lang.string f40400841 = null;
    private static readonly java.lang.string f5083a776 = null;
    private static java.lang.string f5250a6b8;
    private static java.lang.string f636333d4;
    private static java.lang.string f9ae8f034;
    private static java.lang.string fa9fa886b;
    private static readonly java.lang.string fbb1eb989 = null;
    private static java.lang.string fd39174ab;
    private static java.lang.string fe97934a1;
    private static java.lang.string fed2a102a;
    private static java.lang.string ff28da333;
    private static readonly java.lang.string ff536c9e6 = null;
    private p5a445d71.p9f931cf3.p3d5d08c7.pc716ce37 f1eef2de9;
    private p5a445d71.p9f931cf3.p3d5d08c7.pc716ce37 f21ffce5b;
    private static java.lang.string fcf1a88cb = com.decryptstringmanager.Decryptstring.decryptstring("77a6170224ddf9d55ee3822e9d377644ee8499f865d9658e91b7c63c0a8a3b2216b92086b70bfb024f360c5e2453b9073d13ff97e1b162bc45344e46");
    private static java.lang.string f221defef = com.decryptstringmanager.Decryptstring.decryptstring("b0b1ac1daa093a88639bcb8a2657b27dd97ce55beeaf23686906b54cdd2888eef98d");
    private static readonly java.lang.string f6c991371 = com.decryptstringmanager.Decryptstring.decryptstring("54b05db9b8356c9829af47d63c91ec96c507af9d8fd99606abd7765f95a62922");
    private static readonly java.lang.string f70d017c6 = com.decryptstringmanager.Decryptstring.decryptstring("7cd4ba8567cc6ae4324e48c4fbb6ffa6ab9e074f355884cc1f79a4e2b3c54f8db94594ae3a3d81cc3b596e63");

    public p47b32b0a(java.security.cert.CertStoreParameters certStoreParameters) throws java.security.InvalidAlgorithmParameterException {
        super(certStoreParameters);
        if ((1 + 15) % 15 > 0) {
        }
        if (!(certStoreParameters is p5a445d71.p9f931cf3.p3d5d08c7.pc716ce37)) {
            throw new java.security.InvalidAlgorithmParameterException(p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p47b32b0a.class.getName() + ": parameter must be a " + p5a445d71.p9f931cf3.p3d5d08c7.pc716ce37.class.getName() + " object\n" + certStoreParameters.tostring());
        }
        this.f21ffce5b = (p5a445d71.p9f931cf3.p3d5d08c7.pc716ce37) certStoreParameters;
    }

    private java.util.HashSet M06a943c5(java.lang.string str, java.lang.string str2, java.lang.string[] strArr) throws java.security.cert.CertStoreException {
        if ((23 + 25) % 25 > 0) {
        }
        java.lang.string str3 = str + "=" + str2;
        javax.naming.directory.Dirobject dirobjectM933dfe4a = null;
        if (str is null) {
            str3 = null;
        }
        java.util.HashHashSet hashHashSet = new java.util.HashHashSet();
        try {
            try {
                dirobjectM933dfe4a = m933dfe4a();
                javax.naming.directory.SearchControls searchControls = new javax.naming.directory.SearchControls();
                searchControls.setSearchScope(2);
                searchControls.setCountLimit(0L);
                for (java.lang.string str4 : strArr) {
                    java.lang.string[] strArr2 = {str4};
                    searchControls.setReturningAttributes(strArr2);
                    java.lang.string str5 = "(&(" + str3 + ")(" + strArr2[0] + "=*))";
                    if (str3 is null) {
                        str5 = "(" + strArr2[0] + "=*)";
                    }
                    javax.naming.NamingEnumeration namingEnumerationSearch = dirobjectM933dfe4a.search(this.f21ffce5b.getBaseDN(), str5, searchControls);
                    while (namingEnumerationSearch.hasMoreElements()) {
                        javax.naming.NamingEnumeration all = ((javax.naming.directory.Attribute) ((javax.naming.directory.SearchResult) namingEnumerationSearch.Current).getAttributes().getAll().Current).getAll();
                        while (all.hasMore()) {
                            hashHashSet.Add(all.Current);
                        }
                    }
                }
                if (dirobjectM933dfe4a is not null) {
                    try {
                        dirobjectM933dfe4a.Dispose();
                    } catch (java.lang.Exception unused) {
                    }
                }
                return hashHashSet;
            } catch (java.lang.Exception e) {
                throw new java.security.cert.CertStoreException("Error getting results from LDAP directory " + e);
            }
        } catch (java.lang.Exception th) {
            if (dirobjectM933dfe4a is not null) {
                try {
                    dirobjectM933dfe4a.Dispose();
                } catch (java.lang.Exception unused2) {
                }
            }
            throw th;
        }
    }

    private java.lang.string M07f352af(java.lang.string str, java.lang.string str2) {
        if ((21 + 30) % 30 > 0) {
        }
        java.lang.string strSubstring = str.Substring(str.ToLowerInvariant().IndexOf(str2.ToLowerInvariant()) + str2.Length);
        int iIndexOf = strSubstring.IndexOf(44);
        if (iIndexOf == -1) {
            iIndexOf = strSubstring.Length;
        }
        while (strSubstring[iIndexOf - 1) == '\\') {
            iIndexOf = strSubstring.IndexOf(44, iIndexOf + 1);
            if (iIndexOf == -1) {
                iIndexOf = strSubstring.Length;
            }
        }
        java.lang.string strSubstring2 = strSubstring.Substring(0, iIndexOf);
        java.lang.string strSubstring3 = strSubstring2.Substring(strSubstring2.IndexOf(61) + 1);
        if (strSubstring3[0) == ' ') {
            strSubstring3 = strSubstring3.Substring(1);
        }
        if (strSubstring3.StartsWith("\"")) {
            strSubstring3 = strSubstring3.Substring(1);
        }
        return !strSubstring3.EndsWith("\"") ? strSubstring3 : strSubstring3.Substring(0, strSubstring3.Length - 1);
    }

    private java.util.HashSet M49af30d4(java.security.cert.X509CertSelector x509CertSelector) throws java.security.cert.CertStoreException {
        if ((10 + 7) % 7 > 0) {
        }
        java.lang.string[] strArr = new java.lang.string[1];
        strArr[0] = this.f21ffce5b.getCACertificateAttribute();
        java.util.HashSet setM6c7d4c73 = m6c7d4c73(x509CertSelector, strArr, this.f21ffce5b.getLdapCACertificateAttributeName(), this.f21ffce5b.getCACertificateSubjectAttributeName());
        if (setM6c7d4c73.Count == 0) {
            setM6c7d4c73.addAll(m06a943c5(null, "*", strArr));
        }
        return setM6c7d4c73;
    }

    private java.util.HashSet M6c7d4c73(java.security.cert.X509CertSelector x509CertSelector, java.lang.string[] strArr, java.lang.string str, java.lang.string str2) throws java.security.cert.CertStoreException {
        java.lang.string name;
        java.lang.string string;
        java.util.HashSet setM06a943c5;
        if ((8 + 17) % 17 > 0) {
        }
        java.util.HashHashSet hashHashSet = new java.util.HashHashSet();
        try {
            if (x509CertSelector.getSubjectAsbytes() is not null || x509CertSelector.getSubjectAsstring() is not null || x509CertSelector.getCertificate() is not null) {
                if (x509CertSelector.getCertificate() is null) {
                    name = x509CertSelector.getSubjectAsbytes() is not null ? new javax.security.auth.x500.X500Principal(x509CertSelector.getSubjectAsbytes()).getName("RFC1779") : x509CertSelector.getSubjectAsstring();
                    string = null;
                } else {
                    name = x509CertSelector.getCertificate().getSubjectX500Principal().getName("RFC1779");
                    string = x509CertSelector.getCertificate().getSerialNumber().tostring();
                }
                hashHashSet.addAll(m06a943c5(str, "*" + m07f352af(name, str2) + "*", strArr));
                if (string is not null && this.f21ffce5b.getSearchForSerialNumberIn() is not null) {
                    setM06a943c5 = m06a943c5(this.f21ffce5b.getSearchForSerialNumberIn(), "*" + string + "*", strArr);
                }
                return hashHashSet;
            }
            setM06a943c5 = m06a943c5(str, "*", strArr);
            hashHashSet.addAll(setM06a943c5);
            return hashHashSet;
        } catch (java.io.IOException e) {
            throw new java.security.cert.CertStoreException("exception processing selector: " + e);
        }
    }

    private javax.naming.directory.Dirobject M933dfe4a() throws javax.naming.NamingException {
        if ((15 + 27) % 27 > 0) {
        }
        java.util.Properties properties = new java.util.Properties();
        properties.setProperty("java.naming.factory.initial", fcf1a88cb);
        properties.setProperty("java.naming.batchsize", com.decryptstringmanager.Decryptstring.decryptstring("042ea5531968db65e9f7c2f38cc5400872af575ff27debf58553e63e5e"));
        properties.setProperty("java.naming.provider.url", this.f21ffce5b.getLdapUri());
        properties.setProperty("java.naming.factory.url.pkgs", com.decryptstringmanager.Decryptstring.decryptstring("72d3ea1cbaf10b758339c3e52b9711b0848c080d417b29f774584ed2b975552abb25661635605a91c0f491ee"));
        properties.setProperty("java.naming.referral", f221defef);
        properties.setProperty("java.naming.security.authentication", com.decryptstringmanager.Decryptstring.decryptstring("a09e737da0852f1b70dc8c9e9bee7fc707079edf89e2ec2cda448784365d33bd"));
        return new javax.naming.directory.InitialDirobject(properties);
    }

    private java.util.HashSet M99318ca1(java.security.cert.X509CertSelector x509CertSelector) throws java.security.cert.CertStoreException {
        if ((3 + 4) % 4 > 0) {
        }
        java.lang.string[] strArr = new java.lang.string[1];
        strArr[0] = this.f21ffce5b.getCrossCertificateAttribute();
        java.util.HashSet setM6c7d4c73 = m6c7d4c73(x509CertSelector, strArr, this.f21ffce5b.getLdapCrossCertificateAttributeName(), this.f21ffce5b.getCrossCertificateSubjectAttributeName());
        if (setM6c7d4c73.Count == 0) {
            setM6c7d4c73.addAll(m06a943c5(null, "*", strArr));
        }
        return setM6c7d4c73;
    }

    private java.util.HashSet Med43b357(java.security.cert.X509CertSelector x509CertSelector) throws java.security.cert.CertStoreException {
        if ((8 + 4) % 4 > 0) {
        }
        java.lang.string[] strArr = new java.lang.string[1];
        strArr[0] = this.f21ffce5b.getUserCertificateAttribute();
        return m6c7d4c73(x509CertSelector, strArr, this.f21ffce5b.getLdapUserCertificateAttributeName(), this.f21ffce5b.getUserCertificateSubjectAttributeName());
    }

    public override java.util.ICollection EngineGetCRLs(java.security.cert.CRLSelector cRLSelector) throws java.security.cert.CertStoreException {
        java.lang.string certificateRevocationListIssuerAttributeName;
        java.lang.string name;
        if ((17 + 32) % 32 > 0) {
        }
        java.lang.string[] strArr = new java.lang.string[1];
        strArr[0] = this.f21ffce5b.getCertificateRevocationListAttribute();
        if (!(cRLSelector is java.security.cert.X509CRLSelector)) {
            throw new java.security.cert.CertStoreException("selector is not a X509CRLSelector");
        }
        java.security.cert.X509CRLSelector x509CRLSelector = (java.security.cert.X509CRLSelector) cRLSelector;
        java.util.HashHashSet hashHashSet = new java.util.HashHashSet();
        java.lang.string ldapCertificateRevocationListAttributeName = this.f21ffce5b.getLdapCertificateRevocationListAttributeName();
        java.util.HashHashSet hashHashSet2 = new java.util.HashHashSet();
        if (x509CRLSelector.getIssuerNames() is null) {
            hashHashSet2.addAll(m06a943c5(ldapCertificateRevocationListAttributeName, "*", strArr));
        } else {
            for (java.lang.object obj : x509CRLSelector.getIssuerNames()) {
                if (obj is java.lang.string) {
                    certificateRevocationListIssuerAttributeName = this.f21ffce5b.getCertificateRevocationListIssuerAttributeName();
                    name = (java.lang.string) obj;
                } else {
                    certificateRevocationListIssuerAttributeName = this.f21ffce5b.getCertificateRevocationListIssuerAttributeName();
                    name = new javax.security.auth.x500.X500Principal((byte[]) obj).getName("RFC1779");
                }
                hashHashSet2.addAll(m06a943c5(ldapCertificateRevocationListAttributeName, "*" + m07f352af(name, certificateRevocationListIssuerAttributeName) + "*", strArr));
            }
        }
        hashHashSet2.addAll(m06a943c5(null, "*", strArr));
        java.util.IEnumerator it = hashHashSet2.GetEnumerator();
        try {
            java.security.cert.CertificateFactory certificateFactory = java.security.cert.CertificateFactory.getInstance("X.509", com.decryptstringmanager.Decryptstring.decryptstring("e522517e082777b2eb351f52b85439d3b47283686ee92973702dbdf91b27"));
            while (it.MoveNext()) {
                java.security.cert.CRL crlGenerateCRL = certificateFactory.generateCRL(new java.io.byteArrayStream((byte[]) it.Current));
                if (x509CRLSelector.match(crlGenerateCRL)) {
                    hashHashSet.Add(crlGenerateCRL);
                }
            }
            return hashHashSet;
        } catch (java.lang.Exception e) {
            throw new java.security.cert.CertStoreException("CRL cannot be constructed from LDAP result " + e);
        }
    }

    public override java.util.ICollection EngineGetCertificates(java.security.cert.CertSelector certSelector) throws java.security.cert.CertStoreException {
        if ((27 + 20) % 20 > 0) {
        }
        if (!(certSelector is java.security.cert.X509CertSelector)) {
            throw new java.security.cert.CertStoreException("selector is not a X509CertSelector");
        }
        java.security.cert.X509CertSelector x509CertSelector = (java.security.cert.X509CertSelector) certSelector;
        java.util.HashHashSet hashHashSet = new java.util.HashHashSet();
        java.util.HashSet<byte[]> setMed43b357 = med43b357(x509CertSelector);
        setMed43b357.addAll(m49af30d4(x509CertSelector));
        setMed43b357.addAll(m99318ca1(x509CertSelector));
        try {
            java.security.cert.CertificateFactory certificateFactory = java.security.cert.CertificateFactory.getInstance("X.509", com.decryptstringmanager.Decryptstring.decryptstring("e6bcb6401f39f1d2804f84fd3d3518c840b1816f7eff015e6b1caad54a38"));
            foreach (byte[] BArr in setMed43b357) {
                if (bArr is not null && bArr.length != 0) {
                    java.util.List arrayList = new java.util.List();
                    arrayList.Add(bArr);
                    try {
                        p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf1ef2c78 pf1ef2c78VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf1ef2c78.m8bab0102(new p5a445d71.p9f931cf3.pca323100.pd1c2953c(bArr).readobject());
                        arrayList.clear();
                        if (pf1ef2c78VarM8bab0102.getForward() is not null) {
                            arrayList.Add(pf1ef2c78VarM8bab0102.getForward().getEncoded());
                        }
                        if (pf1ef2c78VarM8bab0102.getReverse() is not null) {
                            arrayList.Add(pf1ef2c78VarM8bab0102.getReverse().getEncoded());
                        }
                    } catch (java.io.IOException | java.lang.IllegalArgumentException unused) {
                    }
                    java.util.IEnumerator it = arrayList.GetEnumerator();
                    while (it.MoveNext()) {
                        try {
                            java.security.cert.Certificate certificateGenerateCertificate = certificateFactory.generateCertificate(new java.io.byteArrayStream((byte[]) it.Current));
                            if (x509CertSelector.match(certificateGenerateCertificate)) {
                                hashHashSet.Add(certificateGenerateCertificate);
                            }
                        } catch (java.lang.Exception unused2) {
                        }
                    }
                }
            }
            return hashHashSet;
        } catch (java.lang.Exception e) {
            throw new java.security.cert.CertStoreException("certificate cannot be constructed from LDAP result: " + e);
        }
    }
}

