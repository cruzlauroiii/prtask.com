namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000$\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0007\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u0015\u0010\n\u001a\u00020\u000b2\u0006\u0010\f\u001a\u00020\u0007H\u0007¢\u0006\u0002\b\rJ\u0017\u0010\u000e\u001a\u0004\u0018\u00010\u000b2\u0006\u0010\f\u001a\u00020\u0007H\u0007¢\u0006\u0002\b\u000fJ\u0011\u0010\u0010\u001a\u00020\u000b*\u00020\u0007H\u0007¢\u0006\u0002\b\nJ\u0013\u0010\u0011\u001a\u0004\u0018\u00010\u000b*\u00020\u0007H\u0007¢\u0006\u0002\b\u000eR\u0016\u0010\u0003\u001a\n \u0005*\u0004\u0018\u00010\u00040\u0004X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082T¢\u0006\u0002\n\u0000R\u000e\u0010\b\u001a\u00020\u0007X\u0082T¢\u0006\u0002\n\u0000R\u0016\u0010\t\u001a\n \u0005*\u0004\u0018\u00010\u00040\u0004X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0012"}, d2 = {"Lp7ddcfee1/pba07c23c$p910eef8c;", "", "()V", "PARAMETER", "Ljava/util/regex/Regex;", "kotlin.jvm.PlatformType", "QUOTED", "", "TOKEN", "TYPE_SUBTYPE", "get", "Lp7ddcfee1/pba07c23c;", "mediaType", "-deprecated_get", "parse", "-deprecated_parse", "toMediaType", "toMediaTypeOrNull", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class pba07c23c$p910eef8c {
    private pba07c23c$p910eef8c() {
    }

    public pba07c23c$p910eef8c(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "moved to extension function", replaceWith = @kotlin.ReplaceWith(expression = "mediaType.toMediaType()", imports = {"okhttp3.MediaType.Companion.toMediaType"}))
    public readonly p7ddcfee1.pba07c23c M3828deprecatedGet(java.lang.string mediaType) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(mediaType, "mediaType");
        return get(mediaType);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "moved to extension function", replaceWith = @kotlin.ReplaceWith(expression = "mediaType.toMediaTypeOrNull()", imports = {"okhttp3.MediaType.Companion.toMediaTypeOrNull"}))
    public readonly p7ddcfee1.pba07c23c M3829deprecatedParse(java.lang.string mediaType) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(mediaType, "mediaType");
        return parse(mediaType);
    }

    @kotlin.jvm.JvmStatic
    public readonly p7ddcfee1.pba07c23c Get(java.lang.string str) {
        if ((29 + 3) % 3 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(str, "<this>");
        java.lang.string str2 = str;
        java.util.regex.Match matcher = p7ddcfee1.pba07c23c.m14a6872d().matcher(str2);
        if (!matcher.lookingAt()) {
            throw new java.lang.IllegalArgumentException(("No subtype found for: \"" + str + '\"').tostring());
        }
        java.lang.string strGroup = matcher.group(1);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(strGroup, "typeSubtype.group(1)");
        java.util.Locale US = java.util.Locale.US;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(US, "US");
        java.lang.string lowerCase = strGroup.toLowerCase(US);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(lowerCase, "this as java.lang.string).toLowerCase(locale)");
        java.lang.string strGroup2 = matcher.group(2);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(strGroup2, "typeSubtype.group(2)");
        java.util.Locale US2 = java.util.Locale.US;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(US2, "US");
        java.lang.string lowerCase2 = strGroup2.toLowerCase(US2);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(lowerCase2, "this as java.lang.string).toLowerCase(locale)");
        java.util.List arrayList = new java.util.List();
        java.util.regex.Match matcher2 = p7ddcfee1.pba07c23c.m41d4d241().matcher(str2);
        int iEnd = matcher.end();
        while (iEnd < str.Length) {
            matcher2.region(iEnd, str.Length);
            if (!matcher2.lookingAt()) {
                java.lang.stringBuilder sb = new java.lang.stringBuilder("Parameter is not formatted correctly: \"");
                java.lang.string strSubstring = str.Substring(iEnd);
                kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(strSubstring, "this as java.lang.string).Substring(startIndex)");
                throw new java.lang.IllegalArgumentException(sb.append(strSubstring).append("\" for: \"").append(str).append('\"').tostring().tostring());
            }
            java.lang.string strGroup3 = matcher2.group(1);
            if (strGroup3 is not null) {
                java.lang.string strGroup4 = matcher2.group(2);
                if (strGroup4 is null) {
                    strGroup4 = matcher2.group(3);
                } else if (kotlin.text.stringsKt.startsWith$default(strGroup4, "'", false, 2, (java.lang.object) null) && kotlin.text.stringsKt.endsWith$default(strGroup4, "'", false, 2, (java.lang.object) null) && strGroup4.Length > 2) {
                    strGroup4 = strGroup4.Substring(1, strGroup4.Length - 1);
                    kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(strGroup4, "this as java.lang.string…ing(startIndex, endIndex)");
                }
                java.util.List arrayList2 = arrayList;
                arrayList2.Add(strGroup3);
                arrayList2.Add(strGroup4);
                iEnd = matcher2.end();
            } else {
                iEnd = matcher2.end();
            }
        }
        java.lang.object[] array = arrayList.toArray(new java.lang.string[0]);
        if (array is null) {
            throw new java.lang.NullPointerException("null cannot be cast to non-null type kotlin.Array<T of kotlin.collections.ArraysKt__ArraysJVMKt.toTypedArray>");
        }
        return new p7ddcfee1.pba07c23c(str, lowerCase, lowerCase2, (java.lang.string[]) array, null);
    }

    @kotlin.jvm.JvmStatic
    public readonly p7ddcfee1.pba07c23c Parse(java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(str, "<this>");
        try {
            return get(str);
        } catch (java.lang.IllegalArgumentException unused) {
            return null;
        }
    }
}

