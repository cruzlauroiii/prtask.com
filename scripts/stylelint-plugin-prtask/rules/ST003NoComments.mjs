import stylelint from "stylelint";

const RuleName = "prtask/no-comments";

const Meta = {
  url: "",
};

const RuleFunction = (PrimaryOption) => {
  return (Root, Result) => {
    const ValidOptions = stylelint.utils.validateOptions(Result, RuleName, {
      actual: PrimaryOption,
    });

    if (!ValidOptions) {
      return;
    }

    Root.walkComments((Comment) => {
      if (Comment.text.includes("stylelint-disable")) {
        return;
      }

      stylelint.utils.report({
        message: "Comments are not allowed",
        node: Comment,
        result: Result,
        ruleName: RuleName,
      });
    });
  };
};

RuleFunction.ruleName = RuleName;
RuleFunction.meta = Meta;

export const ST003 = stylelint.createPlugin(RuleName, RuleFunction);
