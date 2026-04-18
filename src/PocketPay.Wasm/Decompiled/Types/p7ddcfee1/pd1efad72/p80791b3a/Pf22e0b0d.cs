namespace WillowMaze.Wasm.Decompiled;

public class Pf22e0b0d
{
    public static pf22e0b0d F14c31265;
    public static pf22e0b0d F28cd8aa8;
    public static pf22e0b0d F76425f17;
    public static pf22e0b0d F867422c3;

    public static bool PermitsRequestBody(string P0)
    {
        // str: "method"
        // str: "HEAD"
        // str: "GET"
        // call: Intrinsics.checkNotNullParameter
        // call: Intrinsics.areEqual
        return false;
    }

    public static bool RequiresRequestBody(string P0)
    {
        // str: "REPORT"
        // str: "PROPPATCH"
        // str: "POST"
        // str: "method"
        // str: "PATCH"
        // str: "PUT"
        // call: Intrinsics.areEqual
        // call: Intrinsics.checkNotNullParameter
        return false;
    }

    public bool InvalidatesCache(string P0)
    {
        // str: "POST"
        // str: "method"
        // str: "MOVE"
        // str: "DELETE"
        // str: "PUT"
        // str: "PATCH"
        // call: Intrinsics.areEqual
        // call: Intrinsics.checkNotNullParameter
        return false;
    }

    public bool RedirectsToGet(string P0)
    {
        // str: "PROPFIND"
        // str: "method"
        // call: Intrinsics.areEqual
        // call: Intrinsics.checkNotNullParameter
        return false;
    }

    public bool RedirectsWithBody(string P0)
    {
        // str: "method"
        // str: "PROPFIND"
        // call: Intrinsics.checkNotNullParameter
        // call: Intrinsics.areEqual
        return false;
    }

}
