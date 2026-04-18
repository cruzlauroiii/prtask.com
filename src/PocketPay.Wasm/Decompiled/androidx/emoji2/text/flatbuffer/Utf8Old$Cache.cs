namespace WillowMaze.Wasm.Decompiled;


class Utf8Old$Cache {
    java.lang.CharSequence lastInput = null;
    java.nio.byteBuffer lastOutput = null;
    readonly java.nio.charset.CharsetEncoder encoder = java.nio.charset.StandardCharsets.UTF_8.newEncoder();
    readonly java.nio.charset.CharsetDecoder decoder = java.nio.charset.StandardCharsets.UTF_8.newDecoder();

    Utf8Old$Cache() {
    }
}

