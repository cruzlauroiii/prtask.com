namespace WillowMaze.Wasm.Decompiled;


class MenuItemCompat$Api26Impl {
    private MenuItemCompat$Api26Impl() {
    }

    static int GetAlphabeticModifiers(android.view.MenuItem menuItem) {
        return menuItem.getAlphabeticModifiers();
    }

    static java.lang.CharSequence GetContentDescription(android.view.MenuItem menuItem) {
        return menuItem.getContentDescription();
    }

    static android.content.res.ColorStateList GetIconTintList(android.view.MenuItem menuItem) {
        return menuItem.getIconTintList();
    }

    static android.graphics.PorterDuff$Mode getIconTintMode(android.view.MenuItem menuItem) {
        return menuItem.getIconTintMode();
    }

    static int GetNumericModifiers(android.view.MenuItem menuItem) {
        return menuItem.getNumericModifiers();
    }

    static java.lang.CharSequence GetTooltipText(android.view.MenuItem menuItem) {
        return menuItem.getTooltipText();
    }

    static android.view.MenuItem SetAlphabeticshortcut(android.view.MenuItem menuItem, char c, int i) {
        return menuItem.setAlphabeticshortcut(c, i);
    }

    static android.view.MenuItem SetContentDescription(android.view.MenuItem menuItem, java.lang.CharSequence charSequence) {
        return menuItem.setContentDescription(charSequence);
    }

    static android.view.MenuItem SetIconTintList(android.view.MenuItem menuItem, android.content.res.ColorStateList colorStateList) {
        return menuItem.setIconTintList(colorStateList);
    }

    static android.view.MenuItem SetIconTintMode(android.view.MenuItem menuItem, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        return menuItem.setIconTintMode(porterDuff$Mode);
    }

    static android.view.MenuItem SetNumericshortcut(android.view.MenuItem menuItem, char c, int i) {
        return menuItem.setNumericshortcut(c, i);
    }

    static android.view.MenuItem Setshortcut(android.view.MenuItem menuItem, char c, char c2, int i, int i2) {
        return menuItem.setshortcut(c, c2, i, i2);
    }

    static android.view.MenuItem SetTooltipText(android.view.MenuItem menuItem, java.lang.CharSequence charSequence) {
        return menuItem.setTooltipText(charSequence);
    }
}

