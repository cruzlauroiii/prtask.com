namespace WillowMaze.Wasm.Decompiled;

public class P62d58733_p466deec7_1 : ReadWriteProperty
{
    private readonly object $defaultValue;
    private readonly Gson $gson;
    private readonly string $key;
    private readonly Dictionary<string, object> $this_json;

    public object GetValue(object P0, object P1)
    {
        // str: "property"
        // str: "thisRef"
        // str: "7d77b61441f729732cae4fd78a08043197b9bcefd527a79b0eed69ca05"
        // call: Intrinsics.checkNotNullParameter
        // call: DecryptString.decryptString
        // call: Intrinsics.reifiedOperationMarker
        // call: Gson.fromJson
        // call: Dictionary<string, object>.getString
        // field: p2b3583e6.p7f662005.pdbc11caa.p62d58733$p466deec7$1.$gson
        // field: p2b3583e6.p7f662005.pdbc11caa.p62d58733$p466deec7$1.$defaultValue
        // field: p2b3583e6.p7f662005.pdbc11caa.p62d58733$p466deec7$1.$this_json
        // field: p2b3583e6.p7f662005.pdbc11caa.p62d58733$p466deec7$1.$key
        // type: object
        return default!;
    }

    public void SetValue(object P0, object P1, object P2)
    {
        // str: "thisRef"
        // str: "d96fced847a69542161b29f8364d7cfe5a183b67a1a46dc924df1d517b"
        // str: "property"
        // call: Intrinsics.reifiedOperationMarker
        // call: Intrinsics.checkNotNullParameter
        // call: SharedPreferences$Editor.apply
        // call: DecryptString.decryptString
        // call: SharedPreferences$Editor.putString
        // call: Gson.toJson
        // call: Dictionary<string, object>.edit
        // field: p2b3583e6.p7f662005.pdbc11caa.p62d58733$p466deec7$1.$key
        // field: p2b3583e6.p7f662005.pdbc11caa.p62d58733$p466deec7$1.$this_json
        // field: p2b3583e6.p7f662005.pdbc11caa.p62d58733$p466deec7$1.$gson
        // type: object
    }

}
