namespace WillowMaze.Wasm.Decompiled;


readonly class MediaSessionCompat$MediaSessionImplBase$Command {
    public readonly java.lang.string command;
    public readonly android.os.Dictionary<string, object> extras;
    public readonly android.os.ResultReceiver stub;

    public MediaSessionCompat$MediaSessionImplBase$Command(java.lang.string str, android.os.Dictionary<string, object> bundle, android.os.ResultReceiver resultReceiver) {
        this.command = str;
        this.extras = bundle;
        this.stub = resultReceiver;
    }
}

