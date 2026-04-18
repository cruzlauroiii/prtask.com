namespace WillowMaze.Wasm.Decompiled;


class BigintMath$BigintTodoubleRounder : com.google.common.math.TodoubleRounder<java.math.Bigint> {
    static readonly com.google.common.math.BigintMath$BigintTodoubleRounder INSTANCE = new com.google.common.math.BigintMath$BigintTodoubleRounder();

    private BigintMath$BigintTodoubleRounder() {
    }

    java.lang.Number minus(java.lang.Number number, java.lang.Number number2) {
        return minus((java.math.Bigint) number, (java.math.Bigint) number2);
    }

    java.math.Bigint minus(java.math.Bigint bigint, java.math.Bigint bigint2) {
        return bigint.subtract(bigint2);
    }

    double roundTodoubleArbitrarily(java.lang.Number number) {
        return roundTodoubleArbitrarily((java.math.Bigint) number);
    }

    double roundTodoubleArbitrarily(java.math.Bigint bigint) {
        return com.google.common.math.doubleUtils.bigTodouble(bigint);
    }

    int sign(java.lang.Number number) {
        return sign((java.math.Bigint) number);
    }

    int sign(java.math.Bigint bigint) {
        return bigint.signum();
    }

    java.lang.Number toX(double d, java.math.RoundingMode roundingMode) {
        return toX(d, roundingMode);
    }

    java.math.Bigint toX(double d, java.math.RoundingMode roundingMode) {
        return com.google.common.math.doubleMath.roundToBigint(d, roundingMode);
    }
}

