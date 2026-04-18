namespace WillowMaze.Wasm.Decompiled;

public class P00313170 : Pf31bbdd1
{
    private readonly Inflater F0ae7f9d1;
    private readonly p16c6c42e F36cd38f4;
    private readonly Inflater F3c894fcd;
    private readonly Inflater F51d02382;
    private byte F58403745;
    private byte F73d5342e;
    private readonly CRC32 F74941c38;
    private readonly p8ac70daa F77ba5006;
    private readonly p8ac70daa F7b55c1dc;
    private readonly Inflater F8e10880a;
    private readonly p8ac70daa Fa4dae5f7;
    private byte Fa767c9b1;
    private readonly p16c6c42e Fddcbc064;
    private readonly CRC32 Ff5ad59c5;

    private void M36fdeca3()
    {
        // str: "FHCRC"
        // str: "ID1ID2"
        // call: EOFException.<init>
        // call: p00313170.mf25b14da
        // call: p16c6c42e.require
        // call: p7e62bc34.readShortLe
        // call: p00313170.m787d627a
        // call: p7e62bc34.getByte
        // call: p16c6c42e.indexOf
        // call: p16c6c42e.skip
        // call: CRC32.getValue
        // call: p16c6c42e.readShortLe
        // call: p16c6c42e.readShort
        // call: CRC32.reset
        // field: p38cb8f46.p00313170.f36cd38f4
        // field: p38cb8f46.p16c6c42e.ff4547fa3
        // field: p38cb8f46.p00313170.ff5ad59c5
        // type: EOFException
    }

    private void M787d627a(string P0, int P1, int P2)
    {
        // str: "format(this, *args)"
        // str: "%s: actual 0x%08x != expected 0x%08x"
        // call: Intrinsics.checkNotNullExpressionValue
        // call: string.format
        // call: int.valueOf
        // call: IOException.<init>
        // call: Arrays.copyOf
        // type: IOException
    }

    private void Maec5cd43()
    {
        // str: "ISIZE"
        // str: "CRC"
        // call: p16c6c42e.readIntLe
        // call: p00313170.m787d627a
        // call: Inflater.getBytesWritten
        // call: CRC32.getValue
        // field: p38cb8f46.p00313170.f0ae7f9d1
        // field: p38cb8f46.p00313170.f36cd38f4
        // field: p38cb8f46.p00313170.ff5ad59c5
    }

    private void Mf25b14da(p7e62bc34 P0, long P1, long P2)
    {
        // call: Intrinsics.checkNotNull
        // call: Math.min
        // call: CRC32.update
        // field: p38cb8f46.p4b77e2a9.f5e0bdcbd
        // field: p38cb8f46.p4b77e2a9.f8d777f38
        // field: p38cb8f46.p4b77e2a9.faa9f73ee
        // field: p38cb8f46.p00313170.ff5ad59c5
        // field: p38cb8f46.p4b77e2a9.fd0cab90d
        // field: p38cb8f46.p7e62bc34.f96e89a29
    }

    public void Close()
    {
        // call: p8ac70daa.close
        // field: p38cb8f46.p00313170.fa4dae5f7
    }

    public long Read(p7e62bc34 P0, long P1)
    {
        // str: "gzip finished without exhausting source"
        // str: "sink"
        // str: "byteCount < 0: "
        // call: StringBuilder.<init>
        // call: Intrinsics.checkNotNullParameter
        // call: p8ac70daa.read
        // call: p00313170.mf25b14da
        // call: p00313170.maec5cd43
        // call: p00313170.m36fdeca3
        // call: p16c6c42e.exhausted
        // call: StringBuilder.toString
        // call: StringBuilder.append
        // call: p7e62bc34.size
        // call: object.toString
        // call: IOException.<init>
        // call: IllegalArgumentException.<init>
        // field: p38cb8f46.p00313170.f73d5342e
        // field: p38cb8f46.p00313170.fa4dae5f7
        // field: p38cb8f46.p00313170.f36cd38f4
        // type: IOException
        // type: StringBuilder
        // type: IllegalArgumentException
        return 0;
    }

    public pc85a251c Timeout()
    {
        // call: p16c6c42e.timeout
        // field: p38cb8f46.p00313170.f36cd38f4
        return default!;
    }

}
