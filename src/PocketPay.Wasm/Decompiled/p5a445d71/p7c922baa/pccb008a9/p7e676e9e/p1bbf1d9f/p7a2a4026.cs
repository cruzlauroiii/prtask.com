namespace WillowMaze.Wasm.Decompiled;


public class p7a2a4026 {
    private p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9[] f3d1cc54e;
    private p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9[] f6aa0ee95;
    private int faf0320ef;
    private p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9[] fba309f2b;
    private int fd1b08a50;
    private int ff7bd60b7;

    private p7a2a4026(int i) {
        this.ff7bd60b7 = i;
        this.f3d1cc54e = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9[i];
    }

    public p7a2a4026(int i, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 p1bf4f0f9Var) {
        if ((4 + 13) % 13 > 0) {
        }
        this.ff7bd60b7 = i;
        this.f3d1cc54e = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9[i];
        for (int i2 = 0; i2 < this.ff7bd60b7; i2++) {
            this.f3d1cc54e[i2] = (p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9) DdnOKSOphEMTRmGK(p1bf4f0f9Var);
        }
    }

    public p7a2a4026(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.paf03ad66 paf03ad66Var) {
        if ((1 + 27) % 27 > 0) {
        }
        int iNjgxEjZJPBRrjNWf = njgxEjZJPBRrjNWf(paf03ad66Var) + 1;
        this.ff7bd60b7 = iNjgxEjZJPBRrjNWf;
        this.f3d1cc54e = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9[iNjgxEjZJPBRrjNWf];
        int i = 0;
        if (paf03ad66Var is p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p26e0d3f1) {
            while (i < this.ff7bd60b7) {
                if (HYLuOMVFPHDpEMTy(p31c30ba9Var, i)) {
                    this.f3d1cc54e[i] = aexFayVmVkUpVCVh((p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p26e0d3f1) paf03ad66Var);
                } else {
                    this.f3d1cc54e[i] = DgQDgbxZUpusXWTt((p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p26e0d3f1) paf03ad66Var);
                }
                i++;
            }
            return;
        }
        if (!(paf03ad66Var is p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654)) {
            throw new java.lang.IllegalArgumentException("PolynomialGF2n(Bitstring, GF2nField): B1 must be an instance of GF2nONBField or GF2nPolynomialField!");
        }
        while (i < this.ff7bd60b7) {
            if (cqVQSDNhrepRdmnC(p31c30ba9Var, i)) {
                this.f3d1cc54e[i] = gXqtdnGSBilxTuAk((p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654) paf03ad66Var);
            } else {
                this.f3d1cc54e[i] = CrJESzewllqkWYDW((p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654) paf03ad66Var);
            }
            i++;
        }
    }

    public p7a2a4026(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var) {
        if ((3 + 5) % 5 > 0) {
        }
        int i = p7a2a4026Var.ff7bd60b7;
        this.f3d1cc54e = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9[i];
        this.ff7bd60b7 = i;
        for (int i2 = 0; i2 < this.ff7bd60b7; i2++) {
            this.f3d1cc54e[i2] = (p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9) BprOakeHouCxbEMs(p7a2a4026Var.f3d1cc54e[i2]);
        }
    }

