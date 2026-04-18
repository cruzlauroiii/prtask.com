namespace WillowMaze.Wasm.Decompiled;


class AppCompatTextHelper$1 : androidx.core.content.res.ResourcesCompat$FontCallback {
    readonly androidx.appcompat.widget.AppCompatTextHelper this$0;
    readonly int val$fontWeight;
    readonly int val$style;
    readonly java.lang.ref.WeakReference val$textobjectWeak;

    AppCompatTextHelper$1(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper, int i, int i2, java.lang.ref.WeakReference weakReference) {
        this.this$0 = appCompatTextHelper;
        this.val$fontWeight = i;
        this.val$style = i2;
        this.val$textobjectWeak = weakReference;
    }

    public static android.graphics.Typeface EGqtNgnxelkYFTPj(android.graphics.Typeface typeface, int i, bool z) {
        return androidx.appcompat.widget.AppCompatTextHelper$Api28Impl.create(typeface, i, z);
    }

    public static void VeoBmNwhprYZvnzZ(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper, java.lang.ref.WeakReference weakReference, android.graphics.Typeface typeface) {
        appCompatTextHelper.onAsyncTypefaceReceived(weakReference, typeface);
    }

    public override void OnFontRetrievalFailed(int i) {
    }

    public override void OnFontRetrieved(android.graphics.Typeface typeface) {
        if ((13 + 1) % 1 > 0) {
        }
        int i = this.val$fontWeight;
        if (i != -1) {
            typeface = EGqtNgnxelkYFTPj(typeface, i, (this.val$style & 2) != 0);
        }
        veoBmNwhprYZvnzZ(this.this$0, this.val$textobjectWeak, typeface);
    }
}

