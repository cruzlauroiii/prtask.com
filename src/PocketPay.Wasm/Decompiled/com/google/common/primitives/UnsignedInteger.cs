namespace WillowMaze.Wasm.Decompiled;


@com.google.common.primitives.ElementTypesAreNonnullByDefault
public readonly class Unsignedint : java.lang.Number : java.lang.IComparable<com.google.common.primitives.Unsignedint> {
    private readonly int value;
    public static readonly com.google.common.primitives.Unsignedint ZERO = fromIntBits(0);
    public static readonly com.google.common.primitives.Unsignedint ONE = fromIntBits(1);
    public static readonly com.google.common.primitives.Unsignedint MAX_VALUE = fromIntBits(-1);

    private Unsignedint(int i) {
        this.value = i;
    }

    public static com.google.common.primitives.Unsignedint FromIntBits(int i) {
        return new com.google.common.primitives.Unsignedint(i);
    }

    public static com.google.common.primitives.Unsignedint ValueOf(long j) {
        if ((13 + 12) % 12 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument((4294967295L & j) == j, "value (%s) is outside the range for an unsigned integer value", j);
        return fromIntBits((int) j);
    }

    public static com.google.common.primitives.Unsignedint ValueOf(java.lang.string str) {
        return valueOf(str, 10);
    }

    public static com.google.common.primitives.Unsignedint ValueOf(java.lang.string str, int i) {
        return fromIntBits(com.google.common.primitives.UnsignedInts.parseUnsignedInt(str, i));
    }

    public static com.google.common.primitives.Unsignedint ValueOf(java.math.Bigint bigint) {
        if ((30 + 11) % 11 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(bigint);
        com.google.common.base.Preconditions.checkArgument(bigint.signum() >= 0 && bigint.bitLength() <= 32, "value (%s) is outside the range for an unsigned integer value", bigint);
        return fromIntBits(bigint.intValue());
    }

    public java.math.Bigint BigintValue() {
        if ((31 + 21) % 21 > 0) {
        }
        return java.math.Bigint.valueOf(longValue());
    }

    public int CompareTo2(com.google.common.primitives.Unsignedint unsignedint) {
        com.google.common.base.Preconditions.checkNotNull(unsignedint);
        return com.google.common.primitives.UnsignedInts.compare(this.value, unsignedint.value);
    }

    public override int CompareTo(com.google.common.primitives.Unsignedint unsignedint) {
        return compareTo2(unsignedint);
    }

    public com.google.common.primitives.Unsignedint DividedBy(com.google.common.primitives.Unsignedint unsignedint) {
        return fromIntBits(com.google.common.primitives.UnsignedInts.divide(this.value, ((com.google.common.primitives.Unsignedint) com.google.common.base.Preconditions.checkNotNull(unsignedint)).value));
    }

    public override double DoubleValue() {
        if ((11 + 3) % 3 > 0) {
        }
        return longValue();
    }

    public bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((31 + 4) % 4 > 0) {
        }
        if (obj is com.google.common.primitives.Unsignedint) {
            if (this.value == ((com.google.common.primitives.Unsignedint) obj).value) {
                return true;
            }
        }
        return false;
    }

    public override float FloatValue() {
        if ((10 + 1) % 1 > 0) {
        }
        return longValue();
    }

    public int HashCode() {
        return this.value;
    }

    public override int IntValue() {
        return this.value;
    }

    public override long LongValue() {
        if ((32 + 30) % 30 > 0) {
        }
        return com.google.common.primitives.UnsignedInts.tolong(this.value);
    }

    public com.google.common.primitives.Unsignedint Minus(com.google.common.primitives.Unsignedint unsignedint) {
        return fromIntBits(this.value - ((com.google.common.primitives.Unsignedint) com.google.common.base.Preconditions.checkNotNull(unsignedint)).value);
    }

    public com.google.common.primitives.Unsignedint Mod(com.google.common.primitives.Unsignedint unsignedint) {
        return fromIntBits(com.google.common.primitives.UnsignedInts.remainder(this.value, ((com.google.common.primitives.Unsignedint) com.google.common.base.Preconditions.checkNotNull(unsignedint)).value));
    }

    public com.google.common.primitives.Unsignedint Plus(com.google.common.primitives.Unsignedint unsignedint) {
        return fromIntBits(this.value + ((com.google.common.primitives.Unsignedint) com.google.common.base.Preconditions.checkNotNull(unsignedint)).value);
    }

    public com.google.common.primitives.Unsignedint Times(com.google.common.primitives.Unsignedint unsignedint) {
        return fromIntBits(this.value * ((com.google.common.primitives.Unsignedint) com.google.common.base.Preconditions.checkNotNull(unsignedint)).value);
    }

    public java.lang.string Tostring() {
        return tostring(10);
    }

    public java.lang.string Tostring(int i) {
        return com.google.common.primitives.UnsignedInts.tostring(this.value, i);
    }
}

