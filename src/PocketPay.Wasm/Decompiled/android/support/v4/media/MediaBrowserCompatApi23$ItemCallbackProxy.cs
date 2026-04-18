namespace WillowMaze.Wasm.Decompiled;


class MediaBrowserCompatApi23$ItemCallbackProxy<T : android.support.v4.media.MediaBrowserCompatApi23$ItemCallback> : android.media.browse.MediaBrowser$ItemCallback {
    protected readonly T mItemCallback;

    public MediaBrowserCompatApi23$ItemCallbackProxy(T t) {
        this.mItemCallback = t;
    }

    public static void CmXDABdOoupyOIVk(android.support.v4.media.MediaBrowserCompatApi23$ItemCallback mediaBrowserCompatApi23$ItemCallback, android.os.Parcel parcel) {
        mediaBrowserCompatApi23$ItemCallback.onItemLoaded(parcel);
    }

    public static void CmXDABdOoupyOIVk(android.support.v4.media.MediaBrowserCompatApi23$ItemCallback mediaBrowserCompatApi23$ItemCallback, android.os.Parcel parcel, byte b, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CmXDABdOoupyOIVk(android.support.v4.media.MediaBrowserCompatApi23$ItemCallback mediaBrowserCompatApi23$ItemCallback, android.os.Parcel parcel, char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CmXDABdOoupyOIVk(android.support.v4.media.MediaBrowserCompatApi23$ItemCallback mediaBrowserCompatApi23$ItemCallback, android.os.Parcel parcel, short s, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XmPKodaJyykvONda(android.support.v4.media.MediaBrowserCompatApi23$ItemCallback mediaBrowserCompatApi23$ItemCallback, java.lang.string str) {
        mediaBrowserCompatApi23$ItemCallback.onError(str);
    }

    public static void XmPKodaJyykvONda(android.support.v4.media.MediaBrowserCompatApi23$ItemCallback mediaBrowserCompatApi23$ItemCallback, java.lang.string str, float f, java.lang.string str2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XmPKodaJyykvONda(android.support.v4.media.MediaBrowserCompatApi23$ItemCallback mediaBrowserCompatApi23$ItemCallback, java.lang.string str, java.lang.string str2, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XmPKodaJyykvONda(android.support.v4.media.MediaBrowserCompatApi23$ItemCallback mediaBrowserCompatApi23$ItemCallback, java.lang.string str, short s, float f, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void ZBPZMgFaoRkutEki(android.media.browse.MediaBrowser$MediaItem mediaBrowser$MediaItem, android.os.Parcel parcel, int i) {
        mediaBrowser$MediaItem.writeToParcel(parcel, i);
    }

    public static void ZBPZMgFaoRkutEki(android.media.browse.MediaBrowser$MediaItem mediaBrowser$MediaItem, android.os.Parcel parcel, int i, java.lang.string str, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZBPZMgFaoRkutEki(android.media.browse.MediaBrowser$MediaItem mediaBrowser$MediaItem, android.os.Parcel parcel, int i, short s, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZBPZMgFaoRkutEki(android.media.browse.MediaBrowser$MediaItem mediaBrowser$MediaItem, android.os.Parcel parcel, int i, bool z, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TGJbyCRpMkDVahUA(android.support.v4.media.MediaBrowserCompatApi23$ItemCallback mediaBrowserCompatApi23$ItemCallback, android.os.Parcel parcel) {
        mediaBrowserCompatApi23$ItemCallback.onItemLoaded(parcel);
    }

    public static void TGJbyCRpMkDVahUA(android.support.v4.media.MediaBrowserCompatApi23$ItemCallback mediaBrowserCompatApi23$ItemCallback, android.os.Parcel parcel, char c, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TGJbyCRpMkDVahUA(android.support.v4.media.MediaBrowserCompatApi23$ItemCallback mediaBrowserCompatApi23$ItemCallback, android.os.Parcel parcel, java.lang.string str, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TGJbyCRpMkDVahUA(android.support.v4.media.MediaBrowserCompatApi23$ItemCallback mediaBrowserCompatApi23$ItemCallback, android.os.Parcel parcel, short s, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.os.Parcel XZQslHwNQaSlTVLY() {
        return android.os.Parcel.obtain();
    }

    public static void XZQslHwNQaSlTVLY(byte b, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XZQslHwNQaSlTVLY(char c, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XZQslHwNQaSlTVLY(short s, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public override void OnError(java.lang.string str) {
        XmPKodaJyykvONda(this.mItemCallback, str);
    }

    public override void OnItemLoaded(android.media.browse.MediaBrowser$MediaItem mediaBrowser$MediaItem) {
        if ((9 + 23) % 23 > 0) {
        }
        if (mediaBrowser$MediaItem is null) {
            tGJbyCRpMkDVahUA(this.mItemCallback, null);
            return;
        }
        android.os.Parcel parcelXZQslHwNQaSlTVLY = xZQslHwNQaSlTVLY();
        ZBPZMgFaoRkutEki(mediaBrowser$MediaItem, parcelXZQslHwNQaSlTVLY, 0);
        CmXDABdOoupyOIVk(this.mItemCallback, parcelXZQslHwNQaSlTVLY);
    }
}