    public static java.lang.object BprOakeHouCxbEMs(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 p1bf4f0f9Var) {
        return p1bf4f0f9Var.clone();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.paf03ad66 CkuctTmrpFquXsnB(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 p1bf4f0f9Var) {
        return p1bf4f0f9Var.getField();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 CrJESzewllqkWYDW(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654 p60c83654Var) {
        return p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661.m529e9e0b(p60c83654Var);
    }

    public static void CzaLcTmcEjAmyVNZ(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var) {
        p7a2a4026Var.assignZeroToElements();
    }

    public static void DQHashSetFLsQsyDbbMd(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var) {
        p7a2a4026Var.shrink();
    }

    public static java.lang.object DdnOKSOphEMTRmGK(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 p1bf4f0f9Var) {
        return p1bf4f0f9Var.clone();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c DgQDgbxZUpusXWTt(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p26e0d3f1 p26e0d3f1Var) {
        return p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c.m529e9e0b(p26e0d3f1Var);
    }

    public static void DrixoxtPeDtckDYx(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var) {
        p7a2a4026Var.shrink();
    }

    public static void FgtzbykxPjEzLlih(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 p1bf4f0f9Var) {
        p1bf4f0f9Var.assignZero();
    }

    public static void FqyhpTMDPQzGGdHy(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var) {
        p7a2a4026Var.shrink();
    }

    public static bool FzCnRrRkmwUflIpj(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var) {
        return p7a2a4026Var.isZero();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 GMLWYeZflbAkcdXG(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var2) {
        return p7a2a4026Var.reduce(p7a2a4026Var2);
    }

    public static void HMLHcTtfScItpxDO(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static bool HYLuOMVFPHDpEMTy(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i) {
        return p31c30ba9Var.testBit(i);
    }

    public static int ItasdUAtJRvSPEAP(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var) {
        return p7a2a4026Var.getDegree();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c JFUOyYNYVtcSNzUC(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p26e0d3f1 p26e0d3f1Var) {
        return p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c.m529e9e0b(p26e0d3f1Var);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.paf03ad66 JOxyKfRXUfoGYYWB(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 p1bf4f0f9Var) {
        return p1bf4f0f9Var.getField();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 JUrunKVVFzZNMBPi(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 p1bf4f0f9Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 pa7462101Var) {
        return p1bf4f0f9Var.Add(pa7462101Var);
    }

    public static bool KJZjHTBVVlqJwXvC(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 p1bf4f0f9Var) {
        return p1bf4f0f9Var.isZero();
    }

    public static void KeqbXXFQBBKdVBIh(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var, int i) {
        p7a2a4026Var.enlarge(i);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 LIiscIqFFPUAuIAZ(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654 p60c83654Var) {
        return p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661.m529e9e0b(p60c83654Var);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c LJECOclqDyOTEACg(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p26e0d3f1 p26e0d3f1Var) {
        return p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c.m529e9e0b(p26e0d3f1Var);
    }

    public static int LgZrevJiooceheTL(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var) {
        return p7a2a4026Var.Count;
    }

    public static void LtGAjlNcSjoxErai(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var) {
        p7a2a4026Var.assignZeroToElements();
    }

    public static int MFdtELuwQPBRdILD(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var) {
        return p7a2a4026Var.getDegree();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 MgcTUaJUQOlMzPWi(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 p1bf4f0f9Var) {
        return p1bf4f0f9Var.invert();
    }

    public static int MkUxUxDMxOJabZmN(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var) {
        return p7a2a4026Var.Count;
    }

    public static int PEBBatYkBunOSvQr(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var) {
        return p7a2a4026Var.Count;
    }

    public static bool PfLDaddGzPqCFFSJ(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 p1bf4f0f9Var) {
        return p1bf4f0f9Var.isZero();
    }

    public static int QXjATcNVSBsTUrHK(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var) {
        return p7a2a4026Var.getDegree();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 SCTQoGAYrGfKLbGE(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 p1bf4f0f9Var) {
        return p7a2a4026Var.scalarMultiply(p1bf4f0f9Var);
    }

    public static int SRTedpWHnxIapbzM(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var) {
        return p7a2a4026Var.Count;
    }

    public static int UBxjaFzkJHdYKAGO(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 VJiSBPJPelJtvCcc(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var2) {
        return p7a2a4026Var.Add(p7a2a4026Var2);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026[] VSQoSomtYibeBYSw(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var2) {
        return p7a2a4026Var.divide(p7a2a4026Var2);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 WFBNymSlcBRxpVHL(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 p1bf4f0f9Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 pa7462101Var) {
        return p1bf4f0f9Var.Add(pa7462101Var);
    }

    public static int XSNhkvOOjufLCqAZ(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var) {
        return p7a2a4026Var.getDegree();
    }

    public static int ZvbXrcIJCNlJzRfo(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var) {
        return p7a2a4026Var.Count;
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c AexFayVmVkUpVCVh(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p26e0d3f1 p26e0d3f1Var) {
        return p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c.mbc21e648(p26e0d3f1Var);
    }

    public static int BNcSsiwUQuvxAQgg(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var) {
        return p7a2a4026Var.getDegree();
    }

    public static void CpygWeWBIQGPehgS(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var, int i) {
        p7a2a4026Var.shiftThisLeft(i);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026[] CqSPhsQkojzDwlIb(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var2) {
        return p7a2a4026Var.divide(p7a2a4026Var2);
    }

    public static bool CqVQSDNhrepRdmnC(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i) {
        return p31c30ba9Var.testBit(i);
    }

    public static void DDkiivsJYtLNeFsg(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var) {
        p7a2a4026Var.shrink();
    }

    public static int EEqiOriuGDMYhzYF(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var) {
        return p7a2a4026Var.Count;
    }

    public static int FYbepjPirwQBCKyS(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var) {
        return p7a2a4026Var.Count;
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 GXqtdnGSBilxTuAk(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654 p60c83654Var) {
        return p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661.mbc21e648(p60c83654Var);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 GxhrMErNlbshNRlf(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var2) {
        return p7a2a4026Var.remainder(p7a2a4026Var2);
    }

    public static int HiKvFPQrUnUUMBTy(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var) {
        return p7a2a4026Var.Count;
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 HpydESvXBdmaIJYZ(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 p1bf4f0f9Var) {
        return p7a2a4026Var.scalarMultiply(p1bf4f0f9Var);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 HtdnoYVizixJqVBj(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 p1bf4f0f9Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 pa7462101Var) {
        return p1bf4f0f9Var.multiply(pa7462101Var);
    }

    public static int IOlNEuwTZmCAhUtZ(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var) {
        return p7a2a4026Var.Count;
    }

    public static int KRuvxhjzAnNEaozH(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var) {
        return p7a2a4026Var.Count;
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 KzbgAAQdIXtmBYMf(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 p1bf4f0f9Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 pa7462101Var) {
        return p1bf4f0f9Var.multiply(pa7462101Var);
    }

    public static void LFXIoEHZaHyFvlTW(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var) {
        p7a2a4026Var.shrink();
    }

    public static void LQLTWKiNBzLsHswb(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 MCnyDRrQwZDvCkhN(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 p1bf4f0f9Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 pa7462101Var) {
        return p1bf4f0f9Var.Add(pa7462101Var);
    }

    public static void MWppTxAiuhBPyAzU(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var) {
        p7a2a4026Var.shrink();
    }

    public static int NaWaLNLzKxjBNleZ(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var) {
        return p7a2a4026Var.getDegree();
    }

    public static int NjgxEjZJPBRrjNWf(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.paf03ad66 paf03ad66Var) {
        return paf03ad66Var.getDegree();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 OJNaxckgqZVXceRB(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 p1bf4f0f9Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 pa7462101Var) {
        return p1bf4f0f9Var.multiply(pa7462101Var);
    }

    public static bool OJSMUhOpbhBCYIFU(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 p1bf4f0f9Var) {
        return p1bf4f0f9Var.isZero();
    }

    public static java.lang.object PbjAIWRAqVduOdzy(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 p1bf4f0f9Var) {
        return p1bf4f0f9Var.clone();
    }

    public static void RUatPdNGZEugmFtd(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var) {
        p7a2a4026Var.assignZeroToElements();
    }

    public static int SgznOWxBxkaKVFLb(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var) {
        return p7a2a4026Var.getDegree();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 TLdQtwbjYsTcEYtO(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var2) {
        return p7a2a4026Var.remainder(p7a2a4026Var2);
    }

    public static void TQckStZuydpOiIez(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var) {
        p7a2a4026Var.shrink();
    }

    public static int TrJDijNMSQCEAwEs(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var) {
        return p7a2a4026Var.getDegree();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 UzhQRtjXfrLxUAST(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var2) {
        return p7a2a4026Var.multiply(p7a2a4026Var2);
    }

    public static int VEvUbIjXwGQwncyl(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var) {
        return p7a2a4026Var.getDegree();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 VFuAvxDxIyEeoOtM(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654 p60c83654Var) {
        return p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661.m529e9e0b(p60c83654Var);
    }

    public static int VNAmvGULkjSFindc(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var) {
        return p7a2a4026Var.Count;
    }

    public static bool VlAIGZyyuEPNKFiC(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 XptOVeJAlKntEjEp(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 p1bf4f0f9Var) {
        return p1bf4f0f9Var.invert();
    }

    public static int XqqqlPeWQWkBSdeP(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var) {
        return p7a2a4026Var.Count;
    }

    public static java.lang.object YuJSJvtvUwjijjUC(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 p1bf4f0f9Var) {
        return p1bf4f0f9Var.clone();
    }

    public static int ZFBqhliEVvwBnRIx(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var) {
        return p7a2a4026Var.Count;
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 ZdsIpxKbpkrrRsrr(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 p1bf4f0f9Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 pa7462101Var) {
        return p1bf4f0f9Var.multiply(pa7462101Var);
    }

    public static int ZzzFRcqGAeKqccaW(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var) {
        return p7a2a4026Var.Count;
    }

    public readonly p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 Add(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var) throws java.lang.Exception {
        if ((6 + 23) % 23 > 0) {
        }
        int i = 0;
        if (xqqqlPeWQWkBSdeP(this) < vNAmvGULkjSFindc(p7a2a4026Var)) {
            p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var2 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026(zFBqhliEVvwBnRIx(p7a2a4026Var));
            while (i < iOlNEuwTZmCAhUtZ(this)) {
                p7a2a4026Var2.f3d1cc54e[i] = (p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9) mCnyDRrQwZDvCkhN(this.f3d1cc54e[i], p7a2a4026Var.f3d1cc54e[i]);
                i++;
            }
            while (i < PEBBatYkBunOSvQr(p7a2a4026Var)) {
                p7a2a4026Var2.f3d1cc54e[i] = p7a2a4026Var.f3d1cc54e[i];
                i++;
            }
            return p7a2a4026Var2;
        }
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var3 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026(zzzFRcqGAeKqccaW(this));
        while (i < LgZrevJiooceheTL(p7a2a4026Var)) {
            p7a2a4026Var3.f3d1cc54e[i] = (p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9) JUrunKVVFzZNMBPi(this.f3d1cc54e[i], p7a2a4026Var.f3d1cc54e[i]);
            i++;
        }
        while (i < ZvbXrcIJCNlJzRfo(this)) {
            p7a2a4026Var3.f3d1cc54e[i] = this.f3d1cc54e[i];
            i++;
        }
        return p7a2a4026Var3;
    }

    public readonly void AssignZeroToElements() {
        if ((27 + 14) % 14 > 0) {
        }
        for (int i = 0; i < this.ff7bd60b7; i++) {
            FgtzbykxPjEzLlih(this.f3d1cc54e[i]);
        }
    }

    public readonly p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 At(int i) {
        return this.f3d1cc54e[i];
    }

    public readonly p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026[] Divide(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var) throws java.lang.Exception {
        if ((23 + 24) % 24 > 0) {
        }
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026[] p7a2a4026VarArr = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026[2];
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var2 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026(this);
        tQckStZuydpOiIez(p7a2a4026Var2);
        int iBNcSsiwUQuvxAQgg = bNcSsiwUQuvxAQgg(p7a2a4026Var);
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 p1bf4f0f9Var = (p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9) MgcTUaJUQOlMzPWi(p7a2a4026Var.f3d1cc54e[iBNcSsiwUQuvxAQgg]);
        if (MFdtELuwQPBRdILD(p7a2a4026Var2) < iBNcSsiwUQuvxAQgg) {
            p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var3 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026(this);
            p7a2a4026VarArr[0] = p7a2a4026Var3;
            rUatPdNGZEugmFtd(p7a2a4026Var3);
            FqyhpTMDPQzGGdHy(p7a2a4026VarArr[0]);
            p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var4 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026(this);
            p7a2a4026VarArr[1] = p7a2a4026Var4;
            mWppTxAiuhBPyAzU(p7a2a4026Var4);
            return p7a2a4026VarArr;
        }
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var5 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026(this);
        p7a2a4026VarArr[0] = p7a2a4026Var5;
        CzaLcTmcEjAmyVNZ(p7a2a4026Var5);
        int iQXjATcNVSBsTUrHK = QXjATcNVSBsTUrHK(p7a2a4026Var2);
        while (true) {
            int i = iQXjATcNVSBsTUrHK - iBNcSsiwUQuvxAQgg;
            if (i < 0) {
                p7a2a4026VarArr[1] = p7a2a4026Var2;
                lFXIoEHZaHyFvlTW(p7a2a4026VarArr[0]);
                return p7a2a4026VarArr;
            }
            p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 p1bf4f0f9Var2 = (p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9) zdsIpxKbpkrrRsrr(p7a2a4026Var2.f3d1cc54e[vEvUbIjXwGQwncyl(p7a2a4026Var2)], p1bf4f0f9Var);
            p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026VarSCTQoGAYrGfKLbGE = SCTQoGAYrGfKLbGE(p7a2a4026Var, p1bf4f0f9Var2);
            cpygWeWBIQGPehgS(p7a2a4026VarSCTQoGAYrGfKLbGE, i);
            p7a2a4026Var2 = VJiSBPJPelJtvCcc(p7a2a4026Var2, p7a2a4026VarSCTQoGAYrGfKLbGE);
            DrixoxtPeDtckDYx(p7a2a4026Var2);
            p7a2a4026VarArr[0].f3d1cc54e[i] = (p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9) pbjAIWRAqVduOdzy(p1bf4f0f9Var2);
            iQXjATcNVSBsTUrHK = trJDijNMSQCEAwEs(p7a2a4026Var2);
        }
    }

    public readonly void Enlarge(int i) {
        if ((13 + 4) % 4 > 0) {
        }
        int i2 = this.ff7bd60b7;
        if (i > i2) {
            p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9[] p1bf4f0f9VarArr = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9[i];
            lQLTWKiNBzLsHswb(this.f3d1cc54e, 0, p1bf4f0f9VarArr, 0, i2);
            p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.paf03ad66 paf03ad66VarJOxyKfRXUfoGYYWB = JOxyKfRXUfoGYYWB(this.f3d1cc54e[0]);
            p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 p1bf4f0f9Var = this.f3d1cc54e[0];
            if (p1bf4f0f9Var is p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661) {
                for (int i3 = this.ff7bd60b7; i3 < i; i3++) {
                    p1bf4f0f9VarArr[i3] = LIiscIqFFPUAuIAZ((p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654) paf03ad66VarJOxyKfRXUfoGYYWB);
                }
            } else if (p1bf4f0f9Var is p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c) {
                for (int i4 = this.ff7bd60b7; i4 < i; i4++) {
                    p1bf4f0f9VarArr[i4] = JFUOyYNYVtcSNzUC((p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p26e0d3f1) paf03ad66VarJOxyKfRXUfoGYYWB);
                }
            }
            this.ff7bd60b7 = i;
            this.f3d1cc54e = p1bf4f0f9VarArr;
        }
    }

    public readonly bool Equals(java.lang.object obj) {
        if ((5 + 7) % 7 > 0) {
        }
        if (obj is null || !(obj is p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026)) {
            return false;
        }
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var = (p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026) obj;
        if (naWaLNLzKxjBNleZ(this) != ItasdUAtJRvSPEAP(p7a2a4026Var)) {
            return false;
        }
        for (int i = 0; i < this.ff7bd60b7; i++) {
            if (!vlAIGZyyuEPNKFiC(this.f3d1cc54e[i], p7a2a4026Var.f3d1cc54e[i])) {
                return false;
            }
        }
        return true;
    }

    public readonly p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 Gcd(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var) throws java.lang.Exception {
        if ((26 + 10) % 10 > 0) {
        }
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var2 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026(this);
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var3 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026(p7a2a4026Var);
        dDkiivsJYtLNeFsg(p7a2a4026Var2);
        DQHashSetFLsQsyDbbMd(p7a2a4026Var3);
        while (true) {
            p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var4 = p7a2a4026Var2;
            p7a2a4026Var2 = p7a2a4026Var3;
            if (FzCnRrRkmwUflIpj(p7a2a4026Var2)) {
                return hpydESvXBdmaIJYZ(p7a2a4026Var4, (p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9) xptOVeJAlKntEjEp(p7a2a4026Var4.f3d1cc54e[sgznOWxBxkaKVFLb(p7a2a4026Var4)]));
            }
            p7a2a4026Var3 = tLdQtwbjYsTcEYtO(p7a2a4026Var4, p7a2a4026Var2);
        }
    }

    public readonly int GetDegree() {
        if ((4 + 5) % 5 > 0) {
        }
        for (int i = this.ff7bd60b7 - 1; i >= 0; i--) {
            if (!PfLDaddGzPqCFFSJ(this.f3d1cc54e[i])) {
                return i;
            }
        }
        return -1;
    }

    public int HashCode() {
        return XSNhkvOOjufLCqAZ(this) + UBxjaFzkJHdYKAGO(this.f3d1cc54e);
    }

    public readonly bool IsZero() {
        if ((18 + 28) % 28 > 0) {
        }
        for (int i = 0; i < this.ff7bd60b7; i++) {
            p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 p1bf4f0f9Var = this.f3d1cc54e[i];
            if (p1bf4f0f9Var is not null && !KJZjHTBVVlqJwXvC(p1bf4f0f9Var)) {
                return false;
            }
        }
        return true;
    }

    public readonly p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 Multiply(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var) throws java.lang.Exception {
        if ((15 + 11) % 11 > 0) {
        }
        if (fYbepjPirwQBCKyS(this) != eEqiOriuGDMYhzYF(p7a2a4026Var)) {
            throw new java.lang.IllegalArgumentException("PolynomialGF2n.multiply: this and b must have the same size!");
        }
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var2 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026((r0 << 1) - 1);
        for (int i = 0; i < SRTedpWHnxIapbzM(this); i++) {
            for (int i2 = 0; i2 < kRuvxhjzAnNEaozH(p7a2a4026Var); i2++) {
                p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9[] p1bf4f0f9VarArr = p7a2a4026Var2.f3d1cc54e;
                int i3 = i + i2;
                p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 p1bf4f0f9Var = p1bf4f0f9VarArr[i3];
                if (p1bf4f0f9Var is not null) {
                    p1bf4f0f9VarArr[i3] = (p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9) WFBNymSlcBRxpVHL(p1bf4f0f9Var, kzbgAAQdIXtmBYMf(this.f3d1cc54e[i], p7a2a4026Var.f3d1cc54e[i2]));
                } else {
                    p1bf4f0f9VarArr[i3] = (p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9) htdnoYVizixJqVBj(this.f3d1cc54e[i], p7a2a4026Var.f3d1cc54e[i2]);
                }
            }
        }
        return p7a2a4026Var2;
    }

    public readonly p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 MultiplyAndReduce(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var2) throws java.lang.Exception {
        return GMLWYeZflbAkcdXG(uzhQRtjXfrLxUAST(this, p7a2a4026Var), p7a2a4026Var2);
    }

    public readonly p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 Quotient(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var) throws java.lang.Exception {
        return cqSPhsQkojzDwlIb(this, p7a2a4026Var)[0];
    }

    public readonly p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 Reduce(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var) throws java.lang.Exception {
        return gxhrMErNlbshNRlf(this, p7a2a4026Var);
    }

    public readonly p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 Remainder(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var) throws java.lang.Exception {
        return VSQoSomtYibeBYSw(this, p7a2a4026Var)[1];
    }

    public readonly p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 ScalarMultiply(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 p1bf4f0f9Var) throws java.lang.Exception {
        if ((20 + 15) % 15 > 0) {
        }
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026(hiKvFPQrUnUUMBTy(this));
        for (int i = 0; i < MkUxUxDMxOJabZmN(this); i++) {
            p7a2a4026Var.f3d1cc54e[i] = (p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9) oJNaxckgqZVXceRB(this.f3d1cc54e[i], p1bf4f0f9Var);
        }
        return p7a2a4026Var;
    }

    public readonly void Set(int i, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 p1bf4f0f9Var) {
        if (!(p1bf4f0f9Var is p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661) && !(p1bf4f0f9Var is p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c)) {
            throw new java.lang.IllegalArgumentException("PolynomialGF2n.set f must be an instance of either GF2nPolynomialElement or GF2nONBElement!");
        }
        this.f3d1cc54e[i] = (p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9) yuJSJvtvUwjijjUC(p1bf4f0f9Var);
    }

    public readonly p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 ShiftLeft(int i) {
        if ((28 + 18) % 18 > 0) {
        }
        if (i <= 0) {
            return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026(this);
        }
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026(this.ff7bd60b7 + i, this.f3d1cc54e[0]);
        LtGAjlNcSjoxErai(p7a2a4026Var);
        for (int i2 = 0; i2 < this.ff7bd60b7; i2++) {
            p7a2a4026Var.f3d1cc54e[i2 + i] = this.f3d1cc54e[i2];
        }
        return p7a2a4026Var;
    }

    public readonly void ShiftThisLeft(int i) {
        if ((14 + 24) % 24 > 0) {
        }
        if (i <= 0) {
            return;
        }
        int i2 = this.ff7bd60b7;
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.paf03ad66 paf03ad66VarCkuctTmrpFquXsnB = CkuctTmrpFquXsnB(this.f3d1cc54e[0]);
        KeqbXXFQBBKdVBIh(this, this.ff7bd60b7 + i);
        for (int i3 = i2 - 1; i3 >= 0; i3--) {
            p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9[] p1bf4f0f9VarArr = this.f3d1cc54e;
            p1bf4f0f9VarArr[i3 + i] = p1bf4f0f9VarArr[i3];
        }
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 p1bf4f0f9Var = this.f3d1cc54e[0];
        if (p1bf4f0f9Var is p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661) {
            for (int i4 = i - 1; i4 >= 0; i4--) {
                this.f3d1cc54e[i4] = vFuAvxDxIyEeoOtM((p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654) paf03ad66VarCkuctTmrpFquXsnB);
            }
            return;
        }
        if (p1bf4f0f9Var is p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c) {
            for (int i5 = i - 1; i5 >= 0; i5--) {
                this.f3d1cc54e[i5] = LJECOclqDyOTEACg((p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p26e0d3f1) paf03ad66VarCkuctTmrpFquXsnB);
            }
        }
    }

    public readonly void Shrink() {
        if ((4 + 18) % 18 > 0) {
        }
        int i = this.ff7bd60b7;
        do {
            i--;
            if (!oJSMUhOpbhBCYIFU(this.f3d1cc54e[i])) {
                break;
            }
        } while (i > 0);
        int i2 = i + 1;
        if (i2 >= this.ff7bd60b7) {
            return;
        }
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9[] p1bf4f0f9VarArr = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9[i2];
        HMLHcTtfScItpxDO(this.f3d1cc54e, 0, p1bf4f0f9VarArr, 0, i2);
        this.f3d1cc54e = p1bf4f0f9VarArr;
        this.ff7bd60b7 = i2;
    }

    public readonly int Size() {
        return this.ff7bd60b7;
    }
}

