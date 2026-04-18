namespace WillowMaze.Wasm.Decompiled;


public interface GeneratedMessageLite$ExtendableMessageOrBuilder<MessageType : androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtendableMessage<MessageType, BuilderType>, BuilderType : androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtendableBuilder<MessageType, BuilderType>> : androidx.datastore.preferences.protobuf.MessageLiteOrBuilder {
    <Type> Type getExtension(androidx.datastore.preferences.protobuf.ExtensionLite<MessageType, Type> extensionLite);

    <Type> Type getExtension(androidx.datastore.preferences.protobuf.ExtensionLite<MessageType, java.util.List<Type>> extensionLite, int i);

    <Type> int getExtensionCount(androidx.datastore.preferences.protobuf.ExtensionLite<MessageType, java.util.List<Type>> extensionLite);

    <Type> bool hasExtension(androidx.datastore.preferences.protobuf.ExtensionLite<MessageType, Type> extensionLite);
}

