const merge = require('webpack-merge');
const uglifyjsPlugin = require('uglifyjs-webpack-plugin');
const common = require('./webpack.common.js');

module.exports = merge(common,{
    devtool:"source-map",
    plugins:[
        new uglifyjsPlugin({
            sourceMap:true
        })
    ]
});