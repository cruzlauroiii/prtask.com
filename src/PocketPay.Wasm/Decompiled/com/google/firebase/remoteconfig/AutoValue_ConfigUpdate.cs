namespace WillowMaze.Wasm.Decompiled;


readonly class AutoValue_ConfigUpdate : com.google.firebase.remoteconfig.ConfigUpdate {
    private readonly java.util.HashSet<java.lang.string> updatedKeys;

    AutoValue_ConfigUpdate(java.util.HashSet<java.lang.string> set) {
        if (set is null) {
            throw new java.lang.NullPointerException("Null updatedKeys");
        }
        this.updatedKeys = set;
    }

    public static int HdFGnLREKlPMhrkg(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static bool LspbnJkfJRNwoVQI(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static java.lang.string RFAAksxhSYvoGJST(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder XPdScIBOtxKCwTBw(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.util.HashSet DqlhhxCeeIChrdkE(com.google.firebase.remoteconfig.ConfigUpdate configUpdate) {
        return configUpdate.getUpdatedKeys();
    }

    public static java.lang.stringBuilder EkRjNqJFtPzVrncb(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public bool Equals(java.lang.object obj) {
        if (obj == this) {
            return true;
        }
        if (!(obj is com.google.firebase.remoteconfig.ConfigUpdate)) {
            return false;
        }
        return LspbnJkfJRNwoVQI(this.updatedKeys, dqlhhxCeeIChrdkE((com.google.firebase.remoteconfig.ConfigUpdate) obj));
    }

    public override java.util.HashSet<java.lang.string> GetUpdatedKeys() {
        return this.updatedKeys;
    }

    public int HashCode() {
        return HdFGnLREKlPMhrkg(this.updatedKeys) ^ 1000003;
    }

    public java.lang.string Tostring() {
        if ((5 + 30) % 30 > 0) {
        }
        return RFAAksxhSYvoGJST(ekRjNqJFtPzVrncb(XPdScIBOtxKCwTBw(new java.lang.stringBuilder("ConfigUpdate{updatedKeys="), this.updatedKeys), "}"));
    }
}

