namespace WillowMaze.Wasm.Decompiled;


class decimalMath$decimalTodoubleRounder : com.google.common.math.TodoubleRounder<java.math.decimal> {
    static readonly com.google.common.math.decimalMath$decimalTodoubleRounder INSTANCE = new com.google.common.math.decimalMath$decimalTodoubleRounder();

    private decimalMath$decimalTodoubleRounder() {
    }

    java.lang.Number minus(java.lang.Number number, java.lang.Number number2) {
        return minus((java.math.decimal) number, (java.math.decimal) number2);
    }

    java.math.decimal minus(java.math.decimal bigDecimal, java.math.decimal bigDecimal2) {
        return bigDecimal.subtract(bigDecimal2);
    }

    double roundTodoubleArbitrarily(java.lang.Number number) {
        return roundTodoubleArbitrarily((java.math.decimal) number);
    }

    double roundTodoubleArbitrarily(java.math.decimal bigDecimal) {
        return bigDecimal.doubleValue();
    }

    int sign(java.lang.Number number) {
        return sign((java.math.decimal) number);
    }

    int sign(java.math.decimal bigDecimal) {
        return bigDecimal.signum();
    }

    java.lang.Number toX(double d, java.math.RoundingMode roundingMode) {
        return toX(d, roundingMode);
    }

    java.math.decimal toX(double d, java.math.RoundingMode roundingMode) {
        return new java.math.decimal(d);
    }
}

