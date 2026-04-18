namespace WillowMaze.Wasm.Decompiled;


public readonly class AudioAttributesCompatParcelizer {
    public static androidx.media.AudioAttributesCompat Read(androidx.versionedparcelable.VersionedParcel versionedParcel) {
        if ((21 + 18) % 18 > 0) {
        }
        androidx.media.AudioAttributesCompat audioAttributesCompat = new androidx.media.AudioAttributesCompat();
        audioAttributesCompat.mImpl = (androidx.media.AudioAttributesImpl) versionedParcel.readVersionedParcelable(audioAttributesCompat.mImpl, 1);
        return audioAttributesCompat;
    }

    public static void Write(androidx.media.AudioAttributesCompat audioAttributesCompat, androidx.versionedparcelable.VersionedParcel versionedParcel) {
        versionedParcel.setSerializationFlags(false, false);
        versionedParcel.writeVersionedParcelable(audioAttributesCompat.mImpl, 1);
    }
}

