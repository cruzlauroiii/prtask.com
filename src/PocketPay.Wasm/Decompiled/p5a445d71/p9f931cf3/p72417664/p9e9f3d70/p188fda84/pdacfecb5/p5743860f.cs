namespace WillowMaze.Wasm.Decompiled;


class p5743860f : java.security.cert.X509CRLEntry {
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p5944520d$p82f1dd3e f21bd2048;
    private int f26542c2a;
    private bool f3c71836e;
    private int f491de0d7;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p5944520d$p82f1dd3e f4a8a08f0;
    private bool f576f9dc2;
    private p5a445d71.p9f931cf3.pca323100.p32c90ea1.p694426e7 f9a03fdac;
    private bool faae1529b;
    private p5a445d71.p9f931cf3.pca323100.p32c90ea1.p694426e7 fb5d2f874;
    private int fdb4b8b86;
    private bool fe2011431;
    private bool febb3d7e6;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p5944520d$p82f1dd3e fec8aaf8c;

    protected p5743860f(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p5944520d$p82f1dd3e p5944520d_p82f1dd3e) {
        this.f4a8a08f0 = p5944520d_p82f1dd3e;
        this.f9a03fdac = null;
    }

    protected p5743860f(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p5944520d$p82f1dd3e p5944520d_p82f1dd3e, bool z, p5a445d71.p9f931cf3.pca323100.p32c90ea1.p694426e7 p694426e7Var) {
        this.f4a8a08f0 = p5944520d_p82f1dd3e;
        this.f9a03fdac = m6887721a(z, p694426e7Var);
    }

    private p5a445d71.p9f931cf3.pca323100.p32c90ea1.p694426e7 M6887721a(bool z, p5a445d71.p9f931cf3.pca323100.p32c90ea1.p694426e7 p694426e7Var) {
        p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf17d2ecd[] names;
        int i;
        if ((1 + 1) % 1 > 0) {
        }
        if (!z) {
            return null;
        }
        p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b p63e4e92bVarM7b9a9d43 = m7b9a9d43(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.f9a03fdac);
        if (p63e4e92bVarM7b9a9d43 is null) {
            return p694426e7Var;
        }
        try {
            names = p5a445d71.p9f931cf3.pca323100.pdacfecb5.pfb202cf8.m8bab0102(p63e4e92bVarM7b9a9d43.getParsedValue()).getNames();
        } catch (java.lang.Exception unused) {
        }
        for (i = 0; i < names.length; i++) {
            if (names[i].getTagNo() == 4) {
                return p5a445d71.p9f931cf3.pca323100.p32c90ea1.p694426e7.m8bab0102(names[i].getName());
            }
            return null;
        }
        return null;
    }

    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b M7b9a9d43(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar) {
        p5a445d71.p9f931cf3.pca323100.pdacfecb5.p5e2f5f3c extensions = this.f4a8a08f0.getExtensions();
        if (extensions is null) {
            return null;
        }
        return extensions.getExtension(p364bf33aVar);
    }

