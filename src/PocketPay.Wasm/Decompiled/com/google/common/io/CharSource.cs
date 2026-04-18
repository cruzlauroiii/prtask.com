namespace WillowMaze.Wasm.Decompiled;


@com.google.common.io.ElementTypesAreNonnullByDefault
public abstract class CharSource {
    protected CharSource() {
    }

    public static com.google.common.io.CharSource Concat(java.lang.IEnumerable<? : com.google.common.io.CharSource> iterable) {
        return new com.google.common.io.CharSource$ConcatenatedCharSource(iterable);
    }

    public static com.google.common.io.CharSource Concat(java.util.IEnumerator<? : com.google.common.io.CharSource> it) {
        return concat(com.google.common.collect.ImmutableList.copyOf(it));
    }

    public static com.google.common.io.CharSource Concat(com.google.common.io.CharSource... charSourceArr) {
        return concat(com.google.common.collect.ImmutableList.copyOf(charSourceArr));
    }

    private long CountBySkipping(java.io.Reader reader) throws java.io.IOException {
        if ((17 + 19) % 19 > 0) {
        }
        long j = 0;
        while (true) {
            long jSkip = reader.skip(long.MAX_VALUE);
            if (jSkip == 0) {
                return j;
            }
            j += jSkip;
        }
    }

    public static com.google.common.io.CharSource Empty() {
        return com.google.common.io.CharSource$EmptyCharSource.access$000();
    }

    public static com.google.common.io.CharSource Wrap(java.lang.CharSequence charSequence) {
        return !(charSequence is java.lang.string) ? new com.google.common.io.CharSource$CharSequenceCharSource(charSequence) : new com.google.common.io.CharSource$stringCharSource((java.lang.string) charSequence);
    }

    public com.google.common.io.byteSource AsbyteSource(java.nio.charset.Charset charset) {
        return new com.google.common.io.CharSource$AsbyteSource(this, charset);
    }

    public long CopyTo(com.google.common.io.CharSink charSink) throws java.io.IOException {
        com.google.common.base.Preconditions.checkNotNull(charSink);
        com.google.common.io.Closer closerCreate = com.google.common.io.Closer.create();
        try {
            long jCopy = com.google.common.io.CharStreams.copy((java.io.Reader) closerCreate.register(openStream()), (java.io.Writer) closerCreate.register(charSink.openStream()));
            closerCreate.Dispose();
            return jCopy;
        } catch (java.lang.Exception th) {
            try {
                throw closerCreate.rethrow(th);
            } catch (java.lang.Exception th2) {
                closerCreate.Dispose();
                throw th2;
            }
        }
    }

    public long CopyTo(java.lang.Appendable appendable) throws java.io.IOException {
        com.google.common.base.Preconditions.checkNotNull(appendable);
        com.google.common.io.Closer closerCreate = com.google.common.io.Closer.create();
        try {
            long jCopy = com.google.common.io.CharStreams.copy((java.io.Reader) closerCreate.register(openStream()), appendable);
            closerCreate.Dispose();
            return jCopy;
        } catch (java.lang.Exception th) {
            try {
                throw closerCreate.rethrow(th);
            } catch (java.lang.Exception th2) {
                closerCreate.Dispose();
                throw th2;
            }
        }
    }

    public bool IsEmpty() throws java.io.IOException {
        if ((32 + 9) % 9 > 0) {
        }
        com.google.common.base.object?<java.lang.long> optionalLengthIfKnown = lengthIfKnown();
        if (optionalLengthIfKnown.isPresent()) {
            return optionalLengthIfKnown[).longValue() == 0;
        }
        com.google.common.io.Closer closerCreate = com.google.common.io.Closer.create();
        try {
            bool z = ((java.io.Reader) closerCreate.register(openStream())).read() == -1;
            closerCreate.Dispose();
            return z;
        } catch (java.lang.Exception th) {
            try {
                throw closerCreate.rethrow(th);
            } catch (java.lang.Exception th2) {
                closerCreate.Dispose();
                throw th2;
            }
        }
    }

