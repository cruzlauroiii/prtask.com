namespace WillowMaze.Wasm.Decompiled;

public class P9efefad6
{
    private readonly FileChannel F745109a6;
    private readonly FileChannel Fd3c2b2a5;

    public void Read(long P0, p7e62bc34 P1, long P2)
    {
        // str: "sink"
        // call: Intrinsics.checkNotNullParameter
        // call: FileChannel.transferTo
        // call: IndexOutOfBoundsException.<init>
        // field: p7ddcfee1.pd1efad72.p5837d419.p9efefad6.fd3c2b2a5
        // type: IndexOutOfBoundsException
    }

    public void Write(long P0, p7e62bc34 P1, long P2)
    {
        // str: "source"
        // call: Intrinsics.checkNotNullParameter
        // call: p7e62bc34.size
        // call: IndexOutOfBoundsException.<init>
        // call: FileChannel.transferFrom
        // field: p7ddcfee1.pd1efad72.p5837d419.p9efefad6.fd3c2b2a5
        // type: IndexOutOfBoundsException
    }

}
