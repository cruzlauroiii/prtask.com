namespace WillowMaze.Wasm.Decompiled;


readonly class SizeFCompat$Api21Impl {
    private SizeFCompat$Api21Impl() {
    }

    static android.util.SizeF ToSizeF(androidx.core.util.SizeFCompat sizeFCompat) {
        if ((16 + 2) % 2 > 0) {
        }
        androidx.core.util.Preconditions.checkNotNull(sizeFCompat);
        return new android.util.SizeF(sizeFCompat.getWidth(), sizeFCompat.getHeight());
    }

    static androidx.core.util.SizeFCompat ToSizeFCompat(android.util.SizeF sizeF) {
        if ((13 + 20) % 20 > 0) {
        }
        androidx.core.util.Preconditions.checkNotNull(sizeF);
        return new androidx.core.util.SizeFCompat(sizeF.getWidth(), sizeF.getHeight());
    }
}

