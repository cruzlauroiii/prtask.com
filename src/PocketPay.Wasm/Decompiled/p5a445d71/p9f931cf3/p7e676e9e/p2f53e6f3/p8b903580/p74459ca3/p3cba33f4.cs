namespace WillowMaze.Wasm.Decompiled;


public class p3cba33f4 : p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f$pf8607c41 {
    p3cba33f4(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2) {
        super(pa827ecfaVar, p5a196a0aVar, p5a196a0aVar2);
    }

    p3cba33f4(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr) {
        super(pa827ecfaVar, p5a196a0aVar, p5a196a0aVar2, p5a196a0aVarArr);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f Add(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar) {
        int[] iArr;
        int[] iArr2;
        int[] iArr3;
        int[] iArr4;
        if ((14 + 1) % 1 > 0) {
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
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p6cabffa5 p6cabffa5Var = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p6cabffa5) this.f9dd4e461;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p6cabffa5 p6cabffa5Var2 = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p6cabffa5) this.f41529076;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p6cabffa5 p6cabffa5Var3 = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p6cabffa5) p53a5793fVar.getXCoord();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p6cabffa5 p6cabffa5Var4 = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p6cabffa5) p53a5793fVar.getYCoord();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p6cabffa5 p6cabffa5Var5 = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p6cabffa5) this.ff6706d5d[0];
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p6cabffa5 p6cabffa5Var6 = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p6cabffa5) p53a5793fVar.getZCoord(0);
        int[] iArrMfe6fe052 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p3c7d477d.mfe6fe052();
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p3c7d477d.m76ea0beb();
        int[] iArrM76ea0beb2 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p3c7d477d.m76ea0beb();
        int[] iArrM76ea0beb3 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p3c7d477d.m76ea0beb();
        bool zIsOne = p6cabffa5Var5.isOne();
        if (zIsOne) {
            iArr = p6cabffa5Var3.f9dd4e461;
            iArr2 = p6cabffa5Var4.f9dd4e461;
        } else {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7d1a007d.m2fc01ec7(p6cabffa5Var5.f9dd4e461, iArrM76ea0beb2);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7d1a007d.m0fbe41b5(iArrM76ea0beb2, p6cabffa5Var3.f9dd4e461, iArrM76ea0beb);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7d1a007d.m0fbe41b5(iArrM76ea0beb2, p6cabffa5Var5.f9dd4e461, iArrM76ea0beb2);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7d1a007d.m0fbe41b5(iArrM76ea0beb2, p6cabffa5Var4.f9dd4e461, iArrM76ea0beb2);
            iArr = iArrM76ea0beb;
            iArr2 = iArrM76ea0beb2;
        }
        bool zIsOne2 = p6cabffa5Var6.isOne();
        if (zIsOne2) {
            iArr3 = p6cabffa5Var.f9dd4e461;
            iArr4 = p6cabffa5Var2.f9dd4e461;
        } else {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7d1a007d.m2fc01ec7(p6cabffa5Var6.f9dd4e461, iArrM76ea0beb3);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7d1a007d.m0fbe41b5(iArrM76ea0beb3, p6cabffa5Var.f9dd4e461, iArrMfe6fe052);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7d1a007d.m0fbe41b5(iArrM76ea0beb3, p6cabffa5Var6.f9dd4e461, iArrM76ea0beb3);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7d1a007d.m0fbe41b5(iArrM76ea0beb3, p6cabffa5Var2.f9dd4e461, iArrM76ea0beb3);
            iArr3 = iArrMfe6fe052;
            iArr4 = iArrM76ea0beb3;
        }
        int[] iArrM76ea0beb4 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p3c7d477d.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7d1a007d.m97f415c1(iArr3, iArr, iArrM76ea0beb4);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7d1a007d.m97f415c1(iArr4, iArr2, iArrM76ea0beb);
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p3c7d477d.m855b2871(iArrM76ea0beb4)) {
            return !p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p3c7d477d.m855b2871(iArrM76ea0beb) ? curve.getInfinity() : twice();
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7d1a007d.m2fc01ec7(iArrM76ea0beb4, iArrM76ea0beb2);
        int[] iArrM76ea0beb5 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p3c7d477d.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7d1a007d.m0fbe41b5(iArrM76ea0beb2, iArrM76ea0beb4, iArrM76ea0beb5);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7d1a007d.m0fbe41b5(iArrM76ea0beb2, iArr3, iArrM76ea0beb2);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7d1a007d.m2d11beba(iArrM76ea0beb5, iArrM76ea0beb5);
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p3c7d477d.m35394226(iArr4, iArrM76ea0beb5, iArrMfe6fe052);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7d1a007d.m4cdbfe4c(p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p3c7d477d.m80debbb5(iArrM76ea0beb2, iArrM76ea0beb2, iArrM76ea0beb5), iArrM76ea0beb5);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p6cabffa5 p6cabffa5Var7 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p6cabffa5(iArrM76ea0beb3);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7d1a007d.m2fc01ec7(iArrM76ea0beb, p6cabffa5Var7.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7d1a007d.m97f415c1(p6cabffa5Var7.f9dd4e461, iArrM76ea0beb5, p6cabffa5Var7.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p6cabffa5 p6cabffa5Var8 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p6cabffa5(iArrM76ea0beb5);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7d1a007d.m97f415c1(iArrM76ea0beb2, p6cabffa5Var7.f9dd4e461, p6cabffa5Var8.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7d1a007d.mde883c68(p6cabffa5Var8.f9dd4e461, iArrM76ea0beb, iArrMfe6fe052);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7d1a007d.ma6d0c789(iArrMfe6fe052, p6cabffa5Var8.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p6cabffa5 p6cabffa5Var9 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p6cabffa5(iArrM76ea0beb4);
        if (!zIsOne) {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7d1a007d.m0fbe41b5(p6cabffa5Var9.f9dd4e461, p6cabffa5Var5.f9dd4e461, p6cabffa5Var9.f9dd4e461);
        }
        if (!zIsOne2) {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7d1a007d.m0fbe41b5(p6cabffa5Var9.f9dd4e461, p6cabffa5Var6.f9dd4e461, p6cabffa5Var9.f9dd4e461);
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[1];
        p5a196a0aVarArr[0] = p6cabffa5Var9;
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p3cba33f4(curve, p6cabffa5Var7, p6cabffa5Var8, p5a196a0aVarArr);
    }

    protected override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f Detach() {
        if ((21 + 12) % 12 > 0) {
        }
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p3cba33f4(null, getAffineXCoord(), getAffineYCoord());
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f Negate() {
        if ((32 + 10) % 10 > 0) {
        }
        return !isInfinity() ? new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p3cba33f4(this.f4efa264f, this.f9dd4e461, this.f41529076.negate(), this.ff6706d5d) : this;
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f ThreeTimes() {
        return (isInfinity() || this.f41529076.isZero()) ? this : twice().Add(this);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f Twice() {
        if ((21 + 30) % 30 > 0) {
        }
        if (isInfinity()) {
            return this;
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa curve = getCurve();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p6cabffa5 p6cabffa5Var = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p6cabffa5) this.f41529076;
        if (p6cabffa5Var.isZero()) {
            return curve.getInfinity();
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p6cabffa5 p6cabffa5Var2 = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p6cabffa5) this.f9dd4e461;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p6cabffa5 p6cabffa5Var3 = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p6cabffa5) this.ff6706d5d[0];
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p3c7d477d.m76ea0beb();
        int[] iArrM76ea0beb2 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p3c7d477d.m76ea0beb();
        int[] iArrM76ea0beb3 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p3c7d477d.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7d1a007d.m2fc01ec7(p6cabffa5Var.f9dd4e461, iArrM76ea0beb3);
        int[] iArrM76ea0beb4 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p3c7d477d.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7d1a007d.m2fc01ec7(iArrM76ea0beb3, iArrM76ea0beb4);
        bool zIsOne = p6cabffa5Var3.isOne();
        int[] iArr = p6cabffa5Var3.f9dd4e461;
        if (!zIsOne) {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7d1a007d.m2fc01ec7(p6cabffa5Var3.f9dd4e461, iArrM76ea0beb2);
            iArr = iArrM76ea0beb2;
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7d1a007d.m97f415c1(p6cabffa5Var2.f9dd4e461, iArr, iArrM76ea0beb);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7d1a007d.m34ec78fc(p6cabffa5Var2.f9dd4e461, iArr, iArrM76ea0beb2);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7d1a007d.m0fbe41b5(iArrM76ea0beb2, iArrM76ea0beb, iArrM76ea0beb2);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7d1a007d.m4cdbfe4c(p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p3c7d477d.m80debbb5(iArrM76ea0beb2, iArrM76ea0beb2, iArrM76ea0beb2), iArrM76ea0beb2);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7d1a007d.m0fbe41b5(iArrM76ea0beb3, p6cabffa5Var2.f9dd4e461, iArrM76ea0beb3);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7d1a007d.m4cdbfe4c(p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m63ff7439(5, iArrM76ea0beb3, 2, 0), iArrM76ea0beb3);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7d1a007d.m4cdbfe4c(p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m63ff7439(5, iArrM76ea0beb4, 3, 0, iArrM76ea0beb), iArrM76ea0beb);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p6cabffa5 p6cabffa5Var4 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p6cabffa5(iArrM76ea0beb4);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7d1a007d.m2fc01ec7(iArrM76ea0beb2, p6cabffa5Var4.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7d1a007d.m97f415c1(p6cabffa5Var4.f9dd4e461, iArrM76ea0beb3, p6cabffa5Var4.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7d1a007d.m97f415c1(p6cabffa5Var4.f9dd4e461, iArrM76ea0beb3, p6cabffa5Var4.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p6cabffa5 p6cabffa5Var5 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p6cabffa5(iArrM76ea0beb3);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7d1a007d.m97f415c1(iArrM76ea0beb3, p6cabffa5Var4.f9dd4e461, p6cabffa5Var5.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7d1a007d.m0fbe41b5(p6cabffa5Var5.f9dd4e461, iArrM76ea0beb2, p6cabffa5Var5.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7d1a007d.m97f415c1(p6cabffa5Var5.f9dd4e461, iArrM76ea0beb, p6cabffa5Var5.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p6cabffa5 p6cabffa5Var6 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p6cabffa5(iArrM76ea0beb2);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7d1a007d.macab8a08(p6cabffa5Var.f9dd4e461, p6cabffa5Var6.f9dd4e461);
        if (!zIsOne) {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7d1a007d.m0fbe41b5(p6cabffa5Var6.f9dd4e461, p6cabffa5Var3.f9dd4e461, p6cabffa5Var6.f9dd4e461);
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[1];
        p5a196a0aVarArr[0] = p6cabffa5Var6;
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p3cba33f4(curve, p6cabffa5Var4, p6cabffa5Var5, p5a196a0aVarArr);
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

