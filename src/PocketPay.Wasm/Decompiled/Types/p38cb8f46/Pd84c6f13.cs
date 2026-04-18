namespace WillowMaze.Wasm.Decompiled;

public class Pd84c6f13 : P08d84bc6
{
    public readonly p1eb558b5 F14134213;
    public readonly p7e62bc34 F28b0065c;
    public bool F349e6863;
    public readonly p1eb558b5 F39cad268;
    public bool F8e7f03cc;
    public bool Fa7c94073;
    public bool Fc47fcff5;
    public readonly p7e62bc34 Fc4b7c368;
    public readonly p1eb558b5 Fcbd79faa;
    public readonly p7e62bc34 Ff4547fa3;
    public readonly p1eb558b5 Ff6e04117;

    public static void M9cfc0ba6()
    {
    }

    public p7e62bc34 Buffer()
    {
        // field: p38cb8f46.pd84c6f13.ff4547fa3
        return default!;
    }

    public void Close()
    {
        // call: p7e62bc34.size
        // call: p1eb558b5.write
        // call: p1eb558b5.close
        // field: p38cb8f46.pd84c6f13.ff4547fa3
        // field: p38cb8f46.pd84c6f13.ff6e04117
        // field: p38cb8f46.pd84c6f13.f349e6863
    }

    public p08d84bc6 Emit()
    {
        // str: "closed"
        // call: IllegalStateException.<init>
        // call: p1eb558b5.write
        // call: object.toString
        // call: p7e62bc34.size
        // field: p38cb8f46.pd84c6f13.f349e6863
        // field: p38cb8f46.pd84c6f13.ff4547fa3
        // field: p38cb8f46.pd84c6f13.ff6e04117
        // type: IllegalStateException
        return default!;
    }

    public p08d84bc6 EmitCompleteSegments()
    {
        // str: "closed"
        // call: object.toString
        // call: p7e62bc34.completeSegmentByteCount
        // call: p1eb558b5.write
        // call: IllegalStateException.<init>
        // field: p38cb8f46.pd84c6f13.ff4547fa3
        // field: p38cb8f46.pd84c6f13.f349e6863
        // field: p38cb8f46.pd84c6f13.ff6e04117
        // type: IllegalStateException
        return default!;
    }

    public void Flush()
    {
        // str: "closed"
        // call: p1eb558b5.flush
        // call: p1eb558b5.write
        // call: object.toString
        // call: IllegalStateException.<init>
        // call: p7e62bc34.size
        // field: p38cb8f46.pd84c6f13.ff4547fa3
        // field: p38cb8f46.pd84c6f13.f349e6863
        // field: p38cb8f46.pd84c6f13.ff6e04117
        // type: IllegalStateException
    }

    public p7e62bc34 GetBuffer()
    {
        // field: p38cb8f46.pd84c6f13.ff4547fa3
        return default!;
    }

    public bool IsOpen()
    {
        // field: p38cb8f46.pd84c6f13.f349e6863
        return false;
    }

    public Stream OutputStream()
    {
        // call: pd84c6f13$pbe2deec2$1.<init>
        // type: pd84c6f13$pbe2deec2$1
        return default!;
    }

    public pc85a251c Timeout()
    {
        // call: p1eb558b5.timeout
        // field: p38cb8f46.pd84c6f13.ff6e04117
        return default!;
    }

    public string ToString()
    {
        // str: "buffer("
        // call: StringBuilder.toString
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // field: p38cb8f46.pd84c6f13.ff6e04117
        // type: StringBuilder
        return string.Empty;
    }

    public int Write(byte[] P0)
    {
        // str: "source"
        // str: "closed"
        // call: object.toString
        // call: Intrinsics.checkNotNullParameter
        // call: pd84c6f13.emitCompleteSegments
        // call: p7e62bc34.write
        // call: IllegalStateException.<init>
        // field: p38cb8f46.pd84c6f13.f349e6863
        // field: p38cb8f46.pd84c6f13.ff4547fa3
        // type: IllegalStateException
        return 0;
    }

    public p08d84bc6 Write(p58efa9e8 P0)
    {
        // str: "byteString"
        // str: "closed"
        // call: Intrinsics.checkNotNullParameter
        // call: object.toString
        // call: IllegalStateException.<init>
        // call: pd84c6f13.emitCompleteSegments
        // call: p7e62bc34.write
        // field: p38cb8f46.pd84c6f13.f349e6863
        // field: p38cb8f46.pd84c6f13.ff4547fa3
        // type: IllegalStateException
        return default!;
    }

