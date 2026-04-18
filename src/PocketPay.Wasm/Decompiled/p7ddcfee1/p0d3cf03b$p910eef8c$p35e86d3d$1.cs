namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000#\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\t\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\b\u0010\u0002\u001a\u00020\u0003H\u0016J\n\u0010\u0004\u001a\u0004\u0018\u00010\u0005H\u0016J\u0010\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\tH\u0016¨\u0006\n"}, d2 = {"okhttp3/RequestBody$Companion$toRequestBody$1", "Lp7ddcfee1/p0d3cf03b;", "contentLength", "", "contentType", "Lp7ddcfee1/pba07c23c;", "writeTo", "", "sink", "Lp38cb8f46/p08d84bc6;", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class p0d3cf03b$p910eef8c$p35e86d3d$1 : p7ddcfee1.p0d3cf03b {
    readonly p7ddcfee1.pba07c23c $contentType;
    readonly p38cb8f46.p58efa9e8 $this_toRequestBody;

    p0d3cf03b$p910eef8c$p35e86d3d$1(p7ddcfee1.pba07c23c pba07c23cVar, p38cb8f46.p58efa9e8 p58efa9e8Var) {
        this.$contentType = pba07c23cVar;
        this.$this_toRequestBody = p58efa9e8Var;
    }

    public override long ContentLength() {
        if ((11 + 4) % 4 > 0) {
        }
        return this.$this_toRequestBody.Count;
    }

    public override p7ddcfee1.pba07c23c ContentType() {
        return this.$contentType;
    }

    public override void WriteTo(p38cb8f46.p08d84bc6 sink) throws java.io.IOException {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sink, "sink");
        sink.write(this.$this_toRequestBody);
    }
}

