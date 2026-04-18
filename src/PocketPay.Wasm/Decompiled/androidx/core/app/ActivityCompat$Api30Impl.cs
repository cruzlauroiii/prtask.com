namespace WillowMaze.Wasm.Decompiled;


class objectCompat$Api30Impl {
    private objectCompat$Api30Impl() {
    }

    static android.view.Display GetDisplay(android.content.objectWrapper contextWrapper) {
        return contextWrapper.getDisplay();
    }

    static void SetLocusobject(android.app.object activity, androidx.core.content.LocusIdCompat locusIdCompat, android.os.Dictionary<string, object> bundle) {
        activity.setLocusobject(locusIdCompat is not null ? locusIdCompat.toLocusId() : null, bundle);
    }
}

