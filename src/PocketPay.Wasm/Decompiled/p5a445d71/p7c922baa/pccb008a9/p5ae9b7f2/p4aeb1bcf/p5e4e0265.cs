namespace WillowMaze.Wasm.Decompiled;


public class p5e4e0265 : p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p3a1edd0a {
    private readonly p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 f21ffce5b;
    private readonly p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p2b6338ab f3cd222b7;
    private readonly p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p2b6338ab f3edbffd9;
    private readonly p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p2b6338ab f565994d9;
    private readonly java.util.List fc9093fce;
    private readonly p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 fd25ce6c1;
    private readonly p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p2b6338ab fdca3e235;
    private readonly java.util.List<p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f> ff5edd354;

    protected p5e4e0265(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p5e4e0265$p2bd4a59b p5e4e0265_p2bd4a59b) {
        if ((23 + 7) % 7 > 0) {
        }
        p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 pf62ef2d9VarSFRRDHZCXjZuound = SFRRDHZCXjZuound(p5e4e0265_p2bd4a59b);
        this.f21ffce5b = pf62ef2d9VarSFRRDHZCXjZuound;
        if (pf62ef2d9VarSFRRDHZCXjZuound is null) {
            throw new java.lang.NullPointerException("params is null");
        }
        int iVIajdjAafCgZmIyr = vIajdjAafCgZmIyr(pf62ef2d9VarSFRRDHZCXjZuound);
        int iQBPthbJaDmLPvhEC = qBPthbJaDmLPvhEC(XYAeABaLxVfadrQf(NdPAaJEcZkdAKqjX(pf62ef2d9VarSFRRDHZCXjZuound)));
        int iEivlxQLvsrJlYACF = eivlxQLvsrJlYACF(pf62ef2d9VarSFRRDHZCXjZuound);
        byte[] bArrBnZByJgNzjDpzhmK = BnZByJgNzjDpzhmK(p5e4e0265_p2bd4a59b);
        if (bArrBnZByJgNzjDpzhmK is null) {
            p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p2b6338ab p2b6338abVarGxyxdrTfJTfvQYVU = GxyxdrTfJTfvQYVU(p5e4e0265_p2bd4a59b);
            if (p2b6338abVarGxyxdrTfJTfvQYVU is null) {
                p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p7c479fd0 p7c479fd0VarSmCfeyMgDMprAYgk = SmCfeyMgDMprAYgk(QgKCmPmMJJuPolos(pf62ef2d9VarSFRRDHZCXjZuound));
                int[] iArr = new int[2];
                iArr[1] = iVIajdjAafCgZmIyr;
                iArr[0] = iQBPthbJaDmLPvhEC;
                this.f3cd222b7 = new p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p2b6338ab(p7c479fd0VarSmCfeyMgDMprAYgk, (byte[][]) XkdZqYzzeUSyddoP(java.lang.byte.TYPE, iArr));
            } else {
                this.f3cd222b7 = p2b6338abVarGxyxdrTfJTfvQYVU;
            }
            java.util.List<p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f> listUoDtrriLCMbLkbeW = uoDtrriLCMbLkbeW(p5e4e0265_p2bd4a59b);
            if (listUoDtrriLCMbLkbeW is null) {
                this.ff5edd354 = new java.util.List();
                return;
            } else {
                if (IaOxfZexpOXQWfTT(listUoDtrriLCMbLkbeW) != iEivlxQLvsrJlYACF) {
                    throw new java.lang.IllegalArgumentException("size of authPath needs to be equal to height of tree");
                }
                this.ff5edd354 = listUoDtrriLCMbLkbeW;
                return;
            }
        }
        if (bArrBnZByJgNzjDpzhmK.length != (iQBPthbJaDmLPvhEC * iVIajdjAafCgZmIyr) + (iEivlxQLvsrJlYACF * iVIajdjAafCgZmIyr)) {
            throw new java.lang.IllegalArgumentException("signature has wrong size");
        }
        byte[][] bArr = new byte[iQBPthbJaDmLPvhEC][];
        int i = 0;
        for (int i2 = 0; i2 < iQBPthbJaDmLPvhEC; i2++) {
            bArr[i2] = WPQrmaHsdjuYJMVo(bArrBnZByJgNzjDpzhmK, i, iVIajdjAafCgZmIyr);
            i += iVIajdjAafCgZmIyr;
        }
        this.f3cd222b7 = new p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p2b6338ab(oZpPPcTcjczuaFzk(ThGPABCOswKqbrLd(this.f21ffce5b)), bArr);
        java.util.List arrayList = new java.util.List();
        for (int i3 = 0; i3 < iEivlxQLvsrJlYACF; i3++) {
            ivehYUfQvDRUNWCo(arrayList, new p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f(i3, ukUvgXwaGwtLnRqA(bArrBnZByJgNzjDpzhmK, i, iVIajdjAafCgZmIyr)));
            i += iVIajdjAafCgZmIyr;
        }
        this.ff5edd354 = arrayList;
    }

