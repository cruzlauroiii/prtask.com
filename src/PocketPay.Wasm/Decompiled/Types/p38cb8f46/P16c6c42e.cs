namespace WillowMaze.Wasm.Decompiled;

public class P16c6c42e : Pcc81e3f6
{
    public bool F01b188e3;
    public readonly p7e62bc34 F29920b32;
    public bool F349e6863;
    public readonly pf31bbdd1 F36cd38f4;
    public readonly pf31bbdd1 F671be959;
    public bool F7b611b16;
    public bool Fd668c447;
    public readonly p7e62bc34 Fe8a9de48;
    public readonly p7e62bc34 Ff4547fa3;
    public readonly p7e62bc34 Ff7846607;

    public static void M9cfc0ba6()
    {
    }

    public p7e62bc34 Buffer()
    {
        // field: p38cb8f46.p16c6c42e.ff4547fa3
        return default!;
    }

    public void Close()
    {
        // call: p7e62bc34.clear
        // call: pf31bbdd1.close
        // field: p38cb8f46.p16c6c42e.f349e6863
        // field: p38cb8f46.p16c6c42e.f36cd38f4
        // field: p38cb8f46.p16c6c42e.ff4547fa3
    }

    public bool Exhausted()
    {
        // str: "closed"
        // call: object.toString
        // call: pf31bbdd1.read
        // call: IllegalStateException.<init>
        // call: p7e62bc34.exhausted
        // field: p38cb8f46.p16c6c42e.f36cd38f4
        // field: p38cb8f46.p16c6c42e.f349e6863
        // field: p38cb8f46.p16c6c42e.ff4547fa3
        // type: IllegalStateException
        return false;
    }

    public p7e62bc34 GetBuffer()
    {
        // field: p38cb8f46.p16c6c42e.ff4547fa3
        return default!;
    }

    public long IndexOf(byte P0)
    {
        // call: p16c6c42e.indexOf
        return 0;
    }

    public long IndexOf(byte P0, long P1)
    {
        // call: p16c6c42e.indexOf
        return 0;
    }

    public long IndexOf(byte P0, long P1, long P2)
    {
        // str: " toIndex="
        // str: "fromIndex="
        // str: "closed"
        // call: StringBuilder.toString
        // call: StringBuilder.append
        // call: pf31bbdd1.read
        // call: StringBuilder.<init>
        // call: IllegalArgumentException.<init>
        // call: IllegalStateException.<init>
        // call: object.toString
        // call: p7e62bc34.size
        // call: p7e62bc34.indexOf
        // call: Math.max
        // field: p38cb8f46.p16c6c42e.ff4547fa3
        // field: p38cb8f46.p16c6c42e.f36cd38f4
        // field: p38cb8f46.p16c6c42e.f349e6863
        // type: IllegalArgumentException
        // type: StringBuilder
        // type: IllegalStateException
        return 0;
    }

    public long IndexOf(p58efa9e8 P0)
    {
        // str: "bytes"
        // call: p16c6c42e.indexOf
        // call: Intrinsics.checkNotNullParameter
        return 0;
    }

    public long IndexOf(p58efa9e8 P0, long P1)
    {
        // str: "bytes"
        // str: "closed"
        // call: Intrinsics.checkNotNullParameter
        // call: Math.max
        // call: IllegalStateException.<init>
        // call: p58efa9e8.size
        // call: p7e62bc34.size
        // call: p7e62bc34.indexOf
        // call: object.toString
        // call: pf31bbdd1.read
        // field: p38cb8f46.p16c6c42e.f36cd38f4
        // field: p38cb8f46.p16c6c42e.ff4547fa3
        // field: p38cb8f46.p16c6c42e.f349e6863
        // type: IllegalStateException
        return 0;
    }

    public long IndexOfElement(p58efa9e8 P0)
    {
        // str: "targetBytes"
        // call: p16c6c42e.indexOfElement
        // call: Intrinsics.checkNotNullParameter
        return 0;
    }

    public long IndexOfElement(p58efa9e8 P0, long P1)
    {
        // str: "targetBytes"
        // str: "closed"
        // call: pf31bbdd1.read
        // call: Intrinsics.checkNotNullParameter
        // call: Math.max
        // call: p7e62bc34.size
        // call: object.toString
        // call: p7e62bc34.indexOfElement
        // call: IllegalStateException.<init>
        // field: p38cb8f46.p16c6c42e.f36cd38f4
        // field: p38cb8f46.p16c6c42e.ff4547fa3
        // field: p38cb8f46.p16c6c42e.f349e6863
        // type: IllegalStateException
        return 0;
    }

