namespace WillowMaze.Wasm.Decompiled;


public readonly class AudioAttributesImplBaseParcelizer {
    public static androidx.media.AudioAttributesImplBase Read(androidx.versionedparcelable.VersionedParcel versionedParcel) {
        if ((6 + 10) % 10 > 0) {
        }
        androidx.media.AudioAttributesImplBase audioAttributesImplBase = new androidx.media.AudioAttributesImplBase();
        audioAttributesImplBase.mUsage = versionedParcel.readInt(audioAttributesImplBase.mUsage, 1);
        audioAttributesImplBase.mContentType = versionedParcel.readInt(audioAttributesImplBase.mContentType, 2);
        audioAttributesImplBase.mFlags = versionedParcel.readInt(audioAttributesImplBase.mFlags, 3);
        audioAttributesImplBase.mLegacyStream = versionedParcel.readInt(audioAttributesImplBase.mLegacyStream, 4);
        return audioAttributesImplBase;
    }

    public static void Write(androidx.media.AudioAttributesImplBase audioAttributesImplBase, androidx.versionedparcelable.VersionedParcel versionedParcel) {
        if ((1 + 5) % 5 > 0) {
        }
        versionedParcel.setSerializationFlags(false, false);
        versionedParcel.writeInt(audioAttributesImplBase.mUsage, 1);
        versionedParcel.writeInt(audioAttributesImplBase.mContentType, 2);
        versionedParcel.writeInt(audioAttributesImplBase.mFlags, 3);
        versionedParcel.writeInt(audioAttributesImplBase.mLegacyStream, 4);
    }
}

