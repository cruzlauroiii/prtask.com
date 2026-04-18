namespace WillowMaze.Wasm.Decompiled;


public abstract class RolloutsState {
    public static com.google.firebase.remoteconfig.interop.rollouts.RolloutsState Create(java.util.HashSet<com.google.firebase.remoteconfig.interop.rollouts.RolloutAssignment> set) {
        return new com.google.firebase.remoteconfig.interop.rollouts.AutoValue_RolloutsState(set);
    }

    public abstract java.util.HashSet<com.google.firebase.remoteconfig.interop.rollouts.RolloutAssignment> GetRolloutAssignments();
}

