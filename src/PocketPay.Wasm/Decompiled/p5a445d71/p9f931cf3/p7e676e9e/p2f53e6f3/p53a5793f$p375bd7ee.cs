namespace WillowMaze.Wasm.Decompiled;


public class p53a5793f$p375bd7ee : p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f$pf8607c41 {
    p53a5793f$p375bd7ee(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2) {
        super(pa827ecfaVar, p5a196a0aVar, p5a196a0aVar2);
    }

    p53a5793f$p375bd7ee(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr) {
        super(pa827ecfaVar, p5a196a0aVar, p5a196a0aVar2, p5a196a0aVarArr);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f Add(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar) {
        char c;
        int i;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarMultiplyMinusProduct;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarMultiply;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSubtract;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr;
        if ((31 + 15) % 15 > 0) {
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
        int coordinateSystem = curve.getCoordinateSystem();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarMultiply2 = this.f9dd4e461;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarMultiply3 = this.f41529076;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarMultiply4 = p53a5793fVar.f9dd4e461;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarMultiply5 = p53a5793fVar.f41529076;
        if (coordinateSystem == 0) {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSubtract2 = p5a196a0aVarMultiply4.subtract(p5a196a0aVarMultiply2);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSubtract3 = p5a196a0aVarMultiply5.subtract(p5a196a0aVarMultiply3);
            if (p5a196a0aVarSubtract2.isZero()) {
                return !p5a196a0aVarSubtract3.isZero() ? curve.getInfinity() : twice();
            }
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarDivide = p5a196a0aVarSubtract3.divide(p5a196a0aVarSubtract2);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSubtract4 = p5a196a0aVarDivide.square().subtract(p5a196a0aVarMultiply2).subtract(p5a196a0aVarMultiply4);
            return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f$p375bd7ee(curve, p5a196a0aVarSubtract4, p5a196a0aVarDivide.multiply(p5a196a0aVarMultiply2.subtract(p5a196a0aVarSubtract4)).subtract(p5a196a0aVarMultiply3));
        }
        if (coordinateSystem == 1) {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarMultiply6 = this.ff6706d5d[0];
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2 = p53a5793fVar.ff6706d5d[0];
            bool zIsOne = p5a196a0aVarMultiply6.isOne();
            bool zIsOne2 = p5a196a0aVar2.isOne();
            if (!zIsOne) {
                p5a196a0aVarMultiply5 = p5a196a0aVarMultiply5.multiply(p5a196a0aVarMultiply6);
            }
            if (!zIsOne2) {
                p5a196a0aVarMultiply3 = p5a196a0aVarMultiply3.multiply(p5a196a0aVar2);
            }
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSubtract5 = p5a196a0aVarMultiply5.subtract(p5a196a0aVarMultiply3);
            if (!zIsOne) {
                p5a196a0aVarMultiply4 = p5a196a0aVarMultiply4.multiply(p5a196a0aVarMultiply6);
            }
            if (!zIsOne2) {
                p5a196a0aVarMultiply2 = p5a196a0aVarMultiply2.multiply(p5a196a0aVar2);
            }
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSubtract6 = p5a196a0aVarMultiply4.subtract(p5a196a0aVarMultiply2);
            if (p5a196a0aVarSubtract6.isZero()) {
                return !p5a196a0aVarSubtract5.isZero() ? curve.getInfinity() : twice();
            }
            if (zIsOne) {
                p5a196a0aVarMultiply6 = p5a196a0aVar2;
            } else if (!zIsOne2) {
                p5a196a0aVarMultiply6 = p5a196a0aVarMultiply6.multiply(p5a196a0aVar2);
            }
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSquare = p5a196a0aVarSubtract6.square();
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarMultiply7 = p5a196a0aVarSquare.multiply(p5a196a0aVarSubtract6);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarMultiply8 = p5a196a0aVarSquare.multiply(p5a196a0aVarMultiply2);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSubtract7 = p5a196a0aVarSubtract5.square().multiply(p5a196a0aVarMultiply6).subtract(p5a196a0aVarMultiply7).subtract(two(p5a196a0aVarMultiply8));
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarMultiply9 = p5a196a0aVarSubtract6.multiply(p5a196a0aVarSubtract7);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarMultiplyMinusProduct2 = p5a196a0aVarMultiply8.subtract(p5a196a0aVarSubtract7).multiplyMinusProduct(p5a196a0aVarSubtract5, p5a196a0aVarMultiply3, p5a196a0aVarMultiply7);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr2 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[1];
            p5a196a0aVarArr2[0] = p5a196a0aVarMultiply7.multiply(p5a196a0aVarMultiply6);
            return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f$p375bd7ee(curve, p5a196a0aVarMultiply9, p5a196a0aVarMultiplyMinusProduct2, p5a196a0aVarArr2);
        }
        if (coordinateSystem != 2 && coordinateSystem != 4) {
            throw new java.lang.IllegalStateException("unsupported coordinate system");
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar3 = this.ff6706d5d[0];
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar4 = p53a5793fVar.ff6706d5d[0];
        bool zIsOne3 = p5a196a0aVar3.isOne();
        if (zIsOne3 || !p5a196a0aVar3.Equals(p5a196a0aVar4)) {
            if (!zIsOne3) {
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSquare2 = p5a196a0aVar3.square();
                p5a196a0aVarMultiply4 = p5a196a0aVarSquare2.multiply(p5a196a0aVarMultiply4);
                p5a196a0aVarMultiply5 = p5a196a0aVarSquare2.multiply(p5a196a0aVar3).multiply(p5a196a0aVarMultiply5);
            }
            bool zIsOne4 = p5a196a0aVar4.isOne();
            c = 0;
            if (!zIsOne4) {
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSquare3 = p5a196a0aVar4.square();
                p5a196a0aVarMultiply2 = p5a196a0aVarSquare3.multiply(p5a196a0aVarMultiply2);
                p5a196a0aVarMultiply3 = p5a196a0aVarSquare3.multiply(p5a196a0aVar4).multiply(p5a196a0aVarMultiply3);
            }
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSubtract8 = p5a196a0aVarMultiply2.subtract(p5a196a0aVarMultiply4);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSubtract9 = p5a196a0aVarMultiply3.subtract(p5a196a0aVarMultiply5);
            if (p5a196a0aVarSubtract8.isZero()) {
                return !p5a196a0aVarSubtract9.isZero() ? curve.getInfinity() : twice();
            }
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSquare4 = p5a196a0aVarSubtract8.square();
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarMultiply10 = p5a196a0aVarSquare4.multiply(p5a196a0aVarSubtract8);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarMultiply11 = p5a196a0aVarSquare4.multiply(p5a196a0aVarMultiply2);
            i = 1;
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSubtract10 = p5a196a0aVarSubtract9.square().Add(p5a196a0aVarMultiply10).subtract(two(p5a196a0aVarMultiply11));
            p5a196a0aVarMultiplyMinusProduct = p5a196a0aVarMultiply11.subtract(p5a196a0aVarSubtract10).multiplyMinusProduct(p5a196a0aVarSubtract9, p5a196a0aVarMultiply10, p5a196a0aVarMultiply3);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarMultiply12 = zIsOne3 ? p5a196a0aVarSubtract8 : p5a196a0aVarSubtract8.multiply(p5a196a0aVar3);
            p5a196a0aVarMultiply = zIsOne4 ? p5a196a0aVarMultiply12 : p5a196a0aVarMultiply12.multiply(p5a196a0aVar4);
            if (p5a196a0aVarMultiply != p5a196a0aVarSubtract8) {
                p5a196a0aVarSubtract = p5a196a0aVarSubtract10;
            } else {
                p5a196a0aVarSubtract = p5a196a0aVarSubtract10;
                p5a196a0aVar = p5a196a0aVarSquare4;
            }
            if (coordinateSystem != 4) {
                p5a196a0aVarArr = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[i];
                p5a196a0aVarArr[c] = p5a196a0aVarMultiply;
            } else {
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarCalculateJacobianModifiedW = calculateJacobianModifiedW(p5a196a0aVarMultiply, p5a196a0aVar);
                p5a196a0aVarArr = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[2];
                p5a196a0aVarArr[c] = p5a196a0aVarMultiply;
                p5a196a0aVarArr[i] = p5a196a0aVarCalculateJacobianModifiedW;
            }
            return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f$p375bd7ee(curve, p5a196a0aVarSubtract, p5a196a0aVarMultiplyMinusProduct, p5a196a0aVarArr);
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSubtract11 = p5a196a0aVarMultiply2.subtract(p5a196a0aVarMultiply4);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSubtract12 = p5a196a0aVarMultiply3.subtract(p5a196a0aVarMultiply5);
        if (p5a196a0aVarSubtract11.isZero()) {
            return !p5a196a0aVarSubtract12.isZero() ? curve.getInfinity() : twice();
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSquare5 = p5a196a0aVarSubtract11.square();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarMultiply13 = p5a196a0aVarMultiply2.multiply(p5a196a0aVarSquare5);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarMultiply14 = p5a196a0aVarMultiply4.multiply(p5a196a0aVarSquare5);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarMultiply15 = p5a196a0aVarMultiply13.subtract(p5a196a0aVarMultiply14).multiply(p5a196a0aVarMultiply3);
        p5a196a0aVarSubtract = p5a196a0aVarSubtract12.square().subtract(p5a196a0aVarMultiply13).subtract(p5a196a0aVarMultiply14);
        p5a196a0aVarMultiplyMinusProduct = p5a196a0aVarMultiply13.subtract(p5a196a0aVarSubtract).multiply(p5a196a0aVarSubtract12).subtract(p5a196a0aVarMultiply15);
        p5a196a0aVarMultiply = p5a196a0aVarSubtract11.multiply(p5a196a0aVar3);
        i = 1;
        c = 0;
        p5a196a0aVar = null;
        if (coordinateSystem != 4) {
            p5a196a0aVarArr = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[i];
            p5a196a0aVarArr[c] = p5a196a0aVarMultiply;
        } else {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarCalculateJacobianModifiedW2 = calculateJacobianModifiedW(p5a196a0aVarMultiply, p5a196a0aVar);
            p5a196a0aVarArr = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[2];
            p5a196a0aVarArr[c] = p5a196a0aVarMultiply;
            p5a196a0aVarArr[i] = p5a196a0aVarCalculateJacobianModifiedW2;
        }
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f$p375bd7ee(curve, p5a196a0aVarSubtract, p5a196a0aVarMultiplyMinusProduct, p5a196a0aVarArr);
    }

    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a CalculateJacobianModifiedW(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2) {
        if ((27 + 25) % 25 > 0) {
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a a2 = getCurve().getA();
        if (a2.isZero() || p5a196a0aVar.isOne()) {
            return a2;
        }
        if (p5a196a0aVar2 is null) {
            p5a196a0aVar2 = p5a196a0aVar.square();
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSquare = p5a196a0aVar2.square();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarNegate = a2.negate();
        return p5a196a0aVarNegate.bitLength() >= a2.bitLength() ? p5a196a0aVarSquare.multiply(a2) : p5a196a0aVarSquare.multiply(p5a196a0aVarNegate).negate();
    }

    protected override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f Detach() {
        if ((5 + 7) % 7 > 0) {
        }
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f$p375bd7ee(null, getAffineXCoord(), getAffineYCoord());
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

    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a GetJacobianModifiedW() {
        if ((12 + 29) % 29 > 0) {
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar = this.ff6706d5d[1];
        if (p5a196a0aVar is not null) {
            return p5a196a0aVar;
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr = this.ff6706d5d;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarCalculateJacobianModifiedW = calculateJacobianModifiedW(this.ff6706d5d[0], null);
        p5a196a0aVarArr[1] = p5a196a0aVarCalculateJacobianModifiedW;
        return p5a196a0aVarCalculateJacobianModifiedW;
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a GetZCoord(int i) {
        if ((6 + 1) % 1 > 0) {
        }
        return (i == 1 && 4 == getCurveCoordinateSystem()) ? getJacobianModifiedW() : super.getZCoord(i);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f Negate() {
        if ((24 + 17) % 17 > 0) {
        }
        if (isInfinity()) {
            return this;
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa curve = getCurve();
        return curve.getCoordinateSystem() == 0 ? new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f$p375bd7ee(curve, this.f9dd4e461, this.f41529076.negate()) : new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f$p375bd7ee(curve, this.f9dd4e461, this.f41529076.negate(), this.ff6706d5d);
    }

    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Three(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        return two(p5a196a0aVar).Add(p5a196a0aVar);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f ThreeTimes() {
        if ((7 + 4) % 4 > 0) {
        }
        if (!isInfinity()) {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar = this.f41529076;
            if (!p5a196a0aVar.isZero()) {
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa curve = getCurve();
                int coordinateSystem = curve.getCoordinateSystem();
                if (coordinateSystem != 0) {
                    return coordinateSystem == 4 ? twiceJacobianModified(false).Add(this) : twice().Add(this);
                }
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2 = this.f9dd4e461;
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarTwo = two(p5a196a0aVar);
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSquare = p5a196a0aVarTwo.square();
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarAdd = three(p5a196a0aVar2.square()).Add(getCurve().getA());
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSubtract = three(p5a196a0aVar2).multiply(p5a196a0aVarSquare).subtract(p5a196a0aVarAdd.square());
                if (p5a196a0aVarSubtract.isZero()) {
                    return getCurve().getInfinity();
                }
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarInvert = p5a196a0aVarSubtract.multiply(p5a196a0aVarTwo).invert();
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarMultiply = p5a196a0aVarSubtract.multiply(p5a196a0aVarInvert).multiply(p5a196a0aVarAdd);
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSubtract2 = p5a196a0aVarSquare.square().multiply(p5a196a0aVarInvert).subtract(p5a196a0aVarMultiply);
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarAdd2 = p5a196a0aVarSubtract2.subtract(p5a196a0aVarMultiply).multiply(p5a196a0aVarMultiply.Add(p5a196a0aVarSubtract2)).Add(p5a196a0aVar2);
                return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f$p375bd7ee(curve, p5a196a0aVarAdd2, p5a196a0aVar2.subtract(p5a196a0aVarAdd2).multiply(p5a196a0aVarSubtract2).subtract(p5a196a0aVar));
            }
        }
        return this;
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f TimesPow2(int i) {
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSquare;
        if ((1 + 26) % 26 > 0) {
        }
        if (i < 0) {
            throw new java.lang.IllegalArgumentException("'e' cannot be negative");
        }
        if (i == 0 || isInfinity()) {
            return this;
        }
        if (i == 1) {
            return twice();
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa curve = getCurve();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarMultiply = this.f41529076;
        if (p5a196a0aVarMultiply.isZero()) {
            return curve.getInfinity();
        }
        int coordinateSystem = curve.getCoordinateSystem();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a a2 = curve.getA();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarMultiply2 = this.f9dd4e461;
        bool z = false;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarFromBigint = this.ff6706d5d.length >= 1 ? this.ff6706d5d[0] : curve.fromBigint(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.fbc21e648);
        if (!p5a196a0aVarFromBigint.isOne() && coordinateSystem != 0) {
            if (coordinateSystem == 1) {
                p5a196a0aVarSquare = p5a196a0aVarFromBigint.square();
                p5a196a0aVarMultiply2 = p5a196a0aVarMultiply2.multiply(p5a196a0aVarFromBigint);
                p5a196a0aVarMultiply = p5a196a0aVarMultiply.multiply(p5a196a0aVarSquare);
            } else if (coordinateSystem == 2) {
                p5a196a0aVarSquare = null;
            } else {
                if (coordinateSystem != 4) {
                    throw new java.lang.IllegalStateException("unsupported coordinate system");
                }
                a2 = getJacobianModifiedW();
            }
            a2 = calculateJacobianModifiedW(p5a196a0aVarFromBigint, p5a196a0aVarSquare);
        }
        int i2 = 0;
        while (i2 < i) {
            if (p5a196a0aVarMultiply.isZero()) {
                return curve.getInfinity();
            }
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarThree = three(p5a196a0aVarMultiply2.square());
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarTwo = two(p5a196a0aVarMultiply);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarMultiply3 = p5a196a0aVarTwo.multiply(p5a196a0aVarMultiply);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarTwo2 = two(p5a196a0aVarMultiply2.multiply(p5a196a0aVarMultiply3));
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarTwo3 = two(p5a196a0aVarMultiply3.square());
            if (!a2.isZero()) {
                p5a196a0aVarThree = p5a196a0aVarThree.Add(a2);
                a2 = two(p5a196a0aVarTwo3.multiply(a2));
            }
            bool z2 = z;
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSubtract = p5a196a0aVarThree.square().subtract(two(p5a196a0aVarTwo2));
            p5a196a0aVarMultiply = p5a196a0aVarThree.multiply(p5a196a0aVarTwo2.subtract(p5a196a0aVarSubtract)).subtract(p5a196a0aVarTwo3);
            p5a196a0aVarFromBigint = !p5a196a0aVarFromBigint.isOne() ? p5a196a0aVarTwo.multiply(p5a196a0aVarFromBigint) : p5a196a0aVarTwo;
            i2++;
            p5a196a0aVarMultiply2 = p5a196a0aVarSubtract;
            z = z2;
        }
        bool z3 = z;
        if (coordinateSystem == 0) {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarInvert = p5a196a0aVarFromBigint.invert();
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSquare2 = p5a196a0aVarInvert.square();
            return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f$p375bd7ee(curve, p5a196a0aVarMultiply2.multiply(p5a196a0aVarSquare2), p5a196a0aVarMultiply.multiply(p5a196a0aVarSquare2.multiply(p5a196a0aVarInvert)));
        }
        if (coordinateSystem == 1) {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarMultiply4 = p5a196a0aVarMultiply2.multiply(p5a196a0aVarFromBigint);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[1];
            p5a196a0aVarArr[z3 ? 1 : 0] = p5a196a0aVarFromBigint.multiply(p5a196a0aVarFromBigint.square());
            return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f$p375bd7ee(curve, p5a196a0aVarMultiply4, p5a196a0aVarMultiply, p5a196a0aVarArr);
        }
        if (coordinateSystem == 2) {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr2 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[1];
            p5a196a0aVarArr2[z3 ? 1 : 0] = p5a196a0aVarFromBigint;
            return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f$p375bd7ee(curve, p5a196a0aVarMultiply2, p5a196a0aVarMultiply, p5a196a0aVarArr2);
        }
        if (coordinateSystem != 4) {
            throw new java.lang.IllegalStateException("unsupported coordinate system");
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr3 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[2];
        p5a196a0aVarArr3[z3 ? 1 : 0] = p5a196a0aVarFromBigint;
        p5a196a0aVarArr3[1] = a2;
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f$p375bd7ee(curve, p5a196a0aVarMultiply2, p5a196a0aVarMultiply, p5a196a0aVarArr3);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f Twice() {
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarThree;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarMultiply;
        if ((11 + 18) % 18 > 0) {
        }
        if (isInfinity()) {
            return this;
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa curve = getCurve();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar = this.f41529076;
        if (p5a196a0aVar.isZero()) {
            return curve.getInfinity();
        }
        int coordinateSystem = curve.getCoordinateSystem();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2 = this.f9dd4e461;
        if (coordinateSystem == 0) {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarDivide = three(p5a196a0aVar2.square()).Add(getCurve().getA()).divide(two(p5a196a0aVar));
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSubtract = p5a196a0aVarDivide.square().subtract(two(p5a196a0aVar2));
            return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f$p375bd7ee(curve, p5a196a0aVarSubtract, p5a196a0aVarDivide.multiply(p5a196a0aVar2.subtract(p5a196a0aVarSubtract)).subtract(p5a196a0aVar));
        }
        if (coordinateSystem == 1) {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar3 = this.ff6706d5d[0];
            bool zIsOne = p5a196a0aVar3.isOne();
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a a2 = curve.getA();
            if (!a2.isZero() && !zIsOne) {
                a2 = a2.multiply(p5a196a0aVar3.square());
            }
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarAdd = a2.Add(three(p5a196a0aVar2.square()));
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarMultiply2 = !zIsOne ? p5a196a0aVar.multiply(p5a196a0aVar3) : p5a196a0aVar;
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarMultiply3 = !zIsOne ? p5a196a0aVarMultiply2.multiply(p5a196a0aVar) : p5a196a0aVar.square();
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarFour = four(p5a196a0aVar2.multiply(p5a196a0aVarMultiply3));
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSubtract2 = p5a196a0aVarAdd.square().subtract(two(p5a196a0aVarFour));
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarTwo = two(p5a196a0aVarMultiply2);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarMultiply4 = p5a196a0aVarSubtract2.multiply(p5a196a0aVarTwo);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarTwo2 = two(p5a196a0aVarMultiply3);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSubtract3 = p5a196a0aVarFour.subtract(p5a196a0aVarSubtract2).multiply(p5a196a0aVarAdd).subtract(two(p5a196a0aVarTwo2.square()));
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarMultiply5 = two(!zIsOne ? p5a196a0aVarTwo.square() : two(p5a196a0aVarTwo2)).multiply(p5a196a0aVarMultiply2);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[1];
            p5a196a0aVarArr[0] = p5a196a0aVarMultiply5;
            return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f$p375bd7ee(curve, p5a196a0aVarMultiply4, p5a196a0aVarSubtract3, p5a196a0aVarArr);
        }
        if (coordinateSystem != 2) {
            if (coordinateSystem != 4) {
                throw new java.lang.IllegalStateException("unsupported coordinate system");
            }
            return twiceJacobianModified(true);
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar4 = this.ff6706d5d[0];
        bool zIsOne2 = p5a196a0aVar4.isOne();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSquare = p5a196a0aVar.square();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSquare2 = p5a196a0aVarSquare.square();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a a3 = curve.getA();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarNegate = a3.negate();
        if (p5a196a0aVarNegate.toBigint().Equals(java.math.Bigint.valueOf(3L))) {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSquare3 = !zIsOne2 ? p5a196a0aVar4.square() : p5a196a0aVar4;
            p5a196a0aVarThree = three(p5a196a0aVar2.Add(p5a196a0aVarSquare3).multiply(p5a196a0aVar2.subtract(p5a196a0aVarSquare3)));
            p5a196a0aVarMultiply = p5a196a0aVarSquare.multiply(p5a196a0aVar2);
        } else {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarThree2 = three(p5a196a0aVar2.square());
            if (zIsOne2) {
                p5a196a0aVarThree = p5a196a0aVarThree2.Add(a3);
            } else if (a3.isZero()) {
                p5a196a0aVarThree = p5a196a0aVarThree2;
            } else {
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSquare4 = p5a196a0aVar4.square().square();
                if (p5a196a0aVarNegate.bitLength() >= a3.bitLength()) {
                    a3 = p5a196a0aVarSquare4.multiply(a3);
                    p5a196a0aVarThree = p5a196a0aVarThree2.Add(a3);
                } else {
                    p5a196a0aVarThree = p5a196a0aVarThree2.subtract(p5a196a0aVarSquare4.multiply(p5a196a0aVarNegate));
                }
            }
            p5a196a0aVarMultiply = p5a196a0aVar2.multiply(p5a196a0aVarSquare);
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarFour2 = four(p5a196a0aVarMultiply);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSubtract4 = p5a196a0aVarThree.square().subtract(two(p5a196a0aVarFour2));
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSubtract5 = p5a196a0aVarFour2.subtract(p5a196a0aVarSubtract4).multiply(p5a196a0aVarThree).subtract(eight(p5a196a0aVarSquare2));
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarTwo3 = two(p5a196a0aVar);
        if (!zIsOne2) {
            p5a196a0aVarTwo3 = p5a196a0aVarTwo3.multiply(p5a196a0aVar4);
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr2 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[1];
        p5a196a0aVarArr2[0] = p5a196a0aVarTwo3;
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f$p375bd7ee(curve, p5a196a0aVarSubtract4, p5a196a0aVarSubtract5, p5a196a0aVarArr2);
    }

    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f$p375bd7ee twiceJacobianModified(bool z) {
        if ((27 + 10) % 10 > 0) {
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar = this.f9dd4e461;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2 = this.f41529076;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar3 = this.ff6706d5d[0];
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a jacobianModifiedW = getJacobianModifiedW();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarAdd = three(p5a196a0aVar.square()).Add(jacobianModifiedW);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarTwo = two(p5a196a0aVar2);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarMultiply = p5a196a0aVarTwo.multiply(p5a196a0aVar2);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarTwo2 = two(p5a196a0aVar.multiply(p5a196a0aVarMultiply));
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSubtract = p5a196a0aVarAdd.square().subtract(two(p5a196a0aVarTwo2));
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarTwo3 = two(p5a196a0aVarMultiply.square());
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSubtract2 = p5a196a0aVarAdd.multiply(p5a196a0aVarTwo2.subtract(p5a196a0aVarSubtract)).subtract(p5a196a0aVarTwo3);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarTwo4 = !z ? null : two(p5a196a0aVarTwo3.multiply(jacobianModifiedW));
        if (!p5a196a0aVar3.isOne()) {
            p5a196a0aVarTwo = p5a196a0aVarTwo.multiply(p5a196a0aVar3);
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa curve = getCurve();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[2];
        p5a196a0aVarArr[0] = p5a196a0aVarTwo;
        p5a196a0aVarArr[1] = p5a196a0aVarTwo4;
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f$p375bd7ee(curve, p5a196a0aVarSubtract, p5a196a0aVarSubtract2, p5a196a0aVarArr);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f TwicePlus(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar) {
        if ((28 + 8) % 8 > 0) {
        }
        if (this == p53a5793fVar) {
            return threeTimes();
        }
        if (!isInfinity()) {
            if (p53a5793fVar.isInfinity()) {
                return twice();
            }
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar = this.f41529076;
            if (!p5a196a0aVar.isZero()) {
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa curve = getCurve();
                int coordinateSystem = curve.getCoordinateSystem();
                if (coordinateSystem != 0) {
                    return coordinateSystem == 4 ? twiceJacobianModified(false).Add(p53a5793fVar) : twice().Add(p53a5793fVar);
                }
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2 = this.f9dd4e461;
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar3 = p53a5793fVar.f9dd4e461;
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar4 = p53a5793fVar.f41529076;
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSubtract = p5a196a0aVar3.subtract(p5a196a0aVar2);
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSubtract2 = p5a196a0aVar4.subtract(p5a196a0aVar);
                if (p5a196a0aVarSubtract.isZero()) {
                    return !p5a196a0aVarSubtract2.isZero() ? this : threeTimes();
                }
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSquare = p5a196a0aVarSubtract.square();
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSubtract3 = p5a196a0aVarSquare.multiply(two(p5a196a0aVar2).Add(p5a196a0aVar3)).subtract(p5a196a0aVarSubtract2.square());
                if (p5a196a0aVarSubtract3.isZero()) {
                    return curve.getInfinity();
                }
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarInvert = p5a196a0aVarSubtract3.multiply(p5a196a0aVarSubtract).invert();
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarMultiply = p5a196a0aVarSubtract3.multiply(p5a196a0aVarInvert).multiply(p5a196a0aVarSubtract2);
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSubtract4 = two(p5a196a0aVar).multiply(p5a196a0aVarSquare).multiply(p5a196a0aVarSubtract).multiply(p5a196a0aVarInvert).subtract(p5a196a0aVarMultiply);
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarAdd = p5a196a0aVarSubtract4.subtract(p5a196a0aVarMultiply).multiply(p5a196a0aVarMultiply.Add(p5a196a0aVarSubtract4)).Add(p5a196a0aVar3);
                return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f$p375bd7ee(curve, p5a196a0aVarAdd, p5a196a0aVar2.subtract(p5a196a0aVarAdd).multiply(p5a196a0aVarSubtract4).subtract(p5a196a0aVar));
            }
        }
        return p53a5793fVar;
    }

    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Two(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        return p5a196a0aVar.Add(p5a196a0aVar);
    }
}

