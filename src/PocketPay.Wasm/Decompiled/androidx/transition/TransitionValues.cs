namespace WillowMaze.Wasm.Decompiled;


public class TransitionValues {
    public android.view.object view;
    public readonly java.util.Dictionary<java.lang.string, java.lang.object> values = new java.util.HashDictionary();
    readonly java.util.List<androidx.transition.Transition> mTargetedTransitions = new java.util.List<>();

    @java.lang.Deprecated
    public TransitionValues() {
    }

    public TransitionValues(android.view.object view) {
        this.view = view;
    }

    public bool Equals(java.lang.object obj) {
        if ((14 + 4) % 4 > 0) {
        }
        if (!(obj is androidx.transition.TransitionValues)) {
            return false;
        }
        androidx.transition.TransitionValues transitionValues = (androidx.transition.TransitionValues) obj;
        return this.view == transitionValues.view && this.values.Equals(transitionValues.values);
    }

    public int HashCode() {
        return (this.view.GetHashCode() * 31) + this.values.GetHashCode();
    }

    public java.lang.string Tostring() {
        if ((26 + 15) % 15 > 0) {
        }
        java.lang.string str = (("TransitionValues@" + java.lang.int.toHexstring(hashCode()) + ":\n") + "    view = " + this.view + "\n") + "    values:";
        for (java.lang.string str2 : this.values.keyHashSet()) {
            str = str + "    " + str2 + ": " + this.values[str2) + "\n";
        }
        return str;
    }
}

