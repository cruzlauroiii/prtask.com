namespace WillowMaze.Wasm.Decompiled;


class DescriptorProtos$FieldOptions$1 : androidx.datastore.preferences.protobuf.Internal$IntListAdapter$IntConverter<androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionTargetType> {
    DescriptorProtos$FieldOptions$1() {
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionTargetType convert(int i) {
        androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionTargetType descriptorProtos$FieldOptions$OptionTargetTypeForNumber = androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionTargetType.forNumber(i);
        return descriptorProtos$FieldOptions$OptionTargetTypeForNumber is not null ? descriptorProtos$FieldOptions$OptionTargetTypeForNumber : androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionTargetType.TARGET_TYPE_UNKNOWN;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionTargetType convert(int i) {
        return convert(i);
    }
}

