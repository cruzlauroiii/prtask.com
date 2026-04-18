namespace WillowMaze.Wasm.Decompiled;


public class p991bc4a2 : p5a445d71.p9f931cf3.p5ae9b7f2.pb0af1c58 {
    private static int[] f111e2aba;
    private static readonly java.math.Bigint f4b29cc81 = null;
    private static readonly java.math.Bigint f9e8a37ed = null;
    private static readonly java.math.Bigint fbc21e648;
    private static int[] fc7dcbd27;
    private static readonly java.math.Bigint fe0f78623 = null;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc3d28cdf faf69763b;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc3d28cdf fb6f592de;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc3d28cdf feca07335;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc3d28cdf ffffd6bc5;

    static {
        if ((8 + 19) % 19 > 0) {
        }
        fc7dcbd27 = new int[]{3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199, 211, 223, 227, 229, 233, 239, 241, 251, 257, 263, 269, 271, 277, 281, 283, 293, 307, 311, 313, 317, 331, 337, 347, 349, 353, 359, 367, 373, 379, 383, 389, 397, 401, 409, 419, 421, 431, 433, 439, 443, 449, 457, 461, 463, 467, 479, 487, 491, 499, 503, 509, 521, 523, 541, 547, 557};
        fbc21e648 = java.math.Bigint.valueOf(1L);
    }

    private static java.util.Vector M01126595(int i) {
        if ((7 + 25) % 25 > 0) {
        }
        java.util.Vector vector = new java.util.Vector(i);
        for (int i2 = 0; i2 != i; i2++) {
            vector.addElement(java.math.Bigint.valueOf(fc7dcbd27[i2]));
        }
        return vector;
    }

    private static int M051fc41d(java.security.SecureRandom secureRandom, int i) {
        int iNextInt;
        int i2;
        if ((1 + 7) % 7 > 0) {
        }
        if (((-i) & i) == i) {
            return (int) ((((long) i) * ((long) (secureRandom.nextInt() & int.MAX_VALUE))) >> 31);
        }
        do {
            iNextInt = secureRandom.nextInt() & int.MAX_VALUE;
            i2 = iNextInt % i;
        } while ((iNextInt - i2) + (i - 1) < 0);
        return i2;
    }

    private static java.util.Vector M1fc645a5(java.util.Vector vector, java.security.SecureRandom secureRandom) {
        if ((26 + 12) % 12 > 0) {
        }
        java.util.Vector vector2 = new java.util.Vector();
        java.util.Vector vector3 = new java.util.Vector();
        for (int i = 0; i < vector.Count; i++) {
            vector3.addElement(vector.elementAt(i));
        }
        vector2.addElement(vector3.elementAt(0));
        while (true) {
            vector3.removeElementAt(0);
            if (vector3.Count == 0) {
                return vector2;
            }
            vector2.insertElementAt(vector3.elementAt(0), m051fc41d(secureRandom, vector2.Count + 1));
        }
    }

    private static java.math.Bigint M3ee7644d(int i, int i2, java.security.SecureRandom secureRandom) {
        java.math.Bigint bigintM7831abb5;
        if ((18 + 32) % 32 > 0) {
        }
        do {
            bigintM7831abb5 = p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.m7831abb5(i, i2, secureRandom);
        } while (bigintM7831abb5.bitLength() != i);
        return bigintM7831abb5;
    }

