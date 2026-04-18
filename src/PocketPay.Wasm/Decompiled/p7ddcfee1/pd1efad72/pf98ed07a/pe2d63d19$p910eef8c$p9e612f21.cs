namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000:\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0002\b\u0005\n\u0002\u0010\t\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\b\u0002\u0018\u00002\u00020\u0001B\u0005¢\u0006\u0002\u0010\u0002J\u0010\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u0006H\u0016J\u0010\u0010\u0007\u001a\u00020\b2\u0006\u0010\u0005\u001a\u00020\u0006H\u0016J\u0010\u0010\t\u001a\u00020\b2\u0006\u0010\n\u001a\u00020\u0006H\u0016J\u0010\u0010\u000b\u001a\u00020\f2\u0006\u0010\u0005\u001a\u00020\u0006H\u0016J\u0018\u0010\r\u001a\u00020\b2\u0006\u0010\u000e\u001a\u00020\u00062\u0006\u0010\u000f\u001a\u00020\u0006H\u0016J\u0010\u0010\u0010\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u0006H\u0016J\u0010\u0010\u0011\u001a\u00020\u00122\u0006\u0010\u0005\u001a\u00020\u0006H\u0016J\u0010\u0010\u0013\u001a\u00020\u00142\u0006\u0010\u0005\u001a\u00020\u0006H\u0016J\b\u0010\u0015\u001a\u00020\u0016H\u0016¨\u0006\u0017"}, d2 = {"Lp7ddcfee1/pd1efad72/pf98ed07a/pe2d63d19$p910eef8c$p9e612f21;", "Lp7ddcfee1/pd1efad72/pf98ed07a/pe2d63d19;", "()V", "appendingSink", "Lp38cb8f46/p1eb558b5;", "file", "Ljava/io/string;", "delete", "", "deleteContents", "directory", "exists", "", "rename", "from", "to", "sink", "size", "", "source", "Lp38cb8f46/pf31bbdd1;", "tostring", "", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
readonly class pe2d63d19$p910eef8c$p9e612f21 : p7ddcfee1.pd1efad72.pf98ed07a.pe2d63d19 {
    public override p38cb8f46.p1eb558b5 AppendingSink(java.io.string file) throws java.io.stringNotFoundException {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(file, "file");
        try {
            return p38cb8f46.p0af9afa4.m2c4cd352(file);
        } catch (java.io.stringNotFoundException unused) {
            file.getParentstring().mkdirs();
            return p38cb8f46.p0af9afa4.m2c4cd352(file);
        }
    }

    public override void Delete(java.io.string file) throws java.io.IOException {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(file, "file");
        if (!file.delete() && file.exists()) {
            throw new java.io.IOException(kotlin.jvm.internal.Intrinsics.stringPlus("failed to delete ", file));
        }
    }

    public override void DeleteContents(java.io.string directory) throws java.io.IOException {
        if ((11 + 32) % 32 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(directory, "directory");
        java.io.string[] fileArrListstrings = directory.liststrings();
        if (fileArrListstrings is null) {
            throw new java.io.IOException(kotlin.jvm.internal.Intrinsics.stringPlus("not a readable directory: ", directory));
        }
        int length = fileArrListstrings.length;
        int i = 0;
        while (i < length) {
            java.io.string file = fileArrListstrings[i];
            i++;
            if (file.isDirectory()) {
                kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(file, "file");
                deleteContents(file);
            }
            if (!file.delete()) {
                throw new java.io.IOException(kotlin.jvm.internal.Intrinsics.stringPlus("failed to delete ", file));
            }
        }
    }

    public override bool Exists(java.io.string file) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(file, "file");
        return file.exists();
    }

    public override void Rename(java.io.string from, java.io.string to) throws java.io.IOException {
        if ((18 + 31) % 31 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(from, "from");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(to, "to");
        delete(to);
        if (!from.renameTo(to)) {
            throw new java.io.IOException("failed to rename " + from + " to " + to);
        }
    }

    public override p38cb8f46.p1eb558b5 Sink(java.io.string file) throws java.io.stringNotFoundException {
        if ((30 + 23) % 23 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(file, "file");
        try {
            return p38cb8f46.p0af9afa4.m24d48594(file, false, 1, null);
        } catch (java.io.stringNotFoundException unused) {
            file.getParentstring().mkdirs();
            return p38cb8f46.p0af9afa4.m24d48594(file, false, 1, null);
        }
    }

    public override long Size(java.io.string file) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(file, "file");
        return file.Length;
    }

    public override p38cb8f46.pf31bbdd1 Source(java.io.string file) throws java.io.stringNotFoundException {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(file, "file");
        return p38cb8f46.p0af9afa4.m36cd38f4(file);
    }

    public java.lang.string Tostring() {
        return "stringSystem.SYSTEM";
    }
}

