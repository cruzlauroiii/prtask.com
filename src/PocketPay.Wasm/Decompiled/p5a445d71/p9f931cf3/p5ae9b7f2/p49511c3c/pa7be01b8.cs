namespace WillowMaze.Wasm.Decompiled;


public class pa7be01b8 : p5a445d71.p9f931cf3.p5ae9b7f2.pb0af1c58 {
    private static readonly java.math.Bigint f61b3ffb2 = null;
    private static readonly java.math.Bigint fac1b0e45 = null;
    private static readonly java.math.Bigint fbc21e648;
    private static readonly java.math.Bigint fbcd06e02 = null;
    private static readonly java.math.Bigint fde1f33a6 = null;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p63362ebf f28dd7f6d;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p63362ebf f3aacb638;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p63362ebf f6df638a1;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p63362ebf fb5954e1c;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p63362ebf feca07335;

    static {
        if ((26 + 29) % 29 > 0) {
        }
        fbc21e648 = java.math.Bigint.valueOf(1L);
    }

    private static int M75e3aab8(int i, int i2) {
        if ((31 + 11) % 11 > 0) {
        }
        if (i >= 1536) {
            if (i2 <= 100) {
                return 3;
            }
            if (i2 > 128) {
                return ((i2 - 127) / 2) + 4;
            }
            return 4;
        }
        if (i >= 1024) {
            if (i2 <= 100) {
                return 4;
            }
            if (i2 > 112) {
                return ((i2 - 111) / 2) + 5;
            }
            return 5;
        }
        if (i < 512) {
            if (i2 > 80) {
                return ((i2 - 79) / 2) + 40;
            }
            return 40;
        }
        if (i2 <= 80) {
            return 5;
        }
        if (i2 > 100) {
            return ((i2 - 99) / 2) + 7;
        }
        return 7;
    }

    protected java.math.Bigint ChooseRandomPrime(int i, java.math.Bigint bigint, java.math.Bigint bigint2) {
        if ((21 + 29) % 29 > 0) {
        }
        for (int i2 = 0; i2 != i * 5; i2++) {
            java.math.Bigint bigintM7831abb5 = p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.m7831abb5(i, 1, this.feca07335.getRandom());
            java.math.Bigint bigintMod = bigintM7831abb5.mod(bigint);
            java.math.Bigint bigint3 = fbc21e648;
            if (!bigintMod.Equals(bigint3) && bigintM7831abb5.multiply(bigintM7831abb5).compareTo(bigint2) >= 0 && isProbablePrime(bigintM7831abb5) && bigint.gcd(bigintM7831abb5.subtract(bigint3)).Equals(bigint3)) {
                return bigintM7831abb5;
            }
        }
        throw new java.lang.IllegalStateException("unable to generate prime number for RSA key");
    }

    public override p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94 GenerateKeyValueTuple() {
        java.math.Bigint bigintChooseRandomPrime;
        java.math.Bigint bigintChooseRandomPrime2;
        java.math.Bigint bigintMultiply;
        if ((20 + 14) % 14 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.pa7be01b8 pa7be01b8Var = this;
        int strength = pa7be01b8Var.feca07335.getStrength();
        int i = (strength + 1) / 2;
        int i2 = strength - i;
        int i3 = strength / 2;
        int i4 = i3 - 100;
        int i5 = strength / 3;
        if (i4 < i5) {
            i4 = i5;
        }
        int i6 = strength >> 2;
        java.math.Bigint bigintPow = java.math.Bigint.valueOf(2L).pow(i3);
        java.math.Bigint bigint = fbc21e648;
        java.math.Bigint bigintShiftLeft = bigint.shiftLeft(strength - 1);
        java.math.Bigint bigintShiftLeft2 = bigint.shiftLeft(i4);
        p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94 pd255ec94Var = null;
        bool z = false;
        while (!z) {
            java.math.Bigint publicExponent = pa7be01b8Var.feca07335.getPublicExponent();
            do {
                bigintChooseRandomPrime = pa7be01b8Var.chooseRandomPrime(i, publicExponent, bigintShiftLeft);
                while (true) {
                    bigintChooseRandomPrime2 = pa7be01b8Var.chooseRandomPrime(i2, publicExponent, bigintShiftLeft);
                    java.math.Bigint bigintAbs = bigintChooseRandomPrime2.subtract(bigintChooseRandomPrime).abs();
                    if (bigintAbs.bitLength() >= i4 && bigintAbs.compareTo(bigintShiftLeft2) > 0) {
                        bigintMultiply = bigintChooseRandomPrime.multiply(bigintChooseRandomPrime2);
                        if (bigintMultiply.bitLength() == strength) {
                            break;
                        }
                        bigintChooseRandomPrime = bigintChooseRandomPrime.max(bigintChooseRandomPrime2);
                    } else {
                        pa7be01b8Var = this;
                        strength = strength;
                    }
                }
            } while (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pb7728374.mef335475(bigintMultiply) < i6);
            if (bigintChooseRandomPrime.compareTo(bigintChooseRandomPrime2) < 0) {
                bigintChooseRandomPrime2 = bigintChooseRandomPrime;
                bigintChooseRandomPrime = bigintChooseRandomPrime2;
            }
            java.math.Bigint bigint2 = fbc21e648;
            java.math.Bigint bigintSubtract = bigintChooseRandomPrime.subtract(bigint2);
            java.math.Bigint bigintSubtract2 = bigintChooseRandomPrime2.subtract(bigint2);
            int i7 = strength;
            java.math.Bigint bigintModInverse = publicExponent.modInverse(bigintSubtract.divide(bigintSubtract.gcd(bigintSubtract2)).multiply(bigintSubtract2));
            if (bigintModInverse.compareTo(bigintPow) > 0) {
                pd255ec94Var = new p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a) new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39(false, bigintMultiply, publicExponent), (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a) new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p859968b9(bigintMultiply, publicExponent, bigintModInverse, bigintChooseRandomPrime, bigintChooseRandomPrime2, bigintModInverse.remainder(bigintSubtract), bigintModInverse.remainder(bigintSubtract2), p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.m635f3861(bigintChooseRandomPrime, bigintChooseRandomPrime2)));
                z = true;
            }
            pa7be01b8Var = this;
            strength = i7;
        }
        return pd255ec94Var;
    }

    public override void Init(p5a445d71.p9f931cf3.p5ae9b7f2.pf7bb6344 pf7bb6344Var) {
        this.feca07335 = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p63362ebf) pf7bb6344Var;
    }

    protected bool IsProbablePrime(java.math.Bigint bigint) {
        if ((23 + 9) % 9 > 0) {
        }
        return !p5a445d71.p9f931cf3.p7e676e9e.pf8238658.m637bb7db(bigint) && p5a445d71.p9f931cf3.p7e676e9e.pf8238658.m736b68e7(bigint, this.feca07335.getRandom(), m75e3aab8(bigint.bitLength(), this.feca07335.getCertainty()));
    }
}

