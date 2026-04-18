namespace WillowMaze.Wasm.Decompiled;

public abstract class P095ab260 : Pe2d63d19
{
    private readonly pe2d63d19 F7f662005;
    private readonly pe2d63d19 Fbeb77bab;

    public p1eb558b5 AppendingSink(pac70412e P0, bool P1)
    {
        // str: "appendingSink"
        // str: "file"
        // call: pe2d63d19.appendingSink
        // call: Intrinsics.checkNotNullParameter
        // call: p095ab260.onPathParameter
        // field: p38cb8f46.p095ab260.f7f662005
        return default!;
    }

    public void AtomicMove(pac70412e P0, pac70412e P1)
    {
        // str: "target"
        // str: "source"
        // str: "atomicMove"
        // call: Intrinsics.checkNotNullParameter
        // call: pe2d63d19.atomicMove
        // call: p095ab260.onPathParameter
        // field: p38cb8f46.p095ab260.f7f662005
    }

    public pac70412e Canonicalize(pac70412e P0)
    {
        // str: "path"
        // str: "canonicalize"
        // call: Intrinsics.checkNotNullParameter
        // call: p095ab260.onPathResult
        // call: pe2d63d19.canonicalize
        // call: p095ab260.onPathParameter
        // field: p38cb8f46.p095ab260.f7f662005
        return default!;
    }

    public void CreateDirectory(pac70412e P0, bool P1)
    {
        // str: "dir"
        // str: "createDirectory"
        // call: Intrinsics.checkNotNullParameter
        // call: p095ab260.onPathParameter
        // call: pe2d63d19.createDirectory
        // field: p38cb8f46.p095ab260.f7f662005
    }

    public void CreateSymlink(pac70412e P0, pac70412e P1)
    {
        // str: "target"
        // str: "source"
        // str: "createSymlink"
        // call: p095ab260.onPathParameter
        // call: Intrinsics.checkNotNullParameter
        // call: pe2d63d19.createSymlink
        // field: p38cb8f46.p095ab260.f7f662005
    }

    public pe2d63d19 Delegate()
    {
        // field: p38cb8f46.p095ab260.f7f662005
        return default!;
    }

    public void Delete(pac70412e P0, bool P1)
    {
        // str: "delete"
        // str: "path"
        // call: p095ab260.onPathParameter
        // call: pe2d63d19.delete
        // call: Intrinsics.checkNotNullParameter
        // field: p38cb8f46.p095ab260.f7f662005
    }

    public List<object> List(pac70412e P0)
    {
        // str: "dir"
        // str: "list"
        // call: IEnumerator<object>.next
        // call: CollectionsKt.sort
        // call: ICollection<object>.add
        // call: p095ab260.onPathParameter
        // call: pe2d63d19.list
        // call: IEnumerable<object>.iterator
        // call: p095ab260.onPathResult
        // call: Intrinsics.checkNotNullParameter
        // call: IEnumerator<object>.hasNext
        // call: List<object>.<init>
        // field: p38cb8f46.p095ab260.f7f662005
        // type: List<object>
        return default!;
    }

    public List<object> ListOrNull(pac70412e P0)
    {
        // str: "dir"
        // str: "listOrNull"
        // call: Intrinsics.checkNotNullParameter
        // call: pe2d63d19.listOrNull
        // call: IEnumerator<object>.next
        // call: CollectionsKt.sort
        // call: IEnumerator<object>.hasNext
        // call: ICollection<object>.add
        // call: List<object>.<init>
        // call: IEnumerable<object>.iterator
        // call: p095ab260.onPathParameter
        // call: p095ab260.onPathResult
        // field: p38cb8f46.p095ab260.f7f662005
        // type: List<object>
        return default!;
    }

    public Sequence ListRecursively(pac70412e P0, bool P1)
    {
        // str: "dir"
        // str: "listRecursively"
        // call: p095ab260$peb75c1fd$1.<init>
        // call: p095ab260.onPathParameter
        // call: SequencesKt.map
        // call: pe2d63d19.listRecursively
        // call: Intrinsics.checkNotNullParameter
        // field: p38cb8f46.p095ab260.f7f662005
        // type: p095ab260$peb75c1fd$1
        return default!;
    }

    public p50ca3499 MetadataOrNull(pac70412e P0)
    {
        // str: "metadataOrNull"
        // str: "path"
        // call: pe2d63d19.metadataOrNull
        // call: p50ca3499.m1c1e012b
        // call: p095ab260.onPathResult
        // call: Intrinsics.checkNotNullParameter
        // call: p095ab260.onPathParameter
        // call: p50ca3499.getSymlinkTarget
        // field: p38cb8f46.p095ab260.f7f662005
        return default!;
    }

    public pac70412e OnPathParameter(pac70412e P0, string P1, string P2)
    {
        // str: "path"
        // str: "functionName"
        // str: "parameterName"
        // call: Intrinsics.checkNotNullParameter
        return default!;
    }

    public pac70412e OnPathResult(pac70412e P0, string P1)
    {
        // str: "path"
        // str: "functionName"
        // call: Intrinsics.checkNotNullParameter
        return default!;
    }

    public p223127e3 OpenReadOnly(pac70412e P0)
    {
        // str: "file"
        // str: "openReadOnly"
        // call: pe2d63d19.openReadOnly
        // call: p095ab260.onPathParameter
        // call: Intrinsics.checkNotNullParameter
        // field: p38cb8f46.p095ab260.f7f662005
        return default!;
    }

    public p223127e3 OpenReadWrite(pac70412e P0, bool P1, bool P2)
    {
        // str: "file"
        // str: "openReadWrite"
        // call: p095ab260.onPathParameter
        // call: Intrinsics.checkNotNullParameter
        // call: pe2d63d19.openReadWrite
        // field: p38cb8f46.p095ab260.f7f662005
        return default!;
    }

    public p1eb558b5 Sink(pac70412e P0, bool P1)
    {
        // str: "sink"
        // str: "file"
        // call: p095ab260.onPathParameter
        // call: pe2d63d19.sink
        // call: Intrinsics.checkNotNullParameter
        // field: p38cb8f46.p095ab260.f7f662005
        return default!;
    }

    public pf31bbdd1 Source(pac70412e P0)
    {
        // str: "source"
        // str: "file"
        // call: p095ab260.onPathParameter
        // call: Intrinsics.checkNotNullParameter
        // call: pe2d63d19.source
        // field: p38cb8f46.p095ab260.f7f662005
        return default!;
    }

    public string ToString()
    {
        // call: KClass.getSimpleName
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // call: Reflection.getOrCreateKotlinClass
        // call: object.getClass
        // call: StringBuilder.toString
        // field: p38cb8f46.p095ab260.f7f662005
        // type: StringBuilder
        return string.Empty;
    }

}
