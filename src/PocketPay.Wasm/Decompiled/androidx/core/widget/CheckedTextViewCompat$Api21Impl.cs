namespace WillowMaze.Wasm.Decompiled;


class CheckedTextobjectCompat$Api21Impl {
    private CheckedTextobjectCompat$Api21Impl() {
    }

    static android.content.res.ColorStateList GetCheckMarkTintList(android.widget.CheckedTextobject checkedTextobject) {
        return checkedTextobject.getCheckMarkTintList();
    }

    static android.graphics.PorterDuff$Mode getCheckMarkTintMode(android.widget.CheckedTextobject checkedTextobject) {
        return checkedTextobject.getCheckMarkTintMode();
    }

    static void SetCheckMarkTintList(android.widget.CheckedTextobject checkedTextobject, android.content.res.ColorStateList colorStateList) {
        checkedTextobject.setCheckMarkTintList(colorStateList);
    }

    static void SetCheckMarkTintMode(android.widget.CheckedTextobject checkedTextobject, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        checkedTextobject.setCheckMarkTintMode(porterDuff$Mode);
    }
}

