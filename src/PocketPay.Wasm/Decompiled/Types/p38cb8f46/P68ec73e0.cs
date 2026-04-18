namespace WillowMaze.Wasm.Decompiled;

public class P68ec73e0 : P7413bcb9
{
    private readonly FileSystem F2653a152;
    private readonly FileSystem F390f729d;
    private readonly FileSystem F840fae2d;
    private readonly FileSystem F92f3ee9c;
    private readonly FileSystem Fdcca394e;

    private List<object> M10ae9fc7(pac70412e P0, bool P1)
    {
        // str: "no such file: "
        // str: "failed to list "
        // call: ICollection<object>.add
        // call: IEnumerable<object>.iterator
        // call: StringBuilder.<init>
        // call: List<object>.<init>
        // call: pac70412e.resolve
        // call: Files.exists
        // call: object.toString
        // call: StringBuilder.toString
        // call: IOException.<init>
        // call: CollectionsKt.sort
        // call: PathsKt.listDirectoryEntries$default
        // call: p68ec73e0.m785e254f
        // call: Arrays.copyOf
        // call: FileNotFoundException.<init>
        // call: StringBuilder.append
        // call: IEnumerator<object>.next
        // call: IEnumerator<object>.hasNext
        // type: IOException
        // type: FileNotFoundException
        // type: StringBuilder
        // type: List<object>
        return default!;
    }

    private Path M785e254f(pac70412e P0)
    {
        // str: "nioFileSystem.getPath(toString())"
        // call: Intrinsics.checkNotNullExpressionValue
        // call: pac70412e.toString
        // call: FileSystem.getPath
        // field: p38cb8f46.p68ec73e0.f840fae2d
        return default!;
    }

    public p1eb558b5 AppendingSink(pac70412e P0, bool P1)
    {
        // str: "newOutputStream(this, *options)"
        // str: "file"
        // call: Files.newOutputStream
        // call: p0af9afa4.mf6e04117
        // call: Arrays.copyOf
        // call: Intrinsics.checkNotNullExpressionValue
        // call: p68ec73e0.m785e254f
        // call: ICollection<object>.toArray
        // call: List<object>.add
        // call: Intrinsics.checkNotNullParameter
        // call: CollectionsKt.build
        // call: CollectionsKt.createListBuilder
        // field: java.nio.file.StandardOpenOption.APPEND
        // field: java.nio.file.StandardOpenOption.CREATE
        return default!;
    }

    public void AtomicMove(pac70412e P0, pac70412e P1)
    {
        // str: "source"
        // str: "target"
        // str: "atomic move not supported"
        // str: "move(this, target, *options)"
        // call: FileNotFoundException.<init>
        // call: IOException.<init>
        // call: Intrinsics.checkNotNullParameter
        // call: NoSuchFileException.getMessage
        // call: p68ec73e0.m785e254f
        // call: Arrays.copyOf
        // call: Files.move
        // call: Intrinsics.checkNotNullExpressionValue
        // field: java.nio.file.StandardCopyOption.ATOMIC_MOVE
        // field: java.nio.file.StandardCopyOption.REPLACE_EXISTING
        // type: FileNotFoundException
        // type: IOException
    }

    public pac70412e Canonicalize(pac70412e P0)
    {
        // str: "path"
        // str: "no such file: "
        // str: "path.resolve().toRealPath()"
        // call: StringBuilder.toString
        // call: StringBuilder.append
        // call: Intrinsics.checkNotNullParameter
        // call: p68ec73e0.m785e254f
        // call: Path.toRealPath
        // call: Intrinsics.checkNotNullExpressionValue
        // call: pac70412e$p910eef8c.ma89e983a
        // call: StringBuilder.<init>
        // call: FileNotFoundException.<init>
        // field: p38cb8f46.pac70412e.f910eef8c
        // type: FileNotFoundException
        // type: StringBuilder
        return default!;
    }

    public void CreateDirectory(pac70412e P0, bool P1)
    {
        // str: "dir"
        // str: "failed to create directory: "
        // str: "createDirectory(this, *attributes)"
        // str: " already exist."
        // call: StringBuilder.append
        // call: p50ca3499.isDirectory
        // call: Intrinsics.checkNotNullParameter
        // call: StringBuilder.<init>
        // call: IOException.<init>
        // call: StringBuilder.toString
        // call: p68ec73e0.metadataOrNull
        // call: p68ec73e0.m785e254f
        // call: Arrays.copyOf
        // call: Files.createDirectory
        // call: Intrinsics.checkNotNullExpressionValue
        // type: StringBuilder
        // type: IOException
    }

    public void CreateSymlink(pac70412e P0, pac70412e P1)
    {
        // str: "target"
        // str: "createSymbolicLink(this, target, *attributes)"
        // str: "source"
        // call: Intrinsics.checkNotNullParameter
        // call: Intrinsics.checkNotNullExpressionValue
        // call: p68ec73e0.m785e254f
        // call: Files.createSymbolicLink
        // call: Arrays.copyOf
    }

