namespace WillowMaze.Wasm.Decompiled;

public abstract class Pf8238658
{
    private static System.Numerics.BigInteger F01f1e834;
    public static int F0c8f80b1;
    private static System.Numerics.BigInteger F0f82d86a;
    private static System.Numerics.BigInteger F413af0de;
    public static int F80d4c42b;
    private static System.Numerics.BigInteger F819d7fbd;
    private static System.Numerics.BigInteger F9e38e550;
    public static int F9e93e9cc;
    private static System.Numerics.BigInteger Fb5905e8f;
    private static System.Numerics.BigInteger Fbc21e648;
    private static System.Numerics.BigInteger Fe51abcbb;
    public static int Fe7f16f49;
    private static System.Numerics.BigInteger Ffcfa5424;
    private static System.Numerics.BigInteger Ffdf0ab10;

    private static pf8238658$p05a21517 M07f0d24a(pe5cfc515 P0, int P1, byte[] P2)
    {
        // str: "Too many iterations in Shawe-Taylor Random_Prime Routine"
        // call: pf8238658$p05a21517.<init>
        // call: System.Numerics.BigInteger.add
        // call: System.Numerics.BigInteger.shiftLeft
        // call: pf8238658$p05a21517.getPrimeSeed
        // call: pf8238658.m81e4a099
        // call: pf8238658.m2e7b2165
        // call: IllegalStateException.<init>
        // call: System.Numerics.BigInteger.equals
        // call: System.Numerics.BigInteger.valueOf
        // call: System.Numerics.BigInteger.subtract
        // call: pf8238658.m0800fc57
        // call: pf8238658.md662a44d
        // call: System.Numerics.BigInteger.modPow
        // call: System.Numerics.BigInteger.gcd
        // call: pf8238658.mcf9f3fde
        // call: pf8238658.me41cd81e
        // call: System.Numerics.BigInteger.bitLength
        // call: pf8238658$p05a21517.getPrime
        // call: System.Numerics.BigInteger.divide
        // call: System.Numerics.BigInteger.multiply
        // field: p5a445d71.p9f931cf3.p7e676e9e.pf8238658.fbc21e648
        // field: p5a445d71.p9f931cf3.p7e676e9e.pf8238658.f413af0de
        // field: p5a445d71.p9f931cf3.p7e676e9e.pf8238658.f0f82d86a
        // type: pf8238658$p05a21517
        // type: IllegalStateException
        return default!;
    }

    private static void M0800fc57(pe5cfc515 P0, byte[] P1, byte[] P2, int P3)
    {
        // call: pe5cfc515.update
        // call: pe5cfc515.doFinal
    }

    public static pf8238658$p05a21517 M1ffd5a2c(pe5cfc515 P0, int P1, byte[] P2)
    {
        // str: "'length' must be >= 2"
        // str: "'hash' cannot be null"
        // str: "'inputSeed' cannot be null or empty"
        // call: IllegalArgumentException.<init>
        // call: pf8238658.m07f0d24a
        // call: pff43b8de.md329fd77
        // type: IllegalArgumentException
        return default!;
    }

    private static bool M2e7b2165(System.Numerics.BigInteger P0)
    {
        // call: System.Numerics.BigInteger.intValue
        // call: System.Numerics.BigInteger.valueOf
        // call: System.Numerics.BigInteger.mod
        return false;
    }

    public static bool M637bb7db(System.Numerics.BigInteger P0)
    {
        // str: "candidate"
        // call: pf8238658.mbd07c7b3
        // call: pf8238658.m2e7b2165
        return false;
    }

    public static bool M736b68e7(System.Numerics.BigInteger P0, System.Security.Cryptography.RandomNumberGenerator P1, int P2)
    {
        // str: "'random' cannot be null"
        // str: "candidate"
        // str: "'iterations' must be > 0"
        // call: IllegalArgumentException.<init>
        // call: System.Numerics.BigInteger.subtract
        // call: System.Numerics.BigInteger.getLowestSetBit
        // call: p68e35a3f.m812c2a1c
        // call: pf8238658.m7f022f31
        // call: pf8238658.mbd07c7b3
        // call: System.Numerics.BigInteger.bitLength
        // call: System.Numerics.BigInteger.shiftRight
        // call: System.Numerics.BigInteger.testBit
        // field: p5a445d71.p9f931cf3.p7e676e9e.pf8238658.f0f82d86a
        // field: p5a445d71.p9f931cf3.p7e676e9e.pf8238658.fbc21e648
        // type: IllegalArgumentException
        return false;
    }

