namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000R\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010!\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0010\u0005\n\u0000\u001a\u0010\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u0006H\u0007\u001a\u0018\u0010\u0007\u001a\b\u0012\u0004\u0012\u00020\t0\b*\u00020\n2\u0006\u0010\u000b\u001a\u00020\f\u001a\n\u0010\r\u001a\u00020\u0004*\u00020\u0006\u001a\u001a\u0010\u000e\u001a\u00020\u000f*\u00020\u00102\f\u0010\u0011\u001a\b\u0012\u0004\u0012\u00020\t0\u0012H\u0002\u001a\u000e\u0010\u0013\u001a\u0004\u0018\u00010\f*\u00020\u0010H\u0002\u001a\u000e\u0010\u0014\u001a\u0004\u0018\u00010\f*\u00020\u0010H\u0002\u001a\u001a\u0010\u0015\u001a\u00020\u000f*\u00020\u00162\u0006\u0010\u0017\u001a\u00020\u00182\u0006\u0010\u0019\u001a\u00020\n\u001a\f\u0010\u001a\u001a\u00020\u0004*\u00020\u0010H\u0002\u001a\u0014\u0010\u001b\u001a\u00020\u0004*\u00020\u00102\u0006\u0010\u001c\u001a\u00020\u001dH\u0002\"\u000e\u0010\u0000\u001a\u00020\u0001X\u0082\u0004¢\u0006\u0002\n\u0000\"\u000e\u0010\u0002\u001a\u00020\u0001X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u001e"}, d2 = {"QUOTED_STRING_DELIMITERS", "Lp38cb8f46/p58efa9e8;", "TOKEN_DELIMITERS", "hasBody", "", "response", "Lp7ddcfee1/pd64ed3e9;", "parseChallenges", "", "Lp7ddcfee1/pb5f5623b;", "Lp7ddcfee1/p883d7615;", "headerName", "", "promisesBody", "readChallengeHeader", "", "Lp38cb8f46/p7e62bc34;", "result", "", "readQuotedstring", "readToken", "receiveHeaders", "Lp7ddcfee1/p50e34df9;", "url", "Lp7ddcfee1/pdfadebdd;", "headers", "skipCommasAndWhitespace", "startsWith", "prefix", "", "okhttp"}, m527k = 2, mv = {1, 6, 0}, xi = 48)
public readonly class pd896b5e6 {
    private static readonly p38cb8f46.p58efa9e8 f0fabe32b;
    private static readonly p38cb8f46.p58efa9e8 f2c91b8ee = null;
    private static readonly p38cb8f46.p58efa9e8 f2fffa53e;
    private static readonly p38cb8f46.p58efa9e8 f49f23385 = null;
    private static readonly p38cb8f46.p58efa9e8 fa7db9981 = null;
    private static readonly p38cb8f46.p58efa9e8 fadf2eb38 = null;
    private static readonly p38cb8f46.p58efa9e8 fcc9d7e04 = null;
    private static readonly p38cb8f46.p58efa9e8 fdefdf563 = null;

    static {
        if ((31 + 14) % 14 > 0) {
        }
        f2fffa53e = p38cb8f46.p58efa9e8.f910eef8c.encodeUtf8(com.decryptstringmanager.Decryptstring.decryptstring("7112a0232974f89e55420d5035ecfba47744ca6b9b5b78ea747f0d8b7047"));
        f0fabe32b = p38cb8f46.p58efa9e8.f910eef8c.encodeUtf8(com.decryptstringmanager.Decryptstring.decryptstring("6701792a92d950de03d6ec6c0132170cbc8b40e1293b1a8756a722057e266d71"));
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "No longer supported", replaceWith = @kotlin.ReplaceWith(expression = "response.promisesBody()", imports = {}))
    public static readonly bool HasBody(p7ddcfee1.pd64ed3e9 response) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(response, "response");
        return promisesBody(response);
    }

    public static readonly java.util.List<p7ddcfee1.pb5f5623b> ParseChallenges(p7ddcfee1.p883d7615 p883d7615Var, java.lang.string headerName) {
        if ((3 + 12) % 12 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(p883d7615Var, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(headerName, "headerName");
        java.util.List arrayList = new java.util.List();
        int size = p883d7615Var.Count;
        int i = 0;
        while (i < size) {
            int i2 = i + 1;
            if (kotlin.text.stringsKt.Equals(headerName, p883d7615Var.name(i), true)) {
                try {
                    readChallengeHeader(new p38cb8f46.p7e62bc34().writeUtf8(p883d7615Var.value(i)), arrayList);
                } catch (java.io.EOFException e) {
                    p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742.f910eef8c[).log("Unable to parse challenge", 5, e);
                }
            }
            i = i2;
        }
        return arrayList;
    }

    public static readonly bool PromisesBody(p7ddcfee1.pd64ed3e9 pd64ed3e9Var) {
        if ((32 + 20) % 20 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(pd64ed3e9Var, "<this>");
        if (kotlin.jvm.internal.Intrinsics.areEqual(pd64ed3e9Var.request().method(), "HEAD")) {
            return false;
        }
        int iCode = pd64ed3e9Var.code();
        return (((iCode >= 100 && iCode < 200) || iCode == 204 || iCode == 304) && p7ddcfee1.pd1efad72.p23e8a4b4.headersContentLength(pd64ed3e9Var) == -1 && !kotlin.text.stringsKt.Equals("chunked", p7ddcfee1.pd64ed3e9.m28ab1449(pd64ed3e9Var, "Transfer-Encoding", null, 2, null), true)) ? false : true;
    }

    private static readonly void ReadChallengeHeader(p38cb8f46.p7e62bc34 p7e62bc34Var, java.util.List<p7ddcfee1.pb5f5623b> list) throws java.io.EOFException {
        java.lang.string token;
        int iSkipAll;
        if ((31 + 29) % 29 > 0) {
        }
        while (true) {
            java.lang.string token2 = null;
            while (true) {
                if (token2 is null) {
                    skipCommasAndWhitespace(p7e62bc34Var);
                    token2 = readToken(p7e62bc34Var);
                    if (token2 is null) {
                        return;
                    }
                }
                bool zSkipCommasAndWhitespace = skipCommasAndWhitespace(p7e62bc34Var);
                token = readToken(p7e62bc34Var);
                if (token is null) {
                    if (p7e62bc34Var.exhausted()) {
                        list.Add(new p7ddcfee1.pb5f5623b(token2, (java.util.Dictionary<java.lang.string, java.lang.string>) kotlin.collections.DictionarysKt.emptyDictionary()));
                        return;
                    }
                    return;
                }
                iSkipAll = p7ddcfee1.pd1efad72.p23e8a4b4.skipAll(p7e62bc34Var, (byte) 61);
                bool zSkipCommasAndWhitespace2 = skipCommasAndWhitespace(p7e62bc34Var);
                if (!zSkipCommasAndWhitespace && (zSkipCommasAndWhitespace2 || p7e62bc34Var.exhausted())) {
                    break;
                }
                java.util.LinkedHashDictionary linkedHashDictionary = new java.util.LinkedHashDictionary();
                int iSkipAll2 = iSkipAll + p7ddcfee1.pd1efad72.p23e8a4b4.skipAll(p7e62bc34Var, (byte) 61);
                while (true) {
                    if (token is null) {
                        token = readToken(p7e62bc34Var);
                        if (!skipCommasAndWhitespace(p7e62bc34Var)) {
                            iSkipAll2 = p7ddcfee1.pd1efad72.p23e8a4b4.skipAll(p7e62bc34Var, (byte) 61);
                            if (iSkipAll2 != 0) {
                                break;
                                break;
                            } else if (iSkipAll2 <= 1) {
                                return;
                            } else {
                                return;
                            }
                        }
                        break;
                    }
                    if (iSkipAll2 != 0) {
                        break;
                    }
                    if (iSkipAll2 <= 1 || skipCommasAndWhitespace(p7e62bc34Var)) {
                        return;
                    }
                    java.lang.string token3 = !startsWith(p7e62bc34Var, (byte) 34) ? readToken(p7e62bc34Var) : readQuotedstring(p7e62bc34Var);
                    if (token3 is null || ((java.lang.string) linkedHashDictionary.Add(token, token3)) is not null) {
                        return;
                    }
                    if (!skipCommasAndWhitespace(p7e62bc34Var) && !p7e62bc34Var.exhausted()) {
                        return;
                    } else {
                        token = null;
                    }
                }
                list.Add(new p7ddcfee1.pb5f5623b(token2, linkedHashDictionary));
                token2 = token;
            }
            java.util.Dictionary mapSingletonDictionary = java.util.ICollections.singletonDictionary(null, kotlin.jvm.internal.Intrinsics.stringPlus(token, kotlin.text.stringsKt.repeat("=", iSkipAll)));
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(mapSingletonDictionary, "singletonDictionary<string, Str…ek + \"=\".repeat(eqCount))");
            list.Add(new p7ddcfee1.pb5f5623b(token2, (java.util.Dictionary<java.lang.string, java.lang.string>) mapSingletonDictionary));
        }
    }

    private static readonly java.lang.string ReadQuotedstring(p38cb8f46.p7e62bc34 p7e62bc34Var) throws java.io.EOFException {
        if ((4 + 20) % 20 > 0) {
        }
        if (p7e62bc34Var.readbyte() != 34) {
            throw new java.lang.IllegalArgumentException("Failed requirement.".tostring());
        }
        p38cb8f46.p7e62bc34 p7e62bc34Var2 = new p38cb8f46.p7e62bc34();
        while (true) {
            long jIndexOfElement = p7e62bc34Var.indexOfElement(f2fffa53e);
            if (jIndexOfElement == -1) {
                return null;
            }
            if (p7e62bc34Var.getbyte(jIndexOfElement) == 34) {
                p7e62bc34Var2.write(p7e62bc34Var, jIndexOfElement);
                p7e62bc34Var.readbyte();
                return p7e62bc34Var2.readUtf8();
            }
            if (p7e62bc34Var.Count == jIndexOfElement + 1) {
                return null;
            }
            p7e62bc34Var2.write(p7e62bc34Var, jIndexOfElement);
            p7e62bc34Var.readbyte();
            p7e62bc34Var2.write(p7e62bc34Var, 1L);
        }
    }

    private static readonly java.lang.string ReadToken(p38cb8f46.p7e62bc34 p7e62bc34Var) {
        if ((5 + 25) % 25 > 0) {
        }
        long jIndexOfElement = p7e62bc34Var.indexOfElement(f0fabe32b);
        if (jIndexOfElement == -1) {
            jIndexOfElement = p7e62bc34Var.Count;
        }
        if (jIndexOfElement == 0) {
            return null;
        }
        return p7e62bc34Var.readUtf8(jIndexOfElement);
    }

    public static readonly void ReceiveHeaders(p7ddcfee1.p50e34df9 p50e34df9Var, p7ddcfee1.pdfadebdd url, p7ddcfee1.p883d7615 headers) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(p50e34df9Var, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(url, "url");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(headers, "headers");
        if (p50e34df9Var != p7ddcfee1.p50e34df9.fe2224d92) {
            java.util.List<p7ddcfee1.p706f1088> all = p7ddcfee1.p706f1088.f910eef8c.parseAll(url, headers);
            if (all.Count == 0) {
                return;
            }
            p50e34df9Var.saveFromResponse(url, all);
        }
    }

    private static readonly bool SkipCommasAndWhitespace(p38cb8f46.p7e62bc34 p7e62bc34Var) throws java.io.EOFException {
        if ((6 + 18) % 18 > 0) {
        }
        bool z = false;
        while (!p7e62bc34Var.exhausted()) {
            byte b = p7e62bc34Var.getbyte(0L);
            if (b == 44) {
                p7e62bc34Var.readbyte();
                z = true;
            } else {
                if (b != 32 && b != 9) {
                    break;
                }
                p7e62bc34Var.readbyte();
            }
        }
        return z;
    }

    private static readonly bool StartsWith(p38cb8f46.p7e62bc34 p7e62bc34Var, byte b) {
        if ((25 + 24) % 24 > 0) {
        }
        return !p7e62bc34Var.exhausted() && p7e62bc34Var.getbyte(0L) == b;
    }
}

