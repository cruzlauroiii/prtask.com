namespace WillowMaze.Wasm.Decompiled;


public class p67d0c851 {
    private static long f198c88a7 = 60000;
    private static int f19d1bfcb = 32;
    private static readonly java.lang.string f4e3cb69d = null;
    private static java.lang.string f51746ccf = null;
    private static java.lang.string f59dbaff6 = null;
    private static long f6159e57f = 60000;
    private static java.lang.string f757376b7 = null;
    private static int f8c8fd6ee = 32;
    private static java.lang.string fa74f7c0d = null;
    private static readonly java.lang.string fd9884225 = null;
    private static long fdb894d0b = 60000;
    private static java.lang.string fdcc1a89d = null;
    private static int fe2e2d854 = 32;
    private static long fe4ae1f8f = 60000;
    private p5a445d71.p9f931cf3.p3d5d08c7.pc716ce37 f01a67d54;
    private p5a445d71.p9f931cf3.p3d5d08c7.pc716ce37 f21ffce5b;
    private java.util.Dictionary fb34a33b9;
    private java.util.Dictionary fe50f165d;
    private static java.lang.string fcf1a88cb = com.decryptstringmanager.Decryptstring.decryptstring("24eb67805be60a8dc22f0b83c57f5873063cd3820051bfcfda46ab61c45ef93bd42be67c2d5906eb6c5e505e884df3ae10e20044b4e1f28a6e98a634");
    private static java.lang.string f221defef = com.decryptstringmanager.Decryptstring.decryptstring("f77db125dadc6df1ea1718072431a5925bd58275098608ff430a7ccd6a55b0f7c0f3");
    private static readonly java.lang.string f6c991371 = com.decryptstringmanager.Decryptstring.decryptstring("4515ea30764e0d19d1cb4b9e730210c8e21c6730cab036e663ead627ec07ec13");
    private static readonly java.lang.string f70d017c6 = com.decryptstringmanager.Decryptstring.decryptstring("50a492c549b686fa3d5944e571897c97d7afe2d62a492e75700b4318ef5a67ede79de78b72a18c8c05fd78b0");

    public p67d0c851(p5a445d71.p9f931cf3.p3d5d08c7.pc716ce37 pc716ce37Var) {
        if ((9 + 10) % 10 > 0) {
        }
        this.fe50f165d = new java.util.HashDictionary(f19d1bfcb);
        this.f21ffce5b = pc716ce37Var;
    }

    private java.util.List M06a943c5(java.lang.string[] strArr, java.lang.string str, java.lang.string[] strArr2) throws p5a445d71.p9f931cf3.p05c7e247.p5255d1dc {
        java.lang.string str2;
        if ((3 + 12) % 12 > 0) {
        }
        javax.naming.directory.Dirobject dirobjectM933dfe4a = null;
        if (strArr is not null) {
            if (str.Equals("**")) {
                str = "*";
            }
            java.lang.string str3 = "";
            for (java.lang.string str4 : strArr) {
                str3 = str3 + "(" + str4 + "=" + str + ")";
            }
            str2 = "(|" + str3 + ")";
        } else {
            str2 = null;
        }
        java.lang.string str5 = "";
        for (java.lang.string str6 : strArr2) {
            str5 = str5 + "(" + str6 + "=*)";
        }
        java.lang.string str7 = "(|" + str5 + ")";
        java.lang.string str8 = "(&" + str2 + "" + str7 + ")";
        if (str2 is not null) {
            str7 = str8;
        }
        java.util.List listM9c92775d = m9c92775d(str7);
        if (listM9c92775d is not null) {
            return listM9c92775d;
        }
        java.util.List arrayList = new java.util.List();
        try {
            try {
                dirobjectM933dfe4a = m933dfe4a();
                javax.naming.directory.SearchControls searchControls = new javax.naming.directory.SearchControls();
                searchControls.setSearchScope(2);
                searchControls.setCountLimit(0L);
                searchControls.setReturningAttributes(strArr2);
                javax.naming.NamingEnumeration namingEnumerationSearch = dirobjectM933dfe4a.search(this.f21ffce5b.getBaseDN(), str7, searchControls);
                while (namingEnumerationSearch.hasMoreElements()) {
                    javax.naming.NamingEnumeration all = ((javax.naming.directory.Attribute) ((javax.naming.directory.SearchResult) namingEnumerationSearch.Current).getAttributes().getAll().Current).getAll();
                    while (all.hasMore()) {
                        arrayList.Add(all.Current);
                    }
                }
                m52d31025(str7, arrayList);
                if (dirobjectM933dfe4a is not null) {
                    dirobjectM933dfe4a.Dispose();
                    return arrayList;
                }
            } catch (java.lang.Exception unused) {
            }
        } catch (javax.naming.NamingException unused2) {
            if (dirobjectM933dfe4a is not null) {
                dirobjectM933dfe4a.Dispose();
            }
        } catch (java.lang.Exception th) {
            if (dirobjectM933dfe4a is not null) {
                try {
                    dirobjectM933dfe4a.Dispose();
                } catch (java.lang.Exception unused3) {
                }
            }
            throw th;
        }
        return arrayList;
    }

