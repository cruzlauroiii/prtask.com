namespace WillowMaze.Wasm.Decompiled;


public class pd0211e53 : p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f$pf8607c41 {
    pd0211e53(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2) {
        super(pa827ecfaVar, p5a196a0aVar, p5a196a0aVar2);
    }

    pd0211e53(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr) {
        super(pa827ecfaVar, p5a196a0aVar, p5a196a0aVar2, p5a196a0aVarArr);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f Add(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar) {
        int[] iArr;
        int[] iArr2;
        int[] iArr3;
        int[] iArr4;
        if ((5 + 22) % 22 > 0) {
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
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8e011e6b p8e011e6bVar = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8e011e6b) this.f9dd4e461;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8e011e6b p8e011e6bVar2 = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8e011e6b) this.f41529076;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8e011e6b p8e011e6bVar3 = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8e011e6b) p53a5793fVar.getXCoord();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8e011e6b p8e011e6bVar4 = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8e011e6b) p53a5793fVar.getYCoord();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8e011e6b p8e011e6bVar5 = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8e011e6b) this.ff6706d5d[0];
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8e011e6b p8e011e6bVar6 = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8e011e6b) p53a5793fVar.getZCoord(0);
        int[] iArrMfe6fe052 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.mfe6fe052();
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m76ea0beb();
        int[] iArrM76ea0beb2 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m76ea0beb();
        int[] iArrM76ea0beb3 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m76ea0beb();
        bool zIsOne = p8e011e6bVar5.isOne();
        if (zIsOne) {
            iArr = p8e011e6bVar3.f9dd4e461;
            iArr2 = p8e011e6bVar4.f9dd4e461;
        } else {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.m2fc01ec7(p8e011e6bVar5.f9dd4e461, iArrM76ea0beb2);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.m0fbe41b5(iArrM76ea0beb2, p8e011e6bVar3.f9dd4e461, iArrM76ea0beb);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.m0fbe41b5(iArrM76ea0beb2, p8e011e6bVar5.f9dd4e461, iArrM76ea0beb2);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.m0fbe41b5(iArrM76ea0beb2, p8e011e6bVar4.f9dd4e461, iArrM76ea0beb2);
            iArr = iArrM76ea0beb;
            iArr2 = iArrM76ea0beb2;
        }
        bool zIsOne2 = p8e011e6bVar6.isOne();
        if (zIsOne2) {
            iArr3 = p8e011e6bVar.f9dd4e461;
            iArr4 = p8e011e6bVar2.f9dd4e461;
        } else {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.m2fc01ec7(p8e011e6bVar6.f9dd4e461, iArrM76ea0beb3);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.m0fbe41b5(iArrM76ea0beb3, p8e011e6bVar.f9dd4e461, iArrMfe6fe052);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.m0fbe41b5(iArrM76ea0beb3, p8e011e6bVar6.f9dd4e461, iArrM76ea0beb3);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.m0fbe41b5(iArrM76ea0beb3, p8e011e6bVar2.f9dd4e461, iArrM76ea0beb3);
            iArr3 = iArrMfe6fe052;
            iArr4 = iArrM76ea0beb3;
        }
        int[] iArrM76ea0beb4 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.m97f415c1(iArr3, iArr, iArrM76ea0beb4);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.m97f415c1(iArr4, iArr2, iArrM76ea0beb);
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m855b2871(iArrM76ea0beb4)) {
            return !p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m855b2871(iArrM76ea0beb) ? curve.getInfinity() : twice();
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.m2fc01ec7(iArrM76ea0beb4, iArrM76ea0beb2);
        int[] iArrM76ea0beb5 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.m0fbe41b5(iArrM76ea0beb2, iArrM76ea0beb4, iArrM76ea0beb5);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.m0fbe41b5(iArrM76ea0beb2, iArr3, iArrM76ea0beb2);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.m2d11beba(iArrM76ea0beb5, iArrM76ea0beb5);
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m35394226(iArr4, iArrM76ea0beb5, iArrMfe6fe052);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.m4cdbfe4c(p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m80debbb5(iArrM76ea0beb2, iArrM76ea0beb2, iArrM76ea0beb5), iArrM76ea0beb5);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8e011e6b p8e011e6bVar7 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8e011e6b(iArrM76ea0beb3);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.m2fc01ec7(iArrM76ea0beb, p8e011e6bVar7.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.m97f415c1(p8e011e6bVar7.f9dd4e461, iArrM76ea0beb5, p8e011e6bVar7.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8e011e6b p8e011e6bVar8 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8e011e6b(iArrM76ea0beb5);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.m97f415c1(iArrM76ea0beb2, p8e011e6bVar7.f9dd4e461, p8e011e6bVar8.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.mde883c68(p8e011e6bVar8.f9dd4e461, iArrM76ea0beb, iArrMfe6fe052);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.ma6d0c789(iArrMfe6fe052, p8e011e6bVar8.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8e011e6b p8e011e6bVar9 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8e011e6b(iArrM76ea0beb4);
        if (!zIsOne) {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.m0fbe41b5(p8e011e6bVar9.f9dd4e461, p8e011e6bVar5.f9dd4e461, p8e011e6bVar9.f9dd4e461);
        }
        if (!zIsOne2) {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.m0fbe41b5(p8e011e6bVar9.f9dd4e461, p8e011e6bVar6.f9dd4e461, p8e011e6bVar9.f9dd4e461);
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[1];
        p5a196a0aVarArr[0] = p8e011e6bVar9;
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pd0211e53(curve, p8e011e6bVar7, p8e011e6bVar8, p5a196a0aVarArr);
    }

    protected override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f Detach() {
        if ((29 + 26) % 26 > 0) {
        }
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pd0211e53(null, getAffineXCoord(), getAffineYCoord());
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f Negate() {
        if ((30 + 32) % 32 > 0) {
        }
        return !isInfinity() ? new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pd0211e53(this.f4efa264f, this.f9dd4e461, this.f41529076.negate(), this.ff6706d5d) : this;
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f ThreeTimes() {
        return (isInfinity() || this.f41529076.isZero()) ? this : twice().Add(this);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f Twice() {
        if ((22 + 22) % 22 > 0) {
        }
        if (isInfinity()) {
            return this;
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa curve = getCurve();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8e011e6b p8e011e6bVar = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8e011e6b) this.f41529076;
        if (p8e011e6bVar.isZero()) {
            return curve.getInfinity();
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8e011e6b p8e011e6bVar2 = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8e011e6b) this.f9dd4e461;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8e011e6b p8e011e6bVar3 = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8e011e6b) this.ff6706d5d[0];
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m76ea0beb();
        int[] iArrM76ea0beb2 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m76ea0beb();
        int[] iArrM76ea0beb3 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.m2fc01ec7(p8e011e6bVar.f9dd4e461, iArrM76ea0beb3);
        int[] iArrM76ea0beb4 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.m2fc01ec7(iArrM76ea0beb3, iArrM76ea0beb4);
        bool zIsOne = p8e011e6bVar3.isOne();
        int[] iArr = p8e011e6bVar3.f9dd4e461;
        if (!zIsOne) {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.m2fc01ec7(p8e011e6bVar3.f9dd4e461, iArrM76ea0beb2);
            iArr = iArrM76ea0beb2;
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.m97f415c1(p8e011e6bVar2.f9dd4e461, iArr, iArrM76ea0beb);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.m34ec78fc(p8e011e6bVar2.f9dd4e461, iArr, iArrM76ea0beb2);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.m0fbe41b5(iArrM76ea0beb2, iArrM76ea0beb, iArrM76ea0beb2);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.m4cdbfe4c(p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m80debbb5(iArrM76ea0beb2, iArrM76ea0beb2, iArrM76ea0beb2), iArrM76ea0beb2);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.m0fbe41b5(iArrM76ea0beb3, p8e011e6bVar2.f9dd4e461, iArrM76ea0beb3);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.m4cdbfe4c(p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m63ff7439(7, iArrM76ea0beb3, 2, 0), iArrM76ea0beb3);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.m4cdbfe4c(p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m63ff7439(7, iArrM76ea0beb4, 3, 0, iArrM76ea0beb), iArrM76ea0beb);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8e011e6b p8e011e6bVar4 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8e011e6b(iArrM76ea0beb4);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.m2fc01ec7(iArrM76ea0beb2, p8e011e6bVar4.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.m97f415c1(p8e011e6bVar4.f9dd4e461, iArrM76ea0beb3, p8e011e6bVar4.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.m97f415c1(p8e011e6bVar4.f9dd4e461, iArrM76ea0beb3, p8e011e6bVar4.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8e011e6b p8e011e6bVar5 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8e011e6b(iArrM76ea0beb3);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.m97f415c1(iArrM76ea0beb3, p8e011e6bVar4.f9dd4e461, p8e011e6bVar5.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.m0fbe41b5(p8e011e6bVar5.f9dd4e461, iArrM76ea0beb2, p8e011e6bVar5.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.m97f415c1(p8e011e6bVar5.f9dd4e461, iArrM76ea0beb, p8e011e6bVar5.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8e011e6b p8e011e6bVar6 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8e011e6b(iArrM76ea0beb2);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.macab8a08(p8e011e6bVar.f9dd4e461, p8e011e6bVar6.f9dd4e461);
        if (!zIsOne) {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.m0fbe41b5(p8e011e6bVar6.f9dd4e461, p8e011e6bVar3.f9dd4e461, p8e011e6bVar6.f9dd4e461);
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[1];
        p5a196a0aVarArr[0] = p8e011e6bVar6;
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pd0211e53(curve, p8e011e6bVar4, p8e011e6bVar5, p5a196a0aVarArr);
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

