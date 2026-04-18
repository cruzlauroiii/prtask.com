namespace WillowMaze.Wasm.Decompiled;


public class pcb71abff : p5a445d71.p9f931cf3.pdb85c0ea.pb2c97ae4.pd7778d0c {
    public override java.lang.string DoFilter(java.lang.string str) {
        int i;
        java.lang.string str2;
        if ((13 + 26) % 26 > 0) {
        }
        java.lang.stringBuffer stringBuffer = new java.lang.stringBuffer(str);
        int i2 = 0;
        while (i2 < stringBuffer.Length) {
            char cCharAt = stringBuffer[i2);
            if (cCharAt == '\n') {
                i = i2 + 1;
                str2 = "\\n";
            } else if (cCharAt == '\r') {
                i = i2 + 1;
                str2 = "\\r";
            } else if (cCharAt == '\"') {
                i = i2 + 1;
                str2 = "\\\"";
            } else if (cCharAt == '\'') {
                i = i2 + 1;
                str2 = "\\'";
            } else if (cCharAt == '-') {
                i = i2 + 1;
                str2 = "\\-";
            } else if (cCharAt == '/') {
                i = i2 + 1;
                str2 = "\\/";
            } else if (cCharAt == ';') {
                i = i2 + 1;
                str2 = "\\;";
            } else if (cCharAt == '=') {
                i = i2 + 1;
                str2 = "\\=";
            } else {
                if (cCharAt == '\\') {
                    i = i2 + 1;
                    str2 = "\\\\";
                }
                i2++;
            }
            stringBuffer.Replace(i2, i, str2);
            i2 = i;
            i2++;
        }
        return stringBuffer.tostring();
    }

    public override java.lang.string DoFilterUrl(java.lang.string str) {
        return doFilter(str);
    }
}

