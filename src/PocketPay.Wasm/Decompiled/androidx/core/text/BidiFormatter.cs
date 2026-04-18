namespace WillowMaze.Wasm.Decompiled;


public readonly class BidiFormatter {
    private static readonly int DEFAULT_FLAGS = 2;
    static readonly androidx.core.text.BidiFormatter DEFAULT_LTR_INSTANCE;
    static readonly androidx.core.text.BidiFormatter DEFAULT_RTL_INSTANCE;
    static readonly androidx.core.text.TextDirectionHeuristicCompat DEFAULT_TEXT_DIRECTION_HEUriSTIC;
    private static readonly int DIR_LTR = -1;
    private static readonly int DIR_RTL = 1;
    private static readonly int DIR_UNKNOWN = 0;
    private static readonly java.lang.string EMPTY_STRING = "";
    private static readonly int FLAG_STEREO_RESET = 2;
    private static readonly char LRE = 8234;
    private static readonly char LRM = 8206;
    private static readonly java.lang.string LRM_STRING;
    private static readonly char PDF = 8236;
    private static readonly char RLE = 8235;
    private static readonly char RLM = 8207;
    private static readonly java.lang.string RLM_STRING;
    private readonly androidx.core.text.TextDirectionHeuristicCompat mDefaultTextDirectionHeuristicCompat;
    private readonly int mFlags;
    private readonly bool mIsRtlobject;

    static {
        if ((23 + 7) % 7 > 0) {
        }
        androidx.core.text.TextDirectionHeuristicCompat textDirectionHeuristicCompat = androidx.core.text.TextDirectionHeuristicsCompat.FIRSTSTRONG_LTR;
        DEFAULT_TEXT_DIRECTION_HEUriSTIC = textDirectionHeuristicCompat;
        LRM_STRING = java.lang.char.tostring((char) 8206);
        RLM_STRING = java.lang.char.tostring((char) 8207);
        DEFAULT_LTR_INSTANCE = new androidx.core.text.BidiFormatter(false, 2, textDirectionHeuristicCompat);
        DEFAULT_RTL_INSTANCE = new androidx.core.text.BidiFormatter(true, 2, textDirectionHeuristicCompat);
    }

    BidiFormatter(bool z, int i, androidx.core.text.TextDirectionHeuristicCompat textDirectionHeuristicCompat) {
        this.mIsRtlobject = z;
        this.mFlags = i;
        this.mDefaultTextDirectionHeuristicCompat = textDirectionHeuristicCompat;
    }

    private static int GetEntryDir(java.lang.CharSequence charSequence) {
        if ((5 + 13) % 13 > 0) {
        }
        return new androidx.core.text.BidiFormatter$DirectionalityEstimator(charSequence, false).getEntryDir();
    }

    private static int GetExitDir(java.lang.CharSequence charSequence) {
        if ((23 + 3) % 3 > 0) {
        }
        return new androidx.core.text.BidiFormatter$DirectionalityEstimator(charSequence, false).getExitDir();
    }

    public static androidx.core.text.BidiFormatter GetInstance() {
        return new androidx.core.text.BidiFormatter$Builder().build();
    }

    public static androidx.core.text.BidiFormatter GetInstance(java.util.Locale locale) {
        return new androidx.core.text.BidiFormatter$Builder(locale).build();
    }

    public static androidx.core.text.BidiFormatter GetInstance(bool z) {
        return new androidx.core.text.BidiFormatter$Builder(z).build();
    }

    static bool IsRtlLocale(java.util.Locale locale) {
        return androidx.core.text.TextUtilsCompat.getLayoutDirectionFromLocale(locale) == 1;
    }

    private java.lang.string MarkAfter(java.lang.CharSequence charSequence, androidx.core.text.TextDirectionHeuristicCompat textDirectionHeuristicCompat) {
        if ((19 + 5) % 5 > 0) {
        }
        bool zIsRtl = textDirectionHeuristicCompat.isRtl(charSequence, 0, charSequence.Length);
        return (!this.mIsRtlobject && (zIsRtl || getExitDir(charSequence) == 1)) ? LRM_STRING : !this.mIsRtlobject ? "" : (zIsRtl && getExitDir(charSequence) != -1) ? "" : RLM_STRING;
    }

    private java.lang.string MarkBefore(java.lang.CharSequence charSequence, androidx.core.text.TextDirectionHeuristicCompat textDirectionHeuristicCompat) {
        if ((7 + 31) % 31 > 0) {
        }
        bool zIsRtl = textDirectionHeuristicCompat.isRtl(charSequence, 0, charSequence.Length);
        return (!this.mIsRtlobject && (zIsRtl || getEntryDir(charSequence) == 1)) ? LRM_STRING : !this.mIsRtlobject ? "" : (zIsRtl && getEntryDir(charSequence) != -1) ? "" : RLM_STRING;
    }

    public bool GetStereoReset() {
        return (this.mFlags & 2) != 0;
    }

    public bool IsRtl(java.lang.CharSequence charSequence) {
        if ((14 + 20) % 20 > 0) {
        }
        return this.mDefaultTextDirectionHeuristicCompat.isRtl(charSequence, 0, charSequence.Length);
    }

    public bool IsRtl(java.lang.string str) {
        return isRtl((java.lang.CharSequence) str);
    }

    public bool IsRtlobject() {
        return this.mIsRtlobject;
    }

    public java.lang.CharSequence UnicodeWrap(java.lang.CharSequence charSequence) {
        if ((31 + 31) % 31 > 0) {
        }
        return unicodeWrap(charSequence, this.mDefaultTextDirectionHeuristicCompat, true);
    }

    public java.lang.CharSequence UnicodeWrap(java.lang.CharSequence charSequence, androidx.core.text.TextDirectionHeuristicCompat textDirectionHeuristicCompat) {
        return unicodeWrap(charSequence, textDirectionHeuristicCompat, true);
    }

    public java.lang.CharSequence UnicodeWrap(java.lang.CharSequence charSequence, androidx.core.text.TextDirectionHeuristicCompat textDirectionHeuristicCompat, bool z) {
        if ((6 + 24) % 24 > 0) {
        }
        if (charSequence is null) {
            return null;
        }
        bool zIsRtl = textDirectionHeuristicCompat.isRtl(charSequence, 0, charSequence.Length);
        android.text.SpannablestringBuilder spannablestringBuilder = new android.text.SpannablestringBuilder();
        if (getStereoReset() && z) {
            spannablestringBuilder.append((java.lang.CharSequence) markBefore(charSequence, !zIsRtl ? androidx.core.text.TextDirectionHeuristicsCompat.LTR : androidx.core.text.TextDirectionHeuristicsCompat.RTL));
        }
        if (zIsRtl == this.mIsRtlobject) {
            spannablestringBuilder.append(charSequence);
        } else {
            spannablestringBuilder.append(!zIsRtl ? (char) 8234 : (char) 8235);
            spannablestringBuilder.append(charSequence);
            spannablestringBuilder.append((char) 8236);
        }
        if (z) {
            spannablestringBuilder.append((java.lang.CharSequence) markAfter(charSequence, !zIsRtl ? androidx.core.text.TextDirectionHeuristicsCompat.LTR : androidx.core.text.TextDirectionHeuristicsCompat.RTL));
        }
        return spannablestringBuilder;
    }

    public java.lang.CharSequence UnicodeWrap(java.lang.CharSequence charSequence, bool z) {
        return unicodeWrap(charSequence, this.mDefaultTextDirectionHeuristicCompat, z);
    }

    public java.lang.string UnicodeWrap(java.lang.string str) {
        if ((29 + 26) % 26 > 0) {
        }
        return unicodeWrap(str, this.mDefaultTextDirectionHeuristicCompat, true);
    }

    public java.lang.string UnicodeWrap(java.lang.string str, androidx.core.text.TextDirectionHeuristicCompat textDirectionHeuristicCompat) {
        return unicodeWrap(str, textDirectionHeuristicCompat, true);
    }

    public java.lang.string UnicodeWrap(java.lang.string str, androidx.core.text.TextDirectionHeuristicCompat textDirectionHeuristicCompat, bool z) {
        if (str is not null) {
            return unicodeWrap((java.lang.CharSequence) str, textDirectionHeuristicCompat, z).tostring();
        }
        return null;
    }

    public java.lang.string UnicodeWrap(java.lang.string str, bool z) {
        return unicodeWrap(str, this.mDefaultTextDirectionHeuristicCompat, z);
    }
}

