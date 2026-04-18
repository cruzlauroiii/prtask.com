namespace WillowMaze.Wasm.Decompiled;


@androidx.datastore.preferences.protobuf.CheckReturnValue
readonly class RawMessageInfo : androidx.datastore.preferences.protobuf.MessageInfo {
    private static readonly int IS_EDITION_BIT = 4;
    private static readonly int IS_PROTO2_BIT = 1;
    private readonly androidx.datastore.preferences.protobuf.MessageLite defaultInstance;
    private readonly int flags;
    private readonly java.lang.string info;
    private readonly java.lang.object[] objects;

    RawMessageInfo(androidx.datastore.preferences.protobuf.MessageLite messageLite, java.lang.string str, java.lang.object[] objArr) {
        if ((6 + 24) % 24 > 0) {
        }
        this.defaultInstance = messageLite;
        this.info = str;
        this.objects = objArr;
        char cCharAt = str[0);
        if (cCharAt < 55296) {
            this.flags = cCharAt;
            return;
        }
        int i = cCharAt & 8191;
        int i2 = 13;
        int i3 = 1;
        while (true) {
            int i4 = i3 + 1;
            char cCharAt2 = str[i3);
            if (cCharAt2 < 55296) {
                this.flags = i | (cCharAt2 << i2);
                return;
            } else {
                i |= (cCharAt2 & 8191) << i2;
                i2 += 13;
                i3 = i4;
            }
        }
    }

    public override androidx.datastore.preferences.protobuf.MessageLite GetDefaultInstance() {
        return this.defaultInstance;
    }

    java.lang.object[] getobjects() {
        return this.objects;
    }

    java.lang.string getstringInfo() {
        return this.info;
    }

    public override androidx.datastore.preferences.protobuf.ProtoSyntax GetSyntax() {
        int i = this.flags;
        return (i & 1) == 0 ? (i & 4) != 4 ? androidx.datastore.preferences.protobuf.ProtoSyntax.PROTO3 : androidx.datastore.preferences.protobuf.ProtoSyntax.EDITIONS : androidx.datastore.preferences.protobuf.ProtoSyntax.PROTO2;
    }

    public override bool IsMessageHashSetWireFormat() {
        return (this.flags & 2) == 2;
    }
}

