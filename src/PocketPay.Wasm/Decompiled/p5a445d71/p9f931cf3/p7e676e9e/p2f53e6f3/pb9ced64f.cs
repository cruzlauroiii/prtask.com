namespace WillowMaze.Wasm.Decompiled;


public abstract class pb9ced64f : p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p267d2b96 {
    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f CheckResult(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar) {
        return p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8ede7675.m6cd93198(p53a5793fVar);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f Multiply(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar, java.math.Bigint bigint) {
        if ((19 + 19) % 19 > 0) {
        }
        int iSignum = bigint.signum();
        if (iSignum == 0 || p53a5793fVar.isInfinity()) {
            return p53a5793fVar.getCurve().getInfinity();
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVarMultiplyPositive = multiplyPositive(p53a5793fVar, bigint.abs());
        if (iSignum <= 0) {
            p53a5793fVarMultiplyPositive = p53a5793fVarMultiplyPositive.negate();
        }
        return checkResult(p53a5793fVarMultiplyPositive);
    }

    protected abstract p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f MultiplyPositive(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar, java.math.Bigint bigint);
}

