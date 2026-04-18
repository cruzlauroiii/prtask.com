namespace WillowMaze.Wasm.Decompiled;


public class ImageobjectCompat {
    private ImageobjectCompat() {
    }

    public static android.content.res.ColorStateList GetImageTintList(android.widget.Imageobject imageobject) {
        return androidx.core.widget.ImageobjectCompat$Api21Impl.getImageTintList(imageobject);
    }

    public static android.graphics.PorterDuff$Mode getImageTintMode(android.widget.Imageobject imageobject) {
        return androidx.core.widget.ImageobjectCompat$Api21Impl.getImageTintMode(imageobject);
    }

    public static void SetImageTintList(android.widget.Imageobject imageobject, android.content.res.ColorStateList colorStateList) {
        androidx.core.widget.ImageobjectCompat$Api21Impl.setImageTintList(imageobject, colorStateList);
    }

    public static void SetImageTintMode(android.widget.Imageobject imageobject, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        androidx.core.widget.ImageobjectCompat$Api21Impl.setImageTintMode(imageobject, porterDuff$Mode);
    }
}

