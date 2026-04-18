namespace WillowMaze.Wasm.Decompiled;

public class P800cd1ed
{
    public static void M0d724359(p16c6c42e P0, long P1)
    {
        // str: "<this>"
        // str: "closed"
        // call: IllegalStateException.<init>
        // call: Math.min
        // call: p7e62bc34.size
        // call: object.toString
        // call: p7e62bc34.skip
        // call: Intrinsics.checkNotNullParameter
        // call: pf31bbdd1.read
        // call: EOFException.<init>
        // field: p38cb8f46.p16c6c42e.ff4547fa3
        // field: p38cb8f46.p16c6c42e.f36cd38f4
        // field: p38cb8f46.p16c6c42e.f349e6863
        // type: EOFException
        // type: IllegalStateException
    }

    public static void M258564c5(p16c6c42e P0, p7e62bc34 P1, long P2)
    {
        // str: "sink"
        // str: "<this>"
        // call: Intrinsics.checkNotNullParameter
        // call: p7e62bc34.readFully
        // call: p7e62bc34.writeAll
        // call: p16c6c42e.require
        // field: p38cb8f46.p16c6c42e.ff4547fa3
    }

    public static void M258564c5(p16c6c42e P0, byte[] P1)
    {
        // str: "<this>"
        // str: "sink"
        // call: p7e62bc34.size
        // call: p7e62bc34.read
        // call: Intrinsics.checkNotNullParameter
        // call: p7e62bc34.readFully
        // call: p16c6c42e.require
        // call: AssertionError.<init>
        // field: p38cb8f46.p16c6c42e.ff4547fa3
        // type: AssertionError
    }

    public static string M31d84cf8(p16c6c42e P0, long P1)
    {
        // str: "limit < 0: "
        // str: "<this>"
        // str: " content="
        // str: "\\n not found: limit="
        // call: object.toString
        // call: p9004bb92.m65ee59af
        // call: p7e62bc34.getByte
        // call: StringBuilder.toString
        // call: StringBuilder.append
        // call: p7e62bc34.<init>
        // call: Intrinsics.checkNotNullParameter
        // call: StringBuilder.<init>
        // call: p16c6c42e.indexOf
        // call: p58efa9e8.hex
        // call: p16c6c42e.request
        // call: EOFException.<init>
        // call: Math.min
        // call: IllegalArgumentException.<init>
        // call: p7e62bc34.copyTo
        // call: p7e62bc34.size
        // call: p7e62bc34.readByteString
        // field: p38cb8f46.p16c6c42e.ff4547fa3
        // type: EOFException
        // type: IllegalArgumentException
        // type: StringBuilder
        // type: p7e62bc34
        return string.Empty;
    }

    public static string M3e2b7c6f(p16c6c42e P0)
    {
        // str: "<this>"
        // call: p7e62bc34.size
        // call: p9004bb92.m65ee59af
        // call: p16c6c42e.indexOf
        // call: p16c6c42e.readUtf8
        // call: Intrinsics.checkNotNullParameter
        // field: p38cb8f46.p16c6c42e.ff4547fa3
        return string.Empty;
    }

    public static bool M4019455f(p16c6c42e P0)
    {
        // str: "<this>"
        // str: "closed"
        // call: pf31bbdd1.read
        // call: Intrinsics.checkNotNullParameter
        // call: object.toString
        // call: IllegalStateException.<init>
        // call: p7e62bc34.exhausted
        // field: p38cb8f46.p16c6c42e.ff4547fa3
        // field: p38cb8f46.p16c6c42e.f36cd38f4
        // field: p38cb8f46.p16c6c42e.f349e6863
        // type: IllegalStateException
        return false;
    }

    public static int M41ba9d56(p16c6c42e P0, pdae8ace1 P1)
    {
        // str: "<this>"
        // str: "closed"
        // str: "options"
        // call: object.toString
        // call: Intrinsics.checkNotNullParameter
        // call: IllegalStateException.<init>
        // call: p7e62bc34.skip
        // call: p58efa9e8.size
        // call: pf31bbdd1.read
        // call: p9004bb92.mcffce896
        // call: pdae8ace1.getByteStrings$okio
        // field: p38cb8f46.p16c6c42e.ff4547fa3
        // field: p38cb8f46.p16c6c42e.f349e6863
        // field: p38cb8f46.p16c6c42e.f36cd38f4
        // type: IllegalStateException
        return 0;
    }

