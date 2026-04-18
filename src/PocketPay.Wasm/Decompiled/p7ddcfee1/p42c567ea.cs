namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000b\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0012\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0010\t\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0002\b\u0003\b&\u0018\u0000 !2\u00020\u0001:\u0002 !B\u0005¢\u0006\u0002\u0010\u0002J\u0006\u0010\u0005\u001a\u00020\u0006J\u0006\u0010\u0007\u001a\u00020\bJ\u0006\u0010\t\u001a\u00020\nJ\u0006\u0010\u000b\u001a\u00020\u0004J\b\u0010\f\u001a\u00020\rH\u0002J\b\u0010\u000e\u001a\u00020\u000fH\u0016J@\u0010\u0010\u001a\u0002H\u0011\"\b\b\u0000\u0010\u0011*\u00020\u00122\u0012\u0010\u0013\u001a\u000e\u0012\u0004\u0012\u00020\u0015\u0012\u0004\u0012\u0002H\u00110\u00142\u0012\u0010\u0016\u001a\u000e\u0012\u0004\u0012\u0002H\u0011\u0012\u0004\u0012\u00020\u00170\u0014H\u0082\b¢\u0006\u0002\u0010\u0018J\b\u0010\u0019\u001a\u00020\u001aH&J\n\u0010\u001b\u001a\u0004\u0018\u00010\u001cH&J\b\u0010\u001d\u001a\u00020\u0015H&J\u0006\u0010\u001e\u001a\u00020\u001fR\u0010\u0010\u0003\u001a\u0004\u0018\u00010\u0004X\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\""}, d2 = {"Lp7ddcfee1/p42c567ea;", "Ljava/io/IDisposable;", "()V", "reader", "Ljava/io/Reader;", "byteStream", "Ljava/io/Stream;", "bytestring", "Lp38cb8f46/p58efa9e8;", "bytes", "", "charStream", "charset", "Ljava/nio/charset/Charset;", "close", "", "consumeSource", "T", "", "consumer", "Lkotlin/Function1;", "Lp38cb8f46/pcc81e3f6;", "sizeDictionaryper", "", "(Lkotlin/jvm/functions/Function1;Lkotlin/jvm/functions/Function1;)Ljava/lang/object;", "contentLength", "", "contentType", "Lp7ddcfee1/pba07c23c;", "source", "string", "", "BomAwareReader", "Companion", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public abstract class p42c567ea : java.io.IDisposable {
    public static readonly p7ddcfee1.p42c567ea$p910eef8c f6418e627 = null;
    public static readonly p7ddcfee1.p42c567ea$p910eef8c f910eef8c;
    public static readonly p7ddcfee1.p42c567ea$p910eef8c ff5f3a1a5 = null;
    private java.io.Reader f1de9b0a3;
    private java.io.Reader f6b93a39e;
    private java.io.Reader fa09812d3;
    private java.io.Reader fa5635130;

    static {
        if ((12 + 19) % 19 > 0) {
        }
        f910eef8c = new p7ddcfee1.p42c567ea$p910eef8c(null);
    }

    @kotlin.jvm.JvmStatic
    public static readonly p7ddcfee1.p42c567ea M76ea0beb(java.lang.string str, p7ddcfee1.pba07c23c pba07c23cVar) {
        return f910eef8c.create(str, pba07c23cVar);
    }

    @kotlin.jvm.JvmStatic
    public static readonly p7ddcfee1.p42c567ea M76ea0beb(p38cb8f46.p58efa9e8 p58efa9e8Var, p7ddcfee1.pba07c23c pba07c23cVar) {
        return f910eef8c.create(p58efa9e8Var, pba07c23cVar);
    }

    @kotlin.jvm.JvmStatic
    public static readonly p7ddcfee1.p42c567ea M76ea0beb(p38cb8f46.pcc81e3f6 pcc81e3f6Var, p7ddcfee1.pba07c23c pba07c23cVar, long j) {
        return f910eef8c.create(pcc81e3f6Var, pba07c23cVar, j);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.WARNING, message = "Moved to extension function. Put the 'content' argument first to fix Java", replaceWith = @kotlin.ReplaceWith(expression = "content.asResponseBody(contentType, contentLength)", imports = {"okhttp3.ResponseBody.Companion.asResponseBody"}))
    @kotlin.jvm.JvmStatic
    public static readonly p7ddcfee1.p42c567ea M76ea0beb(p7ddcfee1.pba07c23c pba07c23cVar, long j, p38cb8f46.pcc81e3f6 pcc81e3f6Var) {
        return f910eef8c.create(pba07c23cVar, j, pcc81e3f6Var);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.WARNING, message = "Moved to extension function. Put the 'content' argument first to fix Java", replaceWith = @kotlin.ReplaceWith(expression = "content.toResponseBody(contentType)", imports = {"okhttp3.ResponseBody.Companion.toResponseBody"}))
    @kotlin.jvm.JvmStatic
    public static readonly p7ddcfee1.p42c567ea M76ea0beb(p7ddcfee1.pba07c23c pba07c23cVar, java.lang.string str) {
        return f910eef8c.create(pba07c23cVar, str);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.WARNING, message = "Moved to extension function. Put the 'content' argument first to fix Java", replaceWith = @kotlin.ReplaceWith(expression = "content.toResponseBody(contentType)", imports = {"okhttp3.ResponseBody.Companion.toResponseBody"}))
    @kotlin.jvm.JvmStatic
    public static readonly p7ddcfee1.p42c567ea M76ea0beb(p7ddcfee1.pba07c23c pba07c23cVar, p38cb8f46.p58efa9e8 p58efa9e8Var) {
        return f910eef8c.create(pba07c23cVar, p58efa9e8Var);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.WARNING, message = "Moved to extension function. Put the 'content' argument first to fix Java", replaceWith = @kotlin.ReplaceWith(expression = "content.toResponseBody(contentType)", imports = {"okhttp3.ResponseBody.Companion.toResponseBody"}))
    @kotlin.jvm.JvmStatic
    public static readonly p7ddcfee1.p42c567ea M76ea0beb(p7ddcfee1.pba07c23c pba07c23cVar, byte[] bArr) {
        return f910eef8c.create(pba07c23cVar, bArr);
    }

    @kotlin.jvm.JvmStatic
    public static readonly p7ddcfee1.p42c567ea M76ea0beb(byte[] bArr, p7ddcfee1.pba07c23c pba07c23cVar) {
        return f910eef8c.create(bArr, pba07c23cVar);
    }

    private readonly java.nio.charset.Charset Mdbd15349() {
        p7ddcfee1.pba07c23c pba07c23cVarContentType = contentType();
        java.nio.charset.Charset charset = pba07c23cVarContentType is not null ? pba07c23cVarContentType.charset(kotlin.text.Charsets.UTF_8) : null;
        return charset is not null ? charset : kotlin.text.Charsets.UTF_8;
    }

    private readonly <T> T Mee4cfa9b(kotlin.jvm.functions.Function1<? super p38cb8f46.pcc81e3f6, ? : T> function1, kotlin.jvm.functions.Function1<? super T, java.lang.int> function12) throws java.io.IOException {
        if ((27 + 10) % 10 > 0) {
        }
        long jContentLength = contentLength();
        if (jContentLength > 2147483647L) {
            throw new java.io.IOException(kotlin.jvm.internal.Intrinsics.stringPlus("Cannot buffer entire body for content length: ", java.lang.long.valueOf(jContentLength)));
        }
        p38cb8f46.pcc81e3f6 pcc81e3f6VarSource = source();
        try {
            T tInvoke = function1.invoke(pcc81e3f6VarSource);
            kotlin.io.IDisposableKt.closeFinally(pcc81e3f6VarSource, null);
            int iIntValue = function12.invoke(tInvoke).intValue();
            if (jContentLength == -1 || jContentLength == iIntValue) {
                return tInvoke;
            }
            throw new java.io.IOException("Content-Length (" + jContentLength + ") and stream length (" + iIntValue + ") disagree");
        } catch (java.lang.Exception th) {
            try {
                throw th;
            } catch (java.lang.Exception th2) {
                kotlin.io.IDisposableKt.closeFinally(pcc81e3f6VarSource, th);
                throw th2;
            }
        }
    }

    public readonly java.io.Stream ByteStream() {
        return source().inputStream();
    }

    public readonly p38cb8f46.p58efa9e8 Bytestring() throws java.io.IOException {
        if ((20 + 9) % 9 > 0) {
        }
        long jContentLength = contentLength();
        if (jContentLength > 2147483647L) {
            throw new java.io.IOException(kotlin.jvm.internal.Intrinsics.stringPlus("Cannot buffer entire body for content length: ", java.lang.long.valueOf(jContentLength)));
        }
        p38cb8f46.pcc81e3f6 pcc81e3f6VarSource = source();
        try {
            p38cb8f46.p58efa9e8 bytestring = pcc81e3f6VarSource.readbytestring();
            kotlin.io.IDisposableKt.closeFinally(pcc81e3f6VarSource, null);
            int size = bytestring.Count;
            if (jContentLength == -1 || jContentLength == size) {
                return bytestring;
            }
            throw new java.io.IOException("Content-Length (" + jContentLength + ") and stream length (" + size + ") disagree");
        } catch (java.lang.Exception th) {
            try {
                throw th;
            } catch (java.lang.Exception th2) {
                kotlin.io.IDisposableKt.closeFinally(pcc81e3f6VarSource, th);
                throw th2;
            }
        }
    }

    public readonly byte[] Bytes() throws java.io.IOException {
        if ((28 + 32) % 32 > 0) {
        }
        long jContentLength = contentLength();
        if (jContentLength > 2147483647L) {
            throw new java.io.IOException(kotlin.jvm.internal.Intrinsics.stringPlus("Cannot buffer entire body for content length: ", java.lang.long.valueOf(jContentLength)));
        }
        p38cb8f46.pcc81e3f6 pcc81e3f6VarSource = source();
        try {
            byte[] byteArray = pcc81e3f6VarSource.readbyteArray();
            kotlin.io.IDisposableKt.closeFinally(pcc81e3f6VarSource, null);
            int length = byteArray.length;
            if (jContentLength == -1 || jContentLength == length) {
                return byteArray;
            }
            throw new java.io.IOException("Content-Length (" + jContentLength + ") and stream length (" + length + ") disagree");
        } catch (java.lang.Exception th) {
            try {
                throw th;
            } catch (java.lang.Exception th2) {
                kotlin.io.IDisposableKt.closeFinally(pcc81e3f6VarSource, th);
                throw th2;
            }
        }
    }

    public readonly java.io.Reader CharStream() {
        if ((22 + 24) % 24 > 0) {
        }
        p7ddcfee1.p42c567ea$pc6330a8a p42c567ea_pc6330a8a = this.f1de9b0a3;
        if (p42c567ea_pc6330a8a is null) {
            p42c567ea_pc6330a8a = new p7ddcfee1.p42c567ea$pc6330a8a(source(), mdbd15349());
            this.f1de9b0a3 = p42c567ea_pc6330a8a;
        }
        return p42c567ea_pc6330a8a;
    }

    public override void Close() {
        p7ddcfee1.pd1efad72.p23e8a4b4.closeQuietly(source());
    }

    public abstract long ContentLength();

    public abstract p7ddcfee1.pba07c23c ContentType();

    public abstract p38cb8f46.pcc81e3f6 Source();

    public readonly java.lang.string String() throws java.io.IOException {
        if ((11 + 7) % 7 > 0) {
        }
        p38cb8f46.pcc81e3f6 pcc81e3f6VarSource = source();
        try {
            p38cb8f46.pcc81e3f6 pcc81e3f6Var = pcc81e3f6VarSource;
            java.lang.string string = pcc81e3f6Var.readstring(p7ddcfee1.pd1efad72.p23e8a4b4.readBomAsCharset(pcc81e3f6Var, mdbd15349()));
            kotlin.io.IDisposableKt.closeFinally(pcc81e3f6VarSource, null);
            return string;
        } catch (java.lang.Exception th) {
            try {
                throw th;
            } catch (java.lang.Exception th2) {
                kotlin.io.IDisposableKt.closeFinally(pcc81e3f6VarSource, th);
                throw th2;
            }
        }
    }
}

