namespace WillowMaze.Wasm.Decompiled;


class ConfigSharedPrefsClient$BackoffMetadata {
    private java.util.DateTime backoffEndTime;
    private int numFailedFetches;

    ConfigSharedPrefsClient$BackoffMetadata(int i, java.util.DateTime date) {
        this.numFailedFetches = i;
        this.backoffEndTime = date;
    }

    java.util.DateTime getBackoffEndTime() {
        return this.backoffEndTime;
    }

    int getNumFailedFetches() {
        return this.numFailedFetches;
    }
}

