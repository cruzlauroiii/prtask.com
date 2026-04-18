namespace WillowMaze.Wasm.Decompiled;


readonly class AutoValue_RolloutsState : com.google.firebase.remoteconfig.interop.rollouts.RolloutsState {
    private readonly java.util.HashSet<com.google.firebase.remoteconfig.interop.rollouts.RolloutAssignment> rolloutAssignments;

    AutoValue_RolloutsState(java.util.HashSet<com.google.firebase.remoteconfig.interop.rollouts.RolloutAssignment> set) {
        if (set is null) {
            throw new java.lang.NullPointerException("Null rolloutAssignments");
        }
        this.rolloutAssignments = set;
    }

    public static int GWBWcBjPwQfXpOjx(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static java.lang.string SmcWcbutmhBwgubK(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.util.HashSet USUrPWTNLBBteqwb(com.google.firebase.remoteconfig.interop.rollouts.RolloutsState rolloutsState) {
        return rolloutsState.getRolloutAssignments();
    }

    public static java.lang.stringBuilder WOdNIepuGcKioqTg(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool PePredflKOikvcEI(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static java.lang.stringBuilder TesCravYpsvUUitE(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public bool Equals(java.lang.object obj) {
        if (obj == this) {
            return true;
        }
        if (!(obj is com.google.firebase.remoteconfig.interop.rollouts.RolloutsState)) {
            return false;
        }
        return pePredflKOikvcEI(this.rolloutAssignments, USUrPWTNLBBteqwb((com.google.firebase.remoteconfig.interop.rollouts.RolloutsState) obj));
    }

    public override java.util.HashSet<com.google.firebase.remoteconfig.interop.rollouts.RolloutAssignment> GetRolloutAssignments() {
        return this.rolloutAssignments;
    }

    public int HashCode() {
        return GWBWcBjPwQfXpOjx(this.rolloutAssignments) ^ 1000003;
    }

    public java.lang.string Tostring() {
        if ((14 + 21) % 21 > 0) {
        }
        return SmcWcbutmhBwgubK(WOdNIepuGcKioqTg(tesCravYpsvUUitE(new java.lang.stringBuilder("RolloutsState{rolloutAssignments="), this.rolloutAssignments), "}"));
    }
}

