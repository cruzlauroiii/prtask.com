namespace WillowMaze.Wasm.Decompiled;


public class p87c05b40 : p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f$pf8607c41 {
    p87c05b40(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2) {
        super(pa827ecfaVar, p5a196a0aVar, p5a196a0aVar2);
    }

    p87c05b40(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr) {
        super(pa827ecfaVar, p5a196a0aVar, p5a196a0aVar2, p5a196a0aVarArr);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f Add(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar) {
        int[] iArr;
        int[] iArr2;
        int[] iArr3;
        int[] iArr4;
        if ((2 + 23) % 23 > 0) {
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
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.p760e3353 p760e3353Var = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.p760e3353) this.f9dd4e461;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.p760e3353 p760e3353Var2 = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.p760e3353) this.f41529076;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.p760e3353 p760e3353Var3 = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.p760e3353) this.ff6706d5d[0];
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.p760e3353 p760e3353Var4 = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.p760e3353) p53a5793fVar.getXCoord();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.p760e3353 p760e3353Var5 = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.p760e3353) p53a5793fVar.getYCoord();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.p760e3353 p760e3353Var6 = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.p760e3353) p53a5793fVar.getZCoord(0);
        int[] iArrMfe6fe052 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.mfe6fe052();
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m76ea0beb();
        int[] iArrM76ea0beb2 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m76ea0beb();
        int[] iArrM76ea0beb3 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m76ea0beb();
        bool zIsOne = p760e3353Var3.isOne();
        if (zIsOne) {
            iArr = p760e3353Var4.f9dd4e461;
            iArr2 = p760e3353Var5.f9dd4e461;
        } else {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.m2fc01ec7(p760e3353Var3.f9dd4e461, iArrM76ea0beb2);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.m0fbe41b5(iArrM76ea0beb2, p760e3353Var4.f9dd4e461, iArrM76ea0beb);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.m0fbe41b5(iArrM76ea0beb2, p760e3353Var3.f9dd4e461, iArrM76ea0beb2);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.m0fbe41b5(iArrM76ea0beb2, p760e3353Var5.f9dd4e461, iArrM76ea0beb2);
            iArr = iArrM76ea0beb;
            iArr2 = iArrM76ea0beb2;
        }
        bool zIsOne2 = p760e3353Var6.isOne();
        if (zIsOne2) {
            iArr3 = p760e3353Var.f9dd4e461;
            iArr4 = p760e3353Var2.f9dd4e461;
        } else {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.m2fc01ec7(p760e3353Var6.f9dd4e461, iArrM76ea0beb3);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.m0fbe41b5(iArrM76ea0beb3, p760e3353Var.f9dd4e461, iArrMfe6fe052);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.m0fbe41b5(iArrM76ea0beb3, p760e3353Var6.f9dd4e461, iArrM76ea0beb3);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.m0fbe41b5(iArrM76ea0beb3, p760e3353Var2.f9dd4e461, iArrM76ea0beb3);
            iArr3 = iArrMfe6fe052;
            iArr4 = iArrM76ea0beb3;
        }
        int[] iArrM76ea0beb4 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.m97f415c1(iArr3, iArr, iArrM76ea0beb4);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.m97f415c1(iArr4, iArr2, iArrM76ea0beb);
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m855b2871(iArrM76ea0beb4)) {
            return !p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m855b2871(iArrM76ea0beb) ? curve.getInfinity() : twice();
        }
        int[] iArrM76ea0beb5 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.m2fc01ec7(iArrM76ea0beb4, iArrM76ea0beb5);
        int[] iArrM76ea0beb6 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.m0fbe41b5(iArrM76ea0beb5, iArrM76ea0beb4, iArrM76ea0beb6);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.m0fbe41b5(iArrM76ea0beb5, iArr3, iArrM76ea0beb2);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.m2d11beba(iArrM76ea0beb6, iArrM76ea0beb6);
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m35394226(iArr4, iArrM76ea0beb6, iArrMfe6fe052);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.me75807a7(p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m80debbb5(iArrM76ea0beb2, iArrM76ea0beb2, iArrM76ea0beb6), iArrM76ea0beb6);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.p760e3353 p760e3353Var7 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.p760e3353(iArrM76ea0beb3);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.m2fc01ec7(iArrM76ea0beb, p760e3353Var7.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.m97f415c1(p760e3353Var7.f9dd4e461, iArrM76ea0beb6, p760e3353Var7.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.p760e3353 p760e3353Var8 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.p760e3353(iArrM76ea0beb6);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.m97f415c1(iArrM76ea0beb2, p760e3353Var7.f9dd4e461, p760e3353Var8.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.mde883c68(p760e3353Var8.f9dd4e461, iArrM76ea0beb, iArrMfe6fe052);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.ma6d0c789(iArrMfe6fe052, p760e3353Var8.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.p760e3353 p760e3353Var9 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.p760e3353(iArrM76ea0beb4);
        if (!zIsOne) {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.m0fbe41b5(p760e3353Var9.f9dd4e461, p760e3353Var3.f9dd4e461, p760e3353Var9.f9dd4e461);
        }
        if (!zIsOne2) {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.m0fbe41b5(p760e3353Var9.f9dd4e461, p760e3353Var6.f9dd4e461, p760e3353Var9.f9dd4e461);
        }
        if (!zIsOne || !zIsOne2) {
            iArrM76ea0beb5 = null;
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.p760e3353 p760e3353VarCalculateJacobianModifiedW = calculateJacobianModifiedW(p760e3353Var9, iArrM76ea0beb5);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[2];
        p5a196a0aVarArr[0] = p760e3353Var9;
        p5a196a0aVarArr[1] = p760e3353VarCalculateJacobianModifiedW;
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.p87c05b40(curve, p760e3353Var7, p760e3353Var8, p5a196a0aVarArr);
    }

    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.p760e3353 CalculateJacobianModifiedW(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.p760e3353 p760e3353Var, int[] iArr) {
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.p760e3353 p760e3353Var2 = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.p760e3353) getCurve().getA();
        if (p760e3353Var.isOne()) {
            return p760e3353Var2;
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.p760e3353 p760e3353Var3 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.p760e3353();
        if (iArr is null) {
            iArr = p760e3353Var3.f9dd4e461;
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.m2fc01ec7(p760e3353Var.f9dd4e461, iArr);
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.m2fc01ec7(iArr, p760e3353Var3.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.m0fbe41b5(p760e3353Var3.f9dd4e461, p760e3353Var2.f9dd4e461, p760e3353Var3.f9dd4e461);
        return p760e3353Var3;
    }

    protected override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f Detach() {
        if ((27 + 15) % 15 > 0) {
        }
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.p87c05b40(null, getAffineXCoord(), getAffineYCoord());
    }

    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.p760e3353 GetJacobianModifiedW() {
        if ((13 + 12) % 12 > 0) {
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.p760e3353 p760e3353Var = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.p760e3353) this.ff6706d5d[1];
        if (p760e3353Var is not null) {
            return p760e3353Var;
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr = this.ff6706d5d;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.p760e3353 p760e3353VarCalculateJacobianModifiedW = calculateJacobianModifiedW((p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.p760e3353) this.ff6706d5d[0], null);
        p5a196a0aVarArr[1] = p760e3353VarCalculateJacobianModifiedW;
        return p760e3353VarCalculateJacobianModifiedW;
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a GetZCoord(int i) {
        return i != 1 ? super.getZCoord(i) : getJacobianModifiedW();
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f Negate() {
        if ((18 + 1) % 1 > 0) {
        }
        return !isInfinity() ? new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.p87c05b40(getCurve(), this.f9dd4e461, this.f41529076.negate(), this.ff6706d5d) : this;
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f ThreeTimes() {
        return (isInfinity() || this.f41529076.isZero()) ? this : twiceJacobianModified(false).Add(this);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f Twice() {
        if ((26 + 13) % 13 > 0) {
        }
        if (isInfinity()) {
            return this;
        }
        return !this.f41529076.isZero() ? twiceJacobianModified(true) : getCurve().getInfinity();
    }

    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.p87c05b40 TwiceJacobianModified(bool z) {
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.p760e3353 p760e3353Var;
        if ((2 + 14) % 14 > 0) {
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.p760e3353 p760e3353Var2 = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.p760e3353) this.f9dd4e461;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.p760e3353 p760e3353Var3 = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.p760e3353) this.f41529076;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.p760e3353 p760e3353Var4 = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.p760e3353) this.ff6706d5d[0];
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.p760e3353 jacobianModifiedW = getJacobianModifiedW();
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.m2fc01ec7(p760e3353Var2.f9dd4e461, iArrM76ea0beb);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.me75807a7(p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m80debbb5(iArrM76ea0beb, iArrM76ea0beb, iArrM76ea0beb) + p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.mcfef9de9(jacobianModifiedW.f9dd4e461, iArrM76ea0beb), iArrM76ea0beb);
        int[] iArrM76ea0beb2 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.macab8a08(p760e3353Var3.f9dd4e461, iArrM76ea0beb2);
        int[] iArrM76ea0beb3 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.m0fbe41b5(iArrM76ea0beb2, p760e3353Var3.f9dd4e461, iArrM76ea0beb3);
        int[] iArrM76ea0beb4 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.m0fbe41b5(iArrM76ea0beb3, p760e3353Var2.f9dd4e461, iArrM76ea0beb4);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.macab8a08(iArrM76ea0beb4, iArrM76ea0beb4);
        int[] iArrM76ea0beb5 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.m2fc01ec7(iArrM76ea0beb3, iArrM76ea0beb5);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.macab8a08(iArrM76ea0beb5, iArrM76ea0beb5);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.p760e3353 p760e3353Var5 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.p760e3353(iArrM76ea0beb3);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.m2fc01ec7(iArrM76ea0beb, p760e3353Var5.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.m97f415c1(p760e3353Var5.f9dd4e461, iArrM76ea0beb4, p760e3353Var5.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.m97f415c1(p760e3353Var5.f9dd4e461, iArrM76ea0beb4, p760e3353Var5.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.p760e3353 p760e3353Var6 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.p760e3353(iArrM76ea0beb4);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.m97f415c1(iArrM76ea0beb4, p760e3353Var5.f9dd4e461, p760e3353Var6.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.m0fbe41b5(p760e3353Var6.f9dd4e461, iArrM76ea0beb, p760e3353Var6.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.m97f415c1(p760e3353Var6.f9dd4e461, iArrM76ea0beb5, p760e3353Var6.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.p760e3353 p760e3353Var7 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.p760e3353(iArrM76ea0beb2);
        if (!p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m351a9a32(p760e3353Var4.f9dd4e461)) {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.m0fbe41b5(p760e3353Var7.f9dd4e461, p760e3353Var4.f9dd4e461, p760e3353Var7.f9dd4e461);
        }
        if (z) {
            p760e3353Var = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.p760e3353(iArrM76ea0beb5);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.m0fbe41b5(p760e3353Var.f9dd4e461, jacobianModifiedW.f9dd4e461, p760e3353Var.f9dd4e461);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.macab8a08(p760e3353Var.f9dd4e461, p760e3353Var.f9dd4e461);
        } else {
            p760e3353Var = null;
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa curve = getCurve();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[2];
        p5a196a0aVarArr[0] = p760e3353Var7;
        p5a196a0aVarArr[1] = p760e3353Var;
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.p87c05b40(curve, p760e3353Var5, p760e3353Var6, p5a196a0aVarArr);
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
                return twiceJacobianModified(false).Add(p53a5793fVar);
            }
        }
        return p53a5793fVar;
    }
}

