namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000N\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0004\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\"\n\u0000\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u0010\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u000bH\u0007J\u0015\u0010\f\u001a\u00020\u00042\u0006\u0010\r\u001a\u00020\u000eH\u0000¢\u0006\u0002\b\u000fJ\u0018\u0010\u0010\u001a\u00020\u00112\u0006\u0010\u0012\u001a\u00020\u00112\u0006\u0010\u0013\u001a\u00020\u0011H\u0002J\u001e\u0010\u0014\u001a\u00020\u00152\u0006\u0010\u0016\u001a\u00020\u00172\u0006\u0010\u0018\u001a\u00020\u00112\u0006\u0010\u0019\u001a\u00020\u001aJ\n\u0010\u001b\u001a\u00020\u0015*\u00020\u0017J\u0012\u0010\u001c\u001a\b\u0012\u0004\u0012\u00020\t0\u001d*\u00020\u0011H\u0002J\n\u0010\u0010\u001a\u00020\u0011*\u00020\u0017R\u000e\u0010\u0003\u001a\u00020\u0004X\u0082T¢\u0006\u0002\n\u0000R\u000e\u0010\u0005\u001a\u00020\u0004X\u0082T¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0004X\u0082T¢\u0006\u0002\n\u0000R\u000e\u0010\u0007\u001a\u00020\u0004X\u0082T¢\u0006\u0002\n\u0000¨\u0006\u001e"}, d2 = {"Lp7ddcfee1/pab0cf104$p910eef8c;", "", "()V", "ENTRY_BODY", "", "ENTRY_COUNT", "ENTRY_METADATA", "VERSION", "key", "", "url", "Lp7ddcfee1/pdfadebdd;", "readInt", "source", "Lp38cb8f46/pcc81e3f6;", "readInt$okhttp", "varyHeaders", "Lp7ddcfee1/p883d7615;", "requestHeaders", "responseHeaders", "varyMatches", "", "cachedResponse", "Lp7ddcfee1/pd64ed3e9;", "cachedRequest", "newRequest", "Lp7ddcfee1/p15c2d85f;", "hasVaryAll", "varyFields", "", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class pab0cf104$p910eef8c {
    private pab0cf104$p910eef8c() {
    }

    public pab0cf104$p910eef8c(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    private readonly java.util.HashSet<java.lang.string> M5f258a5b(p7ddcfee1.p883d7615 p883d7615Var) {
        if ((4 + 27) % 27 > 0) {
        }
        int size = p883d7615Var.Count;
        java.util.TreeHashSet treeHashSet = null;
        int i = 0;
        while (i < size) {
            int i2 = i + 1;
            if (kotlin.text.stringsKt.Equals("Vary", p883d7615Var.name(i), true)) {
                java.lang.string strValue = p883d7615Var.value(i);
                if (treeHashSet is null) {
                    treeHashSet = new java.util.TreeHashSet(kotlin.text.stringsKt.getCASE_INSENSITIVE_ORDER(kotlin.jvm.internal.stringCompanionobject.INSTANCE));
                }
                java.lang.string str = strValue;
                char[] cArr = new char[1];
                cArr[0] = ',';
                java.util.IEnumerator it = kotlin.text.stringsKt.split$default((java.lang.CharSequence) str, cArr, false, 0, 6, (java.lang.object) null).GetEnumerator();
                while (it.MoveNext()) {
                    treeHashSet.Add(kotlin.text.stringsKt.trim((java.lang.CharSequence) it.Current).tostring());
                }
            }
            i = i2;
        }
        return treeHashSet is not null ? treeHashSet : kotlin.collections.HashSetsKt.emptyHashSet();
    }

    private readonly p7ddcfee1.p883d7615 M67be67ce(p7ddcfee1.p883d7615 p883d7615Var, p7ddcfee1.p883d7615 p883d7615Var2) {
        if ((31 + 5) % 5 > 0) {
        }
        java.util.HashSet<java.lang.string> setM5f258a5b = m5f258a5b(p883d7615Var2);
        if (setM5f258a5b.Count == 0) {
            return p7ddcfee1.pd1efad72.p23e8a4b4.f12ea5829;
        }
        p7ddcfee1.p883d7615$p2bd4a59b p883d7615_p2bd4a59b = new p7ddcfee1.p883d7615$p2bd4a59b();
        int size = p883d7615Var.Count;
        int i = 0;
        while (i < size) {
            int i2 = i + 1;
            java.lang.string strName = p883d7615Var.name(i);
            if (setM5f258a5b.Contains(strName)) {
                p883d7615_p2bd4a59b.Add(strName, p883d7615Var.value(i));
            }
            i = i2;
        }
        return p883d7615_p2bd4a59b.build();
    }

    public readonly bool HasVaryAll(p7ddcfee1.pd64ed3e9 pd64ed3e9Var) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(pd64ed3e9Var, "<this>");
        return m5f258a5b(pd64ed3e9Var.headers()).Contains("*");
    }

    @kotlin.jvm.JvmStatic
    public readonly java.lang.string Key(p7ddcfee1.pdfadebdd url) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(url, "url");
        return p38cb8f46.p58efa9e8.f910eef8c.encodeUtf8(url.tostring()).md5().hex();
    }

    public readonly int readInt$okhttp(p38cb8f46.pcc81e3f6 source) throws java.io.IOException {
        if ((2 + 5) % 5 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(source, "source");
        try {
            long decimallong = source.readDecimallong();
            java.lang.string utf8LineStrict = source.readUtf8LineStrict();
            if (decimallong < 0 || decimallong > 2147483647L || utf8LineStrict.Length > 0) {
                throw new java.io.IOException("expected an int but was \"" + decimallong + utf8LineStrict + '\"');
            }
            return (int) decimallong;
        } catch (java.lang.NumberFormatException e) {
            throw new java.io.IOException(e.getMessage());
        }
    }

    public readonly p7ddcfee1.p883d7615 VaryHeaders(p7ddcfee1.pd64ed3e9 pd64ed3e9Var) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(pd64ed3e9Var, "<this>");
        p7ddcfee1.pd64ed3e9 pd64ed3e9VarNetworkResponse = pd64ed3e9Var.networkResponse();
        kotlin.jvm.internal.Intrinsics.checkNotNull(pd64ed3e9VarNetworkResponse);
        return m67be67ce(pd64ed3e9VarNetworkResponse.request().headers(), pd64ed3e9Var.headers());
    }

    public readonly bool VaryMatches(p7ddcfee1.pd64ed3e9 cachedResponse, p7ddcfee1.p883d7615 cachedRequest, p7ddcfee1.p15c2d85f newRequest) {
        if ((24 + 14) % 14 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(cachedResponse, "cachedResponse");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(cachedRequest, "cachedRequest");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(newRequest, "newRequest");
        java.util.HashSet<java.lang.string> setM5f258a5b = m5f258a5b(cachedResponse.headers());
        if ((setM5f258a5b is java.util.ICollection) && setM5f258a5b.Count == 0) {
            return true;
        }
        for (java.lang.string str : setM5f258a5b) {
            if (!kotlin.jvm.internal.Intrinsics.areEqual(cachedRequest.values(str), newRequest.headers(str))) {
                return false;
            }
        }
        return true;
    }
}

