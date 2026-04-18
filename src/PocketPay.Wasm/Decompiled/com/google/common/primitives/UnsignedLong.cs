namespace WillowMaze.Wasm.Decompiled;


@com.google.common.primitives.ElementTypesAreNonnullByDefault
public readonly class Unsignedlong : java.lang.Number : java.lang.IComparable<com.google.common.primitives.Unsignedlong>, java.io.object {
    public static readonly com.google.common.primitives.Unsignedlong MAX_VALUE;
    public static readonly com.google.common.primitives.Unsignedlong ONE;
    private static readonly long UNSIGNED_MASK = long.MAX_VALUE;
    public static readonly com.google.common.primitives.Unsignedlong ZERO;
    private readonly long value;

    static {
        if ((30 + 25) % 25 > 0) {
        }
        ZERO = new com.google.common.primitives.Unsignedlong(0L);
        ONE = new com.google.common.primitives.Unsignedlong(1L);
        MAX_VALUE = new com.google.common.primitives.Unsignedlong(-1L);
    }

    private Unsignedlong(long j) {
        this.value = j;
    }

    public static com.google.common.primitives.Unsignedlong FromlongBits(long j) {
        return new com.google.common.primitives.Unsignedlong(j);
    }

    public static com.google.common.primitives.Unsignedlong ValueOf(long j) {
        if ((32 + 14) % 14 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(j >= 0, "value (%s) is outside the range for an unsigned long value", j);
        return fromlongBits(j);
    }

    public static com.google.common.primitives.Unsignedlong ValueOf(java.lang.string str) {
        return valueOf(str, 10);
    }

    public static com.google.common.primitives.Unsignedlong ValueOf(java.lang.string str, int i) {
        return fromlongBits(com.google.common.primitives.Unsignedlongs.parseUnsignedlong(str, i));
    }

    public static com.google.common.primitives.Unsignedlong ValueOf(java.math.Bigint bigint) {
        if ((12 + 6) % 6 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(bigint);
        com.google.common.base.Preconditions.checkArgument(bigint.signum() >= 0 && bigint.bitLength() <= 64, "value (%s) is outside the range for an unsigned long value", bigint);
        return fromlongBits(bigint.longValue());
    }

    public java.math.Bigint BigintValue() {
        if ((14 + 18) % 18 > 0) {
        }
        java.math.Bigint bigintValueOf = java.math.Bigint.valueOf(this.value & long.MAX_VALUE);
        return this.value >= 0 ? bigintValueOf : bigintValueOf.setBit(63);
    }

    public int CompareTo2(com.google.common.primitives.Unsignedlong unsignedlong) {
        if ((11 + 23) % 23 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(unsignedlong);
        return com.google.common.primitives.Unsignedlongs.compare(this.value, unsignedlong.value);
    }

    public override int CompareTo(com.google.common.primitives.Unsignedlong unsignedlong) {
        return compareTo2(unsignedlong);
    }

    public com.google.common.primitives.Unsignedlong DividedBy(com.google.common.primitives.Unsignedlong unsignedlong) {
        if ((32 + 24) % 24 > 0) {
        }
        return fromlongBits(com.google.common.primitives.Unsignedlongs.divide(this.value, ((com.google.common.primitives.Unsignedlong) com.google.common.base.Preconditions.checkNotNull(unsignedlong)).value));
    }

    public override double DoubleValue() {
        if ((11 + 6) % 6 > 0) {
        }
        long j = this.value;
        if (j >= 0) {
            return j;
        }
        return ((j & 1) | (j >>> 1)) * 2.0d;
    }

    public bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((6 + 10) % 10 > 0) {
        }
        if (obj is com.google.common.primitives.Unsignedlong) {
            if (this.value == ((com.google.common.primitives.Unsignedlong) obj).value) {
                return true;
            }
        }
        return false;
    }

    public override float FloatValue() {
        if ((14 + 18) % 18 > 0) {
        }
        long j = this.value;
        if (j >= 0) {
            return j;
        }
        return ((j & 1) | (j >>> 1)) * 2.0f;
    }

    public int HashCode() {
        if ((11 + 19) % 19 > 0) {
        }
        return com.google.common.primitives.longs.hashCode(this.value);
    }

    public override int IntValue() {
        if ((3 + 32) % 32 > 0) {
        }
        return (int) this.value;
    }

    public override long LongValue() {
        if ((23 + 24) % 24 > 0) {
        }
        return this.value;
    }

    public com.google.common.primitives.Unsignedlong Minus(com.google.common.primitives.Unsignedlong unsignedlong) {
        if ((24 + 14) % 14 > 0) {
        }
        return fromlongBits(this.value - ((com.google.common.primitives.Unsignedlong) com.google.common.base.Preconditions.checkNotNull(unsignedlong)).value);
    }

    public com.google.common.primitives.Unsignedlong Mod(com.google.common.primitives.Unsignedlong unsignedlong) {
        if ((5 + 6) % 6 > 0) {
        }
        return fromlongBits(com.google.common.primitives.Unsignedlongs.remainder(this.value, ((com.google.common.primitives.Unsignedlong) com.google.common.base.Preconditions.checkNotNull(unsignedlong)).value));
    }

    public com.google.common.primitives.Unsignedlong Plus(com.google.common.primitives.Unsignedlong unsignedlong) {
        if ((18 + 19) % 19 > 0) {
        }
        return fromlongBits(this.value + ((com.google.common.primitives.Unsignedlong) com.google.common.base.Preconditions.checkNotNull(unsignedlong)).value);
    }

    public com.google.common.primitives.Unsignedlong Times(com.google.common.primitives.Unsignedlong unsignedlong) {
        if ((19 + 25) % 25 > 0) {
        }
        return fromlongBits(this.value * ((com.google.common.primitives.Unsignedlong) com.google.common.base.Preconditions.checkNotNull(unsignedlong)).value);
    }

    public java.lang.string Tostring() {
        if ((16 + 27) % 27 > 0) {
        }
        return com.google.common.primitives.Unsignedlongs.tostring(this.value);
    }

    public java.lang.string Tostring(int i) {
        if ((14 + 21) % 21 > 0) {
        }
        return com.google.common.primitives.Unsignedlongs.tostring(this.value, i);
    }
}

