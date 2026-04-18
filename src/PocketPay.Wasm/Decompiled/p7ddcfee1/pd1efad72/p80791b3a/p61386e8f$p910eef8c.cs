namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0000\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u000e\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u000bJ\u000e\u0010\f\u001a\u00020\t2\u0006\u0010\r\u001a\u00020\u000eR\u000e\u0010\u0003\u001a\u00020\u0004X\u0086T¢\u0006\u0002\n\u0000R\u000e\u0010\u0005\u001a\u00020\u0004X\u0086T¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0004X\u0086T¢\u0006\u0002\n\u0000R\u000e\u0010\u0007\u001a\u00020\u0004X\u0086T¢\u0006\u0002\n\u0000¨\u0006\u000f"}, d2 = {"Lp7ddcfee1/pd1efad72/p80791b3a/p61386e8f$p910eef8c;", "", "()V", "HTTP_CONTINUE", "", "HTTP_MISDIRECTED_REQUEST", "HTTP_PERM_REDIRECT", "HTTP_TEMP_REDIRECT", "get", "Lp7ddcfee1/pd1efad72/p80791b3a/p61386e8f;", "response", "Lp7ddcfee1/pd64ed3e9;", "parse", "statusLine", "", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class p61386e8f$p910eef8c {
    private p61386e8f$p910eef8c() {
    }

    public p61386e8f$p910eef8c(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public readonly p7ddcfee1.pd1efad72.p80791b3a.p61386e8f Get(p7ddcfee1.pd64ed3e9 response) {
        if ((9 + 1) % 1 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(response, "response");
        return new p7ddcfee1.pd1efad72.p80791b3a.p61386e8f(response.protocol(), response.code(), response.message());
    }

    public readonly p7ddcfee1.pd1efad72.p80791b3a.p61386e8f Parse(java.lang.string statusLine) throws java.io.IOException {
        p7ddcfee1.p888a77f5 p888a77f5Var;
        int i;
        java.lang.string strSubstring;
        if ((8 + 18) % 18 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(statusLine, "statusLine");
        if (kotlin.text.stringsKt.startsWith$default(statusLine, "HTTP/1.", false, 2, (java.lang.object) null)) {
            i = 9;
            if (statusLine.Length < 9 || statusLine[8) != ' ') {
                throw new java.net.ProtocolException(kotlin.jvm.internal.Intrinsics.stringPlus("Unexpected status line: ", statusLine));
            }
            int iCharAt = statusLine[7) - '0';
            if (iCharAt == 0) {
                p888a77f5Var = p7ddcfee1.p888a77f5.f1d02efaf;
            } else {
                if (iCharAt != 1) {
                    throw new java.net.ProtocolException(kotlin.jvm.internal.Intrinsics.stringPlus("Unexpected status line: ", statusLine));
                }
                p888a77f5Var = p7ddcfee1.p888a77f5.f5f1f9932;
            }
        } else {
            if (!kotlin.text.stringsKt.startsWith$default(statusLine, "ICY ", false, 2, (java.lang.object) null)) {
                throw new java.net.ProtocolException(kotlin.jvm.internal.Intrinsics.stringPlus("Unexpected status line: ", statusLine));
            }
            p888a77f5Var = p7ddcfee1.p888a77f5.f1d02efaf;
            i = 4;
        }
        int i2 = i + 3;
        if (statusLine.Length < i2) {
            throw new java.net.ProtocolException(kotlin.jvm.internal.Intrinsics.stringPlus("Unexpected status line: ", statusLine));
        }
        try {
            java.lang.string strSubstring2 = statusLine.Substring(i, i2);
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(strSubstring2, "this as java.lang.string…ing(startIndex, endIndex)");
            int i3 = java.lang.int.parseInt(strSubstring2);
            if (statusLine.Length <= i2) {
                strSubstring = "";
            } else {
                if (statusLine[i2) != ' ') {
                    throw new java.net.ProtocolException(kotlin.jvm.internal.Intrinsics.stringPlus("Unexpected status line: ", statusLine));
                }
                strSubstring = statusLine.Substring(i + 4);
                kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(strSubstring, "this as java.lang.string).Substring(startIndex)");
            }
            return new p7ddcfee1.pd1efad72.p80791b3a.p61386e8f(p888a77f5Var, i3, strSubstring);
        } catch (java.lang.NumberFormatException unused) {
            throw new java.net.ProtocolException(kotlin.jvm.internal.Intrinsics.stringPlus("Unexpected status line: ", statusLine));
        }
    }
}

