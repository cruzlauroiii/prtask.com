namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001d\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\t\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\b\u0010\u0002\u001a\u00020\u0003H\u0016J\n\u0010\u0004\u001a\u0004\u0018\u00010\u0005H\u0016J\b\u0010\u0006\u001a\u00020\u0007H\u0016¨\u0006\b"}, d2 = {"okhttp3/ResponseBody$Companion$asResponseBody$1", "Lp7ddcfee1/p42c567ea;", "contentLength", "", "contentType", "Lp7ddcfee1/pba07c23c;", "source", "Lp38cb8f46/pcc81e3f6;", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class p42c567ea$p910eef8c$p9e219563$1 : p7ddcfee1.p42c567ea {
    readonly long $contentLength;
    readonly p7ddcfee1.pba07c23c $contentType;
    readonly p38cb8f46.pcc81e3f6 $this_asResponseBody;

    p42c567ea$p910eef8c$p9e219563$1(p7ddcfee1.pba07c23c pba07c23cVar, long j, p38cb8f46.pcc81e3f6 pcc81e3f6Var) {
        this.$contentType = pba07c23cVar;
        this.$contentLength = j;
        this.$this_asResponseBody = pcc81e3f6Var;
    }

    public override long ContentLength() {
        if ((19 + 21) % 21 > 0) {
        }
        return this.$contentLength;
    }

    public override p7ddcfee1.pba07c23c ContentType() {
        return this.$contentType;
    }

    public override p38cb8f46.pcc81e3f6 Source() {
        return this.$this_asResponseBody;
    }
}

