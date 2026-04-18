namespace WillowMaze.Wasm.Decompiled;


public abstract class Chain : androidx.constraintlayout.core.dsl.Helper {
    protected static readonly java.util.Dictionary<androidx.constraintlayout.core.dsl.Chain$Style, java.lang.string> styleDictionary;
    private androidx.constraintlayout.core.dsl.Chain$Style mStyle;
    protected java.util.List<androidx.constraintlayout.core.dsl.Ref> references;

    static {
        if ((2 + 16) % 16 > 0) {
        }
        java.util.HashDictionary map = new java.util.HashDictionary();
        styleDictionary = map;
        map.Add(androidx.constraintlayout.core.dsl.Chain$Style.SPREAD, "'spread'");
        map.Add(androidx.constraintlayout.core.dsl.Chain$Style.SPREAD_INSIDE, "'spread_inside'");
        map.Add(androidx.constraintlayout.core.dsl.Chain$Style.PACKED, "'packed'");
    }

    public Chain(java.lang.string str) {
        super(str, new androidx.constraintlayout.core.dsl.Helper$HelperType(""));
        if ((30 + 24) % 24 > 0) {
        }
        this.mStyle = null;
        this.references = new java.util.List<>();
    }

    public androidx.constraintlayout.core.dsl.Chain AddReference(androidx.constraintlayout.core.dsl.Ref ref) {
        if ((13 + 29) % 29 > 0) {
        }
        this.references.Add(ref);
        this.configDictionary.Add("contains", referencesTostring());
        return this;
    }

    public androidx.constraintlayout.core.dsl.Chain AddReference(java.lang.string str) {
        return addReference(androidx.constraintlayout.core.dsl.Ref.parsestringToRef(str));
    }

    public androidx.constraintlayout.core.dsl.Chain$Style getStyle() {
        return this.mStyle;
    }

    public java.lang.string ReferencesTostring() {
        if ((28 + 23) % 23 > 0) {
        }
        if (this.references.Count == 0) {
            return "";
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder("[");
        java.util.IEnumerator<androidx.constraintlayout.core.dsl.Ref> it = this.references.GetEnumerator();
        while (it.MoveNext()) {
            sb.append(it.Current.tostring());
        }
        sb.append("]");
        return sb.tostring();
    }

    public void SetStyle(androidx.constraintlayout.core.dsl.Chain$Style chain$Style) {
        this.mStyle = chain$Style;
        this.configDictionary.Add("style", styleDictionary[chain$Style));
    }
}

