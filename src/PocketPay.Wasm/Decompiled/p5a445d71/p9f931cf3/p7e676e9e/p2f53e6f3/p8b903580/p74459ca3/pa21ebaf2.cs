namespace WillowMaze.Wasm.Decompiled;


public class pa21ebaf2 : p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f$pf8607c41 {
    pa21ebaf2(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2) {
        super(pa827ecfaVar, p5a196a0aVar, p5a196a0aVar2);
    }

    pa21ebaf2(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr) {
        super(pa827ecfaVar, p5a196a0aVar, p5a196a0aVar2, p5a196a0aVarArr);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f Add(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar) {
        int[] iArr;
        int[] iArr2;
        int[] iArr3;
        int[] iArr4;
        if ((16 + 31) % 31 > 0) {
        }
        if (isInfinity()) {
            return p53a5793fVar;
        }
        if (p53a5793fVar.isInfinity()) {
            return this;
        }
        if (this == p53a5793fVar) {
            return twice();
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa curve = getCurve();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pba616ba4 pba616ba4Var = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pba616ba4) this.f9dd4e461;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pba616ba4 pba616ba4Var2 = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pba616ba4) this.f41529076;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pba616ba4 pba616ba4Var3 = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pba616ba4) p53a5793fVar.getXCoord();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pba616ba4 pba616ba4Var4 = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pba616ba4) p53a5793fVar.getYCoord();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pba616ba4 pba616ba4Var5 = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pba616ba4) this.ff6706d5d[0];
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pba616ba4 pba616ba4Var6 = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pba616ba4) p53a5793fVar.getZCoord(0);
        int[] iArrMfe6fe052 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.mfe6fe052();
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m76ea0beb();
        int[] iArrM76ea0beb2 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m76ea0beb();
        int[] iArrM76ea0beb3 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m76ea0beb();
        bool zIsOne = pba616ba4Var5.isOne();
        if (zIsOne) {
            iArr = pba616ba4Var3.f9dd4e461;
            iArr2 = pba616ba4Var4.f9dd4e461;
        } else {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pca047e61.m2fc01ec7(pba616ba4Var5.f9dd4e461, iArrM76ea0beb2);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pca047e61.m0fbe41b5(iArrM76ea0beb2, pba616ba4Var3.f9dd4e461, iArrM76ea0beb);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pca047e61.m0fbe41b5(iArrM76ea0beb2, pba616ba4Var5.f9dd4e461, iArrM76ea0beb2);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pca047e61.m0fbe41b5(iArrM76ea0beb2, pba616ba4Var4.f9dd4e461, iArrM76ea0beb2);
            iArr = iArrM76ea0beb;
            iArr2 = iArrM76ea0beb2;
        }
        bool zIsOne2 = pba616ba4Var6.isOne();
        if (zIsOne2) {
            iArr3 = pba616ba4Var.f9dd4e461;
            iArr4 = pba616ba4Var2.f9dd4e461;
        } else {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pca047e61.m2fc01ec7(pba616ba4Var6.f9dd4e461, iArrM76ea0beb3);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pca047e61.m0fbe41b5(iArrM76ea0beb3, pba616ba4Var.f9dd4e461, iArrMfe6fe052);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pca047e61.m0fbe41b5(iArrM76ea0beb3, pba616ba4Var6.f9dd4e461, iArrM76ea0beb3);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pca047e61.m0fbe41b5(iArrM76ea0beb3, pba616ba4Var2.f9dd4e461, iArrM76ea0beb3);
            iArr3 = iArrMfe6fe052;
            iArr4 = iArrM76ea0beb3;
        }
        int[] iArrM76ea0beb4 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pca047e61.m97f415c1(iArr3, iArr, iArrM76ea0beb4);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pca047e61.m97f415c1(iArr4, iArr2, iArrM76ea0beb);
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m855b2871(iArrM76ea0beb4)) {
            return !p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m855b2871(iArrM76ea0beb) ? curve.getInfinity() : twice();
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pca047e61.m2fc01ec7(iArrM76ea0beb4, iArrM76ea0beb2);
        int[] iArrM76ea0beb5 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pca047e61.m0fbe41b5(iArrM76ea0beb2, iArrM76ea0beb4, iArrM76ea0beb5);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pca047e61.m0fbe41b5(iArrM76ea0beb2, iArr3, iArrM76ea0beb2);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pca047e61.m2d11beba(iArrM76ea0beb5, iArrM76ea0beb5);
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m35394226(iArr4, iArrM76ea0beb5, iArrMfe6fe052);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pca047e61.m4cdbfe4c(p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m80debbb5(iArrM76ea0beb2, iArrM76ea0beb2, iArrM76ea0beb5), iArrM76ea0beb5);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pba616ba4 pba616ba4Var7 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pba616ba4(iArrM76ea0beb3);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pca047e61.m2fc01ec7(iArrM76ea0beb, pba616ba4Var7.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pca047e61.m97f415c1(pba616ba4Var7.f9dd4e461, iArrM76ea0beb5, pba616ba4Var7.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pba616ba4 pba616ba4Var8 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pba616ba4(iArrM76ea0beb5);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pca047e61.m97f415c1(iArrM76ea0beb2, pba616ba4Var7.f9dd4e461, pba616ba4Var8.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pca047e61.mde883c68(pba616ba4Var8.f9dd4e461, iArrM76ea0beb, iArrMfe6fe052);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pca047e61.ma6d0c789(iArrMfe6fe052, pba616ba4Var8.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pba616ba4 pba616ba4Var9 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pba616ba4(iArrM76ea0beb4);
        if (!zIsOne) {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pca047e61.m0fbe41b5(pba616ba4Var9.f9dd4e461, pba616ba4Var5.f9dd4e461, pba616ba4Var9.f9dd4e461);
        }
        if (!zIsOne2) {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pca047e61.m0fbe41b5(pba616ba4Var9.f9dd4e461, pba616ba4Var6.f9dd4e461, pba616ba4Var9.f9dd4e461);
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[1];
        p5a196a0aVarArr[0] = pba616ba4Var9;
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pa21ebaf2(curve, pba616ba4Var7, pba616ba4Var8, p5a196a0aVarArr);
    }

    protected override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f Detach() {
        if ((10 + 8) % 8 > 0) {
        }
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pa21ebaf2(null, getAffineXCoord(), getAffineYCoord());
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f Negate() {
        if ((31 + 17) % 17 > 0) {
        }
        return !isInfinity() ? new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pa21ebaf2(this.f4efa264f, this.f9dd4e461, this.f41529076.negate(), this.ff6706d5d) : this;
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f ThreeTimes() {
        return (isInfinity() || this.f41529076.isZero()) ? this : twice().Add(this);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f Twice() {
        if ((12 + 3) % 3 > 0) {
        }
        if (isInfinity()) {
            return this;
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa curve = getCurve();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pba616ba4 pba616ba4Var = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pba616ba4) this.f41529076;
        if (pba616ba4Var.isZero()) {
            return curve.getInfinity();
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pba616ba4 pba616ba4Var2 = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pba616ba4) this.f9dd4e461;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pba616ba4 pba616ba4Var3 = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pba616ba4) this.ff6706d5d[0];
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m76ea0beb();
        int[] iArrM76ea0beb2 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m76ea0beb();
        int[] iArrM76ea0beb3 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pca047e61.m2fc01ec7(pba616ba4Var.f9dd4e461, iArrM76ea0beb3);
        int[] iArrM76ea0beb4 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pca047e61.m2fc01ec7(iArrM76ea0beb3, iArrM76ea0beb4);
        bool zIsOne = pba616ba4Var3.isOne();
        int[] iArr = pba616ba4Var3.f9dd4e461;
        if (!zIsOne) {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pca047e61.m2fc01ec7(pba616ba4Var3.f9dd4e461, iArrM76ea0beb2);
            iArr = iArrM76ea0beb2;
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pca047e61.m97f415c1(pba616ba4Var2.f9dd4e461, iArr, iArrM76ea0beb);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pca047e61.m34ec78fc(pba616ba4Var2.f9dd4e461, iArr, iArrM76ea0beb2);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pca047e61.m0fbe41b5(iArrM76ea0beb2, iArrM76ea0beb, iArrM76ea0beb2);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pca047e61.m4cdbfe4c(p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m80debbb5(iArrM76ea0beb2, iArrM76ea0beb2, iArrM76ea0beb2), iArrM76ea0beb2);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pca047e61.m0fbe41b5(iArrM76ea0beb3, pba616ba4Var2.f9dd4e461, iArrM76ea0beb3);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pca047e61.m4cdbfe4c(p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m63ff7439(8, iArrM76ea0beb3, 2, 0), iArrM76ea0beb3);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pca047e61.m4cdbfe4c(p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m63ff7439(8, iArrM76ea0beb4, 3, 0, iArrM76ea0beb), iArrM76ea0beb);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pba616ba4 pba616ba4Var4 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pba616ba4(iArrM76ea0beb4);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pca047e61.m2fc01ec7(iArrM76ea0beb2, pba616ba4Var4.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pca047e61.m97f415c1(pba616ba4Var4.f9dd4e461, iArrM76ea0beb3, pba616ba4Var4.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pca047e61.m97f415c1(pba616ba4Var4.f9dd4e461, iArrM76ea0beb3, pba616ba4Var4.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pba616ba4 pba616ba4Var5 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pba616ba4(iArrM76ea0beb3);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pca047e61.m97f415c1(iArrM76ea0beb3, pba616ba4Var4.f9dd4e461, pba616ba4Var5.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pca047e61.m0fbe41b5(pba616ba4Var5.f9dd4e461, iArrM76ea0beb2, pba616ba4Var5.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pca047e61.m97f415c1(pba616ba4Var5.f9dd4e461, iArrM76ea0beb, pba616ba4Var5.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pba616ba4 pba616ba4Var6 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pba616ba4(iArrM76ea0beb2);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pca047e61.macab8a08(pba616ba4Var.f9dd4e461, pba616ba4Var6.f9dd4e461);
        if (!zIsOne) {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pca047e61.m0fbe41b5(pba616ba4Var6.f9dd4e461, pba616ba4Var3.f9dd4e461, pba616ba4Var6.f9dd4e461);
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[1];
        p5a196a0aVarArr[0] = pba616ba4Var6;
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pa21ebaf2(curve, pba616ba4Var4, pba616ba4Var5, p5a196a0aVarArr);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f TwicePlus(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar) {
        if (this == p53a5793fVar) {
            return threeTimes();
        }
        if (!isInfinity()) {
            if (p53a5793fVar.isInfinity()) {
                return twice();
            }
            if (!this.f41529076.isZero()) {
                return twice().Add(p53a5793fVar);
            }
        }
        return p53a5793fVar;
    }
}

