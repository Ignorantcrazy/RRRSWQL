const path = require('path');
const cleanWebpackPlugin = require('clean-webpack-plugin');
const htmlWebpackPlugin = require('html-webpack-plugin');

module.exports = {
    entry:{
        main:'./src/main.js'
    },
    plugins:[
        new cleanWebpackPlugin(['dist']),
        new htmlWebpackPlugin({
            title: 'RRRSWQL',
            template: 'template/template.html',
            favicon:'./src/AppIcon.ico',
            filename:'main.html',
        })
    ],
    output:{
        filename:'[name].bundle.js',
        path : path.resolve(__dirname,'dist')
    },
    module:{
        rules:[
            {
                test:/\.css$/,
                use:[
                    'style-loader',
                    'css-loader'
                ],
                exclude:/node_module/
            },
            {
                test:/\.(png|svg|jpb|gif)$/,
                use:['file-loader'],
                exclude:/node_module/
            },
            {
              test: /\.(woff|woff2|eot|ttf|otf)$/,
              use: [
                'file-loader'
              ],
              exclude:/node_module/
            }
        ]
    }
};