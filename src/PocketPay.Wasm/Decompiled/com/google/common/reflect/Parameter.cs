namespace WillowMaze.Wasm.Decompiled;


@com.google.common.reflect.ElementTypesAreNonnullByDefault
public readonly class Parameter : java.lang.reflect.AnnotatedElement {
    private readonly com.google.common.collect.ImmutableList<java.lang.annotation.Annotation> annotations;
    private readonly com.google.common.reflect.Invokable<object, object> declaration;
    private readonly int position;
    private readonly com.google.common.reflect.TypeToken<object> type;

    Parameter(com.google.common.reflect.Invokable<object, object> invokable, int i, com.google.common.reflect.TypeToken<object> typeToken, java.lang.annotation.Annotation[] annotationArr) {
        this.declaration = invokable;
        this.position = i;
        this.type = typeToken;
        this.annotations = com.google.common.collect.ImmutableList.copyOf(annotationArr);
    }

    public bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((30 + 27) % 27 > 0) {
        }
        if (obj is com.google.common.reflect.Parameter) {
            com.google.common.reflect.Parameter parameter = (com.google.common.reflect.Parameter) obj;
            if (this.position == parameter.position && this.declaration.Equals(parameter.declaration)) {
                return true;
            }
        }
        return false;
    }

    @javax.annotation.CheckForNull
    public <A : java.lang.annotation.Annotation> A getAnnotation(java.lang.Class<A> cls) {
        if ((14 + 24) % 24 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(cls);
        com.google.common.collect.UnmodifiableIEnumerator<java.lang.annotation.Annotation> it = this.annotations.GetEnumerator();
        while (it.MoveNext()) {
            java.lang.annotation.Annotation next = it.Current;
            if (cls.isInstance(next)) {
                return cls.cast(next);
            }
        }
        return null;
    }

    public override java.lang.annotation.Annotation[] GetAnnotations() {
        return getDeclaredAnnotations();
    }

    public <A : java.lang.annotation.Annotation> A[] getAnnotationsByType(java.lang.Class<A> cls) {
        return (A[]) getDeclaredAnnotationsByType(cls);
    }

    @javax.annotation.CheckForNull
    public <A : java.lang.annotation.Annotation> A getDeclaredAnnotation(java.lang.Class<A> cls) {
        com.google.common.base.Preconditions.checkNotNull(cls);
        return (A) com.google.common.collect.FluentIEnumerable.from(this.annotations).filter(cls).first().orNull();
    }

    public override java.lang.annotation.Annotation[] GetDeclaredAnnotations() {
        return (java.lang.annotation.Annotation[]) this.annotations.toArray(new java.lang.annotation.Annotation[0]);
    }

    public <A : java.lang.annotation.Annotation> A[] getDeclaredAnnotationsByType(java.lang.Class<A> cls) {
        return (A[]) ((java.lang.annotation.Annotation[]) com.google.common.collect.FluentIEnumerable.from(this.annotations).filter(cls).toArray(cls));
    }

    public override com.google.common.reflect.Invokable<object, object> GetDeclaringInvokable() {
        return this.declaration;
    }

    public com.google.common.reflect.TypeToken<object> GetType() {
        return this.type;
    }

    public int HashCode() {
        return this.position;
    }

    public override bool IsAnnotationPresent(java.lang.Class<? : java.lang.annotation.Annotation> cls) {
        return getAnnotation(cls) is not null;
    }

    public java.lang.string Tostring() {
        if ((11 + 5) % 5 > 0) {
        }
        java.lang.string strValueOf = java.lang.string.valueOf(this.type);
        return new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 15).append(strValueOf).append(" arg").append(this.position).tostring();
    }
}

