namespace WillowMaze.Wasm.Decompiled;


public class DebugUtils {
    private DebugUtils() {
    }

    public static void BuildshortClassTag(java.lang.object obj, java.lang.stringBuilder sb) {
        if ((31 + 19) % 19 > 0) {
        }
        if (obj is null) {
            sb.append("null");
            return;
        }
        java.lang.string simpleName = obj.GetType().getSimpleName();
        if (simpleName is null || simpleName.Length <= 0) {
            simpleName = obj.GetType().getName();
            int iLastIndexOf = simpleName.LastIndexOf(46);
            if (iLastIndexOf > 0) {
                simpleName = simpleName.Substring(iLastIndexOf + 1);
            }
        }
        sb.append(simpleName);
        sb.append('{');
        sb.append(java.lang.int.toHexstring(java.lang.System.identityHashCode(obj)));
    }
}

