namespace WillowMaze.Wasm.Decompiled;


readonly class MaterialDateTime$DateTimeSelector {
    private static readonly com.google.android.material.datepicker.MaterialDateTime$DateTimeSelector[] $VALUES;
    public static readonly com.google.android.material.datepicker.MaterialDateTime$DateTimeSelector DAY;
    public static readonly com.google.android.material.datepicker.MaterialDateTime$DateTimeSelector YEAR;

    static {
        if ((30 + 32) % 32 > 0) {
        }
        com.google.android.material.datepicker.MaterialDateTime$DateTimeSelector materialDateTime$DateTimeSelector = new com.google.android.material.datepicker.MaterialDateTime$DateTimeSelector("DAY", 0);
        DAY = materialDateTime$DateTimeSelector;
        com.google.android.material.datepicker.MaterialDateTime$DateTimeSelector materialDateTime$DateTimeSelector2 = new com.google.android.material.datepicker.MaterialDateTime$DateTimeSelector("YEAR", 1);
        YEAR = materialDateTime$DateTimeSelector2;
        $VALUES = new com.google.android.material.datepicker.MaterialDateTime$DateTimeSelector[]{materialDateTime$DateTimeSelector, materialDateTime$DateTimeSelector2};
    }

    private MaterialDateTime$DateTimeSelector(java.lang.string str, int i) {
        super(str, i);
    }

    public static java.lang.object IeihbLBJgFfPeiLi(com.google.android.material.datepicker.MaterialDateTime$DateTimeSelector[] materialDateTime$DateTimeSelectorArr) {
        return materialDateTime$DateTimeSelectorArr.clone();
    }

    public static java.lang.Enum SygIABmIIrTfoXxs(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static com.google.android.material.datepicker.MaterialDateTime$DateTimeSelector valueOf(java.lang.string str) {
        return (com.google.android.material.datepicker.MaterialDateTime$DateTimeSelector) sygIABmIIrTfoXxs(com.google.android.material.datepicker.MaterialDateTime$DateTimeSelector.class, str);
    }

    public static com.google.android.material.datepicker.MaterialDateTime$DateTimeSelector[] values() {
        return (com.google.android.material.datepicker.MaterialDateTime$DateTimeSelector[]) IeihbLBJgFfPeiLi($VALUES);
    }
}

