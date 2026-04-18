namespace WillowMaze.Wasm.Decompiled;


@com.google.common.math.ElementTypesAreNonnullByDefault
public class decimalMath {
    private decimalMath() {
    }

    public static double RoundTodouble(java.math.decimal bigDecimal, java.math.RoundingMode roundingMode) {
        return com.google.common.math.decimalMath$decimalTodoubleRounder.INSTANCE.roundTodouble(bigDecimal, roundingMode);
    }
}