    public static short M48b541a6(p16c6c42e P0)
    {
        // str: "<this>"
        // call: Intrinsics.checkNotNullParameter
        // call: p7e62bc34.readShortLe
        // call: p16c6c42e.require
        // field: p38cb8f46.p16c6c42e.ff4547fa3
        return 0;
    }

    public static long M5c576a97(p16c6c42e P0)
    {
        // str: "toString(this, checkRadix(radix))"
        // str: "Expected a digit or '-' but was 0x"
        // str: "<this>"
        // call: Intrinsics.checkNotNullExpressionValue
        // call: p16c6c42e.require
        // call: NumberFormatException.<init>
        // call: StringBuilder.toString
        // call: CharsKt.checkRadix
        // call: int.toString
        // call: Intrinsics.checkNotNullParameter
        // call: StringBuilder.append
        // call: p7e62bc34.readDecimalLong
        // call: p7e62bc34.getByte
        // call: StringBuilder.<init>
        // call: p16c6c42e.request
        // field: p38cb8f46.p16c6c42e.ff4547fa3
        // type: NumberFormatException
        // type: StringBuilder
        return 0;
    }

    public static void M5d519a1e(p16c6c42e P0)
    {
        // str: "<this>"
        // call: p7e62bc34.clear
        // call: Intrinsics.checkNotNullParameter
        // call: pf31bbdd1.close
        // field: p38cb8f46.p16c6c42e.f349e6863
        // field: p38cb8f46.p16c6c42e.ff4547fa3
        // field: p38cb8f46.p16c6c42e.f36cd38f4
    }

    public static int M60624612(p16c6c42e P0)
    {
        // str: "<this>"
        // call: Intrinsics.checkNotNullParameter
        // call: p16c6c42e.require
        // call: p7e62bc34.readIntLe
        // field: p38cb8f46.p16c6c42e.ff4547fa3
        return 0;
    }

    public static byte[] M6332a204(p16c6c42e P0)
    {
        // str: "<this>"
        // call: Intrinsics.checkNotNullParameter
        // call: p7e62bc34.readByteArray
        // call: p7e62bc34.writeAll
        // field: p38cb8f46.p16c6c42e.ff4547fa3
        // field: p38cb8f46.p16c6c42e.f36cd38f4
        return default!;
    }

    public static byte[] M6332a204(p16c6c42e P0, long P1)
    {
        // str: "<this>"
        // call: Intrinsics.checkNotNullParameter
        // call: p7e62bc34.readByteArray
        // call: p16c6c42e.require
        // field: p38cb8f46.p16c6c42e.ff4547fa3
        return default!;
    }

    public static long M644616c4(p16c6c42e P0)
    {
        // str: "<this>"
        // call: Intrinsics.checkNotNullParameter
        // call: p7e62bc34.readLong
        // call: p16c6c42e.require
        // field: p38cb8f46.p16c6c42e.ff4547fa3
        return 0;
    }

    public static p58efa9e8 M73e92b67(p16c6c42e P0)
    {
        // str: "<this>"
        // call: Intrinsics.checkNotNullParameter
        // call: p7e62bc34.readByteString
        // call: p7e62bc34.writeAll
        // field: p38cb8f46.p16c6c42e.ff4547fa3
        // field: p38cb8f46.p16c6c42e.f36cd38f4
        return default!;
    }

    public static p58efa9e8 M73e92b67(p16c6c42e P0, long P1)
    {
        // str: "<this>"
        // call: Intrinsics.checkNotNullParameter
        // call: p7e62bc34.readByteString
        // call: p16c6c42e.require
        // field: p38cb8f46.p16c6c42e.ff4547fa3
        return default!;
    }

    public static void M8001fd48(p16c6c42e P0, long P1)
    {
        // str: "<this>"
        // call: EOFException.<init>
        // call: p16c6c42e.request
        // call: Intrinsics.checkNotNullParameter
        // type: EOFException
    }

    public static short M8733548b(p16c6c42e P0)
    {
        // str: "<this>"
        // call: p7e62bc34.readShort
        // call: p16c6c42e.require
        // call: Intrinsics.checkNotNullParameter
        // field: p38cb8f46.p16c6c42e.ff4547fa3
        return 0;
    }

    public static int M927e8d50(p16c6c42e P0, byte[] P1, int P2, int P3)
    {
        // str: "<this>"
        // str: "sink"
        // call: Intrinsics.checkNotNullParameter
        // call: p7e62bc34.size
        // call: p7e62bc34.read
        // call: p2ff17a65.m799a7e61
        // call: pf31bbdd1.read
        // call: Math.min
        // field: p38cb8f46.p16c6c42e.ff4547fa3
        // field: p38cb8f46.p16c6c42e.f36cd38f4
        return 0;
    }

