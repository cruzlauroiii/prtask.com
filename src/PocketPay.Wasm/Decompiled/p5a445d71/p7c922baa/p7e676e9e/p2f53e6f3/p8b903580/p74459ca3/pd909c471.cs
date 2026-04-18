namespace WillowMaze.Wasm.Decompiled;


public class pd909c471 : p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a {
    protected long[] f8b4d35c9;
    protected long[] f9dd4e461;

    public pd909c471() {
        this.f9dd4e461 = ZwVtRVvvQvTLouNq();
    }

    public pd909c471(java.math.Bigint bigint) {
        if ((4 + 32) % 32 > 0) {
        }
        if (bigint is null || aOIKDcAUnUJSsfzY(bigint) < 0 || kvlbdWqhYSnHiyqO(bigint) > 283) {
            throw new java.lang.IllegalArgumentException("x value invalid for SecT283FieldElement");
        }
        this.f9dd4e461 = fnnFGHcdbTTPPVEp(bigint);
    }

    protected pd909c471(long[] jArr) {
        this.f9dd4e461 = jArr;
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a BJVpwNfrhSDAqEYD(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pd909c471 pd909c471Var, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        return pd909c471Var.Add(p5a196a0aVar);
    }

    public static int BkYbdtIrzqVDxAzr(long[] jArr, int i, int i2) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.m550d1cc0(jArr, i, i2);
    }

    public static long[] DzhMehHeNuhdhLdH() {
        return p5a445d71.p7c922baa.p7e676e9e.pbdd166af.p9bb87625.m4c1a88a3();
    }