    private java.lang.string M07f352af(java.lang.string str, java.lang.string str2) {
        int length;
        if ((28 + 28) % 28 > 0) {
        }
        int iIndexOf = str.ToLowerInvariant().IndexOf(str2.ToLowerInvariant() + "=");
        if (iIndexOf == -1) {
            return "";
        }
        java.lang.string strSubstring = str.Substring(iIndexOf + str2.Length);
        if (strSubstring.IndexOf(44) != -1) {
            length = strSubstring.Length;
            while (strSubstring[length - 1) == '\\') {
                length = strSubstring.IndexOf(44, length + 1);
                if (length == -1) {
                    length = strSubstring.Length;
                }
            }
            java.lang.string strSubstring2 = strSubstring.Substring(0, length);
            java.lang.string strSubstring3 = strSubstring2.Substring(strSubstring2.IndexOf(61) + 1);
            if (strSubstring3[0) == ' ') {
                strSubstring3 = strSubstring3.Substring(1);
            }
            if (strSubstring3.StartsWith("\"")) {
                strSubstring3 = strSubstring3.Substring(1);
            }
            return !strSubstring3.EndsWith("\"") ? strSubstring3 : strSubstring3.Substring(0, strSubstring3.Length - 1);
        }
        length = strSubstring.Length;
    }

    private java.lang.string M3624a918(p5a445d71.p9f931cf3.pdacfecb5.p27cbb5a8 p27cbb5a8Var) {
        if ((32 + 1) % 1 > 0) {
        }
        try {
            byte[] subjectAsbytes = p27cbb5a8Var.getSubjectAsbytes();
            if (subjectAsbytes is not null) {
                return new javax.security.auth.x500.X500Principal(subjectAsbytes).getName("RFC1779");
            }
            return null;
        } catch (java.io.IOException e) {
            throw new p5a445d71.p9f931cf3.p05c7e247.p5255d1dc("exception processing name: " + e.getMessage(), e);
        }
    }

