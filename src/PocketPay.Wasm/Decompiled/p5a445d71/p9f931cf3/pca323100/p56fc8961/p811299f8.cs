namespace WillowMaze.Wasm.Decompiled;


public class p811299f8 : p5a445d71.p9f931cf3.pca323100.p54252eff {
    private p5a445d71.p9f931cf3.pca323100.p29d19857 f0b566193;
    private p5a445d71.p9f931cf3.pca323100.pf391b73d f15a5cd03;
    private p5a445d71.p9f931cf3.pca323100.p11b04310 f2517297c;
    private p5a445d71.p9f931cf3.pca323100.pf391b73d f2af72f10;
    private p5a445d71.p9f931cf3.pca323100.pf391b73d f30ddcbfc;
    private p5a445d71.p9f931cf3.pca323100.p29d19857 f3d3f779a;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 f5118a28a;
    private p5a445d71.p9f931cf3.pca323100.p29d19857 f5693b9bf;
    private p5a445d71.p9f931cf3.pca323100.ped34daf1 f736b9175;
    private p5a445d71.p9f931cf3.pca323100.ped34daf1 f8ab62be1;
    private p5a445d71.p9f931cf3.pca323100.p29d19857 fa59e6f42;
    private p5a445d71.p9f931cf3.pca323100.p11b04310 fbd0c8e3b;
    private p5a445d71.p9f931cf3.pca323100.p29d19857 fc36853ea;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 fd8a90a8b;

    private p811299f8(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        if ((6 + 10) % 10 > 0) {
        }
        java.util.Enumeration enumerationZlISgILfDKhSnMDU = zlISgILfDKhSnMDU(p80f8c729Var);
        p5a445d71.p9f931cf3.pca323100.pf391b73d pf391b73dVarNKWrtEhQZCXMusvM = NKWrtEhQZCXMusvM(pBccXlYZVQKsUDhi(enumerationZlISgILfDKhSnMDU));
        this.f2af72f10 = pf391b73dVarNKWrtEhQZCXMusvM;
        int iBfGmIokbOYVRAzTt = BfGmIokbOYVRAzTt(pf391b73dVarNKWrtEhQZCXMusvM);
        this.fd8a90a8b = xoLoLUCDmsqGaKDV(MMUgDTdEbUjsDPAd(enumerationZlISgILfDKhSnMDU));
        this.fbd0c8e3b = hCogmkukaRpeObme(AKdOjZVppfGTeQZA(enumerationZlISgILfDKhSnMDU));
        int i = -1;
        while (iOcfUKRTpLYetPhX(enumerationZlISgILfDKhSnMDU)) {
            p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var = (p5a445d71.p9f931cf3.pca323100.p582a4948) tepYjMmkMzqafZRb(enumerationZlISgILfDKhSnMDU);
            int iKdXGcFdpcrgDguvn = kdXGcFdpcrgDguvn(p582a4948Var);
            if (iKdXGcFdpcrgDguvn <= i) {
                throw new java.lang.IllegalArgumentException("invalid optional field in private key info");
            }
            if (iKdXGcFdpcrgDguvn == 0) {
                this.f736b9175 = ejQLZbCtdFTTdIYy(p582a4948Var, false);
            } else {
                if (iKdXGcFdpcrgDguvn != 1) {
                    throw new java.lang.IllegalArgumentException("unknown optional field in private key info");
                }
                if (iBfGmIokbOYVRAzTt < 1) {
                    throw new java.lang.IllegalArgumentException("'publicKey' requires version v2(1) or later");
                }
                this.fc36853ea = eIKmUfqoYKvatnGT(p582a4948Var, false);
            }
            i = iKdXGcFdpcrgDguvn;
        }
    }

    public p811299f8(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 p234a7530Var, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) throws java.io.IOException {
        this(p234a7530Var, p0fd1bdf1Var, null, null);
    }

