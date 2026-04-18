namespace WillowMaze.Wasm.Decompiled;

public class P992374d8_p55247216 : P9d679bdd
{
    private bool F21c4bb07;
    private long F30006844;
    private bool F349e6863;
    private readonly long F3cb08169;
    private bool F50f9ce74;
    private readonly long F74dc7ae9;
    private long F7cb149a3;
    private bool F7d97798d;
    private bool F8fb3622e;
    private bool Fa7a5c093;
    private bool Faa8fb77e;
    private bool Fba67e1d2;
    private bool Fbb4f994e;
    private readonly long Fc22384f3;
    private readonly long Fd54c7270;
    private long Fe9aec8e3;
    private long Ffdfb9320;
    private readonly p992374d8 This$0;

    private IOException Complete(IOException P0)
    {
        // call: p992374d8.bodyComplete
        // field: p7ddcfee1.pd1efad72.p4717d53e.p992374d8$p55247216.faa8fb77e
        // field: p7ddcfee1.pd1efad72.p4717d53e.p992374d8$p55247216.this$0
        // field: p7ddcfee1.pd1efad72.p4717d53e.p992374d8$p55247216.fe9aec8e3
        return default!;
    }

    public void Close()
    {
        // str: "unexpected end of stream"
        // call: p9d679bdd.close
        // call: p992374d8$p55247216.complete
        // call: ProtocolException.<init>
        // field: p7ddcfee1.pd1efad72.p4717d53e.p992374d8$p55247216.fe9aec8e3
        // field: p7ddcfee1.pd1efad72.p4717d53e.p992374d8$p55247216.f349e6863
        // field: p7ddcfee1.pd1efad72.p4717d53e.p992374d8$p55247216.fc22384f3
        // type: ProtocolException
    }

    public void Flush()
    {
        // call: p9d679bdd.flush
        // call: p992374d8$p55247216.complete
    }

    public void Write(p7e62bc34 P0, long P1)
    {
        // str: "expected "
        // str: " bytes but received "
        // str: "closed"
        // str: "source"
        // call: p9d679bdd.write
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: ProtocolException.<init>
        // call: StringBuilder.<init>
        // call: IllegalStateException.<init>
        // call: object.toString
        // call: Intrinsics.checkNotNullParameter
        // call: p992374d8$p55247216.complete
        // field: p7ddcfee1.pd1efad72.p4717d53e.p992374d8$p55247216.fe9aec8e3
        // field: p7ddcfee1.pd1efad72.p4717d53e.p992374d8$p55247216.fc22384f3
        // field: p7ddcfee1.pd1efad72.p4717d53e.p992374d8$p55247216.f349e6863
        // type: IllegalStateException
        // type: StringBuilder
        // type: ProtocolException
    }

}
