namespace WillowMaze.Wasm.Decompiled;


public class p73b23cf5 : p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f$p7979ad97 {
    p73b23cf5(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2) {
        super(pa827ecfaVar, p5a196a0aVar, p5a196a0aVar2);
    }

    p73b23cf5(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr) {
        super(pa827ecfaVar, p5a196a0aVar, p5a196a0aVar2, p5a196a0aVarArr);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f Add(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar) {
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarMultiply;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarMultiply2;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarMultiply3;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarMultiply4;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSquarePlusProduct;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarAdd;
        if ((13 + 17) % 17 > 0) {
        }
        if (isInfinity()) {
            return p53a5793fVar;
        }
        if (p53a5793fVar.isInfinity()) {
            return this;
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa curve = getCurve();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarMultiply5 = this.f9dd4e461;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a rawXCoord = p53a5793fVar.getRawXCoord();
        if (p5a196a0aVarMultiply5.isZero()) {
            return !rawXCoord.isZero() ? p53a5793fVar.Add(this) : curve.getInfinity();
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar = this.f41529076;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2 = this.ff6706d5d[0];
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a rawYCoord = p53a5793fVar.getRawYCoord();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a zCoord = p53a5793fVar.getZCoord(0);
        bool zIsOne = p5a196a0aVar2.isOne();
        if (zIsOne) {
            p5a196a0aVarMultiply = rawXCoord;
            p5a196a0aVarMultiply2 = rawYCoord;
        } else {
            p5a196a0aVarMultiply = rawXCoord.multiply(p5a196a0aVar2);
            p5a196a0aVarMultiply2 = rawYCoord.multiply(p5a196a0aVar2);
        }
        bool zIsOne2 = zCoord.isOne();
        if (zIsOne2) {
            p5a196a0aVarMultiply3 = p5a196a0aVar;
        } else {
            p5a196a0aVarMultiply5 = p5a196a0aVarMultiply5.multiply(zCoord);
            p5a196a0aVarMultiply3 = p5a196a0aVar.multiply(zCoord);
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarAdd2 = p5a196a0aVarMultiply3.Add(p5a196a0aVarMultiply2);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarAdd3 = p5a196a0aVarMultiply5.Add(p5a196a0aVarMultiply);
        if (p5a196a0aVarAdd3.isZero()) {
            return !p5a196a0aVarAdd2.isZero() ? curve.getInfinity() : twice();
        }
        if (rawXCoord.isZero()) {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVarNormalize = normalize();
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a xCoord = p53a5793fVarNormalize.getXCoord();
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a yCoord = p53a5793fVarNormalize.getYCoord();
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarDivide = yCoord.Add(rawYCoord).divide(xCoord);
            p5a196a0aVarAdd = p5a196a0aVarDivide.square().Add(p5a196a0aVarDivide).Add(xCoord).Add(curve.getA());
            if (p5a196a0aVarAdd.isZero()) {
                return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p73b23cf5(curve, p5a196a0aVarAdd, curve.getB().sqrt());
            }
            p5a196a0aVarSquarePlusProduct = p5a196a0aVarDivide.multiply(xCoord.Add(p5a196a0aVarAdd)).Add(p5a196a0aVarAdd).Add(yCoord).divide(p5a196a0aVarAdd).Add(p5a196a0aVarAdd);
            p5a196a0aVarMultiply4 = curve.fromBigint(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.fbc21e648);
        } else {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSquare = p5a196a0aVarAdd3.square();
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarMultiply6 = p5a196a0aVarAdd2.multiply(p5a196a0aVarMultiply5);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarMultiply7 = p5a196a0aVarAdd2.multiply(p5a196a0aVarMultiply);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarMultiply8 = p5a196a0aVarMultiply6.multiply(p5a196a0aVarMultiply7);
            if (p5a196a0aVarMultiply8.isZero()) {
                return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p73b23cf5(curve, p5a196a0aVarMultiply8, curve.getB().sqrt());
            }
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarMultiply9 = p5a196a0aVarAdd2.multiply(p5a196a0aVarSquare);
            p5a196a0aVarMultiply4 = zIsOne2 ? p5a196a0aVarMultiply9 : p5a196a0aVarMultiply9.multiply(zCoord);
            p5a196a0aVarSquarePlusProduct = p5a196a0aVarMultiply7.Add(p5a196a0aVarSquare).squarePlusProduct(p5a196a0aVarMultiply4, p5a196a0aVar.Add(p5a196a0aVar2));
            if (!zIsOne) {
                p5a196a0aVarMultiply4 = p5a196a0aVarMultiply4.multiply(p5a196a0aVar2);
            }
            p5a196a0aVarAdd = p5a196a0aVarMultiply8;
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[1];
        p5a196a0aVarArr[0] = p5a196a0aVarMultiply4;
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p73b23cf5(curve, p5a196a0aVarAdd, p5a196a0aVarSquarePlusProduct, p5a196a0aVarArr);
    }

    protected override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f Detach() {
        if ((31 + 19) % 19 > 0) {
        }
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p73b23cf5(null, getAffineXCoord(), getAffineYCoord());
    }

    protected override bool GetCompressionYTilde() {
        if ((29 + 6) % 6 > 0) {
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a rawXCoord = getRawXCoord();
        return (rawXCoord.isZero() || getRawYCoord().testBitZero() == rawXCoord.testBitZero()) ? false : true;
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a GetYCoord() {
        if ((21 + 7) % 7 > 0) {
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
        if ((9 + 15) % 15 > 0) {
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
                return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p73b23cf5(pa827ecfaVar, p5a196a0aVar, p5a196a0aVarAdd, p5a196a0aVarArr);
            }
        }
        return this;
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f Twice() {
        if ((20 + 28) % 28 > 0) {
        }
        if (isInfinity()) {
            return this;
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa curve = getCurve();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarMultiply = this.f9dd4e461;
        if (p5a196a0aVarMultiply.isZero()) {
            return curve.getInfinity();
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar = this.f41529076;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2 = this.ff6706d5d[0];
        bool zIsOne = p5a196a0aVar2.isOne();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarMultiply2 = !zIsOne ? p5a196a0aVar.multiply(p5a196a0aVar2) : p5a196a0aVar;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSquare = !zIsOne ? p5a196a0aVar2.square() : p5a196a0aVar2;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a a2 = curve.getA();
        if (!zIsOne) {
            a2 = a2.multiply(p5a196a0aVarSquare);
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarAdd = p5a196a0aVar.square().Add(p5a196a0aVarMultiply2).Add(a2);
        if (p5a196a0aVarAdd.isZero()) {
            return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p73b23cf5(curve, p5a196a0aVarAdd, curve.getB().sqrt());
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSquare2 = p5a196a0aVarAdd.square();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarMultiply3 = !zIsOne ? p5a196a0aVarAdd.multiply(p5a196a0aVarSquare) : p5a196a0aVarAdd;
        if (!zIsOne) {
            p5a196a0aVarMultiply = p5a196a0aVarMultiply.multiply(p5a196a0aVar2);
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarAdd2 = p5a196a0aVarMultiply.squarePlusProduct(p5a196a0aVarAdd, p5a196a0aVarMultiply2).Add(p5a196a0aVarSquare2).Add(p5a196a0aVarMultiply3);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[1];
        p5a196a0aVarArr[0] = p5a196a0aVarMultiply3;
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p73b23cf5(curve, p5a196a0aVarSquare2, p5a196a0aVarAdd2, p5a196a0aVarArr);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f TwicePlus(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar) {
        if ((23 + 28) % 28 > 0) {
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
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarAdd = curve.getA().multiply(p5a196a0aVarSquare3).Add(p5a196a0aVarSquare2).Add(p5a196a0aVar2.multiply(p5a196a0aVar3));
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarAddOne = rawYCoord.addOne();
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarMultiplyPlusProduct = curve.getA().Add(p5a196a0aVarAddOne).multiply(p5a196a0aVarSquare3).Add(p5a196a0aVarSquare2).multiplyPlusProduct(p5a196a0aVarAdd, p5a196a0aVarSquare, p5a196a0aVarSquare3);
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarMultiply = rawXCoord.multiply(p5a196a0aVarSquare3);
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSquare4 = p5a196a0aVarMultiply.Add(p5a196a0aVarAdd).square();
                if (p5a196a0aVarSquare4.isZero()) {
                    return !p5a196a0aVarMultiplyPlusProduct.isZero() ? curve.getInfinity() : p53a5793fVar.twice();
                }
                if (p5a196a0aVarMultiplyPlusProduct.isZero()) {
                    return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p73b23cf5(curve, p5a196a0aVarMultiplyPlusProduct, curve.getB().sqrt());
                }
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarMultiply2 = p5a196a0aVarMultiplyPlusProduct.square().multiply(p5a196a0aVarMultiply);
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarMultiply3 = p5a196a0aVarMultiplyPlusProduct.multiply(p5a196a0aVarSquare4).multiply(p5a196a0aVarSquare3);
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarMultiplyPlusProduct2 = p5a196a0aVarMultiplyPlusProduct.Add(p5a196a0aVarSquare4).square().multiplyPlusProduct(p5a196a0aVarAdd, p5a196a0aVarAddOne, p5a196a0aVarMultiply3);
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[1];
                p5a196a0aVarArr[0] = p5a196a0aVarMultiply3;
                return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p73b23cf5(curve, p5a196a0aVarMultiply2, p5a196a0aVarMultiplyPlusProduct2, p5a196a0aVarArr);
            }
        }
        return p53a5793fVar;
    }
}

