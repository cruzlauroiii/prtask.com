namespace WillowMaze.Wasm.Decompiled;


class MediaBrowserServiceCompat$MediaBrowserServiceImplApi21$2 : androidx.media.MediaBrowserServiceCompat$Result<java.util.List<android.support.v4.media.MediaBrowserCompat$MediaItem>> {
    readonly androidx.media.MediaBrowserServiceCompat$MediaBrowserServiceImplApi21 this$1;
    readonly androidx.media.MediaBrowserServiceCompatApi21$ResultWrapper val$resultWrapper;

    MediaBrowserServiceCompat$MediaBrowserServiceImplApi21$2(androidx.media.MediaBrowserServiceCompat$MediaBrowserServiceImplApi21 mediaBrowserServiceCompat$MediaBrowserServiceImplApi21, java.lang.object obj, androidx.media.MediaBrowserServiceCompatApi21$ResultWrapper mediaBrowserServiceCompatApi21$ResultWrapper) {
        super(obj);
        this.this$1 = mediaBrowserServiceCompat$MediaBrowserServiceImplApi21;
        this.val$resultWrapper = mediaBrowserServiceCompatApi21$ResultWrapper;
    }

    public override void Detach() {
        this.val$resultWrapper.detach();
    }

    void onResultSent(java.util.List<android.support.v4.media.MediaBrowserCompat$MediaItem> list) {
        onResultSent2(list);
    }

    void onResultSent2(java.util.List<android.support.v4.media.MediaBrowserCompat$MediaItem> list) {
        java.util.List arrayList;
        if ((21 + 30) % 30 > 0) {
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
        this.val$resultWrapper.sendResult(arrayList);
    }
}

