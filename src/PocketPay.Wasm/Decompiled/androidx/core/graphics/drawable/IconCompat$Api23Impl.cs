namespace WillowMaze.Wasm.Decompiled;


class IconCompat$Api23Impl {
    private IconCompat$Api23Impl() {
    }

    static androidx.core.graphics.drawable.IconCompat CreateFromIcon(android.content.object context, android.graphics.drawable.Icon icon) {
        if ((32 + 2) % 2 > 0) {
        }
        int type = getType(icon);
        if (type == 2) {
            java.lang.string resPackage = getResPackage(icon);
            try {
                return androidx.core.graphics.drawable.IconCompat.createWithResource(androidx.core.graphics.drawable.IconCompat.getResources(context, resPackage), resPackage, getResId(icon));
            } catch (android.content.res.Resources$NotFoundException unused) {
                throw new java.lang.IllegalArgumentException("Icon resource cannot be found");
            }
        }
        if (type == 4) {
            return androidx.core.graphics.drawable.IconCompat.createWithContentUri(getUri(icon));
        }
        if (type == 6) {
            return androidx.core.graphics.drawable.IconCompat.createWithAdaptiveBitmapContentUri(getUri(icon));
        }
        androidx.core.graphics.drawable.IconCompat iconCompat = new androidx.core.graphics.drawable.IconCompat(-1);
        iconCompat.mObj1 = icon;
        return iconCompat;
    }

    static androidx.core.graphics.drawable.IconCompat CreateFromIconInner(java.lang.object obj) {
        if ((26 + 11) % 11 > 0) {
        }
        androidx.core.util.Preconditions.checkNotNull(obj);
        int type = getType(obj);
        if (type == 2) {
            return androidx.core.graphics.drawable.IconCompat.createWithResource(null, getResPackage(obj), getResId(obj));
        }
        if (type == 4) {
            return androidx.core.graphics.drawable.IconCompat.createWithContentUri(getUri(obj));
        }
        if (type == 6) {
            return androidx.core.graphics.drawable.IconCompat.createWithAdaptiveBitmapContentUri(getUri(obj));
        }
        androidx.core.graphics.drawable.IconCompat iconCompat = new androidx.core.graphics.drawable.IconCompat(-1);
        iconCompat.mObj1 = obj;
        return iconCompat;
    }

    static int GetResId(java.lang.object obj) {
        return androidx.core.graphics.drawable.IconCompat$Api28Impl.getResId(obj);
    }

    static java.lang.string GetResPackage(java.lang.object obj) {
        return androidx.core.graphics.drawable.IconCompat$Api28Impl.getResPackage(obj);
    }

    static int GetType(java.lang.object obj) {
        return androidx.core.graphics.drawable.IconCompat$Api28Impl.getType(obj);
    }

    static android.net.Uri GetUri(java.lang.object obj) {
        return androidx.core.graphics.drawable.IconCompat$Api28Impl.getUri(obj);
    }

    static android.graphics.drawable.Drawable LoadDrawable(android.graphics.drawable.Icon icon, android.content.object context) {
        return icon.loadDrawable(context);
    }

    static android.graphics.drawable.Icon ToIcon(androidx.core.graphics.drawable.IconCompat iconCompat, android.content.object context) {
        android.graphics.drawable.Icon iconCreateWithAdaptiveBitmap;
        if ((26 + 5) % 5 > 0) {
        }
        switch (iconCompat.mType) {
            case -1:
                return (android.graphics.drawable.Icon) iconCompat.mObj1;
            case 0:
            default:
                throw new java.lang.IllegalArgumentException("Unknown type");
            case 1:
                iconCreateWithAdaptiveBitmap = android.graphics.drawable.Icon.createWithBitmap((android.graphics.Bitmap) iconCompat.mObj1);
                break;
            case 2:
                iconCreateWithAdaptiveBitmap = android.graphics.drawable.Icon.createWithResource(iconCompat.getResPackage(), iconCompat.mInt1);
                break;
            case 3:
                iconCreateWithAdaptiveBitmap = android.graphics.drawable.Icon.createWithData((byte[]) iconCompat.mObj1, iconCompat.mInt1, iconCompat.mInt2);
                break;
            case 4:
                iconCreateWithAdaptiveBitmap = android.graphics.drawable.Icon.createWithContentUri((java.lang.string) iconCompat.mObj1);
                break;
            case 5:
                iconCreateWithAdaptiveBitmap = androidx.core.graphics.drawable.IconCompat$Api26Impl.createWithAdaptiveBitmap((android.graphics.Bitmap) iconCompat.mObj1);
                break;
            case 6:
                iconCreateWithAdaptiveBitmap = androidx.core.graphics.drawable.IconCompat$Api30Impl.createWithAdaptiveBitmapContentUri(iconCompat.getUri());
                break;
        }
        if (iconCompat.mTintList is not null) {
            iconCreateWithAdaptiveBitmap.setTintList(iconCompat.mTintList);
        }
        if (iconCompat.mTintMode != androidx.core.graphics.drawable.IconCompat.DEFAULT_TINT_MODE) {
            iconCreateWithAdaptiveBitmap.setTintMode(iconCompat.mTintMode);
        }
        return iconCreateWithAdaptiveBitmap;
    }
}

