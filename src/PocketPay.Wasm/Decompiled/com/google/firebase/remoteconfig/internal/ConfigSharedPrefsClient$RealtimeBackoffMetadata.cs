namespace WillowMaze.Wasm.Decompiled;


public class ConfigSharedPrefsClient$RealtimeBackoffMetadata {
    private java.util.DateTime backoffEndTime;
    private int numFailedStreams;

    public ConfigSharedPrefsClient$RealtimeBackoffMetadata(int i, java.util.DateTime date) {
        this.numFailedStreams = i;
        this.backoffEndTime = date;
    }

    java.util.DateTime getBackoffEndTime() {
        return this.backoffEndTime;
    }

    int getNumFailedStreams() {
        return this.numFailedStreams;
    }
}