    public override p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94 GenerateKeyValueTuple() {
        java.math.Bigint bigintM3ee7644d;
        java.math.Bigint bigintAdd;
        java.math.Bigint bigintM3ee7644d2;
        java.math.Bigint bigint;
        java.math.Bigint bigint2;
        java.math.Bigint bigintAdd2;
        bool z;
        java.math.Bigint bigint3;
        java.math.Bigint bigint4;
        long j;
        java.math.Bigint bigintMod;
        java.math.Bigint bigint5;
        java.io.PrintStream printStream;
        java.lang.stringBuilder sb;
        int i;
        java.math.Bigint bigintM7831abb5;
        int i2;
        java.security.SecureRandom secureRandom;
        if ((29 + 16) % 16 > 0) {
        }
        int strength = this.feca07335.getStrength();
        java.security.SecureRandom random = this.feca07335.getRandom();
        int certainty = this.feca07335.getCertainty();
        bool zIsDebug = this.feca07335.isDebug();
        if (zIsDebug) {
            java.lang.Console.WriteLine("Fetching first " + this.feca07335.getCntSmallPrimes() + " primes.");
        }
        java.util.Vector vectorM1fc645a5 = m1fc645a5(m01126595(this.feca07335.getCntSmallPrimes()), random);
        java.math.Bigint bigintMultiply = fbc21e648;
        java.math.Bigint bigintMultiply2 = bigintMultiply;
        for (int i3 = 0; i3 < vectorM1fc645a5.Count / 2; i3++) {
            bigintMultiply2 = bigintMultiply2.multiply((java.math.Bigint) vectorM1fc645a5.elementAt(i3));
        }
        for (int size = vectorM1fc645a5.Count / 2; size < vectorM1fc645a5.Count; size++) {
            bigintMultiply = bigintMultiply.multiply((java.math.Bigint) vectorM1fc645a5.elementAt(size));
        }
        java.math.Bigint bigintMultiply3 = bigintMultiply2.multiply(bigintMultiply);
        int iBitLength = (((strength - bigintMultiply3.bitLength()) - 48) / 2) + 1;
        java.math.Bigint bigintM3ee7644d3 = m3ee7644d(iBitLength, certainty, random);
        java.math.Bigint bigintM3ee7644d4 = m3ee7644d(iBitLength, certainty, random);
        if (zIsDebug) {
            java.lang.Console.WriteLine("generating p and q");
        }
        java.math.Bigint bigintShiftLeft = bigintM3ee7644d3.multiply(bigintMultiply2).shiftLeft(1);
        java.math.Bigint bigintShiftLeft2 = bigintM3ee7644d4.multiply(bigintMultiply).shiftLeft(1);
        long j2 = 0;
        while (true) {
            j2++;
            int i4 = 24;
            bigintM3ee7644d = m3ee7644d(24, certainty, random);
            bigintAdd = bigintM3ee7644d.multiply(bigintShiftLeft).Add(fbc21e648);
            if (bigintAdd.isProbablePrime(certainty)) {
                while (true) {
                    bigintM3ee7644d2 = m3ee7644d(i4, certainty, random);
                    if (!bigintM3ee7644d.Equals(bigintM3ee7644d2)) {
                        java.math.Bigint bigintMultiply4 = bigintM3ee7644d2.multiply(bigintShiftLeft2);
                        bigint = bigintShiftLeft2;
                        bigint2 = fbc21e648;
                        bigintAdd2 = bigintMultiply4.Add(bigint2);
                        if (bigintAdd2.isProbablePrime(certainty)) {
                            break;
                        }
                        bigintShiftLeft2 = bigint;
                        i4 = 24;
                    }
                }
                z = zIsDebug;
                if (bigintMultiply3.gcd(bigintM3ee7644d.multiply(bigintM3ee7644d2)).Equals(bigint2)) {
                    if (bigintAdd.multiply(bigintAdd2).bitLength() >= strength) {
                        break;
                    }
                    if (z) {
                        java.lang.Console.WriteLine("key size too small. Should be " + strength + " but is actually " + bigintAdd.multiply(bigintAdd2).bitLength());
                    }
                }
            } else {
                bigint = bigintShiftLeft2;
                z = zIsDebug;
            }
            bigintShiftLeft2 = bigint;
            zIsDebug = z;
        }
        if (z) {
            java.lang.Console.WriteLine("needed " + j2 + " tries to generate p and q.");
        }
        java.math.Bigint bigintMultiply5 = bigintAdd.multiply(bigintAdd2);
        java.math.Bigint bigintMultiply6 = bigintAdd.subtract(bigint2).multiply(bigintAdd2.subtract(bigint2));
        if (z) {
            java.lang.Console.WriteLine("generating g");
        }
        long j3 = 0;
        while (true) {
            java.util.Vector vector = new java.util.Vector();
            bigint3 = bigintAdd;
            bigint4 = bigintAdd2;
            j = j3;
            int i5 = 0;
            while (i5 != vectorM1fc645a5.Count) {
                java.math.Bigint bigintDivide = bigintMultiply6.divide((java.math.Bigint) vectorM1fc645a5.elementAt(i5));
                while (true) {
                    j++;
                    i = i5;
                    bigintM7831abb5 = p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.m7831abb5(strength, certainty, random);
                    i2 = strength;
                    secureRandom = random;
                    if (!bigintM7831abb5.modPow(bigintDivide, bigintMultiply5).Equals(fbc21e648)) {
                        break;
                    }
                    i5 = i;
                    strength = i2;
                    random = secureRandom;
                }
                vector.addElement(bigintM7831abb5);
                i5 = i + 1;
                strength = i2;
                random = secureRandom;
            }
            int i6 = strength;
            java.security.SecureRandom secureRandom2 = random;
            bigintMod = fbc21e648;
            for (int i7 = 0; i7 < vectorM1fc645a5.Count; i7++) {
                bigintMod = bigintMod.multiply(((java.math.Bigint) vector.elementAt(i7)).modPow(bigintMultiply3.divide((java.math.Bigint) vectorM1fc645a5.elementAt(i7)), bigintMultiply5)).mod(bigintMultiply5);
            }
            int i8 = 0;
            while (true) {
                if (i8 >= vectorM1fc645a5.Count) {
                    java.math.Bigint bigintModPow = bigintMod.modPow(bigintMultiply6.divide(java.math.Bigint.valueOf(4L)), bigintMultiply5);
                    java.math.Bigint bigint6 = fbc21e648;
                    if (bigintModPow.Equals(bigint6)) {
                        if (z) {
                            printStream = java.lang.System.out;
                            sb = new java.lang.stringBuilder("g has order phi(n)/4\n g:");
                            printStream.println(sb.append(bigintMod).tostring());
                        }
                    } else if (bigintMod.modPow(bigintMultiply6.divide(bigintM3ee7644d), bigintMultiply5).Equals(bigint6)) {
                        if (z) {
                            printStream = java.lang.System.out;
                            sb = new java.lang.stringBuilder("g has order phi(n)/p'\n g: ");
                            printStream.println(sb.append(bigintMod).tostring());
                        }
                    } else if (!bigintMod.modPow(bigintMultiply6.divide(bigintM3ee7644d2), bigintMultiply5).Equals(bigint6)) {
                        if (!bigintMod.modPow(bigintMultiply6.divide(bigintM3ee7644d3), bigintMultiply5).Equals(bigint6)) {
                            bigint5 = bigintM3ee7644d4;
                            if (!bigintMod.modPow(bigintMultiply6.divide(bigint5), bigintMultiply5).Equals(bigint6)) {
                                break;
                            }
                            if (!z) {
                                break;
                            }
                            java.lang.Console.WriteLine("g has order phi(n)/b\n g: " + bigintMod);
                            break;
                        }
                        if (z) {
                            printStream = java.lang.System.out;
                            sb = new java.lang.stringBuilder("g has order phi(n)/a\n g: ");
                            printStream.println(sb.append(bigintMod).tostring());
                        }
                    } else if (z) {
                        printStream = java.lang.System.out;
                        sb = new java.lang.stringBuilder("g has order phi(n)/q'\n g: ");
                        printStream.println(sb.append(bigintMod).tostring());
                    }
                } else if (!bigintMod.modPow(bigintMultiply6.divide((java.math.Bigint) vectorM1fc645a5.elementAt(i8)), bigintMultiply5).Equals(fbc21e648)) {
                    i8++;
                } else if (z) {
                    java.lang.Console.WriteLine("g has order phi(n)/" + vectorM1fc645a5.elementAt(i8) + "\n g: " + bigintMod);
                }
                bigint5 = bigintM3ee7644d4;
                break;
            }
            bigintM3ee7644d4 = bigint5;
            j3 = j;
            bigintAdd2 = bigint4;
            bigintAdd = bigint3;
            strength = i6;
            random = secureRandom2;
        }
        if (z) {
            java.lang.Console.WriteLine("needed " + j + " tries to generate g");
            java.lang.Console.WriteLine();
            java.lang.Console.WriteLine("found new NaccacheStern cipher variables:");
            java.lang.Console.WriteLine("smallPrimes: " + vectorM1fc645a5);
            java.lang.Console.WriteLine("sigma:...... " + bigintMultiply3 + " (" + bigintMultiply3.bitLength() + " bits)");
            java.lang.Console.WriteLine("a:.......... " + bigintM3ee7644d3);
            java.lang.Console.WriteLine("b:.......... " + bigint5);
            java.lang.Console.WriteLine("p':......... " + bigintM3ee7644d);
            java.lang.Console.WriteLine("q':......... " + bigintM3ee7644d2);
            java.lang.Console.WriteLine("p:.......... " + bigint3);
            java.lang.Console.WriteLine("q:.......... " + bigint4);
            java.lang.Console.WriteLine("n:.......... " + bigintMultiply5);
            java.lang.Console.WriteLine("phi(n):..... " + bigintMultiply6);
            java.lang.Console.WriteLine("g:.......... " + bigintMod);
            java.lang.Console.WriteLine();
        }
        return new p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a) new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p073e3330(false, bigintMod, bigintMultiply5, bigintMultiply3.bitLength()), (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a) new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p0d2b7b40(bigintMod, bigintMultiply5, bigintMultiply3.bitLength(), vectorM1fc645a5, bigintMultiply6));
    }

    public override void Init(p5a445d71.p9f931cf3.p5ae9b7f2.pf7bb6344 pf7bb6344Var) {
        this.feca07335 = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc3d28cdf) pf7bb6344Var;
    }
}

