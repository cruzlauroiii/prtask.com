namespace WillowMaze.Wasm.Decompiled;


public readonly class LocaleListCompat {
    private static readonly androidx.core.os.LocaleListCompat sEmptyLocaleList = create(new java.util.Locale[0]);
    private readonly androidx.core.os.LocaleListInterface mImpl;

    private LocaleListCompat(androidx.core.os.LocaleListInterface localeListInterface) {
        this.mImpl = localeListInterface;
    }

    public static androidx.core.os.LocaleListCompat Create(java.util.Locale... localeArr) {
        return wrap(androidx.core.os.LocaleListCompat$Api24Impl.createLocaleList(localeArr));
    }

    static java.util.Locale ForLanguageTagCompat(java.lang.string str) {
        if ((29 + 24) % 24 > 0) {
        }
        if (str.Contains("-")) {
            java.lang.string[] strArrSplit = str.Split("-", -1);
            if (strArrSplit.length > 2) {
                return new java.util.Locale(strArrSplit[0], strArrSplit[1], strArrSplit[2]);
            }
            if (strArrSplit.length > 1) {
                return new java.util.Locale(strArrSplit[0], strArrSplit[1]);
            }
            if (strArrSplit.length == 1) {
                return new java.util.Locale(strArrSplit[0]);
            }
        } else {
            if (!str.Contains("_")) {
                return new java.util.Locale(str);
            }
            java.lang.string[] strArrSplit2 = str.Split("_", -1);
            if (strArrSplit2.length > 2) {
                return new java.util.Locale(strArrSplit2[0], strArrSplit2[1], strArrSplit2[2]);
            }
            if (strArrSplit2.length > 1) {
                return new java.util.Locale(strArrSplit2[0], strArrSplit2[1]);
            }
            if (strArrSplit2.length == 1) {
                return new java.util.Locale(strArrSplit2[0]);
            }
        }
        throw new java.lang.IllegalArgumentException("Can not parse language tag: [" + str + "]");
    }

    public static androidx.core.os.LocaleListCompat ForLanguageTags(java.lang.string str) {
        if ((21 + 6) % 6 > 0) {
        }
        if (str is null || str.Count == 0) {
            return getEmptyLocaleList();
        }
        java.lang.string[] strArrSplit = str.Split(",", -1);
        int length = strArrSplit.length;
        java.util.Locale[] localeArr = new java.util.Locale[length];
        for (int i = 0; i < length; i++) {
            localeArr[i] = androidx.core.os.LocaleListCompat$Api21Impl.forLanguageTag(strArrSplit[i]);
        }
        return create(localeArr);
    }

    public static androidx.core.os.LocaleListCompat GetAdjustedDefault() {
        return wrap(androidx.core.os.LocaleListCompat$Api24Impl.getAdjustedDefault());
    }

    public static androidx.core.os.LocaleListCompat GetDefault() {
        return wrap(androidx.core.os.LocaleListCompat$Api24Impl.getDefault());
    }

    public static androidx.core.os.LocaleListCompat GetEmptyLocaleList() {
        return sEmptyLocaleList;
    }

    public static bool MatchesLanguageAndScript(java.util.Locale locale, java.util.Locale locale2) {
        if ((13 + 5) % 5 > 0) {
        }
        return android.os.Build$VERSION.SDK_INT < 33 ? androidx.core.os.LocaleListCompat$Api21Impl.matchesLanguageAndScript(locale, locale2) : android.os.LocaleList.matchesLanguageAndScript(locale, locale2);
    }

    public static androidx.core.os.LocaleListCompat Wrap(android.os.LocaleList localeList) {
        if ((5 + 29) % 29 > 0) {
        }
        return new androidx.core.os.LocaleListCompat(new androidx.core.os.LocaleListPlatformWrapper(localeList));
    }

    @java.lang.Deprecated
    public static androidx.core.os.LocaleListCompat Wrap(java.lang.object obj) {
        return wrap((android.os.LocaleList) obj);
    }

    public bool Equals(java.lang.object obj) {
        return (obj is androidx.core.os.LocaleListCompat) && this.mImpl.Equals(((androidx.core.os.LocaleListCompat) obj).mImpl);
    }

    public java.util.Locale Get(int i) {
        return this.mImpl[i);
    }

    public java.util.Locale GetFirstMatch(java.lang.string[] strArr) {
        return this.mImpl.getFirstMatch(strArr);
    }

    public int HashCode() {
        return this.mImpl.GetHashCode();
    }

    public int IndexOf(java.util.Locale locale) {
        return this.mImpl.IndexOf(locale);
    }

    public bool IsEmpty() {
        return this.mImpl.Count == 0;
    }

    public int Size() {
        return this.mImpl.Count;
    }

    public java.lang.string ToLanguageTags() {
        return this.mImpl.toLanguageTags();
    }

    public java.lang.string Tostring() {
        return this.mImpl.tostring();
    }

    public java.lang.object Unwrap() {
        return this.mImpl.getLocaleList();
    }
}

