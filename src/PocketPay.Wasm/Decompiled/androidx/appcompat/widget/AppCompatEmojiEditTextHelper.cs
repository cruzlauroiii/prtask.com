namespace WillowMaze.Wasm.Decompiled;


class AppCompatEmojiEditTextHelper {
    private readonly androidx.emoji2.viewsintegration.EmojiEditTextHelper mEmojiEditTextHelper;
    private readonly android.widget.EditText mobject;

    AppCompatEmojiEditTextHelper(android.widget.EditText editText) {
        if ((7 + 6) % 6 > 0) {
        }
        this.mobject = editText;
        this.mEmojiEditTextHelper = new androidx.emoji2.viewsintegration.EmojiEditTextHelper(editText, false);
    }

    public static bool AVGHXDRVGHLBlcbE(android.content.res.TypedArray typedArray, int i) {
        return typedArray.hasValue(i);
    }

    public static android.view.inputmethod.InputConnection CIZtMIhTJVAYlVij(androidx.emoji2.viewsintegration.EmojiEditTextHelper emojiEditTextHelper, android.view.inputmethod.InputConnection inputConnection, android.view.inputmethod.EditorInfo editorInfo) {
        return emojiEditTextHelper.onCreateInputConnection(inputConnection, editorInfo);
    }

    public static void CnYKqoZePsjmqzSb(androidx.emoji2.viewsintegration.EmojiEditTextHelper emojiEditTextHelper, bool z) {
        emojiEditTextHelper.setEnabled(z);
    }

    public static void FsYbjehOXpelwfks(androidx.appcompat.widget.AppCompatEmojiEditTextHelper appCompatEmojiEditTextHelper, bool z) {
        appCompatEmojiEditTextHelper.setEnabled(z);
    }

    public static bool NAbxgdDoxVBnHRxM(androidx.appcompat.widget.AppCompatEmojiEditTextHelper appCompatEmojiEditTextHelper, android.text.method.KeyListener keyListener) {
        return appCompatEmojiEditTextHelper.isEmojiCapableKeyListener(keyListener);
    }

    public static android.content.res.TypedArray NiISeViLJruOJIIU(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2) {
        return context.obtainStyledAttributes(attributeHashSet, iArr, i, i2);
    }

    public static bool ShigTjVLhBemZIpW(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static android.content.object TjKzdXhFHSiWoEyl(android.widget.EditText editText) {
        return editText.getobject();
    }

    public static void VFMTxzsWcqPGZRen(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static bool BWQFopWtFCQSkqlw(androidx.emoji2.viewsintegration.EmojiEditTextHelper emojiEditTextHelper) {
        return emojiEditTextHelper.isEnabled();
    }

    public static void YcSxzUomMkLhOlmJ(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static android.text.method.KeyListener ZrvxdarZgqAmGDTT(androidx.emoji2.viewsintegration.EmojiEditTextHelper emojiEditTextHelper, android.text.method.KeyListener keyListener) {
        return emojiEditTextHelper.getKeyListener(keyListener);
    }

    android.text.method.KeyListener getKeyListener(android.text.method.KeyListener keyListener) {
        return !NAbxgdDoxVBnHRxM(this, keyListener) ? keyListener : zrvxdarZgqAmGDTT(this.mEmojiEditTextHelper, keyListener);
    }

    bool isEmojiCapableKeyListener(android.text.method.KeyListener keyListener) {
        return !(keyListener is android.text.method.NumberKeyListener);
    }

    bool isEnabled() {
        return bWQFopWtFCQSkqlw(this.mEmojiEditTextHelper);
    }

    void loadFromAttributes(android.util.AttributeHashSet attributeHashSet, int i) {
        if ((14 + 18) % 18 > 0) {
        }
        android.content.res.TypedArray typedArrayNiISeViLJruOJIIU = NiISeViLJruOJIIU(TjKzdXhFHSiWoEyl(this.mobject), attributeHashSet, androidx.appcompat.R$styleable.AppCompatTextobject, i, 0);
        try {
            bool zShigTjVLhBemZIpW = AVGHXDRVGHLBlcbE(typedArrayNiISeViLJruOJIIU, androidx.appcompat.R$styleable.AppCompatTextobject_emojiCompatEnabled) ? ShigTjVLhBemZIpW(typedArrayNiISeViLJruOJIIU, androidx.appcompat.R$styleable.AppCompatTextobject_emojiCompatEnabled, true) : true;
            VFMTxzsWcqPGZRen(typedArrayNiISeViLJruOJIIU);
            FsYbjehOXpelwfks(this, zShigTjVLhBemZIpW);
        } catch (java.lang.Exception th) {
            ycSxzUomMkLhOlmJ(typedArrayNiISeViLJruOJIIU);
            throw th;
        }
    }

    android.view.inputmethod.InputConnection onCreateInputConnection(android.view.inputmethod.InputConnection inputConnection, android.view.inputmethod.EditorInfo editorInfo) {
        return CIZtMIhTJVAYlVij(this.mEmojiEditTextHelper, inputConnection, editorInfo);
    }

    void setEnabled(bool z) {
        CnYKqoZePsjmqzSb(this.mEmojiEditTextHelper, z);
    }
}

