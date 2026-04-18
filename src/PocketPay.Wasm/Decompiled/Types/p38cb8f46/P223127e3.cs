namespace WillowMaze.Wasm.Decompiled;

public abstract class P223127e3 : IDisposable
{
    private readonly Lock F0ffebbf8;
    private bool F349e6863;
    private int F48b0afad;
    private bool F4fb99463;
    private readonly bool F6bf4941c;
    private readonly bool F94631be6;
    private readonly Lock F95208304;
    private readonly Lock Fb279bbf6;
    private int Fc4993491;
    private readonly Lock Fdce7c417;
    private readonly bool Fdfa02da7;
    private readonly bool Fe02f16b8;
    private bool Ff4775c11;
    private readonly bool Ff832b034;
    private bool Ffdab219b;

    public static void M08457b12(p223127e3 P0, long P1, p7e62bc34 P2, long P3)
    {
        // call: p223127e3.m2d732ad4
    }

    public static p1eb558b5 M24d48594(p223127e3 P0, long P1, int P2, object P3)
    {
        // str: "Super calls with default arguments not supported in this target, function: sink"
        // call: p223127e3.sink
        // call: UnsupportedOperationException.<init>
        // type: UnsupportedOperationException
        return default!;
    }

    private void M2d732ad4(long P0, p7e62bc34 P1, long P2)
    {
        // call: p7e62bc34.size
        // call: p223127e3.protectedWrite
        // call: p4b77e2a9.pop
        // call: p7e62bc34.setSize$okio
        // call: Intrinsics.checkNotNull
        // call: p2ff17a65.m799a7e61
        // call: p2700aee4.mf914097e
        // call: Math.min
        // field: p38cb8f46.p4b77e2a9.f5e0bdcbd
        // field: p38cb8f46.p4b77e2a9.faa9f73ee
        // field: p38cb8f46.p7e62bc34.f96e89a29
        // field: p38cb8f46.p4b77e2a9.f8d777f38
    }

    private long M438ee57e(long P0, p7e62bc34 P1, long P2)
    {
        // str: "byteCount < 0: "
        // call: Math.min
        // call: object.toString
        // call: p223127e3.protectedRead
        // call: StringBuilder.<init>
        // call: p4b77e2a9.pop
        // call: IllegalArgumentException.<init>
        // call: p7e62bc34.setSize$okio
        // call: StringBuilder.append
        // call: p7e62bc34.size
        // call: StringBuilder.toString
        // call: p2700aee4.mf914097e
        // call: p7e62bc34.writableSegment$okio
        // field: p38cb8f46.p4b77e2a9.f5e0bdcbd
        // field: p38cb8f46.p4b77e2a9.faa9f73ee
        // field: p38cb8f46.p4b77e2a9.f8d777f38
        // field: p38cb8f46.p7e62bc34.f96e89a29
        // type: IllegalArgumentException
        // type: StringBuilder
        return 0;
    }

    public static long M490a646e(p223127e3 P0, long P1, p7e62bc34 P2, long P3)
    {
        // call: p223127e3.m438ee57e
        return 0;
    }

    public static int M6880f43e(p223127e3 P0)
    {
        // field: p38cb8f46.p223127e3.fc4993491
        return 0;
    }

    public static void M85b60549(p223127e3 P0, int P1)
    {
        // field: p38cb8f46.p223127e3.fc4993491
    }

    public static bool Mb6adc4cd(p223127e3 P0)
    {
        // field: p38cb8f46.p223127e3.f349e6863
        return false;
    }

    public static pf31bbdd1 Mbfef38d1(p223127e3 P0, long P1, int P2, object P3)
    {
        // str: "Super calls with default arguments not supported in this target, function: source"
        // call: UnsupportedOperationException.<init>
        // call: p223127e3.source
        // type: UnsupportedOperationException
        return default!;
    }

    public p1eb558b5 AppendingSink()
    {
        // call: p223127e3.sink
        // call: p223127e3.size
        return default!;
    }

    public void Close()
    {
        // call: Lock.unlock
        // call: p223127e3.protectedClose
        // call: Lock.lock
        // field: p38cb8f46.p223127e3.f349e6863
        // field: p38cb8f46.p223127e3.fc4993491
        // field: p38cb8f46.p223127e3.fdce7c417
        // field: kotlin.Unit.INSTANCE
    }

