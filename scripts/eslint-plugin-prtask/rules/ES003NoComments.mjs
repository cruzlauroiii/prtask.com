const ES003NoComments = {
  meta: {
    type: "problem",
    messages: {
      noComments: "Comments are not allowed.",
    },
    schema: [],
  },
  create(Context) {
    return {
      "Program:exit"() {
        const AllComments = Context.sourceCode.getAllComments();
        for (const Comment of AllComments) {
          if (Comment.value.includes("eslint-disable")) {
            continue;
          }
          Context.report({
            node: Comment,
            messageId: "noComments",
          });
        }
      },
    };
  },
};

export default ES003NoComments;
