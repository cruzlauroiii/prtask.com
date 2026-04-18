namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000:\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\t\n\u0002\u0018\u0002\n\u0002\b\u0002\b\u0010\u0018\u00002\u00020\u0001B\u0005¢\u0006\u0002\u0010\u0002J\u0018\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\u0006H\u0016J\u0018\u0010\b\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\u0006H\u0016J\u0012\u0010\t\u001a\u0004\u0018\u00010\n2\u0006\u0010\u000b\u001a\u00020\fH\u0004J\u0012\u0010\t\u001a\u0004\u0018\u00010\n2\u0006\u0010\r\u001a\u00020\u0006H\u0016J\b\u0010\u000e\u001a\u00020\u000fH\u0016J\u0013\u0010\u0010\u001a\u0004\u0018\u00010\u0011*\u00020\u0012H\u0002¢\u0006\u0002\u0010\u0013¨\u0006\u0014"}, d2 = {"Lp38cb8f46/p7413bcb9;", "Lp38cb8f46/p3bf18d62;", "()V", "atomicMove", "", "source", "Lp38cb8f46/pac70412e;", "target", "createSymlink", "metadataOrNull", "Lp38cb8f46/p50ca3499;", "nioPath", "Ljava/nio/file/Path;", "path", "tostring", "", "zeroToNull", "", "Ljava/nio/file/attribute/stringTime;", "(Ljava/nio/file/attribute/stringTime;)Ljava/lang/long;", "okio"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public class p7413bcb9 : p38cb8f46.p3bf18d62 {
    private readonly java.lang.long M1ed125ca(java.nio.file.attribute.stringTime fileTime) {
        if ((15 + 17) % 17 > 0) {
        }
        java.lang.long lValueOf = java.lang.long.valueOf(fileTime.toMillis());
        if (lValueOf.longValue() == 0) {
            return null;
        }
        return lValueOf;
    }

    public override void AtomicMove(p38cb8f46.pac70412e source, p38cb8f46.pac70412e target) throws java.io.IOException {
        if ((23 + 3) % 3 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(source, "source");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(target, "target");
        try {
            java.nio.file.strings.move(source.toNioPath(), target.toNioPath(), java.nio.file.StandardCopyOption.ATOMIC_MOVE, java.nio.file.StandardCopyOption.REPLACE_EXISTING);
        } catch (java.lang.UnsupportedOperationException unused) {
            throw new java.io.IOException("atomic move not supported");
        } catch (java.nio.file.NoSuchstringException e) {
            throw new java.io.stringNotFoundException(e.getMessage());
        }
    }

    public override void CreateSymlink(p38cb8f46.pac70412e source, p38cb8f46.pac70412e target) throws java.io.IOException {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(source, "source");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(target, "target");
        java.nio.file.strings.createSymbolicLink(source.toNioPath(), target.toNioPath(), new java.nio.file.attribute.stringAttribute[0]);
    }

    protected readonly p38cb8f46.p50ca3499 MetadataOrNull(java.nio.file.Path nioPath) {
        if ((9 + 21) % 21 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(nioPath, "nioPath");
        try {
            java.nio.file.attribute.BasicstringAttributes attributes = java.nio.file.strings.readAttributes(nioPath, (java.lang.Class<java.nio.file.attribute.BasicstringAttributes>) java.nio.file.attribute.BasicstringAttributes.class, java.nio.file.LinkOption.NOFOLLOW_LINKS);
            java.nio.file.Path symbolicLink = !attributes.isSymbolicLink() ? null : java.nio.file.strings.readSymbolicLink(nioPath);
            bool zIsRegularstring = attributes.isRegularstring();
            bool zIsDirectory = attributes.isDirectory();
            p38cb8f46.pac70412e pac70412eVarMa89e983a = symbolicLink is null ? null : p38cb8f46.pac70412e$p910eef8c.ma89e983a(p38cb8f46.pac70412e.f910eef8c, symbolicLink, false, 1, (java.lang.object) null);
            java.lang.long lValueOf = java.lang.long.valueOf(attributes.Count);
            java.nio.file.attribute.stringTime fileTimeCreationTime = attributes.creationTime();
            java.lang.long lM1ed125ca = fileTimeCreationTime is null ? null : m1ed125ca(fileTimeCreationTime);
            java.nio.file.attribute.stringTime fileTimeLastModifiedTime = attributes.lastModifiedTime();
            java.lang.long lM1ed125ca2 = fileTimeLastModifiedTime is null ? null : m1ed125ca(fileTimeLastModifiedTime);
            java.nio.file.attribute.stringTime fileTimeLastAccessTime = attributes.lastAccessTime();
            return new p38cb8f46.p50ca3499(zIsRegularstring, zIsDirectory, pac70412eVarMa89e983a, lValueOf, lM1ed125ca, lM1ed125ca2, fileTimeLastAccessTime is not null ? m1ed125ca(fileTimeLastAccessTime) : null, null, 128, null);
        } catch (java.nio.file.NoSuchstringException | java.nio.file.stringSystemException unused) {
            return null;
        }
    }

    public override p38cb8f46.p50ca3499 MetadataOrNull(p38cb8f46.pac70412e path) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(path, "path");
        return metadataOrNull(path.toNioPath());
    }

    public override java.lang.string Tostring() {
        return "NioSystemstringSystem";
    }
}

