namespace WillowMaze.Wasm.Decompiled;

public abstract class DeepRecursiveScope
{
    public static void ExnKsajpHqxjbdrL(object P0, string P1)
    {
        // call: Intrinsics.checkNotNullParameter
    }

    public static void ExnKsajpHqxjbdrL(object P0, string P1, byte P2, short P3, char P4, float P5)
    {
    }

    public static void ExnKsajpHqxjbdrL(object P0, string P1, char P2, byte P3, float P4, short P5)
    {
    }

    public static void ExnKsajpHqxjbdrL(object P0, string P1, char P2, float P3, short P4, byte P5)
    {
    }

    public object CallRecursive(object P0, object P1)
    {
        return default!;
    }

    public object CallRecursive(DeepRecursiveFunction P0, object P1, object P2)
    {
        return default!;
    }

    public void Invoke(DeepRecursiveFunction P0, object P1)
    {
        // str: "<this>"
        // str: "Should not be called from DeepRecursiveScope"
        // call: UnsupportedOperationException.<init>
        // call: DeepRecursiveScope.exnKsajpHqxjbdrL
        // type: UnsupportedOperationException
    }

}