    public void Delete(pac70412e P0, bool P1)
    {
        // str: "no such file: "
        // str: "interrupted"
        // str: "path"
        // str: "failed to delete "
        // call: StringBuilder.append
        // call: InterruptedIOException.<init>
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // call: Arrays.copyOf
        // call: Intrinsics.checkNotNullParameter
        // call: Thread.interrupted
        // call: Files.exists
        // call: FileNotFoundException.<init>
        // call: IOException.<init>
        // call: p68ec73e0.m785e254f
        // call: Files.delete
        // type: StringBuilder
        // type: IOException
        // type: FileNotFoundException
        // type: InterruptedIOException
    }

    public List<object> List(pac70412e P0)
    {
        // str: "dir"
        // call: Intrinsics.checkNotNullParameter
        // call: p68ec73e0.m10ae9fc7
        // call: Intrinsics.checkNotNull
        return default!;
    }

    public List<object> ListOrNull(pac70412e P0)
    {
        // str: "dir"
        // call: p68ec73e0.m10ae9fc7
        // call: Intrinsics.checkNotNullParameter
        return default!;
    }

    public p50ca3499 MetadataOrNull(pac70412e P0)
    {
        // str: "path"
        // call: p68ec73e0.metadataOrNull
        // call: p68ec73e0.m785e254f
        // call: Intrinsics.checkNotNullParameter
        return default!;
    }

    public p223127e3 OpenReadOnly(pac70412e P0)
    {
        // str: "no such file: "
        // str: "file"
        // str: "channel"
        // call: StringBuilder.append
        // call: Intrinsics.checkNotNullParameter
        // call: p68ec73e0.m785e254f
        // call: FileChannel.open
        // call: ped3c8257.<init>
        // call: FileNotFoundException.<init>
        // call: StringBuilder.<init>
        // call: Intrinsics.checkNotNullExpressionValue
        // call: StringBuilder.toString
        // field: java.nio.file.StandardOpenOption.READ
        // type: StringBuilder
        // type: ped3c8257
        // type: FileNotFoundException
        return default!;
    }

    public p223127e3 OpenReadWrite(pac70412e P0, bool P1, bool P2)
    {
        // str: "no such file: "
        // str: "channel"
        // str: "Cannot require mustCreate and mustExist at the same time."
        // str: "file"
        // call: List<object>.add
        // call: StringBuilder.append
        // call: ped3c8257.<init>
        // call: StringBuilder.toString
        // call: CollectionsKt.build
        // call: p68ec73e0.m785e254f
        // call: ICollection<object>.toArray
        // call: Arrays.copyOf
        // call: FileChannel.open
        // call: object.toString
        // call: Intrinsics.checkNotNullExpressionValue
        // call: Intrinsics.checkNotNullParameter
        // call: FileNotFoundException.<init>
        // call: StringBuilder.<init>
        // call: CollectionsKt.createListBuilder
        // call: IllegalArgumentException.<init>
        // field: java.nio.file.StandardOpenOption.CREATE_NEW
        // field: java.nio.file.StandardOpenOption.WRITE
        // field: java.nio.file.StandardOpenOption.CREATE
        // field: java.nio.file.StandardOpenOption.READ
        // type: IllegalArgumentException
        // type: FileNotFoundException
        // type: StringBuilder
        // type: ped3c8257
        return default!;
    }

    public p1eb558b5 Sink(pac70412e P0, bool P1)
    {
        // str: "file"
        // str: "newOutputStream(this, *options)"
        // str: "no such file: "
        // call: StringBuilder.<init>
        // call: CollectionsKt.createListBuilder
        // call: StringBuilder.toString
        // call: Intrinsics.checkNotNullParameter
        // call: List<object>.add
        // call: CollectionsKt.build
        // call: p68ec73e0.m785e254f
        // call: ICollection<object>.toArray
        // call: Arrays.copyOf
        // call: Files.newOutputStream
        // call: Intrinsics.checkNotNullExpressionValue
        // call: p0af9afa4.mf6e04117
        // call: FileNotFoundException.<init>
        // call: StringBuilder.append
        // field: java.nio.file.StandardOpenOption.CREATE_NEW
        // type: StringBuilder
        // type: FileNotFoundException
        return default!;
    }

    public pf31bbdd1 Source(pac70412e P0)
    {
        // str: "newInputStream(this, *options)"
        // str: "no such file: "
        // str: "file"
        // call: Intrinsics.checkNotNullParameter
        // call: p68ec73e0.m785e254f
        // call: Arrays.copyOf
        // call: Files.newInputStream
        // call: Intrinsics.checkNotNullExpressionValue
        // call: p0af9afa4.m36cd38f4
        // call: FileNotFoundException.<init>
        // call: StringBuilder.toString
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // type: StringBuilder
        // type: FileNotFoundException
        return default!;
    }

    public string ToString()
    {
        // call: KClass.getSimpleName
        // call: Intrinsics.checkNotNull
        // call: Reflection.getOrCreateKotlinClass
        // call: object.getClass
        // field: p38cb8f46.p68ec73e0.f840fae2d
        return string.Empty;
    }

}
