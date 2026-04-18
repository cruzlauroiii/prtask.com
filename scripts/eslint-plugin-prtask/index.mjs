import ES001PascalCase from "./rules/ES001PascalCase.mjs";
import ES003NoComments from "./rules/ES003NoComments.mjs";

const PrtaskPlugin = {
  rules: {
    "pascal-case": ES001PascalCase,
    "no-comments": ES003NoComments,
  },
};

export default PrtaskPlugin;
