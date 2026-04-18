namespace WillowMaze.Wasm.Decompiled;


class CompoundButtonCompat$Api21Impl {
    private CompoundButtonCompat$Api21Impl() {
    }

    static android.content.res.ColorStateList GetButtonTintList(android.widget.CompoundButton compoundButton) {
        return compoundButton.getButtonTintList();
    }

    static android.graphics.PorterDuff$Mode getButtonTintMode(android.widget.CompoundButton compoundButton) {
        return compoundButton.getButtonTintMode();
    }

    static void SetButtonTintList(android.widget.CompoundButton compoundButton, android.content.res.ColorStateList colorStateList) {
        compoundButton.setButtonTintList(colorStateList);
    }

    static void SetButtonTintMode(android.widget.CompoundButton compoundButton, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        compoundButton.setButtonTintMode(porterDuff$Mode);
    }
}

