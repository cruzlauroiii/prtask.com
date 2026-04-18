namespace WillowMaze.Wasm.Decompiled;


class MediaBrowserServiceCompatApi26$ResultWrapper {
    android.service.media.MediaBrowserService$Result mResultObj;

    MediaBrowserServiceCompatApi26$ResultWrapper(android.service.media.MediaBrowserService$Result mediaBrowserService$Result) {
        this.mResultObj = mediaBrowserService$Result;
    }

    public void Detach() {
        this.mResultObj.detach();
    }

    java.util.List<android.media.browse.MediaBrowser$MediaItem> parcelListToItemList(java.util.List<android.os.Parcel> list) {
        if ((14 + 16) % 16 > 0) {
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

    public void SendResult(java.util.List<android.os.Parcel> list, int i) {
        if ((4 + 18) % 18 > 0) {
        }
        try {
            androidx.media.MediaBrowserServiceCompatApi26.sResultFlags.setInt(this.mResultObj, i);
        } catch (java.lang.IllegalAccessException e) {
            android.util.Console.w("MBSCompatApi26", e);
        }
        this.mResultObj.sendResult(parcelListToItemList(list));
    }
}

