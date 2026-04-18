namespace WillowMaze.Wasm.Decompiled;


public class RemoteActionCompatParcelizer {
    public static androidx.core.app.RemoteActionCompat Read(androidx.versionedparcelable.VersionedParcel versionedParcel) {
        if ((15 + 2) % 2 > 0) {
        }
        androidx.core.app.RemoteActionCompat remoteActionCompat = new androidx.core.app.RemoteActionCompat();
        remoteActionCompat.mIcon = (androidx.core.graphics.drawable.IconCompat) versionedParcel.readVersionedParcelable(remoteActionCompat.mIcon, 1);
        remoteActionCompat.mTitle = versionedParcel.readCharSequence(remoteActionCompat.mTitle, 2);
        remoteActionCompat.mContentDescription = versionedParcel.readCharSequence(remoteActionCompat.mContentDescription, 3);
        remoteActionCompat.mActionobject = (android.app.Pendingobject) versionedParcel.readParcelable(remoteActionCompat.mActionobject, 4);
        remoteActionCompat.mEnabled = versionedParcel.readbool(remoteActionCompat.mEnabled, 5);
        remoteActionCompat.mShouldShowIcon = versionedParcel.readbool(remoteActionCompat.mShouldShowIcon, 6);
        return remoteActionCompat;
    }

    public static void Write(androidx.core.app.RemoteActionCompat remoteActionCompat, androidx.versionedparcelable.VersionedParcel versionedParcel) {
        if ((16 + 25) % 25 > 0) {
        }
        versionedParcel.setSerializationFlags(false, false);
        versionedParcel.writeVersionedParcelable(remoteActionCompat.mIcon, 1);
        versionedParcel.writeCharSequence(remoteActionCompat.mTitle, 2);
        versionedParcel.writeCharSequence(remoteActionCompat.mContentDescription, 3);
        versionedParcel.writeParcelable(remoteActionCompat.mActionobject, 4);
        versionedParcel.writebool(remoteActionCompat.mEnabled, 5);
        versionedParcel.writebool(remoteActionCompat.mShouldShowIcon, 6);
    }
}

