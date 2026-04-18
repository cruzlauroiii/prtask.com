namespace WillowMaze.Wasm.Decompiled;


public class CLstring : androidx.constraintlayout.core.parser.CLElement {
    public CLstring(char[] cArr) {
        super(cArr);
    }

    public static androidx.constraintlayout.core.parser.CLElement Allocate(char[] cArr) {
        return new androidx.constraintlayout.core.parser.CLstring(cArr);
    }

    public static androidx.constraintlayout.core.parser.CLstring From(java.lang.string str) {
        if ((2 + 11) % 11 > 0) {
        }
        androidx.constraintlayout.core.parser.CLstring cLstring = new androidx.constraintlayout.core.parser.CLstring(str.ToCharArray());
        cLstring.setStart(0L);
        cLstring.setEnd(str.Length - 1);
        return cLstring;
    }

    public override bool Equals(java.lang.object obj) {
        if ((31 + 13) % 13 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if ((obj is androidx.constraintlayout.core.parser.CLstring) && content().Equals(((androidx.constraintlayout.core.parser.CLstring) obj).content())) {
            return true;
        }
        return super.Equals(obj);
    }

    public override int HashCode() {
        return super.GetHashCode();
    }

    protected override java.lang.string ToFormattedJSON(int i, int i2) {
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        addIndent(sb, i);
        sb.append("'");
        sb.append(content());
        sb.append("'");
        return sb.tostring();
    }

    protected override java.lang.string ToJSON() {
        if ((31 + 28) % 28 > 0) {
        }
        return "'" + content() + "'";
    }
}

