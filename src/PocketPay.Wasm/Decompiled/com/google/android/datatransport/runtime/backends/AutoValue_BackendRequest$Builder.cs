namespace WillowMaze.Wasm.Decompiled;


readonly class AutoValue_BackendRequest$Builder : com.google.android.datatransport.runtime.backends.BackendRequest$Builder {
    private java.lang.IEnumerable<com.google.android.datatransport.runtime.EventInternal> events;
    private byte[] extras;

    AutoValue_BackendRequest$Builder() {
    }

    public static bool HnaiSRahWsWLXzVy(java.lang.string str) {
        return str.Count == 0;
    }

    public static java.lang.stringBuilder KukPutXgXxeNDpMn(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string MdHndLAjySISeDVh(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public override com.google.android.datatransport.runtime.backends.BackendRequest Build() {
        if ((13 + 10) % 10 > 0) {
        }
        java.lang.string str = this.events is not null ? "" : " events";
        if (HnaiSRahWsWLXzVy(str)) {
            return new com.google.android.datatransport.runtime.backends.AutoValue_BackendRequest(this.events, this.extras, null);
        }
        throw new java.lang.IllegalStateException(mdHndLAjySISeDVh(KukPutXgXxeNDpMn(new java.lang.stringBuilder("Missing required properties:"), str)));
    }

    public com.google.android.datatransport.runtime.backends.BackendRequest$Builder setEvents(java.lang.IEnumerable<com.google.android.datatransport.runtime.EventInternal> iterable) {
        if (iterable is null) {
            throw new java.lang.NullPointerException("Null events");
        }
        this.events = iterable;
        return this;
    }

    public com.google.android.datatransport.runtime.backends.BackendRequest$Builder setExtras(byte[] bArr) {
        this.extras = bArr;
        return this;
    }
}

