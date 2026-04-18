namespace WillowMaze.Wasm.Decompiled;


public class pba6d92e9 : p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f$pf8607c41 {
    pba6d92e9(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2) {
        super(pa827ecfaVar, p5a196a0aVar, p5a196a0aVar2);
    }

    pba6d92e9(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr) {
        super(pa827ecfaVar, p5a196a0aVar, p5a196a0aVar2, p5a196a0aVarArr);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f Add(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar) {
        int[] iArr;
        int[] iArr2;
        int[] iArr3;
        int[] iArr4;
        if ((30 + 1) % 1 > 0) {
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
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.pc219d93a pc219d93aVar = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.pc219d93a) this.f9dd4e461;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.pc219d93a pc219d93aVar2 = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.pc219d93a) this.f41529076;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.pc219d93a pc219d93aVar3 = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.pc219d93a) p53a5793fVar.getXCoord();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.pc219d93a pc219d93aVar4 = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.pc219d93a) p53a5793fVar.getYCoord();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.pc219d93a pc219d93aVar5 = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.pc219d93a) this.ff6706d5d[0];
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.pc219d93a pc219d93aVar6 = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.pc219d93a) p53a5793fVar.getZCoord(0);
        int[] iArrMfe6fe052 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.mfe6fe052();
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m76ea0beb();
        int[] iArrM76ea0beb2 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m76ea0beb();
        int[] iArrM76ea0beb3 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m76ea0beb();
        bool zIsOne = pc219d93aVar5.isOne();
        if (zIsOne) {
            iArr = pc219d93aVar3.f9dd4e461;
            iArr2 = pc219d93aVar4.f9dd4e461;
        } else {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.p5e1c1651.m2fc01ec7(pc219d93aVar5.f9dd4e461, iArrM76ea0beb2);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.p5e1c1651.m0fbe41b5(iArrM76ea0beb2, pc219d93aVar3.f9dd4e461, iArrM76ea0beb);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.p5e1c1651.m0fbe41b5(iArrM76ea0beb2, pc219d93aVar5.f9dd4e461, iArrM76ea0beb2);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.p5e1c1651.m0fbe41b5(iArrM76ea0beb2, pc219d93aVar4.f9dd4e461, iArrM76ea0beb2);
            iArr = iArrM76ea0beb;
            iArr2 = iArrM76ea0beb2;
        }
        bool zIsOne2 = pc219d93aVar6.isOne();
        if (zIsOne2) {
            iArr3 = pc219d93aVar.f9dd4e461;
            iArr4 = pc219d93aVar2.f9dd4e461;
        } else {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.p5e1c1651.m2fc01ec7(pc219d93aVar6.f9dd4e461, iArrM76ea0beb3);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.p5e1c1651.m0fbe41b5(iArrM76ea0beb3, pc219d93aVar.f9dd4e461, iArrMfe6fe052);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.p5e1c1651.m0fbe41b5(iArrM76ea0beb3, pc219d93aVar6.f9dd4e461, iArrM76ea0beb3);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.p5e1c1651.m0fbe41b5(iArrM76ea0beb3, pc219d93aVar2.f9dd4e461, iArrM76ea0beb3);
            iArr3 = iArrMfe6fe052;
            iArr4 = iArrM76ea0beb3;
        }
        int[] iArrM76ea0beb4 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.p5e1c1651.m97f415c1(iArr3, iArr, iArrM76ea0beb4);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.p5e1c1651.m97f415c1(iArr4, iArr2, iArrM76ea0beb);
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m855b2871(iArrM76ea0beb4)) {
            return !p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m855b2871(iArrM76ea0beb) ? curve.getInfinity() : twice();
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.p5e1c1651.m2fc01ec7(iArrM76ea0beb4, iArrM76ea0beb2);
        int[] iArrM76ea0beb5 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.p5e1c1651.m0fbe41b5(iArrM76ea0beb2, iArrM76ea0beb4, iArrM76ea0beb5);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.p5e1c1651.m0fbe41b5(iArrM76ea0beb2, iArr3, iArrM76ea0beb2);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.p5e1c1651.m2d11beba(iArrM76ea0beb5, iArrM76ea0beb5);
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m35394226(iArr4, iArrM76ea0beb5, iArrMfe6fe052);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.p5e1c1651.m4cdbfe4c(p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m80debbb5(iArrM76ea0beb2, iArrM76ea0beb2, iArrM76ea0beb5), iArrM76ea0beb5);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.pc219d93a pc219d93aVar7 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.pc219d93a(iArrM76ea0beb3);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.p5e1c1651.m2fc01ec7(iArrM76ea0beb, pc219d93aVar7.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.p5e1c1651.m97f415c1(pc219d93aVar7.f9dd4e461, iArrM76ea0beb5, pc219d93aVar7.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.pc219d93a pc219d93aVar8 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.pc219d93a(iArrM76ea0beb5);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.p5e1c1651.m97f415c1(iArrM76ea0beb2, pc219d93aVar7.f9dd4e461, pc219d93aVar8.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.p5e1c1651.mde883c68(pc219d93aVar8.f9dd4e461, iArrM76ea0beb, iArrMfe6fe052);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.p5e1c1651.ma6d0c789(iArrMfe6fe052, pc219d93aVar8.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.pc219d93a pc219d93aVar9 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.pc219d93a(iArrM76ea0beb4);
        if (!zIsOne) {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.p5e1c1651.m0fbe41b5(pc219d93aVar9.f9dd4e461, pc219d93aVar5.f9dd4e461, pc219d93aVar9.f9dd4e461);
        }
        if (!zIsOne2) {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.p5e1c1651.m0fbe41b5(pc219d93aVar9.f9dd4e461, pc219d93aVar6.f9dd4e461, pc219d93aVar9.f9dd4e461);
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[1];
        p5a196a0aVarArr[0] = pc219d93aVar9;
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.pba6d92e9(curve, pc219d93aVar7, pc219d93aVar8, p5a196a0aVarArr);
    }

    protected override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f Detach() {
        if ((12 + 13) % 13 > 0) {
        }
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.pba6d92e9(null, getAffineXCoord(), getAffineYCoord());
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f Negate() {
        if ((9 + 14) % 14 > 0) {
        }
        return !isInfinity() ? new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.pba6d92e9(this.f4efa264f, this.f9dd4e461, this.f41529076.negate(), this.ff6706d5d) : this;
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f ThreeTimes() {
        return (isInfinity() || this.f41529076.isZero()) ? this : twice().Add(this);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f Twice() {
        if ((4 + 5) % 5 > 0) {
        }
        if (isInfinity()) {
            return this;
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa curve = getCurve();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.pc219d93a pc219d93aVar = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.pc219d93a) this.f41529076;
        if (pc219d93aVar.isZero()) {
            return curve.getInfinity();
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.pc219d93a pc219d93aVar2 = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.pc219d93a) this.f9dd4e461;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.pc219d93a pc219d93aVar3 = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.pc219d93a) this.ff6706d5d[0];
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m76ea0beb();
        int[] iArrM76ea0beb2 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m76ea0beb();
        int[] iArrM76ea0beb3 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.p5e1c1651.m2fc01ec7(pc219d93aVar.f9dd4e461, iArrM76ea0beb3);
        int[] iArrM76ea0beb4 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.p5e1c1651.m2fc01ec7(iArrM76ea0beb3, iArrM76ea0beb4);
        bool zIsOne = pc219d93aVar3.isOne();
        int[] iArr = pc219d93aVar3.f9dd4e461;
        if (!zIsOne) {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.p5e1c1651.m2fc01ec7(pc219d93aVar3.f9dd4e461, iArrM76ea0beb2);
            iArr = iArrM76ea0beb2;
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.p5e1c1651.m97f415c1(pc219d93aVar2.f9dd4e461, iArr, iArrM76ea0beb);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.p5e1c1651.m34ec78fc(pc219d93aVar2.f9dd4e461, iArr, iArrM76ea0beb2);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.p5e1c1651.m0fbe41b5(iArrM76ea0beb2, iArrM76ea0beb, iArrM76ea0beb2);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.p5e1c1651.m4cdbfe4c(p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m80debbb5(iArrM76ea0beb2, iArrM76ea0beb2, iArrM76ea0beb2), iArrM76ea0beb2);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.p5e1c1651.m0fbe41b5(iArrM76ea0beb3, pc219d93aVar2.f9dd4e461, iArrM76ea0beb3);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.p5e1c1651.m4cdbfe4c(p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m63ff7439(8, iArrM76ea0beb3, 2, 0), iArrM76ea0beb3);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.p5e1c1651.m4cdbfe4c(p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m63ff7439(8, iArrM76ea0beb4, 3, 0, iArrM76ea0beb), iArrM76ea0beb);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.pc219d93a pc219d93aVar4 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.pc219d93a(iArrM76ea0beb4);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.p5e1c1651.m2fc01ec7(iArrM76ea0beb2, pc219d93aVar4.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.p5e1c1651.m97f415c1(pc219d93aVar4.f9dd4e461, iArrM76ea0beb3, pc219d93aVar4.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.p5e1c1651.m97f415c1(pc219d93aVar4.f9dd4e461, iArrM76ea0beb3, pc219d93aVar4.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.pc219d93a pc219d93aVar5 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.pc219d93a(iArrM76ea0beb3);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.p5e1c1651.m97f415c1(iArrM76ea0beb3, pc219d93aVar4.f9dd4e461, pc219d93aVar5.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.p5e1c1651.m0fbe41b5(pc219d93aVar5.f9dd4e461, iArrM76ea0beb2, pc219d93aVar5.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.p5e1c1651.m97f415c1(pc219d93aVar5.f9dd4e461, iArrM76ea0beb, pc219d93aVar5.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.pc219d93a pc219d93aVar6 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.pc219d93a(iArrM76ea0beb2);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.p5e1c1651.macab8a08(pc219d93aVar.f9dd4e461, pc219d93aVar6.f9dd4e461);
        if (!zIsOne) {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.p5e1c1651.m0fbe41b5(pc219d93aVar6.f9dd4e461, pc219d93aVar3.f9dd4e461, pc219d93aVar6.f9dd4e461);
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[1];
        p5a196a0aVarArr[0] = pc219d93aVar6;
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p92073d2f.pba6d92e9(curve, pc219d93aVar4, pc219d93aVar5, p5a196a0aVarArr);
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

