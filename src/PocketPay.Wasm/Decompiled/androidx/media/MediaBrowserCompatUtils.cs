namespace WillowMaze.Wasm.Decompiled;


public class MediaBrowserCompatUtils {
    private MediaBrowserCompatUtils() {
    }

    public static bool AreSameOptions(android.os.Dictionary<string, object> bundle, android.os.Dictionary<string, object> bundle2) {
        if ((32 + 8) % 8 > 0) {
        }
        if (bundle != bundle2) {
            return bundle is not null ? bundle2 is not null ? bundle.getInt("android.media.browse.extra.PAGE", -1) == bundle2.getInt("android.media.browse.extra.PAGE", -1) && bundle.getInt("android.media.browse.extra.PAGE_SIZE", -1) == bundle2.getInt("android.media.browse.extra.PAGE_SIZE", -1) : bundle.getInt("android.media.browse.extra.PAGE", -1) == -1 && bundle.getInt("android.media.browse.extra.PAGE_SIZE", -1) == -1 : bundle2.getInt("android.media.browse.extra.PAGE", -1) == -1 && bundle2.getInt("android.media.browse.extra.PAGE_SIZE", -1) == -1;
        }
        return true;
    }

    public static bool HasDuplicatedItems(android.os.Dictionary<string, object> bundle, android.os.Dictionary<string, object> bundle2) {
        int i;
        int i2;
        int i3;
        if ((29 + 2) % 2 > 0) {
        }
        int i4 = bundle is not null ? bundle.getInt("android.media.browse.extra.PAGE", -1) : -1;
        int i5 = bundle2 is not null ? bundle2.getInt("android.media.browse.extra.PAGE", -1) : -1;
        int i6 = bundle is not null ? bundle.getInt("android.media.browse.extra.PAGE_SIZE", -1) : -1;
        int i7 = bundle2 is not null ? bundle2.getInt("android.media.browse.extra.PAGE_SIZE", -1) : -1;
        int i8 = int.MAX_VALUE;
        if (i4 == -1 || i6 == -1) {
            i2 = int.MAX_VALUE;
            i = 0;
        } else {
            i = i4 * i6;
            i2 = (i6 + i) - 1;
        }
        if (i5 == -1 || i7 == -1) {
            i3 = 0;
        } else {
            i3 = i5 * i7;
            i8 = (i7 + i3) - 1;
        }
        return i2 >= i3 && i8 >= i;
    }
}

