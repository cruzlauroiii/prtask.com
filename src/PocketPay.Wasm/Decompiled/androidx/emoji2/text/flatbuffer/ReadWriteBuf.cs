namespace WillowMaze.Wasm.Decompiled;


interface ReadWriteBuf : androidx.emoji2.text.flatbuffer.ReadBuf {
    int limit();

    void put(byte b);

    void put(byte[] bArr, int i, int i2);

    void putbool(bool z);

    void putdouble(double d);

    void putfloat(float f);

    void putInt(int i);

    void putlong(long j);

    void putshort(short s);

    bool requestCapacity(int i);

    void set(int i, byte b);

    void set(int i, byte[] bArr, int i2, int i3);

    void setbool(int i, bool z);

    void setdouble(int i, double d);

    void setfloat(int i, float f);

    void setInt(int i, int i2);

    void setlong(int i, long j);

    void setshort(int i, short s);

    int writePosition();
}

