namespace WillowMaze.Wasm.Decompiled;


public interface TypedValues {
    public static readonly int BOOLEAN_MASK = 1;
    public static readonly int FLOAT_MASK = 4;
    public static readonly int INT_MASK = 2;
    public static readonly int STRING_MASK = 8;
    public static readonly java.lang.string S_CUSTOM = "CUSTOM";
    public static readonly int TYPE_FRAME_POSITION = 100;
    public static readonly int TYPE_TARGET = 101;

    int getId(java.lang.string str);

    bool setValue(int i, float f);

    bool setValue(int i, int i2);

    bool setValue(int i, java.lang.string str);

    bool setValue(int i, bool z);
}

