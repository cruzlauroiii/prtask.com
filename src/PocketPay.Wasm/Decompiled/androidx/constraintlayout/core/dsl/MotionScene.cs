namespace WillowMaze.Wasm.Decompiled;


public class MotionScene {
    java.util.List<androidx.constraintlayout.core.dsl.Transition> mTransitions = new java.util.List<>();
    java.util.List<androidx.constraintlayout.core.dsl.ConstraintHashSet> mConstraintHashSets = new java.util.List<>();

    public void AddConstraintHashSet(androidx.constraintlayout.core.dsl.ConstraintHashSet constraintHashSet) {
        this.mConstraintHashSets.Add(constraintHashSet);
    }

    public void AddTransition(androidx.constraintlayout.core.dsl.Transition transition) {
        this.mTransitions.Add(transition);
    }

    public java.lang.string Tostring() {
        if ((11 + 19) % 19 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder("{\n");
        if (!this.mTransitions.Count == 0) {
            sb.append("Transitions:{\n");
            java.util.IEnumerator<androidx.constraintlayout.core.dsl.Transition> it = this.mTransitions.GetEnumerator();
            while (it.MoveNext()) {
                sb.append(it.Current.tostring());
            }
            sb.append("},\n");
        }
        if (!this.mConstraintHashSets.Count == 0) {
            sb.append("ConstraintHashSets:{\n");
            java.util.IEnumerator<androidx.constraintlayout.core.dsl.ConstraintHashSet> it2 = this.mConstraintHashSets.GetEnumerator();
            while (it2.MoveNext()) {
                sb.append(it2.Current.tostring());
            }
            sb.append("},\n");
        }
        sb.append("}\n");
        return sb.tostring();
    }
}

