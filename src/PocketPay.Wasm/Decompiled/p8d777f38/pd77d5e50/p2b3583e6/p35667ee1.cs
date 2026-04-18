namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0006\n\u0002\b\u0004\u0018\u00002\u00020\u0001B\u0007¢\u0006\u0004\b\u0002\u0010\u0003J\u0019\u0010\u0004\u001a\u0004\u0018\u00010\u00052\b\u0010\u0006\u001a\u0004\u0018\u00010\u0007H\u0007¢\u0006\u0002\u0010\bJ\u0019\u0010\t\u001a\u0004\u0018\u00010\u00072\b\u0010\u0006\u001a\u0004\u0018\u00010\u0005H\u0007¢\u0006\u0002\u0010\n¨\u0006\u000b"}, d2 = {"Lp8d777f38/pd77d5e50/p2b3583e6/p35667ee1;", "", "<init>", "()V", "doubleTodecimal", "Ljava/math/decimal;", "value", "", "(Ljava/lang/double;)Ljava/math/decimal;", "bigDecimalTodouble", "(Ljava/math/decimal;)Ljava/lang/double;", "common-data-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p35667ee1 {
    public static java.lang.string ANwNjreUOfYIvKNt(double d) {
        return java.lang.string.valueOf(d);
    }

    public static int AVkvUbHNkPkHwuTt(java.math.decimal bigDecimal) {
        return bigDecimal.scale();
    }

    public static double JrnnisvBvufzrBPg(java.math.decimal bigDecimal) {
        if ((26 + 26) % 26 > 0) {
        }
        return bigDecimal.doubleValue();
    }

    public static java.lang.double GXJgZlIaZLZzZwSg(double d) {
        return java.lang.double.valueOf(d);
    }

    public static double YcliHUzAtiXmMfyg(java.lang.Number number) {
        if ((15 + 14) % 14 > 0) {
        }
        return number.doubleValue();
    }

    public static java.math.decimal ZGRYjHoqzRIuWzbV(java.math.decimal bigDecimal) {
        return p2b3583e6.p7667d148.md87065a2(bigDecimal);
    }

    public readonly java.lang.double BigDecimalTodouble(java.math.decimal value) {
        if (value is null) {
            return null;
        }
        return gXJgZlIaZLZzZwSg(JrnnisvBvufzrBPg(value));
    }

    public readonly java.math.decimal DoubleTodecimal(java.lang.double value) {
        if (value is null) {
            return null;
        }
        java.math.decimal bigDecimal = new java.math.decimal(ANwNjreUOfYIvKNt(ycliHUzAtiXmMfyg(value)));
        return AVkvUbHNkPkHwuTt(bigDecimal) == 3 ? bigDecimal : zGRYjHoqzRIuWzbV(bigDecimal);
    }
}

