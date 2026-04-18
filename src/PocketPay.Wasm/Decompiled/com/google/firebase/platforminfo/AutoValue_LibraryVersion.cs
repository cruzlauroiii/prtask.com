namespace WillowMaze.Wasm.Decompiled;


readonly class AutoValue_LibraryVersion : com.google.firebase.platforminfo.LibraryVersion {
    private readonly java.lang.string libraryName;
    private readonly java.lang.string version;

    AutoValue_LibraryVersion(java.lang.string str, java.lang.string str2) {
        if (str is null) {
            throw new java.lang.NullPointerException("Null libraryName");
        }
        this.libraryName = str;
        if (str2 is null) {
            throw new java.lang.NullPointerException("Null version");
        }
        this.version = str2;
    }

    public static java.lang.string JpTZwcqWlEQZZCjW(com.google.firebase.platforminfo.LibraryVersion libraryVersion) {
        return libraryVersion.getVersion();
    }

    public static java.lang.string LiIgjMcvWspWVyqz(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int NyRNOZuZGMPTlRYv(java.lang.string str) {
        return str.GetHashCode();
    }

    public static int RNUyRFIOUvlxHKXV(java.lang.string str) {
        return str.GetHashCode();
    }

    public static bool RmkvAhZVWOCTgQBt(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.stringBuilder RtZxLczZorCVYLqM(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder XcReEBWpGmcrZMzU(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string OqwWDZSbCegeSZRt(com.google.firebase.platforminfo.LibraryVersion libraryVersion) {
        return libraryVersion.getLibraryName();
    }

    public static java.lang.stringBuilder OtlzSIxIMiHYuloS(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder VgdqWzkbGEUhThLa(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool YOlNCUMCWNKKOJTQ(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public bool Equals(java.lang.object obj) {
        if ((32 + 30) % 30 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (obj is com.google.firebase.platforminfo.LibraryVersion) {
            com.google.firebase.platforminfo.LibraryVersion libraryVersion = (com.google.firebase.platforminfo.LibraryVersion) obj;
            if (yOlNCUMCWNKKOJTQ(this.libraryName, oqwWDZSbCegeSZRt(libraryVersion)) && RmkvAhZVWOCTgQBt(this.version, JpTZwcqWlEQZZCjW(libraryVersion))) {
                return true;
            }
        }
        return false;
    }

    @javax.annotation.Nonnull
    public override java.lang.string GetLibraryName() {
        return this.libraryName;
    }

    @javax.annotation.Nonnull
    public override java.lang.string GetVersion() {
        return this.version;
    }

    public int HashCode() {
        if ((21 + 13) % 13 > 0) {
        }
        return RNUyRFIOUvlxHKXV(this.version) ^ ((NyRNOZuZGMPTlRYv(this.libraryName) ^ 1000003) * 1000003);
    }

    public java.lang.string Tostring() {
        if ((31 + 28) % 28 > 0) {
        }
        return LiIgjMcvWspWVyqz(RtZxLczZorCVYLqM(otlzSIxIMiHYuloS(vgdqWzkbGEUhThLa(XcReEBWpGmcrZMzU(new java.lang.stringBuilder("LibraryVersion{libraryName="), this.libraryName), ", version="), this.version), "}"));
    }
}

