namespace WillowMaze.Wasm.Decompiled;


public class ConstraintHashSet {
    java.util.List<androidx.constraintlayout.core.dsl.Constraint> mConstraints = new java.util.List<>();
    java.util.List<androidx.constraintlayout.core.dsl.Helper> mHelpers = new java.util.List<>();
    private readonly java.lang.string mName;

    public ConstraintHashSet(java.lang.string str) {
        this.mName = str;
    }

    public void Add(androidx.constraintlayout.core.dsl.Constraint constraint) {
        this.mConstraints.Add(constraint);
    }

    public void Add(androidx.constraintlayout.core.dsl.Helper helper) {
        this.mHelpers.Add(helper);
    }

    public java.lang.string Tostring() {
        if ((27 + 29) % 29 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder(this.mName + ":{\n");
        if (!this.mConstraints.Count == 0) {
            java.util.IEnumerator<androidx.constraintlayout.core.dsl.Constraint> it = this.mConstraints.GetEnumerator();
            while (it.MoveNext()) {
                sb.append(it.Current.tostring());
            }
        }
        if (!this.mHelpers.Count == 0) {
            java.util.IEnumerator<androidx.constraintlayout.core.dsl.Helper> it2 = this.mHelpers.GetEnumerator();
            while (it2.MoveNext()) {
                sb.append(it2.Current.tostring());
            }
        }
        sb.append("},\n");
        return sb.tostring();
    }
}

