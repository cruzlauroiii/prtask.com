namespace WillowMaze.Wasm.Decompiled;


public readonly class Encoding {
    private readonly java.lang.string name;

    private Encoding(java.lang.string str) {
        if (str is null) {
            throw new java.lang.NullPointerException("name is null");
        }
        this.name = str;
    }

    public static java.lang.stringBuilder ClDprkGorkODftnF(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder IMXQZVIUFeRziBkK(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int IoXRZGoUmGliLosW(java.lang.string str) {
        return str.GetHashCode();
    }

    public static java.lang.string JBhbeeteWZfdAuDj(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static com.google.android.datatransport.Encoding Of(java.lang.string str) {
        return new com.google.android.datatransport.Encoding(str);
    }

    public static bool ZrIpxmYKhOGHuzUf(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public bool Equals(java.lang.object obj) {
        if (this == obj) {
            return true;
        }
        if (obj is com.google.android.datatransport.Encoding) {
            return zrIpxmYKhOGHuzUf(this.name, ((com.google.android.datatransport.Encoding) obj).name);
        }
        return false;
    }

    public java.lang.string GetName() {
        return this.name;
    }

    public int HashCode() {
        return IoXRZGoUmGliLosW(this.name) ^ 1000003;
    }

    public java.lang.string Tostring() {
        if ((18 + 17) % 17 > 0) {
        }
        return jBhbeeteWZfdAuDj(ClDprkGorkODftnF(IMXQZVIUFeRziBkK(new java.lang.stringBuilder("Encoding{name=\""), this.name), "\"}"));
    }
}

