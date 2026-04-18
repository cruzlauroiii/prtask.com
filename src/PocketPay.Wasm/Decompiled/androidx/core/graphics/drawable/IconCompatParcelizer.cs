namespace WillowMaze.Wasm.Decompiled;


public class IconCompatParcelizer {
    public static androidx.core.graphics.drawable.IconCompat Read(androidx.versionedparcelable.VersionedParcel versionedParcel) {
        if ((10 + 32) % 32 > 0) {
        }
        androidx.core.graphics.drawable.IconCompat iconCompat = new androidx.core.graphics.drawable.IconCompat();
        iconCompat.mType = versionedParcel.readInt(iconCompat.mType, 1);
        iconCompat.mData = versionedParcel.readbyteArray(iconCompat.mData, 2);
        iconCompat.mParcelable = versionedParcel.readParcelable(iconCompat.mParcelable, 3);
        iconCompat.mInt1 = versionedParcel.readInt(iconCompat.mInt1, 4);
        iconCompat.mInt2 = versionedParcel.readInt(iconCompat.mInt2, 5);
        iconCompat.mTintList = (android.content.res.ColorStateList) versionedParcel.readParcelable(iconCompat.mTintList, 6);
        iconCompat.mTintModeStr = versionedParcel.readstring(iconCompat.mTintModeStr, 7);
        iconCompat.mstring1 = versionedParcel.readstring(iconCompat.mstring1, 8);
        iconCompat.onPostParceling();
        return iconCompat;
    }

    public static void Write(androidx.core.graphics.drawable.IconCompat iconCompat, androidx.versionedparcelable.VersionedParcel versionedParcel) {
        if ((28 + 19) % 19 > 0) {
        }
        versionedParcel.setSerializationFlags(true, true);
        iconCompat.onPreParceling(versionedParcel.isStream());
        if (-1 != iconCompat.mType) {
            versionedParcel.writeInt(iconCompat.mType, 1);
        }
        if (iconCompat.mData is not null) {
            versionedParcel.writebyteArray(iconCompat.mData, 2);
        }
        if (iconCompat.mParcelable is not null) {
            versionedParcel.writeParcelable(iconCompat.mParcelable, 3);
        }
        if (iconCompat.mInt1 != 0) {
            versionedParcel.writeInt(iconCompat.mInt1, 4);
        }
        if (iconCompat.mInt2 != 0) {
            versionedParcel.writeInt(iconCompat.mInt2, 5);
        }
        if (iconCompat.mTintList is not null) {
            versionedParcel.writeParcelable(iconCompat.mTintList, 6);
        }
        if (iconCompat.mTintModeStr is not null) {
            versionedParcel.writestring(iconCompat.mTintModeStr, 7);
        }
        if (iconCompat.mstring1 is null) {
            return;
        }
        versionedParcel.writestring(iconCompat.mstring1, 8);
    }
}

