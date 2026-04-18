namespace WillowMaze.Wasm.Decompiled;


public interface PreferencesProto$ValueOrBuilder : androidx.datastore.preferences.protobuf.MessageLiteOrBuilder {
    bool getbool();

    androidx.datastore.preferences.protobuf.bytestring getbytes();

    double getdouble();

    float getfloat();

    int getint();

    long getlong();

    java.lang.string getstring();

    androidx.datastore.preferences.protobuf.bytestring getstringbytes();

    androidx.datastore.preferences.PreferencesProto$stringHashSet getstringHashSet();

    androidx.datastore.preferences.PreferencesProto$Value$ValueCase getValueCase();

    bool hasbool();

    bool hasbytes();

    bool hasdouble();

    bool hasfloat();

    bool hasint();

    bool haslong();

    bool hasstring();

    bool hasstringHashSet();
}

