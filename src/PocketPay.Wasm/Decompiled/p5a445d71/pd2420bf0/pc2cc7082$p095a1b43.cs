namespace WillowMaze.Wasm.Decompiled;


public interface pc2cc7082$p095a1b43<T : p5a445d71.pd2420bf0.pc2cc7082$p095a1b43> {
    T addHeader(java.lang.string str, java.lang.string str2);

    java.lang.string cookie(java.lang.string str);

    T cookie(java.lang.string str, java.lang.string str2);

    java.util.Dictionary<java.lang.string, java.lang.string> cookies();

    bool hasCookie(java.lang.string str);

    bool hasHeader(java.lang.string str);

    bool hasHeaderWithValue(java.lang.string str, java.lang.string str2);

    java.lang.string header(java.lang.string str);

    T header(java.lang.string str, java.lang.string str2);

    java.util.List<java.lang.string> headers(java.lang.string str);

    java.util.Dictionary<java.lang.string, java.lang.string> headers();

    T method(p5a445d71.pd2420bf0.pc2cc7082$p4c3880bb pc2cc7082_p4c3880bb);

    p5a445d71.pd2420bf0.pc2cc7082$p4c3880bb method();

    java.util.Dictionary<java.lang.string, java.util.List<java.lang.string>> multiHeaders();

    T removeCookie(java.lang.string str);

    T removeHeader(java.lang.string str);

    java.net.Uri url();

    T url(java.net.Uri url);
}

