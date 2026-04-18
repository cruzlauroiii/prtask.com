namespace WillowMaze.Wasm.Decompiled;

public class Ped3c8257 : P223127e3
{
    private readonly FileChannel Fd18ea4cc;
    private readonly FileChannel Fd3c2b2a5;

    private void ProtectedClose()
    {
        // call: FileChannel.close
        // field: p38cb8f46.ped3c8257.fd3c2b2a5
    }

    private void ProtectedFlush()
    {
        // call: FileChannel.force
        // field: p38cb8f46.ped3c8257.fd3c2b2a5
    }

    private int ProtectedRead(long P0, byte[] P1, int P2, int P3)
    {
        // str: "array"
        // call: Intrinsics.checkNotNullParameter
        // call: FileChannel.position
        // call: byte[].wrap
        // call: FileChannel.read
        // field: p38cb8f46.ped3c8257.fd3c2b2a5
        return 0;
    }

    private void ProtectedResize(long P0)
    {
        // call: ped3c8257.protectedWrite
        // call: FileChannel.truncate
        // call: ped3c8257.size
        // field: p38cb8f46.ped3c8257.fd3c2b2a5
    }

    private long ProtectedSize()
    {
        // call: FileChannel.size
        // field: p38cb8f46.ped3c8257.fd3c2b2a5
        return 0;
    }

    private void ProtectedWrite(long P0, byte[] P1, int P2, int P3)
    {
        // str: "array"
        // call: Intrinsics.checkNotNullParameter
        // call: FileChannel.position
        // call: byte[].wrap
        // call: FileChannel.write
        // field: p38cb8f46.ped3c8257.fd3c2b2a5
    }

}