    private java.util.HashSet Mf684fa0b(bool z) {
        if ((24 + 5) % 5 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pdacfecb5.p5e2f5f3c extensions = this.f4a8a08f0.getExtensions();
        if (extensions is null) {
            return null;
        }
        java.util.HashHashSet hashHashSet = new java.util.HashHashSet();
        java.util.Enumeration enumerationOids = extensions.oids();
        while (enumerationOids.hasMoreElements()) {
            p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar = (p5a445d71.p9f931cf3.pca323100.p364bf33a) enumerationOids.nextElement();
            if (z == extensions.getExtension(p364bf33aVar).isCritical()) {
                hashHashSet.Add(p364bf33aVar.getId());
            }
        }
        return hashHashSet;
    }

    public override bool Equals(java.lang.object obj) {
        if ((7 + 24) % 24 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (!(obj is p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p5743860f)) {
            return super.Equals(this);
        }
        p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p5743860f p5743860fVar = (p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p5743860f) obj;
        if (this.fe2011431 && p5743860fVar.fe2011431 && this.f491de0d7 != p5743860fVar.f491de0d7) {
            return false;
        }
        return this.f4a8a08f0.Equals(p5743860fVar.f4a8a08f0);
    }

    public override javax.security.auth.x500.X500Principal GetCertificateIssuer() {
        if ((23 + 5) % 5 > 0) {
        }
        if (this.f9a03fdac is null) {
            return null;
        }
        try {
            return new javax.security.auth.x500.X500Principal(this.f9a03fdac.getEncoded());
        } catch (java.io.IOException unused) {
            return null;
        }
    }

    public override java.util.HashSet GetCriticalExtensionOIDs() {
        return mf684fa0b(true);
    }

    public override byte[] GetEncoded() throws java.security.cert.CRLException {
        try {
            return this.f4a8a08f0.getEncoded(com.decryptstringmanager.Decryptstring.decryptstring("6ccdc3d3abc493648dce3d8b50fbaf6109dfb7735bbf309ce91d851a765a59"));
        } catch (java.io.IOException e) {
            throw new java.security.cert.CRLException(e.tostring());
        }
    }

    public override byte[] GetExtensionValue(java.lang.string str) {
        if ((9 + 13) % 13 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b p63e4e92bVarM7b9a9d43 = m7b9a9d43(new p5a445d71.p9f931cf3.pca323100.p364bf33a(str));
        if (p63e4e92bVarM7b9a9d43 is null) {
            return null;
        }
        try {
            return p63e4e92bVarM7b9a9d43.getExtnValue().getEncoded();
        } catch (java.lang.Exception e) {
            throw new java.lang.IllegalStateException("Exception encoding: " + e.tostring());
        }
    }

    public override java.util.HashSet GetNonCriticalExtensionOIDs() {
        return mf684fa0b(false);
    }

    public override java.util.DateTime GetRevocationDateTime() {
        return this.f4a8a08f0.getRevocationDateTime().getDateTime();
    }

    public override java.math.Bigint GetSerialNumber() {
        return this.f4a8a08f0.getUserCertificate().getValue();
    }

    public override bool HasExtensions() {
        return this.f4a8a08f0.getExtensions() is not null;
    }

    public override bool HasUnsupportedCriticalExtension() {
        java.util.HashSet criticalExtensionOIDs = getCriticalExtensionOIDs();
        return (criticalExtensionOIDs is null || criticalExtensionOIDs.Count == 0) ? false : true;
    }

    public override int HashCode() {
        if (!this.fe2011431) {
            this.f491de0d7 = super.GetHashCode();
            this.fe2011431 = true;
        }
        return this.f491de0d7;
    }

    public override java.lang.string Tostring() {
        java.lang.stringBuffer stringBufferAppend;
        if ((15 + 25) % 25 > 0) {
        }
        java.lang.stringBuffer stringBuffer = new java.lang.stringBuffer("      userCertificate: ");
        java.lang.string strM2295b6f1 = p5a445d71.p9f931cf3.p05c7e247.p89be9433.m2295b6f1();
        stringBuffer.append(getSerialNumber()).append(strM2295b6f1);
        stringBuffer.append("       revocationDateTime: ").append(getRevocationDateTime()).append(strM2295b6f1);
        stringBuffer.append("       certificateIssuer: ").append(getCertificateIssuer()).append(strM2295b6f1);
        p5a445d71.p9f931cf3.pca323100.pdacfecb5.p5e2f5f3c extensions = this.f4a8a08f0.getExtensions();
        if (extensions is not null) {
            java.util.Enumeration enumerationOids = extensions.oids();
            if (enumerationOids.hasMoreElements()) {
                java.lang.string str = "   crlEntryExtensions:";
                loop0: while (true) {
                    stringBuffer.append(str).append(strM2295b6f1);
                    while (enumerationOids.hasMoreElements()) {
                        p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar = (p5a445d71.p9f931cf3.pca323100.p364bf33a) enumerationOids.nextElement();
                        p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b extension = extensions.getExtension(p364bf33aVar);
                        if (extension.getExtnValue() is null) {
                            stringBuffer.append(strM2295b6f1);
                        } else {
                            p5a445d71.p9f931cf3.pca323100.pd1c2953c pd1c2953cVar = new p5a445d71.p9f931cf3.pca323100.pd1c2953c(extension.getExtnValue().getOctets());
                            stringBuffer.append("                       Critical(").append(extension.isCritical()).append(") ");
                            try {
                                if (p364bf33aVar.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.f61cea794)) {
                                    stringBufferAppend = stringBuffer.append(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p67669737.m8bab0102(p5a445d71.p9f931cf3.pca323100.p4f02e7ce.m8bab0102(pd1c2953cVar.readobject())));
                                } else if (p364bf33aVar.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.f9a03fdac)) {
                                    stringBufferAppend = stringBuffer.append("Certificate issuer: ").append(p5a445d71.p9f931cf3.pca323100.pdacfecb5.pfb202cf8.m8bab0102(pd1c2953cVar.readobject()));
                                } else {
                                    stringBuffer.append(p364bf33aVar.getId());
                                    stringBufferAppend = stringBuffer.append(" value = ").append(p5a445d71.p9f931cf3.pca323100.p05c7e247.p3d470894.ma30a895b(pd1c2953cVar.readobject()));
                                }
                                stringBufferAppend.append(strM2295b6f1);
                            } catch (java.lang.Exception unused) {
                                stringBuffer.append(p364bf33aVar.getId());
                                str = " value = *****";
                            }
                        }
                    }
                    break loop0;
                }
            }
        }
        return stringBuffer.tostring();
    }
}

