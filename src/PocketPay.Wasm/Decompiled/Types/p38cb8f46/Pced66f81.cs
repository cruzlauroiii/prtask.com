namespace WillowMaze.Wasm.Decompiled;

public class Pced66f81 : Pe2d63d19
{
    private static pac70412e F0f662ea4;
    private static pac70412e F2db031dc;
    private static pced66f81$p910eef8c F86070527;
    private static pced66f81$p910eef8c F910eef8c;
    private static pac70412e Fea2adde5;
    private readonly string F06d4cd63;
    private readonly Dictionary<string, object> F17f27a84;
    private readonly pac70412e F2652272f;
    private readonly pac70412e F3094b387;
    private readonly Dictionary<string, object> F340bff9a;
    private readonly pe2d63d19 F44d4d4eb;
    private readonly string F4a35ff58;
    private readonly Dictionary<string, object> F5d86fb60;
    private readonly Dictionary<string, object> F5fce916b;
    private readonly Dictionary<string, object> F62252770;
    private readonly string F6ab12290;
    private readonly pe2d63d19 F8595f421;
    private readonly pe2d63d19 Fa8f9a24a;
    private readonly pac70412e Fbb770cb4;
    private readonly pe2d63d19 Fbda4c1de;
    private readonly string Ff45860b4;
    private readonly pac70412e Fffe4e156;

    private List<object> M10ae9fc7(pac70412e P0, bool P1)
    {
        // str: "not a directory: "
        // call: IOException.<init>
        // call: StringBuilder.append
        // call: pf3ce07b0.getChildren
        // call: CollectionsKt.toList
        // call: StringBuilder.<init>
        // call: Dictionary<string, object>.get
        // call: StringBuilder.toString
        // call: pced66f81.m354c803d
        // field: p38cb8f46.pced66f81.f5fce916b
        // type: IOException
        // type: StringBuilder
        return default!;
    }

    private pac70412e M354c803d(pac70412e P0)
    {
        // call: pac70412e.resolve
        // field: p38cb8f46.pced66f81.fea2adde5
        return default!;
    }

    public static pac70412e M4baba847()
    {
        // field: p38cb8f46.pced66f81.fea2adde5
        return default!;
    }

    public p1eb558b5 AppendingSink(pac70412e P0, bool P1)
    {
        // str: "file"
        // str: "zip file systems are read-only"
        // call: Intrinsics.checkNotNullParameter
        // call: IOException.<init>
        // type: IOException
        return default!;
    }

    public void AtomicMove(pac70412e P0, pac70412e P1)
    {
        // str: "target"
        // str: "source"
        // str: "zip file systems are read-only"
        // call: Intrinsics.checkNotNullParameter
        // call: IOException.<init>
        // type: IOException
    }

    public pac70412e Canonicalize(pac70412e P0)
    {
        // str: "path"
        // call: Dictionary<string, object>.containsKey
        // call: FileNotFoundException.<init>
        // call: pced66f81.m354c803d
        // call: string.valueOf
        // call: Intrinsics.checkNotNullParameter
        // field: p38cb8f46.pced66f81.f5fce916b
        // type: FileNotFoundException
        return default!;
    }

    public void CreateDirectory(pac70412e P0, bool P1)
    {
        // str: "dir"
        // str: "zip file systems are read-only"
        // call: IOException.<init>
        // call: Intrinsics.checkNotNullParameter
        // type: IOException
    }

    public void CreateSymlink(pac70412e P0, pac70412e P1)
    {
        // str: "source"
        // str: "target"
        // str: "zip file systems are read-only"
        // call: Intrinsics.checkNotNullParameter
        // call: IOException.<init>
        // type: IOException
    }

    public void Delete(pac70412e P0, bool P1)
    {
        // str: "zip file systems are read-only"
        // str: "path"
        // call: Intrinsics.checkNotNullParameter
        // call: IOException.<init>
        // type: IOException
    }

    public List<object> List(pac70412e P0)
    {
        // str: "dir"
        // call: pced66f81.m10ae9fc7
        // call: Intrinsics.checkNotNull
        // call: Intrinsics.checkNotNullParameter
        return default!;
    }

    public List<object> ListOrNull(pac70412e P0)
    {
        // str: "dir"
        // call: pced66f81.m10ae9fc7
        // call: Intrinsics.checkNotNullParameter
        return default!;
    }

    public p50ca3499 MetadataOrNull(pac70412e P0)
    {
        // str: "path"
        // call: pf3ce07b0.isDirectory
        // call: IDisposable.close
        // call: pf3ce07b0.getOffset
        // call: Dictionary<string, object>.get
        // call: ExceptionsKt.addSuppressed
        // call: pe2d63d19.openReadOnly
        // call: p50ca3499.<init>
        // call: Intrinsics.checkNotNull
        // call: Intrinsics.checkNotNullParameter
        // call: p223127e3.source
        // call: p0af9afa4.m7f2db423
        // call: pf3ce07b0.getLastModifiedAtMillis
        // call: long.valueOf
        // call: pf3ce07b0.getSize
        // call: p5dd44a36.m514ac98d
        // call: pced66f81.m354c803d
        // field: p38cb8f46.pced66f81.fffe4e156
        // field: p38cb8f46.pced66f81.f5fce916b
        // field: p38cb8f46.pced66f81.f44d4d4eb
        // type: p50ca3499
        return default!;
    }

    public p223127e3 OpenReadOnly(pac70412e P0)
    {
        // str: "file"
        // str: "not implemented yet!"
        // call: UnsupportedOperationException.<init>
        // call: Intrinsics.checkNotNullParameter
        // type: UnsupportedOperationException
        return default!;
    }

    public p223127e3 OpenReadWrite(pac70412e P0, bool P1, bool P2)
    {
        // str: "zip entries are not writable"
        // str: "file"
        // call: Intrinsics.checkNotNullParameter
        // call: IOException.<init>
        // type: IOException
        return default!;
    }

    public p1eb558b5 Sink(pac70412e P0, bool P1)
    {
        // str: "file"
        // str: "zip file systems are read-only"
        // call: Intrinsics.checkNotNullParameter
        // call: IOException.<init>
        // type: IOException
        return default!;
    }

    public pf31bbdd1 Source(pac70412e P0)
    {
        // str: "no such file: "
        // str: "file"
        // call: p5dd44a36.mc4eaa582
        // call: Inflater.<init>
        // call: pced66f81.m354c803d
        // call: pf3ce07b0.getSize
        // call: p432b0cdb.<init>
        // call: Intrinsics.checkNotNull
        // call: StringBuilder.<init>
        // call: pf3ce07b0.getCompressionMethod
        // call: IDisposable.close
        // call: StringBuilder.toString
        // call: pe2d63d19.openReadOnly
        // call: Dictionary<string, object>.get
        // call: FileNotFoundException.<init>
        // call: Intrinsics.checkNotNullParameter
        // call: ExceptionsKt.addSuppressed
        // call: pf3ce07b0.getCompressedSize
        // call: pf3ce07b0.getOffset
        // call: p223127e3.source
        // call: p0af9afa4.m7f2db423
        // call: StringBuilder.append
        // field: p38cb8f46.pced66f81.f44d4d4eb
        // field: p38cb8f46.pced66f81.fffe4e156
        // field: p38cb8f46.pced66f81.f5fce916b
        // type: p432b0cdb
        // type: p8ac70daa
        // type: Inflater
        // type: FileNotFoundException
        // type: StringBuilder
        return default!;
    }

}
