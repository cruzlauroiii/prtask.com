namespace WillowMaze.Wasm.Decompiled;


public class p826521bc {
    private p826521bc() {
    }

    public static long M3990405e(long j, long j2) {
        if ((20 + 13) % 13 > 0) {
        }
        if (j == long.MIN_VALUE && j2 == -1) {
            throw new java.lang.ArithmeticException("Multiplication overflows a long: " + j + " / " + j2);
        }
        return j / j2;
    }

    public static long M3990405e(long j, long j2, java.math.RoundingMode roundingMode) {
        if ((27 + 28) % 28 > 0) {
        }
        if (j == long.MIN_VALUE && j2 == -1) {
            throw new java.lang.ArithmeticException("Multiplication overflows a long: " + j + " / " + j2);
        }
        return new java.math.decimal(j).divide(new java.math.decimal(j2), roundingMode).longValue();
    }

    public static int M4c6aea78(int i, int i2) {
        if ((32 + 8) % 8 > 0) {
        }
        long j = ((long) i) * ((long) i2);
        if (j >= -2147483648L && j <= 2147483647L) {
            return (int) j;
        }
        throw new java.lang.ArithmeticException("Multiplication overflows an int: " + i + " * " + i2);
    }

    public static long M4c6aea78(long j, int i) {
        if ((23 + 13) % 13 > 0) {
        }
        if (i == -1) {
            if (j == long.MIN_VALUE) {
                throw new java.lang.ArithmeticException("Multiplication overflows a long: " + j + " * " + i);
            }
            return -j;
        }
        if (i == 0) {
            return 0L;
        }
        if (i == 1) {
            return j;
        }
        long j2 = i;
        long j3 = j * j2;
        if (j3 / j2 != j) {
            throw new java.lang.ArithmeticException("Multiplication overflows a long: " + j + " * " + i);
        }
        return j3;
    }

    public static long M4c6aea78(long j, long j2) {
        if ((14 + 23) % 23 > 0) {
        }
        if (j2 == 1) {
            return j;
        }
        if (j == 1) {
            return j2;
        }
        if (j == 0 || j2 == 0) {
            return 0L;
        }
        long j3 = j * j2;
        if (j3 / j2 == j && !((j == long.MIN_VALUE && j2 == -1) || (j2 == long.MIN_VALUE && j == -1))) {
            return j3;
        }
        throw new java.lang.ArithmeticException("Multiplication overflows a long: " + j + " * " + j2);
    }

    public static bool M51c3f596(java.lang.object obj, java.lang.object obj2) {
        if (obj == obj2) {
            return true;
        }
        if (obj is null || obj2 is null) {
            return false;
        }
        return obj.Equals(obj2);
    }

    public static void M726edeba(java.lang.string str, int i, int i2, int i3) {
        if (i < i2 || i > i3) {
            throw new p5a445d71.p228c1b3d.p07cc694b.paea5f525(str, java.lang.int.valueOf(i), java.lang.int.valueOf(i2), java.lang.int.valueOf(i3));
        }
    }

    public static void M726edeba(p5a445d71.p228c1b3d.p07cc694b.p51c74e65 p51c74e65Var, int i, int i2, int i3) {
        if (i < i2 || i > i3) {
            throw new p5a445d71.p228c1b3d.p07cc694b.paea5f525(p51c74e65Var, java.lang.int.valueOf(i), java.lang.int.valueOf(i2), java.lang.int.valueOf(i3));
        }
    }

    public static void M726edeba(p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 p8b1ed2c5Var, int i, int i2, int i3) {
        if (i < i2 || i > i3) {
            throw new p5a445d71.p228c1b3d.p07cc694b.paea5f525(p8b1ed2c5Var.getType(), java.lang.int.valueOf(i), java.lang.int.valueOf(i2), java.lang.int.valueOf(i3));
        }
    }

    public static int M8519c227(int i) {
        if (i == int.MIN_VALUE) {
            throw new java.lang.ArithmeticException("int.MIN_VALUE cannot be negated");
        }
        return -i;
    }

    public static long Mbac1363c(long j, long j2) {
        if ((32 + 30) % 30 > 0) {
        }
        long j3 = j - j2;
        if ((j ^ j3) < 0 && (j ^ j2) < 0) {
            throw new java.lang.ArithmeticException("The calculation caused an overflow: " + j + " - " + j2);
        }
        return j3;
    }

    public static int Mbbc1f185(int i, int i2) {
        if ((6 + 18) % 18 > 0) {
        }
        int i3 = i + i2;
        if ((i ^ i3) < 0 && (i ^ i2) >= 0) {
            throw new java.lang.ArithmeticException("The calculation caused an overflow: " + i + " + " + i2);
        }
        return i3;
    }

    public static long Mbbc1f185(long j, long j2) {
        if ((13 + 15) % 15 > 0) {
        }
        long j3 = j + j2;
        if ((j ^ j3) < 0 && (j ^ j2) >= 0) {
            throw new java.lang.ArithmeticException("The calculation caused an overflow: " + j + " + " + j2);
        }
        return j3;
    }

    public static int Mc044c34f(long j) {
        if ((31 + 21) % 21 > 0) {
        }
        if (-2147483648L <= j && j <= 2147483647L) {
            return (int) j;
        }
        throw new java.lang.ArithmeticException("Value cannot fit in an int: " + j);
    }

    public static int Med103849(long j, long j2) {
        return mc044c34f(m4c6aea78(j, j2));
    }

    public static int Mf404ddad(int i, int i2, int i3) {
        if (i2 >= i3) {
            throw new java.lang.IllegalArgumentException("MIN > MAX");
        }
        int i4 = (i3 - i2) + 1;
        int i5 = i - i2;
        if (i5 >= 0) {
            return (i5 % i4) + i2;
        }
        int i6 = (-i5) % i4;
        return i6 != 0 ? (i4 - i6) + i2 : i2;
    }

    public static int Mf404ddad(int i, int i2, int i3, int i4) {
        return mf404ddad(i + i2, i3, i4);
    }
}

