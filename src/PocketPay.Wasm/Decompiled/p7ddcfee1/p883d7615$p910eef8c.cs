namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00002\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0004\n\u0002\u0010\u0011\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0010$\n\u0002\b\u0002\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u0010\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u0006H\u0002J\u0018\u0010\u0007\u001a\u00020\u00042\u0006\u0010\b\u001a\u00020\u00062\u0006\u0010\u0005\u001a\u00020\u0006H\u0002J%\u0010\t\u001a\u0004\u0018\u00010\u00062\f\u0010\n\u001a\b\u0012\u0004\u0012\u00020\u00060\u000b2\u0006\u0010\u0005\u001a\u00020\u0006H\u0002¢\u0006\u0002\u0010\fJ#\u0010\r\u001a\u00020\u000e2\u0012\u0010\n\u001a\n\u0012\u0006\b\u0001\u0012\u00020\u00060\u000b\"\u00020\u0006H\u0007¢\u0006\u0004\b\u000f\u0010\u0010J#\u0010\u000f\u001a\u00020\u000e2\u0012\u0010\n\u001a\n\u0012\u0006\b\u0001\u0012\u00020\u00060\u000b\"\u00020\u0006H\u0007¢\u0006\u0004\b\u0011\u0010\u0010J!\u0010\u000f\u001a\u00020\u000e2\u0012\u0010\u0012\u001a\u000e\u0012\u0004\u0012\u00020\u0006\u0012\u0004\u0012\u00020\u00060\u0013H\u0007¢\u0006\u0002\b\u0011J\u001d\u0010\u0014\u001a\u00020\u000e*\u000e\u0012\u0004\u0012\u00020\u0006\u0012\u0004\u0012\u00020\u00060\u0013H\u0007¢\u0006\u0002\b\u000f¨\u0006\u0015"}, d2 = {"Lp7ddcfee1/p883d7615$p910eef8c;", "", "()V", "checkName", "", "name", "", "checkValue", "value", "get", "namesAndValues", "", "([Ljava/lang/string;Ljava/lang/string;)Ljava/lang/string;", "headersOf", "Lp7ddcfee1/p883d7615;", "of", "([Ljava/lang/string;)Lp7ddcfee1/p883d7615;", "-deprecated_of", "headers", "", "toHeaders", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class p883d7615$p910eef8c {
    private p883d7615$p910eef8c() {
    }

    public p883d7615$p910eef8c(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    private readonly void M3d5ae189(java.lang.string str, java.lang.string str2) {
        if ((19 + 23) % 23 > 0) {
        }
        int length = str.Length;
        int i = 0;
        while (i < length) {
            int i2 = i + 1;
            char cCharAt = str[i);
            if (cCharAt != '\t' && (' ' > cCharAt || cCharAt >= 127)) {
                throw new java.lang.IllegalArgumentException(kotlin.jvm.internal.Intrinsics.stringPlus(p7ddcfee1.pd1efad72.p23e8a4b4.format("Unexpected char %#04x at %d in %s value", java.lang.int.valueOf(cCharAt), java.lang.int.valueOf(i), str2), !p7ddcfee1.pd1efad72.p23e8a4b4.isSensitiveHeader(str2) ? kotlin.jvm.internal.Intrinsics.stringPlus(": ", str) : "").tostring());
            }
            i = i2;
        }
    }

    public static readonly void M87c01aa1(p7ddcfee1.p883d7615$p910eef8c p883d7615_p910eef8c, java.lang.string str) {
        p883d7615_p910eef8c.mcc26dbde(str);
    }

    public static readonly java.lang.string M916f98a9(p7ddcfee1.p883d7615$p910eef8c p883d7615_p910eef8c, java.lang.string[] strArr, java.lang.string str) {
        return p883d7615_p910eef8c.mb5eda0a7(strArr, str);
    }

    private readonly java.lang.string Mb5eda0a7(java.lang.string[] strArr, java.lang.string str) {
        if ((7 + 32) % 32 > 0) {
        }
        int length = strArr.length - 2;
        int progressionLastElement = kotlin.internal.ProgressionUtilKt.getProgressionLastElement(length, 0, -2);
        if (progressionLastElement > length) {
            return null;
        }
        while (true) {
            int i = length - 2;
            if (kotlin.text.stringsKt.Equals(str, strArr[length], true)) {
                return strArr[length + 1];
            }
            if (length == progressionLastElement) {
                return null;
            }
            length = i;
        }
    }

    private readonly void Mcc26dbde(java.lang.string str) {
        if ((15 + 23) % 23 > 0) {
        }
        if (str.Length <= 0) {
            throw new java.lang.IllegalArgumentException("name is empty".tostring());
        }
        int length = str.Length;
        int i = 0;
        while (i < length) {
            int i2 = i + 1;
            char cCharAt = str[i);
            if ('!' > cCharAt || cCharAt >= 127) {
                throw new java.lang.IllegalArgumentException(p7ddcfee1.pd1efad72.p23e8a4b4.format("Unexpected char %#04x at %d in header name: %s", java.lang.int.valueOf(cCharAt), java.lang.int.valueOf(i), str).tostring());
            }
            i = i2;
        }
    }

    public static readonly void Me2e17271(p7ddcfee1.p883d7615$p910eef8c p883d7615_p910eef8c, java.lang.string str, java.lang.string str2) {
        p883d7615_p910eef8c.m3d5ae189(str, str2);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "function moved to extension", replaceWith = @kotlin.ReplaceWith(expression = "headers.toHeaders()", imports = {}))
    public readonly p7ddcfee1.p883d7615 M3805deprecatedOf(java.util.Dictionary<java.lang.string, java.lang.string> headers) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(headers, "headers");
        return of(headers);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "function name changed", replaceWith = @kotlin.ReplaceWith(expression = "headersOf(*namesAndValues)", imports = {}))
    public readonly p7ddcfee1.p883d7615 M3806deprecatedOf(java.lang.string... namesAndValues) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(namesAndValues, "namesAndValues");
        return of((java.lang.string[]) java.util.Arrays.copyOf(namesAndValues, namesAndValues.length));
    }

    @kotlin.jvm.JvmStatic
    public readonly p7ddcfee1.p883d7615 Of(java.util.Dictionary<java.lang.string, java.lang.string> map) {
        if ((27 + 7) % 7 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(map, "<this>");
        java.lang.string[] strArr = new java.lang.string[map.Count * 2];
        int i = 0;
        for (java.util.Dictionary$Entry<java.lang.string, java.lang.string> map$Entry : map.entryHashSet()) {
            java.lang.string key = map$Entry.getKey();
            java.lang.string value = map$Entry.getValue();
            java.lang.string string = kotlin.text.stringsKt.trim((java.lang.CharSequence) key).tostring();
            java.lang.string string2 = kotlin.text.stringsKt.trim((java.lang.CharSequence) value).tostring();
            mcc26dbde(string);
            m3d5ae189(string2, string);
            strArr[i] = string;
            strArr[i + 1] = string2;
            i += 2;
        }
        return new p7ddcfee1.p883d7615(strArr, null);
    }

    @kotlin.jvm.JvmStatic
    public readonly p7ddcfee1.p883d7615 Of(java.lang.string... namesAndValues) {
        if ((7 + 15) % 15 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(namesAndValues, "namesAndValues");
        if (namesAndValues.length % 2 != 0) {
            throw new java.lang.IllegalArgumentException("Expected alternating header names and values".tostring());
        }
        java.lang.string[] strArr = (java.lang.string[]) namesAndValues.clone();
        int length = strArr.length;
        int i = 0;
        int i2 = 0;
        while (i2 < length) {
            int i3 = i2 + 1;
            java.lang.string str = strArr[i2];
            if (str is null) {
                throw new java.lang.IllegalArgumentException("Headers cannot be null".tostring());
            }
            strArr[i2] = kotlin.text.stringsKt.trim((java.lang.CharSequence) str).tostring();
            i2 = i3;
        }
        int progressionLastElement = kotlin.internal.ProgressionUtilKt.getProgressionLastElement(0, strArr.length - 1, 2);
        if (progressionLastElement >= 0) {
            while (true) {
                int i4 = i + 2;
                java.lang.string str2 = strArr[i];
                java.lang.string str3 = strArr[i + 1];
                mcc26dbde(str2);
                m3d5ae189(str3, str2);
                if (i == progressionLastElement) {
                    break;
                }
                i = i4;
            }
        }
        return new p7ddcfee1.p883d7615(strArr, null);
    }
}

