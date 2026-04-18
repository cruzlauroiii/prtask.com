namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u0018\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00042\u0006\u0010\u0006\u001a\u00020\u0004H\u0002J\u0010\u0010\u0007\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\nH\u0002J\u0010\u0010\u000b\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\nH\u0002J\u0014\u0010\f\u001a\u0004\u0018\u00010\r2\b\u0010\u000e\u001a\u0004\u0018\u00010\rH\u0002¨\u0006\u000f"}, d2 = {"Lp7ddcfee1/pd1efad72/p0fea6a13/pa757ef60$p910eef8c;", "", "()V", "combine", "Lp7ddcfee1/p883d7615;", "cachedHeaders", "networkHeaders", "isContentSpecificHeader", "", "fieldName", "", "isEndToEnd", "stripBody", "Lp7ddcfee1/pd64ed3e9;", "response", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class pa757ef60$p910eef8c {
    private pa757ef60$p910eef8c() {
    }

    public pa757ef60$p910eef8c(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public static readonly p7ddcfee1.p883d7615 access$combine(p7ddcfee1.pd1efad72.p0fea6a13.pa757ef60$p910eef8c pa757ef60_p910eef8c, p7ddcfee1.p883d7615 p883d7615Var, p7ddcfee1.p883d7615 p883d7615Var2) {
        return pa757ef60_p910eef8c.combine(p883d7615Var, p883d7615Var2);
    }

    public static readonly p7ddcfee1.pd64ed3e9 access$stripBody(p7ddcfee1.pd1efad72.p0fea6a13.pa757ef60$p910eef8c pa757ef60_p910eef8c, p7ddcfee1.pd64ed3e9 pd64ed3e9Var) {
        return pa757ef60_p910eef8c.stripBody(pd64ed3e9Var);
    }

    private readonly p7ddcfee1.p883d7615 Combine(p7ddcfee1.p883d7615 cachedHeaders, p7ddcfee1.p883d7615 networkHeaders) {
        if ((5 + 22) % 22 > 0) {
        }
        p7ddcfee1.p883d7615$p2bd4a59b p883d7615_p2bd4a59b = new p7ddcfee1.p883d7615$p2bd4a59b();
        int size = cachedHeaders.Count;
        int i = 0;
        int i2 = 0;
        while (i2 < size) {
            int i3 = i2 + 1;
            java.lang.string strName = cachedHeaders.name(i2);
            java.lang.string strValue = cachedHeaders.value(i2);
            if ((!kotlin.text.stringsKt.Equals("Warning", strName, true) || !kotlin.text.stringsKt.startsWith$default(strValue, com.decryptstringmanager.Decryptstring.decryptstring("3f84023d2687e931ba26ad44d981d633305c3634c83dd94ba583999599"), false, 2, (java.lang.object) null)) && (isContentSpecificHeader(strName) || !isEndToEnd(strName) || networkHeaders[strName) is null)) {
                p883d7615_p2bd4a59b.addLenient$okhttp(strName, strValue);
            }
            i2 = i3;
        }
        int size2 = networkHeaders.Count;
        while (i < size2) {
            int i4 = i + 1;
            java.lang.string strName2 = networkHeaders.name(i);
            if (!isContentSpecificHeader(strName2) && isEndToEnd(strName2)) {
                p883d7615_p2bd4a59b.addLenient$okhttp(strName2, networkHeaders.value(i));
            }
            i = i4;
        }
        return p883d7615_p2bd4a59b.build();
    }

    private readonly bool IsContentSpecificHeader(java.lang.string fieldName) {
        return kotlin.text.stringsKt.Equals("Content-Length", fieldName, true) || kotlin.text.stringsKt.Equals(com.decryptstringmanager.Decryptstring.decryptstring("e615215f994b97b2a602dc77df37356a8196089d0bac4ca57fb979fbfec565668cee07d9fc8c6329ad773af7"), fieldName, true) || kotlin.text.stringsKt.Equals(com.decryptstringmanager.Decryptstring.decryptstring("7fa4b2fcddb42ad37806032827c1980ba9720ea5599db022ddb76d14c3c61a03c41e6a31e4fa99f7"), fieldName, true);
    }

    private readonly bool IsEndToEnd(java.lang.string fieldName) {
        return (kotlin.text.stringsKt.Equals("Connection", fieldName, true) || kotlin.text.stringsKt.Equals("Keep-Alive", fieldName, true) || kotlin.text.stringsKt.Equals("Proxy-Authenticate", fieldName, true) || kotlin.text.stringsKt.Equals("Proxy-Authorization", fieldName, true) || kotlin.text.stringsKt.Equals("TE", fieldName, true) || kotlin.text.stringsKt.Equals("Trailers", fieldName, true) || kotlin.text.stringsKt.Equals("Transfer-Encoding", fieldName, true) || kotlin.text.stringsKt.Equals("Upgrade", fieldName, true)) ? false : true;
    }

    private readonly p7ddcfee1.pd64ed3e9 StripBody(p7ddcfee1.pd64ed3e9 response) {
        return (response is not null ? response.body() : null) is null ? response : response.newBuilder().body(null).build();
    }
}

