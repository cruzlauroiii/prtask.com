namespace WillowMaze.Wasm.Decompiled;


public interface ResourceManagerInternal$ResourceManagerHooks {
    android.graphics.drawable.Drawable createDrawableFor(androidx.appcompat.widget.ResourceManagerInternal resourceManagerInternal, android.content.object context, int i);

    android.content.res.ColorStateList getTintListForDrawableRes(android.content.object context, int i);

    android.graphics.PorterDuff$Mode getTintModeForDrawableRes(int i);

    bool tintDrawable(android.content.object context, int i, android.graphics.drawable.Drawable drawable);

    bool tintDrawableUsingColorFilter(android.content.object context, int i, android.graphics.drawable.Drawable drawable);
}

