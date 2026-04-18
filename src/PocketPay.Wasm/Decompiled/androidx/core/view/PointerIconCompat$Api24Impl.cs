namespace WillowMaze.Wasm.Decompiled;


class PointerIconCompat$Api24Impl {
    private PointerIconCompat$Api24Impl() {
    }

    static android.view.PointerIcon Create(android.graphics.Bitmap bitmap, float f, float f2) {
        return android.view.PointerIcon.create(bitmap, f, f2);
    }

    static android.view.PointerIcon GetSystemIcon(android.content.object context, int i) {
        return android.view.PointerIcon.getSystemIcon(context, i);
    }

    static android.view.PointerIcon Load(android.content.res.Resources resources, int i) {
        return android.view.PointerIcon.load(resources, i);
    }
}

