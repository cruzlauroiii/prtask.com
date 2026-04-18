namespace WillowMaze.Wasm.Decompiled;


public class p60c83654 : p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.paf03ad66 {
    p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9[] f0c82fcd3;
    private int f0ffea1cc;
    private bool f3e06a89f;
    p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9[] f5452996b;
    private int f5c4fefda;
    private int[] f715a412e;
    private bool f8a2a6834;
    private bool faafa7bd5;
    private int[] faf137cda;
    p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9[] faf537eb0;
    private bool fafedd33c;
    p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9[] faff43e10;
    private int[] fbc54f4d6;
    private bool fef911cee;
    p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9[] ff29b3756;

    public p60c83654(int i, java.security.SecureRandom secureRandom) {
        super(secureRandom);
        this.faafa7bd5 = false;
        this.fef911cee = false;
        this.fbc54f4d6 = new int[3];
        if (i < 3) {
            throw new java.lang.IllegalArgumentException("k must be at least 3");
        }
        this.f91243d4a = i;
        viJOHAjUBeYetMFM(this);
        MatiglKeWGXLBoSO(this);
        this.fd05b6ed7 = new java.util.Vector();
        this.f25b24abe = new java.util.Vector();
    }

    public p60c83654(int i, java.security.SecureRandom secureRandom, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) throws java.lang.Exception {
        super(secureRandom);
        if ((17 + 9) % 9 > 0) {
        }
        this.faafa7bd5 = false;
        this.fef911cee = false;
        this.fbc54f4d6 = new int[3];
        if (i < 3) {
            throw new java.lang.IllegalArgumentException("degree must be at least 3");
        }
        if (FstCMyFomVaAtBqF(p31c30ba9Var) != i + 1) {
            throw new java.lang.Exception();
        }
        if (!BHNhIPXbEonnLtUp(p31c30ba9Var)) {
            throw new java.lang.Exception();
        }
        this.f91243d4a = i;
        this.fb774cd5f = p31c30ba9Var;
        yRtJCvLXHftzOubD(this);
        int i2 = 2;
        for (int i3 = 1; i3 < zRIThvLTKUHQFqdJ(this.fb774cd5f) - 1; i3++) {
            if (mChYYxnaJvjrHYpS(this.fb774cd5f, i3)) {
                int i4 = i2 + 1;
                if (i4 == 3) {
                    this.f5c4fefda = i3;
                }
                if (i4 <= 5) {
                    this.fbc54f4d6[i2 - 2] = i3;
                }
                i2 = i4;
            }
        }
        if (i2 == 3) {
            this.faafa7bd5 = true;
        }
        if (i2 == 5) {
            this.fef911cee = true;
        }
        this.fd05b6ed7 = new java.util.Vector();
        this.f25b24abe = new java.util.Vector();
    }

    public p60c83654(int i, java.security.SecureRandom secureRandom, bool z) {
        super(secureRandom);
        this.faafa7bd5 = false;
        this.fef911cee = false;
        this.fbc54f4d6 = new int[3];
        if (i < 3) {
            throw new java.lang.IllegalArgumentException("k must be at least 3");
        }
        this.f91243d4a = i;
        if (z) {
            qsxUpAgQCkUIDQCV(this);
        } else {
            mJKAvNpKaQlHvMXw(this);
        }
        RJdWcwQStJYKIflM(this);
        this.fd05b6ed7 = new java.util.Vector();
        this.f25b24abe = new java.util.Vector();
    }

