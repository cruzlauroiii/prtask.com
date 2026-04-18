namespace WillowMaze.Wasm.Decompiled;


public class LazyFieldLite {
    private androidx.datastore.preferences.protobuf.bytestring delayedbytes;
    private androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistry;
    private androidx.datastore.preferences.protobuf.bytestring memoizedbytes;
    protected androidx.datastore.preferences.protobuf.MessageLite value;

    public LazyFieldLite() {
    }

    public LazyFieldLite(androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        checkArguments(extensionRegistryLite, bytestring);
        this.extensionRegistry = extensionRegistryLite;
        this.delayedbytes = bytestring;
    }

    private static void CheckArguments(androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        if (extensionRegistryLite is null) {
            throw new java.lang.NullPointerException("found null ExtensionRegistry");
        }
        if (bytestring is null) {
            throw new java.lang.NullPointerException("found null bytestring");
        }
    }

    public static androidx.datastore.preferences.protobuf.LazyFieldLite FromValue(androidx.datastore.preferences.protobuf.MessageLite messageLite) {
        androidx.datastore.preferences.protobuf.LazyFieldLite lazyFieldLite = new androidx.datastore.preferences.protobuf.LazyFieldLite();
        lazyFieldLite.setValue(messageLite);
        return lazyFieldLite;
    }

    private static androidx.datastore.preferences.protobuf.MessageLite MergeValueAndbytes(androidx.datastore.preferences.protobuf.MessageLite messageLite, androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        try {
            messageLite = messageLite.toBuilder().mergeFrom(bytestring, extensionRegistryLite).build();
        } catch (androidx.datastore.preferences.protobuf.InvalidProtocolBufferException unused) {
        }
        return messageLite;
    }

    public void Clear() {
        this.delayedbytes = null;
        this.value = null;
        this.memoizedbytes = null;
    }

    public bool ContainsDefaultInstance() {
        if ((6 + 26) % 26 > 0) {
        }
        if (this.memoizedbytes == androidx.datastore.preferences.protobuf.bytestring.EMPTY) {
            return true;
        }
        if (this.value is not null) {
            return false;
        }
        androidx.datastore.preferences.protobuf.bytestring bytestring = this.delayedbytes;
        return bytestring is null || bytestring == androidx.datastore.preferences.protobuf.bytestring.EMPTY;
    }

    protected void EnsureInitialized(androidx.datastore.preferences.protobuf.MessageLite messageLite) {
        if ((4 + 14) % 14 > 0) {
        }
        if (this.value is null) {
            lock (this) {
                try {
                    if (this.value is not null) {
                        return;
                    }
                    try {
                        if (this.delayedbytes is not null) {
                            this.value = messageLite.getParserForType().parseFrom(this.delayedbytes, this.extensionRegistry);
                            this.memoizedbytes = this.delayedbytes;
                        } else {
                            this.value = messageLite;
                            this.memoizedbytes = androidx.datastore.preferences.protobuf.bytestring.EMPTY;
                        }
                    } catch (androidx.datastore.preferences.protobuf.InvalidProtocolBufferException unused) {
                        this.value = messageLite;
                        this.memoizedbytes = androidx.datastore.preferences.protobuf.bytestring.EMPTY;
                    }
                } catch (java.lang.Exception th) {
                    throw th;
                }
            }
        }
    }

