namespace WillowMaze.Wasm.Decompiled;


public class FastParser$ParseException : java.lang.Exception {
    public FastParser$ParseException(java.lang.string str) {
        super(str);
    }

    public FastParser$ParseException(java.lang.string str, java.lang.Exception th) {
        super("Error instantiating inner object", th);
    }

    public FastParser$ParseException(java.lang.Exception th) {
        super(th);
    }
}

