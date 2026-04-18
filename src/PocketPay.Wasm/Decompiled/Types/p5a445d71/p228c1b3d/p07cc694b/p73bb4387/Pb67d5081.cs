namespace WillowMaze.Wasm.Decompiled;

public class Pb67d5081 : P27703c8f
{
    private readonly string F088b0dfc;
    private readonly HashSet<object> F1599fb73;
    private readonly HashSet<object> F16764137;
    private readonly Dictionary<string, object> F185c52a4;
    private readonly string F1f9d9828;
    private readonly string F31e8448e;
    private readonly string F3ff23b4e;
    private readonly ClassLoader F49e997c5;
    private readonly ClassLoader F4c58a72f;
    private readonly Dictionary<string, object> F775d5d12;
    private readonly string F8a884a6f;
    private readonly ClassLoader Fbbf48087;
    private readonly Dictionary<string, object> Fcf8abcf6;
    private readonly Dictionary<string, object> Fe04964a0;
    private readonly string Fe1281a7c;
    private readonly Dictionary<string, object> Fe1a10968;
    private readonly ClassLoader Fe57c4b32;
    private readonly string Fe6f0451b;
    private readonly ClassLoader Fe93961bf;
    private readonly string Fffa5124a;

    private static void M1d29dec5(DataInputStream P0, Dictionary<string, object> P1)
    {
        // str: "Corrupt zone info map"
        // call: DataInputStream.readUnsignedShort
        // call: Dictionary<string, object>.put
        // call: string.intern
        // call: IOException.<init>
        // call: DataInputStream.readUTF
        // type: IOException
    }

    private static Dictionary<string, object> M2bf845c8(Stream P0)
    {
        // str: "UTC"
        // call: SoftReference.<init>
        // call: DataInputStream.<init>
        // call: pb67d5081.m1d29dec5
        // call: DataInputStream.close
        // call: Dictionary<string, object>.put
        // call: Dictionary<string, object>.<init>
        // field: p5a445d71.p228c1b3d.p07cc694b.p34dacb78.f9234324d
        // type: SoftReference
        // type: DataInputStream
        // type: Dictionary<string, object>
        return default!;
    }

    private Stream Mb32574f8(string P0)
    {
        // str: "Resource not found: \""
        // str: "\" ClassLoader: "
        // str: "system"
        // call: StringBuilder.toString
        // call: AccessController.doPrivileged
        // call: IOException.<init>
        // call: string.concat
        // call: StringBuilder.append
        // call: string.<init>
        // call: FileInputStream.<init>
        // call: object.toString
        // call: StringBuilder.<init>
        // call: pb67d5081$1.<init>
        // field: p5a445d71.p228c1b3d.p07cc694b.p73bb4387.pb67d5081.fe6f0451b
        // field: p5a445d71.p228c1b3d.p07cc694b.p73bb4387.pb67d5081.f8a884a6f
        // field: p5a445d71.p228c1b3d.p07cc694b.p73bb4387.pb67d5081.fe57c4b32
        // type: FileInputStream
        // type: IOException
        // type: string
        // type: StringBuilder
        // type: pb67d5081$1
        return default!;
    }

    private p34dacb78 Me7374c52(string P0)
    {
        // call: Stream.close
        // call: pb67d5081.uncaughtException
        // call: Dictionary<string, object>.remove
        // call: pb67d5081.mb32574f8
        // call: p72436115.mbf464907
        // call: SoftReference.<init>
        // call: Dictionary<string, object>.put
        // field: p5a445d71.p228c1b3d.p07cc694b.p73bb4387.pb67d5081.f775d5d12
        // type: SoftReference
        return default!;
    }

    private static ClassLoader Mf23e8626(pb67d5081 P0)
    {
        // field: p5a445d71.p228c1b3d.p07cc694b.p73bb4387.pb67d5081.fe57c4b32
        return default!;
    }

    public HashSet<object> GetAvailableIDs()
    {
        // field: p5a445d71.p228c1b3d.p07cc694b.p73bb4387.pb67d5081.f1599fb73
        return default!;
    }

    public p34dacb78 GetZone(string P0)
    {
        // call: string.equals
        // call: pb67d5081.me7374c52
        // call: Dictionary<string, object>.get
        // call: SoftReference.get
        // call: pb67d5081.getZone
        // field: p5a445d71.p228c1b3d.p07cc694b.p73bb4387.pb67d5081.f775d5d12
        return default!;
    }

    private void UncaughtException(Exception P0)
    {
        // call: Exception.printStackTrace
    }

}
