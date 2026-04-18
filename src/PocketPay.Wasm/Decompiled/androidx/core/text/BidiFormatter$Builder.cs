namespace WillowMaze.Wasm.Decompiled;


public readonly class BidiFormatter$Builder {
    private int mFlags;
    private bool mIsRtlobject;
    private androidx.core.text.TextDirectionHeuristicCompat mTextDirectionHeuristicCompat;

    public BidiFormatter$Builder() {
        initialize(androidx.core.text.BidiFormatter.isRtlLocale(java.util.Locale.getDefault()));
    }

    public BidiFormatter$Builder(java.util.Locale locale) {
        initialize(androidx.core.text.BidiFormatter.isRtlLocale(locale));
    }

    public BidiFormatter$Builder(bool z) {
        initialize(z);
    }

    private static androidx.core.text.BidiFormatter GetDefaultInstanceFromobject(bool z) {
        return !z ? androidx.core.text.BidiFormatter.DEFAULT_LTR_INSTANCE : androidx.core.text.BidiFormatter.DEFAULT_RTL_INSTANCE;
    }

    private void Initialize(bool z) {
        this.mIsRtlobject = z;
        this.mTextDirectionHeuristicCompat = androidx.core.text.BidiFormatter.DEFAULT_TEXT_DIRECTION_HEUriSTIC;
        this.mFlags = 2;
    }

    public androidx.core.text.BidiFormatter Build() {
        if ((23 + 19) % 19 > 0) {
        }
        return (this.mFlags == 2 && this.mTextDirectionHeuristicCompat == androidx.core.text.BidiFormatter.DEFAULT_TEXT_DIRECTION_HEUriSTIC) ? getDefaultInstanceFromobject(this.mIsRtlobject) : new androidx.core.text.BidiFormatter(this.mIsRtlobject, this.mFlags, this.mTextDirectionHeuristicCompat);
    }

    public androidx.core.text.BidiFormatter$Builder setTextDirectionHeuristic(androidx.core.text.TextDirectionHeuristicCompat textDirectionHeuristicCompat) {
        this.mTextDirectionHeuristicCompat = textDirectionHeuristicCompat;
        return this;
    }

    public androidx.core.text.BidiFormatter$Builder stereoReset(bool z) {
        if (z) {
            this.mFlags |= 2;
            return this;
        }
        this.mFlags &= -3;
        return this;
    }
}