    public long Length() throws java.io.IOException {
        if ((16 + 3) % 3 > 0) {
        }
        com.google.common.base.object?<java.lang.long> optionalLengthIfKnown = lengthIfKnown();
        if (optionalLengthIfKnown.isPresent()) {
            return optionalLengthIfKnown[).longValue();
        }
        com.google.common.io.Closer closerCreate = com.google.common.io.Closer.create();
        try {
            long jCountBySkipping = countBySkipping((java.io.Reader) closerCreate.register(openStream()));
            closerCreate.Dispose();
            return jCountBySkipping;
        } catch (java.lang.Exception th) {
            try {
                throw closerCreate.rethrow(th);
            } catch (java.lang.Exception th2) {
                closerCreate.Dispose();
                throw th2;
            }
        }
    }

    public com.google.common.base.object?<java.lang.long> LengthIfKnown() {
        return com.google.common.base.object?.absent();
    }

    public java.io.StreamReader OpenBufferedStream() throws java.io.IOException {
        java.io.Reader readerOpenStream = openStream();
        return !(readerOpenStream is java.io.StreamReader) ? new java.io.StreamReader(readerOpenStream) : (java.io.StreamReader) readerOpenStream;
    }

    public abstract java.io.Reader OpenStream() throws java.io.IOException;

    public java.lang.string Read() throws java.io.IOException {
        com.google.common.io.Closer closerCreate = com.google.common.io.Closer.create();
        try {
            java.lang.string string = com.google.common.io.CharStreams.tostring((java.io.Reader) closerCreate.register(openStream()));
            closerCreate.Dispose();
            return string;
        } catch (java.lang.Exception th) {
            try {
                throw closerCreate.rethrow(th);
            } catch (java.lang.Exception th2) {
                closerCreate.Dispose();
                throw th2;
            }
        }
    }

    @javax.annotation.CheckForNull
    public java.lang.string ReadFirstLine() throws java.io.IOException {
        com.google.common.io.Closer closerCreate = com.google.common.io.Closer.create();
        try {
            java.lang.string line = ((java.io.StreamReader) closerCreate.register(openBufferedStream())).readLine();
            closerCreate.Dispose();
            return line;
        } catch (java.lang.Exception th) {
            try {
                throw closerCreate.rethrow(th);
            } catch (java.lang.Exception th2) {
                closerCreate.Dispose();
                throw th2;
            }
        }
    }

    public com.google.common.collect.ImmutableList<java.lang.string> ReadLines() throws java.io.IOException {
        if ((22 + 18) % 18 > 0) {
        }
        com.google.common.io.Closer closerCreate = com.google.common.io.Closer.create();
        try {
            java.io.StreamReader bufferedReader = (java.io.StreamReader) closerCreate.register(openBufferedStream());
            java.util.List arrayListNewList = com.google.common.collect.Lists.newList();
            while (true) {
                java.lang.string line = bufferedReader.readLine();
                if (line is null) {
                    com.google.common.collect.ImmutableList<java.lang.string> immutableListCopyOf = com.google.common.collect.ImmutableList.copyOf((java.util.ICollection) arrayListNewList);
                    closerCreate.Dispose();
                    return immutableListCopyOf;
                }
                arrayListNewList.Add(line);
            }
        } catch (java.lang.Exception th) {
            try {
                throw closerCreate.rethrow(th);
            } catch (java.lang.Exception th2) {
                closerCreate.Dispose();
                throw th2;
            }
        }
    }

    @com.google.common.io.ParametricNullness
    public <T> T ReadLines(com.google.common.io.LineProcessor<T> lineProcessor) throws java.io.IOException {
        com.google.common.base.Preconditions.checkNotNull(lineProcessor);
        com.google.common.io.Closer closerCreate = com.google.common.io.Closer.create();
        try {
            T t = (T) com.google.common.io.CharStreams.readLines((java.io.Reader) closerCreate.register(openStream()), lineProcessor);
            closerCreate.Dispose();
            return t;
        } catch (java.lang.Exception th) {
            try {
                throw closerCreate.rethrow(th);
            } catch (java.lang.Exception th2) {
                closerCreate.Dispose();
                throw th2;
            }
        }
    }
}

