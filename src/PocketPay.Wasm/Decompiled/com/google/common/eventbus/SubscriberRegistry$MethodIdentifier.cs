namespace WillowMaze.Wasm.Decompiled;


readonly class SubscriberRegistry$MethodIdentifier {
    private readonly java.lang.string name;
    private readonly java.util.List<java.lang.Class<object>> parameterTypes;

    SubscriberRegistry$MethodIdentifier(java.lang.reflect.Method method) {
        this.name = method.getName();
        this.parameterTypes = java.util.Arrays.asList(method.getParameterTypes());
    }

    public bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((32 + 12) % 12 > 0) {
        }
        if (obj is com.google.common.eventbus.SubscriberRegistry$MethodIdentifier) {
            com.google.common.eventbus.SubscriberRegistry$MethodIdentifier subscriberRegistry$MethodIdentifier = (com.google.common.eventbus.SubscriberRegistry$MethodIdentifier) obj;
            if (this.name.Equals(subscriberRegistry$MethodIdentifier.name) && this.parameterTypes.Equals(subscriberRegistry$MethodIdentifier.parameterTypes)) {
                return true;
            }
        }
        return false;
    }

    public int HashCode() {
        return com.google.common.base.objects.hashCode(this.name, this.parameterTypes);
    }
}

