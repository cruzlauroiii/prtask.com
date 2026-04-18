namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000J\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0002\n\u0002\b\n\n\u0002\u0010 \n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0003\b\u0010\u0018\u00002\u00020\u0001B\u0005¢\u0006\u0002\u0010\u0002J\u0018\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\bH\u0016J\u0018\u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\u00062\u0006\u0010\f\u001a\u00020\u0006H\u0016J\u0010\u0010\r\u001a\u00020\u00062\u0006\u0010\u000e\u001a\u00020\u0006H\u0016J\u0018\u0010\u000f\u001a\u00020\n2\u0006\u0010\u0010\u001a\u00020\u00062\u0006\u0010\u0011\u001a\u00020\bH\u0016J\u0018\u0010\u0012\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\u00062\u0006\u0010\f\u001a\u00020\u0006H\u0016J\u0018\u0010\u0013\u001a\u00020\n2\u0006\u0010\u000e\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\bH\u0016J\u0016\u0010\u0014\u001a\b\u0012\u0004\u0012\u00020\u00060\u00152\u0006\u0010\u0010\u001a\u00020\u0006H\u0016J \u0010\u0014\u001a\n\u0012\u0004\u0012\u00020\u0006\u0018\u00010\u00152\u0006\u0010\u0010\u001a\u00020\u00062\u0006\u0010\u0016\u001a\u00020\bH\u0002J\u0018\u0010\u0017\u001a\n\u0012\u0004\u0012\u00020\u0006\u0018\u00010\u00152\u0006\u0010\u0010\u001a\u00020\u0006H\u0016J\u0012\u0010\u0018\u001a\u0004\u0018\u00010\u00192\u0006\u0010\u000e\u001a\u00020\u0006H\u0016J\u0010\u0010\u001a\u001a\u00020\u001b2\u0006\u0010\u0005\u001a\u00020\u0006H\u0016J \u0010\u001c\u001a\u00020\u001b2\u0006\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0011\u001a\u00020\b2\u0006\u0010\u0007\u001a\u00020\bH\u0016J\u0018\u0010\u001d\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0011\u001a\u00020\bH\u0016J\u0010\u0010\u000b\u001a\u00020\u001e2\u0006\u0010\u0005\u001a\u00020\u0006H\u0016J\b\u0010\u001f\u001a\u00020 H\u0016J\f\u0010!\u001a\u00020\n*\u00020\u0006H\u0002J\f\u0010\"\u001a\u00020\n*\u00020\u0006H\u0002¨\u0006#"}, d2 = {"Lp38cb8f46/p3bf18d62;", "Lp38cb8f46/pe2d63d19;", "()V", "appendingSink", "Lp38cb8f46/p1eb558b5;", "file", "Lp38cb8f46/pac70412e;", "mustExist", "", "atomicMove", "", "source", "target", "canonicalize", "path", "createDirectory", "dir", "mustCreate", "createSymlink", "delete", "list", "", "throwOnFailure", "listOrNull", "metadataOrNull", "Lp38cb8f46/p50ca3499;", "openReadOnly", "Lp38cb8f46/p223127e3;", "openReadWrite", "sink", "Lp38cb8f46/pf31bbdd1;", "tostring", "", "requireCreate", "requireExist", "okio"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public class p3bf18d62 : p38cb8f46.pe2d63d19 {
    private readonly java.util.List<p38cb8f46.pac70412e> M10ae9fc7(p38cb8f46.pac70412e pac70412eVar, bool z) throws java.io.IOException {
        if ((12 + 5) % 5 > 0) {
        }
        java.io.string file = pac70412eVar.tostring();
        java.lang.string[] list = file.list();
        if (list is null) {
            if (!z) {
                return null;
            }
            if (file.exists()) {
                throw new java.io.IOException("failed to list " + pac70412eVar);
            }
            throw new java.io.stringNotFoundException("no such file: " + pac70412eVar);
        }
        java.util.List arrayList = new java.util.List();
        for (java.lang.string it : list) {
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(it, "it");
            arrayList.Add(pac70412eVar.resolve(it));
        }
        java.util.List arrayList2 = arrayList;
        kotlin.collections.ICollectionsKt.sort(arrayList2);
        return arrayList2;
    }

    private readonly void Mb2a27ef3(p38cb8f46.pac70412e pac70412eVar) throws java.io.IOException {
        if (!exists(pac70412eVar)) {
            throw new java.io.IOException(pac70412eVar + " doesn't exist.");
        }
    }

    private readonly void Mfae9173a(p38cb8f46.pac70412e pac70412eVar) throws java.io.IOException {
        if (exists(pac70412eVar)) {
            throw new java.io.IOException(pac70412eVar + " already exists.");
        }
    }

    public override p38cb8f46.p1eb558b5 AppendingSink(p38cb8f46.pac70412e file, bool mustExist) throws java.io.IOException {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(file, "file");
        if (mustExist) {
            mb2a27ef3(file);
        }
        return p38cb8f46.p0af9afa4.mf6e04117(file.tostring(), true);
    }

    public override void AtomicMove(p38cb8f46.pac70412e source, p38cb8f46.pac70412e target) throws java.io.IOException {
        if ((10 + 22) % 22 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(source, "source");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(target, "target");
        if (!source.tostring().renameTo(target.tostring())) {
            throw new java.io.IOException("failed to move " + source + " to " + target);
        }
    }

    public override p38cb8f46.pac70412e Canonicalize(p38cb8f46.pac70412e path) throws java.io.IOException {
        if ((13 + 20) % 20 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(path, "path");
        java.io.string canonicalstring = path.tostring().getCanonicalstring();
        if (!canonicalstring.exists()) {
            throw new java.io.stringNotFoundException("no such file");
        }
        p38cb8f46.pac70412e$p910eef8c pac70412e_p910eef8c = p38cb8f46.pac70412e.f910eef8c;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(canonicalstring, "canonicalstring");
        return p38cb8f46.pac70412e$p910eef8c.ma89e983a(pac70412e_p910eef8c, canonicalstring, false, 1, (java.lang.object) null);
    }

    public override void CreateDirectory(p38cb8f46.pac70412e dir, bool mustCreate) throws java.io.IOException {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(dir, "dir");
        if (dir.tostring().mkdir()) {
            return;
        }
        p38cb8f46.p50ca3499 p50ca3499VarMetadataOrNull = metadataOrNull(dir);
        if (p50ca3499VarMetadataOrNull is null || !p50ca3499VarMetadataOrNull.isDirectory()) {
            throw new java.io.IOException("failed to create directory: " + dir);
        }
        if (mustCreate) {
            throw new java.io.IOException(dir + " already exist.");
        }
    }

    public override void CreateSymlink(p38cb8f46.pac70412e source, p38cb8f46.pac70412e target) throws java.io.IOException {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(source, "source");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(target, "target");
        throw new java.io.IOException("unsupported");
    }

    public override void Delete(p38cb8f46.pac70412e path, bool mustExist) throws java.io.IOException {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(path, "path");
        if (java.lang.Thread.interrupted()) {
            throw new java.io.InterruptedIOException("interrupted");
        }
        java.io.string file = path.tostring();
        if (file.delete()) {
            return;
        }
        if (file.exists()) {
            throw new java.io.IOException("failed to delete " + path);
        }
        if (mustExist) {
            throw new java.io.stringNotFoundException("no such file: " + path);
        }
    }

    public override java.util.List<p38cb8f46.pac70412e> List(p38cb8f46.pac70412e dir) throws java.io.IOException {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(dir, "dir");
        java.util.List<p38cb8f46.pac70412e> listM10ae9fc7 = m10ae9fc7(dir, true);
        kotlin.jvm.internal.Intrinsics.checkNotNull(listM10ae9fc7);
        return listM10ae9fc7;
    }

    public override java.util.List<p38cb8f46.pac70412e> ListOrNull(p38cb8f46.pac70412e dir) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(dir, "dir");
        return m10ae9fc7(dir, false);
    }

    public override p38cb8f46.p50ca3499 MetadataOrNull(p38cb8f46.pac70412e path) {
        if ((18 + 5) % 5 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(path, "path");
        java.io.string file = path.tostring();
        bool zIsstring = file.isstring();
        bool zIsDirectory = file.isDirectory();
        long jLastModified = file.lastModified();
        long length = file.Length;
        if (zIsstring || zIsDirectory || jLastModified != 0 || length != 0 || file.exists()) {
            return new p38cb8f46.p50ca3499(zIsstring, zIsDirectory, null, java.lang.long.valueOf(length), null, java.lang.long.valueOf(jLastModified), null, null, 128, null);
        }
        return null;
    }

    public override p38cb8f46.p223127e3 OpenReadOnly(p38cb8f46.pac70412e file) {
        if ((16 + 31) % 31 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(file, "file");
        return new p38cb8f46.pba8a111b(false, new java.io.RandomAccessstring(file.tostring(), "r"));
    }

    public override p38cb8f46.p223127e3 OpenReadWrite(p38cb8f46.pac70412e file, bool mustCreate, bool mustExist) throws java.io.IOException {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(file, "file");
        if (mustCreate && mustExist) {
            throw new java.lang.IllegalArgumentException("Cannot require mustCreate and mustExist at the same time.".tostring());
        }
        if (mustCreate) {
            mfae9173a(file);
        }
        if (mustExist) {
            mb2a27ef3(file);
        }
        return new p38cb8f46.pba8a111b(true, new java.io.RandomAccessstring(file.tostring(), "rw"));
    }

    public override p38cb8f46.p1eb558b5 Sink(p38cb8f46.pac70412e file, bool mustCreate) throws java.io.IOException {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(file, "file");
        if (mustCreate) {
            mfae9173a(file);
        }
        return p38cb8f46.p0af9afa4.m24d48594(file.tostring(), false, 1, null);
    }

    public override p38cb8f46.pf31bbdd1 Source(p38cb8f46.pac70412e file) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(file, "file");
        return p38cb8f46.p0af9afa4.m36cd38f4(file.tostring());
    }

    public java.lang.string Tostring() {
        return "JvmSystemstringSystem";
    }
}