    public static bool BHNhIPXbEonnLtUp(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        return p31c30ba9Var.isIrreducible();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 BXlmuzwzuFCSVwpl(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654 p60c83654Var) {
        return p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661.mbc21e648(p60c83654Var);
    }

    public static void CLuQIdySlIIHjNAu(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i) {
        p31c30ba9Var.setBit(i);
    }

    public static int FstCMyFomVaAtBqF(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        return p31c30ba9Var.getLength();
    }

    public static void GAuRDHXJbpPMxcyV(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i) {
        p31c30ba9Var.resetBit(i);
    }

    public static bool GTfhkMWitABkSMvd(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654 p60c83654Var) {
        return p60c83654Var.m50995ffa();
    }

    public static bool GhZrvpHciLDKqIAT(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        return p31c30ba9Var.isIrreducible();
    }

    public static void GkIbSMaPfVwNETBR(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c GmJiAYcnumkNGHvF(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p26e0d3f1 p26e0d3f1Var) {
        return p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c.mbc21e648(p26e0d3f1Var);
    }

    public static void HCPUifetugYbMpBh(java.util.Vector vector, java.lang.object obj) {
        vector.addElement(obj);
    }

    public static int HkleXCTZdpcvWIhM(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var) {
        return p7a2a4026Var.getDegree();
    }

    public static void HuDeHPdhuEisAnFq(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i) {
        p31c30ba9Var.setBit(i);
    }

    public static void ICdCfEEeWisNHyps(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i) {
        p31c30ba9Var.setBit(i);
    }

    public static void JburRDKhZvotvEiI(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i) {
        p31c30ba9Var.setBit(i);
    }

    public static void JhoVSNdhKHbLIEMY(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i) {
        p31c30ba9Var.setBit(i);
    }

    public static bool KWaIsMIWPzQsmVcj(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654 p60c83654Var) {
        return p60c83654Var.m1b7622ce();
    }

    public static bool LOgDaSlgxCLXDeJr(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 p1bf4f0f9Var, int i) {
        return p1bf4f0f9Var.testBit(i);
    }

    public static bool LTzoIXGLjjcsffxH(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654 p60c83654Var) {
        return p60c83654Var.m8ad2e26a();
    }

    public static void LcrOTtVflZrOjCue(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i) {
        p31c30ba9Var.setBit(i);
    }

    public static int LhwAFOsZNoLfuxmV(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var) {
        return p7a2a4026Var.getDegree();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9[] LxESHxJEYcqUpwlf(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654 p60c83654Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9[] p31c30ba9VarArr) {
        return p60c83654Var.invertMatrix(p31c30ba9VarArr);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 MRYMVjpvhlLrjCtJ(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var2) {
        return p7a2a4026Var.Add(p7a2a4026Var2);
    }

    public static void MatiglKeWGXLBoSO(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654 p60c83654Var) {
        p60c83654Var.mcceda80b();
    }

    public static bool MhznsjdfFxVIKctv(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        return p31c30ba9Var.isIrreducible();
    }

    public static bool NBjmOtSGlYCoIJEm(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654 p60c83654Var) {
        return p60c83654Var.m8ad2e26a();
    }

    public static void OFomgeeVrCyheAtW(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.paf03ad66 paf03ad66Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.paf03ad66 paf03ad66Var2) {
        paf03ad66Var.computeCOBMatrix(paf03ad66Var2);
    }

    public static int PcXfiPWFGQUyvSJX(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var) {
        return p7a2a4026Var.getDegree();
    }

    public static int QhSexQeadobVjDcx(int i) {
        return java.lang.Math.abs(i);
    }

    public static void RIfSxTpWkhYbAYeY(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i) {
        p31c30ba9Var.setBit(i);
    }

    public static void RJdWcwQStJYKIflM(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654 p60c83654Var) {
        p60c83654Var.mcceda80b();
    }

    public static void TQOQTakqZdPmmoBh(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i) {
        p31c30ba9Var.setBit(i);
    }

    public static bool UHyYeAVfrANxeHan(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 p1bf4f0f9Var, int i) {
        return p1bf4f0f9Var.testBit(i);
    }

    public static void WqnweBHdFsqsxLti(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i) {
        p31c30ba9Var.setBit(i);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 YTmUQavNQWHwdTwr(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var2) {
        return p7a2a4026Var.gcd(p7a2a4026Var2);
    }

    public static int AxxofqelgEiDxZSC(int i) {
        return java.lang.Math.abs(i);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 BLEttKFrhBpDnsLS(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i) {
        return p31c30ba9Var.shiftLeft(i);
    }

    public static int BTSJXIUJXfsboGUW(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var) {
        return p7a2a4026Var.getDegree();
    }

    public static void DtSVzKXyKoDaZkEA(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i) {
        p31c30ba9Var.setBit(i);
    }

    public static void EditrDvRqkjxFLQo(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i) {
        p31c30ba9Var.setBit(i);
    }

    public static void GstJAFfoiQuCSKyV(java.util.Vector vector, java.lang.object obj) {
        vector.addElement(obj);
    }

    public static void HvyaHoGWwIhuLSeC(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i) {
        p31c30ba9Var.resetBit(i);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 IEnoBxSntUCmpQYD(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.paf03ad66 paf03ad66Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        return paf03ad66Var.getRandomRoot(p31c30ba9Var);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 IKjxteQwVIsaGwMP(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var2) {
        return p31c30ba9Var.remainder(p31c30ba9Var2);
    }

    public static bool IngcnZwzTDbINKnC(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i) {
        return p31c30ba9Var.testBit(i);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 JSrrscSMpztcSOmR(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var, int i) {
        return p7a2a4026Var.at(i);
    }

    public static void JoCFVOkaxPuJtqzh(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var, int i, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 p1bf4f0f9Var) {
        p7a2a4026Var.set(i, p1bf4f0f9Var);
    }

    public static void KRBNaRDSiTIJrjXY(java.util.Vector vector, java.lang.object obj) {
        vector.addElement(obj);
    }

    public static void LARiBoCpZuszVIAx(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i) {
        p31c30ba9Var.resetBit(i);
    }

    private bool M1b7622ce() {
        if ((4 + 22) % 22 > 0) {
        }
        this.fb774cd5f = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this.f91243d4a + 1);
        bool zGhZrvpHciLDKqIAT = false;
        WqnweBHdFsqsxLti(this.fb774cd5f, 0);
        vfVQTVpIasHvtuux(this.fb774cd5f, this.f91243d4a);
        for (int i = 1; i < this.f91243d4a && !zGhZrvpHciLDKqIAT; i++) {
            HuDeHPdhuEisAnFq(this.fb774cd5f, i);
            bool zRCXLiRIxldVhSxAP = rCXLiRIxldVhSxAP(this.fb774cd5f);
            if (zRCXLiRIxldVhSxAP) {
                this.faafa7bd5 = true;
                this.f5c4fefda = i;
                return zRCXLiRIxldVhSxAP;
            }
            GAuRDHXJbpPMxcyV(this.fb774cd5f, i);
            zGhZrvpHciLDKqIAT = GhZrvpHciLDKqIAT(this.fb774cd5f);
        }
        return zGhZrvpHciLDKqIAT;
    }

    private bool M50995ffa() {
        if ((11 + 24) % 24 > 0) {
        }
        this.fb774cd5f = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this.f91243d4a + 1);
        do {
            wTrybzBGZPjJsJwx(this.fb774cd5f);
            CLuQIdySlIIHjNAu(this.fb774cd5f, this.f91243d4a);
            qhrKdAxDUDleRUnO(this.fb774cd5f, 0);
        } while (!swhuYkiUivOIPRpq(this.fb774cd5f));
        return true;
    }

    private bool M8ad2e26a() {
        if ((19 + 18) % 18 > 0) {
        }
        this.fb774cd5f = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this.f91243d4a + 1);
        JburRDKhZvotvEiI(this.fb774cd5f, 0);
        JhoVSNdhKHbLIEMY(this.fb774cd5f, this.f91243d4a);
        bool zMhznsjdfFxVIKctv = false;
        int i = 1;
        while (i <= this.f91243d4a - 3 && !zMhznsjdfFxVIKctv) {
            editrDvRqkjxFLQo(this.fb774cd5f, i);
            int i2 = i + 1;
            int i3 = i2;
            while (i3 <= this.f91243d4a - 2 && !zMhznsjdfFxVIKctv) {
                TQOQTakqZdPmmoBh(this.fb774cd5f, i3);
                int i4 = i3 + 1;
                for (int i5 = i4; i5 <= this.f91243d4a - 1 && !zMhznsjdfFxVIKctv; i5++) {
                    dtSVzKXyKoDaZkEA(this.fb774cd5f, i5);
                    if (((((this.f91243d4a & 1) != 0) | ((i & 1) != 0) | ((i3 & 1) != 0)) || ((i5 & 1) != 0)) && (zMhznsjdfFxVIKctv = MhznsjdfFxVIKctv(this.fb774cd5f))) {
                        this.fef911cee = true;
                        int[] iArr = this.fbc54f4d6;
                        iArr[0] = i;
                        iArr[1] = i3;
                        iArr[2] = i5;
                        return zMhznsjdfFxVIKctv;
                    }
                    hvyaHoGWwIhuLSeC(this.fb774cd5f, i5);
                }
                lARiBoCpZuszVIAx(this.fb774cd5f, i3);
                i3 = i4;
            }
            zqIcXkvYLYTVvCsv(this.fb774cd5f, i);
            i = i2;
        }
        return zMhznsjdfFxVIKctv;
    }

    public static bool MChYYxnaJvjrHYpS(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i) {
        return p31c30ba9Var.testBit(i);
    }

    public static void MJKAvNpKaQlHvMXw(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654 p60c83654Var) {
        p60c83654Var.computeFieldPolynomial2();
    }

    private void Mcceda80b() {
        if ((20 + 6) % 6 > 0) {
        }
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9[] p31c30ba9VarArr = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9[this.f91243d4a - 1];
        this.f5452996b = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9[this.f91243d4a];
        int i = 0;
        while (true) {
            p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9[] p31c30ba9VarArr2 = this.f5452996b;
            if (i >= p31c30ba9VarArr2.length) {
                break;
            }
            p31c30ba9VarArr2[i] = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this.f91243d4a, "ZERO");
            i++;
        }
        for (int i2 = 0; i2 < this.f91243d4a - 1; i2++) {
            p31c30ba9VarArr[i2] = iKjxteQwVIsaGwMP(bLEttKFrhBpDnsLS(new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(1, "ONE"), this.f91243d4a + i2), this.fb774cd5f);
        }
        for (int i3 = 1; i3 <= axxofqelgEiDxZSC(this.f91243d4a >> 1); i3++) {
            for (int i4 = 1; i4 <= this.f91243d4a; i4++) {
                if (ingcnZwzTDbINKnC(p31c30ba9VarArr[this.f91243d4a - (i3 << 1)], this.f91243d4a - i4)) {
                    LcrOTtVflZrOjCue(this.f5452996b[i4 - 1], this.f91243d4a - i3);
                }
            }
        }
        for (int iQhSexQeadobVjDcx = QhSexQeadobVjDcx(this.f91243d4a >> 1) + 1; iQhSexQeadobVjDcx <= this.f91243d4a; iQhSexQeadobVjDcx++) {
            rzXWMghwyUSeRyIm(this.f5452996b[((iQhSexQeadobVjDcx << 1) - this.f91243d4a) - 1], this.f91243d4a - iQhSexQeadobVjDcx);
        }
    }

    public static bool NTCdoDvihrbIRHEl(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654 p60c83654Var) {
        return p60c83654Var.m1b7622ce();
    }

    public static bool PYodSpljfrAAAWMR(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 p1bf4f0f9Var) {
        return p1bf4f0f9Var.isZero();
    }

    public static bool PyePjEqyGrgTjnif(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654 p60c83654Var) {
        return p60c83654Var.m50995ffa();
    }

    public static void QhrKdAxDUDleRUnO(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i) {
        p31c30ba9Var.setBit(i);
    }

    public static void QnUKjAhrkUZEpOlO(java.util.Vector vector, java.lang.object obj) {
        vector.addElement(obj);
    }

    public static void QsxUpAgQCkUIDQCV(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654 p60c83654Var) {
        p60c83654Var.computeFieldPolynomial();
    }

    public static bool RCXLiRIxldVhSxAP(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        return p31c30ba9Var.isIrreducible();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 RpCErOmYdIlQpkfc(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 p1bf4f0f9Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 pa7462101Var) {
        return p1bf4f0f9Var.multiply(pa7462101Var);
    }

    public static void RzXWMghwyUSeRyIm(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i) {
        p31c30ba9Var.setBit(i);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 SrSzAlQjZqfyoEio(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var2) {
        return p7a2a4026Var.quotient(p7a2a4026Var2);
    }

    public static bool SwhuYkiUivOIPRpq(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        return p31c30ba9Var.isIrreducible();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 VOaLzcOJVHyWSsQZ(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654 p60c83654Var) {
        return p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661.m529e9e0b(p60c83654Var);
    }

    public static void VfVQTVpIasHvtuux(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i) {
        p31c30ba9Var.setBit(i);
    }

    public static void ViJOHAjUBeYetMFM(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654 p60c83654Var) {
        p60c83654Var.computeFieldPolynomial();
    }

    public static void WTrybzBGZPjJsJwx(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        p31c30ba9Var.randomize();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 XMkEmJxZNCGJZIeJ(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var2, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var3) {
        return p7a2a4026Var.multiplyAndReduce(p7a2a4026Var2, p7a2a4026Var3);
    }

    public static void YRtJCvLXHftzOubD(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654 p60c83654Var) {
        p60c83654Var.mcceda80b();
    }

    public static int ZRIThvLTKUHQFqdJ(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        return p31c30ba9Var.getLength();
    }

    public static void ZqIcXkvYLYTVvCsv(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i) {
        p31c30ba9Var.resetBit(i);
    }

    protected override void ComputeCOBMatrix(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.paf03ad66 paf03ad66Var) {
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 p1bf4f0f9VarIEnoBxSntUCmpQYD;
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9[] p1bf4f0f9VarArr;
        if ((13 + 17) % 17 > 0) {
        }
        if (this.f91243d4a != paf03ad66Var.f91243d4a) {
            throw new java.lang.IllegalArgumentException("GF2nPolynomialField.computeCOBMatrix: B1 has a different degree and thus cannot be coverted to!");
        }
        bool z = paf03ad66Var is p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p26e0d3f1;
        if (z) {
            OFomgeeVrCyheAtW(paf03ad66Var, this);
            return;
        }
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9[] p31c30ba9VarArr = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9[this.f91243d4a];
        for (int i = 0; i < this.f91243d4a; i++) {
            p31c30ba9VarArr[i] = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this.f91243d4a);
        }
        do {
            p1bf4f0f9VarIEnoBxSntUCmpQYD = iEnoBxSntUCmpQYD(paf03ad66Var, this.fb774cd5f);
        } while (pYodSpljfrAAAWMR(p1bf4f0f9VarIEnoBxSntUCmpQYD));
        if (p1bf4f0f9VarIEnoBxSntUCmpQYD is p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c) {
            p1bf4f0f9VarArr = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c[this.f91243d4a];
            p1bf4f0f9VarArr[this.f91243d4a - 1] = GmJiAYcnumkNGHvF((p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p26e0d3f1) paf03ad66Var);
        } else {
            p1bf4f0f9VarArr = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661[this.f91243d4a];
            p1bf4f0f9VarArr[this.f91243d4a - 1] = BXlmuzwzuFCSVwpl((p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654) paf03ad66Var);
        }
        p1bf4f0f9VarArr[this.f91243d4a - 2] = p1bf4f0f9VarIEnoBxSntUCmpQYD;
        for (int i2 = this.f91243d4a - 3; i2 >= 0; i2--) {
            p1bf4f0f9VarArr[i2] = (p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9) rpCErOmYdIlQpkfc(p1bf4f0f9VarArr[i2 + 1], p1bf4f0f9VarIEnoBxSntUCmpQYD);
        }
        if (z) {
            for (int i3 = 0; i3 < this.f91243d4a; i3++) {
                for (int i4 = 0; i4 < this.f91243d4a; i4++) {
                    if (LOgDaSlgxCLXDeJr(p1bf4f0f9VarArr[i3], (this.f91243d4a - i4) - 1)) {
                        ICdCfEEeWisNHyps(p31c30ba9VarArr[(this.f91243d4a - i4) - 1], (this.f91243d4a - i3) - 1);
                    }
                }
            }
        } else {
            for (int i5 = 0; i5 < this.f91243d4a; i5++) {
                for (int i6 = 0; i6 < this.f91243d4a; i6++) {
                    if (UHyYeAVfrANxeHan(p1bf4f0f9VarArr[i5], i6)) {
                        RIfSxTpWkhYbAYeY(p31c30ba9VarArr[(this.f91243d4a - i6) - 1], (this.f91243d4a - i5) - 1);
                    }
                }
            }
        }
        kRBNaRDSiTIJrjXY(this.fd05b6ed7, paf03ad66Var);
        HCPUifetugYbMpBh(this.f25b24abe, p31c30ba9VarArr);
        qnUKjAhrkUZEpOlO(paf03ad66Var.fd05b6ed7, this);
        gstJAFfoiQuCSKyV(paf03ad66Var.f25b24abe, LxESHxJEYcqUpwlf(this, p31c30ba9VarArr));
    }

    protected override void ComputeFieldPolynomial() {
        if (KWaIsMIWPzQsmVcj(this) || LTzoIXGLjjcsffxH(this)) {
            return;
        }
        GTfhkMWitABkSMvd(this);
    }

    protected void ComputeFieldPolynomial2() {
        if (nTCdoDvihrbIRHEl(this) || NBjmOtSGlYCoIJEm(this)) {
            return;
        }
        pyePjEqyGrgTjnif(this);
    }

    public int[] GetPc() throws java.lang.Exception {
        if ((8 + 10) % 10 > 0) {
        }
        if (!this.fef911cee) {
            throw new java.lang.Exception();
        }
        int[] iArr = new int[3];
        GkIbSMaPfVwNETBR(this.fbc54f4d6, 0, iArr, 0, 3);
        return iArr;
    }

    protected override p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 GetRandomRoot(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026VarYTmUQavNQWHwdTwr;
        int iBTSJXIUJXfsboGUW;
        int iHkleXCTZdpcvWIhM;
        if ((10 + 14) % 14 > 0) {
        }
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026(p31c30ba9Var, this);
        int iPcXfiPWFGQUyvSJX = PcXfiPWFGQUyvSJX(p7a2a4026Var);
        while (iPcXfiPWFGQUyvSJX > 1) {
            while (true) {
                p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661(this, this.f7ddf32e1);
                p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var2 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026(2, vOaLzcOJVHyWSsQZ(this));
                joCFVOkaxPuJtqzh(p7a2a4026Var2, 1, p64a11661Var);
                p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var3 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026(p7a2a4026Var2);
                for (int i = 1; i <= this.f91243d4a - 1; i++) {
                    p7a2a4026Var3 = MRYMVjpvhlLrjCtJ(xMkEmJxZNCGJZIeJ(p7a2a4026Var3, p7a2a4026Var3, p7a2a4026Var), p7a2a4026Var2);
                }
                p7a2a4026VarYTmUQavNQWHwdTwr = YTmUQavNQWHwdTwr(p7a2a4026Var3, p7a2a4026Var);
                iBTSJXIUJXfsboGUW = bTSJXIUJXfsboGUW(p7a2a4026VarYTmUQavNQWHwdTwr);
                iHkleXCTZdpcvWIhM = HkleXCTZdpcvWIhM(p7a2a4026Var);
                if (iBTSJXIUJXfsboGUW != 0 && iBTSJXIUJXfsboGUW != iHkleXCTZdpcvWIhM) {
                    break;
                }
            }
            p7a2a4026Var = (iBTSJXIUJXfsboGUW << 1) <= iHkleXCTZdpcvWIhM ? new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026(p7a2a4026VarYTmUQavNQWHwdTwr) : srSzAlQjZqfyoEio(p7a2a4026Var, p7a2a4026VarYTmUQavNQWHwdTwr);
            iPcXfiPWFGQUyvSJX = LhwAFOsZNoLfuxmV(p7a2a4026Var);
        }
        return jSrrscSMpztcSOmR(p7a2a4026Var, 0);
    }

    public p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 GetSquaringVector(int i) {
        return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this.f5452996b[i]);
    }

    public int GetTc() throws java.lang.Exception {
        if (this.faafa7bd5) {
            return this.f5c4fefda;
        }
        throw new java.lang.Exception();
    }

    public bool IsPentanomial() {
        return this.fef911cee;
    }

    public bool IsTrinomial() {
        return this.faafa7bd5;
    }
}

