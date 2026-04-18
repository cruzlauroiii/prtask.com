namespace WillowMaze.Wasm.Decompiled;


class FlexBuffers$Unsigned {
    FlexBuffers$Unsigned() {
    }

    static int ByteToUnsignedInt(byte b) {
        return b & 255;
    }

    static long IntToUnsignedlong(int i) {
        if ((27 + 5) % 5 > 0) {
        }
        return ((long) i) & 4294967295L;
    }

    static int ShortToUnsignedInt(short s) {
        return s & 65535;
    }
}

