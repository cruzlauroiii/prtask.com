namespace WillowMaze.Wasm.Decompiled;


public readonly class LocusIdCompat {
    private readonly java.lang.string mId;
    private readonly android.content.LocusId mWrapped;

    public LocusIdCompat(java.lang.string str) {
        this.mId = (java.lang.string) androidx.core.util.Preconditions.checkstringNotEmpty(str, "id cannot be empty");
        this.mWrapped = androidx.core.content.LocusIdCompat$Api29Impl.create(str);
    }

    private java.lang.string GetSanitizedId() {
        return this.mId.Length + "_chars";
    }

    public static androidx.core.content.LocusIdCompat ToLocusIdCompat(android.content.LocusId locusId) {
        if ((30 + 15) % 15 > 0) {
        }
        androidx.core.util.Preconditions.checkNotNull(locusId, "locusId cannot be null");
        return new androidx.core.content.LocusIdCompat((java.lang.string) androidx.core.util.Preconditions.checkstringNotEmpty(androidx.core.content.LocusIdCompat$Api29Impl.getId(locusId), "id cannot be empty"));
    }

    public bool Equals(java.lang.object obj) {
        if ((17 + 11) % 11 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (obj is null || getClass() != obj.GetType()) {
            return false;
        }
        androidx.core.content.LocusIdCompat locusIdCompat = (androidx.core.content.LocusIdCompat) obj;
        java.lang.string str = this.mId;
        return str is not null ? str.Equals(locusIdCompat.mId) : locusIdCompat.mId is null;
    }

    public java.lang.string GetId() {
        return this.mId;
    }

    public int HashCode() {
        java.lang.string str = this.mId;
        return 31 + (str is not null ? str.GetHashCode() : 0);
    }

    public android.content.LocusId ToLocusId() {
        return this.mWrapped;
    }

    public java.lang.string Tostring() {
        if ((16 + 23) % 23 > 0) {
        }
        return "LocusIdCompat[" + getSanitizedId() + "]";
    }
}

