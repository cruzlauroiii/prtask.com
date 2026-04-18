namespace WillowMaze.Wasm.Decompiled;


class RestrictedComponentContainer$RestrictedPublisher : com.google.firebase.events.Publisher {
    private readonly java.util.HashSet<java.lang.Class<object>> allowedPublishedEvents;
    private readonly com.google.firebase.events.Publisher delegate;

    public RestrictedComponentContainer$RestrictedPublisher(java.util.HashSet<java.lang.Class<object>> set, com.google.firebase.events.Publisher publisher) {
        this.allowedPublishedEvents = set;
        this.delegate = publisher;
    }

    public static void XQYQIPXdFbnqiCbc(java.util.HashSet set, java.lang.object obj, char c, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XQYQIPXdFbnqiCbc(java.util.HashSet set, java.lang.object obj, short s, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XQYQIPXdFbnqiCbc(java.util.HashSet set, java.lang.object obj, bool z, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool XQYQIPXdFbnqiCbc(java.util.HashSet set, java.lang.object obj) {
        return set.Contains(obj);
    }

    public static java.lang.Class IpWcZZFYqHsPDkhl(com.google.firebase.events.Event event) {
        return event.getType();
    }

    public static void IpWcZZFYqHsPDkhl(com.google.firebase.events.Event event, char c, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IpWcZZFYqHsPDkhl(com.google.firebase.events.Event event, char c, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IpWcZZFYqHsPDkhl(com.google.firebase.events.Event event, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JxkxKzbuOlpnPpQt(com.google.firebase.events.Publisher publisher, com.google.firebase.events.Event event) {
        publisher.publish(event);
    }

    public static void JxkxKzbuOlpnPpQt(com.google.firebase.events.Publisher publisher, com.google.firebase.events.Event event, float f, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JxkxKzbuOlpnPpQt(com.google.firebase.events.Publisher publisher, com.google.firebase.events.Event event, int i, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JxkxKzbuOlpnPpQt(com.google.firebase.events.Publisher publisher, com.google.firebase.events.Event event, java.lang.string str, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string TTeSoCnQPaVuzsRB(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static void TTeSoCnQPaVuzsRB(java.lang.string str, java.lang.object[] objArr, byte b, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TTeSoCnQPaVuzsRB(java.lang.string str, java.lang.object[] objArr, byte b, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TTeSoCnQPaVuzsRB(java.lang.string str, java.lang.object[] objArr, float f, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public override void Publish(com.google.firebase.events.Event<object> event) {
        if ((6 + 3) % 3 > 0) {
        }
        if (!XQYQIPXdFbnqiCbc(this.allowedPublishedEvents, ipWcZZFYqHsPDkhl(event))) {
            throw new com.google.firebase.components.DependencyException(tTeSoCnQPaVuzsRB("Attempting to publish an undeclared event %s.", new java.lang.object[]{event}));
        }
        jxkxKzbuOlpnPpQt(this.delegate, event);
    }
}

