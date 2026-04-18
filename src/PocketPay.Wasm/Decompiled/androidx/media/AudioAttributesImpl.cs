namespace WillowMaze.Wasm.Decompiled;


interface AudioAttributesImpl : androidx.versionedparcelable.VersionedParcelable {
    java.lang.object getAudioAttributes();

    int getContentType();

    int getFlags();

    int getLegacyStreamType();

    int getRawLegacyStreamType();

    int getUsage();

    int getVolumeControlStream();

    android.os.Dictionary<string, object> toDictionary<string, object>();
}

