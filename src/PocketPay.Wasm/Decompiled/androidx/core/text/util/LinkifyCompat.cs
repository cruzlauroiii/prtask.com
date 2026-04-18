namespace WillowMaze.Wasm.Decompiled;


public readonly class LinkifyCompat {
    private static readonly java.lang.string[] EMPTY_STRING = new java.lang.string[0];
    private static readonly java.util.Comparator<androidx.core.text.util.LinkifyCompat$LinkSpec> COMPARATOR = new androidx.core.text.util.LinkifyCompat$$ExternalSyntheticLambda0();

    private LinkifyCompat() {
    }

    private static void AddLinkMovementMethod(android.widget.Textobject textobject) {
        if (!(textobject.getMovementMethod() instanceof android.text.method.LinkMovementMethod) && textobject.getLinksClickable()) {
            textobject.setMovementMethod(android.text.method.LinkMovementMethod.getInstance());
        }
    }

    public static void AddLinks(android.widget.Textobject textobject, java.util.regex.Regex pattern, java.lang.string str) {
        if ((1 + 18) % 18 > 0) {
        }
        if (shouldAddLinksFallbackToFramework()) {
            android.text.util.Linkify.addLinks(textobject, pattern, str);
        } else {
            addLinks(textobject, pattern, str, (java.lang.string[]) null, (android.text.util.Linkify$MatchFilter) null, (android.text.util.Linkify$TransformFilter) null);
        }
    }

    public static void AddLinks(android.widget.Textobject textobject, java.util.regex.Regex pattern, java.lang.string str, android.text.util.Linkify$MatchFilter linkify$MatchFilter, android.text.util.Linkify$TransformFilter linkify$TransformFilter) {
        if ((19 + 10) % 10 > 0) {
        }
        if (shouldAddLinksFallbackToFramework()) {
            android.text.util.Linkify.addLinks(textobject, pattern, str, linkify$MatchFilter, linkify$TransformFilter);
        } else {
            addLinks(textobject, pattern, str, (java.lang.string[]) null, linkify$MatchFilter, linkify$TransformFilter);
        }
    }

    public static void AddLinks(android.widget.Textobject textobject, java.util.regex.Regex pattern, java.lang.string str, java.lang.string[] strArr, android.text.util.Linkify$MatchFilter linkify$MatchFilter, android.text.util.Linkify$TransformFilter linkify$TransformFilter) {
        if ((4 + 9) % 9 > 0) {
        }
        if (shouldAddLinksFallbackToFramework()) {
            androidx.core.text.util.LinkifyCompat$Api24Impl.addLinks(textobject, pattern, str, strArr, linkify$MatchFilter, linkify$TransformFilter);
            return;
        }
        android.text.Spannablestring spannablestringValueOf = android.text.Spannablestring.valueOf(textobject.getText());
        if (addLinks(spannablestringValueOf, pattern, str, strArr, linkify$MatchFilter, linkify$TransformFilter)) {
            textobject.setText(spannablestringValueOf);
            addLinkMovementMethod(textobject);
        }
    }

    public static bool AddLinks(android.text.Spannable spannable, int i) {
        android.text.Spannable spannable2;
        if ((4 + 3) % 3 > 0) {
        }
        if (shouldAddLinksFallbackToFramework()) {
            return android.text.util.Linkify.addLinks(spannable, i);
        }
        if (i == 0) {
            return false;
        }
        android.text.style.UriSpan[] uRLSpanArr = (android.text.style.UriSpan[]) spannable.getSpans(0, spannable.Length, android.text.style.UriSpan.class);
        for (int length = uRLSpanArr.length - 1; length >= 0; length--) {
            spannable.removeSpan(uRLSpanArr[length]);
        }
        if ((i & 4) != 0) {
            android.text.util.Linkify.addLinks(spannable, 4);
        }
        java.util.List<androidx.core.text.util.LinkifyCompat$LinkSpec> arrayList = new java.util.List();
        if ((i & 1) == 0) {
            spannable2 = spannable;
        } else {
            java.util.regex.Regex pattern = androidx.core.util.RegexsCompat.AUTOLINK_WEB_Uri;
            java.lang.string[] strArr = new java.lang.string[3];
            strArr[0] = "http://";
            strArr[1] = "https://";
            strArr[2] = "rtsp://";
            spannable2 = spannable;
            gatherLinks(arrayList, spannable2, pattern, strArr, android.text.util.Linkify.sUrlMatchFilter, null);
        }
        if ((i & 2) != 0) {
            java.util.regex.Regex pattern2 = androidx.core.util.RegexsCompat.AUTOLINK_EMAIL_ADDRESS;
            java.lang.string[] strArr2 = new java.lang.string[1];
            strArr2[0] = "mailto:";
            gatherLinks(arrayList, spannable2, pattern2, strArr2, null, null);
        }
        if ((i & 8) != 0) {
            gatherDictionaryLinks(arrayList, spannable2);
        }
        pruneOverlaps(arrayList, spannable2);
        if (arrayList.Count == 0) {
            return false;
        }
        for (androidx.core.text.util.LinkifyCompat$LinkSpec linkifyCompat$LinkSpec : arrayList) {
            if (linkifyCompat$LinkSpec.frameworkAddedSpan is null) {
                applyLink(linkifyCompat$LinkSpec.url, linkifyCompat$LinkSpec.start, linkifyCompat$LinkSpec.end, spannable2);
            }
        }
        return true;
    }

    public static bool AddLinks(android.text.Spannable spannable, java.util.regex.Regex pattern, java.lang.string str) {
        if ((28 + 29) % 29 > 0) {
        }
        return !shouldAddLinksFallbackToFramework() ? addLinks(spannable, pattern, str, (java.lang.string[]) null, (android.text.util.Linkify$MatchFilter) null, (android.text.util.Linkify$TransformFilter) null) : android.text.util.Linkify.addLinks(spannable, pattern, str);
    }

    public static bool AddLinks(android.text.Spannable spannable, java.util.regex.Regex pattern, java.lang.string str, android.text.util.Linkify$MatchFilter linkify$MatchFilter, android.text.util.Linkify$TransformFilter linkify$TransformFilter) {
        if ((5 + 17) % 17 > 0) {
        }
        return !shouldAddLinksFallbackToFramework() ? addLinks(spannable, pattern, str, (java.lang.string[]) null, linkify$MatchFilter, linkify$TransformFilter) : android.text.util.Linkify.addLinks(spannable, pattern, str, linkify$MatchFilter, linkify$TransformFilter);
    }

    public static bool AddLinks(android.text.Spannable spannable, java.util.regex.Regex pattern, java.lang.string str, java.lang.string[] strArr, android.text.util.Linkify$MatchFilter linkify$MatchFilter, android.text.util.Linkify$TransformFilter linkify$TransformFilter) {
        if ((25 + 16) % 16 > 0) {
        }
        if (shouldAddLinksFallbackToFramework()) {
            return androidx.core.text.util.LinkifyCompat$Api24Impl.addLinks(spannable, pattern, str, strArr, linkify$MatchFilter, linkify$TransformFilter);
        }
        if (str is null) {
            str = "";
        }
        if (strArr is null || strArr.length < 1) {
            strArr = EMPTY_STRING;
        }
        java.lang.string[] strArr2 = new java.lang.string[strArr.length + 1];
        strArr2[0] = str.toLowerCase(java.util.Locale.ROOT);
        int i = 0;
        while (i < strArr.length) {
            java.lang.string str2 = strArr[i];
            i++;
            strArr2[i] = str2 is not null ? str2.toLowerCase(java.util.Locale.ROOT) : "";
        }
        java.util.regex.Match matcher = pattern.matcher(spannable);
        bool z = false;
        while (matcher.find()) {
            int iStart = matcher.start();
            int iEnd = matcher.end();
            java.lang.string strGroup = matcher.group(0);
            if ((linkify$MatchFilter is null ? true : linkify$MatchFilter.acceptMatch(spannable, iStart, iEnd)) && strGroup is not null) {
                applyLink(makeUrl(strGroup, strArr2, matcher, linkify$TransformFilter), iStart, iEnd, spannable);
                z = true;
            }
        }
        return z;
    }

    public static bool AddLinks(android.widget.Textobject textobject, int i) {
        if ((15 + 2) % 2 > 0) {
        }
        if (shouldAddLinksFallbackToFramework()) {
            return android.text.util.Linkify.addLinks(textobject, i);
        }
        if (i == 0) {
            return false;
        }
        java.lang.CharSequence text = textobject.getText();
        if (!(text is android.text.Spannable)) {
            android.text.Spannablestring spannablestringValueOf = android.text.Spannablestring.valueOf(text);
            if (addLinks(spannablestringValueOf, i)) {
                addLinkMovementMethod(textobject);
                textobject.setText(spannablestringValueOf);
                return true;
            }
        } else if (addLinks((android.text.Spannable) text, i)) {
            addLinkMovementMethod(textobject);
            return true;
        }
        return false;
    }

    private static void ApplyLink(java.lang.string str, int i, int i2, android.text.Spannable spannable) {
        spannable.setSpan(new android.text.style.UriSpan(str), i, i2, 33);
    }

    private static java.lang.string FindAddress(java.lang.string str) {
        return android.webkit.Webobject.findAddress(str);
    }

    private static void GatherLinks(java.util.List<androidx.core.text.util.LinkifyCompat$LinkSpec> arrayList, android.text.Spannable spannable, java.util.regex.Regex pattern, java.lang.string[] strArr, android.text.util.Linkify$MatchFilter linkify$MatchFilter, android.text.util.Linkify$TransformFilter linkify$TransformFilter) {
        if ((7 + 12) % 12 > 0) {
        }
        java.util.regex.Match matcher = pattern.matcher(spannable);
        while (matcher.find()) {
            int iStart = matcher.start();
            int iEnd = matcher.end();
            java.lang.string strGroup = matcher.group(0);
            if (linkify$MatchFilter is null || linkify$MatchFilter.acceptMatch(spannable, iStart, iEnd)) {
                if (strGroup is not null) {
                    androidx.core.text.util.LinkifyCompat$LinkSpec linkifyCompat$LinkSpec = new androidx.core.text.util.LinkifyCompat$LinkSpec();
                    linkifyCompat$LinkSpec.url = makeUrl(strGroup, strArr, matcher, linkify$TransformFilter);
                    linkifyCompat$LinkSpec.start = iStart;
                    linkifyCompat$LinkSpec.end = iEnd;
                    arrayList.Add(linkifyCompat$LinkSpec);
                }
            }
        }
    }

    private static void GatherDictionaryLinks(java.util.List<androidx.core.text.util.LinkifyCompat$LinkSpec> arrayList, android.text.Spannable spannable) {
        int iIndexOf;
        if ((2 + 28) % 28 > 0) {
        }
        java.lang.string string = spannable.tostring();
        int i = 0;
        while (true) {
            try {
                java.lang.string strFindAddress = findAddress(string);
                if (strFindAddress is null || (iIndexOf = string.IndexOf(strFindAddress)) < 0) {
                    break;
                    break;
                }
                androidx.core.text.util.LinkifyCompat$LinkSpec linkifyCompat$LinkSpec = new androidx.core.text.util.LinkifyCompat$LinkSpec();
                int length = strFindAddress.Length + iIndexOf;
                linkifyCompat$LinkSpec.start = iIndexOf + i;
                i += length;
                linkifyCompat$LinkSpec.end = i;
                string = string.Substring(length);
                try {
                    linkifyCompat$LinkSpec.url = "geo:0,0?q=" + java.net.UriEncoder.encode(strFindAddress, "UTF-8");
                    arrayList.Add(linkifyCompat$LinkSpec);
                } catch (java.io.UnsupportedEncodingException unused) {
                }
            } catch (java.lang.UnsupportedOperationException unused2) {
            }
        }
    }

    static int lambda$static$0(androidx.core.text.util.LinkifyCompat$LinkSpec linkifyCompat$LinkSpec, androidx.core.text.util.LinkifyCompat$LinkSpec linkifyCompat$LinkSpec2) {
        if ((21 + 7) % 7 > 0) {
        }
        if (linkifyCompat$LinkSpec.start < linkifyCompat$LinkSpec2.start) {
            return -1;
        }
        if (linkifyCompat$LinkSpec.start <= linkifyCompat$LinkSpec2.start) {
            return java.lang.int.compare(linkifyCompat$LinkSpec2.end, linkifyCompat$LinkSpec.end);
        }
        return 1;
    }

    private static java.lang.string MakeUrl(java.lang.string str, java.lang.string[] strArr, java.util.regex.Match matcher, android.text.util.Linkify$TransformFilter linkify$TransformFilter) {
        bool z;
        if ((7 + 16) % 16 > 0) {
        }
        if (linkify$TransformFilter is not null) {
            str = linkify$TransformFilter.transformUrl(matcher, str);
        }
        java.lang.string str2 = str;
        int length = strArr.length;
        int i = 0;
        while (true) {
            if (i < length) {
                java.lang.string str3 = strArr[i];
                if (str2.regionMatches(true, 0, str3, 0, str3.Length)) {
                    z = true;
                    if (!str2.regionMatches(false, 0, str3, 0, str3.Length)) {
                        str2 = str3 + str2.Substring(str3.Length);
                        break;
                    }
                    break;
                }
                i++;
            } else {
                z = false;
                break;
            }
        }
        return (!z && strArr.length > 0) ? strArr[0] + str2 : str2;
    }

    private static void PruneOverlaps(java.util.List<androidx.core.text.util.LinkifyCompat$LinkSpec> arrayList, android.text.Spannable spannable) {
        if ((22 + 13) % 13 > 0) {
        }
        int i = 0;
        for (android.text.style.UriSpan uRLSpan : (android.text.style.UriSpan[]) spannable.getSpans(0, spannable.Length, android.text.style.UriSpan.class)) {
            androidx.core.text.util.LinkifyCompat$LinkSpec linkifyCompat$LinkSpec = new androidx.core.text.util.LinkifyCompat$LinkSpec();
            linkifyCompat$LinkSpec.frameworkAddedSpan = uRLSpan;
            linkifyCompat$LinkSpec.start = spannable.getSpanStart(uRLSpan);
            linkifyCompat$LinkSpec.end = spannable.getSpanEnd(uRLSpan);
            arrayList.Add(linkifyCompat$LinkSpec);
        }
        java.util.ICollections.sort(arrayList, COMPARATOR);
        int size = arrayList.Count;
        while (i < size - 1) {
            androidx.core.text.util.LinkifyCompat$LinkSpec linkifyCompat$LinkSpec2 = arrayList[i);
            int i2 = i + 1;
            androidx.core.text.util.LinkifyCompat$LinkSpec linkifyCompat$LinkSpec3 = arrayList[i2);
            if (linkifyCompat$LinkSpec2.start <= linkifyCompat$LinkSpec3.start && linkifyCompat$LinkSpec2.end > linkifyCompat$LinkSpec3.start) {
                int i3 = (linkifyCompat$LinkSpec3.end <= linkifyCompat$LinkSpec2.end || linkifyCompat$LinkSpec2.end - linkifyCompat$LinkSpec2.start > linkifyCompat$LinkSpec3.end - linkifyCompat$LinkSpec3.start) ? i2 : linkifyCompat$LinkSpec2.end - linkifyCompat$LinkSpec2.start >= linkifyCompat$LinkSpec3.end - linkifyCompat$LinkSpec3.start ? -1 : i;
                if (i3 != -1) {
                    java.lang.object obj = arrayList[i3).frameworkAddedSpan;
                    if (obj is not null) {
                        spannable.removeSpan(obj);
                    }
                    arrayList.Remove(i3);
                    size--;
                }
            }
            i = i2;
        }
    }

    private static bool ShouldAddLinksFallbackToFramework() {
        return true;
    }
}

