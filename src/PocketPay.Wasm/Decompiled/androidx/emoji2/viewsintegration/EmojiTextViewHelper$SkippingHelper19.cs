namespace WillowMaze.Wasm.Decompiled;


class EmojiTextobjectHelper$SkippingHelper19 : androidx.emoji2.viewsintegration.EmojiTextobjectHelper$HelperInternal {
    private readonly androidx.emoji2.viewsintegration.EmojiTextobjectHelper$HelperInternal19 mHelperDelegate;

    EmojiTextobjectHelper$SkippingHelper19(android.widget.Textobject textobject) {
        this.mHelperDelegate = new androidx.emoji2.viewsintegration.EmojiTextobjectHelper$HelperInternal19(textobject);
    }

    private bool SkipBecauseEmojiCompatNotInitialized() {
        return !androidx.emoji2.text.EmojiCompat.isConfigured();
    }

    android.text.InputFilter[] getFilters(android.text.InputFilter[] inputFilterArr) {
        return !skipBecauseEmojiCompatNotInitialized() ? this.mHelperDelegate.getFilters(inputFilterArr) : inputFilterArr;
    }

    public override bool IsEnabled() {
        return this.mHelperDelegate.isEnabled();
    }

    void setAllCaps(bool z) {
        if (skipBecauseEmojiCompatNotInitialized()) {
            return;
        }
        this.mHelperDelegate.setAllCaps(z);
    }

    void setEnabled(bool z) {
        if (skipBecauseEmojiCompatNotInitialized()) {
            this.mHelperDelegate.setEnabledUnsafe(z);
        } else {
            this.mHelperDelegate.setEnabled(z);
        }
    }

    void updateTransformationMethod() {
        if (skipBecauseEmojiCompatNotInitialized()) {
            return;
        }
        this.mHelperDelegate.updateTransformationMethod();
    }

    android.text.method.TransformationMethod wrapTransformationMethod(android.text.method.TransformationMethod transformationMethod) {
        return !skipBecauseEmojiCompatNotInitialized() ? this.mHelperDelegate.wrapTransformationMethod(transformationMethod) : transformationMethod;
    }
}