    public Stream InputStream()
    {
        // call: p16c6c42e$p267171e6$1.<init>
        // type: p16c6c42e$p267171e6$1
        return default!;
    }

    public bool IsOpen()
    {
        // field: p38cb8f46.p16c6c42e.f349e6863
        return false;
    }

    public pcc81e3f6 Peek()
    {
        // call: p8435dbaa.<init>
        // call: p0af9afa4.m7f2db423
        // type: p8435dbaa
        return default!;
    }

    public bool RangeEquals(long P0, p58efa9e8 P1)
    {
        // str: "bytes"
        // call: p16c6c42e.rangeEquals
        // call: Intrinsics.checkNotNullParameter
        // call: p58efa9e8.size
        return false;
    }

    public bool RangeEquals(long P0, p58efa9e8 P1, int P2, int P3)
    {
        // str: "bytes"
        // str: "closed"
        // call: p58efa9e8.size
        // call: p58efa9e8.getByte
        // call: IllegalStateException.<init>
        // call: object.toString
        // call: Intrinsics.checkNotNullParameter
        // call: p16c6c42e.request
        // call: p7e62bc34.getByte
        // field: p38cb8f46.p16c6c42e.f349e6863
        // field: p38cb8f46.p16c6c42e.ff4547fa3
        // type: IllegalStateException
        return false;
    }

    public int Read(byte[] P0)
    {
        // str: "sink"
        // call: p7e62bc34.read
        // call: pf31bbdd1.read
        // call: p7e62bc34.size
        // call: Intrinsics.checkNotNullParameter
        // field: p38cb8f46.p16c6c42e.ff4547fa3
        // field: p38cb8f46.p16c6c42e.f36cd38f4
        return 0;
    }

    public int Read(byte[] P0, int P1, int P2)
    {
        // str: "sink"
        // call: pf31bbdd1.read
        // call: Intrinsics.checkNotNullParameter
        // call: p7e62bc34.read
        // call: p2ff17a65.m799a7e61
        // call: Math.min
        // call: p7e62bc34.size
        // field: p38cb8f46.p16c6c42e.ff4547fa3
        // field: p38cb8f46.p16c6c42e.f36cd38f4
        return 0;
    }

    public long Read(p7e62bc34 P0, long P1)
    {
        // str: "byteCount < 0: "
        // str: "closed"
        // str: "sink"
        // call: p7e62bc34.size
        // call: StringBuilder.toString
        // call: Intrinsics.checkNotNullParameter
        // call: IllegalArgumentException.<init>
        // call: Math.min
        // call: StringBuilder.<init>
        // call: p7e62bc34.read
        // call: object.toString
        // call: StringBuilder.append
        // call: IllegalStateException.<init>
        // call: pf31bbdd1.read
        // field: p38cb8f46.p16c6c42e.ff4547fa3
        // field: p38cb8f46.p16c6c42e.f36cd38f4
        // field: p38cb8f46.p16c6c42e.f349e6863
        // type: IllegalStateException
        // type: IllegalArgumentException
        // type: StringBuilder
        return 0;
    }

    public long ReadAll(p1eb558b5 P0)
    {
        // str: "sink"
        // call: Intrinsics.checkNotNullParameter
        // call: pf31bbdd1.read
        // call: p7e62bc34.completeSegmentByteCount
        // call: p7e62bc34.size
        // call: p1eb558b5.write
        // field: p38cb8f46.p16c6c42e.ff4547fa3
        // field: p38cb8f46.p16c6c42e.f36cd38f4
        return 0;
    }

    public byte ReadByte()
    {
        // call: p7e62bc34.readByte
        // call: p16c6c42e.require
        // field: p38cb8f46.p16c6c42e.ff4547fa3
        return 0;
    }

    public byte[] ReadByteArray()
    {
        // call: p7e62bc34.writeAll
        // call: p7e62bc34.readByteArray
        // field: p38cb8f46.p16c6c42e.f36cd38f4
        // field: p38cb8f46.p16c6c42e.ff4547fa3
        return default!;
    }

    public byte[] ReadByteArray(long P0)
    {
        // call: p16c6c42e.require
        // call: p7e62bc34.readByteArray
        // field: p38cb8f46.p16c6c42e.ff4547fa3
        return default!;
    }

    public p58efa9e8 ReadByteString()
    {
        // call: p7e62bc34.readByteString
        // call: p7e62bc34.writeAll
        // field: p38cb8f46.p16c6c42e.f36cd38f4
        // field: p38cb8f46.p16c6c42e.ff4547fa3
        return default!;
    }

