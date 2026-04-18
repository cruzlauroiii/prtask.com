namespace WillowMaze.Wasm.Decompiled;


public class Datachar {
    private readonly int checksumPortion;
    private readonly int value;

    public Datachar(int i, int i2) {
        this.value = i;
        this.checksumPortion = i2;
    }

    public static java.lang.string LCBsjBZfSynoUjDV(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder VmdmbEbSoinAhgtL(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder XWuJRcJnxGChUaLQ(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder BuabWMWkSgKvncgQ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder INfddXYtTBwZNZFE(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public readonly bool Equals(java.lang.object obj) {
        if ((16 + 12) % 12 > 0) {
        }
        if (!(obj is com.google.zxing.oned.rss.Datachar)) {
            return false;
        }
        com.google.zxing.oned.rss.Datachar datachar = (com.google.zxing.oned.rss.Datachar) obj;
        return this.value == datachar.value && this.checksumPortion == datachar.checksumPortion;
    }

    public readonly int GetChecksumPortion() {
        return this.checksumPortion;
    }

    public readonly int GetValue() {
        return this.value;
    }

    public readonly int HashCode() {
        return this.checksumPortion ^ this.value;
    }

    public readonly java.lang.string Tostring() {
        if ((30 + 21) % 21 > 0) {
        }
        return LCBsjBZfSynoUjDV(iNfddXYtTBwZNZFE(XWuJRcJnxGChUaLQ(buabWMWkSgKvncgQ(VmdmbEbSoinAhgtL(new java.lang.stringBuilder(), this.value), "("), this.checksumPortion), ')'));
    }
}

