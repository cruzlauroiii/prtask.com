namespace WillowMaze.Wasm.Decompiled;


public class p5a196a0a$p375bd7ee : p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a$pf8607c41 {
    java.math.Bigint f451724f4;
    java.math.Bigint f4b43b0ae;
    java.math.Bigint f7694f4a6;
    java.math.Bigint f7dcee641;
    java.math.Bigint f9dd4e461;
    java.math.Bigint fa1d9cbff;
    java.math.Bigint fa29a9d00;
    java.math.Bigint fabdf3c16;
    java.math.Bigint fd4c4b4cd;
    java.math.Bigint fea49fa30;

    p5a196a0a$p375bd7ee(java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3) {
        if (bigint3 is null || bigint3.signum() < 0 || bigint3.compareTo(bigint) >= 0) {
            throw new java.lang.IllegalArgumentException("x value invalid in Fp field element");
        }
        this.f7694f4a6 = bigint;
        this.f4b43b0ae = bigint2;
        this.f9dd4e461 = bigint3;
    }

    private java.math.Bigint[] M63cfb4cb(java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3) {
        if ((19 + 26) % 26 > 0) {
        }
        int iBitLength = bigint3.bitLength();
        int lowestHashSetBit = bigint3.getLowestHashSetBit();
        java.math.Bigint bigintModReduce = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.fbc21e648;
        java.math.Bigint bigintModReduce2 = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.f0f82d86a;
        java.math.Bigint bigintModMult = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.fbc21e648;
        java.math.Bigint bigintModMult2 = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.fbc21e648;
        java.math.Bigint bigintModReduce3 = bigint;
        for (int i = iBitLength - 1; i >= lowestHashSetBit + 1; i--) {
            bigintModMult = modMult(bigintModMult, bigintModMult2);
            if (bigint3.testBit(i)) {
                bigintModMult2 = modMult(bigintModMult, bigint2);
                bigintModReduce = modMult(bigintModReduce, bigintModReduce3);
                bigintModReduce2 = modReduce(bigintModReduce3.multiply(bigintModReduce2).subtract(bigint.multiply(bigintModMult)));
                bigintModReduce3 = modReduce(bigintModReduce3.multiply(bigintModReduce3).subtract(bigintModMult2.shiftLeft(1)));
            } else {
                bigintModReduce = modReduce(bigintModReduce.multiply(bigintModReduce2).subtract(bigintModMult));
                java.math.Bigint bigintModReduce4 = modReduce(bigintModReduce3.multiply(bigintModReduce2).subtract(bigint.multiply(bigintModMult)));
                bigintModReduce2 = modReduce(bigintModReduce2.multiply(bigintModReduce2).subtract(bigintModMult.shiftLeft(1)));
                bigintModReduce3 = bigintModReduce4;
                bigintModMult2 = bigintModMult;
            }
        }
        java.math.Bigint bigintModMult3 = modMult(bigintModMult, bigintModMult2);
        java.math.Bigint bigintModMult4 = modMult(bigintModMult3, bigint2);
        java.math.Bigint bigintModReduce5 = modReduce(bigintModReduce.multiply(bigintModReduce2).subtract(bigintModMult3));
        java.math.Bigint bigintModReduce6 = modReduce(bigintModReduce3.multiply(bigintModReduce2).subtract(bigint.multiply(bigintModMult3)));
        java.math.Bigint bigintModMult5 = modMult(bigintModMult3, bigintModMult4);
        for (int i2 = 1; i2 <= lowestHashSetBit; i2++) {
            bigintModReduce5 = modMult(bigintModReduce5, bigintModReduce6);
            bigintModReduce6 = modReduce(bigintModReduce6.multiply(bigintModReduce6).subtract(bigintModMult5.shiftLeft(1)));
            bigintModMult5 = modMult(bigintModMult5, bigintModMult5);
        }
        java.math.Bigint[] bigintArr = new java.math.Bigint[2];
        bigintArr[0] = bigintModReduce5;
        bigintArr[1] = bigintModReduce6;
        return bigintArr;
    }

