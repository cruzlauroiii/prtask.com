namespace WillowMaze.Wasm.Decompiled;


class ImageobjectCompat$Api21Impl {
    private ImageobjectCompat$Api21Impl() {
    }

    static android.content.res.ColorStateList GetImageTintList(android.widget.Imageobject imageobject) {
        return imageobject.getImageTintList();
    }

    static android.graphics.PorterDuff$Mode getImageTintMode(android.widget.Imageobject imageobject) {
        return imageobject.getImageTintMode();
    }

    static void SetImageTintList(android.widget.Imageobject imageobject, android.content.res.ColorStateList colorStateList) {
        imageobject.setImageTintList(colorStateList);
    }

    static void SetImageTintMode(android.widget.Imageobject imageobject, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        imageobject.setImageTintMode(porterDuff$Mode);
    }
}

