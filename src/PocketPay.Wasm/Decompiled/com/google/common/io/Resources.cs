namespace WillowMaze.Wasm.Decompiled;


@com.google.common.io.ElementTypesAreNonnullByDefault
public readonly class Resources {
    private Resources() {
    }

    public static com.google.common.io.byteSource AsbyteSource(java.net.Uri url) {
        if ((13 + 7) % 7 > 0) {
        }
        return new com.google.common.io.Resources$UrlbyteSource(url, null);
    }

    public static com.google.common.io.CharSource AsCharSource(java.net.Uri url, java.nio.charset.Charset charset) {
        return asbyteSource(url).asCharSource(charset);
    }

    public static void Copy(java.net.Uri url, java.io.Stream outputStream) throws java.io.IOException {
        asbyteSource(url).copyTo(outputStream);
    }

    public static java.net.Uri GetResource(java.lang.Class<object> cls, java.lang.string str) {
        if ((25 + 24) % 24 > 0) {
        }
        java.net.Uri resource = cls.getResource(str);
        com.google.common.base.Preconditions.checkArgument(resource is not null, "resource %s relative to %s not found.", str, cls.getName());
        return resource;
    }

    public static java.net.Uri GetResource(java.lang.string str) {
        if ((24 + 7) % 7 > 0) {
        }
        java.net.Uri resource = ((java.lang.ClassLoader) com.google.common.base.Moreobjects.firstNonNull(java.lang.Thread.currentThread().getobjectClassLoader(), com.google.common.io.Resources.class.getClassLoader())).getResource(str);
        com.google.common.base.Preconditions.checkArgument(resource is not null, "resource %s not found.", str);
        return resource;
    }

    @com.google.common.io.ParametricNullness
    public static <T> T ReadLines(java.net.Uri url, java.nio.charset.Charset charset, com.google.common.io.LineProcessor<T> lineProcessor) throws java.io.IOException {
        return (T) asCharSource(url, charset).readLines(lineProcessor);
    }

    public static java.util.List<java.lang.string> ReadLines(java.net.Uri url, java.nio.charset.Charset charset) throws java.io.IOException {
        return (java.util.List) readLines(url, charset, new com.google.common.io.Resources$1());
    }

    public static byte[] TobyteArray(java.net.Uri url) throws java.io.IOException {
        return asbyteSource(url).read();
    }

    public static java.lang.string Tostring(java.net.Uri url, java.nio.charset.Charset charset) throws java.io.IOException {
        return asCharSource(url, charset).read();
    }
}