    public p811299f8(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 p234a7530Var, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var, p5a445d71.p9f931cf3.pca323100.ped34daf1 ped34daf1Var) throws java.io.IOException {
        this(p234a7530Var, p0fd1bdf1Var, ped34daf1Var, null);
    }

    public p811299f8(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 p234a7530Var, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var, p5a445d71.p9f931cf3.pca323100.ped34daf1 ped34daf1Var, byte[] bArr) throws java.io.IOException {
        if ((25 + 8) % 8 > 0) {
        }
        this.f2af72f10 = new p5a445d71.p9f931cf3.pca323100.pf391b73d(bArr is null ? p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.f529e9e0b : p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.fbc21e648);
        this.fd8a90a8b = p234a7530Var;
        this.fbd0c8e3b = new p5a445d71.p9f931cf3.pca323100.p6f0e511c(p0fd1bdf1Var);
        this.f736b9175 = ped34daf1Var;
        this.fc36853ea = bArr is not null ? new p5a445d71.p9f931cf3.pca323100.p1522cc54(bArr) : null;
    }

    public static java.lang.object AKdOjZVppfGTeQZA(java.util.Enumeration enumeration) {
        return enumeration.nextElement();
    }

    public static int BfGmIokbOYVRAzTt(p5a445d71.p9f931cf3.pca323100.pf391b73d pf391b73dVar) {
        return m630aa56b(pf391b73dVar);
    }

