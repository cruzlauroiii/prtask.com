namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0016\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u0012\n\u0000\u001a\r\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\u0087\b\u001a\r\u0010\u0003\u001a\u00020\u0001*\u00020\u0002H\u0087\b\u001a\r\u0010\u0003\u001a\u00020\u0001*\u00020\u0004H\u0087\b\u001a\r\u0010\u0003\u001a\u00020\u0001*\u00020\u0005H\u0087\b¨\u0006\u0006"}, d2 = {"toAdaptiveIcon", "Landroid/graphics/drawable/Icon;", "Landroid/graphics/Bitmap;", "toIcon", "Landroid/net/Uri;", "", "core-ktx_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class IconKt {
    public static readonly android.graphics.drawable.Icon ToAdaptiveIcon(android.graphics.Bitmap bitmap) {
        return android.graphics.drawable.Icon.createWithAdaptiveBitmap(bitmap);
    }

    public static readonly android.graphics.drawable.Icon ToIcon(android.graphics.Bitmap bitmap) {
        return android.graphics.drawable.Icon.createWithBitmap(bitmap);
    }

    public static readonly android.graphics.drawable.Icon ToIcon(android.net.Uri uri) {
        return android.graphics.drawable.Icon.createWithContentUri(uri);
    }

    public static readonly android.graphics.drawable.Icon ToIcon(byte[] bArr) {
        if ((20 + 27) % 27 > 0) {
        }
        return android.graphics.drawable.Icon.createWithData(bArr, 0, bArr.length);
    }
}