    public void Flush()
    {
        // str: "file handle is read-only"
        // str: "closed"
        // call: Lock.unlock
        // call: p223127e3.protectedFlush
        // call: object.toString
        // call: IllegalStateException.<init>
        // call: Lock.lock
        // field: p38cb8f46.p223127e3.f6bf4941c
        // field: p38cb8f46.p223127e3.fdce7c417
        // field: p38cb8f46.p223127e3.f349e6863
        // field: kotlin.Unit.INSTANCE
        // type: IllegalStateException
    }

    public Lock GetLock()
    {
        // field: p38cb8f46.p223127e3.fdce7c417
        return default!;
    }

    public bool GetReadWrite()
    {
        // field: p38cb8f46.p223127e3.f6bf4941c
        return false;
    }

    public long Position(p1eb558b5 P0)
    {
        // str: "sink"
        // str: "sink was not created by this FileHandle"
        // str: "closed"
        // call: IllegalArgumentException.<init>
        // call: p7e62bc34.size
        // call: Intrinsics.checkNotNullParameter
        // call: p223127e3$p136b4d88.getFileHandle
        // call: p223127e3$p136b4d88.getClosed
        // call: object.toString
        // call: IllegalStateException.<init>
        // call: p223127e3$p136b4d88.getPosition
        // field: p38cb8f46.pd84c6f13.ff4547fa3
        // field: p38cb8f46.pd84c6f13.ff6e04117
        // type: IllegalArgumentException
        // type: IllegalStateException
        return 0;
    }

    public long Position(pf31bbdd1 P0)
    {
        // str: "closed"
        // str: "source"
        // str: "source was not created by this FileHandle"
        // call: p223127e3$p6cee4383.getFileHandle
        // call: Intrinsics.checkNotNullParameter
        // call: IllegalArgumentException.<init>
        // call: object.toString
        // call: p7e62bc34.size
        // call: p223127e3$p6cee4383.getClosed
        // call: IllegalStateException.<init>
        // call: p223127e3$p6cee4383.getPosition
        // field: p38cb8f46.p16c6c42e.ff4547fa3
        // field: p38cb8f46.p16c6c42e.f36cd38f4
        // type: IllegalStateException
        // type: IllegalArgumentException
        return 0;
    }

    private void ProtectedClose()
    {
    }

    private void ProtectedFlush()
    {
    }

    private int ProtectedRead(long P0, byte[] P1, int P2, int P3)
    {
        return 0;
    }

    private void ProtectedResize(long P0)
    {
    }

    private long ProtectedSize()
    {
        return 0;
    }

    private void ProtectedWrite(long P0, byte[] P1, int P2, int P3)
    {
    }

    public int Read(long P0, byte[] P1, int P2, int P3)
    {
        // str: "array"
        // str: "closed"
        // call: Lock.lock
        // call: Intrinsics.checkNotNullParameter
        // call: Lock.unlock
        // call: p223127e3.protectedRead
        // call: object.toString
        // call: IllegalStateException.<init>
        // field: p38cb8f46.p223127e3.f349e6863
        // field: kotlin.Unit.INSTANCE
        // field: p38cb8f46.p223127e3.fdce7c417
        // type: IllegalStateException
        return 0;
    }

    public long Read(long P0, p7e62bc34 P1, long P2)
    {
        // str: "closed"
        // str: "sink"
        // call: Lock.unlock
        // call: Intrinsics.checkNotNullParameter
        // call: object.toString
        // call: IllegalStateException.<init>
        // call: p223127e3.m438ee57e
        // call: Lock.lock
        // field: p38cb8f46.p223127e3.fdce7c417
        // field: p38cb8f46.p223127e3.f349e6863
        // field: kotlin.Unit.INSTANCE
        // type: IllegalStateException
        return 0;
    }

    public void Reposition(p1eb558b5 P0, long P1)
    {
        // str: "closed"
        // str: "sink was not created by this FileHandle"
        // str: "sink"
        // call: IllegalArgumentException.<init>
        // call: p223127e3$p136b4d88.getClosed
        // call: IllegalStateException.<init>
        // call: pd84c6f13.emit
        // call: object.toString
        // call: Intrinsics.checkNotNullParameter
        // call: p223127e3$p136b4d88.setPosition
        // call: p223127e3$p136b4d88.getFileHandle
        // field: p38cb8f46.pd84c6f13.ff6e04117
        // type: IllegalStateException
        // type: IllegalArgumentException
    }

