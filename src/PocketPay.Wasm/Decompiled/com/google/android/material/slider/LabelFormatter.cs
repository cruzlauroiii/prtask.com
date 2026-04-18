namespace WillowMaze.Wasm.Decompiled;


public interface LabelFormatter {
    public static readonly int LABEL_FLOATING = 0;
    public static readonly int LABEL_GONE = 2;
    public static readonly int LABEL_VISIBLE = 3;
    public static readonly int LABEL_WITHIN_BOUNDS = 1;

    java.lang.string getFormattedValue(float f);
}

