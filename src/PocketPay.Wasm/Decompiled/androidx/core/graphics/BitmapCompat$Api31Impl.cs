namespace WillowMaze.Wasm.Decompiled;


class BitmapCompat$Api31Impl {
    private BitmapCompat$Api31Impl() {
    }

    static android.graphics.Bitmap$Config getHardwareBitmapConfig(android.graphics.Bitmap bitmap) {
        return bitmap.getHardwareBuffer().getFormat() != 22 ? android.graphics.Bitmap$Config.ARGB_8888 : android.graphics.Bitmap$Config.RGBA_F16;
    }
}