    public p58efa9e8 ReadByteString(long P0)
    {
        // call: p7e62bc34.readByteString
        // call: p16c6c42e.require
        // field: p38cb8f46.p16c6c42e.ff4547fa3
        return default!;
    }

    public long ReadDecimalLong()
    {
        // str: "toString(this, checkRadix(radix))"
        // str: "Expected a digit or '-' but was 0x"
        // call: p16c6c42e.request
        // call: p7e62bc34.getByte
        // call: p16c6c42e.require
        // call: StringBuilder.toString
        // call: Intrinsics.checkNotNullExpressionValue
        // call: int.toString
        // call: NumberFormatException.<init>
        // call: CharsKt.checkRadix
        // call: p7e62bc34.readDecimalLong
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // field: p38cb8f46.p16c6c42e.ff4547fa3
        // type: NumberFormatException
        // type: StringBuilder
        return 0;
    }

    public void ReadFully(p7e62bc34 P0, long P1)
    {
        // str: "sink"
        // call: p7e62bc34.writeAll
        // call: Intrinsics.checkNotNullParameter
        // call: p16c6c42e.require
        // call: p7e62bc34.readFully
        // field: p38cb8f46.p16c6c42e.ff4547fa3
    }

    public void ReadFully(byte[] P0)
    {
        // str: "sink"
        // call: AssertionError.<init>
        // call: p7e62bc34.read
        // call: Intrinsics.checkNotNullParameter
        // call: p16c6c42e.require
        // call: p7e62bc34.size
        // call: p7e62bc34.readFully
        // field: p38cb8f46.p16c6c42e.ff4547fa3
        // type: AssertionError
    }

    public long ReadHexadecimalUnsignedLong()
    {
        // str: "Expected leading [0-9a-fA-F] character but was 0x"
        // str: "toString(this, checkRadix(radix))"
        // call: Intrinsics.checkNotNullExpressionValue
        // call: p16c6c42e.request
        // call: StringBuilder.toString
        // call: StringBuilder.append
        // call: NumberFormatException.<init>
        // call: StringBuilder.<init>
        // call: p7e62bc34.getByte
        // call: p16c6c42e.require
        // call: int.toString
        // call: p7e62bc34.readHexadecimalUnsignedLong
        // call: CharsKt.checkRadix
        // field: p38cb8f46.p16c6c42e.ff4547fa3
        // type: StringBuilder
        // type: NumberFormatException
        return 0;
    }

    public int ReadInt()
    {
        // call: p16c6c42e.require
        // call: p7e62bc34.readInt
        // field: p38cb8f46.p16c6c42e.ff4547fa3
        return 0;
    }

    public int ReadIntLe()
    {
        // call: p16c6c42e.require
        // call: p7e62bc34.readIntLe
        // field: p38cb8f46.p16c6c42e.ff4547fa3
        return 0;
    }

    public long ReadLong()
    {
        // call: p16c6c42e.require
        // call: p7e62bc34.readLong
        // field: p38cb8f46.p16c6c42e.ff4547fa3
        return 0;
    }

    public long ReadLongLe()
    {
        // call: p16c6c42e.require
        // call: p7e62bc34.readLongLe
        // field: p38cb8f46.p16c6c42e.ff4547fa3
        return 0;
    }

    public short ReadShort()
    {
        // call: p7e62bc34.readShort
        // call: p16c6c42e.require
        // field: p38cb8f46.p16c6c42e.ff4547fa3
        return 0;
    }

    public short ReadShortLe()
    {
        // call: p7e62bc34.readShortLe
        // call: p16c6c42e.require
        // field: p38cb8f46.p16c6c42e.ff4547fa3
        return 0;
    }

    public string ReadString(long P0, System.Text.Encoding P1)
    {
        // str: "charset"
        // call: p7e62bc34.readString
        // call: Intrinsics.checkNotNullParameter
        // call: p16c6c42e.require
        // field: p38cb8f46.p16c6c42e.ff4547fa3
        return string.Empty;
    }

    public string ReadString(System.Text.Encoding P0)
    {
        // str: "charset"
        // call: p7e62bc34.writeAll
        // call: Intrinsics.checkNotNullParameter
        // call: p7e62bc34.readString
        // field: p38cb8f46.p16c6c42e.ff4547fa3
        // field: p38cb8f46.p16c6c42e.f36cd38f4
        return string.Empty;
    }

