///
var inputs = [{
  expressionType: 'input',
  name: 'name',
  dataType: 'number',
  rawValue: '10'
}];

function toAny(name, value) {
  return {
    type: 'ExpressionStatement',
    expression: {
      type: 'AssignmentExpression',
      operator: '=',
      left: {
        type: 'MemberExpression',
        computed: false,
        object: {
          type: 'Identifier',
          name: 'input'
        },
        property: {
          type: 'Identifier',
          name: name
        }
      },
      right: {
        type: 'Literal',
        value: value
      }
    }
  };
}

function toNumber(def) {
  return toAny(def.name, parseFloat(def.rawValue));
}

var escodegen = require('escodegen');

inputs.forEach(function(def, index, array) {
  var ast;
  if (def.expressionType === 'input') {
    if (def.dataType === 'number') {
      ast = toNumber(def);
      console.log(escodegen.generate(ast));
    }
  }
});
