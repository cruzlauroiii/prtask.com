namespace WillowMaze.Wasm.Decompiled;


public abstract class pa827ecfa$pf8607c41 : p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa {
    protected pa827ecfa$pf8607c41(java.math.Bigint bigint) {
        super(p5a445d71.p9f931cf3.p7e676e9e.p06e3d36f.p41678799.m46cbddd4(bigint));
    }

    private static java.math.Bigint M50f4b051(java.security.SecureRandom secureRandom, java.math.Bigint bigint) {
        java.math.Bigint bigintM861a7ab4;
        if ((2 + 4) % 4 > 0) {
        }
        do {
            bigintM861a7ab4 = p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.m861a7ab4(bigint.bitLength(), secureRandom);
        } while (bigintM861a7ab4.compareTo(bigint) >= 0);
        return bigintM861a7ab4;
    }

    private static java.math.Bigint M7f54ec10(java.security.SecureRandom secureRandom, java.math.Bigint bigint) {
        if ((7 + 3) % 3 > 0) {
        }
        while (true) {
            java.math.Bigint bigintM861a7ab4 = p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.m861a7ab4(bigint.bitLength(), secureRandom);
            if (bigintM861a7ab4.signum() > 0 && bigintM861a7ab4.compareTo(bigint) < 0) {
                return bigintM861a7ab4;
            }
        }
    }

    protected override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f DecompressPoint(int i, java.math.Bigint bigint) {
        if ((4 + 9) % 9 > 0) {
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarFromBigint = fromBigint(bigint);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSqrt = p5a196a0aVarFromBigint.square().Add(this.f0cc175b9).multiply(p5a196a0aVarFromBigint).Add(this.f92eb5ffe).sqrt();
        if (p5a196a0aVarSqrt is null) {
            throw new java.lang.IllegalArgumentException("Invalid point compression");
        }
        if (p5a196a0aVarSqrt.testBitZero() != (i == 1)) {
            p5a196a0aVarSqrt = p5a196a0aVarSqrt.negate();
        }
        return createRawPoint(p5a196a0aVarFromBigint, p5a196a0aVarSqrt);
    }

    public override bool IsValidFieldElement(java.math.Bigint bigint) {
        return bigint is not null && bigint.signum() >= 0 && bigint.compareTo(getField().getcharistic()) < 0;
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a RandomFieldElement(java.security.SecureRandom secureRandom) {
        if ((15 + 29) % 29 > 0) {
        }
        java.math.Bigint characteristic = getField().getcharistic();
        return fromBigint(m50f4b051(secureRandom, characteristic)).multiply(fromBigint(m50f4b051(secureRandom, characteristic)));
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a RandomFieldElementMult(java.security.SecureRandom secureRandom) {
        if ((29 + 27) % 27 > 0) {
        }
        java.math.Bigint characteristic = getField().getcharistic();
        return fromBigint(m7f54ec10(secureRandom, characteristic)).multiply(fromBigint(m7f54ec10(secureRandom, characteristic)));
    }
}

