namespace WillowMaze.Wasm.Decompiled;

public class Pdc482228 : Pe2d63d19
{
    private static pdc482228$p910eef8c F296f2e7c;
    private static pdc482228$p910eef8c F5e70145a;
    private static pac70412e F75b749e1;
    private static pac70412e F77d24dbf;
    private static pdc482228$p910eef8c F910eef8c;
    private static pac70412e F9fedb7e2;
    private static pdc482228$p910eef8c Fa611aedb;
    private static pac70412e Fb731e623;
    private static pac70412e Fea2adde5;
    private static pdc482228$p910eef8c Ffefecb54;
    private readonly Lazy<object> Roots$delegate;

    private List<object> M2446873b()
    {
        // call: Lazy<object>.getValue
        // field: p38cb8f46.pd1efad72.pdc482228.roots$delegate
        return default!;
    }

    private pac70412e M354c803d(pac70412e P0)
    {
        // call: pac70412e.resolve
        // field: p38cb8f46.pd1efad72.pdc482228.fea2adde5
        return default!;
    }

    public static pac70412e M4baba847()
    {
        // field: p38cb8f46.pd1efad72.pdc482228.fea2adde5
        return default!;
    }

    public static pdc482228$p910eef8c M6b378b54()
    {
        // field: p38cb8f46.pd1efad72.pdc482228.f910eef8c
        return default!;
    }

    private string Mee9e067b(pac70412e P0)
    {
        // call: pac70412e.relativeTo
        // call: pac70412e.toString
        // call: pdc482228.m354c803d
        // field: p38cb8f46.pd1efad72.pdc482228.fea2adde5
        return string.Empty;
    }

    public p1eb558b5 AppendingSink(pac70412e P0, bool P1)
    {
        // str: "file"
        // str: " is read-only"
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // call: Intrinsics.checkNotNullParameter
        // call: IOException.<init>
        // call: StringBuilder.toString
        // type: StringBuilder
        // type: IOException
        return default!;
    }

    public void AtomicMove(pac70412e P0, pac70412e P1)
    {
        // str: "source"
        // str: " is read-only"
        // str: "target"
        // call: StringBuilder.<init>
        // call: IOException.<init>
        // call: StringBuilder.append
        // call: Intrinsics.checkNotNullParameter
        // call: StringBuilder.toString
        // type: IOException
        // type: StringBuilder
    }

    public pac70412e Canonicalize(pac70412e P0)
    {
        // str: "path"
        // call: Intrinsics.checkNotNullParameter
        // call: pdc482228.m354c803d
        return default!;
    }

    public void CreateDirectory(pac70412e P0, bool P1)
    {
        // str: " is read-only"
        // str: "dir"
        // call: StringBuilder.<init>
        // call: Intrinsics.checkNotNullParameter
        // call: StringBuilder.toString
        // call: StringBuilder.append
        // call: IOException.<init>
        // type: StringBuilder
        // type: IOException
    }

    public void CreateSymlink(pac70412e P0, pac70412e P1)
    {
        // str: " is read-only"
        // str: "source"
        // str: "target"
        // call: Intrinsics.checkNotNullParameter
        // call: StringBuilder.<init>
        // call: IOException.<init>
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // type: StringBuilder
        // type: IOException
    }

    public void Delete(pac70412e P0, bool P1)
    {
        // str: "path"
        // str: " is read-only"
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: Intrinsics.checkNotNullParameter
        // call: IOException.<init>
        // call: StringBuilder.<init>
        // type: StringBuilder
        // type: IOException
    }

    public List<object> List(pac70412e P0)
    {
        // str: "dir"
        // str: "file not found: "
        // call: pac70412e.resolve
        // call: pe2d63d19.list
        // call: List<object>.<init>
        // call: IEnumerable<object>.iterator
        // call: IEnumerator<object>.hasNext
        // call: IEnumerator<object>.next
        // call: pdc482228$p910eef8c.me59ee7ad
        // call: ICollection<object>.add
        // call: CollectionsKt.collectionSizeOrDefault
        // call: pdc482228$p910eef8c.removeBase
        // call: CollectionsKt.addAll
        // call: HashSet<object>.<init>
        // call: pdc482228.mee9e067b
        // call: StringBuilder.<init>
        // call: CollectionsKt.toList
        // call: pdc482228.m2446873b
        // call: StringBuilder.toString
        // call: List<object>.iterator
        // call: ValueTuple<object, object>.component2
        // call: FileNotFoundException.<init>
        // field: p38cb8f46.pd1efad72.pdc482228.f910eef8c
        // type: List<object>
        // type: HashSet<object>
        // type: FileNotFoundException
        // type: StringBuilder
        return default!;
    }

