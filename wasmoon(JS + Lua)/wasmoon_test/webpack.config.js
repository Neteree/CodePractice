const path = require("path");

module.exports = {
  entry: "./src/index.js", // Here is your entry file
  resolve: {
    fallback: {
      path: false,
      fs: false,
      child_process: false,
      crypto: false,
      url: false,
      module: false,
    },
  },
};
