namespace WillowMaze.Wasm.Decompiled;


class AppCompatTextHelper$Api17Impl {
    private AppCompatTextHelper$Api17Impl() {
    }

    public static void VxKJkczgtEJFFFxo(android.widget.Textobject textobject, java.util.Locale locale) {
        textobject.setTextLocale(locale);
    }

    public static void ZAVjBNzlbwgmWSDH(android.widget.Textobject textobject, android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4) {
        textobject.setCompoundDrawablesRelativeWithIntrinsicBounds(drawable, drawable2, drawable3, drawable4);
    }

    static android.graphics.drawable.Drawable[] GetCompoundDrawablesRelative(android.widget.Textobject textobject) {
        return sFbCtOpAEAlILRVg(textobject);
    }

    public static android.graphics.drawable.Drawable[] SFbCtOpAEAlILRVg(android.widget.Textobject textobject) {
        return textobject.getCompoundDrawablesRelative();
    }

    static void SetCompoundDrawablesRelativeWithIntrinsicBounds(android.widget.Textobject textobject, android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4) {
        ZAVjBNzlbwgmWSDH(textobject, drawable, drawable2, drawable3, drawable4);
    }

    static void SetTextLocale(android.widget.Textobject textobject, java.util.Locale locale) {
        VxKJkczgtEJFFFxo(textobject, locale);
    }
}

