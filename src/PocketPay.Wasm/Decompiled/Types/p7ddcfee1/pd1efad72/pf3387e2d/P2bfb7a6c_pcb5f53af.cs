namespace WillowMaze.Wasm.Decompiled;

public class P2bfb7a6c_pcb5f53af : P1eb558b5
{
    private bool F04ae1554;
    private readonly p911250bb F14d02a06;
    private readonly p911250bb F14f3de0f;
    private readonly p911250bb F1bce6e76;
    private bool F349e6863;
    private bool F3ef8ae0e;
    private bool F7521a609;
    private readonly p911250bb F90272dda;
    private readonly p911250bb Fc2688d27;
    private bool Fd9209dc2;
    private readonly p2bfb7a6c This$0;

    public void Close()
    {
        // str: "0\r\n\r\n"
        // call: p2bfb7a6c.access$getSink$p
        // call: p08d84bc6.writeUtf8
        // call: p2bfb7a6c.access$detachTimeout
        // call: p2bfb7a6c.access$setState$p
        // field: p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c$pcb5f53af.f349e6863
        // field: p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c$pcb5f53af.this$0
        // field: p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c$pcb5f53af.f90272dda
    }

    public void Flush()
    {
        // call: p2bfb7a6c.access$getSink$p
        // call: p08d84bc6.flush
        // field: p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c$pcb5f53af.this$0
        // field: p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c$pcb5f53af.f349e6863
    }

    public pc85a251c Timeout()
    {
        // field: p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c$pcb5f53af.f90272dda
        return default!;
    }

    public void Write(p7e62bc34 P0, long P1)
    {
        // str: "source"
        // str: "closed"
        // str: "\r\n"
        // call: IllegalStateException.<init>
        // call: p2bfb7a6c.access$getSink$p
        // call: p08d84bc6.writeUtf8
        // call: p08d84bc6.writeHexadecimalUnsignedLong
        // call: p08d84bc6.write
        // call: Intrinsics.checkNotNullParameter
        // call: object.toString
        // field: p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c$pcb5f53af.this$0
        // field: p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c$pcb5f53af.f349e6863
        // type: IllegalStateException
    }

}