    public string ReadUtf8()
    {
        // call: p7e62bc34.writeAll
        // call: p7e62bc34.readUtf8
        // field: p38cb8f46.p16c6c42e.ff4547fa3
        // field: p38cb8f46.p16c6c42e.f36cd38f4
        return string.Empty;
    }

    public string ReadUtf8(long P0)
    {
        // call: p7e62bc34.readUtf8
        // call: p16c6c42e.require
        // field: p38cb8f46.p16c6c42e.ff4547fa3
        return string.Empty;
    }

    public int ReadUtf8CodePoint()
    {
        // call: p7e62bc34.getByte
        // call: p16c6c42e.require
        // call: p7e62bc34.readUtf8CodePoint
        // field: p38cb8f46.p16c6c42e.ff4547fa3
        return 0;
    }

    public string ReadUtf8Line()
    {
        // call: p16c6c42e.indexOf
        // call: p9004bb92.m65ee59af
        // call: p16c6c42e.readUtf8
        // call: p7e62bc34.size
        // field: p38cb8f46.p16c6c42e.ff4547fa3
        return string.Empty;
    }

    public string ReadUtf8LineStrict()
    {
        // call: p16c6c42e.readUtf8LineStrict
        return string.Empty;
    }

    public string ReadUtf8LineStrict(long P0)
    {
        // str: "\\n not found: limit="
        // str: " content="
        // str: "limit < 0: "
        // call: p7e62bc34.getByte
        // call: EOFException.<init>
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // call: p16c6c42e.request
        // call: p9004bb92.m65ee59af
        // call: IllegalArgumentException.<init>
        // call: object.toString
        // call: p16c6c42e.indexOf
        // call: p7e62bc34.<init>
        // call: p7e62bc34.copyTo
        // call: p7e62bc34.size
        // call: p7e62bc34.readByteString
        // call: StringBuilder.toString
        // call: Math.min
        // call: p58efa9e8.hex
        // field: p38cb8f46.p16c6c42e.ff4547fa3
        // type: EOFException
        // type: StringBuilder
        // type: IllegalArgumentException
        // type: p7e62bc34
        return string.Empty;
    }

    public bool Request(long P0)
    {
        // str: "closed"
        // str: "byteCount < 0: "
        // call: object.toString
        // call: IllegalStateException.<init>
        // call: IllegalArgumentException.<init>
        // call: pf31bbdd1.read
        // call: p7e62bc34.size
        // call: StringBuilder.toString
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // field: p38cb8f46.p16c6c42e.ff4547fa3
        // field: p38cb8f46.p16c6c42e.f349e6863
        // field: p38cb8f46.p16c6c42e.f36cd38f4
        // type: IllegalStateException
        // type: IllegalArgumentException
        // type: StringBuilder
        return false;
    }

    public void Require(long P0)
    {
        // call: p16c6c42e.request
        // call: EOFException.<init>
        // type: EOFException
    }

    public int Select(pdae8ace1 P0)
    {
        // str: "options"
        // str: "closed"
        // call: Intrinsics.checkNotNullParameter
        // call: p58efa9e8.size
        // call: p7e62bc34.skip
        // call: pdae8ace1.getByteStrings$okio
        // call: object.toString
        // call: p9004bb92.mcffce896
        // call: IllegalStateException.<init>
        // call: pf31bbdd1.read
        // field: p38cb8f46.p16c6c42e.ff4547fa3
        // field: p38cb8f46.p16c6c42e.f349e6863
        // field: p38cb8f46.p16c6c42e.f36cd38f4
        // type: IllegalStateException
        return 0;
    }

    public void Skip(long P0)
    {
        // str: "closed"
        // call: EOFException.<init>
        // call: object.toString
        // call: p7e62bc34.size
        // call: pf31bbdd1.read
        // call: IllegalStateException.<init>
        // call: Math.min
        // call: p7e62bc34.skip
        // field: p38cb8f46.p16c6c42e.f36cd38f4
        // field: p38cb8f46.p16c6c42e.ff4547fa3
        // field: p38cb8f46.p16c6c42e.f349e6863
        // type: EOFException
        // type: IllegalStateException
    }

    public pc85a251c Timeout()
    {
        // call: pf31bbdd1.timeout
        // field: p38cb8f46.p16c6c42e.f36cd38f4
        return default!;
    }

    public string ToString()
    {
        // str: "buffer("
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // field: p38cb8f46.p16c6c42e.f36cd38f4
        // type: StringBuilder
        return string.Empty;
    }

}