    public static long M927e8d50(p16c6c42e P0, p7e62bc34 P1, long P2)
    {
        // str: "byteCount < 0: "
        // str: "closed"
        // str: "<this>"
        // str: "sink"
        // call: Intrinsics.checkNotNullParameter
        // call: StringBuilder.append
        // call: p7e62bc34.size
        // call: IllegalArgumentException.<init>
        // call: pf31bbdd1.read
        // call: Math.min
        // call: StringBuilder.<init>
        // call: object.toString
        // call: p7e62bc34.read
        // call: IllegalStateException.<init>
        // call: StringBuilder.toString
        // field: p38cb8f46.p16c6c42e.ff4547fa3
        // field: p38cb8f46.p16c6c42e.f349e6863
        // field: p38cb8f46.p16c6c42e.f36cd38f4
        // type: StringBuilder
        // type: IllegalStateException
        // type: IllegalArgumentException
        return 0;
    }

    public static byte M9ec95aaa(p16c6c42e P0)
    {
        // str: "<this>"
        // call: p7e62bc34.readByte
        // call: p16c6c42e.require
        // call: Intrinsics.checkNotNullParameter
        // field: p38cb8f46.p16c6c42e.ff4547fa3
        return 0;
    }

    public static bool Ma58572d0(p16c6c42e P0, long P1)
    {
        // str: "closed"
        // str: "byteCount < 0: "
        // str: "<this>"
        // call: IllegalArgumentException.<init>
        // call: p7e62bc34.size
        // call: Intrinsics.checkNotNullParameter
        // call: pf31bbdd1.read
        // call: StringBuilder.append
        // call: object.toString
        // call: StringBuilder.<init>
        // call: IllegalStateException.<init>
        // call: StringBuilder.toString
        // field: p38cb8f46.p16c6c42e.ff4547fa3
        // field: p38cb8f46.p16c6c42e.f349e6863
        // field: p38cb8f46.p16c6c42e.f36cd38f4
        // type: IllegalArgumentException
        // type: StringBuilder
        // type: IllegalStateException
        return false;
    }

    public static long Ma6eb6cf0(p16c6c42e P0)
    {
        // str: "<this>"
        // call: Intrinsics.checkNotNullParameter
        // call: p16c6c42e.require
        // call: p7e62bc34.readLongLe
        // field: p38cb8f46.p16c6c42e.ff4547fa3
        return 0;
    }

    public static long Mac742f45(p16c6c42e P0, p1eb558b5 P1)
    {
        // str: "<this>"
        // str: "sink"
        // call: p7e62bc34.size
        // call: p1eb558b5.write
        // call: p7e62bc34.completeSegmentByteCount
        // call: Intrinsics.checkNotNullParameter
        // call: pf31bbdd1.read
        // field: p38cb8f46.p16c6c42e.ff4547fa3
        // field: p38cb8f46.p16c6c42e.f36cd38f4
        return 0;
    }

    public static pc85a251c Maf8344da(p16c6c42e P0)
    {
        // str: "<this>"
        // call: pf31bbdd1.timeout
        // call: Intrinsics.checkNotNullParameter
        // field: p38cb8f46.p16c6c42e.f36cd38f4
        return default!;
    }

    public static long Mb3a1415e(p16c6c42e P0, p58efa9e8 P1, long P2)
    {
        // str: "targetBytes"
        // str: "closed"
        // str: "<this>"
        // call: Intrinsics.checkNotNullParameter
        // call: pf31bbdd1.read
        // call: p7e62bc34.size
        // call: Math.max
        // call: p7e62bc34.indexOfElement
        // call: IllegalStateException.<init>
        // call: object.toString
        // field: p38cb8f46.p16c6c42e.ff4547fa3
        // field: p38cb8f46.p16c6c42e.f36cd38f4
        // field: p38cb8f46.p16c6c42e.f349e6863
        // type: IllegalStateException
        return 0;
    }

    public static pcc81e3f6 Mb5655012(p16c6c42e P0)
    {
        // str: "<this>"
        // call: p0af9afa4.m7f2db423
        // call: p8435dbaa.<init>
        // call: Intrinsics.checkNotNullParameter
        // type: p8435dbaa
        return default!;
    }

