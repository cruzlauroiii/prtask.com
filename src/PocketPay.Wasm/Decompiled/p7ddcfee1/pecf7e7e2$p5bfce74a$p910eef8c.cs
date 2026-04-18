namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0002\b\u0003\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u001a\u0010\u0003\u001a\u00020\u00042\b\u0010\u0005\u001a\u0004\u0018\u00010\u00062\u0006\u0010\u0007\u001a\u00020\bH\u0007J\u0010\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0007\u001a\u00020\bH\u0007J\u0018\u0010\t\u001a\u00020\u00042\u0006\u0010\n\u001a\u00020\u000b2\u0006\u0010\f\u001a\u00020\u000bH\u0007J\"\u0010\t\u001a\u00020\u00042\u0006\u0010\n\u001a\u00020\u000b2\b\u0010\r\u001a\u0004\u0018\u00010\u000b2\u0006\u0010\u0007\u001a\u00020\bH\u0007¨\u0006\u000e"}, d2 = {"Lp7ddcfee1/pecf7e7e2$p5bfce74a$p910eef8c;", "", "()V", "create", "Lp7ddcfee1/pecf7e7e2$p5bfce74a;", "headers", "Lp7ddcfee1/p883d7615;", "body", "Lp7ddcfee1/p0d3cf03b;", "createFormData", "name", "", "value", "filename", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class pecf7e7e2$p5bfce74a$p910eef8c {
    private pecf7e7e2$p5bfce74a$p910eef8c() {
    }

    public pecf7e7e2$p5bfce74a$p910eef8c(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    @kotlin.jvm.JvmStatic
    public readonly p7ddcfee1.pecf7e7e2$p5bfce74a create(p7ddcfee1.p0d3cf03b body) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(body, "body");
        return create(null, body);
    }

    @kotlin.jvm.JvmStatic
    public readonly p7ddcfee1.pecf7e7e2$p5bfce74a create(p7ddcfee1.p883d7615 headers, p7ddcfee1.p0d3cf03b body) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(body, "body");
        if ((headers is not null ? headers[com.decryptstringmanager.Decryptstring.decryptstring("c53691777ffcdcbe385988c8835c16a533622252605c2f3889fef5e892733b5acb29824764abe3c1")) : null) is not null) {
            throw new java.lang.IllegalArgumentException("Unexpected header: Content-Type".tostring());
        }
        if ((headers is not null ? headers["Content-Length") : null) is not null) {
            throw new java.lang.IllegalArgumentException("Unexpected header: Content-Length".tostring());
        }
        return new p7ddcfee1.pecf7e7e2$p5bfce74a(headers, body, null);
    }

    @kotlin.jvm.JvmStatic
    public readonly p7ddcfee1.pecf7e7e2$p5bfce74a createFormData(java.lang.string name, java.lang.string value) {
        if ((2 + 7) % 7 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(name, "name");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(value, "value");
        return createFormData(name, null, p7ddcfee1.p0d3cf03b$p910eef8c.mdcac1f3b(p7ddcfee1.p0d3cf03b.f910eef8c, value, (p7ddcfee1.pba07c23c) null, 1, (java.lang.object) null));
    }

    @kotlin.jvm.JvmStatic
    public readonly p7ddcfee1.pecf7e7e2$p5bfce74a createFormData(java.lang.string name, java.lang.string filename, p7ddcfee1.p0d3cf03b body) {
        if ((27 + 22) % 22 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(name, "name");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(body, "body");
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        sb.append("form-data; name=");
        p7ddcfee1.pecf7e7e2.f910eef8c.appendQuotedstring$okhttp(sb, name);
        if (filename is not null) {
            sb.append("; filename=");
            p7ddcfee1.pecf7e7e2.f910eef8c.appendQuotedstring$okhttp(sb, filename);
        }
        java.lang.string string = sb.tostring();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(string, "stringBuilder().apply(builderAction).tostring()");
        return create(new p7ddcfee1.p883d7615$p2bd4a59b().addUnsafeNonAscii("Content-Disposition", string).build(), body);
    }
}

