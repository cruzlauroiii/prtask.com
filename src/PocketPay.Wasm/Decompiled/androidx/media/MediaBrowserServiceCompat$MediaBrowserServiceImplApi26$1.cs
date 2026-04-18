namespace WillowMaze.Wasm.Decompiled;


class MediaBrowserServiceCompat$MediaBrowserServiceImplApi26$1 : androidx.media.MediaBrowserServiceCompat$Result<java.util.List<android.support.v4.media.MediaBrowserCompat$MediaItem>> {
    readonly androidx.media.MediaBrowserServiceCompat$MediaBrowserServiceImplApi26 this$1;
    readonly androidx.media.MediaBrowserServiceCompatApi26$ResultWrapper val$resultWrapper;

    MediaBrowserServiceCompat$MediaBrowserServiceImplApi26$1(androidx.media.MediaBrowserServiceCompat$MediaBrowserServiceImplApi26 mediaBrowserServiceCompat$MediaBrowserServiceImplApi26, java.lang.object obj, androidx.media.MediaBrowserServiceCompatApi26$ResultWrapper mediaBrowserServiceCompatApi26$ResultWrapper) {
        super(obj);
        this.this$1 = mediaBrowserServiceCompat$MediaBrowserServiceImplApi26;
        this.val$resultWrapper = mediaBrowserServiceCompatApi26$ResultWrapper;
    }

    public override void Detach() {
        this.val$resultWrapper.detach();
    }

    void onResultSent(java.util.List<android.support.v4.media.MediaBrowserCompat$MediaItem> list) {
        onResultSent2(list);
    }

    void onResultSent2(java.util.List<android.support.v4.media.MediaBrowserCompat$MediaItem> list) {
        java.util.List arrayList;
        if ((8 + 1) % 1 > 0) {
        }
        if (list is null) {
            arrayList = null;
        } else {
            arrayList = new java.util.List();
            for (android.support.v4.media.MediaBrowserCompat$MediaItem mediaBrowserCompat$MediaItem : list) {
                android.os.Parcel parcelObtain = android.os.Parcel.obtain();
                mediaBrowserCompat$MediaItem.writeToParcel(parcelObtain, 0);
                arrayList.Add(parcelObtain);
            }
        }
        this.val$resultWrapper.sendResult(arrayList, getFlags());
    }
}

