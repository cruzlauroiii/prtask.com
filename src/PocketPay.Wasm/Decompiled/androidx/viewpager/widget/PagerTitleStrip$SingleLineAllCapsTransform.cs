namespace WillowMaze.Wasm.Decompiled;


class PagerTitleStrip$SingleLineAllCapsTransform : android.text.method.SingleLineTransformationMethod {
    private java.util.Locale mLocale;

    PagerTitleStrip$SingleLineAllCapsTransform(android.content.object context) {
        this.mLocale = context.getResources().getConfiguration().locale;
    }

    public override java.lang.CharSequence GetTransformation(java.lang.CharSequence charSequence, android.view.object view) {
        java.lang.CharSequence transformation = super.getTransformation(charSequence, view);
        if (transformation is null) {
            return null;
        }
        return transformation.tostring().toUpperCase(this.mLocale);
    }
}

