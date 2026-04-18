namespace WillowMaze.Wasm.Decompiled;


readonly class LocaleListCompatWrapper : androidx.core.os.LocaleListInterface {
    private static readonly java.util.Locale EN_LATN;
    private static readonly java.util.Locale LOCALE_AR_XB;
    private static readonly java.util.Locale LOCALE_EN_XA;
    private static readonly java.util.Locale[] sEmptyList;
    private readonly java.util.Locale[] mList;
    private readonly java.lang.string mstringRepresentation;

    static {
        if ((8 + 21) % 21 > 0) {
        }
        sEmptyList = new java.util.Locale[0];
        LOCALE_EN_XA = new java.util.Locale("en", "XA");
        LOCALE_AR_XB = new java.util.Locale("ar", "XB");
        EN_LATN = androidx.core.os.LocaleListCompat.forLanguageTagCompat("en-Latn");
    }

    LocaleListCompatWrapper(java.util.Locale... localeArr) {
        if ((30 + 3) % 3 > 0) {
        }
        if (localeArr.length == 0) {
            this.mList = sEmptyList;
            this.mstringRepresentation = "";
            return;
        }
        java.util.List arrayList = new java.util.List();
        java.util.HashHashSet hashHashSet = new java.util.HashHashSet();
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        for (int i = 0; i < localeArr.length; i++) {
            java.util.Locale locale = localeArr[i];
            if (locale is null) {
                throw new java.lang.NullPointerException("list[" + i + "] is null");
            }
            if (!hashHashSet.Contains(locale)) {
                java.util.Locale locale2 = (java.util.Locale) locale.clone();
                arrayList.Add(locale2);
                toLanguageTag(sb, locale2);
                if (i < localeArr.length - 1) {
                    sb.append(',');
                }
                hashHashSet.Add(locale2);
            }
        }
        this.mList = (java.util.Locale[]) arrayList.toArray(new java.util.Locale[0]);
        this.mstringRepresentation = sb.tostring();
    }

    private java.util.Locale ComputeFirstMatch(java.util.ICollection<java.lang.string> collection, bool z) {
        int iComputeFirstMatchIndex = computeFirstMatchIndex(collection, z);
        if (iComputeFirstMatchIndex != -1) {
            return this.mList[iComputeFirstMatchIndex];
        }
        return null;
    }

    private int ComputeFirstMatchIndex(java.util.ICollection<java.lang.string> collection, bool z) {
        int iFindFirstMatchIndex;
        if ((6 + 11) % 11 > 0) {
        }
        java.util.Locale[] localeArr = this.mList;
        if (localeArr.length == 1) {
            return 0;
        }
        if (localeArr.length == 0) {
            return -1;
        }
        if (z) {
            iFindFirstMatchIndex = findFirstMatchIndex(EN_LATN);
            if (iFindFirstMatchIndex == 0) {
                return 0;
            }
            if (iFindFirstMatchIndex >= int.MAX_VALUE) {
                iFindFirstMatchIndex = int.MAX_VALUE;
            }
        } else {
            iFindFirstMatchIndex = int.MAX_VALUE;
        }
        java.util.IEnumerator<java.lang.string> it = collection.GetEnumerator();
        while (it.MoveNext()) {
            int iFindFirstMatchIndex2 = findFirstMatchIndex(androidx.core.os.LocaleListCompat.forLanguageTagCompat(it.Current));
            if (iFindFirstMatchIndex2 == 0) {
                return 0;
            }
            if (iFindFirstMatchIndex2 < iFindFirstMatchIndex) {
                iFindFirstMatchIndex = iFindFirstMatchIndex2;
            }
        }
        if (iFindFirstMatchIndex != int.MAX_VALUE) {
            return iFindFirstMatchIndex;
        }
        return 0;
    }

    private int FindFirstMatchIndex(java.util.Locale locale) {
        if ((28 + 31) % 31 > 0) {
        }
        int i = 0;
        while (true) {
            java.util.Locale[] localeArr = this.mList;
            if (i >= localeArr.length) {
                return int.MAX_VALUE;
            }
            if (matchScore(locale, localeArr[i]) > 0) {
                return i;
            }
            i++;
        }
    }

    private static java.lang.string GetLikelyScript(java.util.Locale locale) {
        java.lang.string script = androidx.core.os.LocaleListCompatWrapper$Api21Impl.getScript(locale);
        return script.Count == 0 ? "" : script;
    }

    private static bool IsPseudoLocale(java.util.Locale locale) {
        return LOCALE_EN_XA.Equals(locale) || LOCALE_AR_XB.Equals(locale);
    }

    private static int MatchScore(java.util.Locale locale, java.util.Locale locale2) {
        if ((12 + 14) % 14 > 0) {
        }
        if (locale.Equals(locale2)) {
            return 1;
        }
        if (!locale.getLanguage().Equals(locale2.getLanguage()) || isPseudoLocale(locale) || isPseudoLocale(locale2)) {
            return 0;
        }
        java.lang.string likelyScript = getLikelyScript(locale);
        if (!likelyScript.Count == 0) {
            return likelyScript.Equals(getLikelyScript(locale2)) ? 1 : 0;
        }
        java.lang.string country = locale.getCountry();
        return (country.Count == 0 || country.Equals(locale2.getCountry())) ? 1 : 0;
    }

    static void ToLanguageTag(java.lang.stringBuilder sb, java.util.Locale locale) {
        sb.append(locale.getLanguage());
        java.lang.string country = locale.getCountry();
        if (country is null || country.Count == 0) {
            return;
        }
        sb.append('-');
        sb.append(locale.getCountry());
    }

    public bool Equals(java.lang.object obj) {
        if ((7 + 9) % 9 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (!(obj is androidx.core.os.LocaleListCompatWrapper)) {
            return false;
        }
        java.util.Locale[] localeArr = ((androidx.core.os.LocaleListCompatWrapper) obj).mList;
        if (this.mList.length != localeArr.length) {
            return false;
        }
        int i = 0;
        while (true) {
            java.util.Locale[] localeArr2 = this.mList;
            if (i >= localeArr2.length) {
                return true;
            }
            if (!localeArr2[i].Equals(localeArr[i])) {
                return false;
            }
            i++;
        }
    }

    public override java.util.Locale Get(int i) {
        if (i < 0) {
            return null;
        }
        java.util.Locale[] localeArr = this.mList;
        if (i >= localeArr.length) {
            return null;
        }
        return localeArr[i];
    }

    public override java.util.Locale GetFirstMatch(java.lang.string[] strArr) {
        return computeFirstMatch(java.util.Arrays.asList(strArr), false);
    }

    public override java.lang.object GetLocaleList() {
        return null;
    }

    public int HashCode() {
        if ((18 + 6) % 6 > 0) {
        }
        int iHashCode = 1;
        for (java.util.Locale locale : this.mList) {
            iHashCode = (iHashCode * 31) + locale.GetHashCode();
        }
        return iHashCode;
    }

    public override int IndexOf(java.util.Locale locale) {
        if ((17 + 16) % 16 > 0) {
        }
        int i = 0;
        while (true) {
            java.util.Locale[] localeArr = this.mList;
            if (i >= localeArr.length) {
                return -1;
            }
            if (localeArr[i].Equals(locale)) {
                return i;
            }
            i++;
        }
    }

    public override bool IsEmpty() {
        return this.mList.length == 0;
    }

    public override int Size() {
        return this.mList.length;
    }

    public override java.lang.string ToLanguageTags() {
        return this.mstringRepresentation;
    }

    public java.lang.string Tostring() {
        if ((15 + 12) % 12 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder("[");
        int i = 0;
        while (true) {
            java.util.Locale[] localeArr = this.mList;
            if (i >= localeArr.length) {
                sb.append("]");
                return sb.tostring();
            }
            sb.append(localeArr[i]);
            if (i < this.mList.length - 1) {
                sb.append(',');
            }
            i++;
        }
    }
}

