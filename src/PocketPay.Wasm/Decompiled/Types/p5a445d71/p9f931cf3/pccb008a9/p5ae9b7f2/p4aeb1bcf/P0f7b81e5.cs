namespace WillowMaze.Wasm.Decompiled;

public class P0f7b81e5
{
    public static bool M12409193(byte[][] P0)
    {
        return false;
    }

    public static byte[] M20260f59(byte[] P0)
    {
        // str: "in == null"
        // call: System.arraycopy
        // call: NullPointerException.<init>
        // type: NullPointerException
        return default!;
    }

    public static byte[][] M20260f59(byte[][] P0)
    {
        // str: "in has null pointers"
        // call: NullPointerException.<init>
        // call: p0f7b81e5.m12409193
        // call: System.arraycopy
        // type: NullPointerException
        return default!;
    }

    public static int M20d107d6(long P0, int P1)
    {
        return 0;
    }

    public static byte[] M235cdd01(object P0)
    {
        // call: ObjectOutputStream.flush
        // call: ObjectOutputStream.writeObject
        // call: MemoryStream.<init>
        // call: MemoryStream.toByteArray
        // call: ObjectOutputStream.<init>
        // type: ObjectOutputStream
        // type: MemoryStream
        return default!;
    }

    public static int M277ad7bf(pe5cfc515 P0)
    {
        // str: "digest == null"
        // str: "3249987fb27e5fe1cab3c98bd343941f09ba7da8a549b47f4a1fc0b0a39053b39c48732a"
        // str: "138057598e21f264f75f3951404ad936b065cc86e14b8e0158c2f876ea4ffa8edf6df8a0"
        // call: NullPointerException.<init>
        // call: DecryptString.decryptString
        // call: string.equals
        // call: pe5cfc515.getDigestSize
        // call: pe5cfc515.getAlgorithmName
        // type: NullPointerException
        return 0;
    }

    public static bool M2a3f81d2(byte[][] P0, byte[][] P1)
    {
        // str: "a or b == null"
        // call: p0f7b81e5.m12409193
        // call: NullPointerException.<init>
        // call: pff43b8de.m2a3f81d2
        // type: NullPointerException
        return false;
    }

    public static void M38b01934(long P0, byte[] P1, int P2)
    {
        // str: "not enough space in array"
        // str: "in == null"
        // call: NullPointerException.<init>
        // call: IllegalArgumentException.<init>
        // type: IllegalArgumentException
        // type: NullPointerException
    }

    public static int M7b1a5a4d(int P0)
    {
        return 0;
    }

    public static void M7d427729(byte[] P0, byte[] P1, int P2)
    {
        // str: "offset hast to be >= 0"
        // str: "src length + offset must not be greater than size of destination"
        // str: "dst == null"
        // str: "src == null"
        // call: IllegalArgumentException.<init>
        // call: NullPointerException.<init>
        // type: IllegalArgumentException
        // type: NullPointerException
    }

    public static object M95f98046(byte[] P0, Type P1)
    {
        // str: "unexpected class found in ObjectInputStream"
        // str: "unexpected data found at end of ObjectInputStream"
        // call: IOException.<init>
        // call: p0f7b81e5$p036ce53a.<init>
        // call: ObjectInputStream.available
        // call: MemoryStream.<init>
        // call: ObjectInputStream.readObject
        // call: Type.isInstance
        // type: IOException
        // type: p0f7b81e5$p036ce53a
        // type: MemoryStream
        return default!;
    }

    public static long M98ffcd8c(byte[] P0, int P1, int P2)
    {
        // str: "in == null"
        // call: NullPointerException.<init>
        // type: NullPointerException
        return 0;
    }

    public static bool Mb8f42873(long P0, int P1, int P2)
    {
        // call: Math.pow
        return false;
    }

    public static bool Mc177ebab(long P0, int P1, int P2)
    {
        // call: Math.pow
        return false;
    }

    public static void Mdd1c3fd2(byte[][] P0)
    {
        // str: "x has null pointers"
        // call: NullPointerException.<init>
        // call: p0f7b81e5.m12409193
        // call: p92640bd7.m81519f2a
        // call: TextWriter.println
        // field: java.lang.System.out
        // type: NullPointerException
    }

    public static long Me16d9a9a(long P0, int P1)
    {
        return 0;
    }

    public static bool Me5f78db1(int P0, long P1)
    {
        // str: "index must not be negative"
        // call: IllegalStateException.<init>
        // type: IllegalStateException
        return false;
    }

    public static byte[] Me6b9e09d(long P0, int P1)
    {
        return default!;
    }

    public static int Mf79ad9e6(int P0, int P1)
    {
        return 0;
    }

    public static byte[] Mf88bb2f2(byte[] P0, int P1, int P2)
    {
        // str: "length hast to be >= 0"
        // str: "offset hast to be >= 0"
        // str: "src == null"
        // str: "offset + length must not be greater then size of source array"
        // call: IllegalArgumentException.<init>
        // call: NullPointerException.<init>
        // type: IllegalArgumentException
        // type: NullPointerException
        return default!;
    }

}
