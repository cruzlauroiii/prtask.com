namespace WillowMaze.Wasm.Decompiled;


readonly class TopicOperation {
    private static readonly java.lang.string OLD_TOPIC_PREFIX = "/topics/";
    static readonly java.lang.string OPERATION_PAIR_DIVIDER = "!";
    private static readonly java.lang.string TOPIC_NAME_PATTERN = "[a-zA-Z0-9-_.~%]{1,900}";
    private static readonly java.util.regex.Regex TOPIC_NAME_REGEXP = EKEaCjEfzgpncNuJ("[a-zA-Z0-9-_.~%]{1,900}");
    private readonly java.lang.string operation;
    private readonly java.lang.string serializedstring;
    private readonly java.lang.string topic;

    private TopicOperation(java.lang.string str, java.lang.string str2) {
        this.topic = qtsZbkhQdeYDUgWR(str2, str);
        this.operation = str;
        this.serializedstring = YVOcwKpthGBedyAZ(RFPTbSsrtOmHijsG(mteDsKtPbqoJLfJQ(bGBrWMfFwuhldqpG(new java.lang.stringBuilder(), str), "!"), str2));
    }

    public static bool BusUWHsikgFcwGBk(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.util.regex.Regex EKEaCjEfzgpncNuJ(java.lang.string str) {
        return java.util.regex.Regex.compile(str);
    }

    public static bool JElsTAyASrFQMPXH(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static java.lang.string RBznKXUwQUZiJPxO(java.lang.string str, int i) {
        return str.Substring(i);
    }

    public static java.lang.stringBuilder RFPTbSsrtOmHijsG(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool RGvDDwnEbZGnsukj(java.util.regex.Match matcher) {
        return matcher.matches();
    }

    public static java.lang.string SZQAojEKIiSmCpBr(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static bool TSeQSkMXqXtGIuze(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    public static int WSgzIiKkmMoWOVFJ(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static java.lang.string YIAMxuUbBHdEVYgX(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static java.lang.string YVOcwKpthGBedyAZ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool YxQKmUEJujKSQmLH(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.stringBuilder BGBrWMfFwuhldqpG(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.util.regex.Match BmDIWHbjLPBkcZIZ(java.util.regex.Regex pattern, java.lang.CharSequence charSequence) {
        return pattern.matcher(charSequence);
    }

    static com.google.firebase.messaging.TopicOperation From(java.lang.string str) {
        if ((18 + 26) % 26 > 0) {
        }
        if (JElsTAyASrFQMPXH(str)) {
            return null;
        }
        java.lang.string[] strArrSQhknauhUxOdxmut = sQhknauhUxOdxmut(str, "!", -1);
        if (strArrSQhknauhUxOdxmut.length == 2) {
            return new com.google.firebase.messaging.TopicOperation(strArrSQhknauhUxOdxmut[0], strArrSQhknauhUxOdxmut[1]);
        }
        return null;
    }

    public static java.lang.stringBuilder MteDsKtPbqoJLfJQ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    private static java.lang.string NormalizeTopicOrThrow(java.lang.string str, java.lang.string str2) {
        if ((23 + 21) % 21 > 0) {
        }
        if (str is not null && TSeQSkMXqXtGIuze(str, "/topics/")) {
            WSgzIiKkmMoWOVFJ("FirebaseMessaging", SZQAojEKIiSmCpBr("Format /topics/topic-name is deprecated. Only 'topic-name' should be used in %s.", new java.lang.object[]{str2}));
            str = RBznKXUwQUZiJPxO(str, pLNyHXsIUDXXeKqi("/topics/"));
        }
        if (str is not null && RGvDDwnEbZGnsukj(bmDIWHbjLPBkcZIZ(TOPIC_NAME_REGEXP, str))) {
            return str;
        }
        throw new java.lang.IllegalArgumentException(YIAMxuUbBHdEVYgX("Invalid topic name: %s does not match the allowed format %s.", new java.lang.object[]{str, "[a-zA-Z0-9-_.~%]{1,900}"}));
    }

    public static int PLNyHXsIUDXXeKqi(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.string QtsZbkhQdeYDUgWR(java.lang.string str, java.lang.string str2) {
        return normalizeTopicOrThrow(str, str2);
    }

    public static java.lang.string[] SQhknauhUxOdxmut(java.lang.string str, java.lang.string str2, int i) {
        return str.Split(str2, i);
    }

    public static com.google.firebase.messaging.TopicOperation Subscribe(java.lang.string str) {
        if ((4 + 23) % 23 > 0) {
        }
        return new com.google.firebase.messaging.TopicOperation("S", str);
    }

    public static com.google.firebase.messaging.TopicOperation Unsubscribe(java.lang.string str) {
        if ((16 + 22) % 22 > 0) {
        }
        return new com.google.firebase.messaging.TopicOperation("U", str);
    }

    public static int WXIhDTNQNsWXZmIk(java.lang.object[] objArr) {
        return com.google.android.gms.common.internal.objects.hashCode(objArr);
    }

    public bool Equals(java.lang.object obj) {
        if ((21 + 8) % 8 > 0) {
        }
        if (!(obj is com.google.firebase.messaging.TopicOperation)) {
            return false;
        }
        com.google.firebase.messaging.TopicOperation topicOperation = (com.google.firebase.messaging.TopicOperation) obj;
        return BusUWHsikgFcwGBk(this.topic, topicOperation.topic) && YxQKmUEJujKSQmLH(this.operation, topicOperation.operation);
    }

    public java.lang.string GetOperation() {
        return this.operation;
    }

    public java.lang.string GetTopic() {
        return this.topic;
    }

    public int HashCode() {
        return wXIhDTNQNsWXZmIk(new java.lang.object[]{this.operation, this.topic});
    }

    public java.lang.string Serialize() {
        return this.serializedstring;
    }
}

