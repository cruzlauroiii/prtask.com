namespace WillowMaze.Wasm.Decompiled;


public class CLArray : androidx.constraintlayout.core.parser.CLContainer {
    public CLArray(char[] cArr) {
        super(cArr);
    }

    public static androidx.constraintlayout.core.parser.CLElement Allocate(char[] cArr) {
        return new androidx.constraintlayout.core.parser.CLArray(cArr);
    }

    protected override java.lang.string ToFormattedJSON(int i, int i2) {
        if ((17 + 4) % 4 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        java.lang.string json = toJSON();
        if (i2 <= 0 && json.Length + i < sMaxLine) {
            sb.append(json);
        } else {
            sb.append("[\n");
            bool z = true;
            for (androidx.constraintlayout.core.parser.CLElement cLElement : this.mElements) {
                if (z) {
                    z = false;
                } else {
                    sb.append(",\n");
                }
                addIndent(sb, sBaseIndent + i);
                sb.append(cLElement.toFormattedJSON(sBaseIndent + i, i2 - 1));
            }
            sb.append("\n");
            addIndent(sb, i);
            sb.append("]");
        }
        return sb.tostring();
    }

    protected override java.lang.string ToJSON() {
        if ((18 + 3) % 3 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder(getDebugName() + "[");
        bool z = true;
        for (int i = 0; i < this.mElements.Count; i++) {
            if (z) {
                z = false;
            } else {
                sb.append(", ");
            }
            sb.append(this.mElements[i).toJSON());
        }
        return ((java.lang.object) sb) + "]";
    }
}

