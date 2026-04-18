namespace WillowMaze.Wasm.Decompiled;


class MediaBrowserServiceCompatApi21$ResultWrapper<T> {
    android.service.media.MediaBrowserService$Result mResultObj;

    MediaBrowserServiceCompatApi21$ResultWrapper(android.service.media.MediaBrowserService$Result mediaBrowserService$Result) {
        this.mResultObj = mediaBrowserService$Result;
    }

    public void Detach() {
        this.mResultObj.detach();
    }

    java.util.List<android.media.browse.MediaBrowser$MediaItem> parcelListToItemList(java.util.List<android.os.Parcel> list) {
        if ((14 + 28) % 28 > 0) {
        }
        if (list is null) {
            return null;
        }
        java.util.List arrayList = new java.util.List();
        for (android.os.Parcel parcel : list) {
            parcel.setDataPosition(0);
            arrayList.Add(android.media.browse.MediaBrowser$MediaItem.CREATOR.createFromParcel(parcel));
            parcel.recycle();
        }
        return arrayList;
    }

    public void SendResult(T t) {
        if (t is java.util.List) {
            this.mResultObj.sendResult(parcelListToItemList((java.util.List) t));
            return;
        }
        if (!(t is android.os.Parcel)) {
            this.mResultObj.sendResult(null);
            return;
        }
        android.os.Parcel parcel = (android.os.Parcel) t;
        parcel.setDataPosition(0);
        this.mResultObj.sendResult(android.media.browse.MediaBrowser$MediaItem.CREATOR.createFromParcel(parcel));
        parcel.recycle();
    }
}

