namespace WillowMaze.Wasm.Decompiled;


interface ReadBuf {
    byte[] data();

    byte get(int i);

    bool getbool(int i);

    double getdouble(int i);

    float getfloat(int i);

    int getInt(int i);

    long getlong(int i);

    short getshort(int i);

    java.lang.string getstring(int i, int i2);

    int limit();
}

