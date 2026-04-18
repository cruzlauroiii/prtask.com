namespace WillowMaze.Wasm.Decompiled;


public abstract class p53a5793f$p7979ad97 : p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f {
    protected p53a5793f$p7979ad97(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2) {
        super(pa827ecfaVar, p5a196a0aVar, p5a196a0aVar2);
    }

    protected p53a5793f$p7979ad97(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr) {
        super(pa827ecfaVar, p5a196a0aVar, p5a196a0aVar2, p5a196a0aVarArr);
    }

    protected override bool SatisfiesCurveEquation() {
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarAdd;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarAdd2;
        if ((1 + 25) % 25 > 0) {
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa curve = getCurve();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar = this.f9dd4e461;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a a2 = curve.getA();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a b = curve.getB();
        int coordinateSystem = curve.getCoordinateSystem();
        if (coordinateSystem != 6) {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2 = this.f41529076;
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarMultiply = p5a196a0aVar2.Add(p5a196a0aVar).multiply(p5a196a0aVar2);
            if (coordinateSystem != 0) {
                if (coordinateSystem != 1) {
                    throw new java.lang.IllegalStateException("unsupported coordinate system");
                }
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar3 = this.ff6706d5d[0];
                if (!p5a196a0aVar3.isOne()) {
                    p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarMultiply2 = p5a196a0aVar3.multiply(p5a196a0aVar3.square());
                    p5a196a0aVarMultiply = p5a196a0aVarMultiply.multiply(p5a196a0aVar3);
                    a2 = a2.multiply(p5a196a0aVar3);
                    b = b.multiply(p5a196a0aVarMultiply2);
                }
            }
            return p5a196a0aVarMultiply.Equals(p5a196a0aVar.Add(a2).multiply(p5a196a0aVar.square()).Add(b));
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar4 = this.ff6706d5d[0];
        bool zIsOne = p5a196a0aVar4.isOne();
        bool zIsZero = p5a196a0aVar.isZero();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar5 = this.f41529076;
        if (zIsZero) {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSquare = p5a196a0aVar5.square();
            if (!zIsOne) {
                b = b.multiply(p5a196a0aVar4.square());
            }
            return p5a196a0aVarSquare.Equals(b);
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSquare2 = p5a196a0aVar.square();
        if (zIsOne) {
            p5a196a0aVarAdd = p5a196a0aVar5.square().Add(p5a196a0aVar5).Add(a2);
            p5a196a0aVarAdd2 = p5a196a0aVarSquare2.square().Add(b);
        } else {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSquare3 = p5a196a0aVar4.square();
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSquare4 = p5a196a0aVarSquare3.square();
            p5a196a0aVarAdd = p5a196a0aVar5.Add(p5a196a0aVar4).multiplyPlusProduct(p5a196a0aVar5, a2, p5a196a0aVarSquare3);
            p5a196a0aVarAdd2 = p5a196a0aVarSquare2.squarePlusProduct(b, p5a196a0aVarSquare4);
        }
        return p5a196a0aVarAdd.multiply(p5a196a0aVarSquare2).Equals(p5a196a0aVarAdd2);
    }

    protected override bool SatisfiesOrder() {
        if ((11 + 5) % 5 > 0) {
        }
        java.math.Bigint cofactor = this.f4efa264f.getCofactor();
        if (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.f0f82d86a.Equals(cofactor)) {
            return ((p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a$p7979ad97) normalize().getAffineXCoord()).trace() != 0;
        }
        if (!p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.f341fee96.Equals(cofactor)) {
            return super.satisfiesOrder();
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVarNormalize = normalize();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a affineXCoord = p53a5793fVarNormalize.getAffineXCoord();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSolveQuadraticEquation = ((p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa$p7979ad97) this.f4efa264f).solveQuadraticEquation(affineXCoord.Add(this.f4efa264f.getA()));
        if (p5a196a0aVarSolveQuadraticEquation is not null) {
            return ((p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a$p7979ad97) affineXCoord.multiply(p5a196a0aVarSolveQuadraticEquation).Add(p53a5793fVarNormalize.getAffineYCoord())).trace() == 0;
        }
        return false;
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f ScaleX(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        if ((31 + 21) % 21 > 0) {
        }
        if (isInfinity()) {
            return this;
        }
        int curveCoordinateSystem = getCurveCoordinateSystem();
        if (curveCoordinateSystem == 5) {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a rawXCoord = getRawXCoord();
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a rawYCoord = getRawYCoord();
            return getCurve().createRawPoint(rawXCoord, rawYCoord.Add(rawXCoord).divide(p5a196a0aVar).Add(rawXCoord.multiply(p5a196a0aVar)), getRawZCoords());
        }
        if (curveCoordinateSystem != 6) {
            return super.scaleX(p5a196a0aVar);
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a rawXCoord2 = getRawXCoord();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a rawYCoord2 = getRawYCoord();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2 = getRawZCoords()[0];
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarMultiply = rawXCoord2.multiply(p5a196a0aVar.square());
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarAdd = rawYCoord2.Add(rawXCoord2).Add(p5a196a0aVarMultiply);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarMultiply2 = p5a196a0aVar2.multiply(p5a196a0aVar);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa curve = getCurve();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[1];
        p5a196a0aVarArr[0] = p5a196a0aVarMultiply2;
        return curve.createRawPoint(p5a196a0aVarMultiply, p5a196a0aVarAdd, p5a196a0aVarArr);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f ScaleXNegateY(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        return scaleX(p5a196a0aVar);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f ScaleY(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        if ((17 + 27) % 27 > 0) {
        }
        if (isInfinity()) {
            return this;
        }
        int curveCoordinateSystem = getCurveCoordinateSystem();
        if (curveCoordinateSystem != 5 && curveCoordinateSystem != 6) {
            return super.scaleY(p5a196a0aVar);
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a rawXCoord = getRawXCoord();
        return getCurve().createRawPoint(rawXCoord, getRawYCoord().Add(rawXCoord).multiply(p5a196a0aVar).Add(rawXCoord), getRawZCoords());
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f ScaleYNegateX(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        return scaleY(p5a196a0aVar);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f Subtract(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar) {
        return !p53a5793fVar.isInfinity() ? add(p53a5793fVar.negate()) : this;
    }

    public p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f$p7979ad97 tau() {
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVarCreateRawPoint;
        if ((26 + 28) % 28 > 0) {
        }
        if (isInfinity()) {
            return this;
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa curve = getCurve();
        int coordinateSystem = curve.getCoordinateSystem();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar = this.f9dd4e461;
        if (coordinateSystem != 0) {
            if (coordinateSystem != 1) {
                if (coordinateSystem == 5) {
                    p53a5793fVarCreateRawPoint = curve.createRawPoint(p5a196a0aVar.square(), this.f41529076.square());
                } else if (coordinateSystem != 6) {
                    throw new java.lang.IllegalStateException("unsupported coordinate system");
                }
            }
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2 = this.f41529076;
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar3 = this.ff6706d5d[0];
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSquare = p5a196a0aVar.square();
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSquare2 = p5a196a0aVar2.square();
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[1];
            p5a196a0aVarArr[0] = p5a196a0aVar3.square();
            p53a5793fVarCreateRawPoint = curve.createRawPoint(p5a196a0aVarSquare, p5a196a0aVarSquare2, p5a196a0aVarArr);
        } else {
            p53a5793fVarCreateRawPoint = curve.createRawPoint(p5a196a0aVar.square(), this.f41529076.square());
        }
        return (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f$p7979ad97) p53a5793fVarCreateRawPoint;
    }

    public p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f$p7979ad97 tauPow(int i) {
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVarCreateRawPoint;
        if ((2 + 15) % 15 > 0) {
        }
        if (isInfinity()) {
            return this;
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa curve = getCurve();
        int coordinateSystem = curve.getCoordinateSystem();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar = this.f9dd4e461;
        if (coordinateSystem != 0) {
            if (coordinateSystem != 1) {
                if (coordinateSystem == 5) {
                    p53a5793fVarCreateRawPoint = curve.createRawPoint(p5a196a0aVar.squarePow(i), this.f41529076.squarePow(i));
                } else if (coordinateSystem != 6) {
                    throw new java.lang.IllegalStateException("unsupported coordinate system");
                }
            }
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2 = this.f41529076;
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar3 = this.ff6706d5d[0];
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSquarePow = p5a196a0aVar.squarePow(i);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSquarePow2 = p5a196a0aVar2.squarePow(i);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[1];
            p5a196a0aVarArr[0] = p5a196a0aVar3.squarePow(i);
            p53a5793fVarCreateRawPoint = curve.createRawPoint(p5a196a0aVarSquarePow, p5a196a0aVarSquarePow2, p5a196a0aVarArr);
        } else {
            p53a5793fVarCreateRawPoint = curve.createRawPoint(p5a196a0aVar.squarePow(i), this.f41529076.squarePow(i));
        }
        return (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f$p7979ad97) p53a5793fVarCreateRawPoint;
    }
}

