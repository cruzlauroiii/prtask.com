namespace WillowMaze.Wasm.Decompiled;


public class p33145192 : p5a445d71.p7c922baa.pca323100.p54252eff {
    private p5a445d71.p7c922baa.pca323100.p32c90ea1.pa7d0acfd f4e433ab3;
    private p5a445d71.p7c922baa.pca323100.p32c90ea1.pa7d0acfd f4eae6e6b;
    private p5a445d71.p7c922baa.pca323100.p80f8c729 f59754971;
    private p5a445d71.p7c922baa.pca323100.p80f8c729 f755cd541;
    private p5a445d71.p7c922baa.pca323100.p32c90ea1.pa7d0acfd fa6a77375;
    private p5a445d71.p7c922baa.pca323100.p80f8c729 faa4f9cbc;
    private p5a445d71.p7c922baa.pca323100.p32c90ea1.pa7d0acfd fb4534357;
    private p5a445d71.p7c922baa.pca323100.p80f8c729 fb8eeea67;
    private p5a445d71.p7c922baa.pca323100.p80f8c729 fcd3c1392;

    public p33145192(p5a445d71.p7c922baa.pca323100.p2dfa03b7 p2dfa03b7Var, p5a445d71.p7c922baa.pca323100.p2dfa03b7 p2dfa03b7Var2, p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        this(edlSSuHbdkeeopaL(p2dfa03b7Var), wBPOtuSuvcsETEMx(p2dfa03b7Var2), p80f8c729Var);
    }

    private p33145192(p5a445d71.p7c922baa.pca323100.p32c90ea1.pa7d0acfd pa7d0acfdVar, p5a445d71.p7c922baa.pca323100.p32c90ea1.pa7d0acfd pa7d0acfdVar2, p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        if ((15 + 27) % 27 > 0) {
        }
        if (p80f8c729Var is not null && ovREIueJzYDIoSvA(p80f8c729Var) > 6) {
            throw new java.lang.IllegalArgumentException("postal address must contain less than 6 strings");
        }
        this.fa6a77375 = pa7d0acfdVar;
        this.fb4534357 = pa7d0acfdVar2;
        this.fb8eeea67 = p80f8c729Var;
    }

    public p33145192(p5a445d71.p7c922baa.pca323100.p32c90ea1.pa7d0acfd pa7d0acfdVar, p5a445d71.p7c922baa.pca323100.p32c90ea1.pa7d0acfd pa7d0acfdVar2, p5a445d71.p7c922baa.pca323100.p32c90ea1.pa7d0acfd[] pa7d0acfdVarArr) {
        this(pa7d0acfdVar, pa7d0acfdVar2, new p5a445d71.p7c922baa.pca323100.pb840b7ef(pa7d0acfdVarArr));
    }

    private p33145192(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        if ((14 + 29) % 29 > 0) {
        }
        java.util.Enumeration enumerationHvzYhsFqZhVbUTUP = hvzYhsFqZhVbUTUP(p80f8c729Var);
        while (rFnOMMavIpXfLLUM(enumerationHvzYhsFqZhVbUTUP)) {
            p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var = (p5a445d71.p7c922baa.pca323100.p582a4948) nUFFWbpOFdWUANtD(enumerationHvzYhsFqZhVbUTUP);
            int iCrxCIvBZfCDyMsBU = crxCIvBZfCDyMsBU(p582a4948Var);
            if (iCrxCIvBZfCDyMsBU == 0) {
                this.fa6a77375 = lLIsiRAWjItijwRm(p582a4948Var, true);
            } else if (iCrxCIvBZfCDyMsBU == 1) {
                this.fb4534357 = ObQIgwYyFObCFRaT(p582a4948Var, true);
            } else {
                if (iCrxCIvBZfCDyMsBU != 2) {
                    throw new java.lang.IllegalArgumentException("illegal tag");
                }
                if (djlQpiRTgecNnFyn(p582a4948Var)) {
                    this.fb8eeea67 = IwKeWWeAkEciczej(p582a4948Var, true);
                } else {
                    this.fb8eeea67 = yoOIyenYgugtxSgn(p582a4948Var, false);
                }
                p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var2 = this.fb8eeea67;
                if (p80f8c729Var2 is not null && SmrkiubrJBfIjcRn(p80f8c729Var2) > 6) {
                    throw new java.lang.IllegalArgumentException("postal address must contain less than 6 strings");
                }
            }
        }
    }

