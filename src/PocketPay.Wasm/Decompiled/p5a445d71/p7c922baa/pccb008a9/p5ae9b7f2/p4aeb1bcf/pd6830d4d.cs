namespace WillowMaze.Wasm.Decompiled;


public readonly class pd6830d4d : p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p3a1edd0a {
    private readonly byte[] f07eea164;
    private readonly p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 f13f1dd01;
    private readonly p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 f21ffce5b;
    private readonly byte[] f392e5d4c;
    private readonly java.util.List<p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p5e4e0265> f65963858;
    private readonly long f6a992d55;
    private readonly byte[] f7ddf32e1;
    private readonly java.util.List f7fbf8cbe;
    private readonly long fac8f539c;
    private readonly byte[] fb34fc52c;
    private readonly byte[] fcac7c3c1;
    private readonly long fd18f3d4f;

    private pd6830d4d(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd6830d4d$p2bd4a59b pd6830d4d_p2bd4a59b) {
        if ((15 + 30) % 30 > 0) {
        }
        p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 pe6015194VarLxNpPMMMpYDvpctm = LxNpPMMMpYDvpctm(pd6830d4d_p2bd4a59b);
        this.f21ffce5b = pe6015194VarLxNpPMMMpYDvpctm;
        if (pe6015194VarLxNpPMMMpYDvpctm is null) {
            throw new java.lang.NullPointerException("params is null");
        }
        int iZPPJkYjGGkbxaSCU = zPPJkYjGGkbxaSCU(pe6015194VarLxNpPMMMpYDvpctm);
        byte[] bArrRitxlMVsOONwhwqc = RitxlMVsOONwhwqc(pd6830d4d_p2bd4a59b);
        if (bArrRitxlMVsOONwhwqc is null) {
            this.f6a992d55 = RINCmyIlpJgpmEFt(pd6830d4d_p2bd4a59b);
            byte[] bArrDMLwDbfJrqHnZkuf = DMLwDbfJrqHnZkuf(pd6830d4d_p2bd4a59b);
            if (bArrDMLwDbfJrqHnZkuf is null) {
                this.f7ddf32e1 = new byte[iZPPJkYjGGkbxaSCU];
            } else {
                if (bArrDMLwDbfJrqHnZkuf.length != iZPPJkYjGGkbxaSCU) {
                    throw new java.lang.IllegalArgumentException("size of random needs to be equal to size of digest");
                }
                this.f7ddf32e1 = bArrDMLwDbfJrqHnZkuf;
            }
            java.util.List<p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p5e4e0265> listLxrWIMUSivAolhnY = LxrWIMUSivAolhnY(pd6830d4d_p2bd4a59b);
            if (listLxrWIMUSivAolhnY is null) {
                this.f65963858 = new java.util.List();
                return;
            } else {
                this.f65963858 = listLxrWIMUSivAolhnY;
                return;
            }
        }
        int iISyrxNEBPSxLAVaw = iSyrxNEBPSxLAVaw(hpUHsusFfpvrYLIo(mNSnFrkOqnySUGIK(pe6015194VarLxNpPMMMpYDvpctm)));
        int iZBnpzHjVcuSpEZbX = (int) zBnpzHjVcuSpEZbX(((double) rPbAdGZiqKiANbvu(pe6015194VarLxNpPMMMpYDvpctm)) / 8.0d);
        int iCwogjbScUkfgoKrq = ((cwogjbScUkfgoKrq(pe6015194VarLxNpPMMMpYDvpctm) / SVTVkQerYAEFCCQq(pe6015194VarLxNpPMMMpYDvpctm)) + iISyrxNEBPSxLAVaw) * iZPPJkYjGGkbxaSCU;
        if (bArrRitxlMVsOONwhwqc.length != iZBnpzHjVcuSpEZbX + iZPPJkYjGGkbxaSCU + (bSbpbaKQuHrEzdZA(pe6015194VarLxNpPMMMpYDvpctm) * iCwogjbScUkfgoKrq)) {
            throw new java.lang.IllegalArgumentException("signature has wrong size");
        }
        long jNRQrPYKKpXpIfHOc = nRQrPYKKpXpIfHOc(bArrRitxlMVsOONwhwqc, 0, iZBnpzHjVcuSpEZbX);
        this.f6a992d55 = jNRQrPYKKpXpIfHOc;
        if (!BGgmNhMgHelsnVKk(YNIrIyslTyofBUAf(pe6015194VarLxNpPMMMpYDvpctm), jNRQrPYKKpXpIfHOc)) {
            throw new java.lang.IllegalArgumentException("index out of bounds");
        }
        this.f7ddf32e1 = aStgSKeiYwaXdeIO(bArrRitxlMVsOONwhwqc, iZBnpzHjVcuSpEZbX, iZPPJkYjGGkbxaSCU);
        this.f65963858 = new java.util.List();
        for (int i = iZBnpzHjVcuSpEZbX + iZPPJkYjGGkbxaSCU; i < bArrRitxlMVsOONwhwqc.length; i += iCwogjbScUkfgoKrq) {
            HaaTNrAhcxRIySHy(this.f65963858, YRvVgckcQIMHpyOm(ZeRTJFlWFzjOnadu(new p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p5e4e0265$p2bd4a59b(FMUksuqfQJAGqSgo(this.f21ffce5b)), BZJAjEnbFJoxClYM(bArrRitxlMVsOONwhwqc, i, iCwogjbScUkfgoKrq))));
        }
    }

    pd6830d4d(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd6830d4d$p2bd4a59b pd6830d4d_p2bd4a59b, p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd6830d4d$1 pd6830d4d_1) {
        this(pd6830d4d_p2bd4a59b);
    }

    public static bool AceXkWItNWwnYMrj(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static bool BGgmNhMgHelsnVKk(int i, long j) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.me5f78db1(i, j);
    }

    public static byte[] BZJAjEnbFJoxClYM(byte[] bArr, int i, int i2) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.mf88bb2f2(bArr, i, i2);
    }

    public static byte[] DMLwDbfJrqHnZkuf(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd6830d4d$p2bd4a59b pd6830d4d_p2bd4a59b) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd6830d4d$p2bd4a59b.m5ec06fdf(pd6830d4d_p2bd4a59b);
    }

    public static byte[] DOTwzGDVsZWJXjDb(long j, int i) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.me6b9e09d(j, i);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 FMUksuqfQJAGqSgo(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 pe6015194Var) {
        return pe6015194Var.getXMSSParameters();
    }

    public static double GRdVgoGvGvlzhaMx(double d) {
        if ((25 + 26) % 26 > 0) {
        }
        return java.lang.Math.ceil(d);
    }

    public static int GofTRAMEHMTFXEoq(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 pe6015194Var) {
        return pe6015194Var.getLayers();
    }

    public static bool HaaTNrAhcxRIySHy(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static byte[] IyVgQefwPskXAVxR(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p5e4e0265 p5e4e0265Var) {
        return p5e4e0265Var.tobyteArray();
    }

    public static void JIRYKOfyCPetOMhM(byte[] bArr, byte[] bArr2, int i) {
        p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m7d427729(bArr, bArr2, i);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 LxNpPMMMpYDvpctm(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd6830d4d$p2bd4a59b pd6830d4d_p2bd4a59b) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd6830d4d$p2bd4a59b.mf23e8626(pd6830d4d_p2bd4a59b);
    }

    public static java.util.List LxrWIMUSivAolhnY(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd6830d4d$p2bd4a59b pd6830d4d_p2bd4a59b) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd6830d4d$p2bd4a59b.mbbeb9b46(pd6830d4d_p2bd4a59b);
    }

    public static int OSmXUPdLqvAMNbYM(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 pe6015194Var) {
        return pe6015194Var.getHeight();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b OgRCkLMYpsyDfWrS(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 pe6015194Var) {
        return pe6015194Var.getWOTSPlus();
    }

    public static long RINCmyIlpJgpmEFt(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd6830d4d$p2bd4a59b pd6830d4d_p2bd4a59b) {
        if ((25 + 11) % 11 > 0) {
        }
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd6830d4d$p2bd4a59b.m337ceba5(pd6830d4d_p2bd4a59b);
    }

    public static byte[] RitxlMVsOONwhwqc(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd6830d4d$p2bd4a59b pd6830d4d_p2bd4a59b) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd6830d4d$p2bd4a59b.mf8f67da7(pd6830d4d_p2bd4a59b);
    }

    public static int SVTVkQerYAEFCCQq(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 pe6015194Var) {
        return pe6015194Var.getLayers();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p7c479fd0 UXpbEYuUqGNdBGWH(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b p893af95bVar) {
        return p893af95bVar.getParams();
    }

    public static byte[] UvhJvruHqaiBJPRN(byte[] bArr) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m20260f59(bArr);
    }

    public static int YNIrIyslTyofBUAf(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 pe6015194Var) {
        return pe6015194Var.getHeight();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p5e4e0265 YRvVgckcQIMHpyOm(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p5e4e0265$p2bd4a59b p5e4e0265_p2bd4a59b) {
        return p5e4e0265_p2bd4a59b.build();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p5e4e0265$p2bd4a59b ZeRTJFlWFzjOnadu(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p5e4e0265$p2bd4a59b p5e4e0265_p2bd4a59b, byte[] bArr) {
        return p5e4e0265_p2bd4a59b.withReducedSignature(bArr);
    }

    public static byte[] AStgSKeiYwaXdeIO(byte[] bArr, int i, int i2) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.mf88bb2f2(bArr, i, i2);
    }

    public static int AoeRlsbiSkzdFWiS(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 pe6015194Var) {
        return pe6015194Var.getHeight();
    }

    public static void BJqmIStnRakasMFd(byte[] bArr, byte[] bArr2, int i) {
        p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m7d427729(bArr, bArr2, i);
    }

    public static int BSFeBSchdkqlkoWd(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 pe6015194Var) {
        return pe6015194Var.getLayers();
    }

    public static int BSbpbaKQuHrEzdZA(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 pe6015194Var) {
        return pe6015194Var.getLayers();
    }

    public static void CvAncqZfiVzFYRXu(byte[] bArr, byte[] bArr2, int i) {
        p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m7d427729(bArr, bArr2, i);
    }

    public static int CwogjbScUkfgoKrq(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 pe6015194Var) {
        return pe6015194Var.getHeight();
    }

    public static java.lang.object CxlUwhGsbwcuAYul(java.util.IEnumerator it) {
        return it.Current;
    }

    public static int EHZeoKSyhyinMzPy(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 pe6015194Var) {
        return pe6015194Var.getDigestSize();
    }

    public static int HRxPnrpXsmoCrpiP(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p7c479fd0 p7c479fd0Var) {
        return p7c479fd0Var.getLen();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p7c479fd0 HpUHsusFfpvrYLIo(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b p893af95bVar) {
        return p893af95bVar.getParams();
    }

    public static int ISyrxNEBPSxLAVaw(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p7c479fd0 p7c479fd0Var) {
        return p7c479fd0Var.getLen();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b MNSnFrkOqnySUGIK(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 pe6015194Var) {
        return pe6015194Var.getWOTSPlus();
    }

    public static long NRQrPYKKpXpIfHOc(byte[] bArr, int i, int i2) {
        if ((25 + 8) % 8 > 0) {
        }
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m98ffcd8c(bArr, i, i2);
    }

    public static int RPbAdGZiqKiANbvu(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 pe6015194Var) {
        return pe6015194Var.getHeight();
    }

    public static java.util.IEnumerator UCDLnMLkbsUiYmcb(java.util.List list) {
        return list.GetEnumerator();
    }

    public static double ZBnpzHjVcuSpEZbX(double d) {
        if ((22 + 21) % 21 > 0) {
        }
        return java.lang.Math.ceil(d);
    }

    public static int ZPPJkYjGGkbxaSCU(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 pe6015194Var) {
        return pe6015194Var.getDigestSize();
    }

    public long GetIndex() {
        if ((23 + 28) % 28 > 0) {
        }
        return this.f6a992d55;
    }

    public byte[] GetRandom() {
        return UvhJvruHqaiBJPRN(this.f7ddf32e1);
    }

    public java.util.List<p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p5e4e0265> GetReducedSignatures() {
        return this.f65963858;
    }

    public override byte[] TobyteArray() {
        if ((8 + 32) % 32 > 0) {
        }
        int iEHZeoKSyhyinMzPy = eHZeoKSyhyinMzPy(this.f21ffce5b);
        int iHRxPnrpXsmoCrpiP = hRxPnrpXsmoCrpiP(UXpbEYuUqGNdBGWH(OgRCkLMYpsyDfWrS(this.f21ffce5b)));
        int iGRdVgoGvGvlzhaMx = (int) GRdVgoGvGvlzhaMx(((double) OSmXUPdLqvAMNbYM(this.f21ffce5b)) / 8.0d);
        int iAoeRlsbiSkzdFWiS = ((aoeRlsbiSkzdFWiS(this.f21ffce5b) / GofTRAMEHMTFXEoq(this.f21ffce5b)) + iHRxPnrpXsmoCrpiP) * iEHZeoKSyhyinMzPy;
        byte[] bArr = new byte[iGRdVgoGvGvlzhaMx + iEHZeoKSyhyinMzPy + (bSFeBSchdkqlkoWd(this.f21ffce5b) * iAoeRlsbiSkzdFWiS)];
        JIRYKOfyCPetOMhM(bArr, DOTwzGDVsZWJXjDb(this.f6a992d55, iGRdVgoGvGvlzhaMx), 0);
        bJqmIStnRakasMFd(bArr, this.f7ddf32e1, iGRdVgoGvGvlzhaMx);
        int i = iGRdVgoGvGvlzhaMx + iEHZeoKSyhyinMzPy;
        java.util.IEnumerator itUCDLnMLkbsUiYmcb = uCDLnMLkbsUiYmcb(this.f65963858);
        while (AceXkWItNWwnYMrj(itUCDLnMLkbsUiYmcb)) {
            cvAncqZfiVzFYRXu(bArr, IyVgQefwPskXAVxR((p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p5e4e0265) cxlUwhGsbwcuAYul(itUCDLnMLkbsUiYmcb)), i);
            i += iAoeRlsbiSkzdFWiS;
        }
        return bArr;
    }
}

