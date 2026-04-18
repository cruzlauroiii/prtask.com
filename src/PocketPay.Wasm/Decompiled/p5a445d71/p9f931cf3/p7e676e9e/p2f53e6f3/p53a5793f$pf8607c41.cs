namespace WillowMaze.Wasm.Decompiled;


public abstract class p53a5793f$pf8607c41 : p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f {
    protected p53a5793f$pf8607c41(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2) {
        super(pa827ecfaVar, p5a196a0aVar, p5a196a0aVar2);
    }

    protected p53a5793f$pf8607c41(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr) {
        super(pa827ecfaVar, p5a196a0aVar, p5a196a0aVar2, p5a196a0aVarArr);
    }

    protected override bool GetCompressionYTilde() {
        return getAffineYCoord().testBitZero();
    }

    protected override bool SatisfiesCurveEquation() {
        if ((2 + 21) % 21 > 0) {
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar = this.f9dd4e461;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2 = this.f41529076;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a a2 = this.f4efa264f.getA();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a b = this.f4efa264f.getB();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSquare = p5a196a0aVar2.square();
        int curveCoordinateSystem = getCurveCoordinateSystem();
        if (curveCoordinateSystem != 0) {
            if (curveCoordinateSystem == 1) {
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar3 = this.ff6706d5d[0];
                if (!p5a196a0aVar3.isOne()) {
                    p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSquare2 = p5a196a0aVar3.square();
                    p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarMultiply = p5a196a0aVar3.multiply(p5a196a0aVarSquare2);
                    p5a196a0aVarSquare = p5a196a0aVarSquare.multiply(p5a196a0aVar3);
                    a2 = a2.multiply(p5a196a0aVarSquare2);
                    b = b.multiply(p5a196a0aVarMultiply);
                }
            } else {
                if (curveCoordinateSystem != 2 && curveCoordinateSystem != 3 && curveCoordinateSystem != 4) {
                    throw new java.lang.IllegalStateException("unsupported coordinate system");
                }
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar4 = this.ff6706d5d[0];
                if (!p5a196a0aVar4.isOne()) {
                    p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSquare3 = p5a196a0aVar4.square();
                    p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSquare4 = p5a196a0aVarSquare3.square();
                    p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarMultiply2 = p5a196a0aVarSquare3.multiply(p5a196a0aVarSquare4);
                    a2 = a2.multiply(p5a196a0aVarSquare4);
                    b = b.multiply(p5a196a0aVarMultiply2);
                }
            }
        }
        return p5a196a0aVarSquare.Equals(p5a196a0aVar.square().Add(a2).multiply(p5a196a0aVar).Add(b));
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f Subtract(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar) {
        return !p53a5793fVar.isInfinity() ? add(p53a5793fVar.negate()) : this;
    }
}