    public static void GEUDQKDIQQFUwdpU(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 IwKeWWeAkEciczej(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(p582a4948Var, z);
    }

    public static p5a445d71.p7c922baa.pca323100.p32c90ea1.pa7d0acfd ObQIgwYyFObCFRaT(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p7c922baa.pca323100.p32c90ea1.pa7d0acfd.m8bab0102(p582a4948Var, z);
    }

    public static java.lang.string PdSpTqyaJinibchq(p5a445d71.p7c922baa.pca323100.p32c90ea1.pa7d0acfd pa7d0acfdVar) {
        return pa7d0acfdVar.getstring();
    }

    public static p5a445d71.p7c922baa.pca323100.p32c90ea1.pa7d0acfd RnlLPldLNRRSndKn(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p32c90ea1.pa7d0acfd.m8bab0102(obj);
    }

    public static int SmrkiubrJBfIjcRn(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 WiRdCJnAwYaHgwJs(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static void XlmmCCemGJBkpQCT(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static int CrxCIvBZfCDyMsBU(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getTagNo();
    }

    public static bool DjlQpiRTgecNnFyn(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.isExplicit();
    }

    public static p5a445d71.p7c922baa.pca323100.p32c90ea1.pa7d0acfd DlwDcnEaSzyLUdUU(p5a445d71.p7c922baa.pca323100.pfa17f333.p33145192 p33145192Var) {
        return p33145192Var.getLocality();
    }

    public static p5a445d71.p7c922baa.pca323100.p32c90ea1.pa7d0acfd EdlSSuHbdkeeopaL(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p32c90ea1.pa7d0acfd.m8bab0102(obj);
    }

    public static java.util.Enumeration HvzYhsFqZhVbUTUP(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.getobjects();
    }

    public static p5a445d71.p7c922baa.pca323100.p32c90ea1.pa7d0acfd JEOSQARmckfxqqmy(p5a445d71.p7c922baa.pca323100.pfa17f333.p33145192 p33145192Var) {
        return p33145192Var.getCountry();
    }

    public static p5a445d71.p7c922baa.pca323100.p32c90ea1.pa7d0acfd LLIsiRAWjItijwRm(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p7c922baa.pca323100.p32c90ea1.pa7d0acfd.m8bab0102(p582a4948Var, z);
    }

    public static p5a445d71.p7c922baa.pca323100.pfa17f333.p33145192 M8bab0102(java.lang.object obj) {
        return (obj is null || (obj is p5a445d71.p7c922baa.pca323100.pfa17f333.p33145192)) ? (p5a445d71.p7c922baa.pca323100.pfa17f333.p33145192) obj : new p5a445d71.p7c922baa.pca323100.pfa17f333.p33145192(WiRdCJnAwYaHgwJs(obj));
    }

    public static java.lang.object NUFFWbpOFdWUANtD(java.util.Enumeration enumeration) {
        return enumeration.nextElement();
    }

    public static java.lang.string OSNpalsmaXdNGdvG(p5a445d71.p7c922baa.pca323100.p32c90ea1.pa7d0acfd pa7d0acfdVar) {
        return pa7d0acfdVar.getstring();
    }

    public static int OvREIueJzYDIoSvA(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 QCbyXioYpWlGArCb(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static bool RFnOMMavIpXfLLUM(java.util.Enumeration enumeration) {
        return enumeration.hasMoreElements();
    }

    public static int TCCubaDmDPfKgjMQ(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static void VduoxHoCVXdCuqTP(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p7c922baa.pca323100.p32c90ea1.pa7d0acfd WBPOtuSuvcsETEMx(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p32c90ea1.pa7d0acfd.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 YoOIyenYgugtxSgn(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(p582a4948Var, z);
    }

    public p5a445d71.p7c922baa.pca323100.p32c90ea1.pa7d0acfd GetCountry() {
        return this.fa6a77375;
    }

    public p5a445d71.p7c922baa.pca323100.p2dfa03b7 GetCountryName() {
        if (this.fa6a77375 is not null) {
            return new p5a445d71.p7c922baa.pca323100.p2dfa03b7(PdSpTqyaJinibchq(jEOSQARmckfxqqmy(this)));
        }
        return null;
    }

    public p5a445d71.p7c922baa.pca323100.p32c90ea1.pa7d0acfd GetLocality() {
        return this.fb4534357;
    }

    public p5a445d71.p7c922baa.pca323100.p2dfa03b7 GetLocalityName() {
        if (this.fb4534357 is not null) {
            return new p5a445d71.p7c922baa.pca323100.p2dfa03b7(oSNpalsmaXdNGdvG(dlwDcnEaSzyLUdUU(this)));
        }
        return null;
    }

    public p5a445d71.p7c922baa.pca323100.p32c90ea1.pa7d0acfd[] GetPostal() {
        if ((20 + 14) % 14 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var = this.fb8eeea67;
        if (p80f8c729Var is null) {
            return null;
        }
        int iTCCubaDmDPfKgjMQ = tCCubaDmDPfKgjMQ(p80f8c729Var);
        p5a445d71.p7c922baa.pca323100.p32c90ea1.pa7d0acfd[] pa7d0acfdVarArr = new p5a445d71.p7c922baa.pca323100.p32c90ea1.pa7d0acfd[iTCCubaDmDPfKgjMQ];
        for (int i = 0; i != iTCCubaDmDPfKgjMQ; i++) {
            pa7d0acfdVarArr[i] = RnlLPldLNRRSndKn(qCbyXioYpWlGArCb(this.fb8eeea67, i));
        }
        return pa7d0acfdVarArr;
    }

    public p5a445d71.p7c922baa.pca323100.p80f8c729 GetPostalAddress() {
        return this.fb8eeea67;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((5 + 25) % 25 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p7c922baa.pca323100.pd6ccb7fc();
        if (this.fa6a77375 is not null) {
            GEUDQKDIQQFUwdpU(pd6ccb7fcVar, new p5a445d71.p7c922baa.pca323100.p87af127c(true, 0, this.fa6a77375));
        }
        if (this.fb4534357 is not null) {
            XlmmCCemGJBkpQCT(pd6ccb7fcVar, new p5a445d71.p7c922baa.pca323100.p87af127c(true, 1, this.fb4534357));
        }
        if (this.fb8eeea67 is not null) {
            vduoxHoCVXdCuqTP(pd6ccb7fcVar, new p5a445d71.p7c922baa.pca323100.p87af127c(true, 2, this.fb8eeea67));
        }
        return new p5a445d71.p7c922baa.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