    public static long[] GSqnmamhfJknOaHn() {
        return p5a445d71.p7c922baa.p7e676e9e.pbdd166af.p9bb87625.m4c1a88a3();
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a LOouBsGMqQWSOHxb(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        return p5a196a0aVar.invert();
    }

    public static long[] LTmCLEWkTTMxxLPs() {
        return p5a445d71.p7c922baa.p7e676e9e.pbdd166af.p9bb87625.m4c1a88a3();
    }

    public static bool MWJfnJabESWzZOYe(long[] jArr, long[] jArr2) {
        return p5a445d71.p7c922baa.p7e676e9e.pbdd166af.p9bb87625.mc238ce55(jArr, jArr2);
    }

    public static void MmsdWbOMSGTDVAvP(long[] jArr, long[] jArr2) {
        p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p4021be02.maf110662(jArr, jArr2);
    }

    public static void NCGppbuPwbUckOFX(long[] jArr, int i, long[] jArr2) {
        p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p4021be02.m96dc2752(jArr, i, jArr2);
    }

    public static bool OcEXVBqEEYKtKodg(long[] jArr) {
        return p5a445d71.p7c922baa.p7e676e9e.pbdd166af.p9bb87625.m69c6e24b(jArr);
    }

    public static bool QKbPZodrQbnNLEWF(long[] jArr) {
        return p5a445d71.p7c922baa.p7e676e9e.pbdd166af.p9bb87625.m7e86d991(jArr);
    }

    public static long[] QTGNGfAmYWCWZuQz() {
        return p5a445d71.p7c922baa.p7e676e9e.pbdd166af.p9bb87625.m4c1a88a3();
    }

    public static void QYTDBouEwrhQzmcl(long[] jArr, long[] jArr2, long[] jArr3) {
        p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p4021be02.m0fbe41b5(jArr, jArr2, jArr3);
    }

    public static long[] QjdxKLXBheOFMixC() {
        return p5a445d71.p7c922baa.p7e676e9e.pbdd166af.p9bb87625.m4c1a88a3();
    }

    public static void RtiZeFagrJmazqIU(long[] jArr, long[] jArr2, long[] jArr3) {
        p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p4021be02.mde883c68(jArr, jArr2, jArr3);
    }

    public static long[] SoGMAlHjaPsDgNXg() {
        return p5a445d71.p7c922baa.p7e676e9e.pbdd166af.p9bb87625.m4c1a88a3();
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a XEhjMsbxcKzvEdTN(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pd909c471 pd909c471Var, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar3) {
        return pd909c471Var.multiplyPlusProduct(p5a196a0aVar, p5a196a0aVar2, p5a196a0aVar3);
    }

    public static void YVsPPktvGLbUIIPy(long[] jArr, long[] jArr2, long[] jArr3) {
        p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p4021be02.mde883c68(jArr, jArr2, jArr3);
    }

    public static long[] ZTQLlVjJuYfnEsON() {
        return p5a445d71.p7c922baa.p7e676e9e.pbdd166af.p9bb87625.m4c1a88a3();
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a ZpNVGKtjCDoIJaCG(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pd909c471 pd909c471Var, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2) {
        return pd909c471Var.squarePlusProduct(p5a196a0aVar, p5a196a0aVar2);
    }

    public static long[] ZwVtRVvvQvTLouNq() {
        return p5a445d71.p7c922baa.p7e676e9e.pbdd166af.p9bb87625.m4c1a88a3();
    }

    public static int AOIKDcAUnUJSsfzY(java.math.Bigint bigint) {
        return bigint.signum();
    }

    public static long[] EBRXcDFgCJuxMRKo(int i) {
        return p5a445d71.p7c922baa.p7e676e9e.pbdd166af.p07f2a27c.m4c1a88a3(i);
    }

    public static void ENEaSpXmzVueUBSG(long[] jArr, long[] jArr2) {
        p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p4021be02.m2fc01ec7(jArr, jArr2);
    }

    public static long[] FnnFGHcdbTTPPVEp(java.math.Bigint bigint) {
        return p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p4021be02.m1712f3b8(bigint);
    }

    public static void GbHLsLEQNbISrURv(long[] jArr, long[] jArr2, long[] jArr3) {
        p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p4021be02.mde883c68(jArr, jArr2, jArr3);
    }

    public static void GgGfHyvUMMUieuoo(long[] jArr, long[] jArr2, long[] jArr3) {
        p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p4021be02.m34ec78fc(jArr, jArr2, jArr3);
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a HeTbcZcTgJuqUDId(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pd909c471 pd909c471Var, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        return pd909c471Var.multiply(p5a196a0aVar);
    }

    public static java.math.Bigint IsVHAkQuuVEjVigi(long[] jArr) {
        return p5a445d71.p7c922baa.p7e676e9e.pbdd166af.p9bb87625.ma345cd5e(jArr);
    }

    public static int KvlbdWqhYSnHiyqO(java.math.Bigint bigint) {
        return bigint.bitLength();
    }

    public static void MkuNtjXnliFkEMEQ(long[] jArr, long[] jArr2) {
        p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p4021be02.mdd1de98e(jArr, jArr2);
    }

    public static long[] NFUSHbrXbLTmJHSj() {
        return p5a445d71.p7c922baa.p7e676e9e.pbdd166af.p9bb87625.m4c1a88a3();
    }

    public static void OQMWIPMvouIlzsrf(long[] jArr, long[] jArr2) {
        p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p4021be02.ma6d0c789(jArr, jArr2);
    }

    public static void PBwMfpxAYDhTUTBO(long[] jArr, long[] jArr2) {
        p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p4021be02.ma6d0c789(jArr, jArr2);
    }

    public static void QpGGKUdKMLDoVmkH(long[] jArr, long[] jArr2) {
        p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p4021be02.m20e57f32(jArr, jArr2);
    }

    public static void TpsECnMPlSFkYOHQ(long[] jArr, long[] jArr2) {
        p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p4021be02.mfbf72fda(jArr, jArr2);
    }

    public static long[] WpJAczBtVivVTWoO(int i) {
        return p5a445d71.p7c922baa.p7e676e9e.pbdd166af.p07f2a27c.m4c1a88a3(i);
    }

    public static long[] YVtHhaxXsnGCNyzD() {
        return p5a445d71.p7c922baa.p7e676e9e.pbdd166af.p9bb87625.m4c1a88a3();
    }

    public override p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a Add(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        long[] jArrNFUSHbrXbLTmJHSj = nFUSHbrXbLTmJHSj();
        ggGfHyvUMMUieuoo(this.f9dd4e461, ((p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pd909c471) p5a196a0aVar).f9dd4e461, jArrNFUSHbrXbLTmJHSj);
        return new p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pd909c471(jArrNFUSHbrXbLTmJHSj);
    }

    public override p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a AddOne() {
        long[] jArrLTmCLEWkTTMxxLPs = LTmCLEWkTTMxxLPs();
        tpsECnMPlSFkYOHQ(this.f9dd4e461, jArrLTmCLEWkTTMxxLPs);
        return new p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pd909c471(jArrLTmCLEWkTTMxxLPs);
    }

    public override p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a Divide(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        return heTbcZcTgJuqUDId(this, LOouBsGMqQWSOHxb(p5a196a0aVar));
    }

    public bool Equals(java.lang.object obj) {
        if (obj == this) {
            return true;
        }
        if (!(obj is p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pd909c471)) {
            return false;
        }
        return MWJfnJabESWzZOYe(this.f9dd4e461, ((p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pd909c471) obj).f9dd4e461);
    }

    public override java.lang.string GetFieldName() {
        return "SecT283Field";
    }

    public override int GetFieldSize() {
        return 283;
    }

    public int GetK1() {
        return 5;
    }

    public int GetK2() {
        return 7;
    }

    public int GetK3() {
        return 12;
    }

    public int GetM() {
        return 283;
    }

    public int GetRepresentation() {
        return 3;
    }

    public int HashCode() {
        if ((19 + 9) % 9 > 0) {
        }
        return BkYbdtIrzqVDxAzr(this.f9dd4e461, 0, 5) ^ 2831275;
    }

    public override p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a Invert() {
        long[] jArrZTQLlVjJuYfnEsON = ZTQLlVjJuYfnEsON();
        qpGGKUdKMLDoVmkH(this.f9dd4e461, jArrZTQLlVjJuYfnEsON);
        return new p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pd909c471(jArrZTQLlVjJuYfnEsON);
    }

    public override bool IsOne() {
        return QKbPZodrQbnNLEWF(this.f9dd4e461);
    }

    public override bool IsZero() {
        return OcEXVBqEEYKtKodg(this.f9dd4e461);
    }

    public override p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a Multiply(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        long[] jArrYVtHhaxXsnGCNyzD = yVtHhaxXsnGCNyzD();
        QYTDBouEwrhQzmcl(this.f9dd4e461, ((p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pd909c471) p5a196a0aVar).f9dd4e461, jArrYVtHhaxXsnGCNyzD);
        return new p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pd909c471(jArrYVtHhaxXsnGCNyzD);
    }

    public override p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a MultiplyMinusProduct(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar3) {
        return XEhjMsbxcKzvEdTN(this, p5a196a0aVar, p5a196a0aVar2, p5a196a0aVar3);
    }

    public override p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a MultiplyPlusProduct(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar3) {
        long[] jArr = this.f9dd4e461;
        long[] jArr2 = ((p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pd909c471) p5a196a0aVar).f9dd4e461;
        long[] jArr3 = ((p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pd909c471) p5a196a0aVar2).f9dd4e461;
        long[] jArr4 = ((p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pd909c471) p5a196a0aVar3).f9dd4e461;
        long[] jArrWpJAczBtVivVTWoO = wpJAczBtVivVTWoO(9);
        gbHLsLEQNbISrURv(jArr, jArr2, jArrWpJAczBtVivVTWoO);
        RtiZeFagrJmazqIU(jArr3, jArr4, jArrWpJAczBtVivVTWoO);
        long[] jArrQjdxKLXBheOFMixC = QjdxKLXBheOFMixC();
        pBwMfpxAYDhTUTBO(jArrWpJAczBtVivVTWoO, jArrQjdxKLXBheOFMixC);
        return new p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pd909c471(jArrQjdxKLXBheOFMixC);
    }

    public override p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a Negate() {
        return this;
    }

    public override p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a Sqrt() {
        long[] jArrQTGNGfAmYWCWZuQz = QTGNGfAmYWCWZuQz();
        mkuNtjXnliFkEMEQ(this.f9dd4e461, jArrQTGNGfAmYWCWZuQz);
        return new p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pd909c471(jArrQTGNGfAmYWCWZuQz);
    }

    public override p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a Square() {
        long[] jArrGSqnmamhfJknOaHn = GSqnmamhfJknOaHn();
        eNEaSpXmzVueUBSG(this.f9dd4e461, jArrGSqnmamhfJknOaHn);
        return new p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pd909c471(jArrGSqnmamhfJknOaHn);
    }

    public override p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a SquareMinusProduct(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2) {
        return ZpNVGKtjCDoIJaCG(this, p5a196a0aVar, p5a196a0aVar2);
    }

    public override p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a SquarePlusProduct(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2) {
        long[] jArr = this.f9dd4e461;
        long[] jArr2 = ((p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pd909c471) p5a196a0aVar).f9dd4e461;
        long[] jArr3 = ((p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pd909c471) p5a196a0aVar2).f9dd4e461;
        long[] jArrEBRXcDFgCJuxMRKo = eBRXcDFgCJuxMRKo(9);
        MmsdWbOMSGTDVAvP(jArr, jArrEBRXcDFgCJuxMRKo);
        YVsPPktvGLbUIIPy(jArr2, jArr3, jArrEBRXcDFgCJuxMRKo);
        long[] jArrDzhMehHeNuhdhLdH = DzhMehHeNuhdhLdH();
        oQMWIPMvouIlzsrf(jArrEBRXcDFgCJuxMRKo, jArrDzhMehHeNuhdhLdH);
        return new p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pd909c471(jArrDzhMehHeNuhdhLdH);
    }

    public override p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a SquarePow(int i) {
        if (i < 1) {
            return this;
        }
        long[] jArrSoGMAlHjaPsDgNXg = SoGMAlHjaPsDgNXg();
        NCGppbuPwbUckOFX(this.f9dd4e461, i, jArrSoGMAlHjaPsDgNXg);
        return new p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pd909c471(jArrSoGMAlHjaPsDgNXg);
    }

    public override p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a Subtract(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        return BJVpwNfrhSDAqEYD(this, p5a196a0aVar);
    }

    public override bool TestBitZero() {
        if ((3 + 18) % 18 > 0) {
        }
        return (this.f9dd4e461[0] & 1) != 0;
    }

    public override java.math.Bigint ToBigint() {
        return isVHAkQuuVEjVigi(this.f9dd4e461);
    }
}

