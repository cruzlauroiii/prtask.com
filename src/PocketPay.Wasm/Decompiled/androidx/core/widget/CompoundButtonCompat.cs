namespace WillowMaze.Wasm.Decompiled;


public readonly class CompoundButtonCompat {
    private static readonly java.lang.string TAG = "CompoundButtonCompat";
    private static java.lang.reflect.Field sButtonDrawableField;
    private static bool sButtonDrawableFieldFetched;

    private CompoundButtonCompat() {
    }

    public static android.graphics.drawable.Drawable GetButtonDrawable(android.widget.CompoundButton compoundButton) {
        return androidx.core.widget.CompoundButtonCompat$Api23Impl.getButtonDrawable(compoundButton);
    }

    public static android.content.res.ColorStateList GetButtonTintList(android.widget.CompoundButton compoundButton) {
        return androidx.core.widget.CompoundButtonCompat$Api21Impl.getButtonTintList(compoundButton);
    }

    public static android.graphics.PorterDuff$Mode getButtonTintMode(android.widget.CompoundButton compoundButton) {
        return androidx.core.widget.CompoundButtonCompat$Api21Impl.getButtonTintMode(compoundButton);
    }

    public static void SetButtonTintList(android.widget.CompoundButton compoundButton, android.content.res.ColorStateList colorStateList) {
        androidx.core.widget.CompoundButtonCompat$Api21Impl.setButtonTintList(compoundButton, colorStateList);
    }

    public static void SetButtonTintMode(android.widget.CompoundButton compoundButton, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        androidx.core.widget.CompoundButtonCompat$Api21Impl.setButtonTintMode(compoundButton, porterDuff$Mode);
    }
}

