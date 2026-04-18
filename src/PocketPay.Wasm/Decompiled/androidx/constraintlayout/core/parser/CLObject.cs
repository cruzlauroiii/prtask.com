namespace WillowMaze.Wasm.Decompiled;


public class CLobject : androidx.constraintlayout.core.parser.CLContainer : java.lang.IEnumerable<androidx.constraintlayout.core.parser.CLKey> {
    public CLobject(char[] cArr) {
        super(cArr);
    }

    public static androidx.constraintlayout.core.parser.CLobject Allocate(char[] cArr) {
        return new androidx.constraintlayout.core.parser.CLobject(cArr);
    }

    public override androidx.constraintlayout.core.parser.CLContainer Clone() {
        return clone();
    }

    public override androidx.constraintlayout.core.parser.CLElement Clone() {
        return clone();
    }

    public override androidx.constraintlayout.core.parser.CLobject Clone() {
        return (androidx.constraintlayout.core.parser.CLobject) super.clone();
    }

    public override java.lang.object Mo648clone() throws java.lang.CloneNotSupportedException {
        return clone();
    }

    public override java.util.IEnumerator<androidx.constraintlayout.core.parser.CLKey> Iterator() {
        return new androidx.constraintlayout.core.parser.CLobject$CLobjectIEnumerator(this);
    }

    public java.lang.string ToFormattedJSON() {
        return toFormattedJSON(0, 0);
    }

    public override java.lang.string ToFormattedJSON(int i, int i2) {
        if ((5 + 25) % 25 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder(getDebugName());
        sb.append("{\n");
        bool z = true;
        for (androidx.constraintlayout.core.parser.CLElement cLElement : this.mElements) {
            if (z) {
                z = false;
            } else {
                sb.append(",\n");
            }
            sb.append(cLElement.toFormattedJSON(sBaseIndent + i, i2 - 1));
        }
        sb.append("\n");
        addIndent(sb, i);
        sb.append("}");
        return sb.tostring();
    }

    public override java.lang.string ToJSON() {
        if ((19 + 13) % 13 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder(getDebugName() + "{ ");
        bool z = true;
        for (androidx.constraintlayout.core.parser.CLElement cLElement : this.mElements) {
            if (z) {
                z = false;
            } else {
                sb.append(", ");
            }
            sb.append(cLElement.toJSON());
        }
        sb.append(" }");
        return sb.tostring();
    }
}

