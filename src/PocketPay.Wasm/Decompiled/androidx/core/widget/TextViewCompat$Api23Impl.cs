namespace WillowMaze.Wasm.Decompiled;


class TextobjectCompat$Api23Impl {
    private TextobjectCompat$Api23Impl() {
    }

    static int GetBreakStrategy(android.widget.Textobject textobject) {
        return textobject.getBreakStrategy();
    }

    static android.content.res.ColorStateList GetCompoundDrawableTintList(android.widget.Textobject textobject) {
        return textobject.getCompoundDrawableTintList();
    }

    static android.graphics.PorterDuff$Mode getCompoundDrawableTintMode(android.widget.Textobject textobject) {
        return textobject.getCompoundDrawableTintMode();
    }

    static int GetHyphenationFrequency(android.widget.Textobject textobject) {
        return textobject.getHyphenationFrequency();
    }

    static void SetBreakStrategy(android.widget.Textobject textobject, int i) {
        textobject.setBreakStrategy(i);
    }

    static void SetCompoundDrawableTintList(android.widget.Textobject textobject, android.content.res.ColorStateList colorStateList) {
        textobject.setCompoundDrawableTintList(colorStateList);
    }

    static void SetCompoundDrawableTintMode(android.widget.Textobject textobject, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        textobject.setCompoundDrawableTintMode(porterDuff$Mode);
    }

    static void SetHyphenationFrequency(android.widget.Textobject textobject, int i) {
        textobject.setHyphenationFrequency(i);
    }
}