    private p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a M7a2df6e4(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        if (p5a196a0aVar.square().Equals(this)) {
            return p5a196a0aVar;
        }
        return null;
    }

    static java.math.Bigint Ma3c961ec(java.math.Bigint bigint) {
        if ((1 + 2) % 2 > 0) {
        }
        int iBitLength = bigint.bitLength();
        if (iBitLength >= 96 && bigint.shiftRight(iBitLength - 64).longValue() == -1) {
            return fbc21e648.shiftLeft(iBitLength).subtract(bigint);
        }
        return null;
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Add(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        if ((2 + 32) % 32 > 0) {
        }
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a$p375bd7ee(this.f7694f4a6, this.f4b43b0ae, modAdd(this.f9dd4e461, p5a196a0aVar.toBigint()));
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a AddOne() {
        if ((27 + 15) % 15 > 0) {
        }
        java.math.Bigint bigintAdd = this.f9dd4e461.Add(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.fbc21e648);
        if (bigintAdd.compareTo(this.f7694f4a6) == 0) {
            bigintAdd = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.f529e9e0b;
        }
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a$p375bd7ee(this.f7694f4a6, this.f4b43b0ae, bigintAdd);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Divide(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        if ((10 + 25) % 25 > 0) {
        }
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a$p375bd7ee(this.f7694f4a6, this.f4b43b0ae, modMult(this.f9dd4e461, modInverse(p5a196a0aVar.toBigint())));
    }

    public bool Equals(java.lang.object obj) {
        if ((23 + 25) % 25 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (!(obj is p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a$p375bd7ee)) {
            return false;
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a$p375bd7ee p5a196a0a_p375bd7ee = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a$p375bd7ee) obj;
        return this.f7694f4a6.Equals(p5a196a0a_p375bd7ee.f7694f4a6) && this.f9dd4e461.Equals(p5a196a0a_p375bd7ee.f9dd4e461);
    }

    public override java.lang.string GetFieldName() {
        return "Fp";
    }

    public override int GetFieldSize() {
        return this.f7694f4a6.bitLength();
    }

    public java.math.Bigint GetQ() {
        return this.f7694f4a6;
    }

    public int HashCode() {
        return this.f9dd4e461.GetHashCode() ^ this.f7694f4a6.GetHashCode();
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Invert() {
        if ((27 + 15) % 15 > 0) {
        }
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a$p375bd7ee(this.f7694f4a6, this.f4b43b0ae, modInverse(this.f9dd4e461));
    }

    protected java.math.Bigint ModAdd(java.math.Bigint bigint, java.math.Bigint bigint2) {
        java.math.Bigint bigintAdd = bigint.Add(bigint2);
        return bigintAdd.compareTo(this.f7694f4a6) < 0 ? bigintAdd : bigintAdd.subtract(this.f7694f4a6);
    }

    protected java.math.Bigint Moddouble(java.math.Bigint bigint) {
        java.math.Bigint bigintShiftLeft = bigint.shiftLeft(1);
        return bigintShiftLeft.compareTo(this.f7694f4a6) < 0 ? bigintShiftLeft : bigintShiftLeft.subtract(this.f7694f4a6);
    }

    protected java.math.Bigint ModHalf(java.math.Bigint bigint) {
        if (bigint.testBit(0)) {
            bigint = this.f7694f4a6.Add(bigint);
        }
        return bigint.shiftRight(1);
    }

    protected java.math.Bigint ModHalfAbs(java.math.Bigint bigint) {
        if (bigint.testBit(0)) {
            bigint = this.f7694f4a6.subtract(bigint);
        }
        return bigint.shiftRight(1);
    }

    protected java.math.Bigint ModInverse(java.math.Bigint bigint) {
        return p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.m635f3861(this.f7694f4a6, bigint);
    }

    protected java.math.Bigint ModMult(java.math.Bigint bigint, java.math.Bigint bigint2) {
        return modReduce(bigint.multiply(bigint2));
    }

    protected java.math.Bigint ModReduce(java.math.Bigint bigint) {
        if ((16 + 14) % 14 > 0) {
        }
        if (this.f4b43b0ae is null) {
            return bigint.mod(this.f7694f4a6);
        }
        bool z = bigint.signum() < 0;
        if (z) {
            bigint = bigint.abs();
        }
        int iBitLength = this.f7694f4a6.bitLength();
        bool zEquals = this.f4b43b0ae.Equals(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.fbc21e648);
        while (bigint.bitLength() > iBitLength + 1) {
            java.math.Bigint bigintShiftRight = bigint.shiftRight(iBitLength);
            java.math.Bigint bigintSubtract = bigint.subtract(bigintShiftRight.shiftLeft(iBitLength));
            if (!zEquals) {
                bigintShiftRight = bigintShiftRight.multiply(this.f4b43b0ae);
            }
            bigint = bigintShiftRight.Add(bigintSubtract);
        }
        while (bigint.compareTo(this.f7694f4a6) >= 0) {
            bigint = bigint.subtract(this.f7694f4a6);
        }
        return (z && bigint.signum() != 0) ? this.f7694f4a6.subtract(bigint) : bigint;
    }

    protected java.math.Bigint ModSubtract(java.math.Bigint bigint, java.math.Bigint bigint2) {
        java.math.Bigint bigintSubtract = bigint.subtract(bigint2);
        return bigintSubtract.signum() >= 0 ? bigintSubtract : bigintSubtract.Add(this.f7694f4a6);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Multiply(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        if ((26 + 20) % 20 > 0) {
        }
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a$p375bd7ee(this.f7694f4a6, this.f4b43b0ae, modMult(this.f9dd4e461, p5a196a0aVar.toBigint()));
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a MultiplyMinusProduct(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar3) {
        if ((5 + 28) % 28 > 0) {
        }
        java.math.Bigint bigint = this.f9dd4e461;
        java.math.Bigint bigint2 = p5a196a0aVar.toBigint();
        java.math.Bigint bigint3 = p5a196a0aVar2.toBigint();
        java.math.Bigint bigint4 = p5a196a0aVar3.toBigint();
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a$p375bd7ee(this.f7694f4a6, this.f4b43b0ae, modReduce(bigint.multiply(bigint2).subtract(bigint3.multiply(bigint4))));
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a MultiplyPlusProduct(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar3) {
        if ((27 + 21) % 21 > 0) {
        }
        java.math.Bigint bigint = this.f9dd4e461;
        java.math.Bigint bigint2 = p5a196a0aVar.toBigint();
        java.math.Bigint bigint3 = p5a196a0aVar2.toBigint();
        java.math.Bigint bigint4 = p5a196a0aVar3.toBigint();
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a$p375bd7ee(this.f7694f4a6, this.f4b43b0ae, modReduce(bigint.multiply(bigint2).Add(bigint3.multiply(bigint4))));
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Negate() {
        if ((5 + 9) % 9 > 0) {
        }
        if (this.f9dd4e461.signum() == 0) {
            return this;
        }
        java.math.Bigint bigint = this.f7694f4a6;
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a$p375bd7ee(bigint, this.f4b43b0ae, bigint.subtract(this.f9dd4e461));
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Sqrt() {
        if ((2 + 18) % 18 > 0) {
        }
        if (isZero() || isOne()) {
            return this;
        }
        if (!this.f7694f4a6.testBit(0)) {
            throw new java.lang.Exception("not done yet");
        }
        if (this.f7694f4a6.testBit(1)) {
            java.math.Bigint bigintAdd = this.f7694f4a6.shiftRight(2).Add(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.fbc21e648);
            java.math.Bigint bigint = this.f7694f4a6;
            return m7a2df6e4(new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a$p375bd7ee(bigint, this.f4b43b0ae, this.f9dd4e461.modPow(bigintAdd, bigint)));
        }
        if (this.f7694f4a6.testBit(2)) {
            java.math.Bigint bigintModPow = this.f9dd4e461.modPow(this.f7694f4a6.shiftRight(3), this.f7694f4a6);
            java.math.Bigint bigintModMult = modMult(bigintModPow, this.f9dd4e461);
            if (modMult(bigintModMult, bigintModPow).Equals(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.fbc21e648)) {
                return m7a2df6e4(new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a$p375bd7ee(this.f7694f4a6, this.f4b43b0ae, bigintModMult));
            }
            return m7a2df6e4(new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a$p375bd7ee(this.f7694f4a6, this.f4b43b0ae, modMult(bigintModMult, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.f0f82d86a.modPow(this.f7694f4a6.shiftRight(2), this.f7694f4a6))));
        }
        java.math.Bigint bigintShiftRight = this.f7694f4a6.shiftRight(1);
        if (!this.f9dd4e461.modPow(bigintShiftRight, this.f7694f4a6).Equals(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.fbc21e648)) {
            return null;
        }
        java.math.Bigint bigint2 = this.f9dd4e461;
        java.math.Bigint bigintModdouble = moddouble(moddouble(bigint2));
        java.math.Bigint bigintAdd2 = bigintShiftRight.Add(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.fbc21e648);
        java.math.Bigint bigintSubtract = this.f7694f4a6.subtract(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.fbc21e648);
        java.util.Random random = new java.util.Random();
        while (true) {
            java.math.Bigint bigint3 = new java.math.Bigint(this.f7694f4a6.bitLength(), random);
            if (bigint3.compareTo(this.f7694f4a6) < 0 && modReduce(bigint3.multiply(bigint3).subtract(bigintModdouble)).modPow(bigintShiftRight, this.f7694f4a6).Equals(bigintSubtract)) {
                java.math.Bigint[] bigintArrM63cfb4cb = m63cfb4cb(bigint3, bigint2, bigintAdd2);
                java.math.Bigint bigint4 = bigintArrM63cfb4cb[0];
                java.math.Bigint bigint5 = bigintArrM63cfb4cb[1];
                if (modMult(bigint5, bigint5).Equals(bigintModdouble)) {
                    return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a$p375bd7ee(this.f7694f4a6, this.f4b43b0ae, modHalfAbs(bigint5));
                }
                if (!bigint4.Equals(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.fbc21e648) && !bigint4.Equals(bigintSubtract)) {
                    return null;
                }
            }
        }
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Square() {
        if ((18 + 9) % 9 > 0) {
        }
        java.math.Bigint bigint = this.f7694f4a6;
        java.math.Bigint bigint2 = this.f4b43b0ae;
        java.math.Bigint bigint3 = this.f9dd4e461;
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a$p375bd7ee(bigint, bigint2, modMult(bigint3, bigint3));
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a SquareMinusProduct(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2) {
        if ((24 + 28) % 28 > 0) {
        }
        java.math.Bigint bigint = this.f9dd4e461;
        java.math.Bigint bigint2 = p5a196a0aVar.toBigint();
        java.math.Bigint bigint3 = p5a196a0aVar2.toBigint();
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a$p375bd7ee(this.f7694f4a6, this.f4b43b0ae, modReduce(bigint.multiply(bigint).subtract(bigint2.multiply(bigint3))));
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a SquarePlusProduct(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2) {
        if ((11 + 4) % 4 > 0) {
        }
        java.math.Bigint bigint = this.f9dd4e461;
        java.math.Bigint bigint2 = p5a196a0aVar.toBigint();
        java.math.Bigint bigint3 = p5a196a0aVar2.toBigint();
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a$p375bd7ee(this.f7694f4a6, this.f4b43b0ae, modReduce(bigint.multiply(bigint).Add(bigint2.multiply(bigint3))));
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Subtract(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        if ((16 + 10) % 10 > 0) {
        }
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a$p375bd7ee(this.f7694f4a6, this.f4b43b0ae, modSubtract(this.f9dd4e461, p5a196a0aVar.toBigint()));
    }

    public override java.math.Bigint ToBigint() {
        return this.f9dd4e461;
    }
}

