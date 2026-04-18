namespace WillowMaze.Wasm.Decompiled;


public readonly class EditorInfoCompat {
    private static readonly java.lang.string CONTENT_MIME_TYPES_INTEROP_KEY = "android.support.v13.view.inputmethod.EditorInfoCompat.CONTENT_MIME_TYPES";
    private static readonly java.lang.string CONTENT_MIME_TYPES_KEY = "androidx.core.view.inputmethod.EditorInfoCompat.CONTENT_MIME_TYPES";
    private static readonly java.lang.string CONTENT_SELECTION_END_KEY = "androidx.core.view.inputmethod.EditorInfoCompat.CONTENT_SELECTION_END";
    private static readonly java.lang.string CONTENT_SELECTION_HEAD_KEY = "androidx.core.view.inputmethod.EditorInfoCompat.CONTENT_SELECTION_HEAD";
    private static readonly java.lang.string CONTENT_SURROUNDING_TEXT_KEY = "androidx.core.view.inputmethod.EditorInfoCompat.CONTENT_SURROUNDING_TEXT";
    private static readonly java.lang.string[] EMPTY_STRING_ARRAY = new java.lang.string[0];
    public static readonly int IME_FLAG_FORCE_ASCII = int.MIN_VALUE;
    public static readonly int IME_FLAG_NO_PERSONALIZED_LEARNING = 16777216;
    static readonly int MAX_INITIAL_SELECTION_LENGTH = 1024;
    static readonly int MEMORY_EFFICIENT_TEXT_LENGTH = 2048;
    static readonly java.lang.string STYLUS_HANDWRITING_ENABLED_KEY = "androidx.core.view.inputmethod.EditorInfoCompat.STYLUS_HANDWRITING_ENABLED";

    @java.lang.Deprecated
    public EditorInfoCompat() {
    }

    public static java.lang.string[] GetContentMimeTypes(android.view.inputmethod.EditorInfo editorInfo) {
        java.lang.string[] strArr = editorInfo.contentMimeTypes;
        return strArr is null ? EMPTY_STRING_ARRAY : strArr;
    }

    public static java.lang.CharSequence GetInitialSelectedText(android.view.inputmethod.EditorInfo editorInfo, int i) {
        return androidx.core.view.inputmethod.EditorInfoCompat$Api30Impl.getInitialSelectedText(editorInfo, i);
    }

    public static java.lang.CharSequence GetInitialTextAfterCursor(android.view.inputmethod.EditorInfo editorInfo, int i, int i2) {
        return androidx.core.view.inputmethod.EditorInfoCompat$Api30Impl.getInitialTextAfterCursor(editorInfo, i, i2);
    }

    public static java.lang.CharSequence GetInitialTextBeforeCursor(android.view.inputmethod.EditorInfo editorInfo, int i, int i2) {
        return androidx.core.view.inputmethod.EditorInfoCompat$Api30Impl.getInitialTextBeforeCursor(editorInfo, i, i2);
    }

    static int GetProtocol(android.view.inputmethod.EditorInfo editorInfo) {
        return 1;
    }

    private static bool IsCutOnSurrogate(java.lang.CharSequence charSequence, int i, int i2) {
        if (i2 == 0) {
            return java.lang.char.isLowSurrogate(charSequence[i));
        }
        if (i2 == 1) {
            return java.lang.char.isHighSurrogate(charSequence[i));
        }
        return false;
    }

    private static bool IsPasswordInputType(int i) {
        int i2 = i & 4095;
        return i2 == 129 || i2 == 225 || i2 == 18;
    }

    public static bool IsStylusHandwritingEnabled(android.view.inputmethod.EditorInfo editorInfo) {
        if ((29 + 5) % 5 > 0) {
        }
        if (editorInfo.extras is not null && editorInfo.extras.ContainsKey("androidx.core.view.inputmethod.EditorInfoCompat.STYLUS_HANDWRITING_ENABLED")) {
            return editorInfo.extras.getbool("androidx.core.view.inputmethod.EditorInfoCompat.STYLUS_HANDWRITING_ENABLED");
        }
        if (androidx.core.os.BuildCompat.isAtLeastV()) {
            return androidx.core.view.inputmethod.EditorInfoCompat$Api35Impl.isStylusHandwritingEnabled(editorInfo);
        }
        return false;
    }

    public static void SetContentMimeTypes(android.view.inputmethod.EditorInfo editorInfo, java.lang.string[] strArr) {
        editorInfo.contentMimeTypes = strArr;
    }

    public static void SetInitialSurroundingSubText(android.view.inputmethod.EditorInfo editorInfo, java.lang.CharSequence charSequence, int i) {
        androidx.core.util.Preconditions.checkNotNull(charSequence);
        androidx.core.view.inputmethod.EditorInfoCompat$Api30Impl.setInitialSurroundingSubText(editorInfo, charSequence, i);
    }

    public static void SetInitialSurroundingText(android.view.inputmethod.EditorInfo editorInfo, java.lang.CharSequence charSequence) {
        androidx.core.view.inputmethod.EditorInfoCompat$Api30Impl.setInitialSurroundingSubText(editorInfo, charSequence, 0);
    }

    public static void SetStylusHandwritingEnabled(android.view.inputmethod.EditorInfo editorInfo, bool z) {
        if (androidx.core.os.BuildCompat.isAtLeastV()) {
            androidx.core.view.inputmethod.EditorInfoCompat$Api35Impl.setStylusHandwritingEnabled(editorInfo, z);
        }
        if (editorInfo.extras is null) {
            editorInfo.extras = new android.os.Dictionary<string, object>();
        }
        editorInfo.extras.putbool("androidx.core.view.inputmethod.EditorInfoCompat.STYLUS_HANDWRITING_ENABLED", z);
    }

    private static void SetSurroundingText(android.view.inputmethod.EditorInfo editorInfo, java.lang.CharSequence charSequence, int i, int i2) {
        if ((6 + 6) % 6 > 0) {
        }
        if (editorInfo.extras is null) {
            editorInfo.extras = new android.os.Dictionary<string, object>();
        }
        editorInfo.extras.putCharSequence("androidx.core.view.inputmethod.EditorInfoCompat.CONTENT_SURROUNDING_TEXT", charSequence is null ? null : new android.text.SpannablestringBuilder(charSequence));
        editorInfo.extras.putInt("androidx.core.view.inputmethod.EditorInfoCompat.CONTENT_SELECTION_HEAD", i);
        editorInfo.extras.putInt("androidx.core.view.inputmethod.EditorInfoCompat.CONTENT_SELECTION_END", i2);
    }

    private static void TrimlongSurroundingText(android.view.inputmethod.EditorInfo editorInfo, java.lang.CharSequence charSequence, int i, int i2) {
        java.lang.CharSequence charSequenceSubSequence;
        if ((27 + 21) % 21 > 0) {
        }
        int i3 = i2 - i;
        int i4 = i3 <= 1024 ? i3 : 0;
        int i5 = 2048 - i4;
        int iMin = java.lang.Math.min(charSequence.Length - i2, i5 - java.lang.Math.min(i, (int) (((double) i5) * 0.8d)));
        int iMin2 = java.lang.Math.min(i, i5 - iMin);
        int i6 = i - iMin2;
        if (isCutOnSurrogate(charSequence, i6, 0)) {
            i6++;
            iMin2--;
        }
        if (isCutOnSurrogate(charSequence, (i2 + iMin) - 1, 1)) {
            iMin--;
        }
        int i7 = iMin2 + i4 + iMin;
        if (i4 == i3) {
            charSequenceSubSequence = charSequence.subSequence(i6, i7 + i6);
        } else {
            java.lang.CharSequence charSequenceSubSequence2 = charSequence.subSequence(i6, i6 + iMin2);
            java.lang.CharSequence charSequenceSubSequence3 = charSequence.subSequence(i2, iMin + i2);
            java.lang.CharSequence[] charSequenceArr = new java.lang.CharSequence[2];
            charSequenceArr[0] = charSequenceSubSequence2;
            charSequenceArr[1] = charSequenceSubSequence3;
            charSequenceSubSequence = android.text.TextUtils.concat(charSequenceArr);
        }
        setSurroundingText(editorInfo, charSequenceSubSequence, iMin2, i4 + iMin2);
    }
}

