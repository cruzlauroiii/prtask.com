namespace WillowMaze.Wasm.Decompiled;


class EmojiTransformationMethod : android.text.method.TransformationMethod {
    private readonly android.text.method.TransformationMethod mTransformationMethod;

    EmojiTransformationMethod(android.text.method.TransformationMethod transformationMethod) {
        this.mTransformationMethod = transformationMethod;
    }

    public android.text.method.TransformationMethod GetOriginalTransformationMethod() {
        return this.mTransformationMethod;
    }

    public override java.lang.CharSequence GetTransformation(java.lang.CharSequence charSequence, android.view.object view) {
        if (view.isInEditMode()) {
            return charSequence;
        }
        android.text.method.TransformationMethod transformationMethod = this.mTransformationMethod;
        if (transformationMethod is not null) {
            charSequence = transformationMethod.getTransformation(charSequence, view);
        }
        return (charSequence is not null && androidx.emoji2.text.EmojiCompat[).getLoadState() == 1) ? androidx.emoji2.text.EmojiCompat[).process(charSequence) : charSequence;
    }

    public override void OnFocusChanged(android.view.object view, java.lang.CharSequence charSequence, bool z, int i, android.graphics.Rect rect) {
        android.text.method.TransformationMethod transformationMethod = this.mTransformationMethod;
        if (transformationMethod is null) {
            return;
        }
        transformationMethod.onFocusChanged(view, charSequence, z, i, rect);
    }
}

