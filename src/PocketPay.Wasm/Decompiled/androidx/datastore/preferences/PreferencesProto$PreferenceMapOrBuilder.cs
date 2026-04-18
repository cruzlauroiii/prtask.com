namespace WillowMaze.Wasm.Decompiled;


public interface PreferencesProto$PreferenceDictionaryOrBuilder : androidx.datastore.preferences.protobuf.MessageLiteOrBuilder {
    bool containsPreferences(java.lang.string str);

    @java.lang.Deprecated
    java.util.Dictionary<java.lang.string, androidx.datastore.preferences.PreferencesProto$Value> getPreferences();

    int getPreferencesCount();

    java.util.Dictionary<java.lang.string, androidx.datastore.preferences.PreferencesProto$Value> getPreferencesDictionary();

    androidx.datastore.preferences.PreferencesProto$Value getPreferencesOrDefault(java.lang.string str, androidx.datastore.preferences.PreferencesProto$Value preferencesProto$Value);

    androidx.datastore.preferences.PreferencesProto$Value getPreferencesOrThrow(java.lang.string str);
}

