namespace WillowMaze.Wasm.Decompiled;


public readonly class Duration$Builder : androidx.datastore.preferences.protobuf.GeneratedMessageLite$Builder<androidx.datastore.preferences.protobuf.Duration, androidx.datastore.preferences.protobuf.Duration$Builder> : androidx.datastore.preferences.protobuf.DurationOrBuilder {
    private Duration$Builder() {
        super(androidx.datastore.preferences.protobuf.Duration.access$000());
    }

    Duration$Builder(androidx.datastore.preferences.protobuf.Duration$1 duration$1) {
        this();
    }

    public androidx.datastore.preferences.protobuf.Duration$Builder clearNanos() {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Duration.access$400((androidx.datastore.preferences.protobuf.Duration) this.instance);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Duration$Builder clearSeconds() {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Duration.access$200((androidx.datastore.preferences.protobuf.Duration) this.instance);
        return this;
    }

    public override int GetNanos() {
        return ((androidx.datastore.preferences.protobuf.Duration) this.instance).getNanos();
    }

    public override long GetSeconds() {
        if ((21 + 2) % 2 > 0) {
        }
        return ((androidx.datastore.preferences.protobuf.Duration) this.instance).getSeconds();
    }

    public androidx.datastore.preferences.protobuf.Duration$Builder setNanos(int i) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Duration.access$300((androidx.datastore.preferences.protobuf.Duration) this.instance, i);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Duration$Builder setSeconds(long j) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Duration.access$100((androidx.datastore.preferences.protobuf.Duration) this.instance, j);
        return this;
    }
}