    public List<object> ListOrNull(pac70412e P0)
    {
        // str: "dir"
        // call: CollectionsKt.toList
        // call: pdc482228.mee9e067b
        // call: HashSet<object>.<init>
        // call: IEnumerator<object>.next
        // call: pe2d63d19.listOrNull
        // call: CollectionsKt.collectionSizeOrDefault
        // call: ICollection<object>.add
        // call: pdc482228$p910eef8c.me59ee7ad
        // call: IEnumerator<object>.hasNext
        // call: IEnumerable<object>.iterator
        // call: List<object>.<init>
        // call: ValueTuple<object, object>.component2
        // call: pdc482228.m2446873b
        // call: Intrinsics.checkNotNullParameter
        // call: pac70412e.resolve
        // call: pdc482228$p910eef8c.removeBase
        // call: CollectionsKt.addAll
        // call: List<object>.iterator
        // call: ValueTuple<object, object>.component1
        // field: p38cb8f46.pd1efad72.pdc482228.f910eef8c
        // type: List<object>
        // type: HashSet<object>
        return default!;
    }

    public p50ca3499 MetadataOrNull(pac70412e P0)
    {
        // str: "path"
        // call: ValueTuple<object, object>.component1
        // call: pac70412e.resolve
        // call: pdc482228.m2446873b
        // call: pdc482228.mee9e067b
        // call: IEnumerator<object>.hasNext
        // call: pdc482228$p910eef8c.me59ee7ad
        // call: IEnumerator<object>.next
        // call: ValueTuple<object, object>.component2
        // call: Intrinsics.checkNotNullParameter
        // call: pe2d63d19.metadataOrNull
        // call: List<object>.iterator
        // field: p38cb8f46.pd1efad72.pdc482228.f910eef8c
        return default!;
    }

    public p223127e3 OpenReadOnly(pac70412e P0)
    {
        // str: "file"
        // str: "file not found: "
        // call: pdc482228.m2446873b
        // call: FileNotFoundException.<init>
        // call: IEnumerator<object>.hasNext
        // call: ValueTuple<object, object>.component2
        // call: StringBuilder.<init>
        // call: pdc482228.mee9e067b
        // call: List<object>.iterator
        // call: StringBuilder.append
        // call: IEnumerator<object>.next
        // call: pdc482228$p910eef8c.me59ee7ad
        // call: Intrinsics.checkNotNullParameter
        // call: ValueTuple<object, object>.component1
        // call: StringBuilder.toString
        // call: pac70412e.resolve
        // call: pe2d63d19.openReadOnly
        // field: p38cb8f46.pd1efad72.pdc482228.f910eef8c
        // type: FileNotFoundException
        // type: StringBuilder
        return default!;
    }

    public p223127e3 OpenReadWrite(pac70412e P0, bool P1, bool P2)
    {
        // str: "resources are not writable"
        // str: "file"
        // call: Intrinsics.checkNotNullParameter
        // call: IOException.<init>
        // type: IOException
        return default!;
    }

    public p1eb558b5 Sink(pac70412e P0, bool P1)
    {
        // str: " is read-only"
        // str: "file"
        // call: IOException.<init>
        // call: StringBuilder.toString
        // call: StringBuilder.<init>
        // call: Intrinsics.checkNotNullParameter
        // call: StringBuilder.append
        // type: StringBuilder
        // type: IOException
        return default!;
    }

    public pf31bbdd1 Source(pac70412e P0)
    {
        // str: "file not found: "
        // str: "file"
        // call: pac70412e.resolve
        // call: pe2d63d19.source
        // call: ValueTuple<object, object>.component2
        // call: ValueTuple<object, object>.component1
        // call: IEnumerator<object>.hasNext
        // call: FileNotFoundException.<init>
        // call: pdc482228.mee9e067b
        // call: IEnumerator<object>.next
        // call: StringBuilder.toString
        // call: pdc482228.m2446873b
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // call: pdc482228$p910eef8c.me59ee7ad
        // call: List<object>.iterator
        // call: Intrinsics.checkNotNullParameter
        // field: p38cb8f46.pd1efad72.pdc482228.f910eef8c
        // type: StringBuilder
        // type: FileNotFoundException
        return default!;
    }

}