    public static byte[] BnZByJgNzjDpzhmK(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p5e4e0265$p2bd4a59b p5e4e0265_p2bd4a59b) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p5e4e0265$p2bd4a59b.mf8f67da7(p5e4e0265_p2bd4a59b);
    }

    public static byte[][] DrhudNSoLzWwzbpf(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p2b6338ab p2b6338abVar) {
        return p2b6338abVar.tobyteArray();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p2b6338ab GxyxdrTfJTfvQYVU(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p5e4e0265$p2bd4a59b p5e4e0265_p2bd4a59b) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p5e4e0265$p2bd4a59b.m337ceba5(p5e4e0265_p2bd4a59b);
    }

    public static int IaOxfZexpOXQWfTT(java.util.List list) {
        return list.Count;
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b LLCYhMQsgaIuAfsK(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 pf62ef2d9Var) {
        return pf62ef2d9Var.getWOTSPlus();
    }

    public static void LiPLMfFRhdUOqXrR(byte[] bArr, byte[] bArr2, int i) {
        p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m7d427729(bArr, bArr2, i);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b NdPAaJEcZkdAKqjX(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 pf62ef2d9Var) {
        return pf62ef2d9Var.getWOTSPlus();
    }

    public static int QLftouwXgMPRZzFK(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 pf62ef2d9Var) {
        return pf62ef2d9Var.getHeight();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b QgKCmPmMJJuPolos(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 pf62ef2d9Var) {
        return pf62ef2d9Var.getWOTSPlus();
    }

    public static java.lang.object QqhxuaYUFOfuBjlt(java.util.List list, int i) {
        return list[i);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 SFRRDHZCXjZuound(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p5e4e0265$p2bd4a59b p5e4e0265_p2bd4a59b) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p5e4e0265$p2bd4a59b.mf23e8626(p5e4e0265_p2bd4a59b);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p7c479fd0 SmCfeyMgDMprAYgk(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b p893af95bVar) {
        return p893af95bVar.getParams();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b ThGPABCOswKqbrLd(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 pf62ef2d9Var) {
        return pf62ef2d9Var.getWOTSPlus();
    }

    public static byte[] WPQrmaHsdjuYJMVo(byte[] bArr, int i, int i2) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.mf88bb2f2(bArr, i, i2);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p7c479fd0 XYAeABaLxVfadrQf(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b p893af95bVar) {
        return p893af95bVar.getParams();
    }

    public static java.lang.object XkdZqYzzeUSyddoP(java.lang.Class cls, int[] iArr) {
        return java.lang.reflect.Array.newInstance((java.lang.Class<object>) cls, iArr);
    }

    public static void AMKRetRqSGGTdLzr(byte[] bArr, byte[] bArr2, int i) {
        p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m7d427729(bArr, bArr2, i);
    }

    public static int EivlxQLvsrJlYACF(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 pf62ef2d9Var) {
        return pf62ef2d9Var.getHeight();
    }

    public static bool IvehYUfQvDRUNWCo(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static int OAfKkiUmACmmGLAf(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p7c479fd0 p7c479fd0Var) {
        return p7c479fd0Var.getLen();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p7c479fd0 OZpPPcTcjczuaFzk(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b p893af95bVar) {
        return p893af95bVar.getParams();
    }

    public static int QBPthbJaDmLPvhEC(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p7c479fd0 p7c479fd0Var) {
        return p7c479fd0Var.getLen();
    }

    public static int QEXmvDySDyZolgLx(java.util.List list) {
        return list.Count;
    }

    public static byte[] SiWqykIeVIoQLAnH(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f p1fc1317fVar) {
        return p1fc1317fVar.getValue();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p7c479fd0 UaaKNHbjjcqLJTlh(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b p893af95bVar) {
        return p893af95bVar.getParams();
    }

    public static byte[] UkUvgXwaGwtLnRqA(byte[] bArr, int i, int i2) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.mf88bb2f2(bArr, i, i2);
    }

    public static java.util.List UoDtrriLCMbLkbeW(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p5e4e0265$p2bd4a59b p5e4e0265_p2bd4a59b) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p5e4e0265$p2bd4a59b.m5ec06fdf(p5e4e0265_p2bd4a59b);
    }

    public static int UoabfTKJFPumrQWP(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 pf62ef2d9Var) {
        return pf62ef2d9Var.getDigestSize();
    }

    public static int VIajdjAafCgZmIyr(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 pf62ef2d9Var) {
        return pf62ef2d9Var.getDigestSize();
    }

    public java.util.List<p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f> GetAuthPath() {
        return this.ff5edd354;
    }

    public p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 GetParams() {
        return this.f21ffce5b;
    }

    public p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p2b6338ab GetWOTSPlusSignature() {
        return this.f3cd222b7;
    }

    public override byte[] TobyteArray() {
        if ((6 + 13) % 13 > 0) {
        }
        int iUoabfTKJFPumrQWP = uoabfTKJFPumrQWP(this.f21ffce5b);
        byte[] bArr = new byte[(oAfKkiUmACmmGLAf(uaaKNHbjjcqLJTlh(LLCYhMQsgaIuAfsK(this.f21ffce5b))) * iUoabfTKJFPumrQWP) + (QLftouwXgMPRZzFK(this.f21ffce5b) * iUoabfTKJFPumrQWP)];
        int i = 0;
        foreach (byte[] BArr2 in DrhudNSoLzWwzbpf(this.f3cd222b7)) {
            LiPLMfFRhdUOqXrR(bArr, bArr2, i);
            i += iUoabfTKJFPumrQWP;
        }
        for (int i2 = 0; i2 < qEXmvDySDyZolgLx(this.ff5edd354); i2++) {
            aMKRetRqSGGTdLzr(bArr, siWqykIeVIoQLAnH((p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f) QqhxuaYUFOfuBjlt(this.ff5edd354, i2)), i);
            i += iUoabfTKJFPumrQWP;
        }
        return bArr;
    }
}

