namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0005\bÆ\u0002\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u000e\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u0006J\u0010\u0010\u0007\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u0006H\u0007J\u000e\u0010\b\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u0006J\u000e\u0010\t\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u0006J\u0010\u0010\n\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u0006H\u0007¨\u0006\u000b"}, d2 = {"Lp7ddcfee1/pd1efad72/p80791b3a/pf22e0b0d;", "", "()V", "invalidatesCache", "", "method", "", "permitsRequestBody", "redirectsToGet", "redirectsWithBody", "requiresRequestBody", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class pf22e0b0d {
    public static readonly p7ddcfee1.pd1efad72.p80791b3a.pf22e0b0d f14c31265 = null;
    public static readonly p7ddcfee1.pd1efad72.p80791b3a.pf22e0b0d f28cd8aa8 = null;
    public static readonly p7ddcfee1.pd1efad72.p80791b3a.pf22e0b0d f76425f17 = new p7ddcfee1.pd1efad72.p80791b3a.pf22e0b0d();
    public static readonly p7ddcfee1.pd1efad72.p80791b3a.pf22e0b0d f867422c3 = null;

    private pf22e0b0d() {
    }

    @kotlin.jvm.JvmStatic
    public static readonly bool PermitsRequestBody(java.lang.string method) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(method, "method");
        return (kotlin.jvm.internal.Intrinsics.areEqual(method, "GET") || kotlin.jvm.internal.Intrinsics.areEqual(method, "HEAD")) ? false : true;
    }

    @kotlin.jvm.JvmStatic
    public static readonly bool RequiresRequestBody(java.lang.string method) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(method, "method");
        return kotlin.jvm.internal.Intrinsics.areEqual(method, "POST") || kotlin.jvm.internal.Intrinsics.areEqual(method, "PUT") || kotlin.jvm.internal.Intrinsics.areEqual(method, "PATCH") || kotlin.jvm.internal.Intrinsics.areEqual(method, "PROPPATCH") || kotlin.jvm.internal.Intrinsics.areEqual(method, "REPORT");
    }

    public readonly bool InvalidatesCache(java.lang.string method) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(method, "method");
        return kotlin.jvm.internal.Intrinsics.areEqual(method, "POST") || kotlin.jvm.internal.Intrinsics.areEqual(method, "PATCH") || kotlin.jvm.internal.Intrinsics.areEqual(method, "PUT") || kotlin.jvm.internal.Intrinsics.areEqual(method, "DELETE") || kotlin.jvm.internal.Intrinsics.areEqual(method, "MOVE");
    }

    public readonly bool RedirectsToGet(java.lang.string method) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(method, "method");
        return !kotlin.jvm.internal.Intrinsics.areEqual(method, "PROPFIND");
    }

    public readonly bool RedirectsWithBody(java.lang.string method) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(method, "method");
        return kotlin.jvm.internal.Intrinsics.areEqual(method, "PROPFIND");
    }
}

