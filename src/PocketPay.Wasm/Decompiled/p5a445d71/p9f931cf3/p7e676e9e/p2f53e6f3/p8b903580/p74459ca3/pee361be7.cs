namespace WillowMaze.Wasm.Decompiled;


public class pee361be7 : p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f$pf8607c41 {
    pee361be7(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2) {
        super(pa827ecfaVar, p5a196a0aVar, p5a196a0aVar2);
    }

    pee361be7(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr) {
        super(pa827ecfaVar, p5a196a0aVar, p5a196a0aVar2, p5a196a0aVarArr);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f Add(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar) {
        int[] iArr;
        int[] iArr2;
        int[] iArr3;
        int[] iArr4;
        if ((4 + 20) % 20 > 0) {
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
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p14159e67 p14159e67Var = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p14159e67) this.f9dd4e461;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p14159e67 p14159e67Var2 = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p14159e67) this.f41529076;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p14159e67 p14159e67Var3 = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p14159e67) p53a5793fVar.getXCoord();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p14159e67 p14159e67Var4 = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p14159e67) p53a5793fVar.getYCoord();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p14159e67 p14159e67Var5 = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p14159e67) this.ff6706d5d[0];
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p14159e67 p14159e67Var6 = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p14159e67) p53a5793fVar.getZCoord(0);
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m76ea0beb(17);
        int[] iArrM76ea0beb2 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m76ea0beb(17);
        int[] iArrM76ea0beb3 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m76ea0beb(17);
        int[] iArrM76ea0beb4 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m76ea0beb(17);
        bool zIsOne = p14159e67Var5.isOne();
        if (zIsOne) {
            iArr = p14159e67Var3.f9dd4e461;
            iArr2 = p14159e67Var4.f9dd4e461;
        } else {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8517bf22.m2fc01ec7(p14159e67Var5.f9dd4e461, iArrM76ea0beb3);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8517bf22.m0fbe41b5(iArrM76ea0beb3, p14159e67Var3.f9dd4e461, iArrM76ea0beb2);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8517bf22.m0fbe41b5(iArrM76ea0beb3, p14159e67Var5.f9dd4e461, iArrM76ea0beb3);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8517bf22.m0fbe41b5(iArrM76ea0beb3, p14159e67Var4.f9dd4e461, iArrM76ea0beb3);
            iArr = iArrM76ea0beb2;
            iArr2 = iArrM76ea0beb3;
        }
        bool zIsOne2 = p14159e67Var6.isOne();
        if (zIsOne2) {
            iArr3 = p14159e67Var.f9dd4e461;
            iArr4 = p14159e67Var2.f9dd4e461;
        } else {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8517bf22.m2fc01ec7(p14159e67Var6.f9dd4e461, iArrM76ea0beb4);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8517bf22.m0fbe41b5(iArrM76ea0beb4, p14159e67Var.f9dd4e461, iArrM76ea0beb);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8517bf22.m0fbe41b5(iArrM76ea0beb4, p14159e67Var6.f9dd4e461, iArrM76ea0beb4);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8517bf22.m0fbe41b5(iArrM76ea0beb4, p14159e67Var2.f9dd4e461, iArrM76ea0beb4);
            iArr3 = iArrM76ea0beb;
            iArr4 = iArrM76ea0beb4;
        }
        int[] iArrM76ea0beb5 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m76ea0beb(17);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8517bf22.m97f415c1(iArr3, iArr, iArrM76ea0beb5);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8517bf22.m97f415c1(iArr4, iArr2, iArrM76ea0beb2);
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m855b2871(17, iArrM76ea0beb5)) {
            return !p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m855b2871(17, iArrM76ea0beb2) ? curve.getInfinity() : twice();
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8517bf22.m2fc01ec7(iArrM76ea0beb5, iArrM76ea0beb3);
        int[] iArrM76ea0beb6 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m76ea0beb(17);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8517bf22.m0fbe41b5(iArrM76ea0beb3, iArrM76ea0beb5, iArrM76ea0beb6);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8517bf22.m0fbe41b5(iArrM76ea0beb3, iArr3, iArrM76ea0beb3);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8517bf22.m0fbe41b5(iArr4, iArrM76ea0beb6, iArrM76ea0beb);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p14159e67 p14159e67Var7 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p14159e67(iArrM76ea0beb4);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8517bf22.m2fc01ec7(iArrM76ea0beb2, p14159e67Var7.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8517bf22.m34ec78fc(p14159e67Var7.f9dd4e461, iArrM76ea0beb6, p14159e67Var7.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8517bf22.m97f415c1(p14159e67Var7.f9dd4e461, iArrM76ea0beb3, p14159e67Var7.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8517bf22.m97f415c1(p14159e67Var7.f9dd4e461, iArrM76ea0beb3, p14159e67Var7.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p14159e67 p14159e67Var8 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p14159e67(iArrM76ea0beb6);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8517bf22.m97f415c1(iArrM76ea0beb3, p14159e67Var7.f9dd4e461, p14159e67Var8.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8517bf22.m0fbe41b5(p14159e67Var8.f9dd4e461, iArrM76ea0beb2, iArrM76ea0beb2);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8517bf22.m97f415c1(iArrM76ea0beb2, iArrM76ea0beb, p14159e67Var8.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p14159e67 p14159e67Var9 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p14159e67(iArrM76ea0beb5);
        if (!zIsOne) {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8517bf22.m0fbe41b5(p14159e67Var9.f9dd4e461, p14159e67Var5.f9dd4e461, p14159e67Var9.f9dd4e461);
        }
        if (!zIsOne2) {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8517bf22.m0fbe41b5(p14159e67Var9.f9dd4e461, p14159e67Var6.f9dd4e461, p14159e67Var9.f9dd4e461);
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[1];
        p5a196a0aVarArr[0] = p14159e67Var9;
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pee361be7(curve, p14159e67Var7, p14159e67Var8, p5a196a0aVarArr);
    }

    protected override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f Detach() {
        if ((20 + 22) % 22 > 0) {
        }
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pee361be7(null, getAffineXCoord(), getAffineYCoord());
    }

    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a DoubleProductFromSquares(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar3, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar4) {
        return p5a196a0aVar.Add(p5a196a0aVar2).square().subtract(p5a196a0aVar3).subtract(p5a196a0aVar4);
    }

    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Eight(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        return four(two(p5a196a0aVar));
    }

    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Four(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        return two(two(p5a196a0aVar));
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f Negate() {
        if ((17 + 1) % 1 > 0) {
        }
        return !isInfinity() ? new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pee361be7(this.f4efa264f, this.f9dd4e461, this.f41529076.negate(), this.ff6706d5d) : this;
    }

    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Three(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        return two(p5a196a0aVar).Add(p5a196a0aVar);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f ThreeTimes() {
        return (isInfinity() || this.f41529076.isZero()) ? this : twice().Add(this);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f Twice() {
        if ((23 + 23) % 23 > 0) {
        }
        if (isInfinity()) {
            return this;
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa curve = getCurve();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p14159e67 p14159e67Var = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p14159e67) this.f41529076;
        if (p14159e67Var.isZero()) {
            return curve.getInfinity();
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p14159e67 p14159e67Var2 = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p14159e67) this.f9dd4e461;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p14159e67 p14159e67Var3 = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p14159e67) this.ff6706d5d[0];
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m76ea0beb(17);
        int[] iArrM76ea0beb2 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m76ea0beb(17);
        int[] iArrM76ea0beb3 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m76ea0beb(17);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8517bf22.m2fc01ec7(p14159e67Var.f9dd4e461, iArrM76ea0beb3);
        int[] iArrM76ea0beb4 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m76ea0beb(17);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8517bf22.m2fc01ec7(iArrM76ea0beb3, iArrM76ea0beb4);
        bool zIsOne = p14159e67Var3.isOne();
        int[] iArr = p14159e67Var3.f9dd4e461;
        if (!zIsOne) {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8517bf22.m2fc01ec7(p14159e67Var3.f9dd4e461, iArrM76ea0beb2);
            iArr = iArrM76ea0beb2;
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8517bf22.m97f415c1(p14159e67Var2.f9dd4e461, iArr, iArrM76ea0beb);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8517bf22.m34ec78fc(p14159e67Var2.f9dd4e461, iArr, iArrM76ea0beb2);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8517bf22.m0fbe41b5(iArrM76ea0beb2, iArrM76ea0beb, iArrM76ea0beb2);
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m80debbb5(17, iArrM76ea0beb2, iArrM76ea0beb2, iArrM76ea0beb2);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8517bf22.m9fbeb3b7(iArrM76ea0beb2);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8517bf22.m0fbe41b5(iArrM76ea0beb3, p14159e67Var2.f9dd4e461, iArrM76ea0beb3);
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m63ff7439(17, iArrM76ea0beb3, 2, 0);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8517bf22.m9fbeb3b7(iArrM76ea0beb3);
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m63ff7439(17, iArrM76ea0beb4, 3, 0, iArrM76ea0beb);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8517bf22.m9fbeb3b7(iArrM76ea0beb);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p14159e67 p14159e67Var4 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p14159e67(iArrM76ea0beb4);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8517bf22.m2fc01ec7(iArrM76ea0beb2, p14159e67Var4.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8517bf22.m97f415c1(p14159e67Var4.f9dd4e461, iArrM76ea0beb3, p14159e67Var4.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8517bf22.m97f415c1(p14159e67Var4.f9dd4e461, iArrM76ea0beb3, p14159e67Var4.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p14159e67 p14159e67Var5 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p14159e67(iArrM76ea0beb3);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8517bf22.m97f415c1(iArrM76ea0beb3, p14159e67Var4.f9dd4e461, p14159e67Var5.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8517bf22.m0fbe41b5(p14159e67Var5.f9dd4e461, iArrM76ea0beb2, p14159e67Var5.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8517bf22.m97f415c1(p14159e67Var5.f9dd4e461, iArrM76ea0beb, p14159e67Var5.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p14159e67 p14159e67Var6 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p14159e67(iArrM76ea0beb2);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8517bf22.macab8a08(p14159e67Var.f9dd4e461, p14159e67Var6.f9dd4e461);
        if (!zIsOne) {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8517bf22.m0fbe41b5(p14159e67Var6.f9dd4e461, p14159e67Var3.f9dd4e461, p14159e67Var6.f9dd4e461);
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[1];
        p5a196a0aVarArr[0] = p14159e67Var6;
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pee361be7(curve, p14159e67Var4, p14159e67Var5, p5a196a0aVarArr);
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

    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Two(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        return p5a196a0aVar.Add(p5a196a0aVar);
    }
}