    public p08d84bc6 Write(p58efa9e8 P0, int P1, int P2)
    {
        // str: "closed"
        // str: "byteString"
        // call: object.toString
        // call: pd84c6f13.emitCompleteSegments
        // call: p7e62bc34.write
        // call: Intrinsics.checkNotNullParameter
        // call: IllegalStateException.<init>
        // field: p38cb8f46.pd84c6f13.f349e6863
        // field: p38cb8f46.pd84c6f13.ff4547fa3
        // type: IllegalStateException
        return default!;
    }

    public p08d84bc6 Write(pf31bbdd1 P0, long P1)
    {
        // str: "source"
        // call: EOFException.<init>
        // call: Intrinsics.checkNotNullParameter
        // call: pf31bbdd1.read
        // call: pd84c6f13.emitCompleteSegments
        // field: p38cb8f46.pd84c6f13.ff4547fa3
        // type: EOFException
        return default!;
    }

    public p08d84bc6 Write(byte[] P0)
    {
        // str: "closed"
        // str: "source"
        // call: p7e62bc34.write
        // call: object.toString
        // call: Intrinsics.checkNotNullParameter
        // call: pd84c6f13.emitCompleteSegments
        // call: IllegalStateException.<init>
        // field: p38cb8f46.pd84c6f13.f349e6863
        // field: p38cb8f46.pd84c6f13.ff4547fa3
        // type: IllegalStateException
        return default!;
    }

    public p08d84bc6 Write(byte[] P0, int P1, int P2)
    {
        // str: "closed"
        // str: "source"
        // call: Intrinsics.checkNotNullParameter
        // call: p7e62bc34.write
        // call: object.toString
        // call: IllegalStateException.<init>
        // call: pd84c6f13.emitCompleteSegments
        // field: p38cb8f46.pd84c6f13.f349e6863
        // field: p38cb8f46.pd84c6f13.ff4547fa3
        // type: IllegalStateException
        return default!;
    }

    public void Write(p7e62bc34 P0, long P1)
    {
        // str: "source"
        // str: "closed"
        // call: pd84c6f13.emitCompleteSegments
        // call: Intrinsics.checkNotNullParameter
        // call: IllegalStateException.<init>
        // call: object.toString
        // call: p7e62bc34.write
        // field: p38cb8f46.pd84c6f13.f349e6863
        // field: p38cb8f46.pd84c6f13.ff4547fa3
        // type: IllegalStateException
    }

    public long WriteAll(pf31bbdd1 P0)
    {
        // str: "source"
        // call: Intrinsics.checkNotNullParameter
        // call: pd84c6f13.emitCompleteSegments
        // call: pf31bbdd1.read
        // field: p38cb8f46.pd84c6f13.ff4547fa3
        return 0;
    }

    public p08d84bc6 WriteByte(int P0)
    {
        // str: "closed"
        // call: pd84c6f13.emitCompleteSegments
        // call: p7e62bc34.writeByte
        // call: IllegalStateException.<init>
        // call: object.toString
        // field: p38cb8f46.pd84c6f13.ff4547fa3
        // field: p38cb8f46.pd84c6f13.f349e6863
        // type: IllegalStateException
        return default!;
    }

    public p08d84bc6 WriteDecimalLong(long P0)
    {
        // str: "closed"
        // call: IllegalStateException.<init>
        // call: pd84c6f13.emitCompleteSegments
        // call: p7e62bc34.writeDecimalLong
        // call: object.toString
        // field: p38cb8f46.pd84c6f13.ff4547fa3
        // field: p38cb8f46.pd84c6f13.f349e6863
        // type: IllegalStateException
        return default!;
    }

    public p08d84bc6 WriteHexadecimalUnsignedLong(long P0)
    {
        // str: "closed"
        // call: pd84c6f13.emitCompleteSegments
        // call: IllegalStateException.<init>
        // call: p7e62bc34.writeHexadecimalUnsignedLong
        // call: object.toString
        // field: p38cb8f46.pd84c6f13.ff4547fa3
        // field: p38cb8f46.pd84c6f13.f349e6863
        // type: IllegalStateException
        return default!;
    }

    public p08d84bc6 WriteInt(int P0)
    {
        // str: "closed"
        // call: object.toString
        // call: pd84c6f13.emitCompleteSegments
        // call: p7e62bc34.writeInt
        // call: IllegalStateException.<init>
        // field: p38cb8f46.pd84c6f13.f349e6863
        // field: p38cb8f46.pd84c6f13.ff4547fa3
        // type: IllegalStateException
        return default!;
    }

