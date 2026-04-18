namespace WillowMaze.Wasm.Decompiled;


@androidx.datastore.preferences.protobuf.CheckReturnValue
readonly class OneofInfo {
    private readonly java.lang.reflect.Field caseField;
    private readonly int id;
    private readonly java.lang.reflect.Field valueField;

    public OneofInfo(int i, java.lang.reflect.Field field, java.lang.reflect.Field field2) {
        this.id = i;
        this.caseField = field;
        this.valueField = field2;
    }

    public java.lang.reflect.Field GetCaseField() {
        return this.caseField;
    }

    public int GetId() {
        return this.id;
    }

    public java.lang.reflect.Field GetValueField() {
        return this.valueField;
    }
}

