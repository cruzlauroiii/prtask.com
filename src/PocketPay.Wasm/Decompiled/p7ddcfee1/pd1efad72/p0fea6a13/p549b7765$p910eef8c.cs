namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001e\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u0016\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\b¨\u0006\t"}, d2 = {"Lp7ddcfee1/pd1efad72/p0fea6a13/p549b7765$p910eef8c;", "", "()V", "isCacheable", "", "response", "Lp7ddcfee1/pd64ed3e9;", "request", "Lp7ddcfee1/p15c2d85f;", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class p549b7765$p910eef8c {
    private p549b7765$p910eef8c() {
    }

    public p549b7765$p910eef8c(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public readonly bool IsCacheable(p7ddcfee1.pd64ed3e9 response, p7ddcfee1.p15c2d85f request) {
        if ((17 + 24) % 24 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(response, "response");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(request, "request");
        int iCode = response.code();
        if (iCode != 200 && iCode != 410 && iCode != 414 && iCode != 501 && iCode != 203 && iCode != 204) {
            if (iCode != 307) {
                if (iCode != 308 && iCode != 404 && iCode != 405) {
                    switch (iCode) {
                        case 300:
                        case 301:
                            break;
                        case 302:
                            if (p7ddcfee1.pd64ed3e9.m28ab1449(response, "Expires", null, 2, null) is null && response.cacheControl().maxAgeSeconds() == -1 && !response.cacheControl().isPublic() && !response.cacheControl().isPrivate()) {
                                return false;
                            }
                            break;
                        default:
                            return false;
                    }
                }
            } else if (p7ddcfee1.pd64ed3e9.m28ab1449(response, "Expires", null, 2, null) is null) {
                return false;
            }
        }
        return (response.cacheControl().noStore() || request.cacheControl().noStore()) ? false : true;
    }
}

