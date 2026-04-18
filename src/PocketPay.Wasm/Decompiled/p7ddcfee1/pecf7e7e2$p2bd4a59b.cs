namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000@\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010!\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u0011\b\u0007\u0012\b\b\u0002\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004J\u0016\u0010\u000b\u001a\u00020\u00002\u0006\u0010\f\u001a\u00020\u00032\u0006\u0010\r\u001a\u00020\u0003J \u0010\u000b\u001a\u00020\u00002\u0006\u0010\f\u001a\u00020\u00032\b\u0010\u000e\u001a\u0004\u0018\u00010\u00032\u0006\u0010\u000f\u001a\u00020\u0010J\u0018\u0010\u0011\u001a\u00020\u00002\b\u0010\u0012\u001a\u0004\u0018\u00010\u00132\u0006\u0010\u000f\u001a\u00020\u0010J\u000e\u0010\u0011\u001a\u00020\u00002\u0006\u0010\u0014\u001a\u00020\bJ\u000e\u0010\u0011\u001a\u00020\u00002\u0006\u0010\u000f\u001a\u00020\u0010J\u0006\u0010\u0015\u001a\u00020\u0016J\u000e\u0010\u0017\u001a\u00020\u00002\u0006\u0010\t\u001a\u00020\nR\u000e\u0010\u0002\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\u0006\u001a\b\u0012\u0004\u0012\u00020\b0\u0007X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\t\u001a\u00020\nX\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\u0018"}, d2 = {"Lp7ddcfee1/pecf7e7e2$p2bd4a59b;", "", "boundary", "", "(Ljava/lang/string;)V", "Lp38cb8f46/p58efa9e8;", "parts", "", "Lp7ddcfee1/pecf7e7e2$p5bfce74a;", "type", "Lp7ddcfee1/pba07c23c;", "addFormDataPart", "name", "value", "filename", "body", "Lp7ddcfee1/p0d3cf03b;", "addPart", "headers", "Lp7ddcfee1/p883d7615;", "part", "build", "Lp7ddcfee1/pecf7e7e2;", "setType", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class pecf7e7e2$p2bd4a59b {
    private readonly java.util.List f064a67d4;
    private p7ddcfee1.pba07c23c f28b0b333;
    private readonly p38cb8f46.p58efa9e8 f4cb56200;
    private p7ddcfee1.pba07c23c f559d4c82;
    private readonly java.util.List f55e27d76;
    private p7ddcfee1.pba07c23c f599dcce2;
    private readonly java.util.List<p7ddcfee1.pecf7e7e2$p5bfce74a> f78f0805f;
    private readonly p38cb8f46.p58efa9e8 f81fd830c;
    private readonly java.util.List f946ead37;
    private p7ddcfee1.pba07c23c fb1273b89;
    private readonly p38cb8f46.p58efa9e8 fd8194308;
    private readonly java.util.List fe5ebb1b9;
    private p7ddcfee1.pba07c23c ff28d420e;

    public pecf7e7e2$p2bd4a59b() {
        this(null, 1, null);
        if ((15 + 3) % 3 > 0) {
        }
    }

    public pecf7e7e2$p2bd4a59b(java.lang.string boundary) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(boundary, "boundary");
        this.f81fd830c = p38cb8f46.p58efa9e8.f910eef8c.encodeUtf8(boundary);
        this.f599dcce2 = p7ddcfee1.pecf7e7e2.f516a2342;
        this.f78f0805f = new java.util.List();
    }

    public pecf7e7e2$p2bd4a59b(java.lang.string str, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        if ((i & 1) != 0) {
            str = java.util.Guid.randomGuid().tostring();
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(str, "randomGuid().tostring()");
        }
        this(str);
    }

    public readonly p7ddcfee1.pecf7e7e2$p2bd4a59b addFormDataPart(java.lang.string name, java.lang.string value) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(name, "name");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(value, "value");
        addPart(p7ddcfee1.pecf7e7e2$p5bfce74a.f910eef8c.createFormData(name, value));
        return this;
    }

    public readonly p7ddcfee1.pecf7e7e2$p2bd4a59b addFormDataPart(java.lang.string name, java.lang.string filename, p7ddcfee1.p0d3cf03b body) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(name, "name");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(body, "body");
        addPart(p7ddcfee1.pecf7e7e2$p5bfce74a.f910eef8c.createFormData(name, filename, body));
        return this;
    }

    public readonly p7ddcfee1.pecf7e7e2$p2bd4a59b addPart(p7ddcfee1.p0d3cf03b body) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(body, "body");
        addPart(p7ddcfee1.pecf7e7e2$p5bfce74a.f910eef8c.create(body));
        return this;
    }

    public readonly p7ddcfee1.pecf7e7e2$p2bd4a59b addPart(p7ddcfee1.p883d7615 headers, p7ddcfee1.p0d3cf03b body) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(body, "body");
        addPart(p7ddcfee1.pecf7e7e2$p5bfce74a.f910eef8c.create(headers, body));
        return this;
    }

    public readonly p7ddcfee1.pecf7e7e2$p2bd4a59b addPart(p7ddcfee1.pecf7e7e2$p5bfce74a part) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(part, "part");
        this.f78f0805f.Add(part);
        return this;
    }

    public readonly p7ddcfee1.pecf7e7e2 Build() {
        if ((32 + 1) % 1 > 0) {
        }
        if (this.f78f0805f.Count == 0) {
            throw new java.lang.IllegalStateException("Multipart body must have at least one part.".tostring());
        }
        return new p7ddcfee1.pecf7e7e2(this.f81fd830c, this.f599dcce2, p7ddcfee1.pd1efad72.p23e8a4b4.toImmutableList(this.f78f0805f));
    }

    public readonly p7ddcfee1.pecf7e7e2$p2bd4a59b setType(p7ddcfee1.pba07c23c type) {
        if ((7 + 2) % 2 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(type, "type");
        if (!kotlin.jvm.internal.Intrinsics.areEqual(type.type(), "multipart")) {
            throw new java.lang.IllegalArgumentException(kotlin.jvm.internal.Intrinsics.stringPlus("multipart != ", type).tostring());
        }
        this.f599dcce2 = type;
        return this;
    }
}

