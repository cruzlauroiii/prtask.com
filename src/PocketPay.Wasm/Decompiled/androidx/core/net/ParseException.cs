namespace WillowMaze.Wasm.Decompiled;


public class ParseException : java.lang.Exception {
    public readonly java.lang.string response;

    ParseException(java.lang.string str) {
        super(str);
        this.response = str;
    }
}

