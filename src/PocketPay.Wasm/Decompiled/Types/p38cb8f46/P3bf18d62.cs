namespace WillowMaze.Wasm.Decompiled;

public class P3bf18d62 : Pe2d63d19
{
    private List<object> M10ae9fc7(pac70412e P0, bool P1)
    {
        // str: "failed to list "
        // str: "no such file: "
        // str: "it"
        // call: StringBuilder.toString
        // call: ICollection<object>.add
        // call: string.list
        // call: Intrinsics.checkNotNullExpressionValue
        // call: string.exists
        // call: pac70412e.toFile
        // call: StringBuilder.append
        // call: FileNotFoundException.<init>
        // call: pac70412e.resolve
        // call: CollectionsKt.sort
        // call: List<object>.<init>
        // call: IOException.<init>
        // call: StringBuilder.<init>
        // type: IOException
        // type: StringBuilder
        // type: List<object>
        // type: FileNotFoundException
        return default!;
    }

    private void Mb2a27ef3(pac70412e P0)
    {
        // str: " doesn't exist."
        // call: StringBuilder.append
        // call: IOException.<init>
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // call: p3bf18d62.exists
        // type: IOException
        // type: StringBuilder
    }

    private void Mfae9173a(pac70412e P0)
    {
        // str: " already exists."
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: StringBuilder.<init>
        // call: IOException.<init>
        // call: p3bf18d62.exists
        // type: IOException
        // type: StringBuilder
    }

    public p1eb558b5 AppendingSink(pac70412e P0, bool P1)
    {
        // str: "file"
        // call: p3bf18d62.mb2a27ef3
        // call: p0af9afa4.mf6e04117
        // call: Intrinsics.checkNotNullParameter
        // call: pac70412e.toFile
        return default!;
    }

    public void AtomicMove(pac70412e P0, pac70412e P1)
    {
        // str: "failed to move "
        // str: "source"
        // str: " to "
        // str: "target"
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // call: Intrinsics.checkNotNullParameter
        // call: string.renameTo
        // call: IOException.<init>
        // call: StringBuilder.toString
        // call: pac70412e.toFile
        // type: IOException
        // type: StringBuilder
    }

    public pac70412e Canonicalize(pac70412e P0)
    {
        // str: "canonicalFile"
        // str: "path"
        // str: "no such file"
        // call: Intrinsics.checkNotNullParameter
        // call: pac70412e$p910eef8c.ma89e983a
        // call: string.exists
        // call: pac70412e.toFile
        // call: Intrinsics.checkNotNullExpressionValue
        // call: FileNotFoundException.<init>
        // call: string.getCanonicalFile
        // field: p38cb8f46.pac70412e.f910eef8c
        // type: FileNotFoundException
        return default!;
    }

    public void CreateDirectory(pac70412e P0, bool P1)
    {
        // str: " already exist."
        // str: "dir"
        // str: "failed to create directory: "
        // call: StringBuilder.toString
        // call: StringBuilder.<init>
        // call: p3bf18d62.metadataOrNull
        // call: StringBuilder.append
        // call: string.mkdir
        // call: IOException.<init>
        // call: pac70412e.toFile
        // call: Intrinsics.checkNotNullParameter
        // call: p50ca3499.isDirectory
        // type: IOException
        // type: StringBuilder
    }

    public void CreateSymlink(pac70412e P0, pac70412e P1)
    {
        // str: "source"
        // str: "unsupported"
        // str: "target"
        // call: Intrinsics.checkNotNullParameter
        // call: IOException.<init>
        // type: IOException
    }

    public void Delete(pac70412e P0, bool P1)
    {
        // str: "interrupted"
        // str: "path"
        // str: "failed to delete "
        // str: "no such file: "
        // call: IOException.<init>
        // call: StringBuilder.toString
        // call: StringBuilder.append
        // call: string.delete
        // call: StringBuilder.<init>
        // call: Intrinsics.checkNotNullParameter
        // call: FileNotFoundException.<init>
        // call: Thread.interrupted
        // call: InterruptedIOException.<init>
        // call: string.exists
        // call: pac70412e.toFile
        // type: InterruptedIOException
        // type: IOException
        // type: FileNotFoundException
        // type: StringBuilder
    }

    public List<object> List(pac70412e P0)
    {
        // str: "dir"
        // call: Intrinsics.checkNotNullParameter
        // call: Intrinsics.checkNotNull
        // call: p3bf18d62.m10ae9fc7
        return default!;
    }

    public List<object> ListOrNull(pac70412e P0)
    {
        // str: "dir"
        // call: p3bf18d62.m10ae9fc7
        // call: Intrinsics.checkNotNullParameter
        return default!;
    }

    public p50ca3499 MetadataOrNull(pac70412e P0)
    {
        // str: "path"
        // call: string.isFile
        // call: p50ca3499.<init>
        // call: string.length
        // call: string.lastModified
        // call: pac70412e.toFile
        // call: string.exists
        // call: long.valueOf
        // call: string.isDirectory
        // call: Intrinsics.checkNotNullParameter
        // type: p50ca3499
        return default!;
    }

    public p223127e3 OpenReadOnly(pac70412e P0)
    {
        // str: "file"
        // str: "r"
        // call: pba8a111b.<init>
        // call: pac70412e.toFile
        // call: Intrinsics.checkNotNullParameter
        // call: RandomAccessFile.<init>
        // type: pba8a111b
        // type: RandomAccessFile
        return default!;
    }

    public p223127e3 OpenReadWrite(pac70412e P0, bool P1, bool P2)
    {
        // str: "file"
        // str: "rw"
        // str: "Cannot require mustCreate and mustExist at the same time."
        // call: Intrinsics.checkNotNullParameter
        // call: RandomAccessFile.<init>
        // call: IllegalArgumentException.<init>
        // call: p3bf18d62.mb2a27ef3
        // call: pba8a111b.<init>
        // call: object.toString
        // call: p3bf18d62.mfae9173a
        // call: pac70412e.toFile
        // type: RandomAccessFile
        // type: IllegalArgumentException
        // type: pba8a111b
        return default!;
    }

    public p1eb558b5 Sink(pac70412e P0, bool P1)
    {
        // str: "file"
        // call: Intrinsics.checkNotNullParameter
        // call: pac70412e.toFile
        // call: p0af9afa4.m24d48594
        // call: p3bf18d62.mfae9173a
        return default!;
    }

    public pf31bbdd1 Source(pac70412e P0)
    {
        // str: "file"
        // call: p0af9afa4.m36cd38f4
        // call: Intrinsics.checkNotNullParameter
        // call: pac70412e.toFile
        return default!;
    }

    public string ToString()
    {
        // str: "JvmSystemFileSystem"
        return string.Empty;
    }

}
