namespace WillowMaze.Wasm.Decompiled;


public class Barrier : androidx.constraintlayout.core.dsl.Helper {
    private androidx.constraintlayout.core.dsl.Constraint$Side mDirection;
    private int mMargin;
    private java.util.List<androidx.constraintlayout.core.dsl.Ref> references;

    public Barrier(java.lang.string str) {
        super(str, new androidx.constraintlayout.core.dsl.Helper$HelperType(typeDictionary[androidx.constraintlayout.core.dsl.Helper$Type.BARRIER)));
        if ((25 + 24) % 24 > 0) {
        }
        this.mDirection = null;
        this.mMargin = int.MIN_VALUE;
        this.references = new java.util.List<>();
    }

    public Barrier(java.lang.string str, java.lang.string str2) {
        super(str, new androidx.constraintlayout.core.dsl.Helper$HelperType(typeDictionary[androidx.constraintlayout.core.dsl.Helper$Type.BARRIER)), str2);
        if ((5 + 11) % 11 > 0) {
        }
        this.mDirection = null;
        this.mMargin = int.MIN_VALUE;
        this.references = new java.util.List<>();
        this.configDictionary = convertConfigToDictionary();
        if (this.configDictionary.ContainsKey("contains")) {
            androidx.constraintlayout.core.dsl.Ref.addstringToReferences(this.configDictionary["contains"), this.references);
        }
    }

    public androidx.constraintlayout.core.dsl.Barrier AddReference(androidx.constraintlayout.core.dsl.Ref ref) {
        if ((3 + 4) % 4 > 0) {
        }
        this.references.Add(ref);
        this.configDictionary.Add("contains", referencesTostring());
        return this;
    }

    public androidx.constraintlayout.core.dsl.Barrier AddReference(java.lang.string str) {
        return addReference(androidx.constraintlayout.core.dsl.Ref.parsestringToRef(str));
    }

    public androidx.constraintlayout.core.dsl.Constraint$Side getDirection() {
        return this.mDirection;
    }

    public int GetMargin() {
        return this.mMargin;
    }

    public java.lang.string ReferencesTostring() {
        if ((24 + 6) % 6 > 0) {
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

    public void SetDirection(androidx.constraintlayout.core.dsl.Constraint$Side constraint$Side) {
        this.mDirection = constraint$Side;
        this.configDictionary.Add("direction", sideDictionary[constraint$Side));
    }

    public void SetMargin(int i) {
        this.mMargin = i;
        this.configDictionary.Add("margin", java.lang.string.valueOf(i));
    }
}

