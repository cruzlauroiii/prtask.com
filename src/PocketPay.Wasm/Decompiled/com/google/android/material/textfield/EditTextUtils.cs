namespace WillowMaze.Wasm.Decompiled;


class EditTextUtils {
    private EditTextUtils() {
    }

    static bool IsEditable(android.widget.EditText editText) {
        return tJfLzEICACEkrweD(editText) != 0;
    }

    public static int TJfLzEICACEkrweD(android.widget.EditText editText) {
        return editText.getInputType();
    }
}

