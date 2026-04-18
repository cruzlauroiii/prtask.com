namespace WillowMaze.Wasm.Decompiled;

public class P223127e3_p136b4d88 : P1eb558b5
{
    private bool F349e6863;
    private long F35ce3ef9;
    private long F4757fe07;
    private bool F4a7f602d;
    private long F5c869720;
    private readonly p223127e3 F93abd35a;
    private bool Fa962683b;
    private bool Fabb83237;
    private bool Fd64572da;
    private readonly p223127e3 Fe70ca351;

    public void Close()
    {
        // call: Lock.lock
        // call: p223127e3.m6880f43e
        // call: p223127e3.m85b60549
        // call: p223127e3.mb6adc4cd
        // call: p223127e3.getLock
        // call: Lock.unlock
        // call: p223127e3.protectedClose
        // field: p38cb8f46.p223127e3$p136b4d88.f349e6863
        // field: p38cb8f46.p223127e3$p136b4d88.f93abd35a
        // field: kotlin.Unit.INSTANCE
    }

    public void Flush()
    {
        // str: "closed"
        // call: object.toString
        // call: p223127e3.protectedFlush
        // call: IllegalStateException.<init>
        // field: p38cb8f46.p223127e3$p136b4d88.f349e6863
        // field: p38cb8f46.p223127e3$p136b4d88.f93abd35a
        // type: IllegalStateException
    }

    public bool GetClosed()
    {
        // field: p38cb8f46.p223127e3$p136b4d88.f349e6863
        return false;
    }

    public p223127e3 GetFileHandle()
    {
        // field: p38cb8f46.p223127e3$p136b4d88.f93abd35a
        return default!;
    }

    public long GetPosition()
    {
        // field: p38cb8f46.p223127e3$p136b4d88.f4757fe07
        return 0;
    }

    public void SetClosed(bool P0)
    {
        // field: p38cb8f46.p223127e3$p136b4d88.f349e6863
    }

    public void SetPosition(long P0)
    {
        // field: p38cb8f46.p223127e3$p136b4d88.f4757fe07
    }

    public pc85a251c Timeout()
    {
        // field: p38cb8f46.pc85a251c.fb50339a1
        return default!;
    }

    public void Write(p7e62bc34 P0, long P1)
    {
        // str: "source"
        // str: "closed"
        // call: object.toString
        // call: IllegalStateException.<init>
        // call: Intrinsics.checkNotNullParameter
        // call: p223127e3.m08457b12
        // field: p38cb8f46.p223127e3$p136b4d88.f93abd35a
        // field: p38cb8f46.p223127e3$p136b4d88.f4757fe07
        // field: p38cb8f46.p223127e3$p136b4d88.f349e6863
        // type: IllegalStateException
    }

}
