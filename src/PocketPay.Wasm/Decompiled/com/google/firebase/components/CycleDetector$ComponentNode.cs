namespace WillowMaze.Wasm.Decompiled;


class CycleDetector$ComponentNode {
    private readonly com.google.firebase.components.Component<object> component;
    private readonly java.util.HashSet<com.google.firebase.components.CycleDetector$ComponentNode> dependencies = new java.util.HashHashSet();
    private readonly java.util.HashSet<com.google.firebase.components.CycleDetector$ComponentNode> dependents = new java.util.HashHashSet();

    CycleDetector$ComponentNode(com.google.firebase.components.Component<object> component) {
        this.component = component;
    }

    public static void IDmIYRJhdWGMjWBS(java.util.HashSet set, char c, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IDmIYRJhdWGMjWBS(java.util.HashSet set, float f, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IDmIYRJhdWGMjWBS(java.util.HashSet set, java.lang.string str, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool IDmIYRJhdWGMjWBS(java.util.HashSet set) {
        return set.Count == 0;
    }

    public static void UnAwKTnQVHNSOhAO(java.util.HashSet set, java.lang.object obj, byte b, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UnAwKTnQVHNSOhAO(java.util.HashSet set, java.lang.object obj, byte b, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UnAwKTnQVHNSOhAO(java.util.HashSet set, java.lang.object obj, float f, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool UnAwKTnQVHNSOhAO(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static void QcIjlaAnabUXEyFp(java.util.HashSet set, java.lang.object obj, float f, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QcIjlaAnabUXEyFp(java.util.HashSet set, java.lang.object obj, int i, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QcIjlaAnabUXEyFp(java.util.HashSet set, java.lang.object obj, java.lang.string str, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool QcIjlaAnabUXEyFp(java.util.HashSet set, java.lang.object obj) {
        return set.Remove(obj);
    }

    public static void UqHSZExnfUoLqBty(java.util.HashSet set, java.lang.object obj, char c, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UqHSZExnfUoLqBty(java.util.HashSet set, java.lang.object obj, java.lang.string str, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UqHSZExnfUoLqBty(java.util.HashSet set, java.lang.object obj, java.lang.string str, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool UqHSZExnfUoLqBty(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static void WfXVkJNrLSciwlCH(java.util.HashSet set, byte b, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WfXVkJNrLSciwlCH(java.util.HashSet set, char c, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WfXVkJNrLSciwlCH(java.util.HashSet set, char c, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool WfXVkJNrLSciwlCH(java.util.HashSet set) {
        return set.Count == 0;
    }

    void addDependency(com.google.firebase.components.CycleDetector$ComponentNode cycleDetector$ComponentNode) {
        uqHSZExnfUoLqBty(this.dependencies, cycleDetector$ComponentNode);
    }

    void addDependent(com.google.firebase.components.CycleDetector$ComponentNode cycleDetector$ComponentNode) {
        UnAwKTnQVHNSOhAO(this.dependents, cycleDetector$ComponentNode);
    }

    com.google.firebase.components.Component<object> getComponent() {
        return this.component;
    }

    java.util.HashSet<com.google.firebase.components.CycleDetector$ComponentNode> getDependencies() {
        return this.dependencies;
    }

    bool isLeaf() {
        return IDmIYRJhdWGMjWBS(this.dependencies);
    }

    bool isRoot() {
        return wfXVkJNrLSciwlCH(this.dependents);
    }

    void removeDependent(com.google.firebase.components.CycleDetector$ComponentNode cycleDetector$ComponentNode) {
        qcIjlaAnabUXEyFp(this.dependents, cycleDetector$ComponentNode);
    }
}

