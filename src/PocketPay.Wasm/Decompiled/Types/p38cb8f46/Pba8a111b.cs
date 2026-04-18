namespace WillowMaze.Wasm.Decompiled;

public class Pba8a111b : P223127e3
{
    private readonly RandomAccessFile F142cb162;
    private readonly RandomAccessFile F23c2be1b;
    private readonly RandomAccessFile F42f6d937;
    private readonly RandomAccessFile F673ff92e;
    private readonly RandomAccessFile Fde34ca48;

    private void ProtectedClose()
    {
        // call: RandomAccessFile.close
        // field: p38cb8f46.pba8a111b.f42f6d937
    }

    private void ProtectedFlush()
    {
        // call: RandomAccessFile.getFD
        // call: FileDescriptor.sync
        // field: p38cb8f46.pba8a111b.f42f6d937
    }

    private int ProtectedRead(long P0, byte[] P1, int P2, int P3)
    {
        // str: "array"
        // call: Intrinsics.checkNotNullParameter
        // call: RandomAccessFile.seek
        // call: RandomAccessFile.read
        // field: p38cb8f46.pba8a111b.f42f6d937
        return 0;
    }

    private void ProtectedResize(long P0)
    {
        // call: pba8a111b.size
        // call: pba8a111b.protectedWrite
        // call: RandomAccessFile.setLength
        // field: p38cb8f46.pba8a111b.f42f6d937
    }

    private long ProtectedSize()
    {
        // call: RandomAccessFile.length
        // field: p38cb8f46.pba8a111b.f42f6d937
        return 0;
    }

    private void ProtectedWrite(long P0, byte[] P1, int P2, int P3)
    {
        // str: "array"
        // call: Intrinsics.checkNotNullParameter
        // call: RandomAccessFile.seek
        // call: RandomAccessFile.write
        // field: p38cb8f46.pba8a111b.f42f6d937
    }

}
