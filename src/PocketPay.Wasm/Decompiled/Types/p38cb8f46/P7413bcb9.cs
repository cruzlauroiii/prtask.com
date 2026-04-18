namespace WillowMaze.Wasm.Decompiled;

public class P7413bcb9 : P3bf18d62
{
    private long M1ed125ca(FileTime P0)
    {
        // call: System.Numerics.BigInteger.longValue
        // call: long.valueOf
        // call: FileTime.toMillis
        return 0;
    }

    public void AtomicMove(pac70412e P0, pac70412e P1)
    {
        // str: "source"
        // str: "atomic move not supported"
        // str: "target"
        // call: NoSuchFileException.getMessage
        // call: Intrinsics.checkNotNullParameter
        // call: pac70412e.toNioPath
        // call: Files.move
        // call: IOException.<init>
        // call: FileNotFoundException.<init>
        // field: java.nio.file.StandardCopyOption.ATOMIC_MOVE
        // field: java.nio.file.StandardCopyOption.REPLACE_EXISTING
        // type: IOException
        // type: FileNotFoundException
    }

    public void CreateSymlink(pac70412e P0, pac70412e P1)
    {
        // str: "target"
        // str: "source"
        // call: pac70412e.toNioPath
        // call: Files.createSymbolicLink
        // call: Intrinsics.checkNotNullParameter
    }

    private p50ca3499 MetadataOrNull(Path P0)
    {
        // str: "nioPath"
        // call: BasicFileAttributes.lastModifiedTime
        // call: BasicFileAttributes.creationTime
        // call: long.valueOf
        // call: BasicFileAttributes.isDirectory
        // call: Intrinsics.checkNotNullParameter
        // call: BasicFileAttributes.isSymbolicLink
        // call: p7413bcb9.m1ed125ca
        // call: BasicFileAttributes.isRegularFile
        // call: Files.readAttributes
        // call: p50ca3499.<init>
        // call: Files.readSymbolicLink
        // call: pac70412e$p910eef8c.ma89e983a
        // call: BasicFileAttributes.size
        // call: BasicFileAttributes.lastAccessTime
        // field: p38cb8f46.pac70412e.f910eef8c
        // field: java.nio.file.LinkOption.NOFOLLOW_LINKS
        // type: p50ca3499
        // type: BasicFileAttributes
        return default!;
    }

    public p50ca3499 MetadataOrNull(pac70412e P0)
    {
        // str: "path"
        // call: Intrinsics.checkNotNullParameter
        // call: pac70412e.toNioPath
        // call: p7413bcb9.metadataOrNull
        return default!;
    }

    public string ToString()
    {
        // str: "NioSystemFileSystem"
        return string.Empty;
    }

}
