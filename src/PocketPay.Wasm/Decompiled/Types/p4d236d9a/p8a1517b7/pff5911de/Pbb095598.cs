namespace WillowMaze.Wasm.Decompiled;

public class Pbb095598
{
    private static decimal F4f1c2e5c;
    private static decimal F54aeaa6b;
    private static System.Text.Encoding F58717a1b;
    private static decimal F6f28b236;
    private static int F847199ce;
    private static System.Text.Encoding Fd2cd8253;
    private static int Fda3de17a;
    private static System.Text.Encoding Fe7d6caba;
    private static int Ffa8bc932;
    private readonly pa4f4f3f0 F06403830;
    private readonly int F0e339957;
    private int F22c8dfbf;
    private readonly int F40fcdf19;
    private readonly int F5ac93477;
    private int F66206645;
    private readonly byte[] F7f672275;
    private readonly pa4f4f3f0 F825699a8;
    private int F9948807c;
    private int Fa0986998;
    private readonly byte[] Fa4fbe64f;
    private readonly pa4f4f3f0 Faf5c0bbb;
    private readonly pa4f4f3f0 Fb8847376;
    private int Fd334c0c3;
    private readonly byte[] Fe178e5c5;
    private int Ff7bb139f;

    private int M246c128a(int P0)
    {
        // str: "length ["
        // str: "] out of range (0x1000000)"
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: StringBuilder.<init>
        // call: IllegalStateException.<init>
        // type: IllegalStateException
        // type: StringBuilder
        return 0;
    }

    public static pbb095598 M66f6181b(pa4f4f3f0 P0)
    {
        // call: pbb095598.m66f6181b
        return default!;
    }

    public static pbb095598 M66f6181b(pa4f4f3f0 P0, int P1)
    {
        // call: pbb095598.<init>
        // type: pbb095598
        return default!;
    }

    private void Mc7f8b8ad(byte[] P0, int P1, int P2)
    {
        // str: "length ["
        // str: "] out of range (0x1000000)"
        // call: IllegalStateException.<init>
        // call: StringBuilder.toString
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // type: IllegalStateException
        // type: StringBuilder
    }

    public static pbb095598 Md98a07f8(p18e8d507 P0)
    {
        // call: pbb095598.md98a07f8
        return default!;
    }

    public static pbb095598 Md98a07f8(p18e8d507 P0, int P1)
    {
        // call: pbb095598.<init>
        // call: pbb095598.m66f6181b
        // call: p18e8d507.isConstructed
        // call: IEnumerator<object>.hasNext
        // call: List<object>.iterator
        // call: p18e8d507.getTag
        // call: pbb095598.addBerTlv
        // call: IEnumerator<object>.next
        // field: p4d236d9a.p8a1517b7.pff5911de.p18e8d507.fe4302f49
        // type: pbb095598
        return default!;
    }

    public pbb095598 Add(pbb095598 P0)
    {
        // call: System.arraycopy
        // call: pbb095598.buildArray
        // field: p4d236d9a.p8a1517b7.pff5911de.pbb095598.f7f672275
        // field: p4d236d9a.p8a1517b7.pff5911de.pbb095598.fd334c0c3
        return default!;
    }

    public pbb095598 AddAmount(pa4f4f3f0 P0, decimal P1)
    {
        // call: StringBuilder.toString
        // call: StringBuilder.insert
        // call: StringBuilder.<init>
        // call: StringBuilder.length
        // call: StringBuilder.append
        // call: pbb095598.addHex
        // call: decimal.longValue
        // call: decimal.multiply
        // field: p4d236d9a.p8a1517b7.pff5911de.pbb095598.f6f28b236
        // type: StringBuilder
        return default!;
    }

    public pbb095598 AddBerTlv(p18e8d507 P0)
    {
        // call: pbb095598.addBytes
        // call: pbb095598.add
        // call: p18e8d507.isConstructed
        // call: p18e8d507.getBytesValue
        // call: pbb095598.md98a07f8
        // call: p18e8d507.getTag
        // field: p4d236d9a.p8a1517b7.pff5911de.pbb095598.f7f672275
        return default!;
    }