    public void Reposition(pf31bbdd1 P0, long P1)
    {
        // str: "source"
        // str: "source was not created by this FileHandle"
        // str: "closed"
        // call: object.toString
        // call: p223127e3$p6cee4383.getFileHandle
        // call: IllegalArgumentException.<init>
        // call: p16c6c42e.skip
        // call: p7e62bc34.size
        // call: IllegalStateException.<init>
        // call: p223127e3$p6cee4383.setPosition
        // call: p7e62bc34.clear
        // call: p223127e3$p6cee4383.getClosed
        // call: p223127e3$p6cee4383.getPosition
        // call: Intrinsics.checkNotNullParameter
        // field: p38cb8f46.p16c6c42e.ff4547fa3
        // field: p38cb8f46.p16c6c42e.f36cd38f4
        // type: IllegalStateException
        // type: IllegalArgumentException
    }

    public void Resize(long P0)
    {
        // str: "closed"
        // str: "file handle is read-only"
        // call: Lock.lock
        // call: Lock.unlock
        // call: IllegalStateException.<init>
        // call: object.toString
        // call: p223127e3.protectedResize
        // field: p38cb8f46.p223127e3.f349e6863
        // field: kotlin.Unit.INSTANCE
        // field: p38cb8f46.p223127e3.fdce7c417
        // field: p38cb8f46.p223127e3.f6bf4941c
        // type: IllegalStateException
    }

    public p1eb558b5 Sink(long P0)
    {
        // str: "closed"
        // str: "file handle is read-only"
        // call: object.toString
        // call: IllegalStateException.<init>
        // call: p223127e3$p136b4d88.<init>
        // call: Lock.unlock
        // call: Lock.lock
        // field: p38cb8f46.p223127e3.f6bf4941c
        // field: p38cb8f46.p223127e3.fdce7c417
        // field: p38cb8f46.p223127e3.f349e6863
        // field: p38cb8f46.p223127e3.fc4993491
        // type: IllegalStateException
        // type: p223127e3$p136b4d88
        return default!;
    }

    public long Size()
    {
        // str: "closed"
        // call: Lock.lock
        // call: object.toString
        // call: IllegalStateException.<init>
        // call: Lock.unlock
        // call: p223127e3.protectedSize
        // field: p38cb8f46.p223127e3.fdce7c417
        // field: p38cb8f46.p223127e3.f349e6863
        // field: kotlin.Unit.INSTANCE
        // type: IllegalStateException
        return 0;
    }

    public pf31bbdd1 Source(long P0)
    {
        // str: "closed"
        // call: Lock.unlock
        // call: object.toString
        // call: IllegalStateException.<init>
        // call: p223127e3$p6cee4383.<init>
        // call: Lock.lock
        // field: p38cb8f46.p223127e3.f349e6863
        // field: p38cb8f46.p223127e3.fc4993491
        // field: p38cb8f46.p223127e3.fdce7c417
        // type: IllegalStateException
        // type: p223127e3$p6cee4383
        return default!;
    }

    public void Write(long P0, p7e62bc34 P1, long P2)
    {
        // str: "closed"
        // str: "file handle is read-only"
        // str: "source"
        // call: object.toString
        // call: IllegalStateException.<init>
        // call: Lock.unlock
        // call: p223127e3.m2d732ad4
        // call: Intrinsics.checkNotNullParameter
        // call: Lock.lock
        // field: p38cb8f46.p223127e3.fdce7c417
        // field: p38cb8f46.p223127e3.f6bf4941c
        // field: p38cb8f46.p223127e3.f349e6863
        // field: kotlin.Unit.INSTANCE
        // type: IllegalStateException
    }

    public void Write(long P0, byte[] P1, int P2, int P3)
    {
        // str: "file handle is read-only"
        // str: "array"
        // str: "closed"
        // call: IllegalStateException.<init>
        // call: Intrinsics.checkNotNullParameter
        // call: Lock.lock
        // call: Lock.unlock
        // call: object.toString
        // call: p223127e3.protectedWrite
        // field: p38cb8f46.p223127e3.fdce7c417
        // field: p38cb8f46.p223127e3.f349e6863
        // field: kotlin.Unit.INSTANCE
        // field: p38cb8f46.p223127e3.f6bf4941c
        // type: IllegalStateException
    }

}
