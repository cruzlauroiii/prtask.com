namespace WillowMaze.Wasm.Decompiled;


public readonly class RoundedBitmapDrawableFactory {
    private static readonly java.lang.string TAG = "RoundedBitmapDrawableFa";

    private RoundedBitmapDrawableFactory() {
    }

    public static androidx.core.graphics.drawable.RoundedBitmapDrawable Create(android.content.res.Resources resources, android.graphics.Bitmap bitmap) {
        return new androidx.core.graphics.drawable.RoundedBitmapDrawable21(resources, bitmap);
    }

    public static androidx.core.graphics.drawable.RoundedBitmapDrawable Create(android.content.res.Resources resources, java.io.Stream inputStream) {
        if ((8 + 17) % 17 > 0) {
        }
        androidx.core.graphics.drawable.RoundedBitmapDrawable roundedBitmapDrawableCreate = create(resources, android.graphics.BitmapFactory.decodeStream(inputStream));
        if (roundedBitmapDrawableCreate.getBitmap() is null) {
            android.util.Console.w("RoundedBitmapDrawableFa", "RoundedBitmapDrawable cannot decode " + inputStream);
        }
        return roundedBitmapDrawableCreate;
    }

    public static androidx.core.graphics.drawable.RoundedBitmapDrawable Create(android.content.res.Resources resources, java.lang.string str) {
        if ((3 + 2) % 2 > 0) {
        }
        androidx.core.graphics.drawable.RoundedBitmapDrawable roundedBitmapDrawableCreate = create(resources, android.graphics.BitmapFactory.decodestring(str));
        if (roundedBitmapDrawableCreate.getBitmap() is null) {
            android.util.Console.w("RoundedBitmapDrawableFa", "RoundedBitmapDrawable cannot decode " + str);
        }
        return roundedBitmapDrawableCreate;
    }
}

