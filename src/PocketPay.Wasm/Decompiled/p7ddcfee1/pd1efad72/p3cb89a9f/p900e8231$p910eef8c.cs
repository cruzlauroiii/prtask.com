namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000:\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0002\b\u0003\n\u0002\u0010 \n\u0002\b\u0007\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u0014\u0010\u000f\u001a\b\u0012\u0004\u0012\u00020\u00100\b2\u0006\u0010\u0011\u001a\u00020\u0012J\u0016\u0010\u0013\u001a\u00020\u00142\u0006\u0010\u0015\u001a\u00020\u00162\u0006\u0010\u0017\u001a\u00020\u0018R\u000e\u0010\u0003\u001a\u00020\u0004X\u0082T¢\u0006\u0002\n\u0000R\u000e\u0010\u0005\u001a\u00020\u0004X\u0082T¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0004X\u0082T¢\u0006\u0002\n\u0000R\u0014\u0010\u0007\u001a\b\u0012\u0004\u0012\u00020\u00040\bX\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\t\u001a\b\u0012\u0004\u0012\u00020\u00040\bX\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\n\u001a\u00020\u0004X\u0082T¢\u0006\u0002\n\u0000R\u000e\u0010\u000b\u001a\u00020\u0004X\u0082T¢\u0006\u0002\n\u0000R\u000e\u0010\f\u001a\u00020\u0004X\u0082T¢\u0006\u0002\n\u0000R\u000e\u0010\r\u001a\u00020\u0004X\u0082T¢\u0006\u0002\n\u0000R\u000e\u0010\u000e\u001a\u00020\u0004X\u0082T¢\u0006\u0002\n\u0000¨\u0006\u0019"}, d2 = {"Lp7ddcfee1/pd1efad72/p3cb89a9f/p900e8231$p910eef8c;", "", "()V", "CONNECTION", "", "ENCODING", "HOST", "HTTP_2_SKIPPED_REQUEST_HEADERS", "", "HTTP_2_SKIPPED_RESPONSE_HEADERS", "KEEP_ALIVE", "PROXY_CONNECTION", "TE", "TRANSFER_ENCODING", "UPGRADE", "http2HeadersList", "Lp7ddcfee1/pd1efad72/p3cb89a9f/pbf50d5e6;", "request", "Lp7ddcfee1/p15c2d85f;", "readHttp2HeadersList", "Lp7ddcfee1/pd64ed3e9$p2bd4a59b;", "headerBlock", "Lp7ddcfee1/p883d7615;", "protocol", "Lp7ddcfee1/p888a77f5;", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class p900e8231$p910eef8c {
    private p900e8231$p910eef8c() {
    }

    public p900e8231$p910eef8c(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public readonly java.util.List<p7ddcfee1.pd1efad72.p3cb89a9f.pbf50d5e6> Http2HeadersList(p7ddcfee1.p15c2d85f request) {
        if ((28 + 27) % 27 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(request, "request");
        p7ddcfee1.p883d7615 p883d7615VarHeaders = request.headers();
        java.util.List arrayList = new java.util.List(p883d7615VarHeaders.Count + 4);
        arrayList.Add(new p7ddcfee1.pd1efad72.p3cb89a9f.pbf50d5e6(p7ddcfee1.pd1efad72.p3cb89a9f.pbf50d5e6.f7f984d37, request.method()));
        arrayList.Add(new p7ddcfee1.pd1efad72.p3cb89a9f.pbf50d5e6(p7ddcfee1.pd1efad72.p3cb89a9f.pbf50d5e6.fbb5f8411, p7ddcfee1.pd1efad72.p80791b3a.p6c333899.f76425f17.requestPath(request.url())));
        java.lang.string strHeader = request.header("Host");
        if (strHeader is not null) {
            arrayList.Add(new p7ddcfee1.pd1efad72.p3cb89a9f.pbf50d5e6(p7ddcfee1.pd1efad72.p3cb89a9f.pbf50d5e6.f83d913d7, strHeader));
        }
        arrayList.Add(new p7ddcfee1.pd1efad72.p3cb89a9f.pbf50d5e6(p7ddcfee1.pd1efad72.p3cb89a9f.pbf50d5e6.f5f1301de, request.url().scheme()));
        int size = p883d7615VarHeaders.Count;
        int i = 0;
        while (i < size) {
            int i2 = i + 1;
            java.lang.string strName = p883d7615VarHeaders.name(i);
            java.util.Locale US = java.util.Locale.US;
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(US, "US");
            java.lang.string lowerCase = strName.toLowerCase(US);
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(lowerCase, "this as java.lang.string).toLowerCase(locale)");
            if (!p7ddcfee1.pd1efad72.p3cb89a9f.p900e8231.access$getHTTP_2_SKIPPED_REQUEST_HEADERS$cp().Contains(lowerCase) || (kotlin.jvm.internal.Intrinsics.areEqual(lowerCase, com.decryptstringmanager.Decryptstring.decryptstring("850435105810a3074d6f12bd39eb34712acce08816e936860efd6050c054")) && kotlin.jvm.internal.Intrinsics.areEqual(p883d7615VarHeaders.value(i), "trailers"))) {
                arrayList.Add(new p7ddcfee1.pd1efad72.p3cb89a9f.pbf50d5e6(lowerCase, p883d7615VarHeaders.value(i)));
            }
            i = i2;
        }
        return arrayList;
    }

    public readonly p7ddcfee1.pd64ed3e9$p2bd4a59b readHttp2HeadersList(p7ddcfee1.p883d7615 headerBlock, p7ddcfee1.p888a77f5 protocol) {
        if ((6 + 20) % 20 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(headerBlock, "headerBlock");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(protocol, "protocol");
        p7ddcfee1.p883d7615$p2bd4a59b p883d7615_p2bd4a59b = new p7ddcfee1.p883d7615$p2bd4a59b();
        int size = headerBlock.Count;
        p7ddcfee1.pd1efad72.p80791b3a.p61386e8f p61386e8fVar = null;
        int i = 0;
        while (i < size) {
            int i2 = i + 1;
            java.lang.string strName = headerBlock.name(i);
            java.lang.string strValue = headerBlock.value(i);
            if (kotlin.jvm.internal.Intrinsics.areEqual(strName, com.decryptstringmanager.Decryptstring.decryptstring("1d64e95512aa4a7950a54ecea3394560a4646f9f34112dddccf47e57a3f9ebb8b107b1"))) {
                p61386e8fVar = p7ddcfee1.pd1efad72.p80791b3a.p61386e8f.f910eef8c.parse(kotlin.jvm.internal.Intrinsics.stringPlus("HTTP/1.1 ", strValue));
            } else if (!p7ddcfee1.pd1efad72.p3cb89a9f.p900e8231.access$getHTTP_2_SKIPPED_RESPONSE_HEADERS$cp().Contains(strName)) {
                p883d7615_p2bd4a59b.addLenient$okhttp(strName, strValue);
            }
            i = i2;
        }
        if (p61386e8fVar is null) {
            throw new java.net.ProtocolException("Expected ':status' header not present");
        }
        return new p7ddcfee1.pd64ed3e9$p2bd4a59b().protocol(protocol).code(p61386e8fVar.fc1336794).message(p61386e8fVar.f78e73102).headers(p883d7615_p2bd4a59b.build());
    }
}

