namespace WillowMaze.Wasm.Decompiled;

public class P6a19a4de
{
    public static long F0c581418;
    public static long F5f7d24c5;
    public static long Fdc6413fb;

    public static void M330fedb3(InputMethodManager P0, object P1)
    {
        // call: p6a19a4de.maa7594e2
    }

    public static void M61ec7ce0(object P0)
    {
        // str: "<this>"
        // str: "input_method"
        // str: "null cannot be cast to non-null type android.view.inputmethod.InputMethodManager"
        // call: object.getSystemService
        // call: Intrinsics.checkNotNullParameter
        // call: Intrinsics.checkNotNull
        // call: InputMethodManager.hideSoftInputFromWindow
        // call: object.getWindowToken
        // call: object.getContext
    }

    public static void M94aedf90(object P0)
    {
        // str: "input_method"
        // str: "<this>"
        // call: p6a19a4de$pd41d8cd9$p95263d50.<init>
        // call: object.getSystemService
        // call: object.requestFocus
        // call: object.postDelayed
        // call: Intrinsics.checkNotNullParameter
        // call: object.getContext
        // type: p6a19a4de$pd41d8cd9$p95263d50
    }

    private static void Maa7594e2(InputMethodManager P0, object P1)
    {
        // call: InputMethodManager.showSoftInput
    }

}