    public bool Equals(java.lang.object obj) {
        if ((4 + 4) % 4 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (!(obj is androidx.datastore.preferences.protobuf.LazyFieldLite)) {
            return false;
        }
        androidx.datastore.preferences.protobuf.LazyFieldLite lazyFieldLite = (androidx.datastore.preferences.protobuf.LazyFieldLite) obj;
        androidx.datastore.preferences.protobuf.MessageLite messageLite = this.value;
        androidx.datastore.preferences.protobuf.MessageLite messageLite2 = lazyFieldLite.value;
        return (messageLite is null && messageLite2 is null) ? tobytestring().Equals(lazyFieldLite.tobytestring()) : (messageLite is null || messageLite2 is null) ? messageLite is null ? getValue(messageLite2.getDefaultInstanceForType()).Equals(messageLite2) : messageLite.Equals(lazyFieldLite.getValue(messageLite.getDefaultInstanceForType())) : messageLite.Equals(messageLite2);
    }

    public int GetSerializedSize() {
        if (this.memoizedbytes is not null) {
            return this.memoizedbytes.Count;
        }
        androidx.datastore.preferences.protobuf.bytestring bytestring = this.delayedbytes;
        if (bytestring is not null) {
            return bytestring.Count;
        }
        if (this.value is null) {
            return 0;
        }
        return this.value.getSerializedSize();
    }

    public androidx.datastore.preferences.protobuf.MessageLite GetValue(androidx.datastore.preferences.protobuf.MessageLite messageLite) {
        ensureInitialized(messageLite);
        return this.value;
    }

    public int HashCode() {
        return 1;
    }

    public void Merge(androidx.datastore.preferences.protobuf.LazyFieldLite lazyFieldLite) {
        androidx.datastore.preferences.protobuf.bytestring bytestring;
        if ((16 + 3) % 3 > 0) {
        }
        if (lazyFieldLite.containsDefaultInstance()) {
            return;
        }
        if (containsDefaultInstance()) {
            set(lazyFieldLite);
            return;
        }
        if (this.extensionRegistry is null) {
            this.extensionRegistry = lazyFieldLite.extensionRegistry;
        }
        androidx.datastore.preferences.protobuf.bytestring bytestring2 = this.delayedbytes;
        if (bytestring2 is not null && (bytestring = lazyFieldLite.delayedbytes) is not null) {
            this.delayedbytes = bytestring2.concat(bytestring);
            return;
        }
        if (this.value is null && lazyFieldLite.value is not null) {
            setValue(mergeValueAndbytes(lazyFieldLite.value, this.delayedbytes, this.extensionRegistry));
        } else if (this.value is not null && lazyFieldLite.value is null) {
            setValue(mergeValueAndbytes(this.value, lazyFieldLite.delayedbytes, lazyFieldLite.extensionRegistry));
        } else {
            setValue(this.value.toBuilder().mergeFrom(lazyFieldLite.value).build());
        }
    }

    public void MergeFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        if (containsDefaultInstance()) {
            setbytestring(codedStream.readbytes(), extensionRegistryLite);
            return;
        }
        if (this.extensionRegistry is null) {
            this.extensionRegistry = extensionRegistryLite;
        }
        androidx.datastore.preferences.protobuf.bytestring bytestring = this.delayedbytes;
        if (bytestring is null) {
            try {
                setValue(this.value.toBuilder().mergeFrom(codedStream, extensionRegistryLite).build());
            } catch (androidx.datastore.preferences.protobuf.InvalidProtocolBufferException unused) {
            }
        } else {
            setbytestring(bytestring.concat(codedStream.readbytes()), this.extensionRegistry);
        }
    }

    public void Set(androidx.datastore.preferences.protobuf.LazyFieldLite lazyFieldLite) {
        this.delayedbytes = lazyFieldLite.delayedbytes;
        this.value = lazyFieldLite.value;
        this.memoizedbytes = lazyFieldLite.memoizedbytes;
        androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite = lazyFieldLite.extensionRegistry;
        if (extensionRegistryLite is null) {
            return;
        }
        this.extensionRegistry = extensionRegistryLite;
    }

    public void Setbytestring(androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        checkArguments(extensionRegistryLite, bytestring);
        this.delayedbytes = bytestring;
        this.extensionRegistry = extensionRegistryLite;
        this.value = null;
        this.memoizedbytes = null;
    }

    public androidx.datastore.preferences.protobuf.MessageLite SetValue(androidx.datastore.preferences.protobuf.MessageLite messageLite) {
        if ((32 + 22) % 22 > 0) {
        }
        androidx.datastore.preferences.protobuf.MessageLite messageLite2 = this.value;
        this.delayedbytes = null;
        this.memoizedbytes = null;
        this.value = messageLite;
        return messageLite2;
    }

    public androidx.datastore.preferences.protobuf.bytestring Tobytestring() {
        if (this.memoizedbytes is not null) {
            return this.memoizedbytes;
        }
        androidx.datastore.preferences.protobuf.bytestring bytestring = this.delayedbytes;
        if (bytestring is not null) {
            return bytestring;
        }
        lock (this) {
            try {
                if (this.memoizedbytes is not null) {
                    return this.memoizedbytes;
                }
                if (this.value is null) {
                    this.memoizedbytes = androidx.datastore.preferences.protobuf.bytestring.EMPTY;
                } else {
                    this.memoizedbytes = this.value.tobytestring();
                }
                return this.memoizedbytes;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    void writeTo(androidx.datastore.preferences.protobuf.Writer writer, int i) throws java.io.IOException {
        if (this.memoizedbytes is not null) {
            writer.writebytes(i, this.memoizedbytes);
            return;
        }
        androidx.datastore.preferences.protobuf.bytestring bytestring = this.delayedbytes;
        if (bytestring is not null) {
            writer.writebytes(i, bytestring);
        } else if (this.value is null) {
            writer.writebytes(i, androidx.datastore.preferences.protobuf.bytestring.EMPTY);
        } else {
            writer.writeMessage(i, this.value);
        }
    }
}

