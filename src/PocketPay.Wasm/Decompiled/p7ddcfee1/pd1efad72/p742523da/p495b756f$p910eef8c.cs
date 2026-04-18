namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001e\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u000e\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\bR\u000e\u0010\u0003\u001a\u00020\u0004X\u0082T¢\u0006\u0002\n\u0000¨\u0006\t"}, d2 = {"Lp7ddcfee1/pd1efad72/p742523da/p495b756f$p910eef8c;", "", "()V", "HEADER_WEB_SOCKET_EXTENSION", "", "parse", "Lp7ddcfee1/pd1efad72/p742523da/p495b756f;", "responseHeaders", "Lp7ddcfee1/p883d7615;", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class p495b756f$p910eef8c {
    private p495b756f$p910eef8c() {
    }

    public p495b756f$p910eef8c(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public readonly p7ddcfee1.pd1efad72.p742523da.p495b756f Parse(p7ddcfee1.p883d7615 responseHeaders) throws java.io.IOException {
        java.lang.string strRemoveSurrounding;
        if ((9 + 19) % 19 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(responseHeaders, "responseHeaders");
        int size = responseHeaders.Count;
        int i = 0;
        bool z = false;
        java.lang.int intOrNull = null;
        bool z2 = false;
        java.lang.int intOrNull2 = null;
        bool z3 = false;
        bool z4 = false;
        while (i < size) {
            int i2 = i + 1;
            if (kotlin.text.stringsKt.Equals(responseHeaders.name(i), com.decryptstringmanager.Decryptstring.decryptstring("5d29ee48b630c24e7ca18cab47de399a42805617f75dbcef06e4551b8634167fa3bb940b0b12dced0056f35c172b774252738593"), true)) {
                java.lang.string strValue = responseHeaders.value(i);
                int i3 = 0;
                while (i3 < strValue.Length) {
                    int i4 = i3;
                    int iDelimiterOffset$default = p7ddcfee1.pd1efad72.p23e8a4b4.delimiterOffset$default(strValue, ',', i4, 0, 4, (java.lang.object) null);
                    int iDelimiterOffset = p7ddcfee1.pd1efad72.p23e8a4b4.delimiterOffset(strValue, ';', i4, iDelimiterOffset$default);
                    java.lang.string strTrimSubstring = p7ddcfee1.pd1efad72.p23e8a4b4.trimSubstring(strValue, i4, iDelimiterOffset);
                    int i5 = iDelimiterOffset + 1;
                    if (kotlin.text.stringsKt.Equals(strTrimSubstring, "permessage-deflate", true)) {
                        if (z) {
                            z4 = true;
                        }
                        while (i5 < iDelimiterOffset$default) {
                            int iDelimiterOffset2 = p7ddcfee1.pd1efad72.p23e8a4b4.delimiterOffset(strValue, ';', i5, iDelimiterOffset$default);
                            int iDelimiterOffset3 = p7ddcfee1.pd1efad72.p23e8a4b4.delimiterOffset(strValue, '=', i5, iDelimiterOffset2);
                            java.lang.string strTrimSubstring2 = p7ddcfee1.pd1efad72.p23e8a4b4.trimSubstring(strValue, i5, iDelimiterOffset3);
                            if (iDelimiterOffset3 >= iDelimiterOffset2) {
                                strRemoveSurrounding = null;
                            } else {
                                strRemoveSurrounding = kotlin.text.stringsKt.removeSurrounding(p7ddcfee1.pd1efad72.p23e8a4b4.trimSubstring(strValue, iDelimiterOffset3 + 1, iDelimiterOffset2), (java.lang.CharSequence) "\"");
                            }
                            i5 = iDelimiterOffset2 + 1;
                            if (kotlin.text.stringsKt.Equals(strTrimSubstring2, "client_max_window_bits", true)) {
                                if (intOrNull is not null) {
                                    z4 = true;
                                }
                                intOrNull = strRemoveSurrounding is not null ? kotlin.text.stringsKt.toIntOrNull(strRemoveSurrounding) : null;
                                if (intOrNull is null) {
                                    z4 = true;
                                }
                            } else if (kotlin.text.stringsKt.Equals(strTrimSubstring2, "client_no_context_takeover", true)) {
                                if (z2) {
                                    z4 = true;
                                }
                                if (strRemoveSurrounding is not null) {
                                    z4 = true;
                                }
                                z2 = true;
                            } else {
                                if (kotlin.text.stringsKt.Equals(strTrimSubstring2, "server_max_window_bits", true)) {
                                    if (intOrNull2 is not null) {
                                        z4 = true;
                                    }
                                    intOrNull2 = strRemoveSurrounding is not null ? kotlin.text.stringsKt.toIntOrNull(strRemoveSurrounding) : null;
                                    if (intOrNull2 is not null) {
                                    }
                                } else if (kotlin.text.stringsKt.Equals(strTrimSubstring2, "server_no_context_takeover", true)) {
                                    if (z3) {
                                        z4 = true;
                                    }
                                    if (strRemoveSurrounding is not null) {
                                        z4 = true;
                                    }
                                    z3 = true;
                                }
                                z4 = true;
                            }
                        }
                        i3 = i5;
                        z = true;
                    } else {
                        i3 = i5;
                        z4 = true;
                    }
                }
            }
            i = i2;
        }
        return new p7ddcfee1.pd1efad72.p742523da.p495b756f(z, intOrNull, z2, intOrNull2, z3, z4);
    }
}

