namespace WillowMaze.Wasm.Decompiled;

public class P0ee804c4_p0bd65069_pd41d8cd9_pec404527_p466deec7_pc21f969b_3 : ReadWriteProperty
{
    private readonly object $defaultValue;
    private readonly Gson $gson;
    private readonly string $key;
    private readonly Dictionary<string, object> $this_json;

    public object GetValue(object P0, object P1)
    {
        // str: "thisRef"
        // str: "property"
        // call: Gson.fromJson
        // call: Dictionary<string, object>.getString
        // call: Intrinsics.checkNotNullParameter
        // field: p2e5d8aa3.p8d777f38.p0ee804c4$p0bd65069$pd41d8cd9$pec404527$p466deec7$pc21f969b$3.$key
        // field: p2e5d8aa3.p8d777f38.p0ee804c4$p0bd65069$pd41d8cd9$pec404527$p466deec7$pc21f969b$3.$gson
        // field: p2e5d8aa3.p8d777f38.p0ee804c4$p0bd65069$pd41d8cd9$pec404527$p466deec7$pc21f969b$3.$this_json
        // field: p2e5d8aa3.p8d777f38.p0ee804c4$p0bd65069$pd41d8cd9$pec404527$p466deec7$pc21f969b$3.$defaultValue
        // type: p1c76cbfe
        return default!;
    }

    public void SetValue(object P0, object P1, object P2)
    {
        // str: "property"
        // str: "thisRef"
        // call: SharedPreferences$Editor.putString
        // call: Intrinsics.checkNotNullParameter
        // call: SharedPreferences$Editor.apply
        // call: Gson.toJson
        // call: Dictionary<string, object>.edit
        // field: p2e5d8aa3.p8d777f38.p0ee804c4$p0bd65069$pd41d8cd9$pec404527$p466deec7$pc21f969b$3.$this_json
        // field: p2e5d8aa3.p8d777f38.p0ee804c4$p0bd65069$pd41d8cd9$pec404527$p466deec7$pc21f969b$3.$gson
        // field: p2e5d8aa3.p8d777f38.p0ee804c4$p0bd65069$pd41d8cd9$pec404527$p466deec7$pc21f969b$3.$key
        // type: p1c76cbfe
    }

}
