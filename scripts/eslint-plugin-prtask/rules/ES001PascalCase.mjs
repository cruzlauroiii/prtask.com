const ES001PascalCase = {
  meta: {
    type: "problem",
    messages: {
      notPascalCase: "'{{name}}' should start with an uppercase letter (PascalCase).",
    },
    schema: [],
  },
  create(Context) {
    function IsPascalCase(Name) {
      return /^[A-Z]/.test(Name);
    }

    function CheckName(Node, Name) {
      if (!Name || IsPascalCase(Name)) {
        return;
      }
      Context.report({
        node: Node,
        messageId: "notPascalCase",
        data: { name: Name },
      });
    }

    function CheckParams(Params) {
      for (const Param of Params) {
        if (Param.type === "ObjectPattern" || Param.type === "ArrayPattern") {
          continue;
        }
        if (Param.type === "AssignmentPattern" && Param.left.type === "Identifier") {
          CheckName(Param, Param.left.name);
          continue;
        }
        if (Param.type === "RestElement" && Param.argument.type === "Identifier") {
          CheckName(Param, Param.argument.name);
          continue;
        }
        if (Param.type === "Identifier") {
          CheckName(Param, Param.name);
        }
      }
    }

    return {
      FunctionDeclaration(Node) {
        if (Node.id) {
          CheckName(Node.id, Node.id.name);
        }
      },
      VariableDeclarator(Node) {
        if (Node.id.type === "ObjectPattern" || Node.id.type === "ArrayPattern") {
          return;
        }
        if (Node.id.type === "Identifier" && Node.init && Node.init.type === "MemberExpression") {
          return;
        }
        if (Node.id.type === "Identifier") {
          CheckName(Node.id, Node.id.name);
        }
      },
      ArrowFunctionExpression(Node) {
        CheckParams(Node.params);
      },
      FunctionExpression(Node) {
        CheckParams(Node.params);
      },
    };
  },
};

export default ES001PascalCase;
