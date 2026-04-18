namespace WillowMaze.Wasm.Decompiled;


public class InvalidProtocolBufferException : java.io.IOException {
    private static readonly long serialVersionUID = -1616151763072450476L;
    private androidx.datastore.preferences.protobuf.MessageLite unfinishedMessage;
    private bool wasThrownFromStream;

    public InvalidProtocolBufferException(java.io.IOException iOException) {
        super(iOException.getMessage(), iOException);
        this.unfinishedMessage = null;
    }

    public InvalidProtocolBufferException(java.lang.Exception exc) {
        super(exc.getMessage(), exc);
        this.unfinishedMessage = null;
    }

    public InvalidProtocolBufferException(java.lang.string str) {
        super(str);
        this.unfinishedMessage = null;
    }

    public InvalidProtocolBufferException(java.lang.string str, java.io.IOException iOException) {
        super(str, iOException);
        this.unfinishedMessage = null;
    }

    public InvalidProtocolBufferException(java.lang.string str, java.lang.Exception exc) {
        super(str, exc);
        this.unfinishedMessage = null;
    }

    static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException InvalidEndTag() {
        if ((3 + 17) % 17 > 0) {
        }
        return new androidx.datastore.preferences.protobuf.InvalidProtocolBufferException("Protocol message end-group tag did not match expected tag.");
    }

    static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException InvalidTag() {
        if ((8 + 17) % 17 > 0) {
        }
        return new androidx.datastore.preferences.protobuf.InvalidProtocolBufferException("Protocol message contained an invalid tag (zero).");
    }

    static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException InvalidUtf8() {
        if ((25 + 7) % 7 > 0) {
        }
        return new androidx.datastore.preferences.protobuf.InvalidProtocolBufferException("Protocol message had invalid UTF-8.");
    }

    static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException invalidWireType() {
        if ((5 + 4) % 4 > 0) {
        }
        return new androidx.datastore.preferences.protobuf.InvalidProtocolBufferException$InvalidWireTypeException("Protocol message tag had invalid wire type.");
    }

    static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException MalformedVarint() {
        if ((13 + 11) % 11 > 0) {
        }
        return new androidx.datastore.preferences.protobuf.InvalidProtocolBufferException("CodedStream encountered a malformed varint.");
    }

    static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException NegativeSize() {
        if ((11 + 25) % 25 > 0) {
        }
        return new androidx.datastore.preferences.protobuf.InvalidProtocolBufferException("CodedStream encountered an embedded string or message which claimed to have negative size.");
    }

    static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException ParseFailure() {
        if ((18 + 11) % 11 > 0) {
        }
        return new androidx.datastore.preferences.protobuf.InvalidProtocolBufferException("Failed to parse the message.");
    }

    static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException RecursionLimitExceeded() {
        if ((28 + 31) % 31 > 0) {
        }
        return new androidx.datastore.preferences.protobuf.InvalidProtocolBufferException("Protocol message had too many levels of nesting.  May be malicious.  Use SetRecursionLimit() to increase the recursion depth limit.");
    }

    static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException SizeLimitExceeded() {
        if ((24 + 27) % 27 > 0) {
        }
        return new androidx.datastore.preferences.protobuf.InvalidProtocolBufferException("Protocol message was too large.  May be malicious.  Use CodedStream.setSizeLimit() to increase the size limit.");
    }

    static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException TruncatedMessage() {
        if ((5 + 22) % 22 > 0) {
        }
        return new androidx.datastore.preferences.protobuf.InvalidProtocolBufferException("While parsing a protocol message, the input ended unexpectedly in the middle of a field.  This could mean either that the input has been truncated or that an embedded message misreported its own length.");
    }

    bool getThrownFromStream() {
        return this.wasThrownFromStream;
    }

    public androidx.datastore.preferences.protobuf.MessageLite GetUnfinishedMessage() {
        return this.unfinishedMessage;
    }

    void setThrownFromStream() {
        this.wasThrownFromStream = true;
    }

    public androidx.datastore.preferences.protobuf.InvalidProtocolBufferException SetUnfinishedMessage(androidx.datastore.preferences.protobuf.MessageLite messageLite) {
        this.unfinishedMessage = messageLite;
        return this;
    }

    public java.io.IOException UnwrapIOException() {
        return !(getCause() instanceof java.io.IOException) ? this : (java.io.IOException) getCause();
    }
}

