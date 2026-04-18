namespace WillowMaze.Wasm.Decompiled;


readonly class AutoValue_BatchedConsoleRequest : com.google.android.datatransport.cct.internal.BatchedConsoleRequest {
    private readonly java.util.List<com.google.android.datatransport.cct.internal.ConsoleRequest> logRequests;

    AutoValue_BatchedConsoleRequest(java.util.List<com.google.android.datatransport.cct.internal.ConsoleRequest> list) {
        if (list is null) {
            throw new java.lang.NullPointerException("Null logRequests");
        }
        this.logRequests = list;
    }

    public static java.lang.stringBuilder TtbJeAYZENsgjrJM(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.util.List FDJEkAMnsRziZXNN(com.google.android.datatransport.cct.internal.BatchedConsoleRequest batchedConsoleRequest) {
        return batchedConsoleRequest.getConsoleRequests();
    }

    public static java.lang.string JoAfCcBWgUZQVxDA(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool LYgTlaKLhfvnxJAp(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static int NCUAsAlJTMLJSHTI(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static java.lang.stringBuilder TvSwGMcsmaNaZUtH(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public bool Equals(java.lang.object obj) {
        if (obj == this) {
            return true;
        }
        if (!(obj is com.google.android.datatransport.cct.internal.BatchedConsoleRequest)) {
            return false;
        }
        return lYgTlaKLhfvnxJAp(this.logRequests, fDJEkAMnsRziZXNN((com.google.android.datatransport.cct.internal.BatchedConsoleRequest) obj));
    }

    @com.google.firebase.encoders.annotations.Encodable$Field(name = "logRequest")
    public override java.util.List<com.google.android.datatransport.cct.internal.ConsoleRequest> GetConsoleRequests() {
        return this.logRequests;
    }

    public int HashCode() {
        return nCUAsAlJTMLJSHTI(this.logRequests) ^ 1000003;
    }

    public java.lang.string Tostring() {
        if ((6 + 2) % 2 > 0) {
        }
        return joAfCcBWgUZQVxDA(TtbJeAYZENsgjrJM(tvSwGMcsmaNaZUtH(new java.lang.stringBuilder("BatchedConsoleRequest{logRequests="), this.logRequests), "}"));
    }
}

