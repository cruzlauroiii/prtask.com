namespace WillowMaze.Wasm.Decompiled;


public class p9c04f762 : p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f$pf8607c41 {
    p9c04f762(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2) {
        super(pa827ecfaVar, p5a196a0aVar, p5a196a0aVar2);
    }

    p9c04f762(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr) {
        super(pa827ecfaVar, p5a196a0aVar, p5a196a0aVar2, p5a196a0aVarArr);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f Add(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar) {
        int[] iArr;
        int[] iArr2;
        int[] iArr3;
        int[] iArr4;
        if ((2 + 21) % 21 > 0) {
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
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pc26229f7 pc26229f7Var = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pc26229f7) this.f9dd4e461;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pc26229f7 pc26229f7Var2 = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pc26229f7) this.f41529076;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pc26229f7 pc26229f7Var3 = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pc26229f7) p53a5793fVar.getXCoord();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pc26229f7 pc26229f7Var4 = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pc26229f7) p53a5793fVar.getYCoord();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pc26229f7 pc26229f7Var5 = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pc26229f7) this.ff6706d5d[0];
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pc26229f7 pc26229f7Var6 = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pc26229f7) p53a5793fVar.getZCoord(0);
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m76ea0beb(24);
        int[] iArrM76ea0beb2 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m76ea0beb(24);
        int[] iArrM76ea0beb3 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m76ea0beb(12);
        int[] iArrM76ea0beb4 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m76ea0beb(12);
        bool zIsOne = pc26229f7Var5.isOne();
        if (zIsOne) {
            iArr = pc26229f7Var3.f9dd4e461;
            iArr2 = pc26229f7Var4.f9dd4e461;
        } else {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7cbc162a.m2fc01ec7(pc26229f7Var5.f9dd4e461, iArrM76ea0beb3);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7cbc162a.m0fbe41b5(iArrM76ea0beb3, pc26229f7Var3.f9dd4e461, iArrM76ea0beb2);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7cbc162a.m0fbe41b5(iArrM76ea0beb3, pc26229f7Var5.f9dd4e461, iArrM76ea0beb3);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7cbc162a.m0fbe41b5(iArrM76ea0beb3, pc26229f7Var4.f9dd4e461, iArrM76ea0beb3);
            iArr = iArrM76ea0beb2;
            iArr2 = iArrM76ea0beb3;
        }
        bool zIsOne2 = pc26229f7Var6.isOne();
        if (zIsOne2) {
            iArr3 = pc26229f7Var.f9dd4e461;
            iArr4 = pc26229f7Var2.f9dd4e461;
        } else {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7cbc162a.m2fc01ec7(pc26229f7Var6.f9dd4e461, iArrM76ea0beb4);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7cbc162a.m0fbe41b5(iArrM76ea0beb4, pc26229f7Var.f9dd4e461, iArrM76ea0beb);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7cbc162a.m0fbe41b5(iArrM76ea0beb4, pc26229f7Var6.f9dd4e461, iArrM76ea0beb4);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7cbc162a.m0fbe41b5(iArrM76ea0beb4, pc26229f7Var2.f9dd4e461, iArrM76ea0beb4);
            iArr3 = iArrM76ea0beb;
            iArr4 = iArrM76ea0beb4;
        }
        int[] iArrM76ea0beb5 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m76ea0beb(12);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7cbc162a.m97f415c1(iArr3, iArr, iArrM76ea0beb5);
        int[] iArrM76ea0beb6 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m76ea0beb(12);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7cbc162a.m97f415c1(iArr4, iArr2, iArrM76ea0beb6);
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m855b2871(12, iArrM76ea0beb5)) {
            return !p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m855b2871(12, iArrM76ea0beb6) ? curve.getInfinity() : twice();
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7cbc162a.m2fc01ec7(iArrM76ea0beb5, iArrM76ea0beb3);
        int[] iArrM76ea0beb7 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m76ea0beb(12);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7cbc162a.m0fbe41b5(iArrM76ea0beb3, iArrM76ea0beb5, iArrM76ea0beb7);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7cbc162a.m0fbe41b5(iArrM76ea0beb3, iArr3, iArrM76ea0beb3);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7cbc162a.m2d11beba(iArrM76ea0beb7, iArrM76ea0beb7);
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p7ec591e7.m35394226(iArr4, iArrM76ea0beb7, iArrM76ea0beb);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7cbc162a.m4cdbfe4c(p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m80debbb5(12, iArrM76ea0beb3, iArrM76ea0beb3, iArrM76ea0beb7), iArrM76ea0beb7);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pc26229f7 pc26229f7Var7 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pc26229f7(iArrM76ea0beb4);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7cbc162a.m2fc01ec7(iArrM76ea0beb6, pc26229f7Var7.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7cbc162a.m97f415c1(pc26229f7Var7.f9dd4e461, iArrM76ea0beb7, pc26229f7Var7.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pc26229f7 pc26229f7Var8 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pc26229f7(iArrM76ea0beb7);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7cbc162a.m97f415c1(iArrM76ea0beb3, pc26229f7Var7.f9dd4e461, pc26229f7Var8.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p7ec591e7.m35394226(pc26229f7Var8.f9dd4e461, iArrM76ea0beb6, iArrM76ea0beb2);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7cbc162a.m0408d798(iArrM76ea0beb, iArrM76ea0beb2, iArrM76ea0beb);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7cbc162a.ma6d0c789(iArrM76ea0beb, pc26229f7Var8.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pc26229f7 pc26229f7Var9 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pc26229f7(iArrM76ea0beb5);
        if (!zIsOne) {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7cbc162a.m0fbe41b5(pc26229f7Var9.f9dd4e461, pc26229f7Var5.f9dd4e461, pc26229f7Var9.f9dd4e461);
        }
        if (!zIsOne2) {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7cbc162a.m0fbe41b5(pc26229f7Var9.f9dd4e461, pc26229f7Var6.f9dd4e461, pc26229f7Var9.f9dd4e461);
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[1];
        p5a196a0aVarArr[0] = pc26229f7Var9;
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9c04f762(curve, pc26229f7Var7, pc26229f7Var8, p5a196a0aVarArr);
    }

    protected override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f Detach() {
        if ((21 + 32) % 32 > 0) {
        }
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9c04f762(null, getAffineXCoord(), getAffineYCoord());
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f Negate() {
        if ((30 + 2) % 2 > 0) {
        }
        return !isInfinity() ? new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9c04f762(this.f4efa264f, this.f9dd4e461, this.f41529076.negate(), this.ff6706d5d) : this;
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f ThreeTimes() {
        return (isInfinity() || this.f41529076.isZero()) ? this : twice().Add(this);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f Twice() {
        if ((28 + 16) % 16 > 0) {
        }
        if (isInfinity()) {
            return this;
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa curve = getCurve();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pc26229f7 pc26229f7Var = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pc26229f7) this.f41529076;
        if (pc26229f7Var.isZero()) {
            return curve.getInfinity();
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pc26229f7 pc26229f7Var2 = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pc26229f7) this.f9dd4e461;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pc26229f7 pc26229f7Var3 = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pc26229f7) this.ff6706d5d[0];
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m76ea0beb(12);
        int[] iArrM76ea0beb2 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m76ea0beb(12);
        int[] iArrM76ea0beb3 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m76ea0beb(12);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7cbc162a.m2fc01ec7(pc26229f7Var.f9dd4e461, iArrM76ea0beb3);
        int[] iArrM76ea0beb4 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m76ea0beb(12);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7cbc162a.m2fc01ec7(iArrM76ea0beb3, iArrM76ea0beb4);
        bool zIsOne = pc26229f7Var3.isOne();
        int[] iArr = pc26229f7Var3.f9dd4e461;
        if (!zIsOne) {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7cbc162a.m2fc01ec7(pc26229f7Var3.f9dd4e461, iArrM76ea0beb2);
            iArr = iArrM76ea0beb2;
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7cbc162a.m97f415c1(pc26229f7Var2.f9dd4e461, iArr, iArrM76ea0beb);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7cbc162a.m34ec78fc(pc26229f7Var2.f9dd4e461, iArr, iArrM76ea0beb2);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7cbc162a.m0fbe41b5(iArrM76ea0beb2, iArrM76ea0beb, iArrM76ea0beb2);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7cbc162a.m4cdbfe4c(p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m80debbb5(12, iArrM76ea0beb2, iArrM76ea0beb2, iArrM76ea0beb2), iArrM76ea0beb2);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7cbc162a.m0fbe41b5(iArrM76ea0beb3, pc26229f7Var2.f9dd4e461, iArrM76ea0beb3);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7cbc162a.m4cdbfe4c(p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m63ff7439(12, iArrM76ea0beb3, 2, 0), iArrM76ea0beb3);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7cbc162a.m4cdbfe4c(p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m63ff7439(12, iArrM76ea0beb4, 3, 0, iArrM76ea0beb), iArrM76ea0beb);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pc26229f7 pc26229f7Var4 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pc26229f7(iArrM76ea0beb4);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7cbc162a.m2fc01ec7(iArrM76ea0beb2, pc26229f7Var4.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7cbc162a.m97f415c1(pc26229f7Var4.f9dd4e461, iArrM76ea0beb3, pc26229f7Var4.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7cbc162a.m97f415c1(pc26229f7Var4.f9dd4e461, iArrM76ea0beb3, pc26229f7Var4.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pc26229f7 pc26229f7Var5 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pc26229f7(iArrM76ea0beb3);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7cbc162a.m97f415c1(iArrM76ea0beb3, pc26229f7Var4.f9dd4e461, pc26229f7Var5.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7cbc162a.m0fbe41b5(pc26229f7Var5.f9dd4e461, iArrM76ea0beb2, pc26229f7Var5.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7cbc162a.m97f415c1(pc26229f7Var5.f9dd4e461, iArrM76ea0beb, pc26229f7Var5.f9dd4e461);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pc26229f7 pc26229f7Var6 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pc26229f7(iArrM76ea0beb2);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7cbc162a.macab8a08(pc26229f7Var.f9dd4e461, pc26229f7Var6.f9dd4e461);
        if (!zIsOne) {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7cbc162a.m0fbe41b5(pc26229f7Var6.f9dd4e461, pc26229f7Var3.f9dd4e461, pc26229f7Var6.f9dd4e461);
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[1];
        p5a196a0aVarArr[0] = pc26229f7Var6;
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9c04f762(curve, pc26229f7Var4, pc26229f7Var5, p5a196a0aVarArr);
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

