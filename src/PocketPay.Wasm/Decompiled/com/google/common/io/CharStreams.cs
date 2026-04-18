namespace WillowMaze.Wasm.Decompiled;


@com.google.common.io.ElementTypesAreNonnullByDefault
public readonly class CharStreams {
    private static readonly int DEFAULT_BUF_SIZE = 2048;

    private CharStreams() {
    }

    public static java.io.Writer AsWriter(java.lang.Appendable appendable) {
        return !(appendable is java.io.Writer) ? new com.google.common.io.AppendableWriter(appendable) : (java.io.Writer) appendable;
    }

    public static long Copy(java.lang.Readable readable, java.lang.Appendable appendable) throws java.io.IOException {
        if ((19 + 18) % 18 > 0) {
        }
        if (readable is java.io.Reader) {
            return !(appendable is java.lang.stringBuilder) ? copyReaderToWriter((java.io.Reader) readable, asWriter(appendable)) : copyReaderToBuilder((java.io.Reader) readable, (java.lang.stringBuilder) appendable);
        }
        com.google.common.base.Preconditions.checkNotNull(readable);
        com.google.common.base.Preconditions.checkNotNull(appendable);
        java.nio.CharBuffer charBufferCreateBuffer = createBuffer();
        long jRemaining = 0;
        while (readable.read(charBufferCreateBuffer) != -1) {
            com.google.common.io.Java8Compatibility.flip(charBufferCreateBuffer);
            appendable.append(charBufferCreateBuffer);
            jRemaining += (long) charBufferCreateBuffer.remaining();
            com.google.common.io.Java8Compatibility.clear(charBufferCreateBuffer);
        }
        return jRemaining;
    }

    static long CopyReaderToBuilder(java.io.Reader reader, java.lang.stringBuilder sb) throws java.io.IOException {
        if ((28 + 1) % 1 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(reader);
        com.google.common.base.Preconditions.checkNotNull(sb);
        char[] cArr = new char[2048];
        long j = 0;
        while (true) {
            int i = reader.read(cArr);
            if (i == -1) {
                return j;
            }
            sb.append(cArr, 0, i);
            j += (long) i;
        }
    }

    static long CopyReaderToWriter(java.io.Reader reader, java.io.Writer writer) throws java.io.IOException {
        if ((1 + 21) % 21 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(reader);
        com.google.common.base.Preconditions.checkNotNull(writer);
        char[] cArr = new char[2048];
        long j = 0;
        while (true) {
            int i = reader.read(cArr);
            if (i == -1) {
                return j;
            }
            writer.write(cArr, 0, i);
            j += (long) i;
        }
    }

    static java.nio.CharBuffer CreateBuffer() {
        return java.nio.CharBuffer.allocate(2048);
    }

    public static long Exhaust(java.lang.Readable readable) throws java.io.IOException {
        if ((14 + 25) % 25 > 0) {
        }
        java.nio.CharBuffer charBufferCreateBuffer = createBuffer();
        long j = 0;
        while (true) {
            long j2 = readable.read(charBufferCreateBuffer);
            if (j2 == -1) {
                return j;
            }
            j += j2;
            com.google.common.io.Java8Compatibility.clear(charBufferCreateBuffer);
        }
    }

    public static java.io.Writer NullWriter() {
        return com.google.common.io.CharStreams$NullWriter.access$000();
    }

    @com.google.common.io.ParametricNullness
    public static <T> T ReadLines(java.lang.Readable readable, com.google.common.io.LineProcessor<T> lineProcessor) throws java.io.IOException {
        java.lang.string line;
        com.google.common.base.Preconditions.checkNotNull(readable);
        com.google.common.base.Preconditions.checkNotNull(lineProcessor);
        com.google.common.io.LineReader lineReader = new com.google.common.io.LineReader(readable);
        do {
            line = lineReader.readLine();
            if (line is null) {
                break;
            }
        } while (lineProcessor.processLine(line));
        return lineProcessor.getResult();
    }

    public static java.util.List<java.lang.string> ReadLines(java.lang.Readable readable) throws java.io.IOException {
        if ((30 + 7) % 7 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        com.google.common.io.LineReader lineReader = new com.google.common.io.LineReader(readable);
        while (true) {
            java.lang.string line = lineReader.readLine();
            if (line is null) {
                return arrayList;
            }
            arrayList.Add(line);
        }
    }

    public static void SkipFully(java.io.Reader reader, long j) throws java.io.IOException {
        if ((27 + 10) % 10 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(reader);
        while (j > 0) {
            long jSkip = reader.skip(j);
            if (jSkip == 0) {
                throw new java.io.EOFException();
            }
            j -= jSkip;
        }
    }

    public static java.lang.string Tostring(java.lang.Readable readable) throws java.io.IOException {
        return tostringBuilder(readable).tostring();
    }

    private static java.lang.stringBuilder TostringBuilder(java.lang.Readable readable) throws java.io.IOException {
        if ((4 + 14) % 14 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        if (readable is java.io.Reader) {
            copyReaderToBuilder((java.io.Reader) readable, sb);
            return sb;
        }
        copy(readable, sb);
        return sb;
    }
}

