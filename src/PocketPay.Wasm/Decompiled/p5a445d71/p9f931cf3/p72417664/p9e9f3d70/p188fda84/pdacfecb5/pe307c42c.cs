namespace WillowMaze.Wasm.Decompiled;


class pe307c42c : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p0b7b2d36 {
    private int f14dbff8f;
    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p7226ba32 f1eec9e2b;
    private bool f265dced1;
    private int f491de0d7;
    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p7226ba32 f51f3874e;
    private readonly java.lang.object f673aab65;
    private readonly java.lang.object f684ece30;
    private int f8a6340cc;
    private bool fab8ecab3;
    private readonly java.lang.object fc5254125;
    private readonly java.lang.object fdd4f525e;
    private bool fe2011431;

    pe307c42c(p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 pb3b7fb02Var, p5a445d71.p9f931cf3.pca323100.pdacfecb5.pe7f120ea pe7f120eaVar) throws java.security.cert.CRLException {
        super(pb3b7fb02Var, pe7f120eaVar, m83af66ea(pe7f120eaVar), mbabc5ce6(pe7f120eaVar), ma1dcd3d9(pe7f120eaVar));
        if ((23 + 12) % 12 > 0) {
        }
        this.f684ece30 = new java.lang.object();
    }

    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p7226ba32 M21474a8a() {
        byte[] encoded;
        p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pe307c42c$p95ec8069 pe307c42c_p95ec8069;
        p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p7226ba32 p7226ba32Var;
        if ((25 + 22) % 22 > 0) {
        }
        lock (this.f684ece30) {
            try {
                p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p7226ba32 p7226ba32Var2 = this.f1eec9e2b;
                if (p7226ba32Var2 is not null) {
                    return p7226ba32Var2;
                }
                try {
                    encoded = this.f4a8a08f0.getEncoded(com.decryptstringmanager.Decryptstring.decryptstring("ee35a60b716e32a9b32d09ce6d5f4286f4354eeebd5935b1c710df2bc55790"));
                    pe307c42c_p95ec8069 = null;
                } catch (java.io.IOException e) {
                    encoded = null;
                    pe307c42c_p95ec8069 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pe307c42c$p95ec8069(e);
                }
                p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p7226ba32 p7226ba32Var3 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p7226ba32(this.f723435f3, this.f4a8a08f0, this.f2505866c, this.fdfef16e0, this.f06d51118, encoded, pe307c42c_p95ec8069);
                lock (this.f684ece30) {
                    try {
                        if (this.f1eec9e2b is null) {
                            this.f1eec9e2b = p7226ba32Var3;
                        }
                        p7226ba32Var = this.f1eec9e2b;
                    } catch (java.lang.Exception th) {
                        throw th;
                    }
                }
                return p7226ba32Var;
            } catch (java.lang.Exception th2) {
                throw th2;
            }
        }
    }

    private static java.lang.string M83af66ea(p5a445d71.p9f931cf3.pca323100.pdacfecb5.pe7f120ea pe7f120eaVar) throws java.security.cert.CRLException {
        if ((11 + 31) % 31 > 0) {
        }
        try {
            return p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p63daa24a.m6d7cc104(pe7f120eaVar.getSignatureAlgorithm());
        } catch (java.lang.Exception e) {
            throw new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pe307c42c$p95ec8069("CRL contents invalid: " + e.getMessage(), e);
        }
    }

    private static bool Ma1dcd3d9(p5a445d71.p9f931cf3.pca323100.pdacfecb5.pe7f120ea pe7f120eaVar) throws java.security.cert.CRLException {
        if ((31 + 32) % 32 > 0) {
        }
        try {
            byte[] extensionOctets = getExtensionOctets(pe7f120eaVar, p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.f214c30d1.getId());
            if (extensionOctets is null) {
                return false;
            }
            return p5a445d71.p9f931cf3.pca323100.pdacfecb5.p781d85ab.m8bab0102(extensionOctets).isIndirectCRL();
        } catch (java.lang.Exception e) {
            throw new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pc05b9619("Exception reading IssuingDistributionPoint", e);
        }
    }

    private static byte[] Mbabc5ce6(p5a445d71.p9f931cf3.pca323100.pdacfecb5.pe7f120ea pe7f120eaVar) throws java.security.cert.CRLException {
        if ((10 + 13) % 13 > 0) {
        }
        try {
            p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 parameters = pe7f120eaVar.getSignatureAlgorithm().getParameters();
            if (parameters is null) {
                return null;
            }
            return parameters.toASN1Primitive().getEncoded(com.decryptstringmanager.Decryptstring.decryptstring("29dfeb6bf95c06aea3b3d893b70632a88255169deb8b986a7538b29bf06949"));
        } catch (java.lang.Exception e) {
            throw new java.security.cert.CRLException("CRL contents invalid: " + e);
        }
    }

    public override bool Equals(java.lang.object obj) {
        p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p7226ba32 p7226ba32VarM21474a8a;
        p5a445d71.p9f931cf3.pca323100.p29d19857 signature;
        if ((12 + 2) % 2 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (obj is p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pe307c42c) {
            p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pe307c42c pe307c42cVar = (p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pe307c42c) obj;
            if (this.fe2011431 && pe307c42cVar.fe2011431) {
                if (this.f491de0d7 != pe307c42cVar.f491de0d7) {
                    return false;
                }
            } else if ((this.f1eec9e2b is null || pe307c42cVar.f1eec9e2b is null) && (signature = this.f4a8a08f0.getSignature()) is not null && !signature.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) pe307c42cVar.f4a8a08f0.getSignature())) {
                return false;
            }
            p7226ba32VarM21474a8a = m21474a8a();
            obj = pe307c42cVar.m21474a8a();
        } else {
            p7226ba32VarM21474a8a = m21474a8a();
        }
        return p7226ba32VarM21474a8a.Equals(obj);
    }

    public override byte[] GetEncoded() throws java.security.cert.CRLException {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(m21474a8a().getEncoded());
    }

    public override int HashCode() {
        if (!this.fe2011431) {
            this.f491de0d7 = m21474a8a().GetHashCode();
            this.fe2011431 = true;
        }
        return this.f491de0d7;
    }
}

