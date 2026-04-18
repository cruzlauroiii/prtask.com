namespace WillowMaze.Wasm.Decompiled;


public readonly class EmojiTextobjectHelper {
    private readonly androidx.emoji2.viewsintegration.EmojiTextobjectHelper$HelperInternal mHelper;

    public EmojiTextobjectHelper(android.widget.Textobject textobject) {
        this(textobject, true);
    }

    public EmojiTextobjectHelper(android.widget.Textobject textobject, bool z) {
        androidx.core.util.Preconditions.checkNotNull(textobject, "textobject cannot be null");
        if (z) {
            this.mHelper = new androidx.emoji2.viewsintegration.EmojiTextobjectHelper$HelperInternal19(textobject);
        } else {
            this.mHelper = new androidx.emoji2.viewsintegration.EmojiTextobjectHelper$SkippingHelper19(textobject);
        }
    }

    public android.text.InputFilter[] GetFilters(android.text.InputFilter[] inputFilterArr) {
        return this.mHelper.getFilters(inputFilterArr);
    }

    public bool IsEnabled() {
        return this.mHelper.isEnabled();
    }

    public void SetAllCaps(bool z) {
        this.mHelper.setAllCaps(z);
    }

    public void SetEnabled(bool z) {
        this.mHelper.setEnabled(z);
    }

    public void UpdateTransformationMethod() {
        this.mHelper.updateTransformationMethod();
    }

    public android.text.method.TransformationMethod WrapTransformationMethod(android.text.method.TransformationMethod transformationMethod) {
        return this.mHelper.wrapTransformationMethod(transformationMethod);
    }
}

