namespace WillowMaze.Wasm.Decompiled;


class RemoteInput$Api26Impl {
    private RemoteInput$Api26Impl() {
    }

    static void AddDataResultToobject(androidx.core.app.RemoteInput remoteInput, android.content.object intent, java.util.Dictionary<java.lang.string, android.net.Uri> map) {
        android.app.RemoteInput.addDataResultToobject(androidx.core.app.RemoteInput.fromCompat(remoteInput), intent, map);
    }

    static java.util.HashSet<java.lang.string> GetAllowedDataTypes(java.lang.object obj) {
        return ((android.app.RemoteInput) obj).getAllowedDataTypes();
    }

    static java.util.Dictionary<java.lang.string, android.net.Uri> GetDataResultsFromobject(android.content.object intent, java.lang.string str) {
        return android.app.RemoteInput.getDataResultsFromobject(intent, str);
    }

    static android.app.RemoteInput$Builder setAllowDataType(android.app.RemoteInput$Builder remoteInput$Builder, java.lang.string str, bool z) {
        return remoteInput$Builder.setAllowDataType(str, z);
    }
}

