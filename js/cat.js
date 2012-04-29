var assert = require('assert');

process.stdin.setEncoding('utf8');
process.stdout.setEncoding('utf8');

var input = '';

process.stdin.on('data', function(data) { input += data; });
process.stdin.on('end', function() { handleInput(); });
process.stdin.resume();

function handleInput() {
  var root = JSON.parse(input);
  assert.equal(root.shift(), 'text');

  root.forEach(function(block) {
    var blockType = block.shift();
    var blockAttr = block.shift();

    block.forEach(function(span) {
      var spanType = span.shift();
      assert(span.length, 1);
      var text = span[0];
      process.stdout.write(text);
    });

    process.stdout.write('\n\n');
  });
};
