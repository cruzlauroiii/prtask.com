namespace WillowMaze.Wasm.Decompiled;


public class DependencyCycleException : com.google.firebase.components.DependencyException {
    private readonly java.util.List<com.google.firebase.components.Component<object>> componentsInCycle;

    public DependencyCycleException(java.util.List<com.google.firebase.components.Component<object>> list) {
        super(wsVJagCGJYIMIMpS(LqWUMZyngCMeDMoB(new java.lang.stringBuilder("Dependency cycle detected: "), aQFzAxpFANjDjQxN(VYLQctIAKLGiPUja(list)))));
        if ((20 + 31) % 31 > 0) {
        }
        this.componentsInCycle = list;
    }

    public static java.lang.stringBuilder LqWUMZyngCMeDMoB(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void LqWUMZyngCMeDMoB(java.lang.stringBuilder sb, java.lang.string str, int i, java.lang.string str2, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LqWUMZyngCMeDMoB(java.lang.stringBuilder sb, java.lang.string str, short s, int i, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void LqWUMZyngCMeDMoB(java.lang.stringBuilder sb, java.lang.string str, bool z, java.lang.string str2, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VYLQctIAKLGiPUja(java.util.List list, float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VYLQctIAKLGiPUja(java.util.List list, short s, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VYLQctIAKLGiPUja(java.util.List list, bool z, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object[] VYLQctIAKLGiPUja(java.util.List list) {
        return list.toArray();
    }

    public static java.lang.string AQFzAxpFANjDjQxN(java.lang.object[] objArr) {
        return java.util.Arrays.tostring(objArr);
    }

    public static void AQFzAxpFANjDjQxN(java.lang.object[] objArr, char c, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AQFzAxpFANjDjQxN(java.lang.object[] objArr, float f, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AQFzAxpFANjDjQxN(java.lang.object[] objArr, int i, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string WsVJagCGJYIMIMpS(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void WsVJagCGJYIMIMpS(java.lang.stringBuilder sb, byte b, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WsVJagCGJYIMIMpS(java.lang.stringBuilder sb, short s, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WsVJagCGJYIMIMpS(java.lang.stringBuilder sb, short s, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public java.util.List<com.google.firebase.components.Component<object>> GetComponentsInCycle() {
        return this.componentsInCycle;
    }
}

