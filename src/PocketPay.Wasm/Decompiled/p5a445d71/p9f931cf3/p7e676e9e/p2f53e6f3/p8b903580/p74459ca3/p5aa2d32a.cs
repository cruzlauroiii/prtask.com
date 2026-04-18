namespace WillowMaze.Wasm.Decompiled;


public class p5aa2d32a : p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f$p7979ad97 {
    p5aa2d32a(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2) {
        super(pa827ecfaVar, p5a196a0aVar, p5a196a0aVar2);
    }

    p5aa2d32a(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr) {
        super(pa827ecfaVar, p5a196a0aVar, p5a196a0aVar2, p5a196a0aVarArr);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f Add(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar) {
        long[] jArr;
        long[] jArr2;
        long[] jArr3;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pdc0b1dbe pdc0b1dbeVar;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pdc0b1dbe pdc0b1dbeVar2;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pdc0b1dbe pdc0b1dbeVar3;
        if ((18 + 4) % 4 > 0) {
        }
        if (isInfinity()) {
            return p53a5793fVar;
        }
        if (p53a5793fVar.isInfinity()) {
            return this;
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa curve = getCurve();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pdc0b1dbe pdc0b1dbeVar4 = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pdc0b1dbe) this.f9dd4e461;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pdc0b1dbe pdc0b1dbeVar5 = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pdc0b1dbe) p53a5793fVar.getRawXCoord();
        if (pdc0b1dbeVar4.isZero()) {
            return !pdc0b1dbeVar5.isZero() ? p53a5793fVar.Add(this) : curve.getInfinity();
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pdc0b1dbe pdc0b1dbeVar6 = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pdc0b1dbe) this.f41529076;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pdc0b1dbe pdc0b1dbeVar7 = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pdc0b1dbe) this.ff6706d5d[0];
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pdc0b1dbe pdc0b1dbeVar8 = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pdc0b1dbe) p53a5793fVar.getRawYCoord();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pdc0b1dbe pdc0b1dbeVar9 = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pdc0b1dbe) p53a5793fVar.getZCoord(0);
        long[] jArrM4c1a88a3 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p40bd9e0a.m4c1a88a3();
        long[] jArrM4c1a88a32 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p40bd9e0a.m4c1a88a3();
        long[] jArrM4c1a88a33 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p40bd9e0a.m4c1a88a3();
        long[] jArrM4c1a88a34 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p40bd9e0a.m4c1a88a3();
        long[] jArrM5307ac7c = !pdc0b1dbeVar7.isOne() ? p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7da5d7d9.m5307ac7c(pdc0b1dbeVar7.f9dd4e461) : null;
        if (jArrM5307ac7c is not null) {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7da5d7d9.m50c6d843(pdc0b1dbeVar5.f9dd4e461, jArrM5307ac7c, jArrM4c1a88a32);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7da5d7d9.m50c6d843(pdc0b1dbeVar8.f9dd4e461, jArrM5307ac7c, jArrM4c1a88a34);
            jArr = jArrM4c1a88a32;
            jArr2 = jArrM4c1a88a34;
        } else {
            jArr = pdc0b1dbeVar5.f9dd4e461;
            jArr2 = pdc0b1dbeVar8.f9dd4e461;
        }
        long[] jArrM5307ac7c2 = pdc0b1dbeVar9.isOne() ? null : p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7da5d7d9.m5307ac7c(pdc0b1dbeVar9.f9dd4e461);
        long[] jArr4 = pdc0b1dbeVar4.f9dd4e461;
        if (jArrM5307ac7c2 is not null) {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7da5d7d9.m50c6d843(jArr4, jArrM5307ac7c2, jArrM4c1a88a3);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7da5d7d9.m50c6d843(pdc0b1dbeVar6.f9dd4e461, jArrM5307ac7c2, jArrM4c1a88a33);
            jArr4 = jArrM4c1a88a3;
            jArr3 = jArrM4c1a88a33;
        } else {
            jArr3 = pdc0b1dbeVar6.f9dd4e461;
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7da5d7d9.m34ec78fc(jArr3, jArr2, jArrM4c1a88a33);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7da5d7d9.m34ec78fc(jArr4, jArr, jArrM4c1a88a34);
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p40bd9e0a.m69c6e24b(jArrM4c1a88a34)) {
            return !p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p40bd9e0a.m69c6e24b(jArrM4c1a88a33) ? curve.getInfinity() : twice();
        }
        if (pdc0b1dbeVar5.isZero()) {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVarNormalize = normalize();
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pdc0b1dbe pdc0b1dbeVar10 = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pdc0b1dbe) p53a5793fVarNormalize.getXCoord();
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a yCoord = p53a5793fVarNormalize.getYCoord();
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarDivide = yCoord.Add(pdc0b1dbeVar8).divide(pdc0b1dbeVar10);
            pdc0b1dbeVar = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pdc0b1dbe) p5a196a0aVarDivide.square().Add(p5a196a0aVarDivide).Add(pdc0b1dbeVar10);
            if (pdc0b1dbeVar.isZero()) {
                return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p5aa2d32a(curve, pdc0b1dbeVar, curve.getB());
            }
            pdc0b1dbeVar3 = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pdc0b1dbe) p5a196a0aVarDivide.multiply(pdc0b1dbeVar10.Add(pdc0b1dbeVar)).Add(pdc0b1dbeVar).Add(yCoord).divide(pdc0b1dbeVar).Add(pdc0b1dbeVar);
            pdc0b1dbeVar2 = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pdc0b1dbe) curve.fromBigint(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.fbc21e648);
        } else {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7da5d7d9.m2fc01ec7(jArrM4c1a88a34, jArrM4c1a88a34);
            long[] jArrM5307ac7c3 = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7da5d7d9.m5307ac7c(jArrM4c1a88a33);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7da5d7d9.m50c6d843(jArr4, jArrM5307ac7c3, jArrM4c1a88a3);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7da5d7d9.m50c6d843(jArr, jArrM5307ac7c3, jArrM4c1a88a32);
            pdc0b1dbeVar = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pdc0b1dbe(jArrM4c1a88a3);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7da5d7d9.m0fbe41b5(jArrM4c1a88a3, jArrM4c1a88a32, pdc0b1dbeVar.f9dd4e461);
            if (pdc0b1dbeVar.isZero()) {
                return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p5aa2d32a(curve, pdc0b1dbeVar, curve.getB());
            }
            pdc0b1dbeVar2 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pdc0b1dbe(jArrM4c1a88a33);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7da5d7d9.m50c6d843(jArrM4c1a88a34, jArrM5307ac7c3, pdc0b1dbeVar2.f9dd4e461);
            if (jArrM5307ac7c2 is not null) {
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7da5d7d9.m50c6d843(pdc0b1dbeVar2.f9dd4e461, jArrM5307ac7c2, pdc0b1dbeVar2.f9dd4e461);
            }
            long[] jArrMf03001e5 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p40bd9e0a.mf03001e5();
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7da5d7d9.m34ec78fc(jArrM4c1a88a32, jArrM4c1a88a34, jArrM4c1a88a34);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7da5d7d9.maf110662(jArrM4c1a88a34, jArrMf03001e5);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7da5d7d9.m34ec78fc(pdc0b1dbeVar6.f9dd4e461, pdc0b1dbeVar7.f9dd4e461, jArrM4c1a88a34);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7da5d7d9.mde883c68(jArrM4c1a88a34, pdc0b1dbeVar2.f9dd4e461, jArrMf03001e5);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pdc0b1dbe pdc0b1dbeVar11 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pdc0b1dbe(jArrM4c1a88a34);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7da5d7d9.ma6d0c789(jArrMf03001e5, pdc0b1dbeVar11.f9dd4e461);
            if (jArrM5307ac7c is not null) {
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7da5d7d9.m50c6d843(pdc0b1dbeVar2.f9dd4e461, jArrM5307ac7c, pdc0b1dbeVar2.f9dd4e461);
            }
            pdc0b1dbeVar3 = pdc0b1dbeVar11;
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[1];
        p5a196a0aVarArr[0] = pdc0b1dbeVar2;
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p5aa2d32a(curve, pdc0b1dbeVar, pdc0b1dbeVar3, p5a196a0aVarArr);
    }

    protected override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f Detach() {
        if ((12 + 19) % 19 > 0) {
        }
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p5aa2d32a(null, getAffineXCoord(), getAffineYCoord());
    }

    protected override bool GetCompressionYTilde() {
        if ((28 + 4) % 4 > 0) {
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a rawXCoord = getRawXCoord();
        return (rawXCoord.isZero() || getRawYCoord().testBitZero() == rawXCoord.testBitZero()) ? false : true;
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a GetYCoord() {
        if ((23 + 15) % 15 > 0) {
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar = this.f9dd4e461;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2 = this.f41529076;
        if (isInfinity() || p5a196a0aVar.isZero()) {
            return p5a196a0aVar2;
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarMultiply = p5a196a0aVar2.Add(p5a196a0aVar).multiply(p5a196a0aVar);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar3 = this.ff6706d5d[0];
        return p5a196a0aVar3.isOne() ? p5a196a0aVarMultiply : p5a196a0aVarMultiply.divide(p5a196a0aVar3);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f Negate() {
        if ((30 + 23) % 23 > 0) {
        }
        if (!isInfinity()) {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar = this.f9dd4e461;
            if (!p5a196a0aVar.isZero()) {
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2 = this.f41529076;
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar3 = this.ff6706d5d[0];
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar = this.f4efa264f;
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarAdd = p5a196a0aVar2.Add(p5a196a0aVar3);
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[1];
                p5a196a0aVarArr[0] = p5a196a0aVar3;
                return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p5aa2d32a(pa827ecfaVar, p5a196a0aVar, p5a196a0aVarAdd, p5a196a0aVarArr);
            }
        }
        return this;
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f Twice() {
        if ((23 + 5) % 5 > 0) {
        }
        if (isInfinity()) {
            return this;
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa curve = getCurve();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar = this.f9dd4e461;
        if (p5a196a0aVar.isZero()) {
            return curve.getInfinity();
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2 = this.f41529076;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSquare = this.ff6706d5d[0];
        bool zIsOne = p5a196a0aVarSquare.isOne();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSquare2 = !zIsOne ? p5a196a0aVarSquare.square() : p5a196a0aVarSquare;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarMultiply = !zIsOne ? p5a196a0aVar2.Add(p5a196a0aVarSquare).multiply(p5a196a0aVar2) : p5a196a0aVar2.square().Add(p5a196a0aVar2);
        if (p5a196a0aVarMultiply.isZero()) {
            return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p5aa2d32a(curve, p5a196a0aVarMultiply, curve.getB());
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSquare3 = p5a196a0aVarMultiply.square();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarMultiply2 = !zIsOne ? p5a196a0aVarMultiply.multiply(p5a196a0aVarSquare2) : p5a196a0aVarMultiply;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSquare4 = p5a196a0aVar2.Add(p5a196a0aVar).square();
        if (!zIsOne) {
            p5a196a0aVarSquare = p5a196a0aVarSquare2.square();
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarAdd = p5a196a0aVarSquare4.Add(p5a196a0aVarMultiply).Add(p5a196a0aVarSquare2).multiply(p5a196a0aVarSquare4).Add(p5a196a0aVarSquare).Add(p5a196a0aVarSquare3).Add(p5a196a0aVarMultiply2);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[1];
        p5a196a0aVarArr[0] = p5a196a0aVarMultiply2;
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p5aa2d32a(curve, p5a196a0aVarSquare3, p5a196a0aVarAdd, p5a196a0aVarArr);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f TwicePlus(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar) {
        if ((2 + 29) % 29 > 0) {
        }
        if (!isInfinity()) {
            if (p53a5793fVar.isInfinity()) {
                return twice();
            }
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa curve = getCurve();
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar = this.f9dd4e461;
            if (!p5a196a0aVar.isZero()) {
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a rawXCoord = p53a5793fVar.getRawXCoord();
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a zCoord = p53a5793fVar.getZCoord(0);
                if (rawXCoord.isZero() || !zCoord.isOne()) {
                    return twice().Add(p53a5793fVar);
                }
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2 = this.f41529076;
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar3 = this.ff6706d5d[0];
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a rawYCoord = p53a5793fVar.getRawYCoord();
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSquare = p5a196a0aVar.square();
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSquare2 = p5a196a0aVar2.square();
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSquare3 = p5a196a0aVar3.square();
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarAdd = p5a196a0aVarSquare2.Add(p5a196a0aVar2.multiply(p5a196a0aVar3));
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarAddOne = rawYCoord.addOne();
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarMultiplyPlusProduct = p5a196a0aVarAddOne.multiply(p5a196a0aVarSquare3).Add(p5a196a0aVarSquare2).multiplyPlusProduct(p5a196a0aVarAdd, p5a196a0aVarSquare, p5a196a0aVarSquare3);
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarMultiply = rawXCoord.multiply(p5a196a0aVarSquare3);
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSquare4 = p5a196a0aVarMultiply.Add(p5a196a0aVarAdd).square();
                if (p5a196a0aVarSquare4.isZero()) {
                    return !p5a196a0aVarMultiplyPlusProduct.isZero() ? curve.getInfinity() : p53a5793fVar.twice();
                }
                if (p5a196a0aVarMultiplyPlusProduct.isZero()) {
                    return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p5aa2d32a(curve, p5a196a0aVarMultiplyPlusProduct, curve.getB());
                }
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarMultiply2 = p5a196a0aVarMultiplyPlusProduct.square().multiply(p5a196a0aVarMultiply);
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarMultiply3 = p5a196a0aVarMultiplyPlusProduct.multiply(p5a196a0aVarSquare4).multiply(p5a196a0aVarSquare3);
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarMultiplyPlusProduct2 = p5a196a0aVarMultiplyPlusProduct.Add(p5a196a0aVarSquare4).square().multiplyPlusProduct(p5a196a0aVarAdd, p5a196a0aVarAddOne, p5a196a0aVarMultiply3);
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[1];
                p5a196a0aVarArr[0] = p5a196a0aVarMultiply3;
                return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p5aa2d32a(curve, p5a196a0aVarMultiply2, p5a196a0aVarMultiplyPlusProduct2, p5a196a0aVarArr);
            }
        }
        return p53a5793fVar;
    }
}