    public pbb095598 AddByte(pa4f4f3f0 P0, byte P1)
    {
        // call: System.arraycopy
        // field: p4d236d9a.p8a1517b7.pff5911de.pbb095598.f7f672275
        // field: p4d236d9a.p8a1517b7.pff5911de.pbb095598.fd334c0c3
        // field: p4d236d9a.p8a1517b7.pff5911de.pa4f4f3f0.f4b3a6218
        return default!;
    }

    public pbb095598 AddBytes(pa4f4f3f0 P0, byte[] P1)
    {
        // call: pbb095598.addBytes
        return default!;
    }

    public pbb095598 AddBytes(pa4f4f3f0 P0, byte[] P1, int P2, int P3)
    {
        // call: System.arraycopy
        // call: pbb095598.m246c128a
        // call: pbb095598.mc7f8b8ad
        // field: p4d236d9a.p8a1517b7.pff5911de.pbb095598.f7f672275
        // field: p4d236d9a.p8a1517b7.pff5911de.pbb095598.fd334c0c3
        // field: p4d236d9a.p8a1517b7.pff5911de.pa4f4f3f0.f4b3a6218
        return default!;
    }

    public pbb095598 AddDate(pa4f4f3f0 P0, DateTime P1)
    {
        // str: "yyMMdd"
        // call: string.<init>
        // call: pbb095598.addHex
        // call: string.format
        // type: string
        return default!;
    }

    public pbb095598 AddEmpty(pa4f4f3f0 P0)
    {
        // call: pbb095598.addBytes
        return default!;
    }

    public pbb095598 AddHex(pa4f4f3f0 P0, string P1)
    {
        // call: p5e5d682d.m82f8e804
        // call: pbb095598.addBytes
        return default!;
    }

    public pbb095598 AddIntAsHex(pa4f4f3f0 P0, int P1, int P2)
    {
        // call: StringBuilder.toString
        // call: StringBuilder.insert
        // call: StringBuilder.<init>
        // call: pbb095598.addHex
        // call: StringBuilder.append
        // call: StringBuilder.length
        // type: StringBuilder
        return default!;
    }

    public pbb095598 AddText(pa4f4f3f0 P0, string P1)
    {
        // call: pbb095598.addText
        // field: p4d236d9a.p8a1517b7.pff5911de.pbb095598.fd2cd8253
        return default!;
    }

    public pbb095598 AddText(pa4f4f3f0 P0, string P1, System.Text.Encoding P2)
    {
        // call: pbb095598.addBytes
        // call: string.getBytes
        return default!;
    }

    public pbb095598 AddTime(pa4f4f3f0 P0, DateTime P1)
    {
        // str: "HHmmss"
        // call: pbb095598.addHex
        // call: string.<init>
        // call: string.format
        // type: string
        return default!;
    }

    public int Build()
    {
        // call: System.arraycopy
        // call: pbb095598.m246c128a
        // call: pbb095598.mc7f8b8ad
        // field: p4d236d9a.p8a1517b7.pff5911de.pa4f4f3f0.f4b3a6218
        // field: p4d236d9a.p8a1517b7.pff5911de.pbb095598.fd334c0c3
        // field: p4d236d9a.p8a1517b7.pff5911de.pbb095598.f7f672275
        // field: p4d236d9a.p8a1517b7.pff5911de.pbb095598.faf5c0bbb
        // field: p4d236d9a.p8a1517b7.pff5911de.pbb095598.f0e339957
        return 0;
    }

    public byte[] BuildArray()
    {
        // call: pbb095598.build
        // call: System.arraycopy
        // field: p4d236d9a.p8a1517b7.pff5911de.pbb095598.f7f672275
        return default!;
    }

    public p18e8d507 BuildTlv()
    {
        // call: pbb095598.build
        // call: p74322e47.parseConstructed
        // call: p74322e47.<init>
        // field: p4d236d9a.p8a1517b7.pff5911de.pbb095598.f0e339957
        // field: p4d236d9a.p8a1517b7.pff5911de.pbb095598.f7f672275
        // type: p74322e47
        return default!;
    }

    public pfb48fcda BuildTlvs()
    {
        // call: pbb095598.build
        // call: p74322e47.<init>
        // call: p74322e47.parse
        // field: p4d236d9a.p8a1517b7.pff5911de.pbb095598.f0e339957
        // field: p4d236d9a.p8a1517b7.pff5911de.pbb095598.f7f672275
        // type: p74322e47
        return default!;
    }

}
