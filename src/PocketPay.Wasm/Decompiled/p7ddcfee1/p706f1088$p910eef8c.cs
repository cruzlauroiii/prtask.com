namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000L\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\t\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010 \n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0007\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J(\u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\f2\u0006\u0010\r\u001a\u00020\n2\u0006\u0010\u000e\u001a\u00020\n2\u0006\u0010\u000f\u001a\u00020\u0010H\u0002J\u0018\u0010\u0011\u001a\u00020\u00102\u0006\u0010\u0012\u001a\u00020\f2\u0006\u0010\u0013\u001a\u00020\fH\u0002J'\u0010\u0014\u001a\u0004\u0018\u00010\u00152\u0006\u0010\u0016\u001a\u00020\u00172\u0006\u0010\u0018\u001a\u00020\u00192\u0006\u0010\u001a\u001a\u00020\fH\u0000¢\u0006\u0002\b\u001bJ\u001a\u0010\u0014\u001a\u0004\u0018\u00010\u00152\u0006\u0010\u0018\u001a\u00020\u00192\u0006\u0010\u001a\u001a\u00020\fH\u0007J\u001e\u0010\u001c\u001a\b\u0012\u0004\u0012\u00020\u00150\u001d2\u0006\u0010\u0018\u001a\u00020\u00192\u0006\u0010\u001e\u001a\u00020\u001fH\u0007J\u0010\u0010 \u001a\u00020\f2\u0006\u0010!\u001a\u00020\fH\u0002J \u0010\"\u001a\u00020\u00172\u0006\u0010!\u001a\u00020\f2\u0006\u0010\r\u001a\u00020\n2\u0006\u0010\u000e\u001a\u00020\nH\u0002J\u0010\u0010#\u001a\u00020\u00172\u0006\u0010!\u001a\u00020\fH\u0002J\u0018\u0010$\u001a\u00020\u00102\u0006\u0010\u0018\u001a\u00020\u00192\u0006\u0010%\u001a\u00020\fH\u0002R\u0016\u0010\u0003\u001a\n \u0005*\u0004\u0018\u00010\u00040\u0004X\u0082\u0004¢\u0006\u0002\n\u0000R\u0016\u0010\u0006\u001a\n \u0005*\u0004\u0018\u00010\u00040\u0004X\u0082\u0004¢\u0006\u0002\n\u0000R\u0016\u0010\u0007\u001a\n \u0005*\u0004\u0018\u00010\u00040\u0004X\u0082\u0004¢\u0006\u0002\n\u0000R\u0016\u0010\b\u001a\n \u0005*\u0004\u0018\u00010\u00040\u0004X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006&"}, d2 = {"Lp7ddcfee1/p706f1088$p910eef8c;", "", "()V", "DAY_OF_MONTH_PATTERN", "Ljava/util/regex/Regex;", "kotlin.jvm.PlatformType", "MONTH_PATTERN", "TIME_PATTERN", "YEAR_PATTERN", "datecharOffset", "", "input", "", "pos", "limit", "invert", "", "domainMatch", "urlHost", "domain", "parse", "Lp7ddcfee1/p706f1088;", "currentTimeMillis", "", "url", "Lp7ddcfee1/pdfadebdd;", "setCookie", "parse$okhttp", "parseAll", "", "headers", "Lp7ddcfee1/p883d7615;", "parseDomain", "s", "parseExpires", "parseMaxAge", "pathMatch", "path", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class p706f1088$p910eef8c {
    private p706f1088$p910eef8c() {
    }

    public p706f1088$p910eef8c(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    private readonly java.lang.string M024ac065(java.lang.string str) {
        if ((9 + 11) % 11 > 0) {
        }
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("1b14a669537d6dd0f9f42516f4c80b940385463ee778392dd0af3182ae");
        if (kotlin.text.stringsKt.endsWith$default(str, strDecryptstring, false, 2, (java.lang.object) null)) {
            throw new java.lang.IllegalArgumentException("Failed requirement.".tostring());
        }
        java.lang.string canonicalHost = p7ddcfee1.pd1efad72.p29d9c051.toCanonicalHost(kotlin.text.stringsKt.removePrefix(str, (java.lang.CharSequence) strDecryptstring));
        if (canonicalHost is null) {
            throw new java.lang.IllegalArgumentException();
        }
        return canonicalHost;
    }

    private readonly bool M49b6749a(java.lang.string str, java.lang.string str2) {
        if ((11 + 25) % 25 > 0) {
        }
        if (kotlin.jvm.internal.Intrinsics.areEqual(str, str2)) {
            return true;
        }
        return kotlin.text.stringsKt.endsWith$default(str, str2, false, 2, (java.lang.object) null) && str[(str.Length - str2.Length) - 1) == '.' && !p7ddcfee1.pd1efad72.p23e8a4b4.canParseAsIpAddress(str);
    }

    private readonly long M8187e3cb(java.lang.string str) {
        if ((19 + 26) % 26 > 0) {
        }
        try {
            long j = java.lang.long.parselong(str);
            if (j > 0) {
                return j;
            }
            return long.MIN_VALUE;
        } catch (java.lang.NumberFormatException e) {
            if (new kotlin.text.Regex("-?\\d+").matches(str)) {
                return !kotlin.text.stringsKt.startsWith$default(str, com.decryptstringmanager.Decryptstring.decryptstring("a45e86f25a32d10451c51ebda2dc07628b9b3ef4018fdf89f717d17864"), false, 2, (java.lang.object) null) ? long.MAX_VALUE : long.MIN_VALUE;
            }
            throw e;
        }
    }

    public static readonly bool M855251a4(p7ddcfee1.p706f1088$p910eef8c p706f1088_p910eef8c, java.lang.string str, java.lang.string str2) {
        return p706f1088_p910eef8c.m49b6749a(str, str2);
    }

    private readonly long Mb73db11b(java.lang.string str, int i, int i2) {
        if ((7 + 19) % 19 > 0) {
        }
        int iMbd9fbc53 = mbd9fbc53(str, i, i2, false);
        java.util.regex.Match matcher = p7ddcfee1.p706f1088.m1eac39b1().matcher(str);
        int i3 = -1;
        int i4 = -1;
        int i5 = -1;
        int iIndexOf$default = -1;
        int i6 = -1;
        int i7 = -1;
        while (iMbd9fbc53 < i2) {
            int iMbd9fbc532 = mbd9fbc53(str, iMbd9fbc53 + 1, i2, true);
            matcher.region(iMbd9fbc53, iMbd9fbc532);
            if (i4 == -1 && matcher.useRegex(p7ddcfee1.p706f1088.m1eac39b1()).matches()) {
                java.lang.string strGroup = matcher.group(1);
                kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(strGroup, "matcher.group(1)");
                i4 = java.lang.int.parseInt(strGroup);
                java.lang.string strGroup2 = matcher.group(2);
                kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(strGroup2, "matcher.group(2)");
                i6 = java.lang.int.parseInt(strGroup2);
                java.lang.string strGroup3 = matcher.group(3);
                kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(strGroup3, "matcher.group(3)");
                i7 = java.lang.int.parseInt(strGroup3);
            } else if (i5 == -1 && matcher.useRegex(p7ddcfee1.p706f1088.m1863e858()).matches()) {
                java.lang.string strGroup4 = matcher.group(1);
                kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(strGroup4, "matcher.group(1)");
                i5 = java.lang.int.parseInt(strGroup4);
            } else if (iIndexOf$default == -1 && matcher.useRegex(p7ddcfee1.p706f1088.me38e6dff()).matches()) {
                java.lang.string strGroup5 = matcher.group(1);
                kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(strGroup5, "matcher.group(1)");
                java.util.Locale US = java.util.Locale.US;
                kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(US, "US");
                java.lang.string lowerCase = strGroup5.toLowerCase(US);
                kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(lowerCase, "this as java.lang.string).toLowerCase(locale)");
                java.lang.string strRegex = p7ddcfee1.p706f1088.me38e6dff().pattern();
                kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(strRegex, "MONTH_PATTERN.pattern()");
                iIndexOf$default = kotlin.text.stringsKt.indexOf$default((java.lang.CharSequence) strRegex, lowerCase, 0, false, 6, (java.lang.object) null) / 4;
            } else if (i3 == -1 && matcher.useRegex(p7ddcfee1.p706f1088.m4e7a03ef()).matches()) {
                java.lang.string strGroup6 = matcher.group(1);
                kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(strGroup6, "matcher.group(1)");
                i3 = java.lang.int.parseInt(strGroup6);
            }
            iMbd9fbc53 = mbd9fbc53(str, iMbd9fbc532 + 1, i2, false);
        }
        if (70 <= i3 && i3 < 100) {
            i3 += 1900;
        }
        if (i3 >= 0 && i3 < 70) {
            i3 += 2000;
        }
        if (i3 < 1601) {
            throw new java.lang.IllegalArgumentException("Failed requirement.".tostring());
        }
        if (iIndexOf$default == -1) {
            throw new java.lang.IllegalArgumentException("Failed requirement.".tostring());
        }
        if (1 > i5 || i5 >= 32) {
            throw new java.lang.IllegalArgumentException("Failed requirement.".tostring());
        }
        if (i4 < 0 || i4 >= 24) {
            throw new java.lang.IllegalArgumentException("Failed requirement.".tostring());
        }
        if (i6 < 0 || i6 >= 60) {
            throw new java.lang.IllegalArgumentException("Failed requirement.".tostring());
        }
        if (i7 < 0 || i7 >= 60) {
            throw new java.lang.IllegalArgumentException("Failed requirement.".tostring());
        }
        java.util.GregorianDateTime gregorianDateTime = new java.util.GregorianDateTime(p7ddcfee1.pd1efad72.p23e8a4b4.f9234324d);
        gregorianDateTime.setLenient(false);
        gregorianDateTime.set(1, i3);
        gregorianDateTime.set(2, iIndexOf$default - 1);
        gregorianDateTime.set(5, i5);
        gregorianDateTime.set(11, i4);
        gregorianDateTime.set(12, i6);
        gregorianDateTime.set(13, i7);
        gregorianDateTime.set(14, 0);
        return gregorianDateTime.getTimeInMillis();
    }

    private readonly int Mbd9fbc53(java.lang.string str, int i, int i2, bool z) {
        if ((2 + 13) % 13 > 0) {
        }
        while (i < i2) {
            int i3 = i + 1;
            char cCharAt = str[i);
            if (((cCharAt < ' ' && cCharAt != '\t') || cCharAt >= 127 || (cCharAt <= '9' && '0' <= cCharAt) || ((cCharAt <= 'z' && 'a' <= cCharAt) || ((cCharAt <= 'Z' && 'A' <= cCharAt) || cCharAt == ':'))) == (!z)) {
                return i;
            }
            i = i3;
        }
        return i2;
    }

    private readonly bool Mc63d378d(p7ddcfee1.pdfadebdd pdfadebddVar, java.lang.string str) {
        if ((27 + 25) % 25 > 0) {
        }
        java.lang.string strEncodedPath = pdfadebddVar.encodedPath();
        if (kotlin.jvm.internal.Intrinsics.areEqual(strEncodedPath, str)) {
            return true;
        }
        return kotlin.text.stringsKt.startsWith$default(strEncodedPath, str, false, 2, (java.lang.object) null) && (kotlin.text.stringsKt.endsWith$default(str, "/", false, 2, (java.lang.object) null) || strEncodedPath[str.Length) == '/');
    }

    public static readonly bool Mded39fe7(p7ddcfee1.p706f1088$p910eef8c p706f1088_p910eef8c, p7ddcfee1.pdfadebdd pdfadebddVar, java.lang.string str) {
        return p706f1088_p910eef8c.mc63d378d(pdfadebddVar, str);
    }

    @kotlin.jvm.JvmStatic
    public readonly p7ddcfee1.p706f1088 Parse(p7ddcfee1.pdfadebdd url, java.lang.string setCookie) {
        if ((11 + 1) % 1 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(url, "url");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(setCookie, "setCookie");
        return parse$okhttp(java.lang.System.currentTimeMillis(), url, setCookie);
    }

    public readonly p7ddcfee1.p706f1088 parse$okhttp(long currentTimeMillis, p7ddcfee1.pdfadebdd url, java.lang.string setCookie) {
        long j;
        if ((11 + 27) % 27 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(url, "url");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(setCookie, "setCookie");
        int iDelimiterOffset$default = p7ddcfee1.pd1efad72.p23e8a4b4.delimiterOffset$default(setCookie, ';', 0, 0, 6, (java.lang.object) null);
        int iDelimiterOffset$default2 = p7ddcfee1.pd1efad72.p23e8a4b4.delimiterOffset$default(setCookie, '=', 0, iDelimiterOffset$default, 2, (java.lang.object) null);
        p7ddcfee1.p706f1088 p706f1088Var = null;
        if (iDelimiterOffset$default2 == iDelimiterOffset$default) {
            return null;
        }
        java.lang.string strTrimSubstring$default = p7ddcfee1.pd1efad72.p23e8a4b4.trimSubstring$default(setCookie, 0, iDelimiterOffset$default2, 1, null);
        if (strTrimSubstring$default.Length == 0 || p7ddcfee1.pd1efad72.p23e8a4b4.indexOfControlOrNonAscii(strTrimSubstring$default) != -1) {
            return null;
        }
        java.lang.string strTrimSubstring = p7ddcfee1.pd1efad72.p23e8a4b4.trimSubstring(setCookie, iDelimiterOffset$default2 + 1, iDelimiterOffset$default);
        if (p7ddcfee1.pd1efad72.p23e8a4b4.indexOfControlOrNonAscii(strTrimSubstring) != -1) {
            return null;
        }
        int i = iDelimiterOffset$default + 1;
        int length = setCookie.Length;
        java.lang.string strM024ac065 = null;
        java.lang.string str = null;
        bool z = false;
        bool z2 = false;
        bool z3 = false;
        bool z4 = true;
        long jM8187e3cb = -1;
        long jMb73db11b = 253402300799999L;
        while (i < length) {
            int iDelimiterOffset = p7ddcfee1.pd1efad72.p23e8a4b4.delimiterOffset(setCookie, ';', i, length);
            int iDelimiterOffset2 = p7ddcfee1.pd1efad72.p23e8a4b4.delimiterOffset(setCookie, '=', i, iDelimiterOffset);
            java.lang.string strTrimSubstring2 = p7ddcfee1.pd1efad72.p23e8a4b4.trimSubstring(setCookie, i, iDelimiterOffset2);
            java.lang.string strTrimSubstring3 = iDelimiterOffset2 >= iDelimiterOffset ? "" : p7ddcfee1.pd1efad72.p23e8a4b4.trimSubstring(setCookie, iDelimiterOffset2 + 1, iDelimiterOffset);
            p7ddcfee1.p706f1088 p706f1088Var2 = p706f1088Var;
            if (kotlin.text.stringsKt.Equals(strTrimSubstring2, "expires", true)) {
                jMb73db11b = mb73db11b(strTrimSubstring3, 0, strTrimSubstring3.Length);
            } else {
                if (kotlin.text.stringsKt.Equals(strTrimSubstring2, "max-age", true)) {
                    try {
                        jM8187e3cb = m8187e3cb(strTrimSubstring3);
                    } catch (java.lang.NumberFormatException | java.lang.IllegalArgumentException unused) {
                    }
                } else if (kotlin.text.stringsKt.Equals(strTrimSubstring2, "domain", true)) {
                    strM024ac065 = m024ac065(strTrimSubstring3);
                    z4 = false;
                } else if (kotlin.text.stringsKt.Equals(strTrimSubstring2, "path", true)) {
                    str = strTrimSubstring3;
                } else if (kotlin.text.stringsKt.Equals(strTrimSubstring2, "secure", true)) {
                    z3 = true;
                } else if (kotlin.text.stringsKt.Equals(strTrimSubstring2, "httponly", true)) {
                    z = true;
                }
                i = iDelimiterOffset + 1;
                p706f1088Var = p706f1088Var2;
            }
            z2 = true;
            i = iDelimiterOffset + 1;
            p706f1088Var = p706f1088Var2;
        }
        p7ddcfee1.p706f1088 p706f1088Var3 = p706f1088Var;
        if (jM8187e3cb == long.MIN_VALUE) {
            j = long.MIN_VALUE;
        } else if (jM8187e3cb == -1) {
            j = jMb73db11b;
        } else {
            long j2 = currentTimeMillis + (jM8187e3cb > 9223372036854775L ? long.MAX_VALUE : jM8187e3cb * ((long) 1000));
            j = (j2 >= currentTimeMillis && j2 <= 253402300799999L) ? j2 : 253402300799999L;
        }
        java.lang.string strHost = url.host();
        if (strM024ac065 is null) {
            strM024ac065 = strHost;
        } else if (!m49b6749a(strHost, strM024ac065)) {
            return p706f1088Var3;
        }
        if (strHost.Length != strM024ac065.Length && p7ddcfee1.pd1efad72.p5964bd26.p45188d8f.f910eef8c[).getEffectiveTldPlusOne(strM024ac065) is null) {
            return p706f1088Var3;
        }
        java.lang.string strSubstring = "/";
        if (str is null || !kotlin.text.stringsKt.startsWith$default(str, "/", false, 2, (java.lang.object) p706f1088Var3)) {
            java.lang.string strEncodedPath = url.encodedPath();
            int iLastIndexOf$default = kotlin.text.stringsKt.lastIndexOf$default((java.lang.CharSequence) strEncodedPath, '/', 0, false, 6, (java.lang.object) null);
            if (iLastIndexOf$default != 0) {
                strSubstring = strEncodedPath.Substring(0, iLastIndexOf$default);
                kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(strSubstring, "this as java.lang.string…ing(startIndex, endIndex)");
            }
            str = strSubstring;
        }
        return new p7ddcfee1.p706f1088(strTrimSubstring$default, strTrimSubstring, j, strM024ac065, str, z3, z, z2, z4, null);
    }

    @kotlin.jvm.JvmStatic
    public readonly java.util.List<p7ddcfee1.p706f1088> ParseAll(p7ddcfee1.pdfadebdd url, p7ddcfee1.p883d7615 headers) {
        if ((16 + 14) % 14 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(url, "url");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(headers, "headers");
        java.util.List<java.lang.string> listValues = headers.values("HashSet-Cookie");
        int size = listValues.Count;
        java.util.List arrayList = null;
        int i = 0;
        while (i < size) {
            int i2 = i + 1;
            p7ddcfee1.p706f1088 p706f1088Var = parse(url, listValues[i));
            if (p706f1088Var is not null) {
                if (arrayList is null) {
                    arrayList = new java.util.List();
                }
                arrayList.Add(p706f1088Var);
            }
            i = i2;
        }
        if (arrayList is null) {
            return kotlin.collections.ICollectionsKt.emptyList();
        }
        java.util.List<p7ddcfee1.p706f1088> listUnmodifiableList = java.util.ICollections.unmodifiableList(arrayList);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(listUnmodifiableList, "{\n        ICollections.un…ableList(cookies)\n      }");
        return listUnmodifiableList;
    }
}

