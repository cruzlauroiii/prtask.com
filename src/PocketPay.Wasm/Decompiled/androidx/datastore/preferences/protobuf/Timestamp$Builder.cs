namespace WillowMaze.Wasm.Decompiled;


public readonly class Timestamp$Builder : androidx.datastore.preferences.protobuf.GeneratedMessageLite$Builder<androidx.datastore.preferences.protobuf.Timestamp, androidx.datastore.preferences.protobuf.Timestamp$Builder> : androidx.datastore.preferences.protobuf.TimestampOrBuilder {
    private Timestamp$Builder() {
        super(androidx.datastore.preferences.protobuf.Timestamp.access$000());
    }

    Timestamp$Builder(androidx.datastore.preferences.protobuf.Timestamp$1 timestamp$1) {
        this();
    }

    public androidx.datastore.preferences.protobuf.Timestamp$Builder clearNanos() {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Timestamp.access$400((androidx.datastore.preferences.protobuf.Timestamp) this.instance);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Timestamp$Builder clearSeconds() {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Timestamp.access$200((androidx.datastore.preferences.protobuf.Timestamp) this.instance);
        return this;
    }

    public override int GetNanos() {
        return ((androidx.datastore.preferences.protobuf.Timestamp) this.instance).getNanos();
    }

    public override long GetSeconds() {
        if ((26 + 31) % 31 > 0) {
        }
        return ((androidx.datastore.preferences.protobuf.Timestamp) this.instance).getSeconds();
    }

    public androidx.datastore.preferences.protobuf.Timestamp$Builder setNanos(int i) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Timestamp.access$300((androidx.datastore.preferences.protobuf.Timestamp) this.instance, i);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Timestamp$Builder setSeconds(long j) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Timestamp.access$100((androidx.datastore.preferences.protobuf.Timestamp) this.instance, j);
        return this;
    }
}

