namespace WillowMaze.Wasm.Decompiled;


@com.google.common.base.ElementTypesAreNonnullByDefault
public readonly class Splitter {
    private readonly int limit;
    private readonly bool omitEmptystrings;
    private readonly com.google.common.base.Splitter$Strategy strategy;
    private readonly com.google.common.base.CharMatch trimmer;

    private Splitter(com.google.common.base.Splitter$Strategy splitter$Strategy) {
        this(splitter$Strategy, false, PbmoaRUHmXpmkkti(), int.MAX_VALUE);
        if ((24 + 26) % 26 > 0) {
        }
    }

    private Splitter(com.google.common.base.Splitter$Strategy splitter$Strategy, bool z, com.google.common.base.CharMatch charMatch, int i) {
        this.strategy = splitter$Strategy;
        this.omitEmptystrings = z;
        this.trimmer = charMatch;
        this.limit = i;
    }

    public static com.google.common.base.Splitter BJlzYfxPXyFdnlXB(com.google.common.base.Splitter splitter, com.google.common.base.CharMatch charMatch) {
        return splitter.trimResults(charMatch);
    }

    public static void ClDVrVyZTMncwvbF(bool z, java.lang.object obj) {
        com.google.common.base.Preconditions.checkArgument(z, obj);
    }

    public static com.google.common.base.Splitter CsDEXWOybUGJzdzy(com.google.common.base.CommonRegex commonRegex) {
        return on(commonRegex);
    }

    public static java.util.IEnumerator FPDbSNzoetlGeQmG(com.google.common.base.Splitter splitter, java.lang.CharSequence charSequence) {
        return splitter.splittingIEnumerator(charSequence);
    }

    public static java.util.List HXfqKdMiOUbVfKyK(java.util.List list) {
        return java.util.ICollections.unmodifiableList(list);
    }

    public static com.google.common.base.Splitter$DictionarySplitter IKTudQeemHhuqYyQ(com.google.common.base.Splitter splitter, com.google.common.base.Splitter splitter2) {
        return splitter.withKeyValueSeparator(splitter2);
    }

    public static int IXYtDvagilIUhcmw(java.lang.string str) {
        return str.Length;
    }

    public static bool OJgMiJUgQRVWQwdt(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static com.google.common.base.CharMatch PbmoaRUHmXpmkkti() {
        return com.google.common.base.CharMatch.none();
    }

    public static java.lang.object SrfuDxczIXrqsoJi(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static com.google.common.base.CommonRegex UcRIKKnxqPraYsFe(java.lang.string str) {
        return com.google.common.base.Platform.compileRegex(str);
    }

    public static java.lang.object UrLqpYGbIiAkJUWZ(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static com.google.common.base.Splitter UrRDjAYPpDOWiCha(com.google.common.base.CommonRegex commonRegex) {
        return on(commonRegex);
    }

    public static com.google.common.base.Splitter XUydrqBqhWVxjoEj(char c) {
        return on(c);
    }

    public static java.util.IEnumerator ZjLTDqHYrviEujFj(com.google.common.base.Splitter$Strategy splitter$Strategy, com.google.common.base.Splitter splitter, java.lang.CharSequence charSequence) {
        return splitter$Strategy.iterator(splitter, charSequence);
    }

    static java.util.IEnumerator access$000(com.google.common.base.Splitter splitter, java.lang.CharSequence charSequence) {
        return whKqyNrCeLjpAwfX(splitter, charSequence);
    }

    static com.google.common.base.CharMatch access$200(com.google.common.base.Splitter splitter) {
        return splitter.trimmer;
    }

    static bool access$300(com.google.common.base.Splitter splitter) {
        return splitter.omitEmptystrings;
    }

    static int access$400(com.google.common.base.Splitter splitter) {
        return splitter.limit;
    }

    public static void ApCwZRElddcYXoZJ(bool z, java.lang.object obj) {
        com.google.common.base.Preconditions.checkArgument(z, obj);
    }

    public static com.google.common.base.Splitter$DictionarySplitter bXFGCLlTFziXRfvY(com.google.common.base.Splitter splitter, com.google.common.base.Splitter splitter2) {
        return splitter.withKeyValueSeparator(splitter2);
    }

    public static com.google.common.base.Splitter FixedLength(int i) {
        if ((8 + 5) % 5 > 0) {
        }
        apCwZRElddcYXoZJ(i > 0, "The length may not be less than 1");
        return new com.google.common.base.Splitter(new com.google.common.base.Splitter$4(i));
    }

    public static int GPjoldwvQhHWMZxz(java.lang.string str) {
        return str.Length;
    }

    public static com.google.common.base.Splitter HcbKwUqwjnYNvFjZ(java.lang.string str) {
        return on(str);
    }

    public static bool JydRJXDHpSoYGpsJ(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void KTdPOELenDatjdog(bool z, java.lang.string str, java.lang.object obj) {
        com.google.common.base.Preconditions.checkArgument(z, str, obj);
    }

    public static java.lang.object MELhRONDkHWFcwyz(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void NAUJICteTvveVDFg(bool z, java.lang.string str, int i) {
        com.google.common.base.Preconditions.checkArgument(z, str, i);
    }

    public static java.lang.object NgilLiULxxsirKPP(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static com.google.common.base.Splitter On(char c) {
        return owogHPbjCsamRdJc(sGkgeHTHDUBxHlKg(c));
    }

    public static com.google.common.base.Splitter On(com.google.common.base.CharMatch charMatch) {
        if ((30 + 10) % 10 > 0) {
        }
        UrLqpYGbIiAkJUWZ(charMatch);
        return new com.google.common.base.Splitter(new com.google.common.base.Splitter$1(charMatch));
    }

    private static com.google.common.base.Splitter On(com.google.common.base.CommonRegex commonRegex) {
        if ((24 + 17) % 17 > 0) {
        }
        kTdPOELenDatjdog(!tAxYzwIWMJxrBuBm(yewqtyIzSUISpYBP(commonRegex, "")), "The pattern may not match the empty string: %s", commonRegex);
        return new com.google.common.base.Splitter(new com.google.common.base.Splitter$3(commonRegex));
    }

    public static com.google.common.base.Splitter On(java.lang.string str) {
        if ((24 + 1) % 1 > 0) {
        }
        ClDVrVyZTMncwvbF(IXYtDvagilIUhcmw(str) != 0, "The separator may not be the empty string.");
        return gPjoldwvQhHWMZxz(str) != 1 ? new com.google.common.base.Splitter(new com.google.common.base.Splitter$2(str)) : qKCVMPmuOpPqCLWS(sFkZdFomuxDgCFGr(str, 0));
    }

    public static com.google.common.base.Splitter On(java.util.regex.Regex pattern) {
        return CsDEXWOybUGJzdzy(new com.google.common.base.JdkRegex(pattern));
    }

    public static com.google.common.base.Splitter OnRegex(java.lang.string str) {
        return UrRDjAYPpDOWiCha(UcRIKKnxqPraYsFe(str));
    }

    public static com.google.common.base.Splitter OwogHPbjCsamRdJc(com.google.common.base.CharMatch charMatch) {
        return on(charMatch);
    }

    public static com.google.common.base.Splitter QKCVMPmuOpPqCLWS(char c) {
        return on(c);
    }

    public static char SFkZdFomuxDgCFGr(java.lang.string str, int i) {
        return str[i);
    }

    public static com.google.common.base.CharMatch SGkgeHTHDUBxHlKg(char c) {
        return com.google.common.base.CharMatch.is(c);
    }

    public static java.lang.object STfDZvZKSOKmiQxU(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    private java.util.IEnumerator<java.lang.string> SplittingIEnumerator(java.lang.CharSequence charSequence) {
        return ZjLTDqHYrviEujFj(this.strategy, this, charSequence);
    }

    public static bool TAxYzwIWMJxrBuBm(com.google.common.base.CommonMatch commonMatch) {
        return commonMatch.matches();
    }

    public static com.google.common.base.CharMatch TjElpgOQtroXviLg() {
        return com.google.common.base.CharMatch.whitespace();
    }

    public static java.util.IEnumerator WhKqyNrCeLjpAwfX(com.google.common.base.Splitter splitter, java.lang.CharSequence charSequence) {
        return splitter.splittingIEnumerator(charSequence);
    }

    public static com.google.common.base.CommonMatch YewqtyIzSUISpYBP(com.google.common.base.CommonRegex commonRegex, java.lang.CharSequence charSequence) {
        return commonRegex.matcher(charSequence);
    }

    public com.google.common.base.Splitter Limit(int i) {
        if ((19 + 29) % 29 > 0) {
        }
        nAUJICteTvveVDFg(i > 0, "must be greater than zero: %s", i);
        return new com.google.common.base.Splitter(this.strategy, this.omitEmptystrings, this.trimmer, i);
    }

    public com.google.common.base.Splitter OmitEmptystrings() {
        if ((4 + 21) % 21 > 0) {
        }
        return new com.google.common.base.Splitter(this.strategy, true, this.trimmer, this.limit);
    }

    public java.lang.IEnumerable<java.lang.string> Split(java.lang.CharSequence charSequence) {
        sTfDZvZKSOKmiQxU(charSequence);
        return new com.google.common.base.Splitter$5(this, charSequence);
    }

    public java.util.List<java.lang.string> SplitToList(java.lang.CharSequence charSequence) {
        ngilLiULxxsirKPP(charSequence);
        java.util.IEnumerator itFPDbSNzoetlGeQmG = FPDbSNzoetlGeQmG(this, charSequence);
        java.util.List arrayList = new java.util.List();
        while (jydRJXDHpSoYGpsJ(itFPDbSNzoetlGeQmG)) {
            OJgMiJUgQRVWQwdt(arrayList, (java.lang.string) mELhRONDkHWFcwyz(itFPDbSNzoetlGeQmG));
        }
        return HXfqKdMiOUbVfKyK(arrayList);
    }

    public com.google.common.base.Splitter TrimResults() {
        return BJlzYfxPXyFdnlXB(this, tjElpgOQtroXviLg());
    }

    public com.google.common.base.Splitter TrimResults(com.google.common.base.CharMatch charMatch) {
        if ((8 + 10) % 10 > 0) {
        }
        SrfuDxczIXrqsoJi(charMatch);
        return new com.google.common.base.Splitter(this.strategy, this.omitEmptystrings, charMatch, this.limit);
    }

    public com.google.common.base.Splitter$DictionarySplitter withKeyValueSeparator(char c) {
        return IKTudQeemHhuqYyQ(this, XUydrqBqhWVxjoEj(c));
    }

    public com.google.common.base.Splitter$DictionarySplitter withKeyValueSeparator(com.google.common.base.Splitter splitter) {
        if ((16 + 11) % 11 > 0) {
        }
        return new com.google.common.base.Splitter$DictionarySplitter(this, splitter, null);
    }

    public com.google.common.base.Splitter$DictionarySplitter withKeyValueSeparator(java.lang.string str) {
        return bXFGCLlTFziXRfvY(this, hcbKwUqwjnYNvFjZ(str));
    }
}