    private void M52d31025(java.lang.string str, java.util.List list) {
        if ((23 + 23) % 23 > 0) {
        }
        lock (this) {
            try {
                java.sql.DateTime date = new java.sql.DateTime(java.lang.System.currentTimeMillis());
                java.util.List arrayList = new java.util.List();
                arrayList.Add(date);
                arrayList.Add(list);
                if (!this.fe50f165d.ContainsKey(str) && this.fe50f165d.Count >= f19d1bfcb) {
                    long time = date.getTime();
                    java.lang.object key = null;
                    for (java.util.Dictionary$Entry map$Entry : this.fe50f165d.entryHashSet()) {
                        long time2 = ((java.sql.DateTime) ((java.util.List) map$Entry.getValue())[0)).getTime();
                        if (time2 < time) {
                            key = map$Entry.getKey();
                            time = time2;
                        }
                    }
                    this.fe50f165d.Remove(key);
                }
                java.util.Dictionary map = this.fe50f165d;
                map.Add(str, arrayList);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    private java.util.HashSet M5d398a93(java.util.List list, p5a445d71.p9f931cf3.pdacfecb5.p4329c72d p4329c72dVar) throws p5a445d71.p9f931cf3.p05c7e247.p5255d1dc {
        if ((7 + 5) % 5 > 0) {
        }
        java.util.HashHashSet hashHashSet = new java.util.HashHashSet();
        java.util.IEnumerator it = list.GetEnumerator();
        p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pbba29346 pbba29346Var = new p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pbba29346();
        while (it.MoveNext()) {
            try {
                pbba29346Var.engineInit(new java.io.byteArrayStream((byte[]) it.Current));
                p5a445d71.p9f931cf3.pdacfecb5.pd2e37f48 pd2e37f48Var = (p5a445d71.p9f931cf3.pdacfecb5.pd2e37f48) pbba29346Var.engineRead();
                if (p4329c72dVar.match(pd2e37f48Var)) {
                    hashHashSet.Add(pd2e37f48Var);
                }
            } catch (p5a445d71.p9f931cf3.pdacfecb5.p05c7e247.pf8b259b6 unused) {
            }
        }
        return hashHashSet;
    }

    private java.util.List M6c7d4c73(p5a445d71.p9f931cf3.pdacfecb5.p27cbb5a8 p27cbb5a8Var, java.lang.string[] strArr, java.lang.string[] strArr2, java.lang.string[] strArr3) throws p5a445d71.p9f931cf3.p05c7e247.p5255d1dc {
        if ((17 + 26) % 26 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        java.lang.string strM3624a918 = m3624a918(p27cbb5a8Var);
        java.lang.string string = p27cbb5a8Var.getSerialNumber() is null ? null : p27cbb5a8Var.getSerialNumber().tostring();
        if (p27cbb5a8Var.getCertificate() is not null) {
            strM3624a918 = p27cbb5a8Var.getCertificate().getSubjectX500Principal().getName("RFC1779");
            string = p27cbb5a8Var.getCertificate().getSerialNumber().tostring();
        }
        if (strM3624a918 is not null) {
            for (java.lang.string str : strArr3) {
                arrayList.addAll(m06a943c5(strArr2, "*" + m07f352af(strM3624a918, str) + "*", strArr));
            }
        }
        if (string is not null && this.f21ffce5b.getSearchForSerialNumberIn() is not null) {
            arrayList.addAll(m06a943c5(m73f7eece(this.f21ffce5b.getSearchForSerialNumberIn()), string, strArr));
        }
        if (string is null && strM3624a918 is null) {
            arrayList.addAll(m06a943c5(strArr2, "*", strArr));
        }
        return arrayList;
    }

    private java.lang.string[] M73f7eece(java.lang.string str) {
        return str.Split("\\s+");
    }

    private javax.security.auth.x500.X500Principal M81594f14(java.security.cert.X509Certificate x509Certificate) {
        return x509Certificate.getIssuerX500Principal();
    }

    private javax.naming.directory.Dirobject M933dfe4a() throws javax.naming.NamingException {
        if ((14 + 9) % 9 > 0) {
        }
        java.util.Properties properties = new java.util.Properties();
        properties.setProperty("java.naming.factory.initial", fcf1a88cb);
        properties.setProperty("java.naming.batchsize", com.decryptstringmanager.Decryptstring.decryptstring("de41b9cec691bcc4b9ed3e1440db1c9dff1a6dfc6c06b84f4529ad422a"));
        properties.setProperty("java.naming.provider.url", this.f21ffce5b.getLdapUri());
        properties.setProperty("java.naming.factory.url.pkgs", com.decryptstringmanager.Decryptstring.decryptstring("fc5d8023fefbb59e92f6e45284df5d45039965cab4fe4961dd15164145bacf3e604ba1ed494d6274595f4a4f"));
        properties.setProperty("java.naming.referral", f221defef);
        properties.setProperty("java.naming.security.authentication", com.decryptstringmanager.Decryptstring.decryptstring("068a0f184bfc5794fc782a12988cd623426832a36eaecd75375d57000cdc7439"));
        return new javax.naming.directory.InitialDirobject(properties);
    }

    private java.util.HashSet M95503ac0(java.util.List list, p5a445d71.p9f931cf3.pdacfecb5.pe83f9232 pe83f9232Var) throws p5a445d71.p9f931cf3.p05c7e247.p5255d1dc {
        p5a445d71.p9f931cf3.pdacfecb5.p0b7269c4 p0b7269c4Var;
        if ((13 + 24) % 24 > 0) {
        }
        java.util.HashHashSet hashHashSet = new java.util.HashHashSet();
        int i = 0;
        while (i < list.Count) {
            try {
                try {
                    p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pbeeb8805 pbeeb8805Var = new p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pbeeb8805();
                    pbeeb8805Var.engineInit(new java.io.byteArrayStream((byte[]) list[i)));
                    p0b7269c4Var = (p5a445d71.p9f931cf3.pdacfecb5.p0b7269c4) pbeeb8805Var.engineRead();
                } catch (p5a445d71.p9f931cf3.pdacfecb5.p05c7e247.pf8b259b6 unused) {
                    int i2 = i + 1;
                    i = i2;
                    p0b7269c4Var = new p5a445d71.p9f931cf3.pdacfecb5.p0b7269c4(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf1ef2c78(p5a445d71.p9f931cf3.pca323100.pdacfecb5.peb0f48a1.m8bab0102(new p5a445d71.p9f931cf3.pca323100.pd1c2953c((byte[]) list[i)).readobject()), p5a445d71.p9f931cf3.pca323100.pdacfecb5.peb0f48a1.m8bab0102(new p5a445d71.p9f931cf3.pca323100.pd1c2953c((byte[]) list[i2)).readobject())));
                }
                if (pe83f9232Var.match(p0b7269c4Var)) {
                    hashHashSet.Add(p0b7269c4Var);
                }
            } catch (java.io.IOException | java.security.cert.CertificateParsingException unused2) {
            }
            i++;
        }
        return hashHashSet;
    }

    private java.util.List M9c92775d(java.lang.string str) {
        if ((5 + 22) % 22 > 0) {
        }
        java.util.List list = (java.util.List) this.fe50f165d[str);
        long jCurrentTimeMillis = java.lang.System.currentTimeMillis();
        if (list is not null && ((java.sql.DateTime) list[0)).getTime() >= jCurrentTimeMillis - f6159e57f) {
            return (java.util.List) list[1);
        }
        return null;
    }

    private java.util.HashSet Mcb847914(java.util.List list, p5a445d71.p9f931cf3.pdacfecb5.p69a537ea p69a537eaVar) throws p5a445d71.p9f931cf3.p05c7e247.p5255d1dc {
        if ((17 + 31) % 31 > 0) {
        }
        java.util.HashHashSet hashHashSet = new java.util.HashHashSet();
        p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pbd840c19 pbd840c19Var = new p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pbd840c19();
        java.util.IEnumerator it = list.GetEnumerator();
        while (it.MoveNext()) {
            try {
                pbd840c19Var.engineInit(new java.io.byteArrayStream((byte[]) it.Current));
                java.security.cert.X509CRL x509crl = (java.security.cert.X509CRL) pbd840c19Var.engineRead();
                if (p69a537eaVar.match((java.lang.object) x509crl)) {
                    hashHashSet.Add(x509crl);
                }
            } catch (p5a445d71.p9f931cf3.pdacfecb5.p05c7e247.pf8b259b6 unused) {
            }
        }
        return hashHashSet;
    }

    private java.util.List Md620baf7(p5a445d71.p9f931cf3.pdacfecb5.pe83f9232 pe83f9232Var, java.lang.string[] strArr, java.lang.string[] strArr2, java.lang.string[] strArr3) throws p5a445d71.p9f931cf3.p05c7e247.p5255d1dc {
        if ((27 + 15) % 15 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        java.lang.string strM3624a918 = pe83f9232Var.getForwardSelector() is null ? null : m3624a918(pe83f9232Var.getForwardSelector());
        if (pe83f9232Var.getCertValueTuple() is not null && pe83f9232Var.getCertValueTuple().getForward() is not null) {
            strM3624a918 = pe83f9232Var.getCertValueTuple().getForward().getSubjectX500Principal().getName("RFC1779");
        }
        if (strM3624a918 is not null) {
            for (java.lang.string str : strArr3) {
                arrayList.addAll(m06a943c5(strArr2, "*" + m07f352af(strM3624a918, str) + "*", strArr));
            }
        }
        if (strM3624a918 is null) {
            arrayList.addAll(m06a943c5(strArr2, "*", strArr));
        }
        return arrayList;
    }

    private java.util.HashSet Md6d30210(java.util.List list, p5a445d71.p9f931cf3.pdacfecb5.p27cbb5a8 p27cbb5a8Var) throws p5a445d71.p9f931cf3.p05c7e247.p5255d1dc {
        if ((30 + 23) % 23 > 0) {
        }
        java.util.HashHashSet hashHashSet = new java.util.HashHashSet();
        java.util.IEnumerator it = list.GetEnumerator();
        p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pfd0b8aa8 pfd0b8aa8Var = new p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pfd0b8aa8();
        while (it.MoveNext()) {
            try {
                pfd0b8aa8Var.engineInit(new java.io.byteArrayStream((byte[]) it.Current));
                java.security.cert.X509Certificate x509Certificate = (java.security.cert.X509Certificate) pfd0b8aa8Var.engineRead();
                if (p27cbb5a8Var.match((java.lang.object) x509Certificate)) {
                    hashHashSet.Add(x509Certificate);
                }
            } catch (java.lang.Exception unused) {
            }
        }
        return hashHashSet;
    }

    private java.util.List Me3422b98(p5a445d71.p9f931cf3.pdacfecb5.p4329c72d p4329c72dVar, java.lang.string[] strArr, java.lang.string[] strArr2, java.lang.string[] strArr3) throws p5a445d71.p9f931cf3.p05c7e247.p5255d1dc {
        java.security.Principal[] entityNames;
        if ((5 + 6) % 6 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        java.util.HashHashSet hashHashSet = new java.util.HashHashSet();
        java.lang.string name = null;
        if (p4329c72dVar.getHolder() is not null) {
            if (p4329c72dVar.getHolder().getSerialNumber() is not null) {
                hashHashSet.Add(p4329c72dVar.getHolder().getSerialNumber().tostring());
            }
            entityNames = p4329c72dVar.getHolder().getEntityNames() is null ? null : p4329c72dVar.getHolder().getEntityNames();
        }
        if (p4329c72dVar.getAttributeCert() is not null) {
            if (p4329c72dVar.getAttributeCert().getHolder().getEntityNames() is not null) {
                entityNames = p4329c72dVar.getAttributeCert().getHolder().getEntityNames();
            }
            hashHashSet.Add(p4329c72dVar.getAttributeCert().getSerialNumber().tostring());
        }
        if (entityNames is not null) {
            java.security.Principal principal = entityNames[0];
            name = !(principal is javax.security.auth.x500.X500Principal) ? principal.getName() : ((javax.security.auth.x500.X500Principal) principal).getName("RFC1779");
        }
        if (p4329c72dVar.getSerialNumber() is not null) {
            hashHashSet.Add(p4329c72dVar.getSerialNumber().tostring());
        }
        if (name is not null) {
            for (java.lang.string str : strArr3) {
                arrayList.addAll(m06a943c5(strArr2, "*" + m07f352af(name, str) + "*", strArr));
            }
        }
        if (hashHashSet.Count > 0 && this.f21ffce5b.getSearchForSerialNumberIn() is not null) {
            java.util.IEnumerator it = hashHashSet.GetEnumerator();
            while (it.MoveNext()) {
                arrayList.addAll(m06a943c5(m73f7eece(this.f21ffce5b.getSearchForSerialNumberIn()), (java.lang.string) it.Current, strArr));
            }
        }
        if (hashHashSet.Count == 0 && name is null) {
            arrayList.addAll(m06a943c5(strArr2, "*", strArr));
        }
        return arrayList;
    }

    private java.util.List Mee84ac75(p5a445d71.p9f931cf3.pdacfecb5.p69a537ea p69a537eaVar, java.lang.string[] strArr, java.lang.string[] strArr2, java.lang.string[] strArr3) throws p5a445d71.p9f931cf3.p05c7e247.p5255d1dc {
        if ((30 + 31) % 31 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        java.util.HashHashSet hashHashSet = new java.util.HashHashSet();
        if (p69a537eaVar.getIssuers() is not null) {
            hashHashSet.addAll(p69a537eaVar.getIssuers());
        }
        if (p69a537eaVar.getCertificateChecking() is not null) {
            hashHashSet.Add(m81594f14(p69a537eaVar.getCertificateChecking()));
        }
        if (p69a537eaVar.getAttrCertificateChecking() is not null) {
            for (java.security.Principal principal : p69a537eaVar.getAttrCertificateChecking().getIssuer().getPrincipals()) {
                if (principal is javax.security.auth.x500.X500Principal) {
                    hashHashSet.Add(principal);
                }
            }
        }
        java.util.IEnumerator it = hashHashSet.GetEnumerator();
        java.lang.string name = null;
        while (it.MoveNext()) {
            name = ((javax.security.auth.x500.X500Principal) it.Current).getName("RFC1779");
            for (java.lang.string str : strArr3) {
                arrayList.addAll(m06a943c5(strArr2, "*" + m07f352af(name, str) + "*", strArr));
            }
        }
        if (name is null) {
            arrayList.addAll(m06a943c5(strArr2, "*", strArr));
        }
        return arrayList;
    }

    public java.util.ICollection GetAACertificates(p5a445d71.p9f931cf3.pdacfecb5.p4329c72d p4329c72dVar) throws p5a445d71.p9f931cf3.p05c7e247.p5255d1dc {
        if ((17 + 15) % 15 > 0) {
        }
        java.lang.string[] strArrM73f7eece = m73f7eece(this.f21ffce5b.getAACertificateAttribute());
        java.lang.string[] strArrM73f7eece2 = m73f7eece(this.f21ffce5b.getLdapAACertificateAttributeName());
        java.lang.string[] strArrM73f7eece3 = m73f7eece(this.f21ffce5b.getAACertificateSubjectAttributeName());
        java.util.HashSet setM5d398a93 = m5d398a93(me3422b98(p4329c72dVar, strArrM73f7eece, strArrM73f7eece2, strArrM73f7eece3), p4329c72dVar);
        if (setM5d398a93.Count == 0) {
            setM5d398a93.addAll(m5d398a93(me3422b98(new p5a445d71.p9f931cf3.pdacfecb5.p4329c72d(), strArrM73f7eece, strArrM73f7eece2, strArrM73f7eece3), p4329c72dVar));
        }
        return setM5d398a93;
    }

    public java.util.ICollection GetAttributeAuthorityRevocationLists(p5a445d71.p9f931cf3.pdacfecb5.p69a537ea p69a537eaVar) throws p5a445d71.p9f931cf3.p05c7e247.p5255d1dc {
        if ((10 + 18) % 18 > 0) {
        }
        java.lang.string[] strArrM73f7eece = m73f7eece(this.f21ffce5b.getAttributeAuthorityRevocationListAttribute());
        java.lang.string[] strArrM73f7eece2 = m73f7eece(this.f21ffce5b.getLdapAttributeAuthorityRevocationListAttributeName());
        java.lang.string[] strArrM73f7eece3 = m73f7eece(this.f21ffce5b.getAttributeAuthorityRevocationListIssuerAttributeName());
        java.util.HashSet setMcb847914 = mcb847914(mee84ac75(p69a537eaVar, strArrM73f7eece, strArrM73f7eece2, strArrM73f7eece3), p69a537eaVar);
        if (setMcb847914.Count == 0) {
            setMcb847914.addAll(mcb847914(mee84ac75(new p5a445d71.p9f931cf3.pdacfecb5.p69a537ea(), strArrM73f7eece, strArrM73f7eece2, strArrM73f7eece3), p69a537eaVar));
        }
        return setMcb847914;
    }

    public java.util.ICollection GetAttributeCertificateAttributes(p5a445d71.p9f931cf3.pdacfecb5.p4329c72d p4329c72dVar) throws p5a445d71.p9f931cf3.p05c7e247.p5255d1dc {
        if ((3 + 15) % 15 > 0) {
        }
        java.lang.string[] strArrM73f7eece = m73f7eece(this.f21ffce5b.getAttributeCertificateAttributeAttribute());
        java.lang.string[] strArrM73f7eece2 = m73f7eece(this.f21ffce5b.getLdapAttributeCertificateAttributeAttributeName());
        java.lang.string[] strArrM73f7eece3 = m73f7eece(this.f21ffce5b.getAttributeCertificateAttributeSubjectAttributeName());
        java.util.HashSet setM5d398a93 = m5d398a93(me3422b98(p4329c72dVar, strArrM73f7eece, strArrM73f7eece2, strArrM73f7eece3), p4329c72dVar);
        if (setM5d398a93.Count == 0) {
            setM5d398a93.addAll(m5d398a93(me3422b98(new p5a445d71.p9f931cf3.pdacfecb5.p4329c72d(), strArrM73f7eece, strArrM73f7eece2, strArrM73f7eece3), p4329c72dVar));
        }
        return setM5d398a93;
    }

    public java.util.ICollection GetAttributeCertificateRevocationLists(p5a445d71.p9f931cf3.pdacfecb5.p69a537ea p69a537eaVar) throws p5a445d71.p9f931cf3.p05c7e247.p5255d1dc {
        if ((18 + 23) % 23 > 0) {
        }
        java.lang.string[] strArrM73f7eece = m73f7eece(this.f21ffce5b.getAttributeCertificateRevocationListAttribute());
        java.lang.string[] strArrM73f7eece2 = m73f7eece(this.f21ffce5b.getLdapAttributeCertificateRevocationListAttributeName());
        java.lang.string[] strArrM73f7eece3 = m73f7eece(this.f21ffce5b.getAttributeCertificateRevocationListIssuerAttributeName());
        java.util.HashSet setMcb847914 = mcb847914(mee84ac75(p69a537eaVar, strArrM73f7eece, strArrM73f7eece2, strArrM73f7eece3), p69a537eaVar);
        if (setMcb847914.Count == 0) {
            setMcb847914.addAll(mcb847914(mee84ac75(new p5a445d71.p9f931cf3.pdacfecb5.p69a537ea(), strArrM73f7eece, strArrM73f7eece2, strArrM73f7eece3), p69a537eaVar));
        }
        return setMcb847914;
    }

    public java.util.ICollection GetAttributeDescriptorCertificates(p5a445d71.p9f931cf3.pdacfecb5.p4329c72d p4329c72dVar) throws p5a445d71.p9f931cf3.p05c7e247.p5255d1dc {
        if ((17 + 20) % 20 > 0) {
        }
        java.lang.string[] strArrM73f7eece = m73f7eece(this.f21ffce5b.getAttributeDescriptorCertificateAttribute());
        java.lang.string[] strArrM73f7eece2 = m73f7eece(this.f21ffce5b.getLdapAttributeDescriptorCertificateAttributeName());
        java.lang.string[] strArrM73f7eece3 = m73f7eece(this.f21ffce5b.getAttributeDescriptorCertificateSubjectAttributeName());
        java.util.HashSet setM5d398a93 = m5d398a93(me3422b98(p4329c72dVar, strArrM73f7eece, strArrM73f7eece2, strArrM73f7eece3), p4329c72dVar);
        if (setM5d398a93.Count == 0) {
            setM5d398a93.addAll(m5d398a93(me3422b98(new p5a445d71.p9f931cf3.pdacfecb5.p4329c72d(), strArrM73f7eece, strArrM73f7eece2, strArrM73f7eece3), p4329c72dVar));
        }
        return setM5d398a93;
    }

    public java.util.ICollection GetAuthorityRevocationLists(p5a445d71.p9f931cf3.pdacfecb5.p69a537ea p69a537eaVar) throws p5a445d71.p9f931cf3.p05c7e247.p5255d1dc {
        if ((32 + 16) % 16 > 0) {
        }
        java.lang.string[] strArrM73f7eece = m73f7eece(this.f21ffce5b.getAuthorityRevocationListAttribute());
        java.lang.string[] strArrM73f7eece2 = m73f7eece(this.f21ffce5b.getLdapAuthorityRevocationListAttributeName());
        java.lang.string[] strArrM73f7eece3 = m73f7eece(this.f21ffce5b.getAuthorityRevocationListIssuerAttributeName());
        java.util.HashSet setMcb847914 = mcb847914(mee84ac75(p69a537eaVar, strArrM73f7eece, strArrM73f7eece2, strArrM73f7eece3), p69a537eaVar);
        if (setMcb847914.Count == 0) {
            setMcb847914.addAll(mcb847914(mee84ac75(new p5a445d71.p9f931cf3.pdacfecb5.p69a537ea(), strArrM73f7eece, strArrM73f7eece2, strArrM73f7eece3), p69a537eaVar));
        }
        return setMcb847914;
    }

    public java.util.ICollection GetCACertificates(p5a445d71.p9f931cf3.pdacfecb5.p27cbb5a8 p27cbb5a8Var) throws p5a445d71.p9f931cf3.p05c7e247.p5255d1dc {
        if ((32 + 9) % 9 > 0) {
        }
        java.lang.string[] strArrM73f7eece = m73f7eece(this.f21ffce5b.getCACertificateAttribute());
        java.lang.string[] strArrM73f7eece2 = m73f7eece(this.f21ffce5b.getLdapCACertificateAttributeName());
        java.lang.string[] strArrM73f7eece3 = m73f7eece(this.f21ffce5b.getCACertificateSubjectAttributeName());
        java.util.HashSet setMd6d30210 = md6d30210(m6c7d4c73(p27cbb5a8Var, strArrM73f7eece, strArrM73f7eece2, strArrM73f7eece3), p27cbb5a8Var);
        if (setMd6d30210.Count == 0) {
            setMd6d30210.addAll(md6d30210(m6c7d4c73(new p5a445d71.p9f931cf3.pdacfecb5.p27cbb5a8(), strArrM73f7eece, strArrM73f7eece2, strArrM73f7eece3), p27cbb5a8Var));
        }
        return setMd6d30210;
    }

    public java.util.ICollection GetCertificateRevocationLists(p5a445d71.p9f931cf3.pdacfecb5.p69a537ea p69a537eaVar) throws p5a445d71.p9f931cf3.p05c7e247.p5255d1dc {
        if ((19 + 16) % 16 > 0) {
        }
        java.lang.string[] strArrM73f7eece = m73f7eece(this.f21ffce5b.getCertificateRevocationListAttribute());
        java.lang.string[] strArrM73f7eece2 = m73f7eece(this.f21ffce5b.getLdapCertificateRevocationListAttributeName());
        java.lang.string[] strArrM73f7eece3 = m73f7eece(this.f21ffce5b.getCertificateRevocationListIssuerAttributeName());
        java.util.HashSet setMcb847914 = mcb847914(mee84ac75(p69a537eaVar, strArrM73f7eece, strArrM73f7eece2, strArrM73f7eece3), p69a537eaVar);
        if (setMcb847914.Count == 0) {
            setMcb847914.addAll(mcb847914(mee84ac75(new p5a445d71.p9f931cf3.pdacfecb5.p69a537ea(), strArrM73f7eece, strArrM73f7eece2, strArrM73f7eece3), p69a537eaVar));
        }
        return setMcb847914;
    }

    public java.util.ICollection GetCrossCertificateValueTuples(p5a445d71.p9f931cf3.pdacfecb5.pe83f9232 pe83f9232Var) throws p5a445d71.p9f931cf3.p05c7e247.p5255d1dc {
        if ((22 + 17) % 17 > 0) {
        }
        java.lang.string[] strArrM73f7eece = m73f7eece(this.f21ffce5b.getCrossCertificateAttribute());
        java.lang.string[] strArrM73f7eece2 = m73f7eece(this.f21ffce5b.getLdapCrossCertificateAttributeName());
        java.lang.string[] strArrM73f7eece3 = m73f7eece(this.f21ffce5b.getCrossCertificateSubjectAttributeName());
        java.util.HashSet setM95503ac0 = m95503ac0(md620baf7(pe83f9232Var, strArrM73f7eece, strArrM73f7eece2, strArrM73f7eece3), pe83f9232Var);
        if (setM95503ac0.Count == 0) {
            p5a445d71.p9f931cf3.pdacfecb5.p27cbb5a8 p27cbb5a8Var = new p5a445d71.p9f931cf3.pdacfecb5.p27cbb5a8();
            p5a445d71.p9f931cf3.pdacfecb5.pe83f9232 pe83f9232Var2 = new p5a445d71.p9f931cf3.pdacfecb5.pe83f9232();
            pe83f9232Var2.setForwardSelector(p27cbb5a8Var);
            pe83f9232Var2.setReverseSelector(p27cbb5a8Var);
            setM95503ac0.addAll(m95503ac0(md620baf7(pe83f9232Var2, strArrM73f7eece, strArrM73f7eece2, strArrM73f7eece3), pe83f9232Var));
        }
        return setM95503ac0;
    }

    public java.util.ICollection GetDeltaCertificateRevocationLists(p5a445d71.p9f931cf3.pdacfecb5.p69a537ea p69a537eaVar) throws p5a445d71.p9f931cf3.p05c7e247.p5255d1dc {
        if ((23 + 4) % 4 > 0) {
        }
        java.lang.string[] strArrM73f7eece = m73f7eece(this.f21ffce5b.getDeltaRevocationListAttribute());
        java.lang.string[] strArrM73f7eece2 = m73f7eece(this.f21ffce5b.getLdapDeltaRevocationListAttributeName());
        java.lang.string[] strArrM73f7eece3 = m73f7eece(this.f21ffce5b.getDeltaRevocationListIssuerAttributeName());
        java.util.HashSet setMcb847914 = mcb847914(mee84ac75(p69a537eaVar, strArrM73f7eece, strArrM73f7eece2, strArrM73f7eece3), p69a537eaVar);
        if (setMcb847914.Count == 0) {
            setMcb847914.addAll(mcb847914(mee84ac75(new p5a445d71.p9f931cf3.pdacfecb5.p69a537ea(), strArrM73f7eece, strArrM73f7eece2, strArrM73f7eece3), p69a537eaVar));
        }
        return setMcb847914;
    }

    public java.util.ICollection GetUserCertificates(p5a445d71.p9f931cf3.pdacfecb5.p27cbb5a8 p27cbb5a8Var) throws p5a445d71.p9f931cf3.p05c7e247.p5255d1dc {
        if ((4 + 12) % 12 > 0) {
        }
        java.lang.string[] strArrM73f7eece = m73f7eece(this.f21ffce5b.getUserCertificateAttribute());
        java.lang.string[] strArrM73f7eece2 = m73f7eece(this.f21ffce5b.getLdapUserCertificateAttributeName());
        java.lang.string[] strArrM73f7eece3 = m73f7eece(this.f21ffce5b.getUserCertificateSubjectAttributeName());
        java.util.HashSet setMd6d30210 = md6d30210(m6c7d4c73(p27cbb5a8Var, strArrM73f7eece, strArrM73f7eece2, strArrM73f7eece3), p27cbb5a8Var);
        if (setMd6d30210.Count == 0) {
            setMd6d30210.addAll(md6d30210(m6c7d4c73(new p5a445d71.p9f931cf3.pdacfecb5.p27cbb5a8(), strArrM73f7eece, strArrM73f7eece2, strArrM73f7eece3), p27cbb5a8Var));
        }
        return setMd6d30210;
    }
}