    public static long Mc4262d16(p16c6c42e P0, byte P1, long P2, long P3)
    {
        // str: "<this>"
        // str: "fromIndex="
        // str: "closed"
        // str: " toIndex="
        // call: StringBuilder.<init>
        // call: p7e62bc34.indexOf
        // call: object.toString
        // call: StringBuilder.append
        // call: IllegalStateException.<init>
        // call: IllegalArgumentException.<init>
        // call: StringBuilder.toString
        // call: p7e62bc34.size
        // call: Intrinsics.checkNotNullParameter
        // call: pf31bbdd1.read
        // call: Math.max
        // field: p38cb8f46.p16c6c42e.f349e6863
        // field: p38cb8f46.p16c6c42e.ff4547fa3
        // field: p38cb8f46.p16c6c42e.f36cd38f4
        // type: IllegalStateException
        // type: StringBuilder
        // type: IllegalArgumentException
        return 0;
    }

    public static long Mc4262d16(p16c6c42e P0, p58efa9e8 P1, long P2)
    {
        // str: "bytes"
        // str: "closed"
        // str: "<this>"
        // call: Intrinsics.checkNotNullParameter
        // call: p7e62bc34.indexOf
        // call: Math.max
        // call: pf31bbdd1.read
        // call: p7e62bc34.size
        // call: object.toString
        // call: IllegalStateException.<init>
        // call: p58efa9e8.size
        // field: p38cb8f46.p16c6c42e.ff4547fa3
        // field: p38cb8f46.p16c6c42e.f36cd38f4
        // field: p38cb8f46.p16c6c42e.f349e6863
        // type: IllegalStateException
        return 0;
    }

    public static string Mc984c9a4(p16c6c42e P0)
    {
        // str: "<this>"
        // call: p7e62bc34.writeAll
        // call: p7e62bc34.readUtf8
        // call: Intrinsics.checkNotNullParameter
        // field: p38cb8f46.p16c6c42e.f36cd38f4
        // field: p38cb8f46.p16c6c42e.ff4547fa3
        return string.Empty;
    }

    public static string Mc984c9a4(p16c6c42e P0, long P1)
    {
        // str: "<this>"
        // call: p16c6c42e.require
        // call: Intrinsics.checkNotNullParameter
        // call: p7e62bc34.readUtf8
        // field: p38cb8f46.p16c6c42e.ff4547fa3
        return string.Empty;
    }

    public static string Md84d09e5(p16c6c42e P0)
    {
        // str: "<this>"
        // str: "buffer("
        // call: Intrinsics.checkNotNullParameter
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // field: p38cb8f46.p16c6c42e.f36cd38f4
        // type: StringBuilder
        return string.Empty;
    }

    public static long Me1aa2fde(p16c6c42e P0)
    {
        // str: "<this>"
        // str: "Expected leading [0-9a-fA-F] character but was 0x"
        // str: "toString(this, checkRadix(radix))"
        // call: CharsKt.checkRadix
        // call: Intrinsics.checkNotNullParameter
        // call: p16c6c42e.request
        // call: p7e62bc34.getByte
        // call: NumberFormatException.<init>
        // call: p16c6c42e.require
        // call: int.toString
        // call: Intrinsics.checkNotNullExpressionValue
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // call: p7e62bc34.readHexadecimalUnsignedLong
        // call: StringBuilder.toString
        // field: p38cb8f46.p16c6c42e.ff4547fa3
        // type: NumberFormatException
        // type: StringBuilder
        return 0;
    }

    public static int Mf3fdaca4(p16c6c42e P0)
    {
        // str: "<this>"
        // call: Intrinsics.checkNotNullParameter
        // call: p16c6c42e.require
        // call: p7e62bc34.readInt
        // field: p38cb8f46.p16c6c42e.ff4547fa3
        return 0;
    }

    public static bool Mf83e0517(p16c6c42e P0, long P1, p58efa9e8 P2, int P3, int P4)
    {
        // str: "bytes"
        // str: "closed"
        // str: "<this>"
        // call: IllegalStateException.<init>
        // call: p7e62bc34.getByte
        // call: Intrinsics.checkNotNullParameter
        // call: p58efa9e8.getByte
        // call: p58efa9e8.size
        // call: object.toString
        // call: p16c6c42e.request
        // field: p38cb8f46.p16c6c42e.ff4547fa3
        // field: p38cb8f46.p16c6c42e.f349e6863
        // type: IllegalStateException
        return false;
    }

    public static int Mfc194ce8(p16c6c42e P0)
    {
        // str: "<this>"
        // call: p16c6c42e.require
        // call: p7e62bc34.getByte
        // call: p7e62bc34.readUtf8CodePoint
        // call: Intrinsics.checkNotNullParameter
        // field: p38cb8f46.p16c6c42e.ff4547fa3
        return 0;
    }

}