    private static bool M7f022f31(System.Numerics.BigInteger P0, System.Numerics.BigInteger P1, System.Numerics.BigInteger P2, int P3, System.Numerics.BigInteger P4)
    {
        // call: System.Numerics.BigInteger.modPow
        // call: System.Numerics.BigInteger.equals
        // field: p5a445d71.p9f931cf3.p7e676e9e.pf8238658.f0f82d86a
        // field: p5a445d71.p9f931cf3.p7e676e9e.pf8238658.fbc21e648
        return false;
    }

    private static System.Numerics.BigInteger M81e4a099(pe5cfc515 P0, byte[] P1, int P2)
    {
        // call: System.Numerics.BigInteger.<init>
        // call: pf8238658.m0800fc57
        // call: pf8238658.mcf9f3fde
        // call: pe5cfc515.getDigestSize
        // type: System.Numerics.BigInteger
        return default!;
    }

    public static bool Ma7c60c35(System.Numerics.BigInteger P0, System.Numerics.BigInteger P1)
    {
        // str: "base"
        // str: "candidate"
        // str: "'base' must be < ('candidate' - 1)"
        // call: IllegalArgumentException.<init>
        // call: pf8238658.mbd07c7b3
        // call: System.Numerics.BigInteger.subtract
        // call: System.Numerics.BigInteger.compareTo
        // call: System.Numerics.BigInteger.shiftRight
        // call: pf8238658.m7f022f31
        // call: System.Numerics.BigInteger.getLowestSetBit
        // call: System.Numerics.BigInteger.bitLength
        // field: p5a445d71.p9f931cf3.p7e676e9e.pf8238658.fbc21e648
        // type: IllegalArgumentException
        return false;
    }

    public static pf8238658$p9677088a Mae60a2cb(System.Numerics.BigInteger P0, System.Security.Cryptography.RandomNumberGenerator P1, int P2)
    {
        // str: "candidate"
        // str: "'iterations' must be > 0"
        // str: "'random' cannot be null"
        // call: System.Numerics.BigInteger.modPow
        // call: pf8238658$p9677088a.mf23e8626
        // call: System.Numerics.BigInteger.compareTo
        // call: System.Numerics.BigInteger.getLowestSetBit
        // call: System.Numerics.BigInteger.equals
        // call: System.Numerics.BigInteger.shiftRight
        // call: pf8238658.mbd07c7b3
        // call: System.Numerics.BigInteger.testBit
        // call: System.Numerics.BigInteger.subtract
        // call: pf8238658$p9677088a.m337ceba5
        // call: System.Numerics.BigInteger.gcd
        // call: IllegalArgumentException.<init>
        // call: p68e35a3f.m812c2a1c
        // call: pf8238658$p9677088a.mf8f67da7
        // call: System.Numerics.BigInteger.bitLength
        // field: p5a445d71.p9f931cf3.p7e676e9e.pf8238658.fbc21e648
        // field: p5a445d71.p9f931cf3.p7e676e9e.pf8238658.f0f82d86a
        // type: IllegalArgumentException
        return default!;
    }

    private static void Mbd07c7b3(System.Numerics.BigInteger P0, string P1)
    {
        // str: "' must be non-null and >= 2"
        // str: "'"
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // call: System.Numerics.BigInteger.signum
        // call: System.Numerics.BigInteger.bitLength
        // call: IllegalArgumentException.<init>
        // call: StringBuilder.toString
        // type: IllegalArgumentException
        // type: StringBuilder
    }

    private static void Mcf9f3fde(byte[] P0, int P1)
    {
    }

    private static bool Md662a44d(long P0)
    {
        // str: "Size limit exceeded"
        // call: IllegalArgumentException.<init>
        // type: IllegalArgumentException
        return false;
    }

    private static int Me41cd81e(byte[] P0)
    {
        // call: Math.min
        return 0;
    }

}
