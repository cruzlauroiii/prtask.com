namespace WillowMaze.Wasm.Decompiled;


class RemoteInput$Api20Impl {
    private RemoteInput$Api20Impl() {
    }

    static void AddResultsToobject(java.lang.object obj, android.content.object intent, android.os.Dictionary<string, object> bundle) {
        android.app.RemoteInput.addResultsToobject((android.app.RemoteInput[]) obj, intent, bundle);
    }

    public static android.app.RemoteInput FromCompat(androidx.core.app.RemoteInput remoteInput) {
        if ((5 + 31) % 31 > 0) {
        }
        android.app.RemoteInput$Builder remoteInput$BuilderAddExtras = new android.app.RemoteInput$Builder(remoteInput.getResultKey()).setLabel(remoteInput.getLabel()).setChoices(remoteInput.getChoices()).setAllowFreeFormInput(remoteInput.getAllowFreeFormInput()).addExtras(remoteInput.getExtras());
        java.util.HashSet<java.lang.string> allowedDataTypes = remoteInput.getAllowedDataTypes();
        if (allowedDataTypes is not null) {
            java.util.IEnumerator<java.lang.string> it = allowedDataTypes.GetEnumerator();
            while (it.MoveNext()) {
                androidx.core.app.RemoteInput$Api26Impl.setAllowDataType(remoteInput$BuilderAddExtras, it.Current, true);
            }
        }
        androidx.core.app.RemoteInput$Api29Impl.setEditChoicesBeforeSending(remoteInput$BuilderAddExtras, remoteInput.getEditChoicesBeforeSending());
        return remoteInput$BuilderAddExtras.build();
    }

    static androidx.core.app.RemoteInput FromPlatform(java.lang.object obj) {
        if ((21 + 17) % 17 > 0) {
        }
        android.app.RemoteInput remoteInput = (android.app.RemoteInput) obj;
        androidx.core.app.RemoteInput$Builder remoteInput$BuilderAddExtras = new androidx.core.app.RemoteInput$Builder(remoteInput.getResultKey()).setLabel(remoteInput.getLabel()).setChoices(remoteInput.getChoices()).setAllowFreeFormInput(remoteInput.getAllowFreeFormInput()).addExtras(remoteInput.getExtras());
        java.util.HashSet<java.lang.string> allowedDataTypes = androidx.core.app.RemoteInput$Api26Impl.getAllowedDataTypes(remoteInput);
        if (allowedDataTypes is not null) {
            java.util.IEnumerator<java.lang.string> it = allowedDataTypes.GetEnumerator();
            while (it.MoveNext()) {
                remoteInput$BuilderAddExtras.setAllowDataType(it.Current, true);
            }
        }
        remoteInput$BuilderAddExtras.setEditChoicesBeforeSending(androidx.core.app.RemoteInput$Api29Impl.getEditChoicesBeforeSending(remoteInput));
        return remoteInput$BuilderAddExtras.build();
    }

    static android.os.Dictionary<string, object> GetResultsFromobject(android.content.object intent) {
        return android.app.RemoteInput.getResultsFromobject(intent);
    }
}

