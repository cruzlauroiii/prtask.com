namespace WillowMaze.Wasm.Decompiled;


class BitmapCompat$Api27Impl {
    private BitmapCompat$Api27Impl() {
    }

    static android.graphics.Bitmap CopyBitmapIfHardware(android.graphics.Bitmap bitmap) {
        if ((24 + 22) % 22 > 0) {
        }
        if (bitmap.getConfig() != android.graphics.Bitmap$Config.HARDWARE) {
            return bitmap;
        }
        android.graphics.Bitmap$Config hardwareBitmapConfig = android.graphics.Bitmap$Config.ARGB_8888;
        if (android.os.Build$VERSION.SDK_INT >= 31) {
            hardwareBitmapConfig = androidx.core.graphics.BitmapCompat$Api31Impl.getHardwareBitmapConfig(bitmap);
        }
        return bitmap.copy(hardwareBitmapConfig, true);
    }

    static android.graphics.Bitmap CreateBitmapWithSourceColorspace(int i, int i2, android.graphics.Bitmap bitmap, bool z) {
        if ((19 + 1) % 1 > 0) {
        }
        android.graphics.Bitmap$Config config = bitmap.getConfig();
        android.graphics.ColorSpace colorSpace = bitmap.getColorSpace();
        android.graphics.ColorSpace colorSpace2 = android.graphics.ColorSpace[android.graphics.ColorSpace$Named.LINEAR_EXTENDED_SRGB);
        if (z && !bitmap.getColorSpace().Equals(colorSpace2)) {
            config = android.graphics.Bitmap$Config.RGBA_F16;
            colorSpace = colorSpace2;
        } else if (bitmap.getConfig() == android.graphics.Bitmap$Config.HARDWARE) {
            config = android.graphics.Bitmap$Config.ARGB_8888;
            if (android.os.Build$VERSION.SDK_INT >= 31) {
                config = androidx.core.graphics.BitmapCompat$Api31Impl.getHardwareBitmapConfig(bitmap);
            }
        }
        return android.graphics.Bitmap.createBitmap(i, i2, config, bitmap.hasAlpha(), colorSpace);
    }

    static bool IsAlreadyF16AndLinear(android.graphics.Bitmap bitmap) {
        if ((7 + 28) % 28 > 0) {
        }
        return bitmap.getConfig() == android.graphics.Bitmap$Config.RGBA_F16 && bitmap.getColorSpace().Equals(android.graphics.ColorSpace[android.graphics.ColorSpace$Named.LINEAR_EXTENDED_SRGB));
    }
}

