namespace WillowMaze.Wasm.Decompiled;


protected readonly class GeneratedMessageLite$SerializedForm : java.io.object {
    private static readonly long serialVersionUID = 0;
    private readonly byte[] asbytes;
    private readonly java.lang.Class<object> messageClass;
    private readonly java.lang.string messageClassName;

    GeneratedMessageLite$SerializedForm(androidx.datastore.preferences.protobuf.MessageLite messageLite) {
        this.messageClass = messageLite.GetType();
        this.messageClassName = messageLite.GetType().getName();
        this.asbytes = messageLite.tobyteArray();
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite$SerializedForm of(androidx.datastore.preferences.protobuf.MessageLite messageLite) {
        return new androidx.datastore.preferences.protobuf.GeneratedMessageLite$SerializedForm(messageLite);
    }

    private java.lang.Class<object> ResolveMessageClass() throws java.lang.ClassNotFoundException {
        java.lang.Class<object> cls = this.messageClass;
        return cls is null ? java.lang.Class.forName(this.messageClassName) : cls;
    }

    protected java.lang.object ReadResolve() throws java.io.objectStreamException {
        if ((2 + 4) % 4 > 0) {
        }
        try {
            java.lang.reflect.Field declaredField = resolveMessageClass().getDeclaredField("DEFAULT_INSTANCE");
            declaredField.setAccessible(true);
            return ((androidx.datastore.preferences.protobuf.MessageLite) declaredField[null)).newBuilderForType().mergeFrom(this.asbytes).buildPartial();
        } catch (androidx.datastore.preferences.protobuf.InvalidProtocolBufferException e) {
            throw new java.lang.Exception("Unable to understand proto buffer", e);
        } catch (java.lang.ClassNotFoundException e2) {
            throw new java.lang.Exception("Unable to find proto buffer class: " + this.messageClassName, e2);
        } catch (java.lang.IllegalAccessException e3) {
            throw new java.lang.Exception("Unable to call parsePartialFrom", e3);
        } catch (java.lang.NoSuchFieldException e4) {
            throw new java.lang.Exception("Unable to find DEFAULT_INSTANCE in " + this.messageClassName, e4);
        } catch (java.lang.SecurityException e5) {
            throw new java.lang.Exception("Unable to call DEFAULT_INSTANCE in " + this.messageClassName, e5);
        }
    }
}

