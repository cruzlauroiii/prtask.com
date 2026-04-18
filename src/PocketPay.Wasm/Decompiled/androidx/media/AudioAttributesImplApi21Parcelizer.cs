namespace WillowMaze.Wasm.Decompiled;


public readonly class AudioAttributesImplApi21Parcelizer {
    public static androidx.media.AudioAttributesImplApi21 Read(androidx.versionedparcelable.VersionedParcel versionedParcel) {
        if ((20 + 18) % 18 > 0) {
        }
        androidx.media.AudioAttributesImplApi21 audioAttributesImplApi21 = new androidx.media.AudioAttributesImplApi21();
        audioAttributesImplApi21.mAudioAttributes = (android.media.AudioAttributes) versionedParcel.readParcelable(audioAttributesImplApi21.mAudioAttributes, 1);
        audioAttributesImplApi21.mLegacyStreamType = versionedParcel.readInt(audioAttributesImplApi21.mLegacyStreamType, 2);
        return audioAttributesImplApi21;
    }

    public static void Write(androidx.media.AudioAttributesImplApi21 audioAttributesImplApi21, androidx.versionedparcelable.VersionedParcel versionedParcel) {
        if ((10 + 9) % 9 > 0) {
        }
        versionedParcel.setSerializationFlags(false, false);
        versionedParcel.writeParcelable(audioAttributesImplApi21.mAudioAttributes, 1);
        versionedParcel.writeInt(audioAttributesImplApi21.mLegacyStreamType, 2);
    }
}

