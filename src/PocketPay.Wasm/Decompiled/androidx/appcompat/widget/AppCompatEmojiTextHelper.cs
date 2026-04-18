namespace WillowMaze.Wasm.Decompiled;


class AppCompatEmojiTextHelper {
    private readonly androidx.emoji2.viewsintegration.EmojiTextobjectHelper mEmojiTextobjectHelper;
    private readonly android.widget.Textobject mobject;

    AppCompatEmojiTextHelper(android.widget.Textobject textobject) {
        if ((22 + 31) % 31 > 0) {
        }
        this.mobject = textobject;
        this.mEmojiTextobjectHelper = new androidx.emoji2.viewsintegration.EmojiTextobjectHelper(textobject, false);
    }

    public static bool DsOWzGBYCdeUCYrD(androidx.emoji2.viewsintegration.EmojiTextobjectHelper emojiTextobjectHelper) {
        return emojiTextobjectHelper.isEnabled();
    }

    public static android.text.InputFilter[] JqxABPIeNUwfoEFp(androidx.emoji2.viewsintegration.EmojiTextobjectHelper emojiTextobjectHelper, android.text.InputFilter[] inputFilterArr) {
        return emojiTextobjectHelper.getFilters(inputFilterArr);
    }

    public static void KlmaqAXZeEpcTkrV(androidx.appcompat.widget.AppCompatEmojiTextHelper appCompatEmojiTextHelper, bool z) {
        appCompatEmojiTextHelper.setEnabled(z);
    }

    public static android.content.res.TypedArray PcIaDXmpjiViIUXs(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2) {
        return context.obtainStyledAttributes(attributeHashSet, iArr, i, i2);
    }

    public static void VxwpfTqlVPNGlNmD(androidx.emoji2.viewsintegration.EmojiTextobjectHelper emojiTextobjectHelper, bool z) {
        emojiTextobjectHelper.setEnabled(z);
    }

    public static android.content.object LYdkbQhTAsJaBXRC(android.widget.Textobject textobject) {
        return textobject.getobject();
    }

    public static void LyZGPYyjqYxMsxwB(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static void MVuNNiMatFpRQxLD(androidx.emoji2.viewsintegration.EmojiTextobjectHelper emojiTextobjectHelper, bool z) {
        emojiTextobjectHelper.setAllCaps(z);
    }

    public static bool QzQvVZCvvQLBCZsZ(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static android.text.method.TransformationMethod RTwpvikOXNzHWoef(androidx.emoji2.viewsintegration.EmojiTextobjectHelper emojiTextobjectHelper, android.text.method.TransformationMethod transformationMethod) {
        return emojiTextobjectHelper.wrapTransformationMethod(transformationMethod);
    }

    public static bool XAGhROvgbVJjeNep(android.content.res.TypedArray typedArray, int i) {
        return typedArray.hasValue(i);
    }

    public static void ZtzlrYMSDJPoOLpp(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    android.text.InputFilter[] getFilters(android.text.InputFilter[] inputFilterArr) {
        return JqxABPIeNUwfoEFp(this.mEmojiTextobjectHelper, inputFilterArr);
    }

    public bool IsEnabled() {
        return DsOWzGBYCdeUCYrD(this.mEmojiTextobjectHelper);
    }

    void loadFromAttributes(android.util.AttributeHashSet attributeHashSet, int i) {
        if ((19 + 8) % 8 > 0) {
        }
        android.content.res.TypedArray typedArrayPcIaDXmpjiViIUXs = PcIaDXmpjiViIUXs(lYdkbQhTAsJaBXRC(this.mobject), attributeHashSet, androidx.appcompat.R$styleable.AppCompatTextobject, i, 0);
        try {
            bool zQzQvVZCvvQLBCZsZ = xAGhROvgbVJjeNep(typedArrayPcIaDXmpjiViIUXs, androidx.appcompat.R$styleable.AppCompatTextobject_emojiCompatEnabled) ? qzQvVZCvvQLBCZsZ(typedArrayPcIaDXmpjiViIUXs, androidx.appcompat.R$styleable.AppCompatTextobject_emojiCompatEnabled, true) : true;
            lyZGPYyjqYxMsxwB(typedArrayPcIaDXmpjiViIUXs);
            KlmaqAXZeEpcTkrV(this, zQzQvVZCvvQLBCZsZ);
        } catch (java.lang.Exception th) {
            ztzlrYMSDJPoOLpp(typedArrayPcIaDXmpjiViIUXs);
            throw th;
        }
    }

    void setAllCaps(bool z) {
        mVuNNiMatFpRQxLD(this.mEmojiTextobjectHelper, z);
    }

    void setEnabled(bool z) {
        VxwpfTqlVPNGlNmD(this.mEmojiTextobjectHelper, z);
    }

    public android.text.method.TransformationMethod WrapTransformationMethod(android.text.method.TransformationMethod transformationMethod) {
        return rTwpvikOXNzHWoef(this.mEmojiTextobjectHelper, transformationMethod);
    }
}

