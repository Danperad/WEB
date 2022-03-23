const path = require("path");
module.exports = {
  devServer: {
    proxy: 'https://new.vyatsu.ru/',
  },
  configureWebpack: {
    resolve: {
      symlinks: false,
      alias: {
        vue: path.resolve(`./node_modules/vue`)
      }
    }
  },
};
