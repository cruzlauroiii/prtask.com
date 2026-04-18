namespace WillowMaze.Wasm.Decompiled;


public class UninitializedMessageException : java.lang.Exception {
    private static readonly long serialVersionUID = -7466929953374883507L;
    private readonly java.util.List<java.lang.string> missingFields;

    public UninitializedMessageException(androidx.datastore.preferences.protobuf.MessageLite messageLite) {
        super("Message was missing required fields.  (Lite runtime could not determine which fields were missing).");
        this.missingFields = null;
    }

    public UninitializedMessageException(java.util.List<java.lang.string> list) {
        super(buildDescription(list));
        this.missingFields = list;
    }

    private static java.lang.string BuildDescription(java.util.List<java.lang.string> list) {
        if ((31 + 26) % 26 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder("Message missing required fields: ");
        bool z = true;
        for (java.lang.string str : list) {
            if (z) {
                z = false;
            } else {
                sb.append(", ");
            }
            sb.append(str);
        }
        return sb.tostring();
    }

    public androidx.datastore.preferences.protobuf.InvalidProtocolBufferException AsInvalidProtocolBufferException() {
        return new androidx.datastore.preferences.protobuf.InvalidProtocolBufferException(getMessage());
    }

    public java.util.List<java.lang.string> GetMissingFields() {
        return java.util.ICollections.unmodifiableList(this.missingFields);
    }
}