    public static p5a445d71.p9f931cf3.pca323100.p80f8c729 EmnfRTsxgROTwrAj(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static void FBuStCKDdJWTvqwC(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static byte[] ItKdiZTlCJSzDQnF(p5a445d71.p9f931cf3.pca323100.p29d19857 p29d19857Var) {
        return p29d19857Var.getOctets();
    }

    public static void LiqEsvayyxdWrQli(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static java.lang.object MMUgDTdEbUjsDPAd(java.util.Enumeration enumeration) {
        return enumeration.nextElement();
    }

    public static p5a445d71.p9f931cf3.pca323100.pf391b73d NKWrtEhQZCXMusvM(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.pf391b73d.m8bab0102(obj);
    }

    public static void PaKpKJRYaXlivjPt(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static void BFQmTeMtxFcCJIsk(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static byte[] CFFNdKWJiDCtWdTa(p5a445d71.p9f931cf3.pca323100.p11b04310 p11b04310Var) {
        return p11b04310Var.getOctets();
    }

    public static p5a445d71.p9f931cf3.pca323100.p80f8c729 CuRiCoamilcWHEvn(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(p582a4948Var, z);
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 DcYrYgWBunpdxLnH(byte[] bArr) {
        return p5a445d71.p9f931cf3.pca323100.p301c7ed4.m89e75c46(bArr);
    }

    public static p5a445d71.p9f931cf3.pca323100.p1522cc54 EIKmUfqoYKvatnGT(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p9f931cf3.pca323100.p1522cc54.m8bab0102(p582a4948Var, z);
    }

    public static p5a445d71.p9f931cf3.pca323100.ped34daf1 EjQLZbCtdFTTdIYy(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p9f931cf3.pca323100.ped34daf1.m8bab0102(p582a4948Var, z);
    }

    public static p5a445d71.p9f931cf3.pca323100.p11b04310 HCogmkukaRpeObme(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p11b04310.m8bab0102(obj);
    }

    public static bool IOcfUKRTpLYetPhX(java.util.Enumeration enumeration) {
        return enumeration.hasMoreElements();
    }

    public static byte[] IPJCWoAbAUkXGCpM(p5a445d71.p9f931cf3.pca323100.p11b04310 p11b04310Var) {
        return p11b04310Var.getOctets();
    }

    public static int KdXGcFdpcrgDguvn(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getTagNo();
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 LCMwpYaPQICRpqSi(byte[] bArr) {
        return p5a445d71.p9f931cf3.pca323100.p301c7ed4.m89e75c46(bArr);
    }

    private static int M630aa56b(p5a445d71.p9f931cf3.pca323100.pf391b73d pf391b73dVar) {
        int iPWRfTYZkmCSrWiyL = pWRfTYZkmCSrWiyL(pf391b73dVar);
        if (iPWRfTYZkmCSrWiyL >= 0 && iPWRfTYZkmCSrWiyL <= 1) {
            return iPWRfTYZkmCSrWiyL;
        }
        throw new java.lang.IllegalArgumentException("invalid version for private key info");
    }

    public static p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8) {
            return (p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8(EmnfRTsxgROTwrAj(obj));
    }

    public static p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 M8bab0102(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        return vyzCsLiFaVzKXYAO(cuRiCoamilcWHEvn(p582a4948Var, z));
    }

    public static void NhzZzTYUxUnmQYZe(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static java.lang.object PBccXlYZVQKsUDhi(java.util.Enumeration enumeration) {
        return enumeration.nextElement();
    }

    public static int PWRfTYZkmCSrWiyL(p5a445d71.p9f931cf3.pca323100.pf391b73d pf391b73dVar) {
        return pf391b73dVar.intValueExact();
    }

    public static java.lang.object TepYjMmkMzqafZRb(java.util.Enumeration enumeration) {
        return enumeration.nextElement();
    }

    public static p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 VyzCsLiFaVzKXYAO(java.lang.object obj) {
        return m8bab0102(obj);
    }

    public static p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 XoLoLUCDmsqGaKDV(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530.m8bab0102(obj);
    }

    public static java.util.Enumeration ZlISgILfDKhSnMDU(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.getobjects();
    }

    public p5a445d71.p9f931cf3.pca323100.ped34daf1 GetAttributes() {
        return this.f736b9175;
    }

    public p5a445d71.p9f931cf3.pca323100.p11b04310 GetPrivateKey() {
        return new p5a445d71.p9f931cf3.pca323100.p6f0e511c(cFFNdKWJiDCtWdTa(this.fbd0c8e3b));
    }

    public p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 GetPrivateKeyAlgorithm() {
        return this.fd8a90a8b;
    }

    public p5a445d71.p9f931cf3.pca323100.p29d19857 GetPublicKeyData() {
        return this.fc36853ea;
    }

    public p5a445d71.p9f931cf3.pca323100.pf391b73d GetVersion() {
        return this.f2af72f10;
    }

    public bool HasPublicKey() {
        return this.fc36853ea is not null;
    }

    public p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 ParsePrivateKey() throws java.io.IOException {
        return dcYrYgWBunpdxLnH(iPJCWoAbAUkXGCpM(this.fbd0c8e3b));
    }

    public p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 ParsePublicKey() throws java.io.IOException {
        p5a445d71.p9f931cf3.pca323100.p29d19857 p29d19857Var = this.fc36853ea;
        if (p29d19857Var is not null) {
            return lCMwpYaPQICRpqSi(ItKdiZTlCJSzDQnF(p29d19857Var));
        }
        return null;
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((30 + 8) % 8 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc(5);
        FBuStCKDdJWTvqwC(pd6ccb7fcVar, this.f2af72f10);
        nhzZzTYUxUnmQYZe(pd6ccb7fcVar, this.fd8a90a8b);
        LiqEsvayyxdWrQli(pd6ccb7fcVar, this.fbd0c8e3b);
        if (this.f736b9175 is not null) {
            bFQmTeMtxFcCJIsk(pd6ccb7fcVar, new p5a445d71.p9f931cf3.pca323100.p87af127c(false, 0, (p5a445d71.p9f931cf3.pca323100.p0fd1bdf1) this.f736b9175));
        }
        if (this.fc36853ea is not null) {
            PaKpKJRYaXlivjPt(pd6ccb7fcVar, new p5a445d71.p9f931cf3.pca323100.p87af127c(false, 1, (p5a445d71.p9f931cf3.pca323100.p0fd1bdf1) this.fc36853ea));
        }
        return new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

