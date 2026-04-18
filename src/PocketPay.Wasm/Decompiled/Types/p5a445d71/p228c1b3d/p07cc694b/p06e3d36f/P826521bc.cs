namespace WillowMaze.Wasm.Decompiled;

public class P826521bc
{
    public static long M3990405e(long P0, long P1)
    {
        // str: "Multiplication overflows a long: "
        // str: " / "
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // call: ArithmeticException.<init>
        // type: StringBuilder
        // type: ArithmeticException
        return 0;
    }

    public static long M3990405e(long P0, long P1, RoundingMode P2)
    {
        // str: "Multiplication overflows a long: "
        // str: " / "
        // call: decimal.<init>
        // call: ArithmeticException.<init>
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: decimal.divide
        // call: StringBuilder.<init>
        // call: decimal.longValue
        // type: ArithmeticException
        // type: decimal
        // type: StringBuilder
        return 0;
    }

    public static int M4c6aea78(int P0, int P1)
    {
        // str: " * "
        // str: "Multiplication overflows an int: "
        // call: StringBuilder.toString
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // call: ArithmeticException.<init>
        // type: ArithmeticException
        // type: StringBuilder
        return 0;
    }

    public static long M4c6aea78(long P0, int P1)
    {
        // str: " * "
        // str: "Multiplication overflows a long: "
        // call: StringBuilder.append
        // call: ArithmeticException.<init>
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // type: StringBuilder
        // type: ArithmeticException
        return 0;
    }

    public static long M4c6aea78(long P0, long P1)
    {
        // str: " * "
        // str: "Multiplication overflows a long: "
        // call: ArithmeticException.<init>
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // type: ArithmeticException
        // type: StringBuilder
        return 0;
    }

    public static bool M51c3f596(object P0, object P1)
    {
        // call: object.equals
        return false;
    }

    public static void M726edeba(string P0, int P1, int P2, int P3)
    {
        // call: int.valueOf
        // call: paea5f525.<init>
        // type: paea5f525
    }

    public static void M726edeba(p51c74e65 P0, int P1, int P2, int P3)
    {
        // call: int.valueOf
        // call: paea5f525.<init>
        // type: paea5f525
    }

    public static void M726edeba(p8b1ed2c5 P0, int P1, int P2, int P3)
    {
        // call: int.valueOf
        // call: p8b1ed2c5.getType
        // call: paea5f525.<init>
        // type: paea5f525
    }

    public static int M8519c227(int P0)
    {
        // str: "Integer.MIN_VALUE cannot be negated"
        // call: ArithmeticException.<init>
        // type: ArithmeticException
        return 0;
    }

    public static long Mbac1363c(long P0, long P1)
    {
        // str: " - "
        // str: "The calculation caused an overflow: "
        // call: ArithmeticException.<init>
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // type: StringBuilder
        // type: ArithmeticException
        return 0;
    }

    public static int Mbbc1f185(int P0, int P1)
    {
        // str: "The calculation caused an overflow: "
        // str: " + "
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // call: ArithmeticException.<init>
        // type: StringBuilder
        // type: ArithmeticException
        return 0;
    }

    public static long Mbbc1f185(long P0, long P1)
    {
        // str: "The calculation caused an overflow: "
        // str: " + "
        // call: ArithmeticException.<init>
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: StringBuilder.<init>
        // type: StringBuilder
        // type: ArithmeticException
        return 0;
    }

    public static int Mc044c34f(long P0)
    {
        // str: "Value cannot fit in an int: "
        // call: StringBuilder.toString
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // call: ArithmeticException.<init>
        // type: ArithmeticException
        // type: StringBuilder
        return 0;
    }

    public static int Med103849(long P0, long P1)
    {
        // call: p826521bc.mc044c34f
        // call: p826521bc.m4c6aea78
        return 0;
    }

    public static int Mf404ddad(int P0, int P1, int P2)
    {
        // str: "MIN > MAX"
        // call: IllegalArgumentException.<init>
        // type: IllegalArgumentException
        return 0;
    }

    public static int Mf404ddad(int P0, int P1, int P2, int P3)
    {
        // call: p826521bc.mf404ddad
        return 0;
    }

}
