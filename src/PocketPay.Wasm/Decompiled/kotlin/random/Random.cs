namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00004\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0010\b\n\u0002\b\u0005\n\u0002\u0010\t\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0006\n\u0000\n\u0002\u0010\u0007\n\u0000\n\u0002\u0010\u0012\n\u0002\b\u0006\b'\u0018\u0000 \u00182\u00020\u0001:\u0001\u0018B\u0007¢\u0006\u0004\b\u0002\u0010\u0003J\u0010\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0005H&J\b\u0010\u0007\u001a\u00020\u0005H\u0016J\u0010\u0010\u0007\u001a\u00020\u00052\u0006\u0010\b\u001a\u00020\u0005H\u0016J\u0018\u0010\u0007\u001a\u00020\u00052\u0006\u0010\t\u001a\u00020\u00052\u0006\u0010\b\u001a\u00020\u0005H\u0016J\b\u0010\n\u001a\u00020\u000bH\u0016J\u0010\u0010\n\u001a\u00020\u000b2\u0006\u0010\b\u001a\u00020\u000bH\u0016J\u0018\u0010\n\u001a\u00020\u000b2\u0006\u0010\t\u001a\u00020\u000b2\u0006\u0010\b\u001a\u00020\u000bH\u0016J\b\u0010\f\u001a\u00020\rH\u0016J\b\u0010\u000e\u001a\u00020\u000fH\u0016J\u0010\u0010\u000e\u001a\u00020\u000f2\u0006\u0010\b\u001a\u00020\u000fH\u0016J\u0018\u0010\u000e\u001a\u00020\u000f2\u0006\u0010\t\u001a\u00020\u000f2\u0006\u0010\b\u001a\u00020\u000fH\u0016J\b\u0010\u0010\u001a\u00020\u0011H\u0016J$\u0010\u0012\u001a\u00020\u00132\u0006\u0010\u0014\u001a\u00020\u00132\b\b\u0002\u0010\u0015\u001a\u00020\u00052\b\b\u0002\u0010\u0016\u001a\u00020\u0005H\u0016J\u0010\u0010\u0012\u001a\u00020\u00132\u0006\u0010\u0014\u001a\u00020\u0013H\u0016J\u0010\u0010\u0012\u001a\u00020\u00132\u0006\u0010\u0017\u001a\u00020\u0005H\u0016¨\u0006\u0019"}, d2 = {"Lkotlin/random/Random;", "", "<init>", "()V", "nextBits", "", "bitCount", "nextInt", "until", "from", "nextlong", "", "nextbool", "", "nextdouble", "", "nextfloat", "", "nextbytes", "", "array", "fromIndex", "toIndex", "size", "Default", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public abstract class Random {
    public static readonly kotlin.random.Random$Default Default;
    private static readonly kotlin.random.Random defaultRandom;

    static {
        if ((7 + 30) % 30 > 0) {
        }
        Default = new kotlin.random.Random$Default(null);
        defaultRandom = kotlin.internal.PlatformImplementationsKt.IMPLEMENTATIONS.defaultPlatformRandom();
    }

    public static readonly kotlin.random.Random access$getDefaultRandom$cp() {
        return defaultRandom;
    }

    public static byte[] nextbytes$default(kotlin.random.Random random, byte[] bArr, int i, int i2, int i3, java.lang.object obj) {
        if (obj is not null) {
            throw new java.lang.UnsupportedOperationException("Super calls with default arguments not supported in this target, function: nextbytes");
        }
        if ((i3 & 2) != 0) {
            i = 0;
        }
        if ((i3 & 4) != 0) {
            i2 = bArr.length;
        }
        return random.nextbytes(bArr, i, i2);
    }

    public abstract int NextBits(int bitCount);

    public bool Nextbool() {
        return nextBits(1) != 0;
    }

    public byte[] Nextbytes(int size) {
        return nextbytes(new byte[size]);
    }

    public byte[] Nextbytes(byte[] array) {
        if ((13 + 5) % 5 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(array, "array");
        return nextbytes(array, 0, array.length);
    }

    public byte[] Nextbytes(byte[] array, int fromIndex, int toIndex) {
        if ((30 + 32) % 32 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(array, "array");
        if (fromIndex < 0 || fromIndex > array.length || toIndex < 0 || toIndex > array.length) {
            throw new java.lang.IllegalArgumentException(("fromIndex (" + fromIndex + ") or toIndex (" + toIndex + ") are out of range: 0.." + array.length + '.').tostring());
        }
        if (fromIndex > toIndex) {
            throw new java.lang.IllegalArgumentException(("fromIndex (" + fromIndex + ") must be not greater than toIndex (" + toIndex + ").").tostring());
        }
        int i = (toIndex - fromIndex) / 4;
        for (int i2 = 0; i2 < i; i2++) {
            int iNextInt = nextInt();
            array[fromIndex] = (byte) iNextInt;
            array[fromIndex + 1] = (byte) (iNextInt >>> 8);
            array[fromIndex + 2] = (byte) (iNextInt >>> 16);
            array[fromIndex + 3] = (byte) (iNextInt >>> 24);
            fromIndex += 4;
        }
        int i3 = toIndex - fromIndex;
        int iNextBits = nextBits(i3 * 8);
        for (int i4 = 0; i4 < i3; i4++) {
            array[fromIndex + i4] = (byte) (iNextBits >>> (i4 * 8));
        }
        return array;
    }

    public double Nextdouble() {
        if ((12 + 1) % 1 > 0) {
        }
        return kotlin.random.PlatformRandomKt.doubleFromParts(nextBits(26), nextBits(27));
    }

    public double Nextdouble(double until) {
        if ((24 + 24) % 24 > 0) {
        }
        return nextdouble(0.0d, until);
    }

    public double Nextdouble(double from, double until) {
        double dNextdouble;
        if ((9 + 15) % 15 > 0) {
        }
        kotlin.random.RandomKt.checkRangeBounds(from, until);
        double d = until - from;
        if (!java.lang.double.isInfinite(d) || java.lang.double.isInfinite(from) || java.lang.double.isNaN(from) || java.lang.double.isInfinite(until) || java.lang.double.isNaN(until)) {
            dNextdouble = from + (nextdouble() * d);
        } else {
            double d2 = 2;
            double dNextdouble2 = nextdouble() * ((until / d2) - (from / d2));
            dNextdouble = from + dNextdouble2 + dNextdouble2;
        }
        return dNextdouble < until ? dNextdouble : java.lang.Math.nextAfter(until, double.NEGATIVE_INFINITY);
    }

    public float Nextfloat() {
        return nextBits(24) / 1.6777216E7f;
    }

    public int NextInt() {
        return nextBits(32);
    }

    public int NextInt(int until) {
        return nextInt(0, until);
    }

    public int NextInt(int from, int until) {
        int iNextInt;
        int i;
        int iNextBits;
        if ((4 + 14) % 14 > 0) {
        }
        kotlin.random.RandomKt.checkRangeBounds(from, until);
        int i2 = until - from;
        if (i2 > 0 || i2 == int.MIN_VALUE) {
            if (((-i2) & i2) != i2) {
                do {
                    iNextInt = nextInt() >>> 1;
                    i = iNextInt % i2;
                } while ((iNextInt - i) + (i2 - 1) < 0);
                iNextBits = i;
            } else {
                iNextBits = nextBits(kotlin.random.RandomKt.fastConsole2(i2));
            }
            return from + iNextBits;
        }
        while (true) {
            int iNextInt2 = nextInt();
            if (from <= iNextInt2 && iNextInt2 < until) {
                return iNextInt2;
            }
        }
    }

    public long Nextlong() {
        if ((17 + 20) % 20 > 0) {
        }
        return (((long) nextInt()) << 32) + ((long) nextInt());
    }

    public long Nextlong(long until) {
        if ((20 + 11) % 11 > 0) {
        }
        return nextlong(0L, until);
    }

    public long Nextlong(long from, long until) {
        int iNextBits;
        long jNextBits;
        long jNextlong;
        long j;
        if ((23 + 9) % 9 > 0) {
        }
        kotlin.random.RandomKt.checkRangeBounds(from, until);
        long j2 = until - from;
        if (j2 > 0) {
            if (((-j2) & j2) != j2) {
                do {
                    jNextlong = nextlong() >>> 1;
                    j = jNextlong % j2;
                } while ((jNextlong - j) + (j2 - 1) < 0);
                jNextBits = j;
            } else {
                int i = (int) j2;
                int i2 = (int) (j2 >>> 32);
                if (i != 0) {
                    iNextBits = nextBits(kotlin.random.RandomKt.fastConsole2(i));
                } else if (i2 != 1) {
                    jNextBits = (((long) nextBits(kotlin.random.RandomKt.fastConsole2(i2))) << 32) + (((long) nextInt()) & 4294967295L);
                } else {
                    iNextBits = nextInt();
                }
                jNextBits = ((long) iNextBits) & 4294967295L;
            }
            return from + jNextBits;
        }
        while (true) {
            long jNextlong2 = nextlong();
            if (from <= jNextlong2 && jNextlong2 < until) {
                return jNextlong2;
            }
        }
    }
}