    public p08d84bc6 WriteIntLe(int P0)
    {
        // str: "closed"
        // call: pd84c6f13.emitCompleteSegments
        // call: p7e62bc34.writeIntLe
        // call: object.toString
        // call: IllegalStateException.<init>
        // field: p38cb8f46.pd84c6f13.ff4547fa3
        // field: p38cb8f46.pd84c6f13.f349e6863
        // type: IllegalStateException
        return default!;
    }

    public p08d84bc6 WriteLong(long P0)
    {
        // str: "closed"
        // call: IllegalStateException.<init>
        // call: p7e62bc34.writeLong
        // call: object.toString
        // call: pd84c6f13.emitCompleteSegments
        // field: p38cb8f46.pd84c6f13.f349e6863
        // field: p38cb8f46.pd84c6f13.ff4547fa3
        // type: IllegalStateException
        return default!;
    }

    public p08d84bc6 WriteLongLe(long P0)
    {
        // str: "closed"
        // call: p7e62bc34.writeLongLe
        // call: pd84c6f13.emitCompleteSegments
        // call: IllegalStateException.<init>
        // call: object.toString
        // field: p38cb8f46.pd84c6f13.f349e6863
        // field: p38cb8f46.pd84c6f13.ff4547fa3
        // type: IllegalStateException
        return default!;
    }

    public p08d84bc6 WriteShort(int P0)
    {
        // str: "closed"
        // call: object.toString
        // call: p7e62bc34.writeShort
        // call: pd84c6f13.emitCompleteSegments
        // call: IllegalStateException.<init>
        // field: p38cb8f46.pd84c6f13.ff4547fa3
        // field: p38cb8f46.pd84c6f13.f349e6863
        // type: IllegalStateException
        return default!;
    }

    public p08d84bc6 WriteShortLe(int P0)
    {
        // str: "closed"
        // call: object.toString
        // call: p7e62bc34.writeShortLe
        // call: IllegalStateException.<init>
        // call: pd84c6f13.emitCompleteSegments
        // field: p38cb8f46.pd84c6f13.ff4547fa3
        // field: p38cb8f46.pd84c6f13.f349e6863
        // type: IllegalStateException
        return default!;
    }

    public p08d84bc6 WriteString(string P0, int P1, int P2, System.Text.Encoding P3)
    {
        // str: "string"
        // str: "charset"
        // str: "closed"
        // call: p7e62bc34.writeString
        // call: object.toString
        // call: Intrinsics.checkNotNullParameter
        // call: pd84c6f13.emitCompleteSegments
        // call: IllegalStateException.<init>
        // field: p38cb8f46.pd84c6f13.f349e6863
        // field: p38cb8f46.pd84c6f13.ff4547fa3
        // type: IllegalStateException
        return default!;
    }

    public p08d84bc6 WriteString(string P0, System.Text.Encoding P1)
    {
        // str: "charset"
        // str: "closed"
        // str: "string"
        // call: IllegalStateException.<init>
        // call: object.toString
        // call: Intrinsics.checkNotNullParameter
        // call: p7e62bc34.writeString
        // call: pd84c6f13.emitCompleteSegments
        // field: p38cb8f46.pd84c6f13.f349e6863
        // field: p38cb8f46.pd84c6f13.ff4547fa3
        // type: IllegalStateException
        return default!;
    }

    public p08d84bc6 WriteUtf8(string P0)
    {
        // str: "closed"
        // str: "string"
        // call: object.toString
        // call: Intrinsics.checkNotNullParameter
        // call: IllegalStateException.<init>
        // call: p7e62bc34.writeUtf8
        // call: pd84c6f13.emitCompleteSegments
        // field: p38cb8f46.pd84c6f13.f349e6863
        // field: p38cb8f46.pd84c6f13.ff4547fa3
        // type: IllegalStateException
        return default!;
    }

    public p08d84bc6 WriteUtf8(string P0, int P1, int P2)
    {
        // str: "closed"
        // str: "string"
        // call: Intrinsics.checkNotNullParameter
        // call: p7e62bc34.writeUtf8
        // call: pd84c6f13.emitCompleteSegments
        // call: IllegalStateException.<init>
        // call: object.toString
        // field: p38cb8f46.pd84c6f13.ff4547fa3
        // field: p38cb8f46.pd84c6f13.f349e6863
        // type: IllegalStateException
        return default!;
    }

    public p08d84bc6 WriteUtf8CodePoint(int P0)
    {
        // str: "closed"
        // call: object.toString
        // call: IllegalStateException.<init>
        // call: pd84c6f13.emitCompleteSegments
        // call: p7e62bc34.writeUtf8CodePoint
        // field: p38cb8f46.pd84c6f13.ff4547fa3
        // field: p38cb8f46.pd84c6f13.f349e6863
        // type: IllegalStateException
        return default!;
    }

}
