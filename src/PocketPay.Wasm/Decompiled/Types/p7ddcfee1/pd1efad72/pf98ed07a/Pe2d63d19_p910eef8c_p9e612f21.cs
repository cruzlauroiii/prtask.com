namespace WillowMaze.Wasm.Decompiled;

public class Pe2d63d19_p910eef8c_p9e612f21 : Pe2d63d19
{
    public p1eb558b5 AppendingSink(string P0)
    {
        // str: "file"
        // call: Intrinsics.checkNotNullParameter
        // call: p0af9afa4.m2c4cd352
        // call: string.mkdirs
        // call: string.getParentFile
        return default!;
    }

    public void Delete(string P0)
    {
        // str: "file"
        // str: "failed to delete "
        // call: IOException.<init>
        // call: string.exists
        // call: Intrinsics.stringPlus
        // call: Intrinsics.checkNotNullParameter
        // call: string.delete
        // type: IOException
    }

    public void DeleteContents(string P0)
    {
        // str: "not a readable directory: "
        // str: "failed to delete "
        // str: "directory"
        // str: "file"
        // call: Intrinsics.checkNotNullParameter
        // call: Intrinsics.checkNotNullExpressionValue
        // call: pe2d63d19$p910eef8c$p9e612f21.deleteContents
        // call: string.delete
        // call: Intrinsics.stringPlus
        // call: string.listFiles
        // call: string.isDirectory
        // call: IOException.<init>
        // type: IOException
    }

    public bool Exists(string P0)
    {
        // str: "file"
        // call: Intrinsics.checkNotNullParameter
        // call: string.exists
        return false;
    }

    public void Rename(string P0, string P1)
    {
        // str: "failed to rename "
        // str: "to"
        // str: "from"
        // str: " to "
        // call: pe2d63d19$p910eef8c$p9e612f21.delete
        // call: string.renameTo
        // call: StringBuilder.append
        // call: IOException.<init>
        // call: StringBuilder.toString
        // call: Intrinsics.checkNotNullParameter
        // call: StringBuilder.<init>
        // type: StringBuilder
        // type: IOException
    }

    public p1eb558b5 Sink(string P0)
    {
        // str: "file"
        // call: p0af9afa4.m24d48594
        // call: string.getParentFile
        // call: Intrinsics.checkNotNullParameter
        // call: string.mkdirs
        return default!;
    }

    public long Size(string P0)
    {
        // str: "file"
        // call: string.length
        // call: Intrinsics.checkNotNullParameter
        return 0;
    }

    public pf31bbdd1 Source(string P0)
    {
        // str: "file"
        // call: Intrinsics.checkNotNullParameter
        // call: p0af9afa4.m36cd38f4
        return default!;
    }

    public string ToString()
    {
        // str: "FileSystem.SYSTEM"
        return string.Empty;
    }

}
