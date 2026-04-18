namespace WillowMaze.Wasm.Decompiled;

public class P223127e3_p6cee4383 : Pf31bbdd1
{
    private bool F14e8fd57;
    private long F159aea43;
    private bool F349e6863;
    private bool F4005169b;
    private long F4757fe07;
    private readonly p223127e3 F532b7695;
    private readonly p223127e3 F5673ae88;
    private readonly p223127e3 F93abd35a;
    private readonly p223127e3 Fbb764c49;
    private bool Fd98118f9;
    private bool Fe6b18c1a;
    private readonly p223127e3 Fe7716eb7;
    private long Ff8463cc3;

    public void Close()
    {
        // call: Lock.unlock
        // call: p223127e3.getLock
        // call: Lock.lock
        // call: p223127e3.m6880f43e
        // call: p223127e3.m85b60549
        // call: p223127e3.mb6adc4cd
        // call: p223127e3.protectedClose
        // field: p38cb8f46.p223127e3$p6cee4383.f93abd35a
        // field: p38cb8f46.p223127e3$p6cee4383.f349e6863
        // field: kotlin.Unit.INSTANCE
    }

    public bool GetClosed()
    {
        // field: p38cb8f46.p223127e3$p6cee4383.f349e6863
        return false;
    }

    public p223127e3 GetFileHandle()
    {
        // field: p38cb8f46.p223127e3$p6cee4383.f93abd35a
        return default!;
    }

    public long GetPosition()
    {
        // field: p38cb8f46.p223127e3$p6cee4383.f4757fe07
        return 0;
    }

    public long Read(p7e62bc34 P0, long P1)
    {
        // str: "closed"
        // str: "sink"
        // call: object.toString
        // call: p223127e3.m490a646e
        // call: IllegalStateException.<init>
        // call: Intrinsics.checkNotNullParameter
        // field: p38cb8f46.p223127e3$p6cee4383.f4757fe07
        // field: p38cb8f46.p223127e3$p6cee4383.f349e6863
        // field: p38cb8f46.p223127e3$p6cee4383.f93abd35a
        // type: IllegalStateException
        return 0;
    }

    public void SetClosed(bool P0)
    {
        // field: p38cb8f46.p223127e3$p6cee4383.f349e6863
    }

    public void SetPosition(long P0)
    {
        // field: p38cb8f46.p223127e3$p6cee4383.f4757fe07
    }

    public pc85a251c Timeout()
    {
        // field: p38cb8f46.pc85a251c.fb50339a1
        return default!;
    }

}
